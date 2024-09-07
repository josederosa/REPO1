namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPopulate_Click(object sender, EventArgs e)
        {
            int i = default;
            foreach (var item in PotenciasDeV2(3))
            {
                listBox1.Items.Add(item.ToString());
                i++;
                if (i == 10) break;
            }

            //int i = default;
            //foreach (var item in MultiplosDe(3))
            //{
            //    listBox1.Items.Add(item.ToString());
            //    i++;
            //    if (i == 10) break;
            //}
            //i = default;
            //foreach (var item in PotenciasDe(2))
            //{
            //    listBox1.Items.Add(item.ToString());
            //    i++;
            //    if (i == 10) break;
            //}
        }


        IEnumerable<int> MultiplosDe(int valor)
        {
            for (int i=1;;i++)
            {
                yield return i * valor;
            }
        }
        IEnumerable<int> PotenciasDe(int valor)
        {
            for (int i = 1; ; i++)
            {
                yield return (int)Math.Pow(valor, i);
            }
        }

        IEnumerable<int> PotenciasDeV2(int valor)
        {
            int i = 0;
            for (; ;)
            {
                yield return (int)Math.Pow(valor, i);
                i++;
            }
        }

    }
}
