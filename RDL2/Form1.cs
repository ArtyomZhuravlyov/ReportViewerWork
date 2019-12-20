using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RDL2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Controls.Add(this.reportViewer1);
            List<Student> list = StudentRepository.GetStudents();  //get list of students
            list = list.Union(StudentRepository.GetStudents()).ToList();
            list = list.Union(StudentRepository.GetStudents()).ToList();
            list = list.Union(StudentRepository.GetStudents()).ToList();
            list = list.Union(StudentRepository.GetStudents()).ToList(); list = list.Union(StudentRepository.GetStudents()).ToList();
            list = list.Union(StudentRepository.GetStudents()).ToList();
            list = list.Union(StudentRepository.GetStudents()).ToList();
            list = list.Union(StudentRepository.GetStudents()).ToList();
            list = list.Union(StudentRepository.GetStudents()).ToList();
            list = list.Union(StudentRepository.GetStudents()).ToList();
            list = list.Union(StudentRepository.GetStudents()).ToList();
            list = list.Union(StudentRepository.GetStudents()).ToList();
            list = list.Union(StudentRepository.GetStudents()).ToList();
            list = list.Union(StudentRepository.GetStudents()).ToList();
            list = list.Union(StudentRepository.GetStudents()).ToList();
            list = list.Union(StudentRepository.GetStudents()).ToList();
            list = list.Union(StudentRepository.GetStudents()).ToList();
            //list = list.Union(StudentRepository.GetStudents()).ToList();
            //list = list.Union(StudentRepository.GetStudents()).ToList();
            //list = list.Union(StudentRepository.GetStudents()).ToList();
            //list = list.Union(StudentRepository.GetStudents()).ToList();
            //list = list.Union(StudentRepository.GetStudents()).ToList();
            //list = list.Union(StudentRepository.GetStudents()).ToList();

            // reportViewer1.BackColor = Color.Gray;
            var s = reportViewer1.GetPageSettings();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
           // reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            reportViewer1.LocalReport.DataSources.Clear(); //clear report
                                                           // reportViewer1.LocalReport.ReportPath = @"../../Report1.rdlc";
                                                           // reportViewer1.LocalReport.ReportPath = @"../../Report2.rdlc";


            List<int> tt = new List<int> { 3, 4, 4 };
            var t3 = tt;
            t3.Add(5);
            string p = "sdf";
            string sssd = p;
            sssd = "111111";

            Form2 f2 = new Form2();
            string path = Application.StartupPath + "\\XML\\XML.txt";
            //using (StreamReader sr = new StreamReader(path))
            //{
            //    f2.Rich(sr);
            //}
            f2.Show();

            Microsoft.Reporting.WinForms.ReportDataSource dataset = new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", list); // set the datasource

            reportViewer1.LocalReport.DataSources.Add(dataset);
            //  reportViewer1.LocalReport.ReportEmbeddedResource = "RDL2.testRdlGenerator0.rdlc"; // bind reportviewer with .rdlc
            reportViewer1.LocalReport.ReportEmbeddedResource = "RDL2.Report2.rdlc"; // bind reportviewer with .rdlc

            dataset.Value = list;



            reportViewer1.LocalReport.Refresh();

            reportViewer1.RefreshReport(); // refresh report
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var pageSettings = reportViewer1.GetPageSettings();
            pageSettings.PaperSize = pageSettings.PrinterSettings.DefaultPageSettings.PaperSize;
            reportViewer1.SetPageSettings(pageSettings);
            reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var pageSettings = reportViewer1.GetPageSettings();
            pageSettings.PaperSize = new PaperSize("Custom",
                      869 + offset,
                      1169 + offset);
            reportViewer1.SetPageSettings(pageSettings);
            reportViewer1.RefreshReport();
            offset += 10;
        }

        private int offset = 0;

        private void button3_Click(object sender, EventArgs e)
        {
            var pageSettings = reportViewer1.GetPageSettings();
            pageSettings.PaperSize = new PaperSize("Custom",
                     1169 + offset,
                     869  + offset);
            reportViewer1.SetPageSettings(pageSettings);
            reportViewer1.RefreshReport();
            offset += 10;
        }
    }
}
