namespace ExcelAddIn
{
    partial class Ribbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.customTab = this.Factory.CreateRibbonTab();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.labelUser = this.Factory.CreateRibbonLabel();
            this.buttonLogoff = this.Factory.CreateRibbonButton();
            this.refreshButton = this.Factory.CreateRibbonButton();
            this.relationsGroup = this.Factory.CreateRibbonGroup();
            this.peopleButton = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.customTab.SuspendLayout();
            this.group2.SuspendLayout();
            this.relationsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Label = "group1";
            this.group1.Name = "group1";
            // 
            // customTab
            // 
            this.customTab.Groups.Add(this.group2);
            this.customTab.Groups.Add(this.relationsGroup);
            this.customTab.Label = "Custom";
            this.customTab.Name = "customTab";
            // 
            // group2
            // 
            this.group2.Items.Add(this.labelUser);
            this.group2.Items.Add(this.buttonLogoff);
            this.group2.Items.Add(this.refreshButton);
            this.group2.Label = "General";
            this.group2.Name = "group2";
            // 
            // labelUser
            // 
            this.labelUser.Label = " Not logged in";
            this.labelUser.Name = "labelUser";
            // 
            // buttonLogoff
            // 
            this.buttonLogoff.Label = "Login";
            this.buttonLogoff.Name = "buttonLogoff";
            this.buttonLogoff.ShowImage = true;
            this.buttonLogoff.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ButtonLogoff_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Label = "Refresh";
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.ShowImage = true;
            this.refreshButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.RefreshButton_Click);
            // 
            // relationsGroup
            // 
            this.relationsGroup.Items.Add(this.peopleButton);
            this.relationsGroup.Label = "Relations";
            this.relationsGroup.Name = "relationsGroup";
            // 
            // peopleButton
            // 
            this.peopleButton.Label = "People";
            this.peopleButton.Name = "peopleButton";
            this.peopleButton.OfficeImageId = "DataFormSource";
            this.peopleButton.ShowImage = true;
            this.peopleButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.PeopleInitializeButton_Click);
            // 
            // Ribbon
            // 
            this.Name = "Ribbon";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Tabs.Add(this.customTab);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.customTab.ResumeLayout(false);
            this.customTab.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.relationsGroup.ResumeLayout(false);
            this.relationsGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        private Microsoft.Office.Tools.Ribbon.RibbonTab customTab;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup relationsGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton peopleButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonLogoff;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel labelUser;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton refreshButton;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon Ribbon
        {
            get { return this.GetRibbon<Ribbon>(); }
        }
    }
}
