using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebKeyBoardShop.Models
{
    public class KeyBoard
    {
        public int Id { get; set; }
        [Required]
        [StringLength(60)]
        public string Name { get; set; }
        [Required]
        public int GuaranteeTime { get; set; }
        [Required]
        public int Price { get; set; }
    }
}
