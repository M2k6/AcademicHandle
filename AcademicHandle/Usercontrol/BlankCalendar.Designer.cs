namespace AcademicHandle.Usercontrol
{
    partial class BlankCalendar
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
            this.lb_Date = new System.Windows.Forms.Label();
            this.lb_Status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_Date
            // 
            this.lb_Date.AutoSize = true;
            this.lb_Date.Font = new System.Drawing.Font("UTM Alter Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Date.Location = new System.Drawing.Point(39, 24);
            this.lb_Date.Name = "lb_Date";
            this.lb_Date.Size = new System.Drawing.Size(43, 40);
            this.lb_Date.TabIndex = 0;
            this.lb_Date.Text = "20";
            // 
            // lb_Status
            // 
            this.lb_Status.AutoSize = true;
            this.lb_Status.Location = new System.Drawing.Point(23, 71);
            this.lb_Status.Name = "lb_Status";
            this.lb_Status.Size = new System.Drawing.Size(76, 20);
            this.lb_Status.TabIndex = 1;
            this.lb_Status.Text = "Comming";
            // 
            // BlankCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_Status);
            this.Controls.Add(this.lb_Date);
            this.Name = "BlankCalendar";
            this.Size = new System.Drawing.Size(122, 106);
            this.MouseLeave += new System.EventHandler(this.BlankCalendar_MouseLeave);
            this.MouseHover += new System.EventHandler(this.BlankCalendar_MouseHover);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Date;
        private System.Windows.Forms.Label lb_Status;
    }
}
