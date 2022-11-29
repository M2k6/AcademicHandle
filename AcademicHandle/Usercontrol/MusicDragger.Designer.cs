namespace AcademicHandle.Usercontrol
{
    partial class MusicDragger
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbMusicAdd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbMusicAdd
            // 
            this.lbMusicAdd.AutoSize = true;
            this.lbMusicAdd.ForeColor = System.Drawing.Color.Blue;
            this.lbMusicAdd.Location = new System.Drawing.Point(34, 204);
            this.lbMusicAdd.Name = "lbMusicAdd";
            this.lbMusicAdd.Size = new System.Drawing.Size(270, 40);
            this.lbMusicAdd.TabIndex = 0;
            this.lbMusicAdd.Text = "Chưa có bài hát nào trong danh sách\r\n                 Thêm ngay nào...!\r\n";
            this.lbMusicAdd.Click += new System.EventHandler(this.lbMusicAdd_Click);
            // 
            // MusicDragger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbMusicAdd);
            this.Name = "MusicDragger";
            this.Size = new System.Drawing.Size(334, 440);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMusicAdd;
    }
}
