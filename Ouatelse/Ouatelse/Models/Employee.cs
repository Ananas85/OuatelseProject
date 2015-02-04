using Ouatelse.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ouatelse.Models
{
    public class Employee : BaseModel, IModel
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
        public Country Nationality { get; set; }
        public Role Role { get; set; }
        public Store Store { get; set; }

        public Employee()
        {

        }

        public void Hydrate(object[] data)
        {
            ArrayCursor<object> cursor = new ArrayCursor<object>(data);
            Id = Int32.Parse(cursor.Read().ToString());
            LastName = cursor.Read().ToString();
            FirstName = cursor.Read().ToString();
            Username = cursor.Read().ToString();
            Password = cursor.Read().ToString();
            Address1 = cursor.Read().ToString();
            Address2 = cursor.Read().ToString();
            PhoneNumber = cursor.Read().ToString();
            MobilePhoneNumber = cursor.Read().ToString();
            Email = cursor.Read().ToString();
            DateOfBirth = DateTime.Parse(cursor.Read().ToString());
            Comments = cursor.Read().ToString();
            City = CityManager.Instance.Find(cursor.Read().ToString());
        }
    }
}
