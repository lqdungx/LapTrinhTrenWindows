using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapTuan3
{
    public partial class From1 : Form
    {
        public From1()
        {
            InitializeComponent();
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            string last = txtLast.Text;
            string first = txtFirst.Text;
            string phone = txtPhone.Text;

            ListViewItem item = new ListViewItem(last);
            item.SubItems.Add(first);
            item.SubItems.Add(phone);

            listView1.Items.Add(item);

            txtLast.Clear();
            txtFirst.Clear();
            txtPhone.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];

                txtLast.Text = item.SubItems[0].Text;
                txtFirst.Text = item.SubItems[1].Text;
                txtPhone.Text = item.SubItems[2].Text;
            }
        }

        private void lbl2_Click(object sender, EventArgs e)
        {

        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }
    }
}
