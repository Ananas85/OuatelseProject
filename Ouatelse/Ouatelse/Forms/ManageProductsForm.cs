using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Ouatelse.Managers;
using Ouatelse.Models;
using Ouatelse.Forms;

namespace Ouatelse
{
    /// <summary>
    /// Classe qui permet de gérer l'ensemble des clients de la base de données
    /// </summary>
    public partial class ManageProductsForm : Form
    {
        Product currentProduct = null;
        string lastColumnClicked = string.Empty;
        string order = string.Empty;
        #region Constructeur de la classe
        /// <summary>
        /// Constructeur de la classe
        /// </summary>
        public ManageProductsForm()
        {
            InitializeComponent();
            //Appelle de la méthode pour remplir les données dans le listView
            Reload(ProductManager.Instance.All());
        }
        #endregion

        #region Méthode pour le rechargement du listView
        /// <summary>
        /// Méthode qui gère le rechargement du listView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Reload(object sender, EventArgs e)
        {
            //Si c'est vide ça recharge tous les produits
            Reload(ProductManager.Instance.Filter("WHERE nom LIKE '" + searchBox.Text + "%' OR designation LIKE '" + searchBox.Text + "%';"));
        }
        #endregion

        #region Liaison des données au listView
        /// <summary>
        /// Méthode pour gérer le chargement des données de la base
        /// </summary>
        /// <param name="productArray">La liste des produits à afficher</param>
        private void Reload(Product[] productArray)
        {
            //Nettoyage de la listView
            this.productListView.Items.Clear();

            //Affichage du nombre de produits
            this.ProductsNumber.Text = productArray.Length.ToString();

            //Orthographe correcte selon le nombre
            if (productArray.Length > 1)
                this.ProductsNumber.Text += " produits";
            else
                this.ProductsNumber.Text += " produit";

            //Recherche du nombre total de produits
            //this.ProductsNumber.Text += " " + ProductManager.Instance.Count().ToString();


            //Gestion de la couleur alternée entre les lignes
            bool alternativeColor = false;

            //On parcourt les produits
            foreach (Product p in productArray)
            {
                //Création d'un nouvelle ligne commencant par l'identifiant puis ajout des autres colonnes
                ListViewItem products = this.productListView.Items.Add(p.Id.ToString());
                products.SubItems.Add(p.Name.ToString());
                products.SubItems.Add(p.Designation.ToString());
                products.SubItems.Add(p.PurchasePrice.ToString());
                products.SubItems.Add(p.SellPrice.ToString());
                products.SubItems.Add(p.TVA.ToString());
                products.SubItems.Add(p.EANCode.ToString());
                products.SubItems.Add(Stock.getCurrentStock(p, Properties.Settings.Default.CurrentStore).ToString());

                //Liaison de la ligne à l'objet
                products.Tag = p;

                //Gestion des couleurs
                if (alternativeColor)
                {
                    products.BackColor = Color.WhiteSmoke;
                }
                alternativeColor = !alternativeColor;
            }


            Product[] allP
                = ProductManager.Instance.All();

            Product best = allP[0];
            Product worst = allP[0];

            foreach (Product p in allP.Where(p => p.Sells > best.Sells))
            {
                best = p;
            }

            foreach (Product p in allP.Where(p => p.Sells < worst.Sells))
            {
                worst = p;
            }
            this.bestProduct.Text = best.Name;
            this.lessProduct.Text = worst.Name;


        }
        #endregion

        #region Édition d'un nouveau produit
        /// <summary>
        /// Edition d'un produit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param> 
        private void NewProduct_Click(object sender, EventArgs e)
        {
            ProductsForm p = new ProductsForm(new Product());
            if (p.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;
                ProductManager.Instance.Save(p.getProduct());
                Reload(ProductManager.Instance.All());
                currentProduct = p.getProduct();
                Utils.Info("Nouveau produit ajouté");
                return;
        }
        #endregion

        #region Gestion du click qui permet de sélectionner un produit
        /// <summary>
        /// Gestion du click qui permet de sélectionner un produit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void productListView_MouseClick(object sender, MouseEventArgs e)
        {
            //On récupère le produit correspondant à la ligne
            ListViewItem item = this.productListView.GetItemAt(e.X, e.Y);
            if (item == null)
            {
                currentProduct = null;
                return;
            }
            currentProduct = (Product)item.Tag;
        }
        #endregion

        #region Gestion du click sur le bouton modifier
        /// <summary>
        /// Gestion du click sur le bouton modifier pour le produit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModifyProduct_Click(object sender, EventArgs e)
        {
            if (currentProduct != null)
            {
                ModifyProduct();
                return;
            }
            Utils.Warning("Vous n'avez pas sélectionné de produit");
        }
        #endregion

        #region Gestion du click sur les boutons réapprovisionner/déstoker
        /// <summary>
        /// Gestion du click sur le bouton réapprovisionner pour le produit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RestockProduct_Click(object sender, EventArgs e)
        {
            if (currentProduct != null)
            {
                NewStock(currentProduct, 1);
                return;
            }
            Utils.Warning("Vous n'avez pas sélectionné de produit");
        }

        /// <summary>
        /// Gestion du click sur le bouton déstocker pour le produit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DestockProduct_Click(object sender, EventArgs e)
        {
            if (currentProduct != null)
            {
                NewStock(currentProduct, -1);
                return;
            }
            Utils.Warning("Vous n'avez pas sélectionné de produit");
        }
        #endregion

        #region Édition d'un nouveau stock
        /// <summary>
        /// Edition d'un stock
        /// </summary>
        /// <param name="p"></param>
        /// <param name="action"></param> 
        private void NewStock(Product p, int action)
        {
            StockForm s = new StockForm((Product)currentProduct.Clone(), action);
            if (s.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;
            StockManager.Instance.Save(s.getStock());
            Reload(ProductManager.Instance.All());
            Utils.Info("Stock du produit modifié");
            return;
        }
        #endregion

        #region  Gestion du double click pour modifier un produit
        /// <summary>
        /// Gestion du double click pour modifier un produit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void productListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (currentProduct != null)
            {
                ModifyProduct();
                return;
            }
            Utils.Warning("Vous n'avez pas sélectionné de produit");
        }
        #endregion

        #region Gestion de la modification d'un produit
        /// <summary>
        /// Edition d'un produit
        /// </summary>
        private void ModifyProduct()
        {
            //Passage d'un objet par copie
            ProductsForm p = new ProductsForm((Product)currentProduct.Clone());
            if (p.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;
            if (currentProduct != p.getProduct())
            {
                ProductManager.Instance.Save(p.getProduct());
                Reload(ProductManager.Instance.All());
                currentProduct = p.getProduct();
                return;
            }
            Utils.Info("Aucune modification apportée au produit");
            return;

        }
        #endregion

        #region Suppression d'un produit
        /// <summary>
        /// Suppression d'un produit
        /// </summary>
        private bool DeleteProduct()
        {
            return ProductManager.Instance.Delete(currentProduct);
        }
        #endregion

        #region Gestion du bouton Supprimer
        /// <summary>
        /// Gestion de la suppression d'un produit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteProduct_Click(object sender, EventArgs e)
        {
            if (currentProduct != null)
            {
                if (Utils.Prompt("Voulez-vous vraiment supprimer " + currentProduct.Name + " ? "))
                    if (DeleteProduct())
                    {
                        Reload(ProductManager.Instance.All());
                        Utils.Info("Produit supprimé avec succès");
                    }
            }
        }
        #endregion

        #region Gestion des tris sur les colonnes
        private void ProductListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            switch (this.productListView.Columns[e.Column].Name)
            {
                case "id":
                    if ( this.lastColumnClicked == "id"){
                        if (this.order == "ASC")
                            this.order = "DESC";
                        else
                            this.order = "ASC";
                    }
                    else
                    {
                        this.order = "ASC";
                    }
                    this.Reload(ProductManager.Instance.Filter("WHERE nom LIKE '" + searchBox.Text + "%' OR designation LIKE '" + searchBox.Text + "%' ORDER BY id " + this.order));
                    this.lastColumnClicked = "id";
                    break;
                case "nom":
                    if (this.lastColumnClicked == "nom")
                    {
                        if (this.order == "ASC")
                            this.order = "DESC";
                        else
                            this.order = "ASC";
                    }
                    else
                    {
                        this.order = "ASC";
                    }
                    this.Reload(ProductManager.Instance.Filter("WHERE nom LIKE '" + searchBox.Text + "%' OR designation LIKE '" + searchBox.Text + "%' ORDER BY id " + this.order));
                    this.lastColumnClicked = "nom";
                    break;
                case "designation":
                    if (this.lastColumnClicked == "designation")
                    {
                        if (this.order == "ASC")
                            this.order = "DESC";
                        else
                            this.order = "ASC";
                    }
                    else
                    {
                        this.order = "ASC";
                    }
                    this.Reload(ProductManager.Instance.Filter("WHERE nom LIKE '" + searchBox.Text + "%' OR designation LIKE '" + searchBox.Text + "%' ORDER BY id " + this.order));
                    this.lastColumnClicked = "designation";
                    break;
                case "prixAchat":
                    if (this.lastColumnClicked == "prixAchat")
                    {
                        if (this.order == "ASC")
                            this.order = "DESC";
                        else
                            this.order = "ASC";
                    }
                    else
                    {
                        this.order = "ASC";
                    }
                    this.Reload(ProductManager.Instance.Filter("WHERE nom LIKE '" + searchBox.Text + "%' OR designation LIKE '" + searchBox.Text + "%' ORDER BY id " + this.order));
                    this.lastColumnClicked = "prixAchat";
                    break;
                case "prixVente":
                    if (this.lastColumnClicked == "prixVente")
                    {
                        if (this.order == "ASC")
                            this.order = "DESC";
                        else
                            this.order = "ASC";
                    }
                    else
                    {
                        this.order = "ASC";
                    }
                    this.Reload(ProductManager.Instance.Filter("WHERE nom LIKE '" + searchBox.Text + "%' OR designation LIKE '" + searchBox.Text + "%' ORDER BY id " + this.order));
                    this.lastColumnClicked = "prixVente";
                    break;
                case "tva":
                    if (this.lastColumnClicked == "tva")
                    {
                        if (this.order == "ASC")
                            this.order = "DESC";
                        else
                            this.order = "ASC";
                    }
                    else
                    {
                        this.order = "ASC";
                    }
                    this.Reload(ProductManager.Instance.Filter("WHERE nom LIKE '" + searchBox.Text + "%' OR designation LIKE '" + searchBox.Text + "%' ORDER BY id " + this.order));
                    this.lastColumnClicked = "tva";
                    break;
                case "ean":
                    if (this.lastColumnClicked == "ean")
                    {
                        if (this.order == "ASC")
                            this.order = "DESC";
                        else
                            this.order = "ASC";
                    }
                    else
                    {
                        this.order = "ASC";
                    }
                    this.Reload(ProductManager.Instance.Filter("WHERE nom LIKE '" + searchBox.Text + "%' OR designation LIKE '" + searchBox.Text + "%' ORDER BY id " + this.order));
                    this.lastColumnClicked = "ean";
                    break;
            }
        }
        #endregion

        private void ModifierCeProduitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifyProduct();
        }

        private void SupprimerCeProduitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentProduct != null)
            {
                if (Utils.Prompt("Voulez-vous vraiment supprimer " + currentProduct.Name + " ? "))
                    if (DeleteProduct())
                    {
                        Reload(ProductManager.Instance.All());
                        Utils.Info("Produit supprimé avec succès");
                    }
            }
        }

        private void ProductListView_ItemActivate(object sender, EventArgs e)
        {
            ListViewItem item = ((ListView)sender).SelectedItems[0];
            if (item == null)
            {
                currentProduct = null;
                return;
            }
            currentProduct = (Product)item.Tag;
        }
    }
}