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
            this.lb_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Date.Location = new System.Drawing.Point(35, 19);
            this.lb_Date.Name = "lb_Date";
            this.lb_Date.Size = new System.Drawing.Size(44, 31);
            this.lb_Date.TabIndex = 0;
            this.lb_Date.Text = "20";
            this.lb_Date.Click += new System.EventHandler(this.lb_Date_Click);
            // 
            // lb_Status
            // 
            this.lb_Status.AutoSize = true;
            this.lb_Status.Location = new System.Drawing.Point(20, 57);
            this.lb_Status.Name = "lb_Status";
            this.lb_Status.Size = new System.Drawing.Size(66, 17);
            this.lb_Status.TabIndex = 1;
            this.lb_Status.Text = "Comming";
            // 
            // BlankCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_Status);
            this.Controls.Add(this.lb_Date);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BlankCalendar";
            this.Size = new System.Drawing.Size(108, 85);
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
