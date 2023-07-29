using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace LiveSplit.UI.Components
{
    public partial class ProjectedTimeSettings : UserControl
    {
        public enum ProjectionComparison
        {
            CurrentComparison = 0,
            PersonalBest = 1,
            BestSegments = 2,
            AverageSegments = 3
        }
        public ProjectionComparison Comparison { get; set; }
        public enum ProjectionTimingMethod
        {
            CurrentTimingMethod = 0,
            RealTime = 1,
            GameTime = 2
        }
        public ProjectionTimingMethod TimingMethod { get; set; }
        public bool DisplayCompletionPercent { get; set; }
        
        public bool Display2Rows { get; set; }

        public LayoutMode Mode { get; set; }

        public ProjectedTimeSettings()
        {
            InitializeComponent();

            Display2Rows = false;
            DisplayCompletionPercent = false;
            Comparison = ProjectionComparison.CurrentComparison;
            TimingMethod = ProjectionTimingMethod.CurrentTimingMethod;
        }

        private void ProjectedTimeSettings_Load(object sender, EventArgs e)
        {
            cmpComboBox.SelectedIndex = (int)Comparison;
            timingComboBox.SelectedIndex = (int)TimingMethod;
            percentCheckBox.DataBindings.Add("Checked", this, "DisplayCompletionPercent", false, DataSourceUpdateMode.OnPropertyChanged);
            if (Mode == LayoutMode.Horizontal)
            {
                chkTwoRows.Enabled = false;
                chkTwoRows.DataBindings.Clear();
                chkTwoRows.Checked = true;
            }
            else
            {
                chkTwoRows.Enabled = true;
                chkTwoRows.DataBindings.Clear();
                chkTwoRows.DataBindings.Add("Checked", this, "Display2Rows", false, DataSourceUpdateMode.OnPropertyChanged);
            }
        }

        public void SetSettings(XmlNode node)
        {
            var element = (XmlElement)node;
            Comparison = SettingsHelper.ParseEnum<ProjectionComparison>(element["Comparison"]);
            TimingMethod = SettingsHelper.ParseEnum<ProjectionTimingMethod>(element["TimingMethod"]);
            Display2Rows = SettingsHelper.ParseBool(element["Display2Rows"], false);
        }

        public XmlNode GetSettings(XmlDocument document)
        {
            var parent = document.CreateElement("Settings");
            CreateSettingsNode(document, parent);
            return parent;
        }

        public int GetSettingsHashCode()
        {
            return CreateSettingsNode(null, null);
        }

        private int CreateSettingsNode(XmlDocument document, XmlElement parent)
        {
            return SettingsHelper.CreateSetting(document, parent, "Version", "1.0") ^
            SettingsHelper.CreateSetting(document, parent, "Comparison", Comparison) ^
            SettingsHelper.CreateSetting(document, parent, "TimingMethod", TimingMethod) ^
            SettingsHelper.CreateSetting(document, parent, "Display2Rows", Display2Rows);
        }

        private void cmpComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Comparison = (ProjectionComparison)cmpComboBox.SelectedIndex;
        }

        private void timingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimingMethod = (ProjectionTimingMethod)timingComboBox.SelectedIndex;
        }
    }
}
