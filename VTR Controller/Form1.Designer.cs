namespace VTR_Controller
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.fastFwdBtn = new System.Windows.Forms.Button();
            this.rewBtn = new System.Windows.Forms.Button();
            this.minNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.hrNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.negCheckBox = new System.Windows.Forms.CheckBox();
            this.negSign = new System.Windows.Forms.Label();
            this.secNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.ffNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.smNegLbl = new System.Windows.Forms.Label();
            this.playAftSearchChkBox = new System.Windows.Forms.CheckBox();
            this.fSearchBtn = new System.Windows.Forms.Button();
            this.cSearchBtn = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stopBtn = new System.Windows.Forms.Button();
            this.playBtn = new System.Windows.Forms.Button();
            this.powerBtn = new PowerButtonControl.PowerButton();
            this.button1 = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.minNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hrNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ffNumUpDown)).BeginInit();
            this.searchGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataBits = 7;
            this.serialPort1.Parity = System.IO.Ports.Parity.Odd;
            this.serialPort1.PortName = "COM8";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // fastFwdBtn
            // 
            this.fastFwdBtn.Location = new System.Drawing.Point(308, 178);
            this.fastFwdBtn.Name = "fastFwdBtn";
            this.fastFwdBtn.Size = new System.Drawing.Size(47, 46);
            this.fastFwdBtn.TabIndex = 3;
            this.fastFwdBtn.Text = "FF";
            this.fastFwdBtn.UseVisualStyleBackColor = true;
            this.fastFwdBtn.Click += new System.EventHandler(this.fastFwdBtn_Click);
            // 
            // rewBtn
            // 
            this.rewBtn.Location = new System.Drawing.Point(80, 178);
            this.rewBtn.Name = "rewBtn";
            this.rewBtn.Size = new System.Drawing.Size(47, 46);
            this.rewBtn.TabIndex = 4;
            this.rewBtn.Text = "RW";
            this.rewBtn.UseVisualStyleBackColor = true;
            this.rewBtn.Click += new System.EventHandler(this.rewBtn_Click);
            // 
            // minNumUpDown
            // 
            this.minNumUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minNumUpDown.Location = new System.Drawing.Point(161, 36);
            this.minNumUpDown.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.minNumUpDown.Name = "minNumUpDown";
            this.minNumUpDown.Size = new System.Drawing.Size(43, 26);
            this.minNumUpDown.TabIndex = 5;
            this.minNumUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.minNumUpDown.ValueChanged += new System.EventHandler(this.minNumUpDown_ValueChanged);
            // 
            // hrNumUpDown
            // 
            this.hrNumUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hrNumUpDown.Location = new System.Drawing.Point(120, 36);
            this.hrNumUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.hrNumUpDown.Name = "hrNumUpDown";
            this.hrNumUpDown.Size = new System.Drawing.Size(34, 26);
            this.hrNumUpDown.TabIndex = 6;
            this.hrNumUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.hrNumUpDown.ValueChanged += new System.EventHandler(this.hrNumUpDown_ValueChanged);
            // 
            // negCheckBox
            // 
            this.negCheckBox.AutoSize = true;
            this.negCheckBox.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.negCheckBox.Location = new System.Drawing.Point(26, 20);
            this.negCheckBox.Name = "negCheckBox";
            this.negCheckBox.Size = new System.Drawing.Size(69, 17);
            this.negCheckBox.TabIndex = 7;
            this.negCheckBox.Text = "Negative";
            this.negCheckBox.UseVisualStyleBackColor = true;
            this.negCheckBox.CheckedChanged += new System.EventHandler(this.negCheckBox_CheckedChanged);
            // 
            // negSign
            // 
            this.negSign.AutoSize = true;
            this.negSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.negSign.Location = new System.Drawing.Point(101, 35);
            this.negSign.Name = "negSign";
            this.negSign.Size = new System.Drawing.Size(17, 24);
            this.negSign.TabIndex = 8;
            this.negSign.Text = "-";
            this.negSign.Visible = false;
            // 
            // secNumUpDown
            // 
            this.secNumUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secNumUpDown.Location = new System.Drawing.Point(211, 36);
            this.secNumUpDown.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.secNumUpDown.Name = "secNumUpDown";
            this.secNumUpDown.Size = new System.Drawing.Size(43, 26);
            this.secNumUpDown.TabIndex = 9;
            this.secNumUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.secNumUpDown.ValueChanged += new System.EventHandler(this.secNumUpDown_ValueChanged);
            // 
            // ffNumUpDown
            // 
            this.ffNumUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ffNumUpDown.Location = new System.Drawing.Point(261, 36);
            this.ffNumUpDown.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.ffNumUpDown.Name = "ffNumUpDown";
            this.ffNumUpDown.Size = new System.Drawing.Size(43, 26);
            this.ffNumUpDown.TabIndex = 10;
            this.ffNumUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ffNumUpDown.ValueChanged += new System.EventHandler(this.ffNumUpDown_ValueChanged);
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.updateBtn);
            this.searchGroupBox.Controls.Add(this.smNegLbl);
            this.searchGroupBox.Controls.Add(this.playAftSearchChkBox);
            this.searchGroupBox.Controls.Add(this.fSearchBtn);
            this.searchGroupBox.Controls.Add(this.cSearchBtn);
            this.searchGroupBox.Controls.Add(this.timeLabel);
            this.searchGroupBox.Controls.Add(this.label4);
            this.searchGroupBox.Controls.Add(this.label3);
            this.searchGroupBox.Controls.Add(this.label2);
            this.searchGroupBox.Controls.Add(this.label1);
            this.searchGroupBox.Controls.Add(this.ffNumUpDown);
            this.searchGroupBox.Controls.Add(this.minNumUpDown);
            this.searchGroupBox.Controls.Add(this.secNumUpDown);
            this.searchGroupBox.Controls.Add(this.hrNumUpDown);
            this.searchGroupBox.Controls.Add(this.negSign);
            this.searchGroupBox.Controls.Add(this.negCheckBox);
            this.searchGroupBox.ForeColor = System.Drawing.Color.White;
            this.searchGroupBox.Location = new System.Drawing.Point(172, 23);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(310, 126);
            this.searchGroupBox.TabIndex = 11;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Search";
            // 
            // smNegLbl
            // 
            this.smNegLbl.AutoSize = true;
            this.smNegLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smNegLbl.Location = new System.Drawing.Point(233, 105);
            this.smNegLbl.Name = "smNegLbl";
            this.smNegLbl.Size = new System.Drawing.Size(11, 13);
            this.smNegLbl.TabIndex = 18;
            this.smNegLbl.Text = "-";
            this.smNegLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.smNegLbl.Visible = false;
            // 
            // playAftSearchChkBox
            // 
            this.playAftSearchChkBox.AutoSize = true;
            this.playAftSearchChkBox.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.playAftSearchChkBox.Location = new System.Drawing.Point(7, 102);
            this.playAftSearchChkBox.Name = "playAftSearchChkBox";
            this.playAftSearchChkBox.Size = new System.Drawing.Size(111, 17);
            this.playAftSearchChkBox.TabIndex = 17;
            this.playAftSearchChkBox.Text = "Play after search?";
            this.playAftSearchChkBox.UseVisualStyleBackColor = true;
            // 
            // fSearchBtn
            // 
            this.fSearchBtn.ForeColor = System.Drawing.Color.Black;
            this.fSearchBtn.Location = new System.Drawing.Point(229, 71);
            this.fSearchBtn.Name = "fSearchBtn";
            this.fSearchBtn.Size = new System.Drawing.Size(75, 22);
            this.fSearchBtn.TabIndex = 16;
            this.fSearchBtn.Text = "F. Search";
            this.fSearchBtn.UseVisualStyleBackColor = true;
            this.fSearchBtn.Click += new System.EventHandler(this.fSearchBtn_Click);
            // 
            // cSearchBtn
            // 
            this.cSearchBtn.ForeColor = System.Drawing.Color.Black;
            this.cSearchBtn.Location = new System.Drawing.Point(148, 71);
            this.cSearchBtn.Name = "cSearchBtn";
            this.cSearchBtn.Size = new System.Drawing.Size(75, 22);
            this.cSearchBtn.TabIndex = 12;
            this.cSearchBtn.Text = "C. Search";
            this.cSearchBtn.UseVisualStyleBackColor = true;
            this.cSearchBtn.Click += new System.EventHandler(this.cSearchBtn_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AsciiOnly = true;
            this.timeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timeLabel.ForeColor = System.Drawing.Color.White;
            this.timeLabel.Location = new System.Drawing.Point(245, 106);
            this.timeLabel.Mask = "0:00:00:00";
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.ReadOnly = true;
            this.timeLabel.Size = new System.Drawing.Size(59, 13);
            this.timeLabel.TabIndex = 15;
            this.timeLabel.Text = "0000000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Frame";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Sec.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Min.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Hr.";
            // 
            // stopBtn
            // 
            this.stopBtn.FlatAppearance.BorderSize = 0;
            this.stopBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.stopBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.stopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopBtn.Image = global::VTR_Controller.Properties.Resources.StopButton;
            this.stopBtn.Location = new System.Drawing.Point(214, 171);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(75, 61);
            this.stopBtn.TabIndex = 2;
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            this.stopBtn.MouseEnter += new System.EventHandler(this.stopBtn_MouseEnter);
            this.stopBtn.MouseLeave += new System.EventHandler(this.stopBtn_MouseLeave);
            // 
            // playBtn
            // 
            this.playBtn.FlatAppearance.BorderSize = 0;
            this.playBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.playBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.playBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playBtn.Image = global::VTR_Controller.Properties.Resources.PlayButton;
            this.playBtn.Location = new System.Drawing.Point(133, 171);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(75, 61);
            this.playBtn.TabIndex = 1;
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            this.playBtn.MouseEnter += new System.EventHandler(this.playBtn_MouseEnter);
            this.playBtn.MouseLeave += new System.EventHandler(this.playBtn_MouseLeave);
            // 
            // powerBtn
            // 
            this.powerBtn.BackColor = System.Drawing.Color.Transparent;
            this.powerBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("powerBtn.BackgroundImage")));
            this.powerBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.powerBtn.Location = new System.Drawing.Point(11, 11);
            this.powerBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.powerBtn.Name = "powerBtn";
            this.powerBtn.PowerOnState = false;
            this.powerBtn.Size = new System.Drawing.Size(80, 86);
            this.powerBtn.TabIndex = 12;
            this.powerBtn.PowerStateChanged += new System.EventHandler(this.powerBtn_PowerStateChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(401, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.updateBtn.FlatAppearance.BorderSize = 0;
            this.updateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.updateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.Location = new System.Drawing.Point(161, 99);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(59, 24);
            this.updateBtn.TabIndex = 14;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(504, 298);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.powerBtn);
            this.Controls.Add(this.searchGroupBox);
            this.Controls.Add(this.rewBtn);
            this.Controls.Add(this.fastFwdBtn);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.playBtn);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "VTR Controller";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.minNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hrNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ffNumUpDown)).EndInit();
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button fastFwdBtn;
        private System.Windows.Forms.Button rewBtn;
        private System.Windows.Forms.NumericUpDown minNumUpDown;
        private System.Windows.Forms.NumericUpDown hrNumUpDown;
        private System.Windows.Forms.CheckBox negCheckBox;
        private System.Windows.Forms.Label negSign;
        private System.Windows.Forms.NumericUpDown secNumUpDown;
        private System.Windows.Forms.NumericUpDown ffNumUpDown;
        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox timeLabel;
        private System.Windows.Forms.Button fSearchBtn;
        private System.Windows.Forms.Button cSearchBtn;
        private System.Windows.Forms.CheckBox playAftSearchChkBox;
        private System.Windows.Forms.Label smNegLbl;
        private PowerButtonControl.PowerButton powerBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button updateBtn;
    }
}

