using System.Diagnostics.Eventing.Reader;
using System.Linq.Expressions;

namespace findTheMonth
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void a_Click(object sender, EventArgs e)
        {

        }

        private void lblTikla_Click(object sender, EventArgs e)
        {
            try
            {
                int ayNo = Convert.ToInt32(textGir.Text);

                if (ayNo == 1)
                {
                    label1.Text = "Ocak";

                }
                else if (ayNo == 2)
                {
                    label1.Text = "Şubat";
                }
                else if (ayNo == 2)
                {
                    label1.Text = "Mart";
                }
                else if (ayNo == 3)
                {
                    label1.Text = "Nisan";
                }
                else if (ayNo == 4)
                {
                    label1.Text = "Mayıs";
                }
                else if (ayNo == 5)
                {
                    label1.Text = "Haziran";
                }
                else if (ayNo == 6)
                {
                    label1.Text = "Temmuz";
                }
                else if (ayNo == 7)
                {
                    label1.Text = "Ağustos";
                }
                else if (ayNo == 8)
                {
                    label1.Text = "Eylül";
                }
                else if (ayNo == 9)
                {
                    label1.Text = "Ekim";
                }
                else if (ayNo == 10)
                {
                    label1.Text = "Kasım";
                }
                else if (ayNo == 11)
                {
                    label1.Text = "Aralık";
                }

            }
            catch
            {
                MessageBox.Show("Sayi Giriniz");
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.Yellow;
            this.Name = "Find The Month";

        }
    }
}