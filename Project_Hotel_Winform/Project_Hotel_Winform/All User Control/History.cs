using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Project_Hotel_Winform.Model;
using System.Globalization;

namespace Project_Hotel_Winform.All_User_Control
{
    public partial class History : UserControl
    {
        ConnectAPI api = new ConnectAPI();
        List<historyBookingRoom> lstHistoryBookingRoom;
        List<historyService> lsHhistoryServices;
        List<historyBill> lstHistoryBills;
        public History()
        {
            InitializeComponent();
            loadLichSuThuePhong();
            loadLichSuDichVu();
            loadHoaDonThanhToan();
        }

        public async void loadLichSuThuePhong()
        {
            lstHistoryBookingRoom = new List<historyBookingRoom>();
            var returnData = api.getAPI("history/historyBookingRoom");
            var result = await Task.WhenAll(returnData);
            //setting để jsonconvert nhận null
            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore
            };
            var data = JsonConvert.DeserializeObject<listHistoryBookingRoom>(result[0], settings);
            foreach (historyBookingRoom item in data.data)
            {

                item.Ngayden = DateTime.ParseExact(item.Ngayden.AddDays(1).ToString("dd/MM/yyyy"),"dd/MM/yyyy", CultureInfo.InvariantCulture);
                item.Ngaydi = DateTime.ParseExact(item.Ngaydi.AddDays(1).ToString("dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                lstHistoryBookingRoom.Add(item);
            }

            GridViewThuePhong.DataSource = lstHistoryBookingRoom;
        }
        public async void loadLichSuDichVu()
        {
            lsHhistoryServices = new List<historyService>();
            var returnData = api.getAPI("history/historyService");
            var result = await Task.WhenAll(returnData);

            var data = JsonConvert.DeserializeObject<listHistoryService>(result[0]);
            foreach (historyService item in data.data)
            {
                item.NgayLap = DateTime.ParseExact(item.NgayLap.AddDays(1).ToString("dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                lsHhistoryServices.Add(item);
            }

            GridViewService.DataSource = lsHhistoryServices;
            GridViewService.Columns[0].Visible = false;
        }
        public async void loadHoaDonThanhToan()
        {
            lstHistoryBills = new List<historyBill>();
            var returnData = api.getAPI("history/historyBill");
            var result = await Task.WhenAll(returnData);

            var data = JsonConvert.DeserializeObject<listHistoryBill>(result[0]);
            foreach (historyBill item in data.data)
            {
                item.NgayThanhToan = DateTime.ParseExact(item.NgayThanhToan.AddDays(1).ToString("dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                lstHistoryBills.Add(item);
            }

            GridViewBill.DataSource = lstHistoryBills;
            GridViewBill.Columns[0].Visible = false;
            GridViewBill.Columns[1].Visible = false;
            GridViewBill.Columns[7].Visible = false;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GridViewBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GridViewService_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void btnSearchHistoryRoomsRental_Click(object sender, EventArgs e)
        {
            try
            {
                lstHistoryBookingRoom = new List<historyBookingRoom>();
                GridViewThuePhong.Columns.Clear();
                if (txtSearchHistoryRoomRental.Text.Trim() == "")
                {
                    loadLichSuThuePhong();
                    return;
                }
                string filter = txtSearchHistoryRoomRental.Text.Trim();
                var returnData = api.getAPI("history/historyBookingRoom/search/"+filter);
                var result = await Task.WhenAll(returnData);
                //setting để jsonconvert nhận null
                var settings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    MissingMemberHandling = MissingMemberHandling.Ignore
                };
                var data = JsonConvert.DeserializeObject<listHistoryBookingRoom>(result[0], settings);
                foreach (historyBookingRoom item in data.data)
                {
                    if (item.MaPDK.Equals("-1"))
                    {
                        MessageBox.Show("Không tìm thấy thông tin");
                        loadLichSuThuePhong();
                        return;
                    }
                    item.Ngayden = DateTime.ParseExact(item.Ngayden.AddDays(1).ToString("dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    item.Ngaydi = DateTime.ParseExact(item.Ngaydi.AddDays(1).ToString("dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    lstHistoryBookingRoom.Add(item);
                }
                GridViewThuePhong.DataSource = lstHistoryBookingRoom;
            }
            catch
            {
                MessageBox.Show("Lỗi tìm kiếm");
                loadLichSuThuePhong();
            }
        }

        private async void btnSearchHistoryService_Click(object sender, EventArgs e)
        {
            try
            {
                lsHhistoryServices = new List<historyService>();
                GridViewService.Columns.Clear();
                if (txtSearchHistoryService.Text.Trim() == "")
                {
                    loadLichSuDichVu();
                    return;
                }
                string filter = txtSearchHistoryService.Text.Trim();
                var returnData = api.getAPI("history/historyService/search/" + filter);
                var result = await Task.WhenAll(returnData);
                var data = JsonConvert.DeserializeObject<listHistoryService>(result[0]);
                foreach (historyService item in data.data)
                {
                    if (item.IDHDDV.Equals("-1"))
                    {
                        MessageBox.Show("Không tìm thấy thông tin");
                        loadLichSuThuePhong();
                        return;
                    }
                    item.NgayLap = DateTime.ParseExact(item.NgayLap.AddDays(1).ToString("dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture);

                    lsHhistoryServices.Add(item);
                }
                GridViewService.DataSource = lsHhistoryServices;
                GridViewService.Columns[0].Visible = false;
            }
            catch
            {
                MessageBox.Show("Lỗi tìm kiếm");
                loadLichSuDichVu();
            }
        }

        private async void btnSearchBill_Click(object sender, EventArgs e)
        {
            try
            {
                lstHistoryBills = new List<historyBill>();
                GridViewBill.Columns.Clear();
                if (txtSearchBill.Text.Trim() == "")
                {
                    loadHoaDonThanhToan();
                    return;
                }
                string filter = txtSearchBill.Text.Trim();
                var returnData = api.getAPI("history/historyBill/search/" + filter);
                var result = await Task.WhenAll(returnData);
                var data = JsonConvert.DeserializeObject<listHistoryBill>(result[0]);
                foreach (historyBill item in data.data)
                {
                    if (item.MaPDK.Equals("-1"))
                    {
                        MessageBox.Show("Không tìm thấy thông tin");
                        loadLichSuThuePhong();
                        return;
                    }
                    item.NgayThanhToan = DateTime.ParseExact(item.NgayThanhToan.AddDays(1).ToString("dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture);

                    lstHistoryBills.Add(item);
                }
                GridViewBill.DataSource = lstHistoryBills;
                GridViewBill.Columns[0].Visible = false;
                GridViewBill.Columns[1].Visible = false;
                GridViewBill.Columns[7].Visible = false;
            }
            catch
            {
                MessageBox.Show("Lỗi tìm kiếm");
                loadHoaDonThanhToan();
            }
        }
    }
}
