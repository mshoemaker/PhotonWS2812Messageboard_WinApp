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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSendText = new System.Windows.Forms.Button();
            this.btnPickColor = new System.Windows.Forms.Button();
            this.btnDateTime = new System.Windows.Forms.Button();
            this.chkScrolling = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sliderScrollSpeed = new System.Windows.Forms.NumericUpDown();
            this.sliderBrightness = new System.Windows.Forms.NumericUpDown();
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
            this.statusStrip1.Size = new System.Drawing.Size(284, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 20);
            this.textBox1.TabIndex = 4;
            // 
            // btnSendText
            // 
            this.btnSendText.Enabled = false;
            this.btnSendText.Location = new System.Drawing.Point(197, 90);
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
            this.btnPickColor.Location = new System.Drawing.Point(12, 90);
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
            this.btnDateTime.Location = new System.Drawing.Point(93, 90);
            this.btnDateTime.Name = "btnDateTime";
            this.btnDateTime.Size = new System.Drawing.Size(98, 23);
            this.btnDateTime.TabIndex = 7;
            this.btnDateTime.Text = "Show Date/Time";
            this.btnDateTime.UseVisualStyleBackColor = true;
            this.btnDateTime.Click += new System.EventHandler(this.btnDateTime_Click);
            // 
            // chkScrolling
            // 
            this.chkScrolling.AutoSize = true;
            this.chkScrolling.Checked = true;
            this.chkScrolling.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkScrolling.Location = new System.Drawing.Point(12, 18);
            this.chkScrolling.Name = "chkScrolling";
            this.chkScrolling.Size = new System.Drawing.Size(58, 17);
            this.chkScrolling.TabIndex = 8;
            this.chkScrolling.Text = "Scroll?";
            this.chkScrolling.UseVisualStyleBackColor = true;
            this.chkScrolling.CheckedChanged += new System.EventHandler(this.chkScrolling_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Scroll Speed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Brightness";
            // 
            // sliderScrollSpeed
            // 
            this.sliderScrollSpeed.Location = new System.Drawing.Point(15, 141);
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
            this.sliderBrightness.Location = new System.Drawing.Point(197, 141);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.sliderBrightness);
            this.Controls.Add(this.sliderScrollSpeed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkScrolling);
            this.Controls.Add(this.btnDateTime);
            this.Controls.Add(this.btnPickColor);
            this.Controls.Add(this.btnSendText);
            this.Controls.Add(this.textBox1);
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
      private System.Windows.Forms.TextBox textBox1;
      private System.Windows.Forms.Button btnSendText;
      private System.Windows.Forms.Button btnPickColor;
      private System.Windows.Forms.Button btnDateTime;
        private System.Windows.Forms.CheckBox chkScrolling;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown sliderScrollSpeed;
        private System.Windows.Forms.NumericUpDown sliderBrightness;
    }
}

