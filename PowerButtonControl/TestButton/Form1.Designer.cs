namespace TestButton
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.onBtn = new System.Windows.Forms.Button();
            this.offBtn = new System.Windows.Forms.Button();
            this.togBtn = new System.Windows.Forms.Button();
            this.resultTxtBox = new System.Windows.Forms.TextBox();
            this.powerButton1 = new PowerButtonControl.PowerButton();
            this.SuspendLayout();
            // 
            // onBtn
            // 
            this.onBtn.AutoSize = true;
            this.onBtn.Location = new System.Drawing.Point(183, 36);
            this.onBtn.Name = "onBtn";
            this.onBtn.Size = new System.Drawing.Size(75, 27);
            this.onBtn.TabIndex = 1;
            this.onBtn.Text = "On";
            this.onBtn.UseVisualStyleBackColor = true;
            this.onBtn.Click += new System.EventHandler(this.onBtn_Click);
            // 
            // offBtn
            // 
            this.offBtn.AutoSize = true;
            this.offBtn.Location = new System.Drawing.Point(183, 80);
            this.offBtn.Name = "offBtn";
            this.offBtn.Size = new System.Drawing.Size(75, 27);
            this.offBtn.TabIndex = 2;
            this.offBtn.Text = "Off";
            this.offBtn.UseVisualStyleBackColor = true;
            this.offBtn.Click += new System.EventHandler(this.offBtn_Click);
            // 
            // togBtn
            // 
            this.togBtn.AutoSize = true;
            this.togBtn.Location = new System.Drawing.Point(183, 119);
            this.togBtn.Name = "togBtn";
            this.togBtn.Size = new System.Drawing.Size(75, 27);
            this.togBtn.TabIndex = 3;
            this.togBtn.Text = "Toggle";
            this.togBtn.UseVisualStyleBackColor = true;
            this.togBtn.Click += new System.EventHandler(this.togBtn_Click);
            // 
            // resultTxtBox
            // 
            this.resultTxtBox.Location = new System.Drawing.Point(54, 181);
            this.resultTxtBox.Name = "resultTxtBox";
            this.resultTxtBox.Size = new System.Drawing.Size(100, 22);
            this.resultTxtBox.TabIndex = 4;
            // 
            // powerButton1
            // 
            this.powerButton1.BackColor = System.Drawing.Color.Transparent;
            this.powerButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("powerButton1.BackgroundImage")));
            this.powerButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.powerButton1.Location = new System.Drawing.Point(12, 27);
            this.powerButton1.Name = "powerButton1";
            this.powerButton1.PowerOnState = false;
            this.powerButton1.Size = new System.Drawing.Size(123, 107);
            this.powerButton1.TabIndex = 0;
            this.powerButton1.PowerStateChanged += new System.EventHandler(this.powerButton1_PowerStateChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 227);
            this.Controls.Add(this.resultTxtBox);
            this.Controls.Add(this.togBtn);
            this.Controls.Add(this.offBtn);
            this.Controls.Add(this.onBtn);
            this.Controls.Add(this.powerButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PowerButtonControl.PowerButton powerButton1;
        private System.Windows.Forms.Button onBtn;
        private System.Windows.Forms.Button offBtn;
        private System.Windows.Forms.Button togBtn;
        private System.Windows.Forms.TextBox resultTxtBox;
    }
}

