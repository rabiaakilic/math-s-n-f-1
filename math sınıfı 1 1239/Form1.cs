using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace math_sınıfı_1_1239
{
    public partial class txtKok : Form
    {
        public txtKok()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double sayi = Convert .ToSingle(txtSayi.Text);//Sayisal olarak texti çevirdik

            //işlemler
            double sayiMutlak = Math.Abs(sayi);
            double sayıUs = Math.Pow(sayi, 2);//txt içindeki sayının karesi(2.kuvveti)
            double sayiKareKok = Math.Sqrt(sayi);
            double sayıYukariYuvarla = Math.Ceiling(sayi);
            //round , floor ,ceil
            double sayıYuvarla = Math.Round(sayi);
            double sayıAsagıYuvarla = Math.Floor(sayi);
           



            //sonuçları yazdır
            lblMutlak.Text = "sayının mutlak değerii :"+sayiMutlak.ToString();
            lblUst.Text =  "sayının kuvveti :" + sayıUs.ToString();
            lblKok.Text = "sayının kare kökü :" + sayiKareKok.ToString();
            lblYukariYuvarla.Text = "sayını yukarı yuvarla :" + sayıYukariYuvarla.ToString();
            lblYuvarla.Text = "sayı yuvarla :" + sayıYuvarla.ToString();
            lblAsagıYuvarla.Text = "sayı aşağı yuvarla : " + sayıAsagıYuvarla.ToString();
        }
    }
}
