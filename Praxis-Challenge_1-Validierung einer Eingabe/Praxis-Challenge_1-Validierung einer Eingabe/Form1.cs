namespace Praxis_Challenge_1_Validierung_einer_Eingabe
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (txtEmail.Text == "yke144907@stud.gibb.ch" && txtPass.Text == "sml12345")
			{
				MessageBox.Show("Login erfolgreich");
			}
			else
			{
				MessageBox.Show("Login fehlgeschlagen");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
		
		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			txtEmail.Text = "";
			txtPass.Text = "";
		}
	}
}
