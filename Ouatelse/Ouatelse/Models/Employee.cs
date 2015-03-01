using Ouatelse.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ouatelse.Models
{
    public class Employee : BaseModel, IModel
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string PhoneNumber { get; set; }
        public string MobilePhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Comments { get; set; }
        public City City { get; set; }
        public Role Role { get; set; }
        public Store Store { get; set; }
        public Gender Gender { get; set; }
        public bool EmailOnUpdate { get; set; }
        public enum ValidationResult { OK, WRONG_LASTNAME, WRONG_FIRSTNAME, WRONG_USERNAME, WRONG_PASSWORD, WRONG_ADRESS, WRONG_CITY, WRONG_ROLE, WRONG_STORE, WRONG_EMAIL, WRONG_PHONENUMBER, WRONG_MOBILEPHONENUMBER, ALREADY_USED_MAIL, ALREADY_USED_USERNAME }

        public Employee()
        {
            DateOfBirth = DateTime.Now;
            this.EmailOnUpdate = false;
        }

        /// <summary>
        /// Permet d'hydrater l'objet
        /// </summary>
        /// <param name="data"></param>
        public void Hydrate(object[] data)
        {
            ArrayCursor<object> cursor = new ArrayCursor<object>(data);
            this.Id = Int32.Parse(cursor.Read().ToString());
            this.LastName = cursor.Read().ToString();
            this.FirstName = cursor.Read().ToString();
            this.Username = cursor.Read().ToString();
            this.Password = cursor.Read().ToString();
            this.Address1 = cursor.Read().ToString();
            this.Address2 = cursor.Read().ToString();
            this.PhoneNumber = cursor.Read().ToString();
            this.MobilePhoneNumber = cursor.Read().ToString();
            this.Email = cursor.Read().ToString();
            this.DateOfBirth = DateTime.Parse(cursor.Read().ToString());
            this.Comments = cursor.Read().ToString().Replace(@"\'", "'");
            this.City = CityManager.Instance.Find(cursor.Read().ToString());
            this.Role = RoleManager.Instance.Find(cursor.Read().ToString());
            this.Store = StoreManager.Instance.Find(cursor.Read().ToString());
            this.Gender = GenderManager.Instance.Find(cursor.Read().ToString());
            this.EmailOnUpdate = bool.Parse(cursor.Read().ToString());

        }

        public Dictionary<string, string> Fetch()
        {
            Dictionary<string, string> res = new Dictionary<string, string>
            {
                {"nom", LastName},
                {"prenom", FirstName},
                {"identifiant", Username},
                {"mot_de_passe", Password},
                {"adresse1", Address1},
                {"adresse2", Address2},
                {"fixe", PhoneNumber},
                {"portable", MobilePhoneNumber},
                {"mail", Email},
                {"naissance", DateOfBirth.ToString("yyyy-MM-dd")},
                {"notes", Comments},
                {"villes_id", City.Id.ToString()},
                {"roles_id", Role.Id.ToString()},
                {"magasin_id", Store.Id.ToString()},
                {"civilite_id", Gender.Id.ToString()},
                {"email_modification", Convert.ToInt16(EmailOnUpdate).ToString()}
            };
            return res;
        }
        public List<ValidationResult> validate()
        {
            List<ValidationResult> response = new List<ValidationResult>();
            if (this.City == null)
            {
                response.Add(ValidationResult.WRONG_CITY);
            }
            if (String.IsNullOrWhiteSpace(this.FirstName))
            {
                response.Add(ValidationResult.WRONG_FIRSTNAME);
            }
            if (String.IsNullOrWhiteSpace(this.LastName))
            {
                response.Add(ValidationResult.WRONG_LASTNAME);
            }
            if (!String.IsNullOrWhiteSpace(this.Username))
            {
                if (EmployeeManager.Instance.Filter("WHERE identifiant = \"" + this.Username + "\"").Length >= 1)
                    response.Add(ValidationResult.ALREADY_USED_USERNAME);
            }
            else
                response.Add(ValidationResult.WRONG_USERNAME);
            if (String.IsNullOrWhiteSpace(this.Address1))
            {
                response.Add(ValidationResult.WRONG_ADRESS);
            }
            if (String.IsNullOrWhiteSpace(this.Role.Name))
            {
                response.Add(ValidationResult.WRONG_ROLE);
            }
            if (String.IsNullOrWhiteSpace(this.Store.Name))
            {
                response.Add(ValidationResult.WRONG_STORE);
            }
            if (!String.IsNullOrWhiteSpace(this.Email))
            {
                if (!new EmailAddressAttribute().IsValid(this.Email))
                    response.Add(ValidationResult.WRONG_EMAIL);
                else
                    if (EmployeeManager.Instance.Filter("WHERE mail = \"" + this.Email + "\"").Length >= 1)
                        response.Add(ValidationResult.ALREADY_USED_MAIL);
            }
            if (!String.IsNullOrWhiteSpace(this.PhoneNumber))
            {
                if(this.PhoneNumber.Length != 10)
                    response.Add(ValidationResult.WRONG_PHONENUMBER);
            }
            if (!String.IsNullOrWhiteSpace(this.MobilePhoneNumber))
            {
                if (this.MobilePhoneNumber.Length != 10)
                    response.Add(ValidationResult.WRONG_MOBILEPHONENUMBER);
            }
            return response;
        }
    }
}
