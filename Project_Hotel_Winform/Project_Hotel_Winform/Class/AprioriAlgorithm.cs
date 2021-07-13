using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cotur.DataMining.Association;
namespace Project_Hotel_Winform
{
    class AprioriAlgorithm
    {
        public void writeApriori(Apriori aP, float minimunSupport)
        {
            aP.CalculateCNodes(minimunSupport);
            //int table = 1;
            //foreach (var Levels in aP.EachLevelOfNodes)
            //{
            //    Console.WriteLine("\n-- Table {0} --", table++);
            //    foreach (var node in Levels)
            //    {
            //        Console.WriteLine(node.ToDetailedString(aP.Data));
            //    }
            //}

            //Console.WriteLine("\n -- Rules -- \n");
            foreach (var rule in aP.Rules)
            {

                if (rule.NodeA.ToDetailedString(aP.Data) == "Đôi")
                {
                    Console.WriteLine(rule.ToDetailedString(aP.Data));
                }
            }
            //Console.WriteLine(aP.Data.ToString());
        }
        public Apriori Exam1()
        {
            List<string> fieldNames = new List<string>()
            {
                "Đơn","Đôi","Đơn - VIP","Đôi - VIP","Dịch vụ đặt taxi","Ăn sáng","Dịch vụ đặt vé máy bay, tour du lịch"
            };

            List<List<int>> Transactions = new List<List<int>>()
            {
                new List<int>{0,4},
                new List<int>{1,6,4},
                new List<int>{1,5},
                new List<int>{3,6},
                new List<int>{0,5},
                new List<int>{2,4,5},
                new List<int>{2,4},
                new List<int>{2,4},
                new List<int>{1,6,5}
            };
            Apriori myApriori = new Apriori(
                new DataFields(fieldNames.Count, Transactions, fieldNames));
            return myApriori;
        }
    }
}
