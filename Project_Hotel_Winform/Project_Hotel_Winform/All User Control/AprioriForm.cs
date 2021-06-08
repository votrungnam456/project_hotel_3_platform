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
    public partial class AprioriForm : UserControl
    {
        ConnectAPI api = new ConnectAPI();
        AprioriAlgorithm aprioriAlgorithm = new AprioriAlgorithm();
        List<string> listFieldName;
        List<int> listInt;
        List<List<int>> transactions;
        List<typeRoom> listTypeRooms = new List<typeRoom>();
        public AprioriForm()
        {
            InitializeComponent();
            loadCbo();
        }
        public async Task<List<string>> loadFieldName()
        {
            listFieldName = new List<string>();
            var returnData = api.getAPI("apriori/listFieldName");
            var result = await Task.WhenAll(returnData);
            var data = JsonConvert.DeserializeObject<AprioriFieldName>(result[0]);

            foreach (string item in data.data)
            {
                listFieldName.Add(item.ToString());
            }
            return listFieldName;
        }

        public async Task<List<List<int>>> loadAprioriData()
        {
            transactions = new List<List<int>>();
            var returnData = api.getAPI("apriori/listData");
            var result = await Task.WhenAll(returnData);
            var data = JsonConvert.DeserializeObject<listAprioriData>(result[0]);

            foreach (AprioriData item in data.data)
            {
                listInt = new List<int>();
                //Lấy vị trí kiểu phòng trong danh sách của field name
                int index = listFieldName.IndexOf(item.TenKP);
                listInt.Add(index);
                for (int i = 0; i < listFieldName.Count; i++)
                {
                    //if (item.TenKP.Contains(listFieldName[i].ToString()))
                    //{
                    //    listInt.Add(i);
                    //    continue;
                    //}
                    if (item.TenDV.Contains(listFieldName[i].ToString()))
                    {
                        listInt.Add(i);
                    }
                }
                transactions.Add(listInt);
            }
            return transactions;
        }

        public async void loadCbo()
        {
            var returnData = api.getAPI("rooms/typeRooms");
            var result = await Task.WhenAll(returnData);
            var data = JsonConvert.DeserializeObject<listTypeRooms>(result[0]);
            foreach (typeRoom item in data.data)
            {
                listTypeRooms.Add(item);
            }
            cboLoaiPhong.DataSource = listTypeRooms;
            cboLoaiPhong.DisplayMember = "TenKP";
            cboLoaiPhong.ValueMember = "TenKP";
        }
        private async void btnTuVan_Click(object sender, EventArgs e)
        {
            Label labelTrans = new Label();
            labelTrans.Text = "Transactions";
            labelTrans.Left = 20;
            labelTrans.Top = 20;
            string loaiPhong = cboLoaiPhong.SelectedValue.ToString();
            panel1.Controls.Clear();
            DataGridView transDataGridView = new DataGridView();
            transDataGridView.Columns.Add("column", "Item");
            transDataGridView.Columns.Add("column", "Transactions");
            transDataGridView.BackgroundColor = Color.White;
            transDataGridView.Height = 200;
            transDataGridView.Width = 280;
            transDataGridView.Left = 0;
            transDataGridView.Top = 50; 
            List<string> fieldName = await loadFieldName();
            List<List<int>> transactions = await loadAprioriData();
            Apriori apriori = new Apriori(new DataFields(fieldName.Count, transactions, fieldName));
            int count = 0;
            foreach (string a in fieldName)
            {
                transDataGridView.Rows.Add(count, a);
                count++;
            }
            panel1.Controls.Add(labelTrans);
            panel1.Controls.Add(transDataGridView);
            apriori.CalculateCNodes(.22f);

            //foreach (List<int> b in transactions)
            //{
            //    string a = "";
            //    foreach (int c in b)
            //    {
            //        a += c;
            //    }
            //    MessageBox.Show(a);
            //}


            int tableNumber = 1;
            int j = 0;
            int space = 0;
            foreach (var Levels in apriori.EachLevelOfNodes)
            {
                j++;
                if (j % 4 == 0) { space++; j = 1;  }
                Label labelTable = new Label();
                labelTable.Text = "Table " + tableNumber;
                labelTable.Left = 280 * j+20;
                labelTable.Top = 200 * space + 20;
                DataGridView newDataGridView = new DataGridView();
                newDataGridView.Columns.Add("Column", "Item set");
                newDataGridView.BackgroundColor = Color.White;
                newDataGridView.Height = 200;
                newDataGridView.Width = 280;
                newDataGridView.Left = 280 * j;
                newDataGridView.Top = 200 * space + 50;
                string detail;
                //MessageBox.Show("\n-- Table {0} --", table++.ToString());
                foreach (var node in Levels)
                {
                    detail = node.ToDetailedString(apriori.Data);
                    newDataGridView.Rows.Add(detail);
                    //MessageBox.Show(node.ToDetailedString(apriori.Data));
                    //newDataGridView.DataSource = node.ToDetailedString(apriori.Data);
                }
                panel1.Controls.Add(labelTable);
                tableNumber++;
                panel1.Controls.Add(newDataGridView);
            }
            string resultTuVan = "";
            //MessageBox.Show(loaiPhong);
            //Console.WriteLine("\n -- Rules -- \n");
            foreach (var rule in apriori.Rules)
            {
                //MessageBox.Show(rule.ToDetailedString(apriori.Data));

                if (rule.NodeA.ToDetailedString(apriori.Data).Equals(loaiPhong))
                {
                    resultTuVan += "Dịch vụ: " + rule.NodeB.ToDetailedString(apriori.Data) + "Độ tin cậy: " + rule.Confidence * 100 + "%" + Environment.NewLine;
                }
            }
            if (resultTuVan == "")
            {
                MessageBox.Show("Không đủ data để tư vấn");
            }
            else
            {
                MessageBox.Show(resultTuVan, "Tư vấn dịch vụ");
            }
        }
    }
}
