using Database_task_BU3P.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Database_task_BU3P.Views
{
    /// <summary>
    /// Logika interakcji dla klasy UserControl2.xaml
    /// </summary>
    public partial class UserControl2 : UserControl
    {
		ContentControl contentControl;
		public UserControl2(ContentControl contentControl)
        {
            this.contentControl = contentControl;
            InitializeComponent();
			DataGridView();
        }
		SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\database.mdf;Integrated Security=True;Connect Timeout=30");
		private void GoToReg(object sender, RoutedEventArgs e) { contentControl.Content = new UserControl1(contentControl); }
		private void GoToCat(object sender, RoutedEventArgs e) { contentControl.Content = new UserControl3(contentControl); }

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			try {
				if (!string.IsNullOrEmpty(FnameForm.Text) && !string.IsNullOrEmpty(LnameForm.Text))
				{
					con.Open();
					SqlCommand cmd = con.CreateCommand();
					cmd.CommandText = $"INSERT INTO Technik (Imie, Nazwisko) VALUES('{FnameForm.Text}', '{LnameForm.Text}')";
					cmd.ExecuteNonQuery();
					con.Close();
					FnameForm.Text = "";
					LnameForm.Text = "";
					DataGridView();
				}
			}
			catch (Exception ex) { MessageBox.Show("Some Problems appearse we are sorry" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error); }
		}
			private void DataGridView()
        {
			con.Open();
			SqlCommand cmd = con.CreateCommand();
			cmd.CommandText = $"SELECT * FROM Technik";
			cmd.ExecuteNonQuery();
			IList<Technic> tech = new List<Technic>();
			SqlDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				tech.Add(new Technic { ID = reader.GetInt32("Id"), Name = reader.GetString("Imie") + " " + reader.GetString("Nazwisko") } );
			}
			con.Close();
			dgTechnicy.ItemsSource = tech;
		}
		private void Delete(object sender, RoutedEventArgs e)
		{
			try
			{
				Technic row = (Technic)((Button)e.Source).DataContext;
				int id = row.ID;
				con.Open();
				SqlCommand cmd = con.CreateCommand();
				cmd.CommandText = $"DELETE FROM Technik WHERE Id = {id}";
				cmd.ExecuteNonQuery();
				con.Close();
				DataGridView();
			}
			catch (Exception ex) { MessageBox.Show("Some Problems appearse we are sorry" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error); }
		}
	}
}
