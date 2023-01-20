namespace AcademicHandle
{
    partial class frm_MainTimeTable
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
            this.btnWorkSpaceOpen = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAfter = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.txtDateCalender = new System.Windows.Forms.Label();
            this.panel_Calendar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_Container = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnWorkSpaceOpen
            // 
            this.btnWorkSpaceOpen.Location = new System.Drawing.Point(1025, 649);
            this.btnWorkSpaceOpen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWorkSpaceOpen.Name = "btnWorkSpaceOpen";
            this.btnWorkSpaceOpen.Size = new System.Drawing.Size(207, 41);
            this.btnWorkSpaceOpen.TabIndex = 1;
            this.btnWorkSpaceOpen.Text = "Mở không gian làm việc";
            this.btnWorkSpaceOpen.UseVisualStyleBackColor = true;
            this.btnWorkSpaceOpen.Click += new System.EventHandler(this.btnWorkSpaceOpen_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(79)))), ((int)(((byte)(200)))));
            this.panel1.Controls.Add(this.btnAfter);
            this.panel1.Controls.Add(this.btnPrev);
            this.panel1.Controls.Add(this.txtDateCalender);
            this.panel1.Location = new System.Drawing.Point(45, 26);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1159, 38);
            this.panel1.TabIndex = 0;
            // 
            // btnAfter
            // 
            this.btnAfter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(79)))), ((int)(((byte)(200)))));
            this.btnAfter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAfter.ForeColor = System.Drawing.Color.Snow;
            this.btnAfter.Location = new System.Drawing.Point(1112, 0);
            this.btnAfter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAfter.Name = "btnAfter";
            this.btnAfter.Size = new System.Drawing.Size(45, 34);
            this.btnAfter.TabIndex = 2;
            this.btnAfter.Text = ">";
            this.btnAfter.UseVisualStyleBackColor = false;
            this.btnAfter.Click += new System.EventHandler(this.btnAfter_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(79)))), ((int)(((byte)(200)))));
            this.btnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPrev.ForeColor = System.Drawing.Color.Snow;
            this.btnPrev.Location = new System.Drawing.Point(0, 0);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(45, 34);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // txtDateCalender
            // 
            this.txtDateCalender.AutoSize = true;
            this.txtDateCalender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateCalender.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtDateCalender.Location = new System.Drawing.Point(508, 4);
            this.txtDateCalender.Name = "txtDateCalender";
            this.txtDateCalender.Size = new System.Drawing.Size(138, 25);
            this.txtDateCalender.TabIndex = 0;
            this.txtDateCalender.Text = "Chọn thời gian";
            // 
            // panel_Calendar
            // 
            this.panel_Calendar.BackColor = System.Drawing.Color.White;
            this.panel_Calendar.Location = new System.Drawing.Point(45, 60);
            this.panel_Calendar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_Calendar.Name = "panel_Calendar";
            this.panel_Calendar.Size = new System.Drawing.Size(1156, 585);
            this.panel_Calendar.TabIndex = 1;
            // 
            // panel_Container
            // 
            this.panel_Container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(132)))), ((int)(((byte)(254)))));
            this.panel_Container.Location = new System.Drawing.Point(0, -1);
            this.panel_Container.Name = "panel_Container";
            this.panel_Container.Size = new System.Drawing.Size(1245, 698);
            this.panel_Container.TabIndex = 0;
            // 
            // frm_MainTimeTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(132)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1244, 698);
            this.Controls.Add(this.panel_Calendar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnWorkSpaceOpen);
            this.Controls.Add(this.panel_Container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_MainTimeTable";
            this.Text = "frm_MainTimeTable";
            this.Load += new System.EventHandler(this.frm_MainTimeTable_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnWorkSpaceOpen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtDateCalender;
        private System.Windows.Forms.FlowLayoutPanel panel_Calendar;
        private System.Windows.Forms.Button btnAfter;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Panel panel_Container;
    }
}