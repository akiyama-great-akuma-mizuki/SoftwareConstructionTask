using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork5
{
    class Client
    {
        public String Name { get; }
        public String Address { get; }
        public Client(String name, String address)
        {
            Name = name;
            Address = address;
        }
        public override string ToString()
        {
            return "姓名:" + Name + "\n" + "收货地址:" + Address;
        }
    }
}
