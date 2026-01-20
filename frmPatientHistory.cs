using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Control;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraReports.UI;

namespace Onana_Hospital_Management_System
{
    public partial class frmPatientHistory : XtraForm
    {
        public string PatientMRN { get; set; }
        clsSelect selectClass = new clsSelect();
        public frmPatientHistory()
        {
            InitializeComponent();
            
        }

        private void frmPatientHistory_Load(object sender, EventArgs e)
        {
            selectClass.LoadPatientHistory(PatientMRN, accordionControl1);
            //rptProcedureReportv2 mc = new rptProcedureReportv2();
            //mc.ReportParameters[0].Value = patid;

            //reportViewer1.ReportSource = mc;
            //reportViewer1.RefreshReport();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PatientHistoryPrint pthp = new PatientHistoryPrint { patid = PatientMRN };
            pthp.Show();
           // PrintAccordion(accordionControl1);
        }
        public void PrintAccordion(AccordionControl accordion)
        {
            // Create a printing system
            PrintingSystem printingSystem = new PrintingSystem();

            // Create a link that can print visual controls
            PrintableComponentLink link = new PrintableComponentLink(printingSystem)
            {
                // Create a wrapper that implements IBasePrintable
                Component = new AccordionControlPrintableWrapper(accordion)
            };

            // Create and show preview
            link.CreateDocument();
            link.ShowPreview();
        }

        // Wrapper class that implements IBasePrintable
        public class AccordionControlPrintableWrapper : IBasePrintable
        {
            private readonly AccordionControl _accordion;

            public AccordionControlPrintableWrapper(AccordionControl accordion)
            {
                _accordion = accordion;
            }

            public bool CreatesIntersectedBricks
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public void AssignFrom(IBasePrintable source) { }

            public void AssignFrom(object source) { }

            public void Clear() { }

            public void CreateArea(string areaName, BrickGraphics brickGraphics)
            {
                throw new NotImplementedException();
            }

            public void CreateArea(string areaName, IBrickGraphics graph)
            {
                // Implement rendering logic here
                // This is where you'd draw the accordion content
            }

            public new void Finalize(PrintingSystemBase ps, LinkBase link)
            {
                throw new NotImplementedException();
            }

            public void Finalize(IPrintingSystem ps, ILink link) { }

            public void Initialize(PrintingSystemBase ps, LinkBase link)
            {
                throw new NotImplementedException();
            }

            public void Initialize(IPrintingSystem ps, ILink link) { }
        }
    }
}
