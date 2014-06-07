using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VTR_Controller
{
    public partial class Form1 : Form
    {
        private bool playing = false;
        private bool start = false;

        public Form1()
        {
            InitializeComponent();
            serialPort1.Open();
            ckStateOfDevice();
            sendCode("QCD");
        }

        private void ckStateOfDevice()
        {
            start = true;
            sendCode("QOP");
        }

        private void sendCode(string arg)
        {
            try
            {
                char sTX = (char)0x02;
                char eTX = (char)0x03;
                string str = sTX + arg + eTX;
                serialPort1.Write(str);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string dataRead = serialPort1.ReadExisting();

            if (start)
            {
                if (dataRead.Contains("POF"))
                {
                    powerBtn.PowerOnState = false;
                }
                else
                {
                    powerBtn.PowerOnState = true;

                    //todo: OtherOptions

                    if (dataRead.Contains("OEJ"))
                    {
                        MessageBox.Show("The VTR is Empty", "No Tape", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (dataRead.Contains("OPL"))
                    {
                        playing = true;
                        playBtn.Image = new Bitmap(VTR_Controller.Properties.Resources.Pause);
                    }
                }
                start = false;
            }

            if (dataRead.Contains("CD"))
            {
                updateTapeLoc(dataRead);
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort1.Close();
        }

        #region Play Button

        private void playBtn_MouseEnter(object sender, EventArgs e)
        {
            if (playing)
            {
                playBtn.Image = new Bitmap(VTR_Controller.Properties.Resources.PauseH);
            }
            else
            {
                playBtn.Image = new Bitmap(VTR_Controller.Properties.Resources.PlayButtonH);

            }


        }

        private void playBtn_MouseLeave(object sender, EventArgs e)
        {
            if (playing)
            {
                playBtn.Image = new Bitmap(VTR_Controller.Properties.Resources.Pause);
            }
            else
            {
                playBtn.Image = new Bitmap(VTR_Controller.Properties.Resources.PlayButton);
            }
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            if (playing)
            {
                playing = false;
                playBtn.Image = new Bitmap(VTR_Controller.Properties.Resources.PlayButton);
                sendCode("OPA");
            }
            else
            {
                playing = true;
                playBtn.Image = new Bitmap(VTR_Controller.Properties.Resources.Pause);
                sendCode("OPL");
            }
        }

        private void stopPlaying()
        {
            try
            {
                playing = false;
                playBtn.Image = new Bitmap(VTR_Controller.Properties.Resources.PlayButton);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Stop Button

        private void stopBtn_MouseEnter(object sender, EventArgs e)
        {
            var image = new Bitmap(VTR_Controller.Properties.Resources.StopButtonH);
            stopBtn.Image = image;
        }

        private void stopBtn_MouseLeave(object sender, EventArgs e)
        {
            var image = new Bitmap(VTR_Controller.Properties.Resources.StopButton);
            stopBtn.Image = image;
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            sendCode("OSP");
            playing = false;
            stopPlaying();
        }

        #endregion

        #region FastForward Button

        private void fastFwdBtn_Click(object sender, EventArgs e)
        {
            sendCode("OFF");
            stopPlaying();
        }

        #endregion

        #region Rewind Button

        private void rewBtn_Click(object sender, EventArgs e)
        {
            sendCode("ORW");
            stopPlaying();
        }

        #endregion



        #region Search Function

        private void ffNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (ffNumUpDown.Value == ffNumUpDown.Maximum)
            {
                secNumUpDown.Value++;
                ffNumUpDown.Value = 0;
            }
            calcValue();
        }

        private void secNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (secNumUpDown.Value == secNumUpDown.Maximum)
            {
                minNumUpDown.Value++;
                secNumUpDown.Value = 0;
            }
            calcValue();
        }

        private void minNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (minNumUpDown.Value == minNumUpDown.Maximum)
            {
                hrNumUpDown.Value++;
                minNumUpDown.Value = 0;
            }
            calcValue();
        }

        private void hrNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (hrNumUpDown.Value == hrNumUpDown.Maximum)
            {
                ffNumUpDown.Value = 0;
                secNumUpDown.Value = 0;
                minNumUpDown.Value = 0;
                hrNumUpDown.Value = 0;
            }
            calcValue();

        }

        private void negCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            negSign.Visible = negCheckBox.Checked;
            smNegLbl.Visible = negCheckBox.Checked;
        }

        private string calcValue()
        {
            string appendedText = null;
            try
            {
                var frame = ffNumUpDown.Value;
                var sec = secNumUpDown.Value;
                var min = minNumUpDown.Value;
                var hr = hrNumUpDown.Value;

                appendedText = String.Format("{0:0}", hr) +
                    String.Format("{0:00}", min) +
                    String.Format("{0:00}", sec) +
                    String.Format("{0:00}", frame);
                timeLabel.Text = appendedText;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return appendedText;
        }

        private void cSearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string negSign = " ";
                if (negCheckBox.Checked) negSign = "-";

                sendCode("SMC");

                if (playAftSearchChkBox.Checked)
                {
                    sendCode("SCP:" + negSign + calcValue());
                }
                else
                {
                    sendCode("SCS:" + negSign + calcValue());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fSearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string negSign = " ";
                if (negCheckBox.Checked) negSign = "-";

                sendCode("SMF");

                if (playAftSearchChkBox.Checked)
                {
                    sendCode("SCP:" + negSign + calcValue());
                }
                else
                {
                    sendCode("SCS:" + negSign + calcValue());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion


        private void updateTapeLoc(string locationStr)
        {
            if (locationStr != null )
            {
                 int firstCharacter = locationStr.IndexOf("CD");

                string tapeLocationStr = locationStr.Substring(firstCharacter+4);
                char[] locArray = tapeLocationStr.ToCharArray();
                if (locArray.Length >= 8)
                {
                    if (locArray[0] == '-')
                    {
                        Invoke((MethodInvoker)(() =>
                        {
                            negCheckBox.Checked = true;
                        }));
                    }
                    else
                    {
                        Invoke((MethodInvoker)(() =>
                        {
                            negCheckBox.Checked = false;
                        }));
                    }

                    Invoke((MethodInvoker)(() =>
                    {
                        try
                        {
                            hrNumUpDown.Value = Decimal.Parse(locArray[1].ToString());
                            minNumUpDown.Value = Decimal.Parse(locArray[2].ToString() + locArray[3]);
                            secNumUpDown.Value = Decimal.Parse(locArray[4].ToString() + locArray[5]);
                            ffNumUpDown.Value = Decimal.Parse(locArray[6].ToString() + locArray[7]);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            hrNumUpDown.Value = 0;
                            minNumUpDown.Value = 0;
                            secNumUpDown.Value = 0;
                            ffNumUpDown.Value = 0;

                        }
                    }));
                }
            }
        }


        private void powerBtn_PowerStateChanged(object sender, EventArgs e)
        {
            if (powerBtn.PowerOnState)
            {
                sendCode("PON");
                getLocation();
            }
            else
            {
                sendCode("POF");
                stopPlaying();
            }

        }



        private void getLocation()
        {
            sendCode("QCD");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getLocation();

        }







    }
}
