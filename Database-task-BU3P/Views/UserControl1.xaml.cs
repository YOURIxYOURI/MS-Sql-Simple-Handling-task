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
    /// Logika interakcji dla klasy UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
		ContentControl contentControl;

		public UserControl1(ContentControl contentControl)
        {
			this.contentControl = contentControl;
            InitializeComponent();
			OnLoad();
			DataGridView();
		}
		SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\database.mdf;Integrated Security=True;Connect Timeout=30");

		//private void OnChecked(object sender, RoutedEventArgs e)
		//{
		//	Registration row = (Registration)((CheckBox)e.Source).DataContext;
		//	int id = row.Id;
		//	con.Open();
		//	SqlCommand cmd = con.CreateCommand();
		//	cmd.CommandText = $"UPDATE Zgloszenie SET Czy_wykonane = 1 WHERE Id ={id}";
		//	cmd.ExecuteNonQuery();
		//	con.Close();
		//	DataGridView();
		//}
		private void Button_Click(object sender, RoutedEventArgs e)
		{
			if (!string.IsNullOrEmpty(DescriptionForm.Text) && !string.IsNullOrEmpty(UserForm.Text) && TechnicianList.SelectedValue != null && CategoryList.SelectedValue != null)
			{
				try
				{
					con.Open();
					SqlCommand cmd = con.CreateCommand();
					cmd.CommandText = $"INSERT INTO Zgloszenie (Opis, Przypisanie, Czy_wykonane, Kategoria, uzytkownik, Data) VALUES ('{DescriptionForm.Text}',{TechnicianList.SelectedValue},0,{CategoryList.SelectedValue},'{UserForm.Text}','{DateTime.Now}')";
					cmd.ExecuteNonQuery();
					con.Close();
					UserForm.Text = "";
					DescriptionForm.Text = "";
					TechnicianList.SelectedValue = null;
					CategoryList.SelectedValue = null;
					DataGridView();
				}catch (Exception ex) { MessageBox.Show("Some Problems appearse we are sorry" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error); }
			}

		}
		private void Delete(object sender, RoutedEventArgs e)
		{
			try
			{
				Registration row = (Registration)((Button)e.Source).DataContext;
				int id = row.Id;
				con.Open();
				SqlCommand cmd = con.CreateCommand();
				cmd.CommandText = $"DELETE FROM Zgloszenie WHERE Id = {id}";
				cmd.ExecuteNonQuery();
				con.Close();
				DataGridView();
			}catch(Exception ex) { MessageBox.Show("Some Problems appearse we are sorry" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error); }
		}

		private void OnLoad()
		{
			con.Open();
			SqlCommand cmd = con.CreateCommand();
			cmd.CommandText = $"SELECT * FROM Technik";
			cmd.ExecuteNonQuery();
			IList<Technic> technics = new List<Technic>();
			SqlDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				technics.Add(new Technic() { ID = reader.GetInt32("Id"), Name = reader.GetString("Imie") + " " + reader.GetString("Nazwisko") });
			}
			reader.Close();
			cmd.CommandText = $"SELECT * FROM Kategoria";
			cmd.ExecuteNonQuery();
			IList<Category> Categories = new List<Category>();
			reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				Categories.Add(new Category() { ID = reader.GetInt32("Id"), Name = reader.GetString("NazwaKategori"), Description = reader.GetString("Opis") });
			}
			reader.Close();
			con.Close();
			TechnicianList.ItemsSource = technics;
			TechnicianList.DisplayMemberPath = "Name";
			TechnicianList.SelectedValuePath = "ID";
			CategoryList.ItemsSource = Categories;
			CategoryList.DisplayMemberPath = "Name";
			CategoryList.SelectedValuePath = "ID";
		}
		private void DataGridView()
		{
			con.Open();
			SqlCommand cmd = con.CreateCommand();
			cmd.CommandText = $"SELECT Zgloszenie.* , Kategoria.*, Technik.* FROM Zgloszenie JOIN Technik ON (Technik.Id = Zgloszenie.Przypisanie) JOIN Kategoria ON (Kategoria.Id = Zgloszenie.Kategoria)";
			cmd.ExecuteNonQuery();
			IList<Registration> reg = new List<Registration>();
			SqlDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				bool check = false;
				if (reader.GetByte("Czy_wykonane") == 1) { check = true; }
				reg.Add(new Registration { Id = reader.GetInt32("Id"), User = reader.GetString("uzytkownik"), Description = reader.GetString("Opis"), IsDone = check, Date = reader.GetString("Data"), Technician = reader.GetString("Imie") + " " + reader.GetString("Nazwisko"), Category = reader.GetString("NazwaKategori") });
			}
			con.Close();
			dgZgloszenia.ItemsSource = reg;
		}
		private void GoToTech(object sender, RoutedEventArgs e) { contentControl.Content = new UserControl2(contentControl); }
		private void GoToCat(object sender, RoutedEventArgs e) { contentControl.Content = new UserControl3(contentControl); }
}}

