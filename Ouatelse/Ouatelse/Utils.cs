using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
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

        public static bool Prompt(string message, System.Windows.Forms.MessageBoxIcon icon = System.Windows.Forms.MessageBoxIcon.Question)
        {
            return System.Windows.Forms.MessageBox.Show(message, Application.ProductName, System.Windows.Forms.MessageBoxButtons.YesNo, icon) == DialogResult.Yes;
        }

        public static bool CheckServer()
        {
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("http://chardan.net"))
                {
                    return true;
                }
            }
            catch
            {
                Utils.Error("Impossible d'effectuer l'opération demandée. Aucune connexion Internet ou serveur hors service");
                return false;
            }
        }

        public static String generatePassword(int length)
        {
            const String alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder password = new StringBuilder();
            Random generator = new Random();
            while(0 < length--)
                password.Append(alphabet[generator.Next(alphabet.Length)]);
            return password.ToString();
        }
    }
}
