namespace TimeTableManagementSystemApp.IT18050240
{
    partial class ManageWorkingDays
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.viewTimeTableBtn = new System.Windows.Forms.Button();
            this.addWorkingDayBtn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.manageWorkingDayPanel = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.PictureBox();
            this.miniBtn = new System.Windows.Forms.PictureBox();
            this.maxBtn = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(71)))));
            this.panel1.Controls.Add(this.viewTimeTableBtn);
            this.panel1.Controls.Add(this.addWorkingDayBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 768);
            this.panel1.TabIndex = 0;
            // 
            // viewTimeTableBtn
            // 
            this.viewTimeTableBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.viewTimeTableBtn.FlatAppearance.BorderSize = 0;
            this.viewTimeTableBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewTimeTableBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewTimeTableBtn.ForeColor = System.Drawing.Color.White;
            this.viewTimeTableBtn.Location = new System.Drawing.Point(6, 187);
            this.viewTimeTableBtn.Name = "viewTimeTableBtn";
            this.viewTimeTableBtn.Size = new System.Drawing.Size(238, 50);
            this.viewTimeTableBtn.TabIndex = 1;
            this.viewTimeTableBtn.Text = "VIEW TIME TABLE";
            this.viewTimeTableBtn.UseVisualStyleBackColor = false;
            this.viewTimeTableBtn.Click += new System.EventHandler(this.viewTimeTableBtn_Click);
            // 
            // addWorkingDayBtn
            // 
            this.addWorkingDayBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.addWorkingDayBtn.FlatAppearance.BorderSize = 0;
            this.addWorkingDayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addWorkingDayBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addWorkingDayBtn.ForeColor = System.Drawing.Color.White;
            this.addWorkingDayBtn.Location = new System.Drawing.Point(6, 131);
            this.addWorkingDayBtn.Name = "addWorkingDayBtn";
            this.addWorkingDayBtn.Size = new System.Drawing.Size(238, 50);
            this.addWorkingDayBtn.TabIndex = 0;
            this.addWorkingDayBtn.Text = "ADD WORKING DAY";
            this.addWorkingDayBtn.UseVisualStyleBackColor = false;
            this.addWorkingDayBtn.Click += new System.EventHandler(this.addWorkingDayBtn_Click);
            // 
            // manageWorkingDayPanel
            // 
            this.manageWorkingDayPanel.Location = new System.Drawing.Point(263, 26);
            this.manageWorkingDayPanel.Name = "manageWorkingDayPanel";
            this.manageWorkingDayPanel.Size = new System.Drawing.Size(1005, 730);
            this.manageWorkingDayPanel.TabIndex = 2;
            // 
            // closeBtn
            // 
            this.closeBtn.Image = global::TimeTableManagementSystemApp.Properties.Resources.closebtn;
            this.closeBtn.Location = new System.Drawing.Point(1250, 2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(28, 30);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeBtn.TabIndex = 0;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click_1);
            // 
            // miniBtn
            // 
            this.miniBtn.Image = global::TimeTableManagementSystemApp.Properties.Resources.minibtn;
            this.miniBtn.Location = new System.Drawing.Point(1182, 2);
            this.miniBtn.Name = "miniBtn";
            this.miniBtn.Size = new System.Drawing.Size(28, 30);
            this.miniBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.miniBtn.TabIndex = 3;
            this.miniBtn.TabStop = false;
            this.miniBtn.Click += new System.EventHandler(this.miniBtn_Click_1);
            // 
            // maxBtn
            // 
            this.maxBtn.Image = global::TimeTableManagementSystemApp.Properties.Resources.Maxibtn;
            this.maxBtn.Location = new System.Drawing.Point(1216, 2);
            this.maxBtn.Name = "maxBtn";
            this.maxBtn.Size = new System.Drawing.Size(28, 30);
            this.maxBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maxBtn.TabIndex = 4;
            this.maxBtn.TabStop = false;
            // 
            // ManageWorkingDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 768);
            this.Controls.Add(this.miniBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.maxBtn);
            this.Controls.Add(this.manageWorkingDayPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManageWorkingDays";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageWorkingDays";
            this.Load += new System.EventHandler(this.ManageWorkingDays_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button addWorkingDayBtn;
        private System.Windows.Forms.Panel manageWorkingDayPanel;
        private System.Windows.Forms.Button viewTimeTableBtn;
        private System.Windows.Forms.PictureBox closeBtn;
        private System.Windows.Forms.PictureBox maxBtn;
        private System.Windows.Forms.PictureBox miniBtn;
    }
}