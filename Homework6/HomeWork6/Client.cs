using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace HomeWork5
{


    [Serializable]
    public class Client
    {
        public String Name { get; }
        public String Address { get; }
        public Client(String name, String address)
        {
            Name = name;
            Address = address;
        }
        public Client()
        {
            Name = null;
            Address = null;
        }
        public override string ToString()
        {
            return "姓名:" + Name + "\n" + "收货地址:" + Address;
        }

        public override bool Equals(object obj)
        {
            return obj is Client client &&
                   Name == client.Name &&
                   Address == client.Address;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Address);
        }
    }
}
