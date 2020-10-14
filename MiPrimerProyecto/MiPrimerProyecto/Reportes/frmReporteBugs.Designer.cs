namespace MiPrimerProyecto.Formularios
{
    partial class frmReporteBugs
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
            this.components = new System.ComponentModel.Container();
            this.bugsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bugstrackerDataSet = new MiPrimerProyecto.BugstrackerDataSet();
            this.bugsTableAdapter = new MiPrimerProyecto.BugstrackerDataSetTableAdapters.BugsTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.bugsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugstrackerDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // bugsBindingSource
            // 
            this.bugsBindingSource.DataMember = "Bugs";
            this.bugsBindingSource.DataSource = this.bugstrackerDataSet;
            // 
            // bugstrackerDataSet
            // 
            this.bugstrackerDataSet.DataSetName = "BugstrackerDataSet";
            this.bugstrackerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bugsTableAdapter
            // 
            this.bugsTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(529, 555);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // frmReporteBugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 555);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReporteBugs";
            this.Text = "frmReporteBugs";
            this.Load += new System.EventHandler(this.frmReporteBugs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bugsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugstrackerDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BugstrackerDataSet bugstrackerDataSet;
        private System.Windows.Forms.BindingSource bugsBindingSource;
        private BugstrackerDataSetTableAdapters.BugsTableAdapter bugsTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}