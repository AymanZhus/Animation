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
using System.Windows.Media.Animation;
using System.Drawing;
using System.Windows.Interop;
using System.Windows.Threading;

namespace HappyNewA
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rnd = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string forecast = "";
            int res = rnd.Next(1, 4);
            switch (res)
            {
                case 1:
                    forecast = "В Новом году вас ждет любовь!";
                    break;
                case 2:
                    forecast = "В Новом году вы будете окружены любящими людьми!";
                    break;
                case 3:
                    forecast = "В Новом году вы найдете любимое хобби!";
                    break;
            }
            MessageBox.Show(forecast, "Что вас ждет в Новом Году?");
        }
    }
}