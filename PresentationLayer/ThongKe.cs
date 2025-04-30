using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BusinessLayer;

namespace PresentationLayer
{
    public partial class ThongKe : Form
    {
        private ThongKeBL thongKeBL;

        public ThongKe()
        {
            InitializeComponent();
            thongKeBL = new ThongKeBL(); 
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            
            dtpNam.Format = DateTimePickerFormat.Custom;
            dtpNam.CustomFormat = "yyyy";
            dtpNam.ShowUpDown = true;

          
            cbKieuThongKe.Items.Add("Tháng");
            cbKieuThongKe.Items.Add("Quý");
            cbKieuThongKe.Items.Add("Năm");
            cbKieuThongKe.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kieu = cbKieuThongKe.SelectedItem.ToString();
            int nam = dtpNam.Value.Year;

           
            var thongKeData = thongKeBL.GetThongKeData(kieu, nam);
    
            chartThongKe.Series.Clear();
            chartThongKe.ChartAreas.Clear();
            chartThongKe.Titles.Clear();

            chartThongKe.ChartAreas.Add("ThongKe");
            Series series = new Series("Số lượt mượn");
            series.ChartType = SeriesChartType.Column;

            
            foreach (var data in thongKeData)
            {
                series.Points.AddXY(data.Label, data.SoLuong);
            }

            chartThongKe.Series.Add(series);
            chartThongKe.Titles.Add("Thống kê mượn sách theo " + kieu.ToLower());
        }
    }
}
