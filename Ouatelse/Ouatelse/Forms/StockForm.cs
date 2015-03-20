using Ouatelse.Managers;
using Ouatelse.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ouatelse.Forms
{
    public partial class StockForm : Form
    {
        #region Les attributs de la classe
        /// <summary>
        /// Le produit courant du formulaire
        /// </summary>
        Product product = null;
        List<Store> storeList = null;
        List<Stock> stockList = null;
        int action = 0;
        Stock obj = new Stock();

        /// <summary>
        /// La cohérence entre le formulaire et notre produit
        /// </summary>
        Binding b = new Binding();
        #endregion

        #region Le constructeur de la classe
        /// <summary>
        /// Le constructeur de la classe
        /// </summary>
        /// <param name="obj"></param>
        public StockForm(Product product, int action)
        {
            InitializeComponent();
            this.action = action;
            //Cohérence pour l'affichage des titres
            this.Text = this.label1.Text = this.action == 1 ? "Réapprovisionner " : " Déstocker";
            this.product = product;
            obj.Product = product;
        }
        #endregion

        #region Gestion du chargement de l'affichage du formulaire
        /// <summary>
        /// Chargement de l'affichage du formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StockForm_Load(object sender, EventArgs e)
        {

            //On lie notre objet à notre binding
            this.IdProduct.Text = product.Id.ToString();
            this.NameProduct.Text = product.Name;
            this.Designation.Text = product.Designation;
            loadStores(StoreManager.Instance.All());
        
        }
        #endregion

        #region Chargement des magasins dans la combobox
        /// <summary>
        /// Chargement des magasins dans la comboBox
        /// </summary>
        /// <param name="cities"></param>
        private void loadStores(Store[] stores)
        {
            this.storeList = new List<Store>(stores);
            this.Address.DataSource = storeList;
            this.Address.ValueMember = "Id";
            this.Address.DisplayMember = "Address";
        }
        #endregion

        #region Affichage de la ville et du stock selon l'adresse
        private void Address_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.Address != null)
            {
                this.City.Text = ((Store)this.Address.SelectedItem).City.Name;
                this.IdStore.Text = ((Store)this.Address.SelectedItem).Id.ToString();
                this.stockList = new List<Stock>(StockManager.Instance.Filter("WHERE produits_id = " + this.product.Id + " AND magasin_id = " + ((Store)this.Address.SelectedItem).Id + ";"));
                this.obj.Store = (Store)this.Address.SelectedItem;
                this.obj.Quantity = 0;
                foreach (Stock s in stockList)
                {
                    this.obj.Quantity += s.Quantity;
                }
                this.stockLabel.Text = "En stock : " + this.obj.Quantity;
                return;
            }
            this.City.Text = String.Empty;
        }
        #endregion

        #region Gestion de la validation du formulaire
        private void validateButton_Click(object sender, EventArgs e)
        {

            //On regarde si le mouvement de stock est valide
            if (this.Address == null)
            {
                Utils.Warning("Aucun magasin selectionné");
            }

            else if ((this.action * this.numericQuantity.Value) == 0 || (this.obj.Quantity + (this.action * this.numericQuantity.Value)) < 0)
            {
                Utils.Warning("Quantité selectionnée invalide");
            }

            else
            {
                obj.Quantity = (int) (this.action * this.numericQuantity.Value);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }

        }
        #endregion

        #region Getter du stock en cours
        public Stock getStock()
        {
            return obj;
        }
        #endregion

    }
}
