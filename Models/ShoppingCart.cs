using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebKeyBoardShop.Models
{
    public class ShoppingCart
    {
        public int ShoppingCartId { get; set; }
        public string User { get; set; } 
        public string Address { get; set; }  

        public int KeyBoardId { get; set; } 
        public KeyBoard KeyBoard { get; set; }
    }
}
