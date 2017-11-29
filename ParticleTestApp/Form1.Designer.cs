namespace ParticleTestApp
{
   partial class Form1
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.statusStrip1 = new System.Windows.Forms.StatusStrip();
         this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
         this.colorDialog1 = new System.Windows.Forms.ColorDialog();
         this.text1 = new System.Windows.Forms.TextBox();
         this.btnSendText = new System.Windows.Forms.Button();
         this.btnPickColor = new System.Windows.Forms.Button();
         this.btnDateTime = new System.Windows.Forms.Button();
         this.chkScrolling1 = new System.Windows.Forms.CheckBox();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.sliderScrollSpeed = new System.Windows.Forms.NumericUpDown();
         this.sliderBrightness = new System.Windows.Forms.NumericUpDown();
         this.text4 = new System.Windows.Forms.TextBox();
         this.text3 = new System.Windows.Forms.TextBox();
         this.text2 = new System.Windows.Forms.TextBox();
         this.chkScrolling4 = new System.Windows.Forms.CheckBox();
         this.chkScrolling3 = new System.Windows.Forms.CheckBox();
         this.chkScrolling2 = new System.Windows.Forms.CheckBox();
         this.btnTemp = new System.Windows.Forms.Button();
         this.statusStrip1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.sliderScrollSpeed)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.sliderBrightness)).BeginInit();
         this.SuspendLayout();
         // 
         // statusStrip1
         // 
         this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
         this.statusStrip1.Location = new System.Drawing.Point(0, 240);
         this.statusStrip1.Name = "statusStrip1";
         this.statusStrip1.Size = new System.Drawing.Size(420, 22);
         this.statusStrip1.TabIndex = 0;
         this.statusStrip1.Text = "statusStrip1";
         // 
         // toolStripStatusLabel1
         // 
         this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
         this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
         this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
         // 
         // text1
         // 
         this.text1.Location = new System.Drawing.Point(12, 41);
         this.text1.Name = "text1";
         this.text1.Size = new System.Drawing.Size(260, 20);
         this.text1.TabIndex = 4;
         // 
         // btnSendText
         // 
         this.btnSendText.Enabled = false;
         this.btnSendText.Location = new System.Drawing.Point(333, 159);
         this.btnSendText.Name = "btnSendText";
         this.btnSendText.Size = new System.Drawing.Size(75, 23);
         this.btnSendText.TabIndex = 5;
         this.btnSendText.Text = "Send Text";
         this.btnSendText.UseVisualStyleBackColor = true;
         this.btnSendText.Click += new System.EventHandler(this.btnSendText_Click);
         // 
         // btnPickColor
         // 
         this.btnPickColor.Enabled = false;
         this.btnPickColor.Location = new System.Drawing.Point(12, 159);
         this.btnPickColor.Name = "btnPickColor";
         this.btnPickColor.Size = new System.Drawing.Size(75, 23);
         this.btnPickColor.TabIndex = 6;
         this.btnPickColor.Text = "Pick Color";
         this.btnPickColor.UseVisualStyleBackColor = true;
         this.btnPickColor.Click += new System.EventHandler(this.btnPickColor_Click);
         // 
         // btnDateTime
         // 
         this.btnDateTime.Enabled = false;
         this.btnDateTime.Location = new System.Drawing.Point(93, 159);
         this.btnDateTime.Name = "btnDateTime";
         this.btnDateTime.Size = new System.Drawing.Size(98, 23);
         this.btnDateTime.TabIndex = 7;
         this.btnDateTime.Text = "Show Date/Time";
         this.btnDateTime.UseVisualStyleBackColor = true;
         this.btnDateTime.Click += new System.EventHandler(this.btnDateTime_Click);
         // 
         // chkScrolling1
         // 
         this.chkScrolling1.AutoSize = true;
         this.chkScrolling1.Checked = true;
         this.chkScrolling1.CheckState = System.Windows.Forms.CheckState.Checked;
         this.chkScrolling1.Location = new System.Drawing.Point(278, 41);
         this.chkScrolling1.Name = "chkScrolling1";
         this.chkScrolling1.Size = new System.Drawing.Size(58, 17);
         this.chkScrolling1.TabIndex = 8;
         this.chkScrolling1.Text = "Scroll?";
         this.chkScrolling1.UseVisualStyleBackColor = true;
         this.chkScrolling1.CheckedChanged += new System.EventHandler(this.chkScrolling1_CheckedChanged);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(12, 194);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(67, 13);
         this.label1.TabIndex = 11;
         this.label1.Text = "Scroll Speed";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(194, 194);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(56, 13);
         this.label2.TabIndex = 12;
         this.label2.Text = "Brightness";
         // 
         // sliderScrollSpeed
         // 
         this.sliderScrollSpeed.Location = new System.Drawing.Point(15, 210);
         this.sliderScrollSpeed.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
         this.sliderScrollSpeed.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
         this.sliderScrollSpeed.Name = "sliderScrollSpeed";
         this.sliderScrollSpeed.Size = new System.Drawing.Size(72, 20);
         this.sliderScrollSpeed.TabIndex = 13;
         this.sliderScrollSpeed.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
         this.sliderScrollSpeed.ValueChanged += new System.EventHandler(this.sliderScrollSpeed_ValueChanged);
         // 
         // sliderBrightness
         // 
         this.sliderBrightness.Location = new System.Drawing.Point(197, 210);
         this.sliderBrightness.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
         this.sliderBrightness.Name = "sliderBrightness";
         this.sliderBrightness.Size = new System.Drawing.Size(75, 20);
         this.sliderBrightness.TabIndex = 14;
         this.sliderBrightness.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
         this.sliderBrightness.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
         // 
         // text4
         // 
         this.text4.Location = new System.Drawing.Point(12, 119);
         this.text4.Name = "text4";
         this.text4.Size = new System.Drawing.Size(260, 20);
         this.text4.TabIndex = 15;
         // 
         // text3
         // 
         this.text3.Location = new System.Drawing.Point(12, 93);
         this.text3.Name = "text3";
         this.text3.Size = new System.Drawing.Size(260, 20);
         this.text3.TabIndex = 16;
         // 
         // text2
         // 
         this.text2.Location = new System.Drawing.Point(12, 67);
         this.text2.Name = "text2";
         this.text2.Size = new System.Drawing.Size(260, 20);
         this.text2.TabIndex = 17;
         // 
         // chkScrolling4
         // 
         this.chkScrolling4.AutoSize = true;
         this.chkScrolling4.Checked = true;
         this.chkScrolling4.CheckState = System.Windows.Forms.CheckState.Checked;
         this.chkScrolling4.Location = new System.Drawing.Point(278, 122);
         this.chkScrolling4.Name = "chkScrolling4";
         this.chkScrolling4.Size = new System.Drawing.Size(58, 17);
         this.chkScrolling4.TabIndex = 18;
         this.chkScrolling4.Text = "Scroll?";
         this.chkScrolling4.UseVisualStyleBackColor = true;
         // 
         // chkScrolling3
         // 
         this.chkScrolling3.AutoSize = true;
         this.chkScrolling3.Checked = true;
         this.chkScrolling3.CheckState = System.Windows.Forms.CheckState.Checked;
         this.chkScrolling3.Location = new System.Drawing.Point(278, 96);
         this.chkScrolling3.Name = "chkScrolling3";
         this.chkScrolling3.Size = new System.Drawing.Size(58, 17);
         this.chkScrolling3.TabIndex = 19;
         this.chkScrolling3.Text = "Scroll?";
         this.chkScrolling3.UseVisualStyleBackColor = true;
         // 
         // chkScrolling2
         // 
         this.chkScrolling2.AutoSize = true;
         this.chkScrolling2.Checked = true;
         this.chkScrolling2.CheckState = System.Windows.Forms.CheckState.Checked;
         this.chkScrolling2.Location = new System.Drawing.Point(278, 70);
         this.chkScrolling2.Name = "chkScrolling2";
         this.chkScrolling2.Size = new System.Drawing.Size(58, 17);
         this.chkScrolling2.TabIndex = 20;
         this.chkScrolling2.Text = "Scroll?";
         this.chkScrolling2.UseVisualStyleBackColor = true;
         // 
         // btnTemp
         // 
         this.btnTemp.Enabled = false;
         this.btnTemp.Location = new System.Drawing.Point(197, 159);
         this.btnTemp.Name = "btnTemp";
         this.btnTemp.Size = new System.Drawing.Size(98, 23);
         this.btnTemp.TabIndex = 21;
         this.btnTemp.Text = "Show LocalTemp";
         this.btnTemp.UseVisualStyleBackColor = true;
         this.btnTemp.Click += new System.EventHandler(this.btnTemp_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(420, 262);
         this.Controls.Add(this.btnTemp);
         this.Controls.Add(this.chkScrolling2);
         this.Controls.Add(this.chkScrolling3);
         this.Controls.Add(this.chkScrolling4);
         this.Controls.Add(this.text2);
         this.Controls.Add(this.text3);
         this.Controls.Add(this.text4);
         this.Controls.Add(this.sliderBrightness);
         this.Controls.Add(this.sliderScrollSpeed);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.chkScrolling1);
         this.Controls.Add(this.btnDateTime);
         this.Controls.Add(this.btnPickColor);
         this.Controls.Add(this.btnSendText);
         this.Controls.Add(this.text1);
         this.Controls.Add(this.statusStrip1);
         this.Name = "Form1";
         this.Text = "Form1";
         this.statusStrip1.ResumeLayout(false);
         this.statusStrip1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.sliderScrollSpeed)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.sliderBrightness)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.StatusStrip statusStrip1;
      private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
      private System.Windows.Forms.ColorDialog colorDialog1;
      private System.Windows.Forms.TextBox text1;
      private System.Windows.Forms.Button btnSendText;
      private System.Windows.Forms.Button btnPickColor;
      private System.Windows.Forms.Button btnDateTime;
        private System.Windows.Forms.CheckBox chkScrolling1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown sliderScrollSpeed;
        private System.Windows.Forms.NumericUpDown sliderBrightness;
      private System.Windows.Forms.TextBox text4;
      private System.Windows.Forms.TextBox text3;
      private System.Windows.Forms.TextBox text2;
      private System.Windows.Forms.CheckBox chkScrolling4;
      private System.Windows.Forms.CheckBox chkScrolling3;
      private System.Windows.Forms.CheckBox chkScrolling2;
      private System.Windows.Forms.Button btnTemp;
   }
}

