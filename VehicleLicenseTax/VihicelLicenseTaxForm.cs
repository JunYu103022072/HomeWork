using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleLicenseTax
{
    public partial class VihicelLicenseTaxForm : Form
    {
        public VihicelLicenseTaxForm()
        {
            InitializeComponent();
        }
        #region "Init"

        private void btnClear_Click(object sender, EventArgs e)
        {
            Init();
        }
        /// <summary>
        /// 控制初始化
        /// </summary>
        private void Init()
        {
            this.cbxTrafficType.SelectedIndex = 0;
            this.cbxCC.SelectedIndex = -1;
            this.txtBoxResult.Clear();
            this.lblCCMsg.Visible = false;
            this.lblDateMsg.Visible = false;

        }
        private void VihicelLicenseTaxForm_Load(object sender, EventArgs e)
        {
            Init();
            DateTime dateNow = DateTime.Now;
            DateTime today = DateTime.Today;
        }
        #endregion
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            this.txtBoxResult.Clear();
            //表單點選錯誤提示
            if (this.cbxCC.SelectedIndex == -1)
            {
                this.lblCCMsg.Text = "請選擇汽車CC數/馬達馬力";
                this.lblCCMsg.Visible = true;
                return;
            }
            else
            {
                this.lblCCMsg.Visible = false;
            }

            decimal result = (decimal)this.GetTax();
            int timeSpan = new TimeSpan(this.dtEnd.Value.Ticks - this.dtStart.Value.Ticks).Days;

            int yeardays = DateTime.Now.DayOfYear;


            string start = DateTime.Parse(DateTime.Now.ToString("yyyy-01-01")).ToShortDateString();
            decimal dayscount = 0;
            string end = DateTime.Parse(DateTime.Now.ToString("yyyy-01-01")).AddYears(1).AddDays(-1).ToShortDateString();
            //判斷是否為閏年
            bool isleapyear = DateTime.IsLeapYear(DateTime.Now.Year);
            if (isleapyear == true)
            {
                yeardays = 366;
                dayscount = 366;
            }
            else
            {
                yeardays = 365;
                dayscount = 365;
            }

            DateTime startDate = this.dtStart.Value;
            DateTime endDate = this.dtEnd.Value;

            if (rbtYear.Checked)
            {
                //捨棄小數後的數字
                result = Math.Truncate(result);
                result = Math.Truncate(result);

                this.txtBoxResult.Text = $"使用期限 : {start} ~ {end}" + Environment.NewLine +
                    $"計算天數 : {dayscount} 天" + Environment.NewLine +
                    $"交通工具 : {cbxTrafficType.Text}" + Environment.NewLine +
                    $"汽缸CC數/馬達馬力 : {cbxCC.Text}" + Environment.NewLine +
                    $"計算公式 : {result} * {dayscount}天 / {yeardays}天 = {result} 元" + Environment.NewLine +
                    $"應繳稅額 : 共 {result}元";
            }
            else
            {
                //依日期算金額
                if (endDate.CompareTo(startDate) > 0)
                {
                    for (var i = dtStart.Value.Year; i <= dtEnd.Value.Year; i++)
                    {
                        TimeSpan timespan = endDate.Subtract(startDate);
                        dayscount = timespan.Days + 1;

                        result = Math.Truncate(result);
                        decimal result2 = result * (dayscount / yeardays);
                        result2 = Math.Truncate(result2);
                        DateTime st = Convert.ToDateTime(dtStart.Value.ToString());
                        DateTime et = Convert.ToDateTime(dtEnd.Value.ToString());

                        this.txtBoxResult.Text += $"使用期限 : {st.ToString("yyyy-MM-dd")} ~ {et.ToString("yyyy-MM-dd")}" + Environment.NewLine +
                            $"計算天數 : {dayscount} 天" + Environment.NewLine +
                            $"交通工具 : {cbxTrafficType.Text}" + Environment.NewLine +
                            $"汽缸CC數/馬達馬力 : {cbxCC.Text}" + Environment.NewLine +
                            $"計算公式 : {result} * {dayscount}天 / {yeardays}天 = {result2} 元" + Environment.NewLine +
                            $"應繳稅額 : 共 {result2}元" + Environment.NewLine;
                    }
                }
                else
                {
                    this.lblDateMsg.Text = "開始日期不可大於或等於結束日期";
                    this.lblDateMsg.Visible = true;
                    return;
                }
            }

            //result = Math.Truncate(result);
            //decimal result2 = result * (dayscount / yeardays);
            //result2 = Math.Truncate(result2);

            //this.txtBoxResult.Text = $"使用期限 : {start} ~ {end}" + Environment.NewLine +
            //    $"計算天數 : {dayscount} 天" + Environment.NewLine +
            //    $"交通工具 : {cbxTrafficType.Text}" + Environment.NewLine +
            //    $"汽缸CC數/馬達馬力 : {cbxCC.Text}" + Environment.NewLine +
            //    $"計算公式 : {result} * {dayscount}天 / {yeardays}天 = {result2} 元" + Environment.NewLine +
            //    $"應繳稅額 : 共 {result2}元";
        }

        private void rbtDeadline_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbtDeadline.Checked)
            {
                this.pnlDate.Visible = true;
            }
            else
            {
                this.pnlDate.Visible = false;
                this.lblDateMsg.Visible = false;
            }
        }
        #region "GetTax" 
        /// <summary>
        /// 取出各交通工具結合排氣/馬力數後的價格
        /// </summary>
        private decimal GetTax()
        {
            string traffic = this.cbxTrafficType.Text;
            int yearTax = this.cbxCC.SelectedIndex;

            if (traffic == "機車")
            {
                switch (yearTax)
                {
                    case 1:
                        return 800;
                    case 2:
                        return 1620;
                    case 3:
                        return 2160;
                    case 4:
                        return 4320;
                    case 5:
                        return 7120;
                    case 6:
                        return 11230;
                    default:
                        return 0;
                }
            }
            else if (traffic == "貨車")
            {
                switch (yearTax)
                {
                    case 0:
                        return 900;
                    case 1:
                        return 1080;
                    case 2:
                        return 1800;
                    case 3:
                        return 2700;
                    case 4:
                        return 3600;
                    case 5:
                        return 4500;
                    case 6:
                        return 5400;
                    case 7:
                        return 6300;
                    case 8:
                        return 7200;
                    case 9:
                        return 8100;
                    case 10:
                        return 9000;
                    case 11:
                        return 9900;
                    case 12:
                        return 10800;
                    case 13:
                        return 11700;
                    case 14:
                        return 12600;
                    case 15:
                        return 13500;
                    case 16:
                        return 14400;
                    case 17:
                        return 15300;
                    default:
                        return 16200;
                }
            }
            else if (traffic == "大客車")
            {
                switch (yearTax)
                {
                    case 1:
                        return 1080;
                    case 2:
                        return 1800;
                    case 3:
                        return 2700;
                    case 4:
                        return 3600;
                    case 5:
                        return 4500;
                    case 6:
                        return 5400;
                    case 7:
                        return 6300;
                    case 8:
                        return 7200;
                    case 9:
                        return 8100;
                    case 10:
                        return 9000;
                    case 11:
                        return 9900;
                    case 12:
                        return 10800;
                    case 13:
                        return 11700;
                    case 14:
                        return 12600;
                    case 15:
                        return 13500;
                    case 16:
                        return 14400;
                    case 17:
                        return 15300;
                    default:
                        return 16200;
                }
            }
            else if (traffic == "自用小客車")
            {
                switch (yearTax)
                {
                    case 0:
                        return 1620;
                    case 1:
                        return 2160;
                    case 2:
                        return 4320;
                    case 3:
                        return 7120;
                    case 4:
                        return 11230;
                    case 5:
                        return 15210;
                    case 6:
                        return 28220;
                    case 7:
                        return 46170;
                    case 8:
                        return 69690;
                    case 9:
                        return 117000;
                    default:
                        return 151200;
                }
            }
            else if (traffic == "營業用小客車")
            {
                switch (yearTax)
                {
                    case 0:
                        return 900;
                    case 1:
                        return 1260;
                    case 2:
                        return 2160;
                    case 3:
                        return 3060;
                    case 4:
                        return 6480;
                    case 5:
                        return 9900;
                    case 6:
                        return 16380;
                    case 7:
                        return 24300;
                    case 8:
                        return 33600;
                    case 9:
                        return 44460;
                    default:
                        return 56700;
                }
            }
            return 0;
        }
        #endregion

        private void cbxTrafficType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbxCC.Items.Clear();
            List<string> listBike = new List<string> { "150cc以下", "151~250cc", "251~500cc", "501~600cc", "601~1200cc", "1201~1800cc", "1801以上" };
            List<string> listTruck = new List<string> { "500cc以下", "501~600cc", "601~1200cc", "1201~1800cc", "1801~2400cc", "2401~3000cc", "3001~3600cc", "3601~4200cc", "4201~4800cc", "4801~5400cc", "5400~6000cc", "6001~6600cc", "6601~7200cc", "7201~7800cc", "7801~8400cc", "8401~9000cc", "9001~9600cc", "9600~10200cc", "10200cc以上" };
            List<string> listLargebus = new List<string> { "500cc以下", "600cc以下", "601~1200cc", "1201~1800cc", "1801~2400cc", "2401~3000cc", "3001~3600cc", "3601~4200cc", "4201~4800cc", "4801~5400cc", "5400~6000cc", "6001~6600cc", "6601~7200cc", "7201~7800cc", "7801~8400cc", "8401~9000cc", "9001~9600cc", "9600~10200cc", "10200cc以上" };
            List<string> listMinibus = new List<string> { "500cc以下", "501~600cc", "601~1200cc", "1201~1800cc", "1801~2400cc", "2401~3000cc", "3001~4200cc", "4201~5400cc", "5400~6600cc", "6601~7800cc", "7801cc以上" };
            List<string> listTaxicab = new List<string> { "500cc以下", "501~600cc", "601~1200cc", "1201~1800cc", "1801~2400cc", "2401~3000cc", "3001~4200cc", "4201~5400cc", "5400~6600cc", "6601~7800cc", "7801cc以上" };

            string traffic = this.cbxTrafficType.Text;
            if (cbxTrafficType.SelectedIndex == 0)
            {
                foreach (var bikecc in listBike)
                {
                    this.cbxCC.Items.Add(bikecc);
                }
            }
            else if (cbxTrafficType.SelectedIndex == 1)
            {
                foreach (var truckcc in listTruck)
                {
                    this.cbxCC.Items.Add(truckcc);
                }
            }
            else if (cbxTrafficType.SelectedIndex == 2)
            {
                foreach (var largebuscc in listLargebus)
                {
                    this.cbxCC.Items.Add(largebuscc);
                }
            }
            else if (cbxTrafficType.SelectedIndex == 3)
            {
                foreach (var minicc in listMinibus)
                {
                    this.cbxCC.Items.Add(minicc);
                }
            }
            else
            {
                foreach (var taxicc in listTaxicab)
                {
                    this.cbxCC.Items.Add(taxicc);
                }
            }
        }
    }
}
