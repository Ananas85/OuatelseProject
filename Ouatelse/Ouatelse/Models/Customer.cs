using Ouatelse.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Drawing.Design;
using System.Runtime.Remoting;
using System.Web.Hosting;


namespace Ouatelse.Models
{
    public class Customer : BaseModel, IModel, ICloneable
    {
        #region Les attributs de la classe
        /// <summary>
        /// Obligatoire : Le nom de famille du client
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Obligatoire : Le prénom du client
        /// </summary>
        public string FirstName { get; set; }

        public virtual string FullName { get { return string.Format("{0} {1}", LastName, FirstName); } }

        /// <summary>
        /// Obligatoire : L'adresse n°1 du client
        /// </summary>
        public string Address1 { get; set; }

        /// <summary>
        /// L'adresse n°2 du client
        /// </summary>
        public string Address2 { get; set; }

        /// <summary>
        /// Le numéro de téléphone fixe du client
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Le numéro de télphone mobile du client
        /// </summary>
        public string MobilePhoneNumber { get; set; }

        /// <summary>
        /// L'email du client
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// La date de naissance du client
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Les notes du clients
        /// </summary>
        public string Comments { get; set; }

        /// <summary>
        /// La ville où habite le client
        /// </summary>
        public City City { get; set; }

        /// <summary>
        /// La civilité du client
        /// </summary>
        public Gender Gender { get; set; }

        /// <summary>
        /// Si le client veut un mail en cas de modification de sa fiche
        /// </summary>
        public bool EmailOnUpdate { get; set; }

        /// <summary>
        /// Représente la relation récupérant les factures du client
        /// </summary>
        public ManyCollection<Invoice> Invoices { get; set; } 
        

        /// <summary>
        /// Ce qui permet de valider les données d'un client
        /// </summary>
        public enum ValidationResult { OK, WRONG_LASTNAME, WRONG_FIRSTNAME, WRONG_ADRESS, WRONG_CITY, WRONG_EMAIL, WRONG_PHONENUMBER, WRONG_MOBILEPHONENUMBER}
        #endregion

        #region Constructeur de la classe
        /// <summary>
        /// Constructeur de la classe
        /// </summary>
        public Customer()
        {
            //Par défaut le client est né aujourd'hui
            DateOfBirth = DateTime.Now;

            Invoices = new ManyCollection<Invoice>(this, InvoiceManager.Instance, "clients_id", "Customer");
        }
        #endregion

        #region Permet d'extraire les données de la base au sein d'un objet
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
            this.EmailOnUpdate = Convert.ToBoolean(cursor.Read());

        }
        #endregion

        #region Ajoute les données de l'entités dans un dictionnaire pour assurer la correspondance entre attributs et colonnes
        /// <summary>
        /// Ajoute les données de l'entités dans un dictionnaire pour assurer la correspondance entre attributs et colonnes
        /// </summary>
        /// <returns> Le dictionnaire </returns>
        public Dictionary<string, string> Fetch()
        {
            Dictionary<string, string> res = new Dictionary<string, string>
            {
                {"nom", LastName},
                {"prenom", FirstName},
                {"adresse1", Address1},
                {"adresse2", Address2},
                {"fixe", PhoneNumber},
                {"portable", MobilePhoneNumber},
                {"mail", Email},
                {"naissance", DateOfBirth.ToString("yyyy-MM-dd")},
                {"notes", Comments},
                {"villes_id", City.Id.ToString()},
                {"civilite_id", Gender.Id.ToString()},
                {"email_modification", Convert.ToInt16(EmailOnUpdate).ToString()}
            };
            return res;
        }
        #endregion

        #region Permet de valider les données
        /// <summary>
        /// Permet de valider les données du client
        /// </summary>
        /// <returns>La liste des champs à corriger</returns>
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
            if (String.IsNullOrWhiteSpace(this.Address1))
            {
                response.Add(ValidationResult.WRONG_ADRESS);
            }
            if (!String.IsNullOrWhiteSpace(this.Email))
            {
                if (!new EmailAddressAttribute().IsValid(this.Email))
                    response.Add(ValidationResult.WRONG_EMAIL);
            }
            if (!String.IsNullOrEmpty(this.PhoneNumber))
            {
                if (this.PhoneNumber.Length != 10)
                    response.Add(ValidationResult.WRONG_PHONENUMBER);
            }
            if (!String.IsNullOrEmpty(this.PhoneNumber))
            {
                if (this.MobilePhoneNumber.Length != 10)
                    response.Add(ValidationResult.WRONG_MOBILEPHONENUMBER);
            }
            return response;
        }
        #endregion

        #region surcharge de la méthode GetHashCode pour pouvoir correctement utiliser Equals
        public override int GetHashCode()
        {
            return this.LastName.GetHashCode() ^ this.FirstName.GetHashCode() ^ this.Address1.GetHashCode() ^ this.City.GetHashCode();
        }
        #endregion

        #region surcharge de la méthode equals
        public override bool Equals(object obj)
        {
            return obj is Customer && this == (Customer)obj;
        }
        #endregion

        #region sucharge de l'opérateur ==
        public static bool operator ==(Customer x, Customer y)
        {
            if ((Object) x == null && (Object) y == null)
                return true;
            if ((Object)y != null)
            {
                return x.LastName == y.LastName && x.FirstName == y.LastName && x.Address1 == y.Address1 && x.City == y.City;
            }
            return false;
        }

        #endregion

        #region surcharge de l'opérateur !=
        public static bool operator !=(Customer x, Customer y)
        {
            return !(x == y);
        }
        #endregion

        #region Utilisation de Clone pour passer un objet par copie
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        #endregion

        #region Surcharge de to String 
        public override string ToString()
        {
            return "ID : " + this.Id.ToString() + Environment.NewLine +
                   "Nom : " + this.LastName + Environment.NewLine +
                   "Prénom :" + this.FirstName + Environment.NewLine +
                   "Address1 : " + this.Address1 + Environment.NewLine +
                   " Gender : " + this.Gender.Name + Environment.NewLine;
        }
        #endregion

        public int NumberOfCompleteInvoices()
        {
            return Invoices.Items.Count(invoice => invoice.IsPaid);
        }

        public double NumberOfExpenseCompleteTotal()
        {
            return Invoices.Items.Where(invoice => invoice.IsPaid).Sum(invoice => invoice.TotalTTC);
        }

        public int NumberOfInCompleteInvoices()
        {
            return Invoices.Items.Count(invoice => !invoice.IsPaid);
        }

        public double NumberOfExpenseUnCompleteTotal()
        {
            return Invoices.Items.Where(invoice => !invoice.IsPaid).Sum(invoice => invoice.TotalTTC);
        }

        public int NumberOfTotalInvoices()
        {
            return Invoices.Items.Length;
        }

        public double NumberOfExpenseTotal()
        {
            return Invoices.Items.Sum(invoice => invoice.TotalTTC);
        }

        public int NumberOfInvoicesCompleteInMonth()
        {
            return Invoices.Items.Count(invoice => invoice.IsPaid && invoice.Date.Month == DateTime.Now.Month);
        }

        public double NumberOfExpenseInMonth()
        {
            return Invoices.Items.Where(invoice => invoice.IsPaid && invoice.Date.Month == DateTime.Now.Month).Sum(invoice => invoice.TotalTTC);
        }

        public int NumberOfInvoicesCompleteInYear()
        {
            return Invoices.Items.Count(invoice => invoice.IsPaid && invoice.Date.Year == DateTime.Now.Year);
        }

        public double NumberOfExpenseInYear()
        {
            return Invoices.Items.Where(invoice => invoice.IsPaid && invoice.Date.Year == DateTime.Now.Year).Sum(invoice => invoice.TotalTTC);
        }



        #region Le client peut prétendre à une réduction si depuis la dernière facture avec réduction il y'a eu au moins 100€ de dépenser
        public bool ReductionAvailable()
        {
            return
                Invoices.Items.Where(invoice => invoice.IsPaid && invoice.Date >=
                                                Invoices.Items.Where(i => i.IsPaid && i.DiscountPercent > 0)
                                                    .OrderByDescending(i => i.Date).First().Date)
                    .Sum(invoice => invoice.TotalTTC) >= 100;
        }
        #endregion

        public Dictionary<Product, int> PreferedProdcuts
        {
            get
            {
                Dictionary<Product, int> res = new Dictionary<Product, int>();
                Invoices.Reload();

                foreach (Invoice invoice in Invoices.Items)
                {
                    invoice.Products.Reload();
                    foreach (InvoiceProduct product in invoice.Products.Items)
                    {
                        if (!res.ContainsKey(product.Product))
                            res.Add(product.Product, 0);
                        res[product.Product] += product.Quantity;
                    }
                }

                return res.OrderByDescending(pair => pair.Value).ToDictionary(pair => pair.Key, pair => pair.Value);
            }
        }
    }
}
