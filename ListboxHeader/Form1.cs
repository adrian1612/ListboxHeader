using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListboxHeader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            addheader();
        }

        void addheader()
        {
            lboutput.Items.Clear();
            lboutput.Items.Add(string.Format(output,"First name","Middle name","Last name"));
        }

        string output = "{0, -35}\t{1, -35}\t{2, -35}";

        private void btninsert_Click(object sender, EventArgs e)
        {
            lboutput.Items.Add(string.Format(output, txtfname.Text, txtmn.Text, txtlname.Text));
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = null;
                }
            }
        }
    }
}
