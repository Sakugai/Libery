using Libery.AppData;
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
using System.Windows.Shapes;

namespace Libery.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Authors _selectedAuthors;

        private Books _selectedBooks;

        private List<Authors> authors = new List<Authors>()
        {
            new Authors("Александр Сергеевич Пушкин", new DateTime(1799,6,6), new DateTime(1837,2,10), 0, "Москва", false, new List<Books> {new Books("Руслан и Людмила", new DateTime(1820, 6, 6), 400), 
                                                                                                                                                       new Books("Капитанская дочка", new DateTime(1836, 6, 6), 278),
                                                                                                                                                       new Books("Цыганы", new DateTime(1827, 6, 6), 327) }),

            new Authors("Иван Сергеевич Тургенев", new DateTime(1818,10,22), new DateTime(1883,10,3), 0, "Орёл", false, new List<Books> {new Books("Жид", new DateTime(1844, 6, 6), 367),
                                                                                                                                                       new Books("Муму", new DateTime(1852, 6, 6), 137),
                                                                                                                                                       new Books("Мой сосед Радилов", new DateTime(1847, 6, 6), 327) })

        };

        public MainWindow()
        {
            InitializeComponent();

            foreach(Authors author in authors)
            {
                author.GetAge();
                AuthorsLb.Items.Add(author);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           
        }

        private void AuthorsLb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _selectedAuthors = AuthorsLb.SelectedItem as Authors;

            BooksLb.ItemsSource = _selectedAuthors.books;

            AuthorsGrid.DataContext = _selectedAuthors;

            
        }

        private void BooksLb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _selectedBooks= BooksLb.SelectedItem as Books;

            BooksGrid.DataContext = _selectedBooks;
        }

        private void AddAuthorsBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteAuythorsBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
