namespace AcademicHandle
{
    partial class frm_Home
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
            this.btnKnowledgeRevise = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnEvaluation_Aim = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKnowledgeRevise
            // 
            this.btnKnowledgeRevise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnKnowledgeRevise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKnowledgeRevise.Location = new System.Drawing.Point(46, 74);
            this.btnKnowledgeRevise.Name = "btnKnowledgeRevise";
            this.btnKnowledgeRevise.Size = new System.Drawing.Size(276, 52);
            this.btnKnowledgeRevise.TabIndex = 0;
            this.btnKnowledgeRevise.Text = "Ôn Tập Kiến Thức";
            this.btnKnowledgeRevise.UseVisualStyleBackColor = false;
            this.btnKnowledgeRevise.Click += new System.EventHandler(this.btnKnowledgeRevise_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(46, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(276, 52);
            this.button2.TabIndex = 1;
            this.button2.Text = "Thời Gian Biểu";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnEvaluation_Aim
            // 
            this.btnEvaluation_Aim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnEvaluation_Aim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEvaluation_Aim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvaluation_Aim.Location = new System.Drawing.Point(46, 218);
            this.btnEvaluation_Aim.Name = "btnEvaluation_Aim";
            this.btnEvaluation_Aim.Size = new System.Drawing.Size(276, 52);
            this.btnEvaluation_Aim.TabIndex = 2;
            this.btnEvaluation_Aim.Text = "Mục tiêu";
            this.btnEvaluation_Aim.UseVisualStyleBackColor = false;
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSetting.Location = new System.Drawing.Point(46, 296);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(276, 52);
            this.btnSetting.TabIndex = 3;
            this.btnSetting.Text = "Cài Đặt";
            this.btnSetting.UseVisualStyleBackColor = false;
            // 
            // frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(132)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnEvaluation_Aim);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnKnowledgeRevise);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKnowledgeRevise;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnEvaluation_Aim;
        private System.Windows.Forms.Button btnSetting;
    }
}