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
using DataSetPractica1.MAGAZINEDataSetTableAdapters;
namespace DataSetPractica1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        ExpensesTableAdapter expenses = new ExpensesTableAdapter();
        public MainWindow()
        {
           
            InitializeComponent();
            ExpensesDataGrid.ItemsSource = expenses.GetData();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            MainWindow OneWindow = new MainWindow();
            OneWindow.Show();
            Close();
        }

        private void button3_Click_1(object sender, RoutedEventArgs e)
        {
           Window1 window = new Window1();
            window.Show();
            Close();
        }
    }
}
