using BestGrill.DB;
using BestGrill.Model;
using Microsoft.Reporting.WinForms;
using PrintingReportNoViewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestGrill
{
    public partial class ReportForm : Form
    {
        private string subTotal;

        public string SubTotal
        {
            get { return subTotal; }
            set { subTotal = value; }
        }
        private int table;

        public int Table
        {
            get { return table; }
            set { table = value; }
        }
        private string total;

        public string Total
        {
            get { return total; }
            set { total = value; }
        }

        private string discount;

        public string Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        private string tax;

        public string Tax
        {
            get { return tax; }
            set { tax = value; }
        }
        private Int64 billId;

        public Int64 BillId
        {
            get { return billId; }
            set { billId = value; }
        }
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            float subTotal = 0;
            List<BillItem> listBillItem = BillItemProvider.Instance.loadBillItemById(this.billId);
            foreach (BillItem item in listBillItem)
            {
                if (item.Quantity > 0)
                {
                    billItemBindingSource1.Add(item);
                    subTotal += item.Total;
                }
            }
            ReportParameter[] parms = new ReportParameter[4];
            parms[0] = new ReportParameter("subTotal", this.subTotal);
            parms[1] = new ReportParameter("total", this.total);
            parms[2] = new ReportParameter("table", this.table.ToString());
            parms[3] = new ReportParameter("datepay", DateTime.Today.ToString("dd-MM-yyyy"));
            this.reportViewer1.LocalReport.SetParameters(parms);
            //this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = ZoomMode.PageWidth;
            this.reportViewer1.RefreshReport();
            ReportPrintDocument printDoc = new ReportPrintDocument(reportViewer1.LocalReport);
            printDoc.PrinterSettings.Copies = 1;
            printDoc.Print();
            Close();
        }
    }
}
