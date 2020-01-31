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
using System.Security;
using Microsoft.Win32;

namespace Mailer
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string login, sever;
        private SecureString pass;
        private int PortSend = 587, PrrtSmtps = 465, PortTls = 587;
        private bool chk = false;
        private void EntryOn(object sender, RoutedEventArgs e)
        {
            Ent.Visibility = Visibility.Hidden;
            Sender.Visibility = Visibility.Visible;
            login = LoginUser.Text;
            pass = PassUser.SecurePassword;
            FromUs.Text = LoginUser.Text;
        }
        private void ExitProg(object sender, RoutedEventArgs e)
        {
            Sender.Visibility = Visibility.Hidden;
            Ent.Visibility = Visibility.Visible;
            LoginUser.Clear();
            PassUser.Clear();
        }
        private void SendMail(object sender, RoutedEventArgs e)
        {
            sever = "smtp.yandex.ru";
            if (PortChange.IsChecked == true)
            {
                chk = true;
                PortSend = PrrtSmtps;
            }
            
            SenderMail.Sender(sever, login, ToUs.Text, SubUs.Text, BodyUs.Text, PortSend/*, FilePath.ToString(), login*/, pass, chk );
        }
        private void OpenFile(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == true)
            {
                FilePath.Text = ofd.FileName;
            }
        }
        public MainWindow()
        {
            
            InitializeComponent();
        }
    }
}
