using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RfidApiLib;

namespace UHFReader
{
    public partial class Device_2 : Form
    {
        public Device_2()
        {
            InitializeComponent();
        }

        Form1 home = new Form1();
        RfidApi Reader1 = new RfidApi();
        public byte IsoReading = 0;
        public byte EpcReading = 0;
        public int TagCnt = 0;
        public int ScanTimes = 0;
        public string dataBaca = "";

        private void bRs232Con_Click(object sender, EventArgs e)
        {
            int status;
            byte v1 = 0;
            byte v2 = 0;
            string s = "";
            status = Reader1.OpenCommPort(cCommPort.Text);
            if (status != 0)
            {
                lInfo.Items.Add("Open Comm Port Failed!");
                return;
            }
            status = Reader1.GetFirmwareVersion(ref v1, ref v2);
            if (status != 0)
            {
                lInfo.Items.Add("Can not connect with the reader!");
                Reader1.CloseCommPort();
                return;
            }
            lInfo.Items.Add("Connect the reader success!");
            s = string.Format("The reader's firmware version is:V{0:d2}.{1:d2}", v1, v2);
            lInfo.Items.Add(s);

            status = Reader1.SetBaudRate((byte)cBaudrate.SelectedIndex);
            if (status != 0)
            {
                lInfo.Items.Add("Set baudrate failed!");
                Reader1.CloseCommPort();
                return;
            }
            lInfo.Items.Add("Set baudrate success!");

            bReset.Enabled = true;

            bRs232Con.Enabled = false;
            bRs232Discon.Enabled = true;

            bEpcId.Enabled = true;
            bEpcRead.Enabled = true;
            bEpcWrite.Enabled = true;
            bEpcInit.Enabled = true;
            bEpcKill.Enabled = true;

        }

        private void Device_2_Load(object sender, EventArgs e)
        {
            cCommPort.SelectedIndex = 0;
            cBaudrate.SelectedIndex = 0;
            bRs232Con.Enabled = true;
            bRs232Discon.Enabled = false;

            bReset.Enabled = false;

            bEpcId.Enabled = false;
            bEpcRead.Enabled = false;
            bEpcWrite.Enabled = false;
            bEpcKill.Enabled = false;
            bEpcInit.Enabled = false;

            cEpcTimes.SelectedIndex = 0;

            cEpcMembank.SelectedIndex = 1;
            int nLoop = 0;
            for (nLoop = 0; nLoop < 256; nLoop++)
                cEpcWordptr.Items.Add(Convert.ToString(nLoop));
            cEpcWordptr.SelectedIndex = 2;
            for (nLoop = 0; nLoop < 3; nLoop++)
                cEpcWordcnt.Items.Add(Convert.ToString(nLoop));
            cEpcWordcnt.SelectedIndex = 2;
        }

        private void bRs232Discon_Click(object sender, EventArgs e)
        {
            Reader1.SetBaudRate(0);
            Reader1.CloseCommPort();
            bRs232Con.Enabled = true;
            bRs232Discon.Enabled = false;

            bReset.Enabled = false;

            bEpcId.Enabled = false;
            bEpcRead.Enabled = false;
            bEpcWrite.Enabled = false;
            bEpcKill.Enabled = false;
            bEpcInit.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int status;
            int i, j;
            byte[,] IsoBuf = new byte[100, 12];
            byte tag_cnt = 0;
            string s = "";
            string s1 = "";
            byte tag_flag = 0;
            int listIn = 0;

            // Filter same tag
            if (!chkFilter.Checked)
                Reader1.ClearIdBuf();
            status = Reader1.EpcMultiTagIdentify(ref IsoBuf, ref tag_cnt, ref tag_flag);
            if (tag_cnt > 0)
            {
                for (i = 0; i < tag_cnt; i++)
                {
                    s1 = "";
                    for (j = 0; j < Convert.ToInt16(cEpcWordcnt.Text) * 2; j++)
                    {
                        s = string.Format("{0:X2} ", IsoBuf[i, j]);
                        s1 += s;
                    }
                    lInfo.Items.Add(s1);
                    ListViewItem lviList = new ListViewItem();
                    if (lvTagList.Items.Count <= 0)
                    {
                        lviList.SubItems[0].Text = "1";
                        lviList.SubItems.Add("");
                        lviList.SubItems.Add("");
                        lvTagList.Items.Add(lviList);
                        listIn = 0;
                        lvTagList.Items[listIn].SubItems[1].Text = s1;
                        lvTagList.Items[listIn].SubItems[2].Text = "1";
                    }
                    else
                    {
                        listIn = -1;
                        for (i = 0; i < lvTagList.Items.Count; i++)
                        {
                            if (lvTagList.Items[i].SubItems[1].Text == s1)
                            {
                                listIn = i;
                                break;
                            }
                        }
                        if (listIn < 0)
                        {
                            listIn = lvTagList.Items.Count;
                            lviList.SubItems[0].Text = Convert.ToString(listIn + 1);
                            lviList.SubItems.Add("");
                            lviList.SubItems.Add("");
                            lvTagList.Items.Add(lviList);
                        }
                        lvTagList.Items[listIn].SubItems[1].Text = s1;
                        if (lvTagList.Items[listIn].SubItems[2].Text == "")
                            lvTagList.Items[listIn].SubItems[2].Text = "0";
                        Int64 intTimes = Convert.ToInt64(lvTagList.Items[listIn].SubItems[2].Text);
                        lvTagList.Items[listIn].SubItems[2].Text = Convert.ToString(intTimes + 1);
                    }
                }
            }
            if (ScanTimes <= 0)
            {
                bEpcId_Click(sender, e);
                //bEpcWrite_Click(sender, e);
            }
        }
        private void bEpcId_Click(object sender, EventArgs e)
        {
            if (EpcReading == 0)
            {
                Reader1.ClearIdBuf();
                lInfo.Items.Clear();
                lInfo.Items.Add("Start multiply tags identify!");

                TagCnt = 0;
                if (cEpcTimes.SelectedIndex > 0)
                    ScanTimes = Convert.ToInt16(cEpcTimes.Text);
                else
                    ScanTimes = 9999;
                timerScanEPC.Interval = (tEpcSpeed.Value + 1) * 20;
                timerScanEPC.Enabled = true;
                bEpcId.Text = "Stop";
                EpcReading = 1;
            }
            else
            {
                timerScanEPC.Enabled = false;
                EpcReading = 0;
                bEpcId.Text = "Identify";
            }
        }

        private void bEpcRead_Click(object sender, EventArgs e)
        {
            int membank;
            int wordptr;
            int wordcnt;
            int status = 0;
            byte[] value = new byte[16];

            string s = "The data is:";
            string s1 = "";
            string s2 = "";

            membank = cEpcMembank.SelectedIndex;
            wordptr = cEpcWordptr.SelectedIndex;
            wordcnt = cEpcWordcnt.SelectedIndex;

            status = Reader1.EpcRead((byte)membank, (byte)wordptr, (byte)wordcnt, ref value);
            
            if (status != 0)
            {
                lInfo.Items.Add("Read failed!");
                
                return;
            }
            else
            {

                for (int i = 0; i < wordcnt * 2; i++)
                {
                    s1 = string.Format("{0:X2}", value[i]);
                    s2 += s1;
                    s += s1;
                    
                    
                }

                //dataBaca = s2;

                lInfo.Items.Add("Read success!");
                
                lInfo.Items.Add(s);
                if (comboBox1.Items.IndexOf(s2) == -1)
                {
                    comboBox1.Items.Add(s2);
                }
                if ((comboBox1.Items.Count != 0))
                {
                    comboBox1.SelectedIndex = 0;
                }

            }
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            lInfo.Items.Clear();
            lvTagList.Items.Clear();
        }

        private void bEpcInit_Click(object sender, EventArgs e)
        {
            int status;

            status = Reader1.EpcInitEpc(96);

            if (status == 0)
            {
                lInfo.Items.Add("Init tag success!");
            }
            else
            {
                lInfo.Items.Add("Init tag failed!");
            }
        }
        public static byte[] StringToByteArray(String hex)
        {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }

        private void bEpcWrite_Click(object sender, EventArgs e)
        {
            int membank1;
            int wordptr1;
            int wordcnt1;
            int status1 = 0;
            byte[] value1 = new byte[16];

            string s = "The data is:";
            string s1 = "";
            string s2 = "";

            membank1 = cEpcMembank.SelectedIndex;
            wordptr1 = cEpcWordptr.SelectedIndex;
            wordcnt1 = cEpcWordcnt.SelectedIndex;

            status1 = Reader1.EpcRead((byte)membank1, (byte)wordptr1, (byte)wordcnt1, ref value1);

            for (int i = 0; i < wordcnt1 * 2; i++)
            {
                s1 = string.Format("{0:X2}", value1[i]);
                s2 += s1;
                s += s1;


            }
            dataBaca = s2;

            //if (status1 != 0)
            //{
            //    //lInfo.Items.Add("Read failed!");

            //   // return;
            //}
            //else
            //{


            //    //lInfo.Items.Add("Read success!");

            //    //lInfo.Items.Add(s);

            //}

            
            if (comboBox1.Text == dataBaca)
            {
                ushort[] value = new ushort[16];

                int i = 0;
                byte membank;
                byte wordptr;
                byte wordcnt;
                int status;
                string hexValues;

                membank = (byte)(cEpcMembank.SelectedIndex);
                wordptr = (byte)(cEpcWordptr.SelectedIndex);
                wordcnt = (byte)(cEpcWordcnt.SelectedIndex);


                hexValues = tEpcData.Text;
                string[] hexValuesSplit = hexValues.Split(' ');

                if (comboBox1.Items.Count == 0)
                    return;
                try
                {
                    foreach (String hex in hexValuesSplit)
                    {
                        // Convert the number expressed in base-16 to an integer.
                        if (hex.Length >= 2)
                        {
                            int x = Convert.ToInt32(hex, 16);
                            value[i++] = (ushort)x;
                        }
                    }
                }
                catch (Exception)
                {
                    lInfo.Items.Add("Please input data needed");
                    return;
                }
                if (i != wordcnt)
                {
                    lInfo.Items.Add("Please input data needed");
                    return;
                }
                for (byte j = 0; j < wordcnt; j++)
                {

                    status = Reader1.EpcWrite(membank, (byte)(wordptr + j), value[j]);

                    if (status != 0)
                    {
                        lInfo.Items.Add("Write  success!");
                        return;
                    }
                    //else if (comboBox1.SelectedIndex != timerScanEPC_Tick)

                }
                lInfo.Items.Add("Write success!");
            }
            else
            {
                MessageBox.Show("ANJIM");
            }

            
        }

        private void tEpcData_TextChanged(object sender, EventArgs e)
        {
            if (((tEpcData.Text.Length - 4) % 5) == 0)
            {
                tEpcData.Text += " ";
                tEpcData.Select(tEpcData.Text.Length, 0);
            }
        }

        private void btnSecRead_Click(object sender, EventArgs e)
        {
            int membank;
            int wordptr;
            int wordcnt;
            int status = 0;
            byte[] value = new byte[16];

            string s = "The data is:";
            string s1 = "";
            if (tEpcAccess.TextLength != 8)
            {
                lInfo.Items.Add("Access Password length not enough");
                return;
            }
            uint unAccPwd;
            unAccPwd = Convert.ToUInt32(tEpcAccess.Text, 16);
            membank = cEpcMembank.SelectedIndex;
            wordptr = cEpcWordptr.SelectedIndex;
            wordcnt = cEpcWordcnt.SelectedIndex;

            status = Reader1.Gen2SecRead(unAccPwd, (byte)membank, (byte)wordptr, (byte)wordcnt, ref value);
            if (status != 0)
            {
                lInfo.Items.Add("Read failed!");
                return;
            }
            else
            {
                for (int i = 0; i < wordcnt * 2; i++)
                {
                    s1 = string.Format("{0:X2}", value[i]);
                    s += s1;
                }
                lInfo.Items.Add("Read success!");
                lInfo.Items.Add(s);
            }
        }

        private void btnSecWrite_Click(object sender, EventArgs e)
        {
            ushort[] value = new ushort[16];
            int i = 0;
            byte membank;
            byte wordptr;
            byte wordcnt;
            int status;
            string hexValues;

            membank = (byte)(cEpcMembank.SelectedIndex);
            wordptr = (byte)(cEpcWordptr.SelectedIndex);
            wordcnt = (byte)(cEpcWordcnt.SelectedIndex);
            uint unAccPwd;
            unAccPwd = Convert.ToUInt32(tEpcAccess.Text, 16);

            hexValues = tEpcData.Text;
            string[] hexValuesSplit = hexValues.Split(' ');
            foreach (String hex in hexValuesSplit)
            {
                // Convert the number expressed in base-16 to an integer.
                if (hex != "")
                {
                    int x = Convert.ToInt32(hex, 16);
                    value[i++] = (ushort)x;
                }
            }
            if (i != wordcnt)
            {
                lInfo.Items.Add("Please input data needed");
                return;
            }
            for (byte j = 0; j < wordcnt; j++)
            {
                status = Reader1.Gen2SecWrite(unAccPwd, membank, (byte)(wordptr + j), value[j]);
                if (status != 0)
                {
                    lInfo.Items.Add("Write failed!");
                    return;
                }
            }
            lInfo.Items.Add("Write success!");
        }

        private void bEpcKill_Click(object sender, EventArgs e)
        {
            int status = 0;
            byte[] value = new byte[16];

            string s = "";
            if (tEpcAccess.TextLength != 8)
            {
                lInfo.Items.Add("Access Password length not enough");
                return;
            }
            uint unAccPwd;
            unAccPwd = Convert.ToUInt32(tEpcAccess.Text, 16);
            status = Reader1.Gen2KillTag(unAccPwd);
            if (status != 0)
            {
                lInfo.Items.Add("Set Password failed!");
                return;
            }
            else
            {
                lInfo.Items.Add("Set Password success!");
                lInfo.Items.Add(s);
            }
        }

        private void btnSecLock_Click(object sender, EventArgs e)
        {
            byte membank;
            byte pwdLevel;

            int status = 0;
            byte[] value = new byte[16];

            string s = "";
            if (tEpcAccess.TextLength != 8)
            {
                lInfo.Items.Add("Access Password length not enough");
                return;
            }
            uint unAccPwd;
            switch (cEpcMembank.SelectedIndex)
            {
                case 0:
                    membank = 3;
                    break;
                case 1:
                    membank = 2;
                    break;
                case 2:
                    membank = 1;
                    break;
                case 3:
                    membank = 0;
                    break;
                default:
                    membank = 2;
                    break;
            }
            pwdLevel = (byte)(cmbLevel.SelectedIndex);

            unAccPwd = Convert.ToUInt32(tEpcAccess.Text, 16);
            status = Reader1.Gen2SecLock(unAccPwd, membank, pwdLevel);
            if (status != 0)
            {
                lInfo.Items.Add("Lock EPC tag failed!");
                return;
            }
            else
            {
                lInfo.Items.Add("Lock EPC tag success!");
                lInfo.Items.Add(s);
            }
        }

        private void btnSetAccessPWD_Click(object sender, EventArgs e)
        {
            int status = 0;
            byte[] value = new byte[16];

            string s = "";
            if (tEpcAccess.TextLength != 8)
            {
                lInfo.Items.Add("Access Password length not enough");
                return;
            }
            uint unAccPwd;
            unAccPwd = Convert.ToUInt32(tEpcAccess.Text, 16);
            status = Reader1.Gen2SetAccPwd(unAccPwd);
            if (status != 0)
            {
                lInfo.Items.Add("Set Password failed!");
                return;
            }
            else
            {
                lInfo.Items.Add("Set Password success!");
                lInfo.Items.Add(s);
            }
        }

        private void bReset_Click(object sender, EventArgs e)
        {
            Reader1.ResetReader();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timerPing_Tick(object sender, EventArgs e)
        {
            if (Reader1.CheckPing() > 0)
            {
                lInfo.Items.Add("Reader already dropped");
                // If you are identifying label,can immediately stop.
                if (1 == EpcReading)
                {
                    bEpcId_Click(sender, e);
                }
            }
        }

        private void timerScanEPC_Tick(object sender, EventArgs e)
        {
            string s5 = "";
            int status;
            int i, j;
            byte[,] IsoBuf = new byte[100, 12];
            byte tag_cnt = 0;
            string s = "";
            string s1 = "";
            byte tag_flag = 0;
            int listIn = 0;

            // Filter same tag
            if (!chkFilter.Checked)
                Reader1.ClearIdBuf();
            status = Reader1.EpcMultiTagIdentify(ref IsoBuf, ref tag_cnt, ref tag_flag);
            if (tag_cnt > 0)
            {
                for (i = 0; i < tag_cnt; i++)
                {
                    s1 = "";
                    for (j = 0; j < Convert.ToInt16(cEpcWordcnt.Text) * 2; j++)
                    {
                        s = string.Format("{0:X2} ", IsoBuf[i, j]);
                        s1 += s;
                        s5 += s;
                    }
                    //dataBaca = s5;
                    
                    
                    lInfo.Items.Add(s1);
                    ListViewItem lviList = new ListViewItem();
                    if (lvTagList.Items.Count <= 0)
                    {
                        lviList.SubItems[0].Text = "1";
                        lviList.SubItems.Add("");
                        lviList.SubItems.Add("");
                        lvTagList.Items.Add(lviList);
                        listIn = 0;
                        lvTagList.Items[listIn].SubItems[1].Text = s1;
                        lvTagList.Items[listIn].SubItems[2].Text = "1";
                    }
                    else
                    {
                        listIn = -1;
                        for (i = 0; i < lvTagList.Items.Count; i++)
                        {
                            if (lvTagList.Items[i].SubItems[1].Text == s1)
                            {
                                listIn = i;
                                break;
                            }
                        }
                        if (listIn < 0)
                        {
                            listIn = lvTagList.Items.Count;
                            lviList.SubItems[0].Text = Convert.ToString(listIn + 1);
                            lviList.SubItems.Add("");
                            lviList.SubItems.Add("");
                            lvTagList.Items.Add(lviList);
                            //comboBox1.SelectedIndex = 0;
                            
                        }
                        lvTagList.Items[listIn].SubItems[1].Text = s1;
                        //passing ke combobox
                        //if (comboBox1.Items.IndexOf(s1) == -1){
                        //    comboBox1.Items.Add(s1);
                        //}
                        //if ((comboBox1.Items.Count != 0))
                        //{
                        //    comboBox1.SelectedIndex = 0;
                        //}
                        if (lvTagList.Items[listIn].SubItems[2].Text == "")
                            lvTagList.Items[listIn].SubItems[2].Text = "0";
                        Int64 intTimes = Convert.ToInt64(lvTagList.Items[listIn].SubItems[2].Text);
                        lvTagList.Items[listIn].SubItems[2].Text = Convert.ToString(intTimes + 1);
                    }
                }
            }
            if (ScanTimes <= 0)
            {
                bEpcId_Click(sender, e);
                bEpcWrite_Click(sender, e);
            }
        }

        private void timerScanISO_Tick(object sender, EventArgs e)
        {
            int status;
            int i, j;
            byte[,] IsoBuf = new byte[100, 12];
            byte tag_cnt = 0;
            string s = "";
            string s1 = "";
            int listIn = 0;
            // Filter same tag
            if (!chkFilter.Checked)
                Reader1.ClearIdBuf();
            status = Reader1.IsoMultiTagIdentify(ref IsoBuf, ref tag_cnt);
            if (tag_cnt > 0)
            {
                for (i = 0; i < tag_cnt; i++)
                {
                    s1 = "";
                    for (j = 0; j < 8; j++)
                    {
                        s = string.Format("{0:X2} ", IsoBuf[i, j]);
                        s1 += s;
                    }
                    lInfo.Items.Add(s1);
                    ListViewItem lviList = new ListViewItem();
                    if (lvTagList.Items.Count <= 0)
                    {
                        lviList.SubItems[0].Text = "1";
                        for (i = 0; i <= 2; i++)
                            lviList.SubItems.Add("");
                        lvTagList.Items.Add(lviList);
                        listIn = 0;
                        lvTagList.Items[listIn].SubItems[1].Text = s1;
                        lvTagList.Items[listIn].SubItems[2].Text = "1";
                    }
                    else
                    {
                        listIn = -1;
                        for (i = 0; i < lvTagList.Items.Count; i++)
                        {
                            if (lvTagList.Items[i].SubItems[1].Text == s1)
                            {
                                listIn = i;
                                break;
                            }
                        }
                        if (listIn < 0)
                        {
                            listIn = lvTagList.Items.Count;
                            lviList.SubItems[0].Text = Convert.ToString(listIn + 1);
                            for (i = 0; i <= 2; i++)
                                lviList.SubItems.Add("");
                            lvTagList.Items.Add(lviList);
                        }
                        lvTagList.Items[listIn].SubItems[1].Text = s1;
                        if (lvTagList.Items[listIn].SubItems[2].Text == "")
                            lvTagList.Items[listIn].SubItems[2].Text = "0";
                        Int64 intTimes = Convert.ToInt64(lvTagList.Items[listIn].SubItems[2].Text);
                        lvTagList.Items[listIn].SubItems[2].Text = Convert.ToString(intTimes + 1);
                    }
                    TagCnt++;

                }
            }
            if (ScanTimes <= 0)
            {
                //bIsoId_Click(sender, e);
            }
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            Reader1.SetBaudRate(0);
            Reader1.CloseCommPort();
            Form1 home = new Form1();
            home.Show();
            this.Hide();
        }
    }
}
