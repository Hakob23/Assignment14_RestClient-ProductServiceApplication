using DAL;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Xml.Serialization;

namespace Assignment14_RestClient
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GO_Click(object sender, RoutedEventArgs e)
        {
            RestClient client = new RestClient();

            Response.Text = client.MakeResponse(RequestType.Text, Request1.Text);
        }

        private void Deserializer_Click(object sender, RoutedEventArgs e)
        {
            RestClient client = new RestClient();

            client.MakeResponse(RequestType.Text, Request1.Text);

            using (Stream responseStream = client.Response.GetResponseStream())
            {
                using(StreamReader reader = new StreamReader(responseStream))
                {

                    client.Response.GetResponseStream();

                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Product>));

                    

                    xmlSerializer.Deserialize(reader);
                }
            }


                
            

        }
    }
}
