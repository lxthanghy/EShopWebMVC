using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EShopWebMVC.Models
{
    public class Product
    {
        private int productID;
        private string productName;
        private int categoryID;
        private int unitPrice;
        private int quantity;
        public int ProductID { get => productID; set => productID = value; }
        public string ProductName { get => productName; set => productName = value; }
        public int CategoryID { get => categoryID; set => categoryID = value; }
        public int UnitPrice { get => unitPrice; set => unitPrice = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }
}