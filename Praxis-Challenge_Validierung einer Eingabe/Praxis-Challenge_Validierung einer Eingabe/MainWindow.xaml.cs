using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Praxis_Challenge_Validierung_einer_Eingabe
{

	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}
		// Login Button Click Event
		private void LoginButton_Click(object sender, RoutedEventArgs e)
		{
			string email = emailTextBox.Text;
			string password = passwordBox.Password;

			
			if (email == "vmadmin@stud.gibb.ch" && password == "sml12345")
			{
				MessageBox.Show("Login successful!");
			}
			else
			{
				MessageBox.Show( "Login failed!");
			}	

		}
		private void ResetButton_Click(object sender, RoutedEventArgs e)
		{
			emailTextBox.Clear();
			passwordBox.Clear();
			statusTextBlock.Text = "";
		}
	}
}