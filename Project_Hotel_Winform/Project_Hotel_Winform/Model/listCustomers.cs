﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Hotel_Winform.Model
{
    class listCustomers
    {
        List<Customers> Data =  new List<Customers>();

        public List<Customers> data { get => Data; set => Data = value; }
    }
}
