namespace AcademicHandle.Usercontrol
{
    partial class MissionBlank
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
            this.components = new System.ComponentModel.Container();
            this.lbName = new System.Windows.Forms.Label();
            this.cmenustrip_1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thôngTinChiTiếtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hoànThànhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmenustrip_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbName.Location = new System.Drawing.Point(3, 6);
            this.lbName.MaximumSize = new System.Drawing.Size(336, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(51, 20);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name";
            // 
            // cmenustrip_1
            // 
            this.cmenustrip_1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmenustrip_1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinChiTiếtToolStripMenuItem,
            this.xóaToolStripMenuItem,
            this.hoànThànhToolStripMenuItem});
            this.cmenustrip_1.Name = "cmenustrip_1";
            this.cmenustrip_1.Size = new System.Drawing.Size(241, 133);
            // 
            // thôngTinChiTiếtToolStripMenuItem
            // 
            this.thôngTinChiTiếtToolStripMenuItem.Name = "thôngTinChiTiếtToolStripMenuItem";
            this.thôngTinChiTiếtToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.thôngTinChiTiếtToolStripMenuItem.Text = "Thông tin chi tiết...";
            this.thôngTinChiTiếtToolStripMenuItem.Click += new System.EventHandler(this.thôngTinChiTiếtToolStripMenuItem_Click);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.xóaToolStripMenuItem.Text = "Xóa ";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.ContextMenuStrip = this.cmenustrip_1;
            this.panel1.Location = new System.Drawing.Point(4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 62);
            this.panel1.TabIndex = 5;
            // 
            // hoànThànhToolStripMenuItem
            // 
            this.hoànThànhToolStripMenuItem.Name = "hoànThànhToolStripMenuItem";
            this.hoànThànhToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.hoànThànhToolStripMenuItem.Text = "Hoàn thành";
            this.hoànThànhToolStripMenuItem.Click += new System.EventHandler(this.hoànThànhToolStripMenuItem_Click);
            // 
            // MissionBlank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContextMenuStrip = this.cmenustrip_1;
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.panel1);
            this.Name = "MissionBlank";
            this.Size = new System.Drawing.Size(343, 70);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MissionBlank_MouseClick);
            this.cmenustrip_1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.ContextMenuStrip cmenustrip_1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinChiTiếtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem hoànThànhToolStripMenuItem;
    }
}
