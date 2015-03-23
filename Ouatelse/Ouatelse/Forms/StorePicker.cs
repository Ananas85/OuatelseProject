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

namespace Ouatelse.Forms
{
    public partial class StorePicker : Form
    {
        public StorePicker()
        {
            InitializeComponent();
        }

        private void StorePicker_Load(object sender, EventArgs e)
        {
            foreach (Store store in StoreManager.Instance.All())
            {
                ListViewItem item = this.listView1.Items.Add(store.NameTwoLines);
                item.ImageIndex = 0;
                item.Tag = store;
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = this.listView1.GetItemAt(e.X, e.Y);
            if (item == null)
                return;

            Properties.Settings.Default.CurrentStore = (Store) item.Tag;
            Properties.Settings.Default.Save();
            DialogResult = DialogResult.OK;
        }
    }
}
