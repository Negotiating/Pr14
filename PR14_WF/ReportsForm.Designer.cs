﻿namespace PR14_WF
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
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.studentsDataSet1 = new PR14_WF.StudentsDataSet();
			((System.ComponentModel.ISupportInitialize)(this.studentsDataSet1)).BeginInit();
			this.SuspendLayout();
			// 
			// reportViewer1
			// 
			this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.reportViewer1.LocalReport.DisplayName = "studentDataSet1";
			this.reportViewer1.LocalReport.ReportPath = "reportsg.rdlc";
			this.reportViewer1.Location = new System.Drawing.Point(0, 0);
			this.reportViewer1.Name = "ReportViewer";
			this.reportViewer1.Size = new System.Drawing.Size(651, 450);
			this.reportViewer1.TabIndex = 0;
			// 
			// studentsDataSet1
			// 
			this.studentsDataSet1.DataSetName = "StudentsDataSet";
			this.studentsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
			((System.ComponentModel.ISupportInitialize)(this.studentsDataSet1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private StudentsDataSet studentsDataSet1;
	}
}