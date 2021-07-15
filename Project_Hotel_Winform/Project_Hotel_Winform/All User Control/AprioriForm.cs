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
        // Khởi tạo các biến cần thiết
        ConnectAPI api = new ConnectAPI();
        //AprioriAlgorithm aprioriAlgorithm = new AprioriAlgorithm();
        List<string> listFieldName;
        List<int> listInt;
        List<List<int>> transactions;
        List<typeRoom> listTypeRooms = new List<typeRoom>();
        public AprioriForm()
        {
            InitializeComponent();
            loadCbo();
        }
        // lấy các Field apiori từ database
        public async Task<List<string>> loadFieldName()
        {
            listFieldName = new List<string>();
            var returnData = api.getAPI("apriori/listFieldName");
            var result = await Task.WhenAll(returnData);
            var data = JsonConvert.DeserializeObject<aprioriFieldName>(result[0]);

            foreach (string item in data.data)
            {
                listFieldName.Add(item.ToString());
            }
            return listFieldName;
        }
        // lấy dữ liệu từ các giao dịch cũ của các khách hàng từ datbase thành data cho thuật toán
        public async Task<List<List<int>>> loadAprioriData(string maKP)
        {

            transactions = new List<List<int>>();
            // gọi api
            var returnData = api.getAPI("apriori/listData/"+maKP );
            var result = await Task.WhenAll(returnData);
            var data = JsonConvert.DeserializeObject<listAprioriData>(result[0]);
            // xử lý data đươc trả về từ api
            foreach (aprioriData item in data.data)
            {
                listInt = new List<int>();
                //Lấy vị trí kiểu phòng trong danh sách của field name
                int index = listFieldName.IndexOf(item.TenKP);
                listInt.Add(index);
                for (int i = 0; i < listFieldName.Count; i++)
                {
                    if (item.TenDV.Contains(listFieldName[i].ToString()))
                    {
                        listInt.Add(i);
                    }
                }
                transactions.Add(listInt);
            }
            return transactions;
        }
        // Load combobox
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
            cboLoaiPhong.ValueMember = "MaKP";
        }
        private async void btnTuVan_Click(object sender, EventArgs e)
        {
            //Tạo các label để chứa các table từ thuật toán
            Label labelTrans = new Label();
            labelTrans.Text = "Transactions";
            labelTrans.Left = 20;
            labelTrans.Top = 20;
            string loaiPhong = cboLoaiPhong.SelectedValue.ToString();
            string tenLoaiPhong = cboLoaiPhong.Text.ToString();
            panel1.Controls.Clear();
            DataGridView transDataGridView = new DataGridView();
            transDataGridView.Columns.Add("column", "Item");
            transDataGridView.Columns.Add("column", "Transactions");
            transDataGridView.BackgroundColor = Color.White;
            transDataGridView.Height = 200;
            transDataGridView.Width = 280;
            transDataGridView.Left = 0;
            transDataGridView.Top = 50; 
            // khởi tạo các biến để lưu trữ từ các function
            List<string> fieldName = await loadFieldName();
            List<List<int>> transactions = await loadAprioriData(loaiPhong);
            // thực hiện apriori
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

            // Hiện các label chứa table kết quả của thuật toán
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
                foreach (var node in Levels)
                {
                    detail = node.ToDetailedString(apriori.Data);
                    newDataGridView.Rows.Add(detail);
                }
                panel1.Controls.Add(labelTable);
                tableNumber++;
                panel1.Controls.Add(newDataGridView);
            }
            string resultTuVan = "";
            // Show message box ra kết quả
            foreach (var rule in apriori.Rules)
            {
                //MessageBox.Show(rule.ToDetailedString(apriori.Data));

                if (rule.NodeA.ToDetailedString(apriori.Data).Equals(tenLoaiPhong))
                {
                    resultTuVan += "Dịch vụ: " + rule.NodeB.ToDetailedString(apriori.Data) + " Độ tin cậy: " + rule.Confidence * 100 + "% " + Environment.NewLine;
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
