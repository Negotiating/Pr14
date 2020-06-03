using System;
using Microsoft.Reporting.WinForms;
using System.Windows.Forms;

namespace PR14_WF
{
	public partial class ReportsForm : Form
	{
		public ReportsForm()
		{
			InitializeComponent();
		}

		private void ReportsForm_Load(object sender, EventArgs e)
		{
			reportViewer1.ProcessingMode = ProcessingMode.Local;
			reportViewer1.LocalReport.ReportPath = (@"students_report.rdlc");
			ReportDataSource datasource = new ReportDataSource("StudentsDataSet", this.studentsDataSet1.Tables["students"]);//скорее всего проблема здесь
			reportViewer1.LocalReport.DataSources.Clear();
			reportViewer1.LocalReport.DataSources.Add(datasource);
			this.reportViewer1.RefreshReport();
		}
	}
}
