namespace Suma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, suma; // Declaracion de las variables
          a=Convert.ToInt16(textBox1.Text); // Entrada del primer valor
            b=Convert.ToInt16(textBox2.Text); // Entrada del Segundo valor
            suma = a + b;// Proceso 

            textBox3.Text=Convert.ToString(suma);//Salida o resultado
        }
    }
}
