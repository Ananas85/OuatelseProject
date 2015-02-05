using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ouatelse
{
    public static class Utils
    {
        public static DialogResult Info(string message, System.Windows.Forms.MessageBoxButtons buttons = System.Windows.Forms.MessageBoxButtons.OK)
        {
            return System.Windows.Forms.MessageBox.Show(message, Application.ProductName, buttons, System.Windows.Forms.MessageBoxIcon.Information);
        }

        public static DialogResult Error(string message, System.Windows.Forms.MessageBoxButtons buttons = System.Windows.Forms.MessageBoxButtons.OK)
        {
            return System.Windows.Forms.MessageBox.Show(message, Application.ProductName, buttons, System.Windows.Forms.MessageBoxIcon.Error);
        }

        public static DialogResult Warning(string message, System.Windows.Forms.MessageBoxButtons buttons = System.Windows.Forms.MessageBoxButtons.OK)
        {
            return System.Windows.Forms.MessageBox.Show(message, Application.ProductName, buttons, System.Windows.Forms.MessageBoxIcon.Warning);
        }

        public static DialogResult Prompt(string message, System.Windows.Forms.MessageBoxIcon icon = System.Windows.Forms.MessageBoxIcon.Question)
        {
            return System.Windows.Forms.MessageBox.Show(message, Application.ProductName, System.Windows.Forms.MessageBoxButtons.YesNo, icon);
        }
    }
}
