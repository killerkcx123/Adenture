using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView2
{
    public partial class Form1 : Form
    {
        List<String> ds = new List<String>();
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_ThemvaoDS_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            item.Text = cbo_TenMH.Text;
            item.SubItems.Add(txt_Sotinchi.Text);
            item.SubItems.Add(txt_Diem.Text);
            if (item.Text.Equals("") || txt_Sotinchi.Text.Equals("") || txt_Diem.Equals(""))
            {
                MessageBox.Show("Hãy nhập đủ thông tin");
            }
            else
            {
                if (ds.Contains(item.Text))
                {
                    MessageBox.Show("Đã thêm môn học này");
                }
                else
                {
                    listView1.Items.Add(item);
                    ds.Add(item.Text);
                }
            }
        }

        private void txt_Sotinchi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Sotinchi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || Convert.ToInt16(e.KeyChar) == 8)
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_Diem_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Diem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || Convert.ToInt16(e.KeyChar) == 8 || e.KeyChar == '.')
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void btn_Tinh_Click(object sender, EventArgs e)
        {
            float TongDiem = 0;
            int TongTC = 0;
            float Tong = 0;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                //TongDiem += float.Parse(listView1.Items[i].SubItems[2].Text);
                TongTC += int.Parse(listView1.Items[i].SubItems[1].Text);
                Tong += int.Parse(listView1.Items[i].SubItems[1].Text) * float.Parse(listView1.Items[i].SubItems[2].Text);
            }
            txt_TongDiem.Text = Tong.ToString();
            txt_TongSoTC.Text = TongTC.ToString();
            txt_DiemTB.Text = (Tong/TongTC).ToString();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int i = listView1.SelectedItems[0].Index;
                listView1.Items[i].Text = cbo_TenMH.Text;
                listView1.Items[i].SubItems[1].Text = txt_Sotinchi.Text;
                listView1.Items[i].SubItems[2].Text = txt_Diem.Text;
            }
            ListViewItem item = new ListViewItem();

        }

        private void listView1_Click(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = new ListViewItem();
                item = listView1.SelectedItems[0];
                cbo_TenMH.Text = item.Text;
                txt_Diem.Text = item.SubItems[2].Text;
                txt_Sotinchi.Text = item.SubItems[1].Text;
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int i = listView1.SelectedIndices[0];
                    listView1.Items.RemoveAt(i);
                    ds.RemoveAt(i);
                }
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
