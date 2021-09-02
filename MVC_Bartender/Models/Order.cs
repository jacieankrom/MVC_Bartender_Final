using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Bartender.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int OrderNum { get; set; }
        public Boolean Ready { get; set; }
    }
}
