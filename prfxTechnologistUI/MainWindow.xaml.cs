using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
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

namespace prfxTechnologistUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Loading production orders to main window
            loadlist();
        }

        #region Showing productionOrder id info
        private void loadlist()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString =
                "Data Source = MW;" +
                "Initial Catalog = prfxProdactionOrders;" +
                "Integrated Security=SSPI;";
            connection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select ProductionOrder_id from [ProductionOrders]";
            cmd.Connection = connection;
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "ProductionOrders");
            ProductionOrderListBox.DataContext = ds;

        }
        #endregion

        public void ProductionOrders_Click(object sender, RoutedEventArgs e)
        {

        }

        public void SteelOrders_Click(object sender, RoutedEventArgs e)
        {

        }

        public void Warehouse_Click(object sender, RoutedEventArgs e)
        {

        }

        public void ExitProgram_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        public void AddProductionOrder_Click(object sender, RoutedEventArgs e)
        {

        }

        public void DeleteProductionOrder_Click(object sender, RoutedEventArgs e)
        {

        }

        public void ModifyProductionOrder_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
