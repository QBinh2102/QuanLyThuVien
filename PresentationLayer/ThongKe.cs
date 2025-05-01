using System;
using System.Data;
using System.Drawing;
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

            dtpNam2.Format = DateTimePickerFormat.Custom;
            dtpNam2.CustomFormat = "yyyy";
            dtpNam2.ShowUpDown = true;


            cbKieuThongKe.Items.Add("Tháng");
            cbKieuThongKe.Items.Add("Quý");
           
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
            Series series = new Series("Số lượt mượn")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true,  
                Font = new Font("Arial", 10), 
                LabelFormat = "0"  
            };

           
            foreach (var data in thongKeData)
            {
                series.Points.AddXY(data.Label, data.SoLuong);
            }

            
            chartThongKe.Series.Add(series);
            chartThongKe.Titles.Add("Thống kê mượn sách theo " + kieu.ToLower());
        }


        private void btThongKe_Click(object sender, EventArgs e)
        {
            int nam = dtpNam2.Value.Year;
            var thongKeData = thongKeBL.GetTiLeTraDungHan(nam);
            LoadTiLeTraDungHan(thongKeData, nam);

        }

        private void LoadTiLeTraDungHan(DataTable dt, int nam)
        {
            chartTiLeDungHan.Series.Clear();
            chartTiLeDungHan.ChartAreas.Clear();
            chartTiLeDungHan.Titles.Clear();
            chartTiLeDungHan.ChartAreas.Add("TiLeTra");

            Series series = new Series("Tỉ lệ trả đúng hạn")
            {
                ChartType = SeriesChartType.Pie, 
                IsValueShownAsLabel = true,       
                Font = new Font("Arial", 10),    
            };

        
            foreach (DataRow row in dt.Rows)
            {
                string label = row["TinhTrang"].ToString();  
                int value = Convert.ToInt32(row["SoLuong"]);
                double tiLe = Convert.ToDouble(row["TiLe"]);

                
                DataPoint dp = new DataPoint
                {
                    AxisLabel = label,
                    YValues = new double[] { value },
                    Label = $"{label}: {tiLe:F2}% ({value} lượt)"  
                };

                
                series.Points.Add(dp);
            }
            chartTiLeDungHan.Series.Add(series);
            chartTiLeDungHan.Titles.Add($"Tỉ lệ trả sách đúng hạn trong năm {nam}");
        }

    }
}
