using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ad_sem2_week6_tha_winsform_soalRoccaIdol
{
    public partial class Form1 : Form
    {
        DataTable dtProdukSimpan = new DataTable();
        DataTable dtProdukTampil = new DataTable();
        DataTable dtCategory = new DataTable();
        public List<string> list = new List<string>();
        string idCategory;
        string addIdCategory;
        int idCounter = 0;
        string idProdukAngka;
        DataGridViewRow currentRow2 = null;
        DataGridViewRow currentRow3 = null;

        public Form1()
        {
            InitializeComponent();
            dtProdukTampil.Columns.Add("ID Produk");
            dtProdukTampil.Columns.Add("Nama Produk");
            dtProdukTampil.Columns.Add("Harga");
            dtProdukTampil.Columns.Add("Stok");
            dtProdukTampil.Columns.Add("ID Kategori");
            dtProdukTampil.Rows.Add("J001", "Jas Hitam", "100000", "10", "C1");
            dtProdukTampil.Rows.Add("T001", "T-Shirt Black Pink", "70000", "20", "C2");
            dtProdukTampil.Rows.Add("T002", "T-Shirt Obsessive", "75000", "16", "C2");
            dtProdukTampil.Rows.Add("R002", "Rocca Shirt", "50000", "8", "C2");
            dtProdukTampil.Rows.Add("R001", "Rok Mini", "82000", "26", "C3");
            dtProdukTampil.Rows.Add("J002", "Jeans Biru", "90000", "5", "C4");
            dtProdukTampil.Rows.Add("C001", "Celana Pendek Coklat", "60000", "11", "C4");
            dtProdukTampil.Rows.Add("C002", "Cawat Blink-blink", "1000000", "1", "C5");
            
            dgvKiri.DataSource = dtProdukTampil;

            dtCategory.Columns.Add("ID Kategori");
            dtCategory.Columns.Add("Nama kategori");
            dgvKanan.DataSource = dtCategory;

            dtCategory.Rows.Add("C1", "Jas");
            dtCategory.Rows.Add("C2", "T-Shirt");
            dtCategory.Rows.Add("C3", "Rok");
            dtCategory.Rows.Add("C4", "Celana");
            dtCategory.Rows.Add("C5", "Cawat");
            dgvKanan.DataSource = dtCategory;

            dtProdukSimpan.Columns.Add("ID Produk");
            dtProdukSimpan.Columns.Add("Nama Produk");
            dtProdukSimpan.Columns.Add("Harga");
            dtProdukSimpan.Columns.Add("Stok");
            dtProdukSimpan.Columns.Add("ID Kategori");
            comboBoxFilter.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < dtCategory.Rows.Count; i++)
            {
                comboBoxKategori.Items.Add(dtCategory.Rows[i][1]);
            }
            //    dtProdukSimpan.Columns.Add("ID Produk");
            //    dtProdukSimpan.Columns.Add("Nama Produk");
            //    dtProdukSimpan.Columns.Add("Harga");
            //    dtProdukSimpan.Columns.Add("Stok");
            //    dtProdukSimpan.Columns.Add("ID Kategori");
            //    dgvKiri.DataSource = dtProdukSimpan;

            //    dtCategory.Columns.Add("ID Kategori");
            //    dtCategory.Columns.Add("Nama kategori");
            //    dgvKanan.DataSource = dtCategory;
            //string myString = 015.ToString("D1");
            //textBoxNamaKiri.Text = myString;
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            if (textBoxNamaKiri.Text != "" && comboBoxKategori.Text != "" && textBoxHarga.Text != "" && textBoxStok.Text != "")
            {
                //if (dgvKiri.SelectedRows.Count > 0)
                //{
                //    DataGridViewRow currentRow = dgvKiri.SelectedRows[0];
                //    textBoxNamaKiri.Text = currentRow.Cells[1].ToString();
                //}
                string idProdukHuruf = textBoxNamaKiri.Text.Substring(0, 1).ToUpper();
                //string myString = 3.ToString("D3");
                for (int i = 0; i < dtCategory.Rows.Count; i++)
                {
                    if (dtCategory.Rows[i][1].ToString() == comboBoxKategori.Text)
                    {
                        addIdCategory = dtCategory.Rows[i][0].ToString();
                    }

                }

                for (int i = 0; i < dtProdukTampil.Rows.Count; i++)
                {
                    if (idProdukHuruf == dtProdukTampil.Rows[i][0].ToString().Substring(0, 1))
                    {
                        string helper = dtProdukTampil.Rows[i][0].ToString().Substring(1, 3);
                        int intHelper = Convert.ToInt32(helper);
                        //string helper2 = Convert.ToInt32(helper).ToString();
                        if (intHelper > idCounter)
                        {
                            idCounter = intHelper;
                        }
                    }
                }

                string idProdukAngka = (idCounter+1).ToString("D3");
                dtProdukTampil.Rows.Add(idProdukHuruf + idProdukAngka, textBoxNamaKiri.Text, textBoxHarga.Text, textBoxStok.Text, addIdCategory);
                dgvKiri.DataSource = null;
                dgvKiri.DataSource = dtProdukTampil;
            }
            else
            {
                MessageBox.Show("Silahkan diisi dengan lengkap", "Error Message");
            }
            idCounter = 0;
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            comboBoxFilter.Enabled = true;
            comboBoxFilter.Items.Clear();
            for (int i = 0; i < dtCategory.Rows.Count; i++)
            {
                comboBoxFilter.Items.Add(dtCategory.Rows[i][1]);
            }
            
            
            
        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            textBoxNamaKiri.Text = "";
            comboBoxKategori.Text = ";";
            textBoxHarga.Text = "";
            textBoxStok.Text = "";
            comboBoxFilter.Enabled = false;
            dgvKiri.DataSource = dtProdukTampil;
        }

        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxNamaKiri.Text = "";
            comboBoxKategori.Text = "";
            textBoxHarga.Text = "";
            textBoxStok.Text = "";
            dgvKiri.DataSource = null;
            //if (dtProdukSimpan.Rows.Count > 0)
            //{
            //    for (int i = 0; i <= dtProdukSimpan.Rows.Count; i++)
            //    {
            //        dtProdukSimpan.Rows.RemoveAt(0);
            //    }
            //}
            dtProdukSimpan.Rows.Clear();

            for (int i = 0; i < dtCategory.Rows.Count; i++)
            {
                if (comboBoxFilter.Text == dtCategory.Rows[i][1].ToString())
                {
                    idCategory = dtCategory.Rows[i][0].ToString();
                }
            }

            for (int i = 0; i < dtProdukTampil.Rows.Count; i++)
            {
                if (dtProdukTampil.Rows[i][4].ToString() == idCategory)
                {
                    dtProdukSimpan.Rows.Add(dtProdukTampil.Rows[i][0], dtProdukTampil.Rows[i][1], dtProdukTampil.Rows[i][2], dtProdukTampil.Rows[i][3], dtProdukTampil.Rows[i][4]);
                }
            }

            dgvKiri.DataSource = dtProdukSimpan;

           
            //foreach (DataGridViewRow row in dgvKiri.Rows)
            //{
            //    dgvKiri.Rows.Remove(row);
            //}

            //for (int i = 0; i < dtProdukTampil.Rows.Count; i++)
            //{
            //    if (dtProdukTampil.Rows[i][4].ToString() == idCategory)
            //    {
            //        dtProdukSimpan.Rows.Add(dtProdukTampil.Rows[i]);       
            //    }
            //}

            //dgvKiri.DataSource = dtProdukSimpan;
        }

        private void dgvKiri_SelectionChanged(object sender, EventArgs e)
        {
            if (currentRow2 != null)
            {
                if (dgvKiri.SelectedRows.Count > 0)
                {
                    textBoxNamaKiri.Text = currentRow2.Cells[1].Value.ToString();
                    comboBoxKategori.Text = dtCategory.Rows[1][1].ToString();
                    textBoxHarga.Text = currentRow2.Cells[2].Value.ToString();
                    textBoxStok.Text = currentRow2.Cells[3].Value.ToString();

                    for (int i = 0; i < dtCategory.Rows.Count; i++)
                    {
                        if (currentRow2.Cells[4].Value.ToString() == dtCategory.Rows[i][0].ToString())
                        {
                            comboBoxKategori.Text = dtCategory.Rows[i][1].ToString();
                        }
                    }
                    currentRow2 = null;
                }
                
            }
            
        }

        private void textBoxNamaKiri_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonEditProduct_Click(object sender, EventArgs e)
        {
            if (textBoxNamaKiri.Text != "" && comboBoxKategori.Text != "" && textBoxHarga.Text != "" && textBoxStok.Text != "")
            {
                if (Convert.ToInt32(textBoxStok.Text) <= 0)
                {
                    DataGridViewRow currentRow = dgvKiri.SelectedRows[0];
                    string idDgvKiri = currentRow.Cells[0].Value.ToString();
                    for (int i = 0; i < dtProdukTampil.Rows.Count; i++)
                    {
                        if (idDgvKiri == dtProdukTampil.Rows[i][0].ToString())
                        {
                            dtProdukTampil.Rows.Remove(dtProdukTampil.Rows[i]);
                        }
                    }                 
                }
                else
                {
                    DataGridViewRow currentRow = dgvKiri.SelectedRows[0];
                    string abc = currentRow.Cells[0].Value.ToString();
                    for (int i = 0; i < dtCategory.Rows.Count; i++)
                    {
                        if (comboBoxKategori.Text == dtCategory.Rows[i][1].ToString())
                        {
                            idCategory = dtCategory.Rows[i][0].ToString();
                        }
                    }
                    for (int i = 0; i < dtProdukTampil.Rows.Count; i++)
                    {
                        if (abc == dtProdukTampil.Rows[i][0].ToString())
                        {
                            dtProdukTampil.Rows[i][1] = textBoxNamaKiri.Text;
                            dtProdukTampil.Rows[i][2] = textBoxHarga.Text;
                            dtProdukTampil.Rows[i][3] = textBoxStok.Text;
                            dtProdukTampil.Rows[i][4] = idCategory;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Silahkan diisi dengan lengkap", "Error Message");
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (currentRow2 != null)
            {
                string idDgvKiri = currentRow2.Cells[0].Value.ToString();
                for (int i = 0; i < dtProdukTampil.Rows.Count; i++)
                {
                    if (idDgvKiri == dtProdukTampil.Rows[i][0].ToString())
                    {
                        dtProdukTampil.Rows.Remove(dtProdukTampil.Rows[i]);
                    }

                }
                currentRow2 = null;
            }
        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            int abc = dtCategory.Rows.Count - 1;
            string stringABC = dtCategory.Rows[abc][0].ToString();
            int intABC = Convert.ToInt32(stringABC.Substring(1, 1));
            intABC++;
            dtCategory.Rows.Add("C" + Convert.ToString(intABC), textBoxNamaKanan.Text);
            comboBoxFilter.Items.Clear();
            comboBoxKategori.Items.Clear();
            for (int i = 0; i < dtCategory.Rows.Count; i++)
            {
                comboBoxFilter.Items.Add(dtCategory.Rows[i][1]);
            }
            for (int i = 0; i < dtCategory.Rows.Count; i++)
            {
                comboBoxKategori.Items.Add(dtCategory.Rows[i][1]);
            }

            //comboBoxKategori.DataSource = dtCategory;
            //comboBoxKategori.DisplayMember = "Nama kategori";

        }

        private void buttonRemoveCategory_Click(object sender, EventArgs e)
        {
            if (currentRow3 != null)
            {
                //dtCategory.Rows.Remove(dtCategory.Rows[i]);
                string idCategoryDgvKanan = currentRow3.Cells[0].Value.ToString();

                for (int i = dtCategory.Rows.Count - 1; i >= 0; i--)
                {
                    if (idCategoryDgvKanan == dtCategory.Rows[i][0].ToString())
                    {
                        dtCategory.Rows.Remove(dtCategory.Rows[i]);
                    }
                }

                for (int i = dtProdukTampil.Rows.Count - 1; i >= 0; i--)
                {
                    if (idCategoryDgvKanan == dtProdukTampil.Rows[i][4].ToString())
                    {
                        dtProdukTampil.Rows.Remove(dtProdukTampil.Rows[i]);
                  
                    }
                    currentRow3 = null;
                }

                comboBoxFilter.Items.Clear();
                comboBoxKategori.Items.Clear();
                for (int i = 0; i < dtCategory.Rows.Count; i++)
                {
                    comboBoxFilter.Items.Add(dtCategory.Rows[i][1]);
                }
                for (int i = 0; i < dtCategory.Rows.Count; i++)
                {
                    comboBoxKategori.Items.Add(dtCategory.Rows[i][1]);
                }
                //comboBoxKategori.DataSource = dtCategory;
                //comboBoxKategori.DisplayMember = "Nama kategori";
                //comboBoxFilter.DataSource = dtCategory;
                //comboBoxFilter.DisplayMember = "Nama kategori";
                //ini bisa juga buat ngisi combobox
            }
        }

        private void textBoxHarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBoxStok_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBoxStok_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void dgvKiri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ////dgvKiri.SelectedRows = dgvKiri.SelectedRows[e.RowIndex];
            currentRow2 = dgvKiri.Rows[e.RowIndex];
            if (currentRow2 != null)
            {
            
                textBoxNamaKiri.Text = currentRow2.Cells[1].Value.ToString();
                //comboBoxKategori.Text = dtCategory.Rows[1][1].ToString();
                textBoxHarga.Text = currentRow2.Cells[2].Value.ToString();
                textBoxStok.Text = currentRow2.Cells[3].Value.ToString();

                for (int i = 0; i < dtCategory.Rows.Count; i++)
                {
                    if (currentRow2.Cells[4].Value.ToString() == dtCategory.Rows[i][0].ToString())
                    {
                        comboBoxKategori.Text = dtCategory.Rows[i][1].ToString();
                    }
                }
                currentRow2 = null;
               
            }
            currentRow2 = dgvKiri.Rows[e.RowIndex];
        }
        private void dgvKiri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvKanan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentRow3 = dgvKanan.Rows[e.RowIndex];
        }
    }
}
