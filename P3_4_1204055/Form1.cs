using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3_4_1204055
{
    public partial class Form1 : Form
    {

        public Form1()
            {
                InitializeComponent();
            }

        private void btTampilan_Click(object sender, EventArgs e)
        {
            string kelas     = "";
            string jadwal    = "";

            if (rbSeninrabu.Checked)
            {
                jadwal = "Senin & Rabu, 14.00 - 16.00";
            }
            else if (rbSelasakamis.Checked)
            {
                jadwal = "Selasa & Kamis, 14.00 - 16.00";
            }
            else if (rbSabtuminggu.Checked)
            {
                jadwal = "Sabtu & Minggu, 09:00 - 11.00";
            }
            else if (rbMinggu.Checked)
            {
                jadwal = "Minggu, 13:00 - 17.00";
            }

            if (cbBiola.Checked)
            {
                kelas = kelas + "Biola, ";
            }
            if (drum.Checked)
            {
                kelas = kelas + "Drum, ";
            }
            if (cbGitar.Checked)
            {
                kelas = kelas + "Gitar, ";
            }
            if (cbKomposer.Checked)
            {
                kelas = kelas + "Komposer, ";
            }
            if (cbKonduktor.Checked)
            {
                kelas = kelas + "Konduktor, ";
            }
            if (cbPiano.Checked)
            {
                kelas = kelas + "Piano, ";
            }
            if (cbSaxophone.Checked)
            {
                kelas = kelas + "Saxophone, ";
            }
            if (cbVokal.Checked)
            {
                kelas = kelas + "Vokal, ";
            }
            if (kelas == "")
            {
                MessageBox.Show("Harus memilih salah satu dari pilihan kelas", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else { 
                     MessageBox.Show
                    ("Nama : " + tbNama.Text +
                    "\nJenis Kelamin    : " + cbJk.Text +
                    "\nTanggal Lahir    : " + dtTgl.Text +
                    "\nPilihan Kelas    : " + kelas +
                    "\nPilihan Jadwal   : " + jadwal,
                    "Informasi Pendaftaran",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }
    }
}
