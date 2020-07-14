using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void memoTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.memoTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202031DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'infosys202031DataSet.memoTable' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            //this.memoTableTableAdapter.Fill(this.infosys202031DataSet.memoTable);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.memoTableTableAdapter.Fill(this.infosys202031DataSet.memoTable);
        }
    }
}
