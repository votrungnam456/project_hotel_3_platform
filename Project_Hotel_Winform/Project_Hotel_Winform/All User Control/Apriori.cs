using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Project_Hotel_Winform.Model;
using Cotur.DataMining.Association;
namespace Project_Hotel_Winform.All_User_Control
{
    public partial class Apriori : UserControl
    {
        ConnectAPI api = new ConnectAPI();
        AprioriAlgorithm aprioriAlgorithm = new AprioriAlgorithm();
        List<string> listString = new List<string>();
        List<int> listInt;
        List<List<int>> transactions;
        public Apriori()
        {
            InitializeComponent();
            loadFieldName();
            loadAprioriData();
        }
        public async void loadFieldName()
        {
            var returnData = api.getAPI("apriori/listFieldName");
            var result = await Task.WhenAll(returnData);
            var data = JsonConvert.DeserializeObject<AprioriFieldName>(result[0]);

            foreach (string item in data.data)
            {
                listString.Add(item.ToString());
            }
        }

        public async void loadAprioriData()
        {
            transactions = new List<List<int>>();
            var returnData = api.getAPI("apriori/listData");
            var result = await Task.WhenAll(returnData);
            var data = JsonConvert.DeserializeObject<listAprioriData>(result[0]);

            foreach (AprioriData item in data.data)
            {
                listInt = new List<int>();
                for (int i = 0; i < listString.Count; i++)
                {
                    if (item.TenKP.Contains(listString[i].ToString()))
                    {
                        listInt.Add(i);
                    }
                    if (item.TenDV.Contains(listString[i].ToString()))
                    {
                        listInt.Add(i);
                    }
                }
                transactions.Add(listInt);
            }
           
        }

        private void btnTuVan_Click(object sender, EventArgs e)
        {

        }
    }
}
