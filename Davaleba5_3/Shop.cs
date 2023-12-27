using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Davaleba5_3
{
    internal class Shop
    {
        public string _name;
        public string _address;
        public string _description;
        public string _number;
        public string _email;

        public void Shop1(string name, string address, string description, string number, string email)
        {
            name = _name;
            address = _address;
            description = _description;
            number = _number;
            email = _email;
        }

        public void ShowShop1()
        {
            Console.WriteLine($"Name: {_name}\nAddress: {_address}\nDescription: {_description}\nNumber: {_number}\nEmail: {_email}");
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string value)
        {
            _name = value;
        }

        public string GetAddress()
        {
            return _address;
        }

        public void SetAddress(string value)
        {
            _address = value;
        }

        public string GetDescription()
        {
            return _description;
        }

        public void SetDescription(string value)
        {
            _description = value;
        }

        public string GetNumber()
        {
            return _number;
        }

        public void SetNumber(string value)
        {
            _number = value;
        }

        public string GetEmail()
        {
            return _email;
        }

        public void SetEmail(string value)
        {
            _email = value;
        }
    }
}
