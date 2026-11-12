namespace Lab13_CrystalReport.Reports
{
    using System;
    using System.ComponentModel;
    using CrystalDecisions.Shared;
    using CrystalDecisions.ReportSource;
    using CrystalDecisions.CrystalReports.Engine;

    public class CrystalReportKhoa : ReportClass
    {
        public CrystalReportKhoa()
        {
        }

        public override string ResourceName
        {
            get { return "CrystalReportKhoa.rpt"; }
            set { }
        }

        public override bool NewGenerator
        {
            get { return true; }
            set { }
        }

        public override string FullResourceName
        {
            get { return "Lab13_CrystalReport.Reports.CrystalReportKhoa.rpt"; }
            set { }
        }

        [Browsable(false)]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        public CrystalDecisions.CrystalReports.Engine.Section Section1
        {
            get { return this.ReportDefinition.Sections[0]; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        public CrystalDecisions.CrystalReports.Engine.Section Section2
        {
            get { return this.ReportDefinition.Sections[1]; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        public CrystalDecisions.CrystalReports.Engine.Section Section3
        {
            get { return this.ReportDefinition.Sections[2]; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        public CrystalDecisions.CrystalReports.Engine.Section Section4
        {
            get { return this.ReportDefinition.Sections[3]; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        public CrystalDecisions.CrystalReports.Engine.Section Section5
        {
            get { return this.ReportDefinition.Sections[4]; }
        }
    }
}
