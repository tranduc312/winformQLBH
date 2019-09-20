namespace QLBH
{
    partial class INHOADON
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
            this.reportviewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.RPInhoadon1 = new QLBH.RPInhoadon();
            this.SuspendLayout();
            // 
            // reportviewer
            // 
            this.reportviewer.ActiveViewIndex = 0;
            this.reportviewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reportviewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.reportviewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportviewer.Location = new System.Drawing.Point(0, 0);
            this.reportviewer.Name = "reportviewer";
            this.reportviewer.ReportSource = this.RPInhoadon1;
            this.reportviewer.Size = new System.Drawing.Size(774, 310);
            this.reportviewer.TabIndex = 0;
            this.reportviewer.Load += new System.EventHandler(this.CrystalReportViewer1_Load);
            // 
            // INHOADON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 310);
            this.Controls.Add(this.reportviewer);
            this.Name = "INHOADON";
            this.Text = "INHOADON";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer reportviewer;
        private RPInhoadon RPInhoadon1;
        //private CRportINHOADON CRportINHOADON1;
    }
}