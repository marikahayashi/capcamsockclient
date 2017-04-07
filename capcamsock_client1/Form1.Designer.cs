namespace capcamsock_client1
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
            this.pictureBox_cam2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_cam1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_clock = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer_clock = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox_cam3 = new System.Windows.Forms.PictureBox();
            this.pictureBox_cam4 = new System.Windows.Forms.PictureBox();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cam2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cam1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cam3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cam4)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 33;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox_cam2
            // 
            this.pictureBox_cam2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox_cam2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_cam2.Location = new System.Drawing.Point(352, 66);
            this.pictureBox_cam2.Name = "pictureBox_cam2";
            this.pictureBox_cam2.Size = new System.Drawing.Size(320, 240);
            this.pictureBox_cam2.TabIndex = 5;
            this.pictureBox_cam2.TabStop = false;
            this.pictureBox_cam2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_cam2_MouseClick);
            // 
            // pictureBox_cam1
            // 
            this.pictureBox_cam1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox_cam1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_cam1.Location = new System.Drawing.Point(15, 66);
            this.pictureBox_cam1.Name = "pictureBox_cam1";
            this.pictureBox_cam1.Size = new System.Drawing.Size(320, 240);
            this.pictureBox_cam1.TabIndex = 15;
            this.pictureBox_cam1.TabStop = false;
            this.pictureBox_cam1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_cam1_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(125, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Camera #1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(462, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Camera #2";
            // 
            // label_clock
            // 
            this.label_clock.AutoSize = true;
            this.label_clock.Location = new System.Drawing.Point(537, 9);
            this.label_clock.Name = "label_clock";
            this.label_clock.Size = new System.Drawing.Size(87, 15);
            this.label_clock.TabIndex = 22;
            this.label_clock.Text = "2017-03-20";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer_clock
            // 
            this.timer_clock.Enabled = true;
            this.timer_clock.Interval = 1000;
            this.timer_clock.Tick += new System.EventHandler(this.timer_clock_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(462, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Camera #4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(125, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Camera #3";
            // 
            // pictureBox_cam3
            // 
            this.pictureBox_cam3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox_cam3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_cam3.Location = new System.Drawing.Point(15, 340);
            this.pictureBox_cam3.Name = "pictureBox_cam3";
            this.pictureBox_cam3.Size = new System.Drawing.Size(320, 240);
            this.pictureBox_cam3.TabIndex = 24;
            this.pictureBox_cam3.TabStop = false;
            this.pictureBox_cam3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_cam3_MouseClick);
            // 
            // pictureBox_cam4
            // 
            this.pictureBox_cam4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox_cam4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_cam4.Location = new System.Drawing.Point(352, 340);
            this.pictureBox_cam4.Name = "pictureBox_cam4";
            this.pictureBox_cam4.Size = new System.Drawing.Size(320, 240);
            this.pictureBox_cam4.TabIndex = 23;
            this.pictureBox_cam4.TabStop = false;
            this.pictureBox_cam4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_cam4_MouseClick);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Enabled = true;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 593);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox_cam3);
            this.Controls.Add(this.pictureBox_cam4);
            this.Controls.Add(this.label_clock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox_cam1);
            this.Controls.Add(this.pictureBox_cam2);
            this.Name = "Form1";
            this.Text = "capture cameras";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cam2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cam1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cam3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cam4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.PictureBox pictureBox_cam2;
        public System.Windows.Forms.PictureBox pictureBox_cam1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_clock;
        private System.Windows.Forms.Timer timer_clock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.PictureBox pictureBox_cam3;
        public System.Windows.Forms.PictureBox pictureBox_cam4;
        //private System.Windows.Forms.Timer timer3;
        //private System.Windows.Forms.Timer timer4;
        //private System.Windows.Forms.Timer timer2;
    }
}

