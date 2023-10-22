namespace QPostMan
{
    partial class MainWindo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindo));
            this.TextBoxUrl = new System.Windows.Forms.TextBox();
            this.ProssesRequestBtn = new System.Windows.Forms.Button();
            this.RequestHeaders = new System.Windows.Forms.DataGridView();
            this.Header = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResponseHeaders = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestLabel = new System.Windows.Forms.Label();
            this.ResponseLabel = new System.Windows.Forms.Label();
            this.ClearUrlInput = new System.Windows.Forms.Button();
            this.LogsBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.RequestHeaders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResponseHeaders)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxUrl
            // 
            this.TextBoxUrl.Location = new System.Drawing.Point(12, 39);
            this.TextBoxUrl.Name = "TextBoxUrl";
            this.TextBoxUrl.Size = new System.Drawing.Size(1097, 44);
            this.TextBoxUrl.TabIndex = 1;
            this.TextBoxUrl.Text = "http://example.com/";
            this.TextBoxUrl.MouseLeave += new System.EventHandler(this.TextBoxUrl_MouseLeave);
            this.TextBoxUrl.MouseHover += new System.EventHandler(this.TextBoxUrl_MouseHover);
            // 
            // ProssesRequestBtn
            // 
            this.ProssesRequestBtn.BackColor = System.Drawing.Color.White;
            this.ProssesRequestBtn.ForeColor = System.Drawing.Color.Black;
            this.ProssesRequestBtn.Location = new System.Drawing.Point(1197, 35);
            this.ProssesRequestBtn.Name = "ProssesRequestBtn";
            this.ProssesRequestBtn.Size = new System.Drawing.Size(103, 45);
            this.ProssesRequestBtn.TabIndex = 2;
            this.ProssesRequestBtn.Text = "GET";
            this.ProssesRequestBtn.UseVisualStyleBackColor = false;
            this.ProssesRequestBtn.Click += new System.EventHandler(this.ProssesRequestBtn_Click);
            // 
            // RequestHeaders
            // 
            this.RequestHeaders.AllowUserToOrderColumns = true;
            this.RequestHeaders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RequestHeaders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RequestHeaders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Header,
            this.Value});
            this.RequestHeaders.Location = new System.Drawing.Point(12, 125);
            this.RequestHeaders.Name = "RequestHeaders";
            this.RequestHeaders.RowHeadersWidth = 51;
            this.RequestHeaders.RowTemplate.Height = 24;
            this.RequestHeaders.Size = new System.Drawing.Size(556, 545);
            this.RequestHeaders.TabIndex = 3;
            // 
            // Header
            // 
            this.Header.DataPropertyName = "HeaderRequest";
            this.Header.FillWeight = 200F;
            this.Header.HeaderText = "Header";
            this.Header.MinimumWidth = 6;
            this.Header.Name = "Header";
            this.Header.Width = 250;
            // 
            // Value
            // 
            this.Value.DataPropertyName = "ValueRequest";
            this.Value.FillWeight = 200F;
            this.Value.HeaderText = "Value";
            this.Value.MinimumWidth = 6;
            this.Value.Name = "Value";
            this.Value.Width = 250;
            // 
            // ResponseHeaders
            // 
            this.ResponseHeaders.AllowUserToOrderColumns = true;
            this.ResponseHeaders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ResponseHeaders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResponseHeaders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.ResponseHeaders.Location = new System.Drawing.Point(742, 125);
            this.ResponseHeaders.Name = "ResponseHeaders";
            this.ResponseHeaders.RowHeadersWidth = 51;
            this.ResponseHeaders.RowTemplate.Height = 24;
            this.ResponseHeaders.Size = new System.Drawing.Size(556, 545);
            this.ResponseHeaders.TabIndex = 4;
            this.ResponseHeaders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ResponseHeaders_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "HeaderResponse";
            this.dataGridViewTextBoxColumn1.FillWeight = 200F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Header";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 250;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ValueResponse";
            this.dataGridViewTextBoxColumn2.FillWeight = 200F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Value";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // RequestLabel
            // 
            this.RequestLabel.AutoSize = true;
            this.RequestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequestLabel.ForeColor = System.Drawing.Color.Lime;
            this.RequestLabel.Location = new System.Drawing.Point(198, 80);
            this.RequestLabel.Name = "RequestLabel";
            this.RequestLabel.Size = new System.Drawing.Size(168, 46);
            this.RequestLabel.TabIndex = 5;
            this.RequestLabel.Text = "Request";
            // 
            // ResponseLabel
            // 
            this.ResponseLabel.AutoSize = true;
            this.ResponseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResponseLabel.ForeColor = System.Drawing.Color.Yellow;
            this.ResponseLabel.Location = new System.Drawing.Point(944, 83);
            this.ResponseLabel.Name = "ResponseLabel";
            this.ResponseLabel.Size = new System.Drawing.Size(200, 46);
            this.ResponseLabel.TabIndex = 6;
            this.ResponseLabel.Text = "Response";
            // 
            // ClearUrlInput
            // 
            this.ClearUrlInput.BackColor = System.Drawing.Color.Silver;
            this.ClearUrlInput.Location = new System.Drawing.Point(1116, 37);
            this.ClearUrlInput.Name = "ClearUrlInput";
            this.ClearUrlInput.Size = new System.Drawing.Size(75, 41);
            this.ClearUrlInput.TabIndex = 7;
            this.ClearUrlInput.UseVisualStyleBackColor = false;
            this.ClearUrlInput.Click += new System.EventHandler(this.ClearUrlInput_Click);
            // 
            // LogsBox
            // 
            this.LogsBox.Location = new System.Drawing.Point(12, 676);
            this.LogsBox.Name = "LogsBox";
            this.LogsBox.Size = new System.Drawing.Size(1288, 44);
            this.LogsBox.TabIndex = 8;
            // 
            // MainWindo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1310, 730);
            this.Controls.Add(this.LogsBox);
            this.Controls.Add(this.ClearUrlInput);
            this.Controls.Add(this.ResponseLabel);
            this.Controls.Add(this.RequestLabel);
            this.Controls.Add(this.ResponseHeaders);
            this.Controls.Add(this.RequestHeaders);
            this.Controls.Add(this.ProssesRequestBtn);
            this.Controls.Add(this.TextBoxUrl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainWindo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QPostMan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainWindo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RequestHeaders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResponseHeaders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextBoxUrl;
        private System.Windows.Forms.Button ProssesRequestBtn;
        private System.Windows.Forms.DataGridView RequestHeaders;
        private System.Windows.Forms.DataGridView ResponseHeaders;
        private System.Windows.Forms.Label RequestLabel;
        private System.Windows.Forms.Label ResponseLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Header;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button ClearUrlInput;
        private System.Windows.Forms.TextBox LogsBox;
    }
}

