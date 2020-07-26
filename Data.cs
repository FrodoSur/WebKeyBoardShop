using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebKeyBoardShop.Models;

namespace WebKeyBoardShop
{
    public class Data
    {
        public static void Initialize(SellContext context)
        {
            if (!context.KeyBoards.Any())
            {
                context.KeyBoards.AddRange(
                    new KeyBoard
                    {
                        name = "Razer BlackWidow ",
                        guaranteeTime = 3,
                        price = 9900
                    },
                    new KeyBoard
                    {
                        name = "Oklick 980G",
                        guaranteeTime = 2,
                        price = 2890
                    },
                    new KeyBoard
                    {
                        name = "Corsair K55 RGB",
                        guaranteeTime = 5,
                        price = 3190 
                    }
                );
                context.SaveChanges();
            }
        }
    }
}

