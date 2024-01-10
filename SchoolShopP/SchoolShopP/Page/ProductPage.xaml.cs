using SchoolShopP.Database;
using SchoolShopP.DB;
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

namespace SchoolShopP.Page
{
    /// <summary>
    /// Логика взаимодействия для ProductPage.xaml
    /// </summary>
    public partial class ProductPage
    {
        List<Product> products = new List<Product>();
        public ProductPage()
        {
            InitializeComponent();
            products = DataBase.entities.Product.ToList();
            ListViewProducts.ItemsSource = products;
            ManufComboBox.Items.Add(new Manufacturer() { Name = "Все производители" });
            foreach (var i in DataBase.entities.Manufacturer.ToList())
            {
                ManufComboBox.Items.Add(i);
            }
        }
        //Метод для TextBox для поиска
        private void SearhBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (SearhBox.Text == "")
            {
                products = DataBase.entities.Product.ToList();
                ListViewProducts.ItemsSource = products;
                ManufComboBox_SelectionChanged(null, null);
                OrderBy_Click(null, null);
                DescOrderBy_Click(null, null);
                AmountTextBlock.Text = $"{ListViewProducts.Items.Count} из {DataBase.entities.Product.ToList().Count}";
            }
            else
            {
                products = products.Where(u => u.Title.ToLower().Contains(SearhBox.Text.ToLower())
                || u.Cost.ToString().Contains(SearhBox.Text.ToLower())
                || u.Description.ToLower().Contains(SearhBox.Text.ToLower())).ToList();
                ListViewProducts.ItemsSource = products;
                ManufComboBox_SelectionChanged(null, null);
                OrderBy_Click(null, null);
                DescOrderBy_Click(null, null);
                AmountTextBlock.Text = $"{ListViewProducts.Items.Count} из {DataBase.entities.Product.ToList().Count}";
            }
            if (ListViewProducts.HasItems == false)
            {
                EmptyPanel.Visibility = Visibility.Visible;
                AmountTextBlock.Text = $"{ListViewProducts.Items.Count} из {DataBase.entities.Product.ToList().Count}";
            }
            else
            {
                ManufComboBox_SelectionChanged(null, null);
                OrderBy_Click(null, null);
                DescOrderBy_Click(null, null);
                EmptyPanel.Visibility = Visibility.Hidden;
                AmountTextBlock.Text = $"{ListViewProducts.Items.Count} из {DataBase.entities.Product.ToList().Count}";
            }
            AmountTextBlock.Text = $"{ListViewProducts.Items.Count} из {DataBase.entities.Product.ToList().Count}";
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            products = DataBase.entities.Product.ToList();
            ListViewProducts.ItemsSource = products;
            EmptyPanel.Visibility = Visibility.Hidden;
        }
        //метод для ComboBox для фильтрации по производителю 
        private void ManufComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                Manufacturer manufacturer = (Manufacturer)ManufComboBox.SelectedItem;
                if (manufacturer.Name != "Все производители")
                {

                    ListViewProducts.ItemsSource = products.Where(c => c.Manufacturer.ID == manufacturer.ID).ToList();

                }
                else
                {
                    ListViewProducts.ItemsSource = products;

                }
                AmountTextBlock.Text = $"{ListViewProducts.Items.Count} из {DataBase.entities.Product.ToList().Count}";
            }
            catch { MessageBox.Show("Что-то пошло не так"); }
        }



        Product curentproduct;

        // свойство по умолчанию для ManufComboBox
        private void CancelFilter_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            ManufComboBox.SelectedIndex = 0;
        }

        private void ManufComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                Manufacturer manufacturer = (Manufacturer)ManufComboBox.SelectedItem;
                if (manufacturer.Name != "Все производители")
                {
                    ListViewProducts.ItemsSource = products.Where(c => c.Manufacturer.ID == manufacturer.ID).ToList();
                }
                else
                {
                    ListViewProducts.ItemsSource = products;
                }
                AmountTextBlock.Text = $"{ListViewProducts.Items.Count} из {DataBase.entities.Product.ToList().Count}";
            }
            catch { MessageBox.Show("Что-то пошло не так"); }
        }

        private void ProductBorder_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            curentproduct = (Product)ListViewProducts.SelectedItem;
            if (e.ClickCount == 2)
            {
                if (curentproduct.IsActive == false)
                {
                    MessageBox.Show("Данный товар не активен.");
                }
                else
                {
                    NavigationService.Navigate(new AddEditePage(curentproduct));
                }
            }
        }
        //кнопка для фильтрации продукта по ценам по возрастанию
        private void OrderBy_Click(object sender, RoutedEventArgs e)
        {
            products = products.OrderBy(c => c.Cost).ToList();
            ListViewProducts.ItemsSource = products;
            ManufComboBox_SelectionChanged(null, null);
        }
        //кнопка для фильтрации продукта по ценам по убыванию
        private void DescOrderBy_Click(object sender, RoutedEventArgs e)
        {
            products = products.OrderByDescending(c => c.Cost).ToList();
            ListViewProducts.ItemsSource = products;
            ManufComboBox_SelectionChanged(null, null);
        }
        //кнопка для перехода на страничку добавления
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddEditePage());
        }
        //кнопка для перехода на страничку изменения
        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            if (curentproduct != null)
            {
                NavigationService.Navigate(new AddEditePage(curentproduct));
                products = DataBase.entities.Product.ToList();
                ListViewProducts.ItemsSource = products;
            }
            else
            {
                MessageBox.Show("Выбирете продукт", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }


        }
        //кнопка для удаления
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Product CurrentProduct = (Product)ListViewProducts.SelectedItem;
                MessageBoxResult result = MessageBox.Show("Вы действительно хотите удалить этот товар?", "Сообщение", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    if (CurrentProduct.ProductSale.Where(c => c.Product.ID == CurrentProduct.ID).ToList().Count == 0)
                    {
                        if (CurrentProduct.AttachedProduct.Where(c => CurrentProduct.ID == c.MainProductID).ToList().Count == 0)
                        {
                            DataBase.entities.Product.Remove(CurrentProduct); DataBase.entities.SaveChanges();
                            products = DataBase.entities.Product.ToList(); ListViewProducts.ItemsSource = products;
                            AmountTextBlock.Text = $"{ListViewProducts.Items.Count} из {DataBase.entities.Product.ToList().Count}";
                        }
                        else
                        {
                            MessageBox.Show("У данного товара есть доп.товары.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Данный товар находится в продажах.");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Произошла ошибка.");
            }
        }
       
        private void ListViewProducts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            curentproduct = (Product)ListViewProducts.SelectedItem;
        }
    }
}
