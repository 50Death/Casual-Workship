using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Configuration;

namespace OnlineClassCheats
{
    public partial class Form1 : Form
    {
        //2560*1080坐标
        public int QAx = 1120;//扫描点坐标
        public int QAy = 485;
        public int QBx = 1120;
        public int QBy = 535;
        public int ASx = 1300;
        public int ASy = 610;
        public int counter = 0;

        public int sx1 = 800;
        public int sy1 = 360;
        public string sc1 = "Color[A = 255, R = 0, G = 0, B = 0]";

        public int sx2 = 1450;
        public int sy2 = 360;
        public string sc2= "Color[A = 255, R = 0, G = 0, B = 0]";

        public int sx3 = 800;
        public int sy3 = 830;
        public string sc3 = "Color[A = 255, R = 0, G = 0, B = 0]";

        public int sx4 = 1450;
        public int sy4 = 830;
        public string sc4 = "Color[A = 255, R = 0, G = 0, B = 0]";

        //1920*1080坐标
        public int QAxHD = 0;
        public int QAyHD = 0;
        public int QBxHD = 0;
        public int QByHD = 0;
        public int ASxHD = 0;
        public int ASyHD = 0;
        public int counterHD = 0;

        public Form1()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            string check = ConfigurationManager.AppSettings["checkbox1"].ToString();
            if (check == "0")
            {
                Form2 form = new Form2();
                form.ShowDialog();
            }
            InitializeComponent();
            cb_ExplorerSelector.Items.Clear();
            cb_ResolutionSelector.SelectedIndex = 1;
            cb_ExplorerSelector.SelectedIndex = 0;
            comboBox1_ini();
        }

        [DllImport("gdi32.dll")]
        public static extern System.UInt32 GetPixel(IntPtr hdc, int xPos, int yPos);
        [DllImport("user32.dll")]
        private static extern IntPtr GetDC(IntPtr hwnd);
        [DllImport("user32.dll")]
        private static extern IntPtr ReleaseDC(IntPtr hc, IntPtr hDest);
        /// <summary>
        /// 获取X,Y的ARGB颜色
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public System.Drawing.Color GetPixelColor(int x, int y)
        {
            IntPtr hdc = GetDC(IntPtr.Zero);
            uint pixel = GetPixel(hdc, x, y);
            ReleaseDC(IntPtr.Zero, hdc);
            Color color = Color.FromArgb((int)(pixel & 0x000000FF),
            (int)(pixel & 0x0000FF00) >> 8,
            (int)(pixel & 0x00FF0000) >> 16);
            return color;
        }

        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int X, int Y);

        [DllImport("user32.dll")]
        static extern void mouse_event(MouseEventFlag flags, int dx, int dy, uint data, UIntPtr extraInfo); //UIntPtr指针多句柄类型

        enum MouseEventFlag : uint //设置鼠标动作的键值  
        {
            Move = 0x0001,               //发生移动  
            LeftDown = 0x0002,           //鼠标按下左键  
            LeftUp = 0x0004,             //鼠标松开左键  
            RightDown = 0x0008,          //鼠标按下右键  
            RightUp = 0x0010,            //鼠标松开右键  
            MiddleDown = 0x0020,         //鼠标按下中键  
            MiddleUp = 0x0040,           //鼠标松开中键  
            XDown = 0x0080,
            XUp = 0x0100,
            Wheel = 0x0800,              //鼠标轮被移动  
            VirtualDesk = 0x4000,        //虚拟桌面  
            Absolute = 0x8000
        }

        /// <summary>
        /// 自动点击x、y坐标一次
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        private void AutoClick(int x, int y)
        {
            bool act = false;
            act = SetCursorPos(x, y);
            mouse_event(MouseEventFlag.LeftDown, x, y, 0, UIntPtr.Zero);
            mouse_event(MouseEventFlag.LeftDown, x, y, 0, UIntPtr.Zero);
            mouse_event(MouseEventFlag.LeftUp, x, y, 0, UIntPtr.Zero);
            if (!act)
                MessageBox.Show("未能实现自动点击！", "ERROR");
        }

        private bool colorCheck(string x, string y, string color)
        {
            int xx = int.Parse(x);
            int yy = int.Parse(y);
            if (color == GetPixelColor(xx, yy).ToString())
                return true;
            else
                return false;
        }
        int btn_Start_Counter = 0;
        private void btn_Start_Click(object sender, EventArgs e)
        {
            if (btn_Start_Counter == 0)
            {
                MessageBox.Show("开始！\n 请将此窗口拖至视频外！！！");
                timer2.Enabled = true;
                btn_Start.Text = "结束";
                btn_Start_Counter++;
            }
            else if (btn_Start_Counter == 1)
            {
                timer2.Enabled = false;
                btn_Start.Text = "开始";
                btn_Start_Counter--;
            }
            else
                MessageBox.Show("ERROR: line129-149\nWRONG VALUE!\nbtn_Start_Counter");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            mouseX.Text = Cursor.Position.X.ToString();
            mouseY.Text = Cursor.Position.Y.ToString();
            int x = int.Parse(mouseX.Text);
            int y = int.Parse(mouseY.Text);
            tb_color.Text = GetPixelColor(x, y).ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            string color1 = GetPixelColor(int.Parse(tb_saveX1.Text), int.Parse(tb_saveY1.Text)).ToString();//当前颜色
            string color2 = GetPixelColor(int.Parse(tb_saveX2.Text), int.Parse(tb_saveY2.Text)).ToString();
            string color3 = GetPixelColor(int.Parse(tb_saveX3.Text), int.Parse(tb_saveY3.Text)).ToString();
            string color4 = GetPixelColor(int.Parse(tb_saveX4.Text), int.Parse(tb_saveY4.Text)).ToString();
            if (tb_saveColor1.Text != color1 || tb_saveColor2.Text != color2 || tb_saveColor3.Text != color3 || tb_saveColor4.Text != color4)
            {
                for (int i = 0; i < 3; i++)
                {
                    System.Threading.Thread.Sleep(500);
                    AutoClick(QAx, QAy);
                    System.Threading.Thread.Sleep(500);
                    AutoClick(ASx, ASy);
                    System.Threading.Thread.Sleep(2000);

                    color1 = GetPixelColor(int.Parse(tb_saveX1.Text), int.Parse(tb_saveY1.Text)).ToString();//当前颜色
                    color2 = GetPixelColor(int.Parse(tb_saveX2.Text), int.Parse(tb_saveY2.Text)).ToString();
                    color3 = GetPixelColor(int.Parse(tb_saveX3.Text), int.Parse(tb_saveY3.Text)).ToString();
                    color4 = GetPixelColor(int.Parse(tb_saveX4.Text), int.Parse(tb_saveY4.Text)).ToString();

                    if (tb_saveColor1.Text == color1 || tb_saveColor2.Text == color2 || tb_saveColor3.Text == color3 || tb_saveColor4.Text == color4)
                        break;
                    AutoClick(QBx, QBy);
                    System.Threading.Thread.Sleep(500);
                    AutoClick(ASx, ASy);
                    System.Threading.Thread.Sleep(2000);

                    color1 = GetPixelColor(int.Parse(tb_saveX1.Text), int.Parse(tb_saveY1.Text)).ToString();//当前颜色
                    color2 = GetPixelColor(int.Parse(tb_saveX2.Text), int.Parse(tb_saveY2.Text)).ToString();
                    color3 = GetPixelColor(int.Parse(tb_saveX3.Text), int.Parse(tb_saveY3.Text)).ToString();
                    color4 = GetPixelColor(int.Parse(tb_saveX4.Text), int.Parse(tb_saveY4.Text)).ToString();

                    if (tb_saveColor1.Text == color1 || tb_saveColor2.Text == color2 || tb_saveColor3.Text == color3 || tb_saveColor4.Text == color4)
                        break;

                    AutoClick(ASx, ASy);
                    System.Threading.Thread.Sleep(2000);

                    color1 = GetPixelColor(int.Parse(tb_saveX1.Text), int.Parse(tb_saveY1.Text)).ToString();//当前颜色
                    color2 = GetPixelColor(int.Parse(tb_saveX2.Text), int.Parse(tb_saveY2.Text)).ToString();
                    color3 = GetPixelColor(int.Parse(tb_saveX3.Text), int.Parse(tb_saveY3.Text)).ToString();
                    color4 = GetPixelColor(int.Parse(tb_saveX4.Text), int.Parse(tb_saveY4.Text)).ToString();

                    if (tb_saveColor1.Text == color1 || tb_saveColor2.Text == color2 || tb_saveColor3.Text == color3 || tb_saveColor4.Text == color4)
                        break;
                }
                if (tb_saveColor1.Text == color1 && tb_saveColor2.Text == color2 && tb_saveColor3.Text == color3 && tb_saveColor4.Text == color4)
                {
                    timer2.Enabled = false;
                    System.Environment.Exit(0);
                }
                counter++;
                if (counter > 0)
                    System.Environment.Exit(0);
            }
        }

        public int adv = 0;
        private void btn_Adv_Click(object sender, EventArgs e)
        {
            if (adv == 0)
            {
                adv++;
                this.Width = 710;
                timer1.Enabled = true;
                btn_Adv.Text = "收起<<";
            }
            else
            {
                adv--;
                this.Width = 360;
                timer1.Enabled = false;
                btn_Adv.Text = "高级>>";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cb_ResolutionSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_ResolutionSelector.SelectedItem.ToString()=="2560×1080")
            {
                cb_ExplorerSelector.Items.Clear();
                cb_ExplorerSelector.Items.Add("Google Chrome（全屏）");
            }
        }

        private void cb_ExplorerSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_ExplorerSelector.SelectedItem.ToString() == "Google Chrome（全屏）")
                setNumber(0);
        }

        private void setNumber(int x)
        {
            if(x==-1)
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                tb_saveX1.Text = ConfigurationManager.AppSettings["SaveX_1_1"].ToString();
                tb_saveY1.Text = ConfigurationManager.AppSettings["SaveY_1_1"].ToString();
                tb_saveColor1.Text = ConfigurationManager.AppSettings["SaveC_1_1"].ToString();

                tb_saveX2.Text = ConfigurationManager.AppSettings["SaveX_1_2"].ToString();
                tb_saveY2.Text = ConfigurationManager.AppSettings["SaveY_1_2"].ToString();
                tb_saveColor2.Text = ConfigurationManager.AppSettings["SaveC_1_2"].ToString();

                tb_saveX3.Text = ConfigurationManager.AppSettings["SaveX_1_3"].ToString();
                tb_saveY3.Text = ConfigurationManager.AppSettings["SaveY_1_3"].ToString();
                tb_saveColor3.Text = ConfigurationManager.AppSettings["SaveC_1_3"].ToString();

                tb_saveX4.Text = ConfigurationManager.AppSettings["SaveX_1_4"].ToString();
                tb_saveY4.Text = ConfigurationManager.AppSettings["SaveY_1_4"].ToString();
                tb_saveColor4.Text = ConfigurationManager.AppSettings["SaveC_1_4"].ToString();
            }

            if(x==0)
            {
                tb_saveX1.Text = sx1.ToString();
                tb_saveY1.Text = sy1.ToString();
                tb_saveColor1.Text = sc1;

                tb_saveX2.Text = sx2.ToString();
                tb_saveY2.Text = sy2.ToString();
                tb_saveColor2.Text = sc2;

                tb_saveX3.Text = sx3.ToString();
                tb_saveY3.Text = sy3.ToString();
                tb_saveColor3.Text = sc3;

                tb_saveX4.Text = sx4.ToString();
                tb_saveY4.Text = sy4.ToString();
                tb_saveColor4.Text = sc4;
            }
        }

        private void btn_About_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                config.AppSettings.Settings["Save1"].Value = "enabled";

                config.AppSettings.Settings["SaveX_1_1"].Value = tb_saveX1.Text.ToString();
                config.AppSettings.Settings["SaveY_1_1"].Value = tb_saveY1.Text.ToString();
                config.AppSettings.Settings["SaveC_1_1"].Value = tb_saveColor1.Text.ToString();

                config.AppSettings.Settings["SaveX_1_2"].Value = tb_saveX2.Text.ToString();
                config.AppSettings.Settings["SaveY_1_2"].Value = tb_saveY2.Text.ToString();
                config.AppSettings.Settings["SaveC_1_2"].Value = tb_saveColor2.Text.ToString();

                config.AppSettings.Settings["SaveX_1_3"].Value = tb_saveX3.Text.ToString();
                config.AppSettings.Settings["SaveY_1_3"].Value = tb_saveY3.Text.ToString();
                config.AppSettings.Settings["SaveC_1_3"].Value = tb_saveColor3.Text.ToString();

                config.AppSettings.Settings["SaveX_1_4"].Value = tb_saveX4.Text.ToString();
                config.AppSettings.Settings["SaveY_1_4"].Value = tb_saveY4.Text.ToString();
                config.AppSettings.Settings["SaveC_1_4"].Value = tb_saveColor4.Text.ToString();

                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
                MessageBox.Show("保存成功！");
            }
            catch
            {
                MessageBox.Show("保存失败！\n错误代码:line.289\nfailed to write into config");
            }
        }

        private void comboBox1_ini()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            string save1 = ConfigurationManager.AppSettings["Save1"].ToString();
            if(save1=="enabled")
                comboBox1.Items.Add("保存1");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "保存1")
                setNumber(-1);
        }
    }
}
