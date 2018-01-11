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
using System.Configuration;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data.Odbc;

namespace AdoNetMoule1HW
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string conString = "";
        private string conOleDbString = "";
        private string conOdbcString = "";
        public MainWindow()
        {
            conString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            conOleDbString = ConfigurationManager.ConnectionStrings["OleDbConnection"].ConnectionString;
            conOdbcString = ConfigurationManager.ConnectionStrings["OdbcConnection"].ConnectionString;
            InitializeComponent();
        }

        private void SqlButton_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {


                con.Open();

                MessageSqlLabel.Content += "Подключение открыто\n";


                MessageSqlLabel.Content += "Свойство подключения\n";
                MessageSqlLabel.Content += "\t--> cтрока подключения\n" + con.ConnectionString + "\n";
                MessageSqlLabel.Content += "\t--> база данных\n" + con.Database + "\n";
                MessageSqlLabel.Content += "\t--> сервер\n" + con.ServerVersion + "\n";
                MessageSqlLabel.Content += "\t--> состояние\n" + con.State + "\n";
                MessageSqlLabel.Content += "\t--> рабочая станция\n" + con.WorkstationId + "\n";
                MessageSqlLabel.Content += "Подключение закрыто\n" + "\n";


            }

            //using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-BL837NF;Initial Catalog=Test;Integrated Security = True"))
            //{


            //    con.Open();                                                               //подключение с использованием строки в коде

            //    MessageSqlLabel.Content += "Подключение открыто\n";
                         
                         
            //    MessageSqlLabel.Content += "Свойство подключения\n";
            //    MessageSqlLabel.Content += "\t--> cтрока подключения\n" + con.ConnectionString + "\n";
            //    MessageSqlLabel.Content += "\t--> база данных\n" + con.Database + "\n";
            //    MessageSqlLabel.Content += "\t--> сервер\n" + con.ServerVersion + "\n";
            //    MessageSqlLabel.Content += "\t--> состояние\n" + con.State + "\n";
            //    MessageSqlLabel.Content += "\t--> рабочая станция\n" + con.WorkstationId + "\n";
            //    MessageSqlLabel.Content += "Подключение закрыто\n" + "\n";

            //}
        }

        private void OleDbButton_Click(object sender, RoutedEventArgs e)
        {
            using (OleDbConnection con = new OleDbConnection(conOleDbString))
            {


                con.Open();

                MessageOleDbLabel.Content += "Подключение открыто\n";


                MessageOleDbLabel.Content += "Свойство подключения\n";
                MessageOleDbLabel.Content += "\t--> cтрока подключения\n" + con.ConnectionString + "\n";
                MessageOleDbLabel.Content += "\t--> база данных\n" + con.Database + "\n";
                MessageOleDbLabel.Content += "\t--> сервер\n" + con.ServerVersion + "\n";
                MessageOleDbLabel.Content += "\t--> состояние\n" + con.State + "\n";

                MessageOleDbLabel.Content += "Подключение закрыто\n" + "\n";


            }

            //using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Test.mdb;User Id=admin;Password=;"))
            //{


            //    con.Open();

            //    MessageOleDbLabel.Content += "Подключение открыто\n";


            //    MessageOleDbLabel.Content += "Свойство подключения\n";
            //    MessageOleDbLabel.Content += "\t--> cтрока подключения\n" + con.ConnectionString + "\n";
            //    MessageOleDbLabel.Content += "\t--> база данных\n" + con.Database + "\n";
            //    MessageOleDbLabel.Content += "\t--> сервер\n" + con.ServerVersion + "\n";
            //    MessageOleDbLabel.Content += "\t--> состояние\n" + con.State + "\n";

            //    MessageOleDbLabel.Content += "Подключение закрыто\n" + "\n";


            //}
        }

        private void OdbcButton_Click(object sender, RoutedEventArgs e)
        {
            using (OdbcConnection con = new OdbcConnection(conOdbcString))
            {


                con.Open();

                MessageOdbcLabel.Content += "Подключение открыто\n";




                MessageOdbcLabel.Content += "Свойство подключения\n";
                MessageOdbcLabel.Content += "\t--> cтрока подключения\n" + con.ConnectionString + "\n";
                MessageOdbcLabel.Content += "\t--> база данных\n" + con.Database + "\n";
                MessageOdbcLabel.Content += "\t--> сервер\n" + con.ServerVersion + "\n";
                MessageOdbcLabel.Content += "\t--> состояние\n" + con.State + "\n";

                MessageOdbcLabel.Content += "Подключение закрыто\n" + "\n";


            }

            //using (OdbcConnection con = new OdbcConnection("Driver={Microsoft Access Driver (*.mdb)};DBQ=Test.mdb;UID=;PWD=;"))
            //{


            //    con.Open();

            //    MessageOdbcLabel.Content += "Подключение открыто\n";


            //    MessageOdbcLabel.Content += "Свойство подключения\n";
            //    MessageOdbcLabel.Content += "\t--> cтрока подключения\n" + con.ConnectionString + "\n";
            //    MessageOdbcLabel.Content += "\t--> база данных\n" + con.Database + "\n";
            //    MessageOdbcLabel.Content += "\t--> сервер\n" + con.ServerVersion + "\n";
            //    MessageOdbcLabel.Content += "\t--> состояние\n" + con.State + "\n";

            //    MessageOdbcLabel.Content += "Подключение закрыто\n" + "\n";


            //}

        }
    }
}
