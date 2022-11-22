namespace AcademicHandle
{
    partial class frm_Workspace
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
            this.lbHour = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMusic = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbMissionNow = new System.Windows.Forms.Label();
            this.btnAnotherMission = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbHour
            // 
            this.lbHour.AutoSize = true;
            this.lbHour.Font = new System.Drawing.Font("UTM Alexander", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHour.ForeColor = System.Drawing.SystemColors.Control;
            this.lbHour.Location = new System.Drawing.Point(310, 186);
            this.lbHour.Name = "lbHour";
            this.lbHour.Size = new System.Drawing.Size(246, 194);
            this.lbHour.TabIndex = 0;
            this.lbHour.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Alexander", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(664, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 194);
            this.label1.TabIndex = 1;
            this.label1.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UTM Alexander", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(562, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 129);
            this.label2.TabIndex = 2;
            this.label2.Text = ":";
            // 
            // btnMusic
            // 
            this.btnMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(132)))), ((int)(((byte)(254)))));
            this.btnMusic.Image = global::AcademicHandle.Properties.Resources.music_note;
            this.btnMusic.Location = new System.Drawing.Point(1120, 12);
            this.btnMusic.Name = "btnMusic";
            this.btnMusic.Size = new System.Drawing.Size(87, 69);
            this.btnMusic.TabIndex = 3;
            this.btnMusic.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMusic.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UTM Alexander", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(243, 538);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nhiệm vụ hiện tại :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbMissionNow
            // 
            this.lbMissionNow.AutoSize = true;
            this.lbMissionNow.Font = new System.Drawing.Font("UTM Alexander", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMissionNow.ForeColor = System.Drawing.Color.White;
            this.lbMissionNow.Location = new System.Drawing.Point(243, 593);
            this.lbMissionNow.Name = "lbMissionNow";
            this.lbMissionNow.Size = new System.Drawing.Size(268, 30);
            this.lbMissionNow.TabIndex = 5;
            this.lbMissionNow.Text = "...................................................";
            // 
            // btnAnotherMission
            // 
            this.btnAnotherMission.Font = new System.Drawing.Font("UTM Alter Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnotherMission.ForeColor = System.Drawing.Color.DimGray;
            this.btnAnotherMission.Location = new System.Drawing.Point(168, 557);
            this.btnAnotherMission.Name = "btnAnotherMission";
            this.btnAnotherMission.Size = new System.Drawing.Size(54, 51);
            this.btnAnotherMission.TabIndex = 6;
            this.btnAnotherMission.Text = "...";
            this.btnAnotherMission.UseVisualStyleBackColor = true;
            // 
            // frm_Workspace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(132)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1219, 683);
            this.Controls.Add(this.btnAnotherMission);
            this.Controls.Add(this.lbMissionNow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMusic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbHour);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Workspace";
            this.Text = "frm_Workspace";
            this.Load += new System.EventHandler(this.frm_Workspace_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMusic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbMissionNow;
        private System.Windows.Forms.Button btnAnotherMission;
    }
}