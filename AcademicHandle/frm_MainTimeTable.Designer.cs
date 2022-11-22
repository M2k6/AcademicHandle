﻿namespace AcademicHandle
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Calendar = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnAfter = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnWorkSpaceOpen
            // 
            this.btnWorkSpaceOpen.Location = new System.Drawing.Point(1022, 686);
            this.btnWorkSpaceOpen.Name = "btnWorkSpaceOpen";
            this.btnWorkSpaceOpen.Size = new System.Drawing.Size(207, 41);
            this.btnWorkSpaceOpen.TabIndex = 1;
            this.btnWorkSpaceOpen.Text = "Mở không gian làm việc";
            this.btnWorkSpaceOpen.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(79)))), ((int)(((byte)(200)))));
            this.panel1.Controls.Add(this.btnAfter);
            this.panel1.Controls.Add(this.btnPrev);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(45, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1159, 37);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Eremitage", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(508, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn thời gian";
            // 
            // panel_Calendar
            // 
            this.panel_Calendar.BackColor = System.Drawing.Color.White;
            this.panel_Calendar.Location = new System.Drawing.Point(45, 60);
            this.panel_Calendar.Name = "panel_Calendar";
            this.panel_Calendar.Size = new System.Drawing.Size(1159, 620);
            this.panel_Calendar.TabIndex = 1;
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(79)))), ((int)(((byte)(200)))));
            this.btnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPrev.ForeColor = System.Drawing.Color.Snow;
            this.btnPrev.Location = new System.Drawing.Point(0, 0);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(45, 34);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnAfter
            // 
            this.btnAfter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(79)))), ((int)(((byte)(200)))));
            this.btnAfter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAfter.ForeColor = System.Drawing.Color.Snow;
            this.btnAfter.Location = new System.Drawing.Point(1111, 0);
            this.btnAfter.Name = "btnAfter";
            this.btnAfter.Size = new System.Drawing.Size(45, 34);
            this.btnAfter.TabIndex = 2;
            this.btnAfter.Text = ">";
            this.btnAfter.UseVisualStyleBackColor = false;
            this.btnAfter.Click += new System.EventHandler(this.btnAfter_Click);
            // 
            // frm_MainTimeTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(132)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1241, 739);
            this.Controls.Add(this.panel_Calendar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnWorkSpaceOpen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel panel_Calendar;
        private System.Windows.Forms.Button btnAfter;
        private System.Windows.Forms.Button btnPrev;
    }
}