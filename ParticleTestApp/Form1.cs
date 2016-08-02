using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Particle.SDK;
using Particle.SDK.Models;
using Particle.SDK.RestApi;
using Particle.SDK.Utils;

namespace ParticleTestApp
{
   public partial class Form1 : Form
   {
      ParticleDevice myDevice = null;

      public Form1()
      {
         InitializeComponent();
         ParticleCloud.SharedCloud.SynchronizationContext = System.Threading.SynchronizationContext.Current;

         toolStripStatusLabel1.Text = "Attempting to connect to cloud...";
         login();

         //getDevice();

         //if (null != myDevice)
         //   MessageBox.Show("Device Connected: " + myDevice.Connected);
         //else
         //   MessageBox.Show("myDevice is still null...");
      }

      public async void login()
      {

         Boolean success = await ParticleCloud.SharedCloud.TokenLoginAsync("PARTICLE TOKEN");
         if (success)
         {
            toolStripStatusLabel1.Text = "Logged in...";
            connectToDevice();
         }
         else
            toolStripStatusLabel1.Text = "Error Logging in...";
      }

      public async void connectToDevice()
      {
         myDevice = await ParticleCloud.SharedCloud.GetDeviceAsync("DEVICE_ID");
            if (null != myDevice)
            {
                toolStripStatusLabel1.Text = "Device Connected: " + myDevice.Connected;
                btnDateTime.Enabled = true;
                this.btnPickColor.Enabled = true;
                btnSendText.Enabled = true;
            }
            else
            {
                toolStripStatusLabel1.Text = "myDevice is still null...";
                MessageBox.Show("Device was last seen: " + myDevice.LastHeard);
            }
      }

      private void button1_Click(object sender, EventArgs e)
      {
            if (null != myDevice)
            {
                ParticleCloud.SharedCloud.Logout();
                toolStripStatusLabel1.Text = "Logged out...";
            }
            else
                connectToDevice();

      }

      private void btnSendText_Click(object sender, EventArgs e)
      {
         sendText(textBox1.Text);

      }
      private async void sendText(string text)
      {
         var functionResponce = await myDevice.RunFunctionAsync("led", text);
         int result = functionResponce.ReturnValue;

//         MessageBox.Show("SendText reply: " + result + ", " + functionResponce.ToString());
      }
        
      private void chkScrolling_CheckedChanged(object sender, EventArgs e)
      {
            if (chkScrolling.Checked == true)
                sendText("#51");
            else
                sendText("#50"); 
      }

        private void btnDateTime_Click(object sender, EventArgs e)
        {
            sendText("#6");
        }

        private void btnPickColor_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color c = colorDialog1.Color;
                sendText("#3," + c.R.ToString() + "," + c.G.ToString() + "," + c.B.ToString());
            }
        }

        private void trackScrollSpeed_ValueChanged(object sender, EventArgs e)
        {
        }

        private void trackBrightness_Scroll(object sender, EventArgs e)
        {
        }

        private void sliderScrollSpeed_ValueChanged(object sender, EventArgs e)
        {
            sendText("#2" + sliderScrollSpeed.Value);
            MessageBox.Show("Value: " + sliderScrollSpeed.Value);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            sendText("#4" + sliderBrightness.Value);
        }
    }
}
