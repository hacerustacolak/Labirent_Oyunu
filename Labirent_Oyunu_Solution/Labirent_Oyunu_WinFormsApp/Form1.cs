namespace Labirent_Oyunu_WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Mouse, labirent çizgilerine değdiği anda bu uyarı verilecektir.
        private void label1_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Duvara Dokundunuz!!");
        } 
        //Mouse, labirent çizgilerine değmeden yeşil kutuya ulaştığı anda bu uyarı verilecektir. 
        private void label20_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Tebrikler, Kazandınız!!");
        }
       
    }
}
//Başarılar :)