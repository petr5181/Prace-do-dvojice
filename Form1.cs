namespace Prace_do_dvojice_6_10_2025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Ahoj svìte!");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double vysledek = 0;
            string input = textBox1.Text;
            List<object> mixed = new List<object>();

            string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            
            foreach (object part in parts) 
            {
                if (part is int i)
                {
                    mixed.Add(i);
                }
                else if (part is string s)
                {
                    mixed.Add(s);
                }
            }

            int a = int.Parse(parts[0]);
            int b = int.Parse(parts[2]);

            switch (parts[1])
            {
                case "+":
                    vysledek = a + b;
                    label3.Text = "vysledek" + vysledek;
                    break;
                case "-":
                    vysledek = a - b;
                    label3.Text = "vysledek" + vysledek;
                    break;
                case "/":
                    vysledek = a / b;
                    label3.Text = "vysledek" + vysledek;
                    break;
                case "*":
                    vysledek = a * b;
                    label3.Text = "vysledek" + vysledek;
                    break;
            }
            label3.Text += vysledek.ToString(); 

            int index = input.IndexOf("(");

        }
    }
}
