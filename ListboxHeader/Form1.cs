using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ListboxHeader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            addheader();
            txtid.Text = Convert.ToString(nextID());
        }

        dbcontrol s = new dbcontrol();

        void addheader()
        {
            lboutput.Items.Clear();
            lboutput.Items.Add(string.Format(output,"ID","Username","Password", "First name", "Middle name", "Last name"));
            foreach (DataRow r in s.query("select * from tbluser").Rows)
            {
                lboutput.Items.Add(string.Format(output, r[0], r[1], r[2], r[3], r[4], r[5]));
            }
            if (s.checkError(true))
            {
                return;
            }
        }

        int nextID()
        {
            int id = 0;
            
            foreach (DataRow r in s.query("select count(*) from tbluser").Rows)
            {
                id = (int)r[0];
            }
            if (s.checkError(true))
            {
                return 0;
            }
            return id + 1;
        }

        string output = "{0, -10}\t{1, -22}\t{2, -22}\t{3, -22}\t{4, -22}\t{5, -22}";

        private void btninsert_Click(object sender, EventArgs e)
        {
            s.query("insert into tbluser ([user],pass,fname,mn,lname) values (@user,@pass,@fname,@mn,@lname)", new Dictionary<string, object> {
                 {"@user",txtuser.Text}, {"@pass",txtpass.Text}, {"@fname",txtfname.Text},
                 {"@mn",txtmn.Text}, {"@lname",txtlname.Text}});
            if (s.checkError(true))
            {
                return;
            }
            addheader();
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = null;
                }
            }
            txtid.Text = Convert.ToString(nextID());
        }
    }
}
