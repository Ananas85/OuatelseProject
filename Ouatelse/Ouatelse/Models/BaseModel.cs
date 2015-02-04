using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Ouatelse.Models
{
    public abstract class BaseModel
    {
        protected static string managerName = "";
        public int Id { get; set; }

        public void ForeignKey(string propertyName, string fieldName)
        {
            Type fieldType = this.GetType().GetProperty(propertyName).GetType();
            string managerName = fieldType.GetProperty("ManagerName").GetValue(this).ToString();
            Type managerType = Type.GetType(managerName);

        }

        public string ManagerName
        {
            get
            {
                return managerName;
            }
        }
    }
}
