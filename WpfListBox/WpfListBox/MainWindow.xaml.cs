using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfListBox.Data;

namespace WpfListBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Person> people = new List<Person>()
        {
            new Person{Name = "Panagiotis", Age = 25},
            new Person{Name = "Maria", Age = 45},
            new Person{Name = "Thanasis", Age = 54},
            new Person{Name = "Athanasia", Age = 22},
        };

        public MainWindow()
        {
            InitializeComponent();
            ListBoxPeople.ItemsSource = people;
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            var  selectedItems = ListBoxPeople.SelectedItems;
            foreach(var item in selectedItems)
            {
                var person = (Person)item;
                MessageBox.Show(person.Name);
            }
        }
    }
}