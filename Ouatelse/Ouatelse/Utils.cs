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
                using (var stream = client.OpenRead("http://www.google.com"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static string RemoveDiacritics(string text)
        {
            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }
    }
}
