using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace OrderSystem
{


    [Serializable]
    public class Client
    {
        public int ClientId { get; set; }
        public String Name { get; set; }
        public String Address { get; set; }
        
        public Client(String name, String address)
        {
            this.Name = name;
            this.Address = address;
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
            var hashCode = -1876505879;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Address);
            return hashCode;
        }
    }
}
