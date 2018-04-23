using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace HowToDisplayMDXQueryResults {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        void button1_Click(object sender, EventArgs e) {
            string connectionString = "Provider=msolap;Initial Catalog=Adventure Works DW Standard Edition;Data Source=local\\sql2005",
                query = @"select
non empty 
{ [Measures].[Internet Sales Amount] } on columns,
non empty 
{ [Sales Territory].[Sales Territory Group].[Sales Territory Group].members } *
{ [Sales Territory].[Sales Territory Country].[Sales Territory Country].members } on rows
from [Adventure Works]";
            using(OleDbConnection connection = new OleDbConnection(connectionString)) {
                connection.Open();
                using(OleDbCommand command = connection.CreateCommand()) {
                    command.CommandText = query;
                    pivotGridControl1.DataSource = ReadQueryResult(command);
                }
            }
        }
        protected DataTable ReadQueryResult(OleDbCommand command) {
            DataTable table = new DataTable();
            using(OleDbDataReader reader = command.ExecuteReader()) {
                for(int i = 0; i < reader.FieldCount; i++)
                    table.Columns.Add(reader.GetName(i), reader.GetFieldType(i));
                object[] values = new object[reader.FieldCount];
                while(reader.Read()) {
                    reader.GetValues(values);
                    table.Rows.Add(values);
                }
            }
            return table;
        }
    }
}