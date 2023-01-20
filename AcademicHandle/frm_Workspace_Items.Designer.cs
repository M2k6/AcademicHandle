namespace AcademicHandle
{
    partial class frm_Workspace_Items
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
            this.panell_container = new System.Windows.Forms.TabControl();
            this.tab_Music = new System.Windows.Forms.TabPage();
            this.tab_BlockWebsite = new System.Windows.Forms.TabPage();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lstMusic_Data = new System.Windows.Forms.ListBox();
            this.panell_container.SuspendLayout();
            this.tab_Music.SuspendLayout();
            this.SuspendLayout();
            // 
            // panell_container
            // 
            this.panell_container.Controls.Add(this.tab_Music);
            this.panell_container.Controls.Add(this.tab_BlockWebsite);
            this.panell_container.Location = new System.Drawing.Point(-4, 12);
            this.panell_container.Name = "panell_container";
            this.panell_container.SelectedIndex = 0;
            this.panell_container.Size = new System.Drawing.Size(619, 673);
            this.panell_container.TabIndex = 4;
            // 
            // tab_Music
            // 
            this.tab_Music.AutoScroll = true;
            this.tab_Music.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tab_Music.Controls.Add(this.lstMusic_Data);
            this.tab_Music.Controls.Add(this.btnRemove);
            this.tab_Music.Controls.Add(this.btnAdd);
            this.tab_Music.Location = new System.Drawing.Point(4, 29);
            this.tab_Music.Name = "tab_Music";
            this.tab_Music.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Music.Size = new System.Drawing.Size(611, 640);
            this.tab_Music.TabIndex = 0;
            this.tab_Music.Text = "Music";
            this.tab_Music.UseVisualStyleBackColor = true;
            this.tab_Music.SizeChanged += new System.EventHandler(this.tab_Music_SizeChanged);
            // 
            // tab_BlockWebsite
            // 
            this.tab_BlockWebsite.Location = new System.Drawing.Point(4, 29);
            this.tab_BlockWebsite.Name = "tab_BlockWebsite";
            this.tab_BlockWebsite.Padding = new System.Windows.Forms.Padding(3);
            this.tab_BlockWebsite.Size = new System.Drawing.Size(611, 640);
            this.tab_BlockWebsite.TabIndex = 1;
            this.tab_BlockWebsite.Text = "Block Website";
            this.tab_BlockWebsite.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(163, 489);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 33);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(306, 489);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(85, 33);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // lstMusic_Data
            // 
            this.lstMusic_Data.AllowDrop = true;
            this.lstMusic_Data.FormattingEnabled = true;
            this.lstMusic_Data.ItemHeight = 20;
            this.lstMusic_Data.Location = new System.Drawing.Point(6, 6);
            this.lstMusic_Data.Name = "lstMusic_Data";
            this.lstMusic_Data.Size = new System.Drawing.Size(596, 464);
            this.lstMusic_Data.TabIndex = 2;
            this.lstMusic_Data.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstMusic_Data_DragDrop);
            this.lstMusic_Data.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstMusic_Data_DragEnter);
            // 
            // frm_Workspace_Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 684);
            this.Controls.Add(this.panell_container);
            this.Name = "frm_Workspace_Items";
            this.Text = "Items";
            this.SizeChanged += new System.EventHandler(this.frm_Workspace_Items_SizeChanged);
            this.panell_container.ResumeLayout(false);
            this.tab_Music.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl panell_container;
        private System.Windows.Forms.TabPage tab_Music;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TabPage tab_BlockWebsite;
        private System.Windows.Forms.ListBox lstMusic_Data;
        private System.Windows.Forms.Button btnRemove;
    }
}