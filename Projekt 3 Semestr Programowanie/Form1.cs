namespace Projekt_3_Semestr_Programowanie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Okno_Logowania ol = new Okno_Logowania();
            ol.Show();
        }
    }
}
