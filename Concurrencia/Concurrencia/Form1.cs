namespace Concurrencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;

            //Thread.Sleep(5000);
            await Task.Delay(5000);
            MessageBox.Show("Hola mundo");
            pictureBox1.Visible = false;

        }
    }
}