using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace valencell_show_results {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            lb_1.Text = "1";
            lb_1.Location = pictureBox1.PointToClient(lb_1.Parent.PointToScreen(lb_1.Location));
            lb_1.Parent = pictureBox1;
            lb_1.BackColor = Color.Transparent;
            lb_2.Text = "2";
            lb_2.Location = pictureBox2.PointToClient(lb_2.Parent.PointToScreen(lb_2.Location));
            lb_2.Parent = pictureBox2;
            lb_2.BackColor = Color.Transparent;
            lb_3.Text = "3";
            lb_3.Location = pictureBox3.PointToClient(lb_3.Parent.PointToScreen(lb_3.Location));
            lb_3.Parent = pictureBox3;
            lb_3.BackColor = Color.Transparent;
            lb_4.Text = "4";
            lb_4.Location = pictureBox4.PointToClient(lb_4.Parent.PointToScreen(lb_4.Location));
            lb_4.Parent = pictureBox4;
            lb_4.BackColor = Color.Transparent;
            lb_5.Text = "5";
            lb_5.Location = pictureBox5.PointToClient(lb_5.Parent.PointToScreen(lb_5.Location));
            lb_5.Parent = pictureBox5;
            lb_5.BackColor = Color.Transparent;
            lb_6.Text = "6";
            lb_6.Location = pictureBox6.PointToClient(lb_6.Parent.PointToScreen(lb_6.Location));
            lb_6.Parent = pictureBox6;
            lb_6.BackColor = Color.Transparent;
            lb_7.Text = "7";
            lb_7.Location = pictureBox7.PointToClient(lb_7.Parent.PointToScreen(lb_7.Location));
            lb_7.Parent = pictureBox7;
            lb_7.BackColor = Color.Transparent;
            lb_8.Text = "8";
            lb_8.Location = pictureBox8.PointToClient(lb_8.Parent.PointToScreen(lb_8.Location));
            lb_8.Parent = pictureBox8;
            lb_8.BackColor = Color.Transparent;
            lb_9.Text = "9";
            lb_9.Location = pictureBox9.PointToClient(lb_9.Parent.PointToScreen(lb_9.Location));
            lb_9.Parent = pictureBox9;
            lb_9.BackColor = Color.Transparent;
            lb_10.Text = "10";
            lb_10.Location = pictureBox10.PointToClient(lb_10.Parent.PointToScreen(lb_10.Location));
            lb_10.Parent = pictureBox10;
            lb_10.BackColor = Color.Transparent;
            lb_11.Text = "11";
            lb_11.Location = pictureBox11.PointToClient(lb_11.Parent.PointToScreen(lb_11.Location));
            lb_11.Parent = pictureBox11;
            lb_11.BackColor = Color.Transparent;
            lb_12.Text = "12";
            lb_12.Location = pictureBox12.PointToClient(lb_12.Parent.PointToScreen(lb_12.Location));
            lb_12.Parent = pictureBox12;
            lb_12.BackColor = Color.Transparent;
            lb_13.Text = "13";
            lb_13.Location = pictureBox13.PointToClient(lb_13.Parent.PointToScreen(lb_13.Location));
            lb_13.Parent = pictureBox13;
            lb_13.BackColor = Color.Transparent;
            lb_14.Text = "14";
            lb_14.Location = pictureBox14.PointToClient(lb_14.Parent.PointToScreen(lb_14.Location));
            lb_14.Parent = pictureBox14;
            lb_14.BackColor = Color.Transparent;
            lb_15.Text = "15";
            lb_15.Location = pictureBox15.PointToClient(lb_15.Parent.PointToScreen(lb_15.Location));
            lb_15.Parent = pictureBox15;
            lb_15.BackColor = Color.Transparent;
            lb_16.Text = "16";
            lb_16.Location = pictureBox16.PointToClient(lb_16.Parent.PointToScreen(lb_16.Location));
            lb_16.Parent = pictureBox16;
            lb_16.BackColor = Color.Transparent;
            lb_17.Text = "17";
            lb_17.Location = pictureBox17.PointToClient(lb_17.Parent.PointToScreen(lb_17.Location));
            lb_17.Parent = pictureBox17;
            lb_17.BackColor = Color.Transparent;
            lb_18.Text = "18";
            lb_18.Location = pictureBox18.PointToClient(lb_18.Parent.PointToScreen(lb_18.Location));
            lb_18.Parent = pictureBox18;
            lb_18.BackColor = Color.Transparent;
            lb_19.Text = "19";
            lb_19.Location = pictureBox19.PointToClient(lb_19.Parent.PointToScreen(lb_19.Location));
            lb_19.Parent = pictureBox19;
            lb_19.BackColor = Color.Transparent;
            lb_20.Text = "20";
            lb_20.Location = pictureBox20.PointToClient(lb_20.Parent.PointToScreen(lb_20.Location));
            lb_20.Parent = pictureBox20;
            lb_20.BackColor = Color.Transparent;

            lb_fail_1.Location = pictureBox1.PointToClient(lb_fail_1.Parent.PointToScreen(lb_fail_1.Location));
            lb_fail_1.Parent = pictureBox1;
            //lb_fail_1.BackColor = Color.Transparent;
            lb_fail_2.Location = pictureBox2.PointToClient(lb_fail_2.Parent.PointToScreen(lb_fail_2.Location));
            lb_fail_2.Parent = pictureBox2;
            //lb_fail_2.BackColor = Color.Transparent;
            lb_fail_3.Location = pictureBox3.PointToClient(lb_fail_3.Parent.PointToScreen(lb_fail_3.Location));
            lb_fail_3.Parent = pictureBox3;
            //lb_fail_3.BackColor = Color.Transparent;
            lb_fail_4.Location = pictureBox4.PointToClient(lb_fail_4.Parent.PointToScreen(lb_fail_4.Location));
            lb_fail_4.Parent = pictureBox4;
            //lb_fail_4.BackColor = Color.Transparent;
            lb_fail_5.Location = pictureBox5.PointToClient(lb_fail_5.Parent.PointToScreen(lb_fail_5.Location));
            lb_fail_5.Parent = pictureBox5;
            //lb_fail_5.BackColor = Color.Transparent;
            lb_fail_6.Location = pictureBox6.PointToClient(lb_fail_6.Parent.PointToScreen(lb_fail_6.Location));
            lb_fail_6.Parent = pictureBox6;
            //lb_fail_6.BackColor = Color.Transparent;
            lb_fail_7.Location = pictureBox7.PointToClient(lb_fail_7.Parent.PointToScreen(lb_fail_7.Location));
            lb_fail_7.Parent = pictureBox7;
            //lb_fail_7.BackColor = Color.Transparent;
            lb_fail_8.Location = pictureBox8.PointToClient(lb_fail_8.Parent.PointToScreen(lb_fail_8.Location));
            lb_fail_8.Parent = pictureBox8;
            //lb_fail_8.BackColor = Color.Transparent;
            lb_fail_9.Location = pictureBox9.PointToClient(lb_fail_9.Parent.PointToScreen(lb_fail_9.Location));
            lb_fail_9.Parent = pictureBox9;
            //lb_fail_9.BackColor = Color.Transparent;
            lb_fail_10.Location = pictureBox10.PointToClient(lb_fail_10.Parent.PointToScreen(lb_fail_10.Location));
            lb_fail_10.Parent = pictureBox10;
            //lb_fail_10.BackColor = Color.Transparent;
            lb_fail_11.Location = pictureBox11.PointToClient(lb_fail_11.Parent.PointToScreen(lb_fail_11.Location));
            lb_fail_11.Parent = pictureBox11;
            //lb_fail_11.BackColor = Color.Transparent;
            lb_fail_12.Location = pictureBox12.PointToClient(lb_fail_12.Parent.PointToScreen(lb_fail_12.Location));
            lb_fail_12.Parent = pictureBox12;
            //lb_fail_12.BackColor = Color.Transparent;
            lb_fail_13.Location = pictureBox13.PointToClient(lb_fail_13.Parent.PointToScreen(lb_fail_13.Location));
            lb_fail_13.Parent = pictureBox13;
            //lb_fail_13.BackColor = Color.Transparent;
            lb_fail_14.Location = pictureBox14.PointToClient(lb_fail_14.Parent.PointToScreen(lb_fail_14.Location));
            lb_fail_14.Parent = pictureBox14;
            //lb_fail_14.BackColor = Color.Transparent;
            lb_fail_15.Location = pictureBox15.PointToClient(lb_fail_15.Parent.PointToScreen(lb_fail_15.Location));
            lb_fail_15.Parent = pictureBox15;
            //lb_fail_15.BackColor = Color.Transparent;
            lb_fail_16.Location = pictureBox16.PointToClient(lb_fail_16.Parent.PointToScreen(lb_fail_16.Location));
            lb_fail_16.Parent = pictureBox16;
            //lb_fail_16.BackColor = Color.Transparent;
            lb_fail_17.Location = pictureBox17.PointToClient(lb_fail_17.Parent.PointToScreen(lb_fail_17.Location));
            lb_fail_17.Parent = pictureBox17;
            //lb_fail_17.BackColor = Color.Transparent;
            lb_fail_18.Location = pictureBox18.PointToClient(lb_fail_18.Parent.PointToScreen(lb_fail_18.Location));
            lb_fail_18.Parent = pictureBox18;
            //lb_fail_18.BackColor = Color.Transparent;
            lb_fail_19.Location = pictureBox19.PointToClient(lb_fail_19.Parent.PointToScreen(lb_fail_19.Location));
            lb_fail_19.Parent = pictureBox19;
            //lb_fail_19.BackColor = Color.Transparent;
            lb_fail_20.Location = pictureBox20.PointToClient(lb_fail_20.Parent.PointToScreen(lb_fail_20.Location));
            lb_fail_20.Parent = pictureBox20;
            //lb_fail_20.BackColor = Color.Transparent;
        }

        private void Form1_Load(object sender, EventArgs e) {
            rtb_fail.Clear();
            PictureBox[] p = new PictureBox[20];
            p[0] = pictureBox1; p[4] = pictureBox5; p[8] = pictureBox9; p[12] = pictureBox13; p[16] = pictureBox17;
            p[1] = pictureBox2; p[5] = pictureBox6; p[9] = pictureBox10; p[13] = pictureBox14; p[17] = pictureBox18;
            p[2] = pictureBox3; p[6] = pictureBox7; p[10] = pictureBox11; p[14] = pictureBox15; p[18] = pictureBox19;
            p[3] = pictureBox4; p[7] = pictureBox8; p[11] = pictureBox12; p[15] = pictureBox16; p[19] = pictureBox20;
            Label[] l = new Label[20];
            l[0] = lb_fail_1; l[4] = lb_fail_5; l[8] = lb_fail_9; l[12] = lb_fail_13; l[16] = lb_fail_17;
            l[1] = lb_fail_2; l[5] = lb_fail_6; l[9] = lb_fail_10; l[13] = lb_fail_14; l[17] = lb_fail_18;
            l[2] = lb_fail_3; l[6] = lb_fail_7; l[10] = lb_fail_11; l[14] = lb_fail_15; l[18] = lb_fail_19;
            l[3] = lb_fail_4; l[7] = lb_fail_8; l[11] = lb_fail_12; l[15] = lb_fail_16; l[19] = lb_fail_20;
            for (int i = 0; i < 20; i++) {
                //p[i].Image = Properties.Resources.vlc_non;
                p[i].Image = Properties.Resources.vlc_non2;
                l[i].Visible = false;
            }
            string s1 = "";
            try { s1 = File.ReadAllText("vlc_show_results_tested.txt"); } catch { }
            if (s1 == "") { MessageBox.Show("_อ่านไฟล์ที่ส่งมาจากโปรแกรม Main ไม่ได้"); return; }
            string[] ss1 = File.ReadAllLines("vlc_show_results_tested.txt");
            for (int i = 0; i < 20; i++) {
                if (!ss1[i].Contains("PASS") && !ss1[i].Contains("FAIL")) continue;
                //if (ss1[i] == "PASS") p[i].Image = Properties.Resources.vlc_pass;
                //else p[i].Image = Properties.Resources.vlc_fail;
                if (ss1[i].Contains("PASS")) p[i].Image = Properties.Resources.vlc_pass2;
                else {
                    p[i].Image = Properties.Resources.vlc_fail2;
                    string[] bb = ss1[i].Split(',');
                    try {
                        l[i].Text = bb[1];
                        l[i].Visible = true;
                    } catch { }
                    string value_fail = "";
                    try {
                        value_fail = "head " + (i + 1) + "       step = " + bb[1] + "       value = " + bb[2];
                        Log(LogMsgType.Normal_Black, value_fail + "\r\n");
                    } catch { }
                }
            }

            File.Delete("vlc_show_results_tested.txt");

            string[] sss = new string[2];
            try { sss = File.ReadAllLines("vlc_data_get_status_lot_ok.txt"); } catch {
                MessageBox.Show("_อ่านไฟล์จาก status pass fail จากโปรแกรม vlc_data ไม่ได้");
                tb_fail.Text = "0";
                tb_pass.Text = "0";
                tb_total.Text = "0";
                textBox1.Focus();
                return;
            }
            File.Delete("vlc_data_get_status_lot_ok.txt");
            tb_pass.Text = sss[0];
            tb_fail.Text = sss[1];
            double ggg = 0;
            double ggg2 = 0;
            try {
                ggg = Convert.ToDouble(sss[0]);
                ggg2 = Convert.ToDouble(sss[1]);
            } catch {
                MessageBox.Show("_แปลงค่าจำนวน pass fail ที่ส่งมาจาก vlc_data เป็น double ไม่ได้");
                textBox1.Focus();
                return;
            }
            tb_total.Text = (ggg + ggg2).ToString("0");

            textBox1.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            this.Focus();
            this.Activate();
            this.Show();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e) {
            //this.Close();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            File.WriteAllText("vlc_data_sn_prism_get.txt","");
        }

        #region====================================================== region Display_Message ======================================================
        private Color[] LogMsgTypeColor = { Color.Blue, Color.Green, Color.Black, Color.Orange, Color.Red };
        public enum LogMsgType { Incoming_Blue, Outgoing_Green, Normal_Black, Warning_Orange, Error_Red };
        public void Log(LogMsgType msgtype, string msg) {
            try {
                rtb_fail.Invoke(new EventHandler(delegate {
                    rtb_fail.SelectedText = string.Empty;
                    rtb_fail.SelectionFont = new Font(rtb_fail.SelectionFont, FontStyle.Bold);
                    rtb_fail.SelectionColor = LogMsgTypeColor[(int)msgtype];
                    rtb_fail.AppendText(msg);
                    rtb_fail.ScrollToCaret();
                }));
            } catch (Exception) { }
        }
        #endregion
    }
}
