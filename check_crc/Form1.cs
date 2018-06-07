using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace check_crc
{
    public partial class CRC : Form
    {
        public CRC()
        {
            InitializeComponent();
        }

        public string CRCCalc(string data)  //CRC检验算法  
        {
            string[] datas = data.Split(' ');
            List<byte> bytedata = new List<byte>();

            foreach (string str in datas)
            {
                bytedata.Add(byte.Parse(str, System.Globalization.NumberStyles.AllowHexSpecifier));
            }

            byte[] crcbuf = bytedata.ToArray();
            //计算并填写CRC校验码  
            byte crc = 0;
            int len = crcbuf.Length;

            for (byte n = 0; n < len; n++)
            {
                byte value = crcbuf[n];
                if (0 == n) continue;
                crc = (byte)(crc ^ value);
                for (byte i = 0; i < 8; i++)
                {
                    byte k = (byte)(crc & 0x01);
                    if (0x01 == k)
                    {
                        crc = (byte)((crc >> 1) ^ 0x8c);
                    }
                    else
                        crc >>= 1;
                }
            }
            return crc.ToString("X2");
        } 

        private void bt_crc_Click(object sender, EventArgs e)
        {
            if(tb_send.Text.Trim() == "")
            {
                MessageBox.Show("没有要发送的数据！", "错误提示");
                return;
            }
            else
            {
                string expression = tb_send.Text.Trim();
                this.tb_send.Text += " "+this.CRCCalc(expression).ToString();
            }

        }

        private void CRC_Load(object sender, EventArgs e)
        {
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.MaximizeBox = false;

            //列出设备类型
            cbx_type.Items.Add("LED");
            cbx_type.Items.Add("LCD");
            cbx_type.SelectedIndex = 0;

            cbx_data1.Items.Add("1");
            cbx_data1.Items.Add("2");
            cbx_data1.Items.Add("3");
            cbx_data1.Items.Add("4");
            cbx_data1.Items.Add("5");
            cbx_data1.Items.Add("温控");
            cbx_data1.Items.Add("设图");
            cbx_data1.Items.Add("冷热");
            cbx_data1.Items.Add("模式");
            cbx_data1.Items.Add("风速");
            cbx_data1.Items.Add("显示");
            cbx_data1.Items.Add("湿度");
            cbx_data1.Items.Add("温度");
            cbx_data1.SelectedIndex = 0;

            cbx_data2.Items.Add("左");
            cbx_data2.Items.Add("右");
            cbx_data2.Items.Add("保留");
            cbx_data2.SelectedIndex = 0;

            cbx_data3.Items.Add("R");
            cbx_data3.Items.Add("G");
            cbx_data3.Items.Add("B");
            cbx_data3.Items.Add("RGB");
            cbx_data3.Items.Add("保留");
            cbx_data3.SelectedIndex = 0;

            cbx_data4.Items.Add("高亮");
            cbx_data4.Items.Add("微亮");
            cbx_data4.Items.Add("开");
            cbx_data4.Items.Add("关");
            cbx_data4.Items.Add("亮");
            cbx_data4.Items.Add("灭");
            cbx_data4.SelectedIndex = 0;
        }

        private void bt_org_Click(object sender, EventArgs e)
        {
            string display = "AA 00 03";
            switch(cbx_type.Text.Trim())
            {
                case "LED":
                    display += " " + "02";                  //add led device

                    display += " " + cbx_data1.Text.Trim(); //add linkage num

                    if (cbx_data2.Text.Trim() == "左")       //add left right
                        display += " " + "01";
                    if (cbx_data2.Text.Trim() == "右")
                        display += " " + "02";

                    if (cbx_data3.Text.Trim() == "R")        //add color
                        display += " " + "01";
                    if (cbx_data3.Text.Trim() == "G")
                        display += " " + "02";
                    if (cbx_data3.Text.Trim() == "B")
                        display += " " + "04";
                    if (cbx_data3.Text.Trim() == "RGB")
                        display += " " + "07";

                    if (cbx_data4.Text.Trim() == "高亮")       //add light
                        display += " " + "01";
                    if (cbx_data4.Text.Trim() == "微亮")
                        display += " " + "00";
                    break;



                case "LCD":
                    display += " " + "03";
                    break;



                default:
                    break;
            }
            display += " " + this.CRCCalc(display).ToString();
            this.tb_org_send.Text = display;
        }
    }
}
