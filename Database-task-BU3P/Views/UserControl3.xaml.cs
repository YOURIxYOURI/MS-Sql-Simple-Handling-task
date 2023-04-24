using Database_task_BU3P.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
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
using System.Data;

namespace Database_task_BU3P.Views
{
    /// <summary>
    /// Logika interakcji dla klasy UserControl3.xaml
    /// </summary>
    public partial class UserControl3 : UserControl
    {
		ContentControl contentControl;
		public UserControl3(ContentControl contentControl)
        {
            this.contentControl = contentControl;
            InitializeComponent();
			DataGridView();
		}
		SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\database.mdf;Integrated Security=True;Connect Timeout=30");

		private void GoToReg(object sender, RoutedEventArgs e) { contentControl.Content = new UserControl1(contentControl); }
		private void GoToTech(object sender, RoutedEventArgs e) { contentControl.Content = new UserControl2(contentControl); }
		private void Button_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				if (!string.IsNullOrEmpty(NameForm.Text) && !string.IsNullOrEmpty(DescriptionForm.Text))
				{
					con.Open();
					SqlCommand cmd = con.CreateCommand();
					cmd.CommandText = $"INSERT INTO Kategoria (NazwaKategori, Opis) VALUES('{NameForm.Text}', '{DescriptionForm.Text}')";
					cmd.ExecuteNonQuery();
					con.Close();
					NameForm.Text = "";
					DescriptionForm.Text = "";
					DataGridView();
				}
			}
			catch (Exception ex) { MessageBox.Show("Some Problems appearse we are sorry" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error); }
		}
		private void DataGridView()
		{
			con.Open();
			SqlCommand cmd = con.CreateCommand();
			cmd.CommandText = $"SELECT * FROM Kategoria";
			cmd.ExecuteNonQuery();
			IList<Category> cat = new List<Category>();
			SqlDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				cat.Add(new Category { ID = reader.GetInt32("Id"), Name = reader.GetString("NazwaKategori"), Description = reader.GetString("Opis")});
			}
			con.Close();
			dgKategorie.ItemsSource = cat;
		}
		private void Delete(object sender, RoutedEventArgs e)
		{
			try
			{
				Category row = (Category)((Button)e.Source).DataContext;
				int id = row.ID;
				con.Open();
				SqlCommand cmd = con.CreateCommand();
				cmd.CommandText = $"DELETE FROM Kategoria WHERE Id = {id}";
				cmd.ExecuteNonQuery();
				con.Close();
				DataGridView();
			}
			catch (Exception ex) { MessageBox.Show("Some Problems appearse we are sorry" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error); }
		}
	}
}
