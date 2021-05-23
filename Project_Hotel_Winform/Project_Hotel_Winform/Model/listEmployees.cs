using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Hotel_Winform.Model
{
    public class listEmployees
    {
        List<Employee> Data = new List<Employee>();

        public List<Employee> data { get => Data; set => Data = value; }
    }
}
