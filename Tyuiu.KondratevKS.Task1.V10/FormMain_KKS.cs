using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.KondratevKS.Task1.V10
{
    public partial class FormMain_KKS : Form
    {
        public DataTable orders = new DataTable("orders");
        public DataTable clients = new DataTable("clients");

        public FormMain_KKS()
        {
            DataColumn ID_cloumn_orders = new DataColumn("ID");
            ID_cloumn_orders.DataType = System.Type.GetType("System.Int32");
            DataColumn ID_cloumn_clients = new DataColumn("ID");
            ID_cloumn_orders.DataType = System.Type.GetType("System.Int32");
            orders.Columns.Add(ID_cloumn_orders);
            DataColumn OrderCost = new DataColumn("OrderCost");
            OrderCost.DataType = System.Type.GetType("System.Int32");
            orders.Columns.Add(OrderCost);
            orders.Columns.Add(new DataColumn("ProductName", typeof(string)));
            DataColumn ProductCount = new DataColumn("ProductCount");
            ProductCount.DataType = System.Type.GetType("System.Int32");
            orders.Columns.Add(ProductCount);
            orders.Columns.Add(new DataColumn("ExecutionDate", typeof(string)));
            clients.Columns.Add(ID_cloumn_clients);
            clients.Columns.Add(new DataColumn("FirstName", typeof(string)));
            clients.Columns.Add(new DataColumn("LastName", typeof(string)));
            clients.Columns.Add(new DataColumn("Address", typeof(string)));
            clients.Columns.Add(new DataColumn("Phone", typeof(string)));
            ID_cloumn_orders.Unique = true;
            ID_cloumn_orders.AllowDBNull = false;
            ID_cloumn_orders.AutoIncrement = true;
            ID_cloumn_orders.AutoIncrementSeed = 0;
            ID_cloumn_orders.AutoIncrementStep = 1;
            ID_cloumn_clients.Unique = true;
            ID_cloumn_clients.AllowDBNull = false;
            ID_cloumn_clients.AutoIncrement = true;
            ID_cloumn_clients.AutoIncrementSeed = 0;
            ID_cloumn_clients.AutoIncrementStep = 1;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

        }

      

      
        private void SaveToCsv(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (DataGridViewColumn column in dataGridView_KKS.Columns)
                {
                    writer.Write(column.HeaderText);
                    writer.Write(",");
                }
                writer.WriteLine();
                foreach (DataGridViewRow row in dataGridView_KKS.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        writer.Write(cell.Value?.ToString());
                        writer.Write(",");
                    }
                    writer.WriteLine();
                }
            }
        }

        
        private void LoadFromCsv(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string[] headers = reader.ReadLine().Split(',');
                if (headers[1] == "OrderCost")
                {
                    orders = new DataTable();
                    foreach (string header in headers)
                    {
                        orders.Columns.Add(header);
                    }
                    while (!reader.EndOfStream)
                    {
                        string[] fields = reader.ReadLine().Split(',');
                        DataRow row = orders.NewRow();
                        for (int i = 0; i < fields.Length; i++)
                        {
                            if (i == 1 || i == 3)
                            {
                                int value;
                                if (int.TryParse(fields[i], out value))
                                {
                                    row.SetField(i, value);
                                }
                            }
                            else
                            {
                                row.SetField(i, fields[i]);
                            }
                        }
                        orders.Rows.Add(row);
                    }
                    orders.Columns.Remove("Column1");

                    dataGridView_KKS.DataSource = orders;
                }
                else
                {
                    clients = new DataTable();
                    foreach (string header in headers)
                    {
                        clients.Columns.Add(header);
                    }
                    while (!reader.EndOfStream)
                    {
                        string[] fields = reader.ReadLine().Split(',');
                        DataRow row = clients.NewRow();
                        for (int i = 0; i < fields.Length; i++)
                        {
                            row.SetField(i, fields[i]);
                        }
                        clients.Rows.Add(row);
                    }
                    clients.Columns.Remove("Column1");

                    dataGridView_KKS.DataSource = clients;
                }
                
            }
        }

        private void FormMain_KKS_Load(object sender, EventArgs e)
        {
            SearchTextBox_KKS.Text = "Search...";
            SearchTextBox_KKS.ForeColor = Color.Gray;
            dataGridView_KKS.DataSource = orders;
        }

        private void dataGridView_KKS_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_KKS.DataSource == orders)
            {
                if (dataGridView_KKS.Rows.Count > 0)
                {
                    int sum = 0;
                    int maxValue = 0;
                    int minValue = 0;
                    int rowCount = 0;

                    foreach (DataGridViewRow row in dataGridView_KKS.Rows)
                    {
                        if (row.Cells["OrderCost"].Value != null && row.Cells["OrderCost"].Value != DBNull.Value)
                        {
                            sum += Convert.ToInt32(row.Cells["OrderCost"].Value);
                            rowCount++;
                        }
                    }

                    if (rowCount > 0)
                    {
                        maxValue = dataGridView_KKS.Rows.Cast<DataGridViewRow>()
                            .Where(row => row.Cells["OrderCost"].Value != null && row.Cells["OrderCost"].Value != DBNull.Value)
                            .Max(row => Convert.ToInt32(row.Cells["OrderCost"].Value));

                        minValue = dataGridView_KKS.Rows.Cast<DataGridViewRow>()
                            .Where(row => row.Cells["OrderCost"].Value != null && row.Cells["OrderCost"].Value != DBNull.Value)
                            .Min(row => Convert.ToInt32(row.Cells["OrderCost"].Value));

                        int avg = sum / rowCount;

                        CountTextBox_KKS.Text = rowCount.ToString();
                        AVGCostTextBox_KKS.Text = avg.ToString();
                        MinCostTextBox_KKS.Text = minValue.ToString();
                        MaxCostTextBox_KKS.Text = maxValue.ToString();
                    }
                    else
                    {
                        CountTextBox_KKS.Text = "0";
                        AVGCostTextBox_KKS.Text = "0";
                        MinCostTextBox_KKS.Text = "0";
                        MaxCostTextBox_KKS.Text = "0";
                    }
                }
            }
        }

        private void ClientsButton_KKS_Click(object sender, EventArgs e)
        {
            dataGridView_KKS.DataSource = clients;
        }

        private void OrdersButton_KKS_Click(object sender, EventArgs e)
        {
            dataGridView_KKS.DataSource = orders;
        }

        private void dataGridView_KKS_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchTextBox_KKS_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView_KKS.DataSource == orders)
            {
                orders.DefaultView.RowFilter = $"ProductName LIKE '%{SearchTextBox_KKS.Text}%' OR ProductName LIKE '%{SearchTextBox_KKS.Text}%'";
            }
            else if (dataGridView_KKS.DataSource == clients)
            {
                clients.DefaultView.RowFilter = $"FirstName LIKE '%{SearchTextBox_KKS.Text}%' OR LastName LIKE '%{SearchTextBox_KKS.Text}%'";
            }
        }

        private void SaveButton_KKS_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                SaveToCsv(filePath);
            }
        }

        private void ReadButton_KKS_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                LoadFromCsv(filePath);
            }
        }

        private void SearchTextBox_KKS_Enter(object sender, EventArgs e)
        {
            if (SearchTextBox_KKS.Text == "Search...")
            {
                SearchTextBox_KKS.Text = "";
                SearchTextBox_KKS.ForeColor = Color.Black;
            }
        }

        private void SearchTextBox_KKS_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SearchTextBox_KKS.Text))
            {
                SearchTextBox_KKS.Text = "Search...";
                SearchTextBox_KKS.ForeColor = Color.Gray;
            }
            if (dataGridView_KKS.DataSource == orders)
            {
                orders.DefaultView.RowFilter = "";
            }
            else if (dataGridView_KKS.DataSource == clients)
            {
                clients.DefaultView.RowFilter = "";
            }
        }

        private void ClearButton_KKS_Click(object sender, EventArgs e)
        {
            if (dataGridView_KKS.DataSource == orders)
            {
                orders.Rows.Clear();
            }
            else if (dataGridView_KKS.DataSource == clients)
            {
                clients.Rows.Clear();
            }
            CountTextBox_KKS.Text = "0";
            AVGCostTextBox_KKS.Text = "0";
            MinCostTextBox_KKS.Text = "0";
            MaxCostTextBox_KKS.Text = "0";
        }

        private void FindButton_KKS_Click(object sender, EventArgs e)
        {
            if (FiltrationComboBox_KKS.SelectedItem == null) return;

            string selectedColumn = FiltrationComboBox_KKS.SelectedItem.ToString();
            if (!int.TryParse(MinTextBox_KKS.Text, out int minValue) || !int.TryParse(MaxTextBox_KKS.Text, out int maxValue))
            {
                MessageBox.Show("Пожалуйста, введите корректные числовые значения.");
                return;
            }

            if (selectedColumn == "OrderCost")
            {
                orders.DefaultView.RowFilter = $"OrderCost >= {minValue} AND OrderCost <= {maxValue}";
            }
            else if (selectedColumn == "ProductCount")
            {
                orders.DefaultView.RowFilter = $"ProductCount >= {minValue} AND ProductCount <= {maxValue}";
            }
        }

        private void RefreshButton_KKS_Click(object sender, EventArgs e)
        {
            orders.DefaultView.RowFilter = "";
            MinTextBox_KKS.Text = "";
            MaxTextBox_KKS.Text = "";
        }

        private void ChartsButton_KKS_Click(object sender, EventArgs e)
        {
            FormCharts_KKS chartForm = new FormCharts_KKS();
            List<int> orderCosts = new List<int>();
            foreach (DataGridViewRow row in dataGridView_KKS.Rows)
            {
                if (row.Cells["OrderCost"].Value != DBNull.Value)
                {
                    int value = Convert.ToInt32(row.Cells["OrderCost"].Value);
                    orderCosts.Add(value);
                }
            }
            chartForm.SetData(orderCosts);
            chartForm.Show();
        }
    }
}
