using Ouatelse.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ouatelse.Models
{
    public class Customer : BaseModel, IModel
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
        public Gender Gender { get; set; }

        public Customer()
        {
            DateOfBirth = DateTime.Now;
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
            this.Address1 = cursor.Read().ToString();
            this.Address2 = cursor.Read().ToString();
            this.PhoneNumber = cursor.Read().ToString();
            this.MobilePhoneNumber = cursor.Read().ToString();
            this.Email = cursor.Read().ToString();
            this.DateOfBirth = DateTime.Parse(cursor.Read().ToString());
            this.Comments = cursor.Read().ToString();
            this.City = CityManager.Instance.Find(cursor.Read().ToString());
            this.Gender = GenderManager.Instance.Find(cursor.Read().ToString());

        }

        public Dictionary<string, string> Fetch()
        {
            Dictionary<string, string> res = new Dictionary<string, string>();
            res.Add("nom", LastName);
            res.Add("prenom", FirstName);
            res.Add("adresse1", Address1);
            res.Add("adresse2", Address2);
            res.Add("fixe", PhoneNumber);
            res.Add("portable", MobilePhoneNumber);
            res.Add("mail", Email);
            res.Add("naissance", DateOfBirth.ToString("yyyy-MM-dd"));
            res.Add("notes", Comments);
            res.Add("villes_id", City.Id.ToString());
            res.Add("civilite_id", Gender.Id.ToString());
            return res;
        }
    }
}
