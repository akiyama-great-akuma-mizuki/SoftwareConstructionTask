using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using OrderSystem;
using System.Collections;
using System.Collections.Generic;

public class INFO
{
    public static List<Product> productList = new List<Product>();
    public INFO()
    {
        if(productList.Count == 0)
        {
            productList.Add(new Product("lemon", 10));
            productList.Add(new Product("suika", 30));
            productList.Add(new Product("guitar", 100));
            productList.Add(new Product("sukiyaki", 100));
            productList.Add(new Product("sushi", 50));
        }
    }
}