using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    [AddINotifyPropertyChangedInterface]
    public partial class MainWindow : Window
    {
        public string NameProp { get; set; }
        public string SurnameProp { get; set; }
        public string ImageProp { get; set; }
        //public List<PersonInformation> Collection { get; set; }
        public ObservableCollection<PersonInformation> Collection { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            Collection = new ObservableCollection<PersonInformation>();
           // Collection.Add(new PersonInformation() { Name = "q", Surname = "w" });
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //list  = new List<PersonInformation>();
            //ListBox1.Items.Add(FirstTextBox.Text);
            //ListBox1.Items.Add(SecondTextBox.Text);
            //List<object> s;
            Collection.Add(new PersonInformation() { Name = NameProp, Surname = SurnameProp,ImageURL = ImageProp});
        }

        //private void ListBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    //MessageBox.Show(ListBox1.SelectedIndex.ToString());
        //    //if(ListBox1.SelectedIndex > -1)
        //    //ListBox1.Items.RemoveAt(ListBox1.SelectedIndex);          
        //}
    }
}
