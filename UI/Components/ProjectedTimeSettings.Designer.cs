
namespace LiveSplit.UI.Components
{
    partial class ProjectedTimeSettings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.topLevelLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.chkTwoRows = new System.Windows.Forms.CheckBox();
            this.basisGroupBox = new System.Windows.Forms.GroupBox();
            this.basisLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.timingComboBox = new System.Windows.Forms.ComboBox();
            this.cmpComboBox = new System.Windows.Forms.ComboBox();
            this.cmpLabel = new System.Windows.Forms.Label();
            this.timingLabel = new System.Windows.Forms.Label();
            this.percentCheckBox = new System.Windows.Forms.CheckBox();
            this.topLevelLayoutPanel.SuspendLayout();
            this.basisGroupBox.SuspendLayout();
            this.basisLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topLevelLayoutPanel
            // 
            this.topLevelLayoutPanel.AutoSize = true;
            this.topLevelLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.topLevelLayoutPanel.ColumnCount = 1;
            this.topLevelLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topLevelLayoutPanel.Controls.Add(this.chkTwoRows, 0, 0);
            this.topLevelLayoutPanel.Controls.Add(this.basisGroupBox, 0, 2);
            this.topLevelLayoutPanel.Controls.Add(this.percentCheckBox, 0, 1);
            this.topLevelLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.topLevelLayoutPanel.Name = "topLevelLayoutPanel";
            this.topLevelLayoutPanel.RowCount = 3;
            this.topLevelLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.topLevelLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.topLevelLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topLevelLayoutPanel.Size = new System.Drawing.Size(823, 222);
            this.topLevelLayoutPanel.TabIndex = 0;
            // 
            // chkTwoRows
            // 
            this.chkTwoRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkTwoRows.AutoSize = true;
            this.chkTwoRows.Location = new System.Drawing.Point(3, 10);
            this.chkTwoRows.Name = "chkTwoRows";
            this.chkTwoRows.Size = new System.Drawing.Size(817, 29);
            this.chkTwoRows.TabIndex = 0;
            this.chkTwoRows.Text = "Display Two Rows";
            this.chkTwoRows.UseVisualStyleBackColor = true;
            // 
            // basisGroupBox
            // 
            this.basisGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.basisGroupBox.AutoSize = true;
            this.basisGroupBox.Controls.Add(this.basisLayoutPanel);
            this.basisGroupBox.Location = new System.Drawing.Point(3, 103);
            this.basisGroupBox.Name = "basisGroupBox";
            this.basisGroupBox.Size = new System.Drawing.Size(817, 116);
            this.basisGroupBox.TabIndex = 1;
            this.basisGroupBox.TabStop = false;
            this.basisGroupBox.Text = "Projection Basis";
            // 
            // basisLayoutPanel
            // 
            this.basisLayoutPanel.AutoSize = true;
            this.basisLayoutPanel.ColumnCount = 2;
            this.basisLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 281F));
            this.basisLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.basisLayoutPanel.Controls.Add(this.timingComboBox, 1, 1);
            this.basisLayoutPanel.Controls.Add(this.cmpComboBox, 1, 0);
            this.basisLayoutPanel.Controls.Add(this.cmpLabel, 0, 0);
            this.basisLayoutPanel.Controls.Add(this.timingLabel, 0, 1);
            this.basisLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.basisLayoutPanel.Location = new System.Drawing.Point(3, 25);
            this.basisLayoutPanel.Name = "basisLayoutPanel";
            this.basisLayoutPanel.RowCount = 2;
            this.basisLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.basisLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.basisLayoutPanel.Size = new System.Drawing.Size(811, 88);
            this.basisLayoutPanel.TabIndex = 0;
            // 
            // timingComboBox
            // 
            this.timingComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timingComboBox.FormattingEnabled = true;
            this.timingComboBox.Items.AddRange(new object[] {
            "Current Timing Method",
            "Real Time",
            "Game Time"});
            this.timingComboBox.Location = new System.Drawing.Point(286, 50);
            this.timingComboBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.timingComboBox.Name = "timingComboBox";
            this.timingComboBox.Size = new System.Drawing.Size(520, 32);
            this.timingComboBox.TabIndex = 1;
            this.timingComboBox.SelectedIndexChanged += new System.EventHandler(this.timingComboBox_SelectedIndexChanged);
            // 
            // cmpComboBox
            // 
            this.cmpComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmpComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmpComboBox.FormattingEnabled = true;
            this.cmpComboBox.Items.AddRange(new object[] {
            "Current Comparison",
            "Personal Best",
            "Best Segments",
            "Average Segments"});
            this.cmpComboBox.Location = new System.Drawing.Point(286, 6);
            this.cmpComboBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cmpComboBox.Name = "cmpComboBox";
            this.cmpComboBox.Size = new System.Drawing.Size(520, 32);
            this.cmpComboBox.TabIndex = 0;
            this.cmpComboBox.SelectedIndexChanged += new System.EventHandler(this.cmpComboBox_SelectedIndexChanged);
            // 
            // cmpLabel
            // 
            this.cmpLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmpLabel.AutoSize = true;
            this.cmpLabel.Location = new System.Drawing.Point(3, 9);
            this.cmpLabel.Name = "cmpLabel";
            this.cmpLabel.Size = new System.Drawing.Size(275, 25);
            this.cmpLabel.TabIndex = 2;
            this.cmpLabel.Text = "Comparison:";
            // 
            // timingLabel
            // 
            this.timingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.timingLabel.AutoSize = true;
            this.timingLabel.Location = new System.Drawing.Point(3, 53);
            this.timingLabel.Name = "timingLabel";
            this.timingLabel.Size = new System.Drawing.Size(275, 25);
            this.timingLabel.TabIndex = 3;
            this.timingLabel.Text = "Timing Method:";
            // 
            // percentCheckBox
            // 
            this.percentCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.percentCheckBox.AutoSize = true;
            this.percentCheckBox.Location = new System.Drawing.Point(3, 60);
            this.percentCheckBox.Name = "percentCheckBox";
            this.percentCheckBox.Size = new System.Drawing.Size(817, 29);
            this.percentCheckBox.TabIndex = 2;
            this.percentCheckBox.Text = "Display Completion Percentage";
            this.percentCheckBox.UseVisualStyleBackColor = true;
            // 
            // ProjectedTimeSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.topLevelLayoutPanel);
            this.Name = "ProjectedTimeSettings";
            this.Size = new System.Drawing.Size(829, 228);
            this.Load += new System.EventHandler(this.ProjectedTimeSettings_Load);
            this.topLevelLayoutPanel.ResumeLayout(false);
            this.topLevelLayoutPanel.PerformLayout();
            this.basisGroupBox.ResumeLayout(false);
            this.basisGroupBox.PerformLayout();
            this.basisLayoutPanel.ResumeLayout(false);
            this.basisLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel topLevelLayoutPanel;
        private System.Windows.Forms.CheckBox chkTwoRows;
        private System.Windows.Forms.GroupBox basisGroupBox;
        private System.Windows.Forms.TableLayoutPanel basisLayoutPanel;
        private System.Windows.Forms.ComboBox cmpComboBox;
        private System.Windows.Forms.ComboBox timingComboBox;
        private System.Windows.Forms.Label cmpLabel;
        private System.Windows.Forms.Label timingLabel;
        private System.Windows.Forms.CheckBox percentCheckBox;
    }
}
