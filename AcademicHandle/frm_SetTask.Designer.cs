namespace AcademicHandle
{
    partial class frm_SetTask
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel_Morning = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_Afternoon = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_Evenning = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(70, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 52);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(450, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 52);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(829, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(350, 52);
            this.panel3.TabIndex = 1;
            // 
            // panel_Morning
            // 
            this.panel_Morning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_Morning.Location = new System.Drawing.Point(70, 126);
            this.panel_Morning.Name = "panel_Morning";
            this.panel_Morning.Size = new System.Drawing.Size(350, 470);
            this.panel_Morning.TabIndex = 2;
            // 
            // panel_Afternoon
            // 
            this.panel_Afternoon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_Afternoon.Location = new System.Drawing.Point(450, 126);
            this.panel_Afternoon.Name = "panel_Afternoon";
            this.panel_Afternoon.Size = new System.Drawing.Size(350, 470);
            this.panel_Afternoon.TabIndex = 3;
            // 
            // panel_Evenning
            // 
            this.panel_Evenning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_Evenning.Location = new System.Drawing.Point(829, 126);
            this.panel_Evenning.Name = "panel_Evenning";
            this.panel_Evenning.Size = new System.Drawing.Size(350, 470);
            this.panel_Evenning.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Aurora", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sáng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UTM Aurora", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chiều";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UTM Aurora", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tối";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.MediumOrchid;
            this.button1.Image = global::AcademicHandle.Properties.Resources.plus__1_;
            this.button1.Location = new System.Drawing.Point(307, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 33);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.DetailedTimeTableOpen_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.MediumOrchid;
            this.button2.Image = global::AcademicHandle.Properties.Resources.plus__1_;
            this.button2.Location = new System.Drawing.Point(308, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 33);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.DetailedTimeTableOpen_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.MediumOrchid;
            this.button3.Image = global::AcademicHandle.Properties.Resources.plus__1_;
            this.button3.Location = new System.Drawing.Point(308, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(39, 33);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.DetailedTimeTableOpen_Click);
            // 
            // frm_SetTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(132)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1219, 683);
            this.Controls.Add(this.panel_Evenning);
            this.Controls.Add(this.panel_Afternoon);
            this.Controls.Add(this.panel_Morning);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_SetTask";
            this.Text = "frm_SetTask";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel panel_Morning;
        private System.Windows.Forms.FlowLayoutPanel panel_Afternoon;
        private System.Windows.Forms.FlowLayoutPanel panel_Evenning;
    }
}