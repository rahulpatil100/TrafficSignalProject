namespace Traffic
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.car = new System.Windows.Forms.PictureBox();
            this.greenStopLight = new System.Windows.Forms.PictureBox();
            this.yellowStopLight = new System.Windows.Forms.PictureBox();
            this.redStopLight = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenStopLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowStopLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redStopLight)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(508, 82);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(89, 38);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(508, 150);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(89, 41);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // car
            // 
            this.car.Image = global::Traffic.Properties.Resources.Car_2_icon;
            this.car.Location = new System.Drawing.Point(44, 353);
            this.car.Name = "car";
            this.car.Size = new System.Drawing.Size(96, 96);
            this.car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.car.TabIndex = 5;
            this.car.TabStop = false;
            // 
            // greenStopLight
            // 
            this.greenStopLight.Image = global::Traffic.Properties.Resources.red;
            this.greenStopLight.Location = new System.Drawing.Point(219, 49);
            this.greenStopLight.Name = "greenStopLight";
            this.greenStopLight.Size = new System.Drawing.Size(215, 257);
            this.greenStopLight.TabIndex = 2;
            this.greenStopLight.TabStop = false;
            // 
            // yellowStopLight
            // 
            this.yellowStopLight.Image = global::Traffic.Properties.Resources.ye;
            this.yellowStopLight.Location = new System.Drawing.Point(218, 49);
            this.yellowStopLight.Name = "yellowStopLight";
            this.yellowStopLight.Size = new System.Drawing.Size(216, 257);
            this.yellowStopLight.TabIndex = 1;
            this.yellowStopLight.TabStop = false;
            // 
            // redStopLight
            // 
            this.redStopLight.Image = global::Traffic.Properties.Resources.Traffic_light_icon;
            this.redStopLight.Location = new System.Drawing.Point(218, 49);
            this.redStopLight.Name = "redStopLight";
            this.redStopLight.Size = new System.Drawing.Size(217, 258);
            this.redStopLight.TabIndex = 0;
            this.redStopLight.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Traffic.Properties.Resources._1;
            this.ClientSize = new System.Drawing.Size(683, 511);
            this.Controls.Add(this.car);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.greenStopLight);
            this.Controls.Add(this.yellowStopLight);
            this.Controls.Add(this.redStopLight);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenStopLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowStopLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redStopLight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox redStopLight;
        private System.Windows.Forms.PictureBox yellowStopLight;
        private System.Windows.Forms.PictureBox greenStopLight;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.PictureBox car;
        private System.Windows.Forms.Timer timer2;
    }
}

