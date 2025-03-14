namespace Tarea_del_modulo_5
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

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, Multiplicar;// Declaracion de las variables
            a = Convert.ToInt16(textBox1.Text); // Entrada del primer valor
            b = Convert.ToInt16(textBox2.Text); // Entrada del Segundo valor
            Multiplicar = a * b;// Proceso 

            textBox3.Text = Convert.ToString(Multiplicar);//Salida o resultado
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

        }
    }
}
  
