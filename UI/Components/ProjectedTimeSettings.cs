using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace LiveSplit.UI.Components
{
    public partial class ProjectedTimeSettings : UserControl
    {
        public Color LabelColor { get; set; }
        public bool OverrideLabelColor { get; set; }
        public Color ProjectionColor { get; set; }
        public bool OverrideProjectionColor { get; set; }
        public bool PaceProjectionColor { get; set; }
        public Color BackgroundColor1 { get; set; }
        public Color BackgroundColor2 { get; set; }
        public GradientType BackgroundGradient { get; set; }
        public string GradientString
        {
            get { return BackgroundGradient.ToString(); }
            set { BackgroundGradient = (GradientType)Enum.Parse(typeof(GradientType), value); }
        }

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
        public enum DecimalAccuracy
        {
            ZeroDecimal = 0,
            OneDecimal = 1,
            TwoDecimal = 2
        }
        public DecimalAccuracy CompletionAccuracy { get; set; }
        public bool ShowTrailingZeroes { get; set; }
        
        public bool Display2Rows { get; set; }

        public LayoutMode Mode { get; set; }

        public ProjectedTimeSettings()
        {
            InitializeComponent();

            LabelColor = Color.FromArgb(255, 255, 255);
            OverrideLabelColor = false;
            ProjectionColor = Color.FromArgb(255, 255, 255);
            OverrideProjectionColor = false;
            PaceProjectionColor = false;
            BackgroundColor1 = Color.Transparent;
            BackgroundColor2 = Color.Transparent;
            BackgroundGradient = GradientType.Plain;

            chkOverrideLabelColor.DataBindings.Add("Checked", this, "OverrideLabelColor", false, DataSourceUpdateMode.OnPropertyChanged);
            btnLabelColor.DataBindings.Add("BackColor", this, "LabelColor", false, DataSourceUpdateMode.OnPropertyChanged);
            chkOverrideProjectionColor.DataBindings.Add("Checked", this, "OverrideProjectionColor", false, DataSourceUpdateMode.OnPropertyChanged);
            btnProjectionColor.DataBindings.Add("BackColor", this, "ProjectionColor", false, DataSourceUpdateMode.OnPropertyChanged);
            chkPaceColor.DataBindings.Add("Checked", this, "PaceProjectionColor", false, DataSourceUpdateMode.OnPropertyChanged);
            btnBgColor1.DataBindings.Add("BackColor", this, "BackgroundColor1", false, DataSourceUpdateMode.OnPropertyChanged);
            btnBgColor2.DataBindings.Add("BackColor", this, "BackgroundColor2", false, DataSourceUpdateMode.OnPropertyChanged);
            cmbGradientType.DataBindings.Add("SelectedItem", this, "GradientString", false, DataSourceUpdateMode.OnPropertyChanged);

            Comparison = ProjectionComparison.CurrentComparison;
            TimingMethod = ProjectionTimingMethod.CurrentTimingMethod;
            DisplayCompletionPercent = false;
            CompletionAccuracy = DecimalAccuracy.ZeroDecimal;
            ShowTrailingZeroes = false;
            Display2Rows = false;

            percentCheckBox.DataBindings.Add("Checked", this, "DisplayCompletionPercent", false, DataSourceUpdateMode.OnPropertyChanged);
            chkTrailingZeroes.DataBindings.Add("Checked", this, "ShowTrailingZeroes", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void ProjectedTimeSettings_Load(object sender, EventArgs e)
        {
            chkOverrideLabelColor_CheckedChanged(null, null);
            chkOverrideProjectionColor_CheckedChanged(null, null);
            chkPaceColor_CheckStateChanged(null, null);

            cmpComboBox.SelectedIndex = (int)Comparison;
            timingComboBox.SelectedIndex = (int)TimingMethod;
            zeroDecimalRadioButton.Checked = CompletionAccuracy == DecimalAccuracy.ZeroDecimal;
            oneDecimalRadioButton.Checked = CompletionAccuracy == DecimalAccuracy.OneDecimal;
            twoDecimalRadioButton.Checked = CompletionAccuracy == DecimalAccuracy.TwoDecimal;
            UpdateDecimalOptionsEnabled();

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

            LabelColor = SettingsHelper.ParseColor(element["LabelColor"]);
            OverrideLabelColor = SettingsHelper.ParseBool(element["OverrideLabelColor"]);
            ProjectionColor = SettingsHelper.ParseColor(element["ProjectionColor"]);
            OverrideProjectionColor = SettingsHelper.ParseBool(element["OverrideProjectionColor"]);
            PaceProjectionColor = SettingsHelper.ParseBool(element["PaceProjectionColor"]);
            BackgroundColor1 = SettingsHelper.ParseColor(element["BackgroundColor1"]);
            BackgroundColor2 = SettingsHelper.ParseColor(element["BackgroundColor2"]);
            GradientString = SettingsHelper.ParseString(element["BackgroundGradient"]);

            Comparison = SettingsHelper.ParseEnum<ProjectionComparison>(element["Comparison"]);
            TimingMethod = SettingsHelper.ParseEnum<ProjectionTimingMethod>(element["TimingMethod"]);
            DisplayCompletionPercent = SettingsHelper.ParseBool(element["DisplayCompletionPercent"]);
            CompletionAccuracy = SettingsHelper.ParseEnum<DecimalAccuracy>(element["CompletionAccuracy"]);
            ShowTrailingZeroes = SettingsHelper.ParseBool(element["ShowTrailingZeroes"]);
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
            return SettingsHelper.CreateSetting(document, parent, "Version", "1.1.0") ^
                SettingsHelper.CreateSetting(document, parent, "LabelColor", LabelColor) ^
                SettingsHelper.CreateSetting(document, parent, "OverrideLabelColor", OverrideLabelColor) ^
                SettingsHelper.CreateSetting(document, parent, "ProjectionColor", ProjectionColor) ^
                SettingsHelper.CreateSetting(document, parent, "OverrideProjectionColor", OverrideProjectionColor) ^
                SettingsHelper.CreateSetting(document, parent, "PaceProjectionColor", PaceProjectionColor) ^
                SettingsHelper.CreateSetting(document, parent, "BackgroundColor1", BackgroundColor1) ^
                SettingsHelper.CreateSetting(document, parent, "BackgroundColor2", BackgroundColor2) ^
                SettingsHelper.CreateSetting(document, parent, "BackgroundGradient", BackgroundGradient) ^
                SettingsHelper.CreateSetting(document, parent, "Comparison", Comparison) ^
                SettingsHelper.CreateSetting(document, parent, "TimingMethod", TimingMethod) ^
                SettingsHelper.CreateSetting(document, parent, "DisplayCompletionPercent", DisplayCompletionPercent) ^
                SettingsHelper.CreateSetting(document, parent, "CompletionAccuracy", CompletionAccuracy) ^
                SettingsHelper.CreateSetting(document, parent, "ShowTrailingZeroes", ShowTrailingZeroes) ^
                SettingsHelper.CreateSetting(document, parent, "Display2Rows", Display2Rows);
        }

        private void chkOverrideLabelColor_CheckedChanged(object sender, EventArgs e)
        {
            labelColorLabel.Enabled = btnLabelColor.Enabled = chkOverrideLabelColor.Checked;
        }

        private void chkOverrideProjectionColor_CheckedChanged(object sender, EventArgs e)
        {
            projectionColorLabel.Enabled = btnProjectionColor.Enabled = chkOverrideProjectionColor.Checked && !chkPaceColor.Checked;
        }

        private void chkPaceColor_CheckStateChanged(object sender, EventArgs e)
        {
            chkOverrideProjectionColor_CheckedChanged(sender, e);
            if (chkPaceColor.Checked)
            {
                chkOverrideProjectionColor.Checked = false;
                chkOverrideProjectionColor.Enabled = false;
                chkOverrideProjectionColor.DataBindings.Clear();
            }
            else
            {
                chkOverrideProjectionColor.Enabled = true;
                chkOverrideProjectionColor.DataBindings.Clear();
                chkOverrideProjectionColor.DataBindings.Add("Checked", this, "OverrideProjectionColor", false, DataSourceUpdateMode.OnPropertyChanged);
            }
        }

        private void ColorButtonClick(object sender, EventArgs e)
        {
            SettingsHelper.ColorButtonClick((Button)sender, this);
        }

        private void cmbGradientType_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnBgColor1.Visible = cmbGradientType.SelectedItem.ToString() != "Plain";
            btnBgColor2.DataBindings.Clear();
            btnBgColor2.DataBindings.Add("BackColor", this, btnBgColor1.Visible ? "BackgroundColor2" : "BackgroundColor1", false, DataSourceUpdateMode.OnPropertyChanged);
            GradientString = cmbGradientType.SelectedItem.ToString();
        }

        private void cmpComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Comparison = (ProjectionComparison)cmpComboBox.SelectedIndex;
        }

        private void timingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimingMethod = (ProjectionTimingMethod)timingComboBox.SelectedIndex;
        }

        private void percentCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            UpdateDecimalOptionsEnabled();
        }

        private void UpdateDecimalOptionsEnabled()
        {
            zeroDecimalRadioButton.Enabled = DisplayCompletionPercent;
            oneDecimalRadioButton.Enabled = DisplayCompletionPercent;
            twoDecimalRadioButton.Enabled = DisplayCompletionPercent;
            chkTrailingZeroes.Enabled = DisplayCompletionPercent;
        }

        private void zeroDecimalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateAccuracy();
        }

        private void oneDecimalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateAccuracy();
        }

        private void twoDecimalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateAccuracy();
        }

        private void UpdateAccuracy()
        {
            if (zeroDecimalRadioButton.Checked)
            {
                CompletionAccuracy = DecimalAccuracy.ZeroDecimal;
            }
            else if (oneDecimalRadioButton.Checked)
            {
                CompletionAccuracy = DecimalAccuracy.OneDecimal;
            }
            else
            {
                CompletionAccuracy = DecimalAccuracy.TwoDecimal;
            }
        }
    }
}
