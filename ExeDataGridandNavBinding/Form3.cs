using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExeDataGridandNavBinding
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Form4 form4 = new Form4();
            this.Hide();
            form4.NIMmhs.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            form4.NamaMahasiswa.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            form4.AlamatMahasiswa.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            form4.JenisKelamin.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            form4.NoTelepon.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            form4.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }
    }
}
