using Ouatelse.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Globalization;


namespace Ouatelse.Models
{
    public class Product : BaseModel, IModel, ICloneable
    {
        #region Les attributs de la classe
        /// <summary>
        /// Obligatoire : Le nom du produit
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Obligatoire : La désignation du produit
        /// </summary>
        public string Designation { get; set; }

        /// <summary>
        /// Obligatoire : Le prix d'achat du produit
        /// </summary>
        public float PurchasePrice { get; set; }

        public String PurchasePriceString
        {
            get
            {
                return this.PurchasePrice.ToString();
            }

            set
            {
                this.PurchasePrice = Single.Parse(value);
            }
        }

        /// <summary>
        /// Obligatoire : Le prix de vente du produit
        /// </summary>
        public float SellPrice { get; set; }

        public String SellPriceString
        {
            get
            {
                return this.SellPrice.ToString();
            }

            set
            {
                this.SellPrice = Single.Parse(value);
            }
        }

        /// <summary>
        /// Obligatoire : La TVA du produit
        /// </summary>
        public float TVA { get; set; }

        public String TVAString
        {
            get
            {
                return this.TVA.ToString();
            }

            set
            {
                this.TVA = Single.Parse(value);
            }
        }

        /// <summary>
        /// Obligatoire : Le code EAN du produit
        /// </summary>
        public string EANCode { get; set; }


        /// <summary>
        /// Ce qui permet de valider les données d'un client
        /// </summary>
        public enum ValidationResult { OK, WRONG_NAME, WRONG_DESIGNATION, WRONG_PURCHASEPRICE, WRONG_SELLPRICE, WRONG_TVA, WRONG_EANCODE }
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
            this.Name = cursor.Read().ToString();
            this.Designation = cursor.Read().ToString();
            this.PurchasePrice = Convert.ToSingle(cursor.Read().ToString());
            this.SellPrice = Convert.ToSingle(cursor.Read().ToString());
            this.TVA = Convert.ToSingle(cursor.Read().ToString());
            this.EANCode = cursor.Read().ToString();
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
                {"nom", Name},
                {"designation", Designation},
                {"prix_achat", PurchasePrice.ToString(CultureInfo.CurrentCulture)},
                {"prix_vente", SellPrice.ToString(CultureInfo.CurrentCulture)},
                {"tva", TVA.ToString(CultureInfo.CurrentCulture)},
                {"code_ean", EANCode}
            };
            return res;
        }
        #endregion

        #region Permet de valider les données
        /// <summary>
        /// Permet de valider les données du produit
        /// </summary>
        /// <returns>La liste des champs à corriger</returns>
        public List<ValidationResult> validate()
        {
            List<ValidationResult> response = new List<ValidationResult>();
            if (String.IsNullOrWhiteSpace(this.Name))
            {
                response.Add(ValidationResult.WRONG_NAME);
            }
            if (String.IsNullOrWhiteSpace(this.Designation))
            {
                response.Add(ValidationResult.WRONG_DESIGNATION);
            }
            if (float.IsNaN(this.PurchasePrice) || this.PurchasePrice <= 0)
            {
                response.Add(ValidationResult.WRONG_PURCHASEPRICE);
            }
            if (float.IsNaN(this.SellPrice) || this.SellPrice <= 0)
            {
                response.Add(ValidationResult.WRONG_SELLPRICE);
            }
            if (float.IsNaN(this.TVA) || this.TVA <= 0 || this.TVA >= 100)
            {
                response.Add(ValidationResult.WRONG_TVA);
            }
            if (String.IsNullOrEmpty(this.EANCode))
            {
                response.Add(ValidationResult.WRONG_EANCODE);
            }

            else if (this.EANCode.Length > 13 || this.EANCode.Length < 8)
            {
                response.Add(ValidationResult.WRONG_EANCODE);
            }


            return response;
        }
        #endregion

        #region Utilisation de Clone pour passer un objet par copie
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        #endregion

        public int CurrentStock
        {
            get { return Stock.getCurrentStock(this, Properties.Settings.Default.CurrentStore); }
        }

        public int Sells
        {
            get { return InvoiceProductManager.Instance.Filter("WHERE produits_id = " + this.Id).Sum(p => p.Quantity); }
        }
    }
}
