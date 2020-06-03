namespace PR14_WF
{
	partial class ReportsForm
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
			Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.StudentsDataSet = new PR14_WF.StudentsDataSet();
			this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.studentsTableAdapter = new PR14_WF.StudentsDataSetTableAdapters.studentsTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.StudentsDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// reportViewer1
			// 
			this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
			reportDataSource2.Name = "Report";
			reportDataSource2.Value = this.studentsBindingSource;
			this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "PR14_WF.students_report.rdlc";
			this.reportViewer1.Location = new System.Drawing.Point(0, 0);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(651, 450);
			this.reportViewer1.TabIndex = 0;
			// 
			// StudentsDataSet
			// 
			this.StudentsDataSet.DataSetName = "StudentsDataSet";
			this.StudentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// studentsBindingSource
			// 
			this.studentsBindingSource.DataMember = "students";
			this.studentsBindingSource.DataSource = this.StudentsDataSet;
			// 
			// studentsTableAdapter
			// 
			this.studentsTableAdapter.ClearBeforeFill = true;
			// 
			// ReportsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(651, 450);
			this.Controls.Add(this.reportViewer1);
			this.Name = "ReportsForm";
			this.Text = "ReportsForm";
			this.Load += new System.EventHandler(this.ReportsForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.StudentsDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private System.Windows.Forms.BindingSource studentsBindingSource;
		private StudentsDataSet StudentsDataSet;
		private StudentsDataSetTableAdapters.studentsTableAdapter studentsTableAdapter;
	}
}