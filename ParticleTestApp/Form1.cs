using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
using Microsoft.VisualBasic;
using System.Threading;

namespace ParticleTestApp
{
   public partial class Form1 : Form
   {
      ParticleDevice myDevice = null;

      private String particleToken = Properties.Settings.Default.ParticleToken;

      private bool loggingIn = false;
      private bool loginGood = false;

      public Form1()
      {
         InitializeComponent();
         ParticleCloud.SharedCloud.SynchronizationContext = System.Threading.SynchronizationContext.Current;

         toolStripStatusLabel1.Text = "Attempting to connect to cloud...";

         if (particleToken.ToLower() == "none")
         {
            // ask user for particle token
            particleToken = Interaction.InputBox("Please enter Particle.io Token.", "Invalid Particle.io Token", "Default Text");
            Properties.Settings.Default.ParticleToken = particleToken;
            Properties.Settings.Default.Save();
         }

         //while(!loginGood)
         {
            if(!loggingIn)
               login();

            //Thread.Sleep(100);

            //if(!loggingIn && !loginGood)
            {
               //particleToken = Interaction.InputBox("Please enter Particle.io Token.", "Invalid Particle.io Token", "token");
               //Properties.Settings.Default.ParticleToken = particleToken;
               //Properties.Settings.Default.Save();
            }
         }
         

         //getDevice();

         //if (null != myDevice)
         //   MessageBox.Show("Device Connected: " + myDevice.Connected);
         //else
         //   MessageBox.Show("myDevice is still null...");
      }

      public async void login()
      {
         loggingIn = true;
         Boolean success = false;
         do
         {
            string particleToken = Properties.Settings.Default.ParticleToken;
            success = await ParticleCloud.SharedCloud.TokenLoginAsync(particleToken);

            if (success)
            {
               loginGood = true;
               toolStripStatusLabel1.Text = "Logged in...";
               connectToDevice();
            }
            else
            {
               loginGood = false;
               toolStripStatusLabel1.Text = "Error Logging in...";

               particleToken = Interaction.InputBox("Please enter Particle.io Token.", "Invalid Particle.io Token", particleToken);
               Properties.Settings.Default.ParticleToken = particleToken;
               Properties.Settings.Default.Save();

            }
         } while (!success);

         loggingIn = false;
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
         sendText(text1.Text);

      }
      private async void sendText(string text)
      {
         var functionResponce = await myDevice.RunFunctionAsync("led", text);
         int result = functionResponce.ReturnValue;

         //         MessageBox.Show("SendText reply: " + result + ", " + functionResponce.ToString());
      }

      private void chkScrolling1_CheckedChanged(object sender, EventArgs e)
      {
         if (chkScrolling1.Checked == true)
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
         if (colorDialog1.ShowDialog() == DialogResult.OK)
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

      private void btnTemp_Click(object sender, EventArgs e)
      {
         sendText("#7");
      }

   }
}
