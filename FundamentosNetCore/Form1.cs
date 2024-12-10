namespace FundamentosNetCore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPulsar_Click(object sender, EventArgs e)
        {
            //Solo se escribe aqui
            this.txtNombre.Location = new Point(20,10);
            
            this.txtNombre.Text = "Soy un string";
            this.txtNombre.Width = 229;

            this.txtNombre.TextAlign = HorizontalAlignment.Center;

            this.btnPulsar.BackColor = Color.SlateBlue;
        }
    }
}
