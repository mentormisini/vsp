namespace Stresta.PRINT
{
    partial class printforma
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.inputdatasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printim = new Stresta.PRINT.printim();
            this.inputdatasTableAdapter = new Stresta.PRINT.printimTableAdapters.inputdatasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.inputdatasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printim)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.inputdatasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Stresta.PRINT.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 821);
            this.reportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(737, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // inputdatasBindingSource
            // 
            this.inputdatasBindingSource.DataMember = "inputdatas";
            this.inputdatasBindingSource.DataSource = this.printim;
            // 
            // printim
            // 
            this.printim.DataSetName = "printim";
            this.printim.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inputdatasTableAdapter
            // 
            this.inputdatasTableAdapter.ClearBeforeFill = true;
            // 
            // printforma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 821);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "printforma";
            this.Text = "PRINT";
            this.Load += new System.EventHandler(this.PRINT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inputdatasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource inputdatasBindingSource;
        private printim printim;
        private printimTableAdapters.inputdatasTableAdapter inputdatasTableAdapter;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
    }
}