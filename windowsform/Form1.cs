using windowsform.Models;
using windowsform.Models.Bases;

namespace windowsform
{
    public partial class Form1 : Form
    {
        IKoseliSekil _sekil;
        IDaireSekil _sekil2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            ddlSekil.Items.Add("Seciniz");
            ddlSekil.Items.Add("Dikdörtgen");
            ddlSekil.Items.Add("Dik Ucgen");
            ddlSekil.Items.Add("Daire");
            ddlSekil.SelectedIndex = 0;
            panel1.Visible = false;
            panel2.Visible = false;
            panel2.Size = new Size(242, 79);
            panel2.Location = new Point(12, 55);
        }

        private void bHesapla_Click(object sender, EventArgs e)
        {
            ValideEt();
            Hesapla();
        }

        private void Hesapla()
        {
            
            if (ddlSekil.SelectedIndex == 1)
            {
                rbAlan.Visible = true;
                rbCevre.Visible = true;
                _sekil = new Diktortgen();
                _sekil.Yukseklik = double.Parse(tbYukseklik.Text.Trim());
                _sekil.Genislik = double.Parse(tbGenislik.Text.Trim());
                if (rbAlan.Checked)
                    tbSonuc.Text = _sekil.AlanHesapla().ToString();
                else
                {
                    tbSonuc.Text = _sekil.CevreHesapla().ToString();
                }
            }
            else if (ddlSekil.SelectedIndex == 2)
            {
               
                _sekil = new Diktortgen()
                {
                    Genislik = double.Parse(tbGenislik.Text.Trim()),
                    Yukseklik = double.Parse(tbYukseklik.Text.Trim())
                };
                if (rbAlan.Checked)
                    tbSonuc.Text = _sekil.AlanHesapla().ToString();
                else
                    tbSonuc.Text = _sekil.CevreHesapla().ToString();
            }
            else if (ddlSekil.SelectedIndex == 3)
            {
                
                _sekil2 = new Daire()
                {
                    Yaricap = double.Parse(tbYaricap.Text.Trim()),
                    PiUcMu=cbPiucmu.Checked
                };
                tbSonuc.Text = rbAlan.Checked ? _sekil2.AlanHesapla().ToString() : _sekil2.CevreHesapla().ToString();
                
            }

        }

        private bool ValideEt()
        {
            if (ddlSekil.SelectedIndex == 0)
            {
                MessageBox.Show("Þekil seçiniz ", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return false;
            }
            if (ddlSekil.SelectedIndex == 1 || ddlSekil.SelectedIndex == 2)
            {
                if (string.IsNullOrWhiteSpace(tbGenislik.Text) || string.IsNullOrWhiteSpace(tbYukseklik.Text))
                {
                    MessageBox.Show("Þekil seçiniz ", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return false;
                }
                double genislik;
                if (!double.TryParse(tbGenislik.Text.Trim(), out genislik))
                {
                    MessageBox.Show("Genislik sayisal olmalýdýr. ", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return false;
                }
                double yukselik;
                if (!double.TryParse(tbYukseklik.Text.Trim(), out genislik))
                {
                    MessageBox.Show("yukseklik sayisal olmalýdýr. ", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return false;
                }
            }
            else
            {
                if (string.IsNullOrWhiteSpace(tbYaricap.Text))
                {
                    MessageBox.Show("yukseklik sayisal olmalýdýr. ", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                }
                double yariCap;
                if (!double.TryParse(tbYaricap.Text.Trim(), out yariCap))
                {
                    MessageBox.Show("yukseklik sayisal olmalýdýr. ", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return false;
                }
            }
            return true;
        }

        private void ddlSekil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlSekil.SelectedIndex == 0)
            {
                rbAlan.Visible = false;
                rbCevre.Visible = false;

            }
            panel1.Visible = false;
            panel2.Visible = false;
            if(ddlSekil.SelectedIndex==1 || ddlSekil.SelectedIndex == 2)
            {
                panel1.Visible = true;
                rbAlan.Visible = true;
                rbCevre.Visible = true;
            }
            else if (ddlSekil.SelectedIndex == 3)
            {
                panel2.Visible = true;
                rbAlan.Visible = true;
                rbCevre.Visible = true;
            }
        }

        private void rbAlan_CheckedChanged(object sender, EventArgs e)
        {
            

        }
    }
}