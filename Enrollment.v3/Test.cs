using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrollment
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            String[][] data = new string[][]
            {
                new String[]{"1234", "Shit", "Dczxata"},
                new String[]{"1234", "Shit", "Dazcxta"},
                new String[]{"1234", "Shit", "Dazxcta"},
                new String[]{"1234", "Shit", "Dacta"},
                new String[]{"1234", "Shit", "zxcData"}
            };

            radGridView1.DataSource = GetDataTableFromArray(data);
        }

        public static DataTable GetDataTableFromArray(object[][] array)
        {
            DataTable dataTable = new DataTable();
            if (array.Length > 0)
            {
                for (int c = 0; c < array[0].Length; c++)
                {
                    dataTable.Columns.Add();
                }
            }
            foreach (object[] row in array)
            {
                DataRow dataRow = dataTable.NewRow();
                for (int i = 0; i < row.Length; i++)
                    dataRow[i] = row[i];
                dataTable.Rows.Add(dataRow);
            }
            return dataTable;
        }
    }
}
