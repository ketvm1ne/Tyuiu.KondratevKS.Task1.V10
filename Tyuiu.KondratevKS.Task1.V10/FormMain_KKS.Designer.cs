namespace Tyuiu.KondratevKS.Task1.V10
{
    partial class FormMain_KKS
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView_KKS = new System.Windows.Forms.DataGridView();
            this.SearchTextBox_KKS = new System.Windows.Forms.TextBox();
            this.OrdersButton_KKS = new System.Windows.Forms.Button();
            this.ClientsButton_KKS = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SaveButton_KKS = new System.Windows.Forms.Button();
            this.ReadButton_KKS = new System.Windows.Forms.Button();
            this.FiltrationLabel_KKS = new System.Windows.Forms.Label();
            this.ClearButton_KKS = new System.Windows.Forms.Button();
            this.FiltrationComboBox_KKS = new System.Windows.Forms.ComboBox();
            this.FindButton_KKS = new System.Windows.Forms.Button();
            this.MinTextBox_KKS = new System.Windows.Forms.TextBox();
            this.MaxTextBox_KKS = new System.Windows.Forms.TextBox();
            this.MinLabel_KKS = new System.Windows.Forms.Label();
            this.MaxLabel_KKS = new System.Windows.Forms.Label();
            this.RefreshButton_KKS = new System.Windows.Forms.Button();
            this.CountTextBox_KKS = new System.Windows.Forms.TextBox();
            this.AVGCostTextBox_KKS = new System.Windows.Forms.TextBox();
            this.MinCostTextBox_KKS = new System.Windows.Forms.TextBox();
            this.MaxCostTextBox_KKS = new System.Windows.Forms.TextBox();
            this.CountLabel_KKS = new System.Windows.Forms.Label();
            this.AVGCostLabel_KKS = new System.Windows.Forms.Label();
            this.MinCostLabel_KKS = new System.Windows.Forms.Label();
            this.MaxCostLabel_KKS = new System.Windows.Forms.Label();
            this.ChartsButton_KKS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_KKS)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_KKS
            // 
            this.dataGridView_KKS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_KKS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_KKS.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView_KKS.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView_KKS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_KKS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_KKS.Location = new System.Drawing.Point(16, 12);
            this.dataGridView_KKS.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_KKS.Name = "dataGridView_KKS";
            this.dataGridView_KKS.RowHeadersWidth = 51;
            this.dataGridView_KKS.Size = new System.Drawing.Size(1227, 533);
            this.dataGridView_KKS.TabIndex = 0;
            this.dataGridView_KKS.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_KKS_CellEndEdit);
            this.dataGridView_KKS.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_KKS_CellValueChanged);
            // 
            // SearchTextBox_KKS
            // 
            this.SearchTextBox_KKS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTextBox_KKS.Location = new System.Drawing.Point(1256, 166);
            this.SearchTextBox_KKS.Margin = new System.Windows.Forms.Padding(4);
            this.SearchTextBox_KKS.Name = "SearchTextBox_KKS";
            this.SearchTextBox_KKS.Size = new System.Drawing.Size(212, 22);
            this.SearchTextBox_KKS.TabIndex = 1;
            this.SearchTextBox_KKS.TextChanged += new System.EventHandler(this.SearchTextBox_KKS_TextChanged);
            this.SearchTextBox_KKS.Enter += new System.EventHandler(this.SearchTextBox_KKS_Enter);
            this.SearchTextBox_KKS.Leave += new System.EventHandler(this.SearchTextBox_KKS_Leave);
            // 
            // OrdersButton_KKS
            // 
            this.OrdersButton_KKS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OrdersButton_KKS.Location = new System.Drawing.Point(1364, 12);
            this.OrdersButton_KKS.Margin = new System.Windows.Forms.Padding(4);
            this.OrdersButton_KKS.Name = "OrdersButton_KKS";
            this.OrdersButton_KKS.Size = new System.Drawing.Size(100, 28);
            this.OrdersButton_KKS.TabIndex = 2;
            this.OrdersButton_KKS.Text = "Orders";
            this.OrdersButton_KKS.UseVisualStyleBackColor = true;
            this.OrdersButton_KKS.Click += new System.EventHandler(this.OrdersButton_KKS_Click);
            // 
            // ClientsButton_KKS
            // 
            this.ClientsButton_KKS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientsButton_KKS.BackColor = System.Drawing.SystemColors.Window;
            this.ClientsButton_KKS.Cursor = System.Windows.Forms.Cursors.Default;
            this.ClientsButton_KKS.Location = new System.Drawing.Point(1256, 12);
            this.ClientsButton_KKS.Margin = new System.Windows.Forms.Padding(4);
            this.ClientsButton_KKS.Name = "ClientsButton_KKS";
            this.ClientsButton_KKS.Size = new System.Drawing.Size(103, 28);
            this.ClientsButton_KKS.TabIndex = 3;
            this.ClientsButton_KKS.Text = "Clients";
            this.ClientsButton_KKS.UseVisualStyleBackColor = false;
            this.ClientsButton_KKS.Click += new System.EventHandler(this.ClientsButton_KKS_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // SaveButton_KKS
            // 
            this.SaveButton_KKS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton_KKS.Location = new System.Drawing.Point(1256, 503);
            this.SaveButton_KKS.Margin = new System.Windows.Forms.Padding(4);
            this.SaveButton_KKS.Name = "SaveButton_KKS";
            this.SaveButton_KKS.Size = new System.Drawing.Size(103, 42);
            this.SaveButton_KKS.TabIndex = 5;
            this.SaveButton_KKS.Text = "Save file";
            this.SaveButton_KKS.UseVisualStyleBackColor = true;
            this.SaveButton_KKS.Click += new System.EventHandler(this.SaveButton_KKS_Click);
            // 
            // ReadButton_KKS
            // 
            this.ReadButton_KKS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReadButton_KKS.Location = new System.Drawing.Point(1367, 503);
            this.ReadButton_KKS.Margin = new System.Windows.Forms.Padding(4);
            this.ReadButton_KKS.Name = "ReadButton_KKS";
            this.ReadButton_KKS.Size = new System.Drawing.Size(103, 42);
            this.ReadButton_KKS.TabIndex = 7;
            this.ReadButton_KKS.Text = "Open file";
            this.ReadButton_KKS.UseVisualStyleBackColor = true;
            this.ReadButton_KKS.Click += new System.EventHandler(this.ReadButton_KKS_Click);
            // 
            // FiltrationLabel_KKS
            // 
            this.FiltrationLabel_KKS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FiltrationLabel_KKS.AutoSize = true;
            this.FiltrationLabel_KKS.Location = new System.Drawing.Point(1252, 206);
            this.FiltrationLabel_KKS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FiltrationLabel_KKS.Name = "FiltrationLabel_KKS";
            this.FiltrationLabel_KKS.Size = new System.Drawing.Size(62, 17);
            this.FiltrationLabel_KKS.TabIndex = 8;
            this.FiltrationLabel_KKS.Text = "Filtration";
            // 
            // ClearButton_KKS
            // 
            this.ClearButton_KKS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearButton_KKS.Location = new System.Drawing.Point(1256, 48);
            this.ClearButton_KKS.Margin = new System.Windows.Forms.Padding(4);
            this.ClearButton_KKS.Name = "ClearButton_KKS";
            this.ClearButton_KKS.Size = new System.Drawing.Size(208, 28);
            this.ClearButton_KKS.TabIndex = 9;
            this.ClearButton_KKS.Text = "Clear table";
            this.ClearButton_KKS.UseVisualStyleBackColor = true;
            this.ClearButton_KKS.Click += new System.EventHandler(this.ClearButton_KKS_Click);
            // 
            // FiltrationComboBox_KKS
            // 
            this.FiltrationComboBox_KKS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FiltrationComboBox_KKS.FormattingEnabled = true;
            this.FiltrationComboBox_KKS.Items.AddRange(new object[] {
            "OrderCost",
            "ProductCount"});
            this.FiltrationComboBox_KKS.Location = new System.Drawing.Point(1256, 225);
            this.FiltrationComboBox_KKS.Margin = new System.Windows.Forms.Padding(4);
            this.FiltrationComboBox_KKS.Name = "FiltrationComboBox_KKS";
            this.FiltrationComboBox_KKS.Size = new System.Drawing.Size(207, 24);
            this.FiltrationComboBox_KKS.TabIndex = 10;
            // 
            // FindButton_KKS
            // 
            this.FindButton_KKS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FindButton_KKS.Location = new System.Drawing.Point(1256, 311);
            this.FindButton_KKS.Margin = new System.Windows.Forms.Padding(4);
            this.FindButton_KKS.Name = "FindButton_KKS";
            this.FindButton_KKS.Size = new System.Drawing.Size(213, 28);
            this.FindButton_KKS.TabIndex = 11;
            this.FindButton_KKS.Text = "Find";
            this.FindButton_KKS.UseVisualStyleBackColor = true;
            this.FindButton_KKS.Click += new System.EventHandler(this.FindButton_KKS_Click);
            // 
            // MinTextBox_KKS
            // 
            this.MinTextBox_KKS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinTextBox_KKS.Location = new System.Drawing.Point(1256, 279);
            this.MinTextBox_KKS.Margin = new System.Windows.Forms.Padding(4);
            this.MinTextBox_KKS.Name = "MinTextBox_KKS";
            this.MinTextBox_KKS.Size = new System.Drawing.Size(101, 22);
            this.MinTextBox_KKS.TabIndex = 12;
            // 
            // MaxTextBox_KKS
            // 
            this.MaxTextBox_KKS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxTextBox_KKS.Location = new System.Drawing.Point(1367, 279);
            this.MaxTextBox_KKS.Margin = new System.Windows.Forms.Padding(4);
            this.MaxTextBox_KKS.Name = "MaxTextBox_KKS";
            this.MaxTextBox_KKS.Size = new System.Drawing.Size(101, 22);
            this.MaxTextBox_KKS.TabIndex = 13;
            // 
            // MinLabel_KKS
            // 
            this.MinLabel_KKS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinLabel_KKS.AutoSize = true;
            this.MinLabel_KKS.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MinLabel_KKS.Location = new System.Drawing.Point(1252, 261);
            this.MinLabel_KKS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MinLabel_KKS.Name = "MinLabel_KKS";
            this.MinLabel_KKS.Size = new System.Drawing.Size(30, 17);
            this.MinLabel_KKS.TabIndex = 14;
            this.MinLabel_KKS.Text = "min";
            // 
            // MaxLabel_KKS
            // 
            this.MaxLabel_KKS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxLabel_KKS.AutoSize = true;
            this.MaxLabel_KKS.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MaxLabel_KKS.Location = new System.Drawing.Point(1367, 261);
            this.MaxLabel_KKS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MaxLabel_KKS.Name = "MaxLabel_KKS";
            this.MaxLabel_KKS.Size = new System.Drawing.Size(33, 17);
            this.MaxLabel_KKS.TabIndex = 15;
            this.MaxLabel_KKS.Text = "max";
            // 
            // RefreshButton_KKS
            // 
            this.RefreshButton_KKS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RefreshButton_KKS.Location = new System.Drawing.Point(1256, 348);
            this.RefreshButton_KKS.Margin = new System.Windows.Forms.Padding(4);
            this.RefreshButton_KKS.Name = "RefreshButton_KKS";
            this.RefreshButton_KKS.Size = new System.Drawing.Size(213, 28);
            this.RefreshButton_KKS.TabIndex = 16;
            this.RefreshButton_KKS.Text = "Refresh";
            this.RefreshButton_KKS.UseVisualStyleBackColor = true;
            this.RefreshButton_KKS.Click += new System.EventHandler(this.RefreshButton_KKS_Click);
            // 
            // CountTextBox_KKS
            // 
            this.CountTextBox_KKS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CountTextBox_KKS.BackColor = System.Drawing.SystemColors.Window;
            this.CountTextBox_KKS.Location = new System.Drawing.Point(16, 578);
            this.CountTextBox_KKS.Margin = new System.Windows.Forms.Padding(4);
            this.CountTextBox_KKS.Name = "CountTextBox_KKS";
            this.CountTextBox_KKS.ReadOnly = true;
            this.CountTextBox_KKS.Size = new System.Drawing.Size(132, 22);
            this.CountTextBox_KKS.TabIndex = 17;
            // 
            // AVGCostTextBox_KKS
            // 
            this.AVGCostTextBox_KKS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AVGCostTextBox_KKS.BackColor = System.Drawing.SystemColors.Window;
            this.AVGCostTextBox_KKS.Location = new System.Drawing.Point(157, 578);
            this.AVGCostTextBox_KKS.Margin = new System.Windows.Forms.Padding(4);
            this.AVGCostTextBox_KKS.Name = "AVGCostTextBox_KKS";
            this.AVGCostTextBox_KKS.ReadOnly = true;
            this.AVGCostTextBox_KKS.Size = new System.Drawing.Size(132, 22);
            this.AVGCostTextBox_KKS.TabIndex = 18;
            // 
            // MinCostTextBox_KKS
            // 
            this.MinCostTextBox_KKS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MinCostTextBox_KKS.BackColor = System.Drawing.SystemColors.Window;
            this.MinCostTextBox_KKS.Location = new System.Drawing.Point(299, 578);
            this.MinCostTextBox_KKS.Margin = new System.Windows.Forms.Padding(4);
            this.MinCostTextBox_KKS.Name = "MinCostTextBox_KKS";
            this.MinCostTextBox_KKS.ReadOnly = true;
            this.MinCostTextBox_KKS.Size = new System.Drawing.Size(132, 22);
            this.MinCostTextBox_KKS.TabIndex = 19;
            // 
            // MaxCostTextBox_KKS
            // 
            this.MaxCostTextBox_KKS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MaxCostTextBox_KKS.BackColor = System.Drawing.SystemColors.Window;
            this.MaxCostTextBox_KKS.Location = new System.Drawing.Point(440, 578);
            this.MaxCostTextBox_KKS.Margin = new System.Windows.Forms.Padding(4);
            this.MaxCostTextBox_KKS.Name = "MaxCostTextBox_KKS";
            this.MaxCostTextBox_KKS.ReadOnly = true;
            this.MaxCostTextBox_KKS.Size = new System.Drawing.Size(132, 22);
            this.MaxCostTextBox_KKS.TabIndex = 20;
            // 
            // CountLabel_KKS
            // 
            this.CountLabel_KKS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CountLabel_KKS.AutoSize = true;
            this.CountLabel_KKS.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CountLabel_KKS.Location = new System.Drawing.Point(17, 560);
            this.CountLabel_KKS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CountLabel_KKS.Name = "CountLabel_KKS";
            this.CountLabel_KKS.Size = new System.Drawing.Size(43, 17);
            this.CountLabel_KKS.TabIndex = 21;
            this.CountLabel_KKS.Text = "count";
            // 
            // AVGCostLabel_KKS
            // 
            this.AVGCostLabel_KKS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AVGCostLabel_KKS.AutoSize = true;
            this.AVGCostLabel_KKS.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AVGCostLabel_KKS.Location = new System.Drawing.Point(159, 560);
            this.AVGCostLabel_KKS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AVGCostLabel_KKS.Name = "AVGCostLabel_KKS";
            this.AVGCostLabel_KKS.Size = new System.Drawing.Size(90, 17);
            this.AVGCostLabel_KKS.TabIndex = 22;
            this.AVGCostLabel_KKS.Text = "average cost";
            // 
            // MinCostLabel_KKS
            // 
            this.MinCostLabel_KKS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MinCostLabel_KKS.AutoSize = true;
            this.MinCostLabel_KKS.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MinCostLabel_KKS.Location = new System.Drawing.Point(300, 560);
            this.MinCostLabel_KKS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MinCostLabel_KKS.Name = "MinCostLabel_KKS";
            this.MinCostLabel_KKS.Size = new System.Drawing.Size(60, 17);
            this.MinCostLabel_KKS.TabIndex = 23;
            this.MinCostLabel_KKS.Text = "min cost";
            // 
            // MaxCostLabel_KKS
            // 
            this.MaxCostLabel_KKS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MaxCostLabel_KKS.AutoSize = true;
            this.MaxCostLabel_KKS.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MaxCostLabel_KKS.Location = new System.Drawing.Point(440, 560);
            this.MaxCostLabel_KKS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MaxCostLabel_KKS.Name = "MaxCostLabel_KKS";
            this.MaxCostLabel_KKS.Size = new System.Drawing.Size(63, 17);
            this.MaxCostLabel_KKS.TabIndex = 24;
            this.MaxCostLabel_KKS.Text = "max cost";
            // 
            // ChartsButton_KKS
            // 
            this.ChartsButton_KKS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChartsButton_KKS.Location = new System.Drawing.Point(1256, 443);
            this.ChartsButton_KKS.Margin = new System.Windows.Forms.Padding(4);
            this.ChartsButton_KKS.Name = "ChartsButton_KKS";
            this.ChartsButton_KKS.Size = new System.Drawing.Size(213, 28);
            this.ChartsButton_KKS.TabIndex = 26;
            this.ChartsButton_KKS.Text = "Charts";
            this.ChartsButton_KKS.UseVisualStyleBackColor = true;
            this.ChartsButton_KKS.Click += new System.EventHandler(this.ChartsButton_KKS_Click);
            // 
            // FormMain_KKS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1480, 642);
            this.Controls.Add(this.ChartsButton_KKS);
            this.Controls.Add(this.MaxCostLabel_KKS);
            this.Controls.Add(this.MinCostLabel_KKS);
            this.Controls.Add(this.AVGCostLabel_KKS);
            this.Controls.Add(this.CountLabel_KKS);
            this.Controls.Add(this.MaxCostTextBox_KKS);
            this.Controls.Add(this.MinCostTextBox_KKS);
            this.Controls.Add(this.AVGCostTextBox_KKS);
            this.Controls.Add(this.CountTextBox_KKS);
            this.Controls.Add(this.RefreshButton_KKS);
            this.Controls.Add(this.MaxLabel_KKS);
            this.Controls.Add(this.MinLabel_KKS);
            this.Controls.Add(this.MaxTextBox_KKS);
            this.Controls.Add(this.MinTextBox_KKS);
            this.Controls.Add(this.FindButton_KKS);
            this.Controls.Add(this.FiltrationComboBox_KKS);
            this.Controls.Add(this.ClearButton_KKS);
            this.Controls.Add(this.FiltrationLabel_KKS);
            this.Controls.Add(this.ReadButton_KKS);
            this.Controls.Add(this.SaveButton_KKS);
            this.Controls.Add(this.ClientsButton_KKS);
            this.Controls.Add(this.OrdersButton_KKS);
            this.Controls.Add(this.SearchTextBox_KKS);
            this.Controls.Add(this.dataGridView_KKS);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain_KKS";
            this.Text = "Orders Flat Database";
            this.Load += new System.EventHandler(this.FormMain_KKS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_KKS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_KKS;
        private System.Windows.Forms.TextBox SearchTextBox_KKS;
        private System.Windows.Forms.Button OrdersButton_KKS;
        private System.Windows.Forms.Button ClientsButton_KKS;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button SaveButton_KKS;
        private System.Windows.Forms.Button ReadButton_KKS;
        private System.Windows.Forms.Label FiltrationLabel_KKS;
        private System.Windows.Forms.Button ClearButton_KKS;
        private System.Windows.Forms.ComboBox FiltrationComboBox_KKS;
        private System.Windows.Forms.Button FindButton_KKS;
        private System.Windows.Forms.TextBox MinTextBox_KKS;
        private System.Windows.Forms.TextBox MaxTextBox_KKS;
        private System.Windows.Forms.Label MinLabel_KKS;
        private System.Windows.Forms.Label MaxLabel_KKS;
        private System.Windows.Forms.Button RefreshButton_KKS;
        private System.Windows.Forms.TextBox CountTextBox_KKS;
        private System.Windows.Forms.TextBox AVGCostTextBox_KKS;
        private System.Windows.Forms.TextBox MinCostTextBox_KKS;
        private System.Windows.Forms.TextBox MaxCostTextBox_KKS;
        private System.Windows.Forms.Label CountLabel_KKS;
        private System.Windows.Forms.Label AVGCostLabel_KKS;
        private System.Windows.Forms.Label MinCostLabel_KKS;
        private System.Windows.Forms.Label MaxCostLabel_KKS;
        private System.Windows.Forms.Button ChartsButton_KKS;
    }
}

