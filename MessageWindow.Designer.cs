namespace QPostMan
{
    partial class MessageWindow
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageWindow));
            this.MessageDisplayBox = new System.Windows.Forms.RichTextBox();
            this.MessageBoxDisplayOptions = new System.Windows.Forms.ToolStrip();
            this.MessageDisplayResultsSaveBtn = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.MessageBoxDisplayOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // MessageDisplayBox
            // 
            this.MessageDisplayBox.AccessibleName = "MessageDisplayBox";
            this.MessageDisplayBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageDisplayBox.BackColor = System.Drawing.Color.Silver;
            this.MessageDisplayBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MessageDisplayBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageDisplayBox.Location = new System.Drawing.Point(3, 39);
            this.MessageDisplayBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MessageDisplayBox.Name = "MessageDisplayBox";
            this.MessageDisplayBox.ReadOnly = true;
            this.MessageDisplayBox.Size = new System.Drawing.Size(1469, 815);
            this.MessageDisplayBox.TabIndex = 0;
            this.MessageDisplayBox.Text = "";
            this.MessageDisplayBox.Enter += new System.EventHandler(this.MessageDisplayBox_Enter);
            // 
            // MessageBoxDisplayOptions
            // 
            this.MessageBoxDisplayOptions.Dock = System.Windows.Forms.DockStyle.None;
            this.MessageBoxDisplayOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MessageBoxDisplayOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MessageDisplayResultsSaveBtn});
            this.MessageBoxDisplayOptions.Location = new System.Drawing.Point(0, 0);
            this.MessageBoxDisplayOptions.Name = "MessageBoxDisplayOptions";
            this.MessageBoxDisplayOptions.Size = new System.Drawing.Size(127, 30);
            this.MessageBoxDisplayOptions.TabIndex = 1;
            this.MessageBoxDisplayOptions.Text = "toolStrip1";
            // 
            // MessageDisplayResultsSaveBtn
            // 
            this.MessageDisplayResultsSaveBtn.Name = "MessageDisplayResultsSaveBtn";
            this.MessageDisplayResultsSaveBtn.Size = new System.Drawing.Size(109, 25);
            this.MessageDisplayResultsSaveBtn.Text = "Save Results";
            this.MessageDisplayResultsSaveBtn.Click += new System.EventHandler(this.MessageDisplayResultsSaveBtn_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(90, 22);
            this.toolStripLabel1.Text = "Save Results";
            // 
            // MessageWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 852);
            this.Controls.Add(this.MessageBoxDisplayOptions);
            this.Controls.Add(this.MessageDisplayBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MessageWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageWindow";
            this.Load += new System.EventHandler(this.MessageWindow_Load);
            this.MessageBoxDisplayOptions.ResumeLayout(false);
            this.MessageBoxDisplayOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox MessageDisplayBox;
        private System.Windows.Forms.ToolStrip MessageBoxDisplayOptions;
        private System.Windows.Forms.ToolStripLabel MessageDisplayResultsSaveBtn;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}