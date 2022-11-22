namespace AcademicHandle
{
    partial class frm_DetailedTimeTable
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dt_DatePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dt_HourPicker = new System.Windows.Forms.NumericUpDown();
            this.dt_MinutePicker = new System.Windows.Forms.NumericUpDown();
            this.drop_aim = new System.Windows.Forms.ComboBox();
            this.drop_levelimportant = new System.Windows.Forms.ComboBox();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dt_HourPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_MinutePicker)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Aurora", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên nhiệm vụ";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(39, 59);
            this.txt_Name.Multiline = true;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(592, 49);
            this.txt_Name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UTM Aurora", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thời gian";
            // 
            // dt_DatePicker
            // 
            this.dt_DatePicker.Location = new System.Drawing.Point(40, 156);
            this.dt_DatePicker.Name = "dt_DatePicker";
            this.dt_DatePicker.Size = new System.Drawing.Size(253, 26);
            this.dt_DatePicker.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UTM Aurora", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(415, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Giờ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("UTM Aurora", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(537, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "Phút";
            // 
            // dt_HourPicker
            // 
            this.dt_HourPicker.Location = new System.Drawing.Point(420, 158);
            this.dt_HourPicker.Name = "dt_HourPicker";
            this.dt_HourPicker.Size = new System.Drawing.Size(107, 26);
            this.dt_HourPicker.TabIndex = 8;
            // 
            // dt_MinutePicker
            // 
            this.dt_MinutePicker.Location = new System.Drawing.Point(542, 158);
            this.dt_MinutePicker.Name = "dt_MinutePicker";
            this.dt_MinutePicker.Size = new System.Drawing.Size(107, 26);
            this.dt_MinutePicker.TabIndex = 9;
            // 
            // drop_aim
            // 
            this.drop_aim.FormattingEnabled = true;
            this.drop_aim.Items.AddRange(new object[] {
            "Khẩn cấp",
            "Quan trọng",
            "Trung"});
            this.drop_aim.Location = new System.Drawing.Point(39, 224);
            this.drop_aim.Name = "drop_aim";
            this.drop_aim.Size = new System.Drawing.Size(121, 28);
            this.drop_aim.TabIndex = 10;
            // 
            // drop_levelimportant
            // 
            this.drop_levelimportant.FormattingEnabled = true;
            this.drop_levelimportant.Location = new System.Drawing.Point(39, 294);
            this.drop_levelimportant.Name = "drop_levelimportant";
            this.drop_levelimportant.Size = new System.Drawing.Size(121, 28);
            this.drop_levelimportant.TabIndex = 11;
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(40, 353);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(591, 273);
            this.txt_description.TabIndex = 12;
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(548, 632);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(83, 39);
            this.btnSet.TabIndex = 13;
            this.btnSet.Text = "Xong";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("UTM Aurora", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(35, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 27);
            this.label5.TabIndex = 14;
            this.label5.Text = "Mô tả công việc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("UTM Aurora", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(35, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 27);
            this.label6.TabIndex = 15;
            this.label6.Text = "Mức độ công việc";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("UTM Aurora", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(35, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 27);
            this.label7.TabIndex = 16;
            this.label7.Text = "Mục tiêu liên quan";
            // 
            // DetailedTimeTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(132)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(663, 683);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.drop_levelimportant);
            this.Controls.Add(this.drop_aim);
            this.Controls.Add(this.dt_MinutePicker);
            this.Controls.Add(this.dt_HourPicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dt_DatePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label1);
            this.Name = "DetailedTimeTable";
            this.Text = "Thiết lập công việc";
            ((System.ComponentModel.ISupportInitialize)(this.dt_HourPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_MinutePicker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dt_DatePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown dt_HourPicker;
        private System.Windows.Forms.NumericUpDown dt_MinutePicker;
        private System.Windows.Forms.ComboBox drop_aim;
        private System.Windows.Forms.ComboBox drop_levelimportant;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}