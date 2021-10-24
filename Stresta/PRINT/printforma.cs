using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stresta.PRINT
{
    public partial class printforma : Form
    {
        public printforma()
        {
            InitializeComponent();
        }

        private void PRINT_Load(object sender, EventArgs e)
        {
            label1.Text = Form1.passingtext;
            // TODO: This line of code loads data into the 'printim.inputdatas' table. You can move, or remove it, as needed.
            this.inputdatasTableAdapter.Fill(this.printim.inputdatas);
            try
            {
                this.inputdatasTableAdapter.FillBy(this.printim.inputdatas, ((long)(System.Convert.ChangeType(label1.Text, typeof(long)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            this.reportViewer1.RefreshReport();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
          

        }
    }
}
