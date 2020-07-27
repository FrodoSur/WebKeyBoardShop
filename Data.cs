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
                        Name = "Razer BlackWidow ",
                        GuaranteeTime = 3,
                        Price = 9900
                    },
                    new KeyBoard
                    {
                        Name = "Oklick 980G",
                        GuaranteeTime = 2,
                        Price = 2890
                    },
                    new KeyBoard
                    {
                        Name = "Corsair K55 RGB",
                        GuaranteeTime = 5,
                        Price = 3190 
                    }
                );
                context.SaveChanges();
            }
        }
    }
}

