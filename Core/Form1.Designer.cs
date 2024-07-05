namespace JsonUtilities.Core
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.RichTextBox textBoxFinalJson;
        private System.Windows.Forms.TextBox textBoxOldValues;
        private System.Windows.Forms.TextBox textBoxNewValue;
        private System.Windows.Forms.RichTextBox textBoxMergeJson;
        private System.Windows.Forms.Label labelOldValues;
        private System.Windows.Forms.Label labelNewValue;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.SplitContainer splitContainer;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxFinalJson = new System.Windows.Forms.RichTextBox();
            this.textBoxOldValues = new System.Windows.Forms.TextBox();
            this.textBoxNewValue = new System.Windows.Forms.TextBox();
            this.textBoxMergeJson = new System.Windows.Forms.RichTextBox();
            this.labelOldValues = new System.Windows.Forms.Label();
            this.labelNewValue = new System.Windows.Forms.Label();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.labelOldValues, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.textBoxOldValues, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.labelNewValue, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.textBoxNewValue, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.splitContainer, 0, 2);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // labelOldValues
            // 
            this.labelOldValues.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelOldValues.AutoSize = true;
            this.labelOldValues.Location = new System.Drawing.Point(18, 7);
            this.labelOldValues.Name = "labelOldValues";
            this.labelOldValues.Size = new System.Drawing.Size(59, 17);
            this.labelOldValues.TabIndex = 0;
            this.labelOldValues.Text = "Old Values";
            // 
            // textBoxOldValues
            // 
            this.textBoxOldValues.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOldValues.Location = new System.Drawing.Point(83, 4);
            this.textBoxOldValues.Name = "textBoxOldValues";
            this.textBoxOldValues.Size = new System.Drawing.Size(714, 22);
            this.textBoxOldValues.TabIndex = 1;
            this.textBoxOldValues.Text = "https://statements.innovamat.com;https://locutions.innovamat.com";
            // 
            // labelNewValue
            // 
            this.labelNewValue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelNewValue.AutoSize = true;
            this.labelNewValue.Location = new System.Drawing.Point(12, 37);
            this.labelNewValue.Name = "labelNewValue";
            this.labelNewValue.Size = new System.Drawing.Size(65, 17);
            this.labelNewValue.TabIndex = 2;
            this.labelNewValue.Text = "New Value";
            // 
            // textBoxNewValue
            // 
            this.textBoxNewValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNewValue.Location = new System.Drawing.Point(83, 34);
            this.textBoxNewValue.Name = "textBoxNewValue";
            this.textBoxNewValue.Size = new System.Drawing.Size(714, 22);
            this.textBoxNewValue.TabIndex = 3;
            this.textBoxNewValue.Text = "http://localhost:8000";
            // 
            // splitContainer
            // 
            this.tableLayoutPanel.SetColumnSpan(this.splitContainer, 2);
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(3, 63);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.textBoxMergeJson);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.textBoxFinalJson);
            this.splitContainer.Size = new System.Drawing.Size(794, 384);
            this.splitContainer.SplitterDistance = 128;
            this.splitContainer.TabIndex = 4;
            // 
            // textBoxMergeJson
            // 
            this.textBoxMergeJson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxMergeJson.Location = new System.Drawing.Point(0, 0);
            this.textBoxMergeJson.Multiline = true;
            this.textBoxMergeJson.Name = "textBoxMergeJson";
            this.textBoxMergeJson.ScrollBars = RichTextBoxScrollBars.Vertical;
            this.textBoxMergeJson.Size = new System.Drawing.Size(794, 128);
            this.textBoxMergeJson.TabIndex = 5;
            this.textBoxMergeJson.Text = """
                                         {
                                           "interface": "Navigable",
                                           "session" : "Quiz"
                                         }
                                         """;
            // 
            // textBoxFinalJson
            // 
            this.textBoxFinalJson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxFinalJson.Location = new System.Drawing.Point(0, 0);
            this.textBoxFinalJson.Multiline = true;
            this.textBoxFinalJson.Name = "textBoxFinalJson";
            this.textBoxFinalJson.ScrollBars = RichTextBoxScrollBars.Vertical ;
            this.textBoxFinalJson.Size = new System.Drawing.Size(794, 252);
            this.textBoxFinalJson.TabIndex = 6;
            this.textBoxFinalJson.DetectUrls = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "Form1";
            this.Text = "JSON Drag and Drop";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        

    }
}
