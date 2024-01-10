using Microsoft.Win32;
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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SchoolShopP.Page
{
    /// <summary>
    /// Логика взаимодействия для AddEditePage.xaml
    /// </summary>
    public partial class AddEditePage 
    {
        Product product;
        bool newProduct = false;
        public AddEditePage()
        {
            InitializeComponent();
            this.product = new Product();
            ManufacturerBox.ItemsSource = DataBase.entities.Manufacturer.ToList();
            newProduct = true;
            this.DataContext = this.product;
            Save.Visibility = Visibility.Visible;
        }
        public AddEditePage(Product curentproduct)
        {
            InitializeComponent();
            this.product = curentproduct;
            ManufacturerBox.ItemsSource = DataBase.entities.Manufacturer.ToList();
            this.DataContext = this.product;
            Edit.Visibility = Visibility.Visible;
            IDtext.IsEnabled = false;
            PanelD.Visibility = Visibility.Visible;
        }
       //кнопка для добавления/изменения товаров
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (product.ID == 0)
                {
                    try
                    {
                     
                        DataBase.entities.Product.Add(product);
                        if(fileDialog==null)
                        {
                            MessageBox.Show("Пожалуйста выбирете фото", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        else
                        {
                        product.PhotoProduct = File.ReadAllBytes(fileDialog.FileName);
                        DataBase.entities.SaveChanges();
                        MessageBox.Show("Успешно добавлено", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                        NavigationService.Navigate(new ProductPage());
                        }
                        
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    try
                    {
                       if(fileDialog==null)
                        {
                            MessageBox.Show("Пожалуйста выбирете фото", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        else
                        {
                            product.PhotoProduct = File.ReadAllBytes(fileDialog.FileName);
                            DataBase.entities.SaveChanges();
                            MessageBox.Show("Успешно изменено", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                            NavigationService.Navigate(new ProductPage());
                        }
                       
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
           
        }

        private void PhotoBox_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();
            string path = fileDialog.FileName;
            product.MainImagePath = path;    
            PhotoBox.Source = new BitmapImage(new Uri(path));
            }
            catch
            {
                MessageBox.Show("Выбирете фото", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
           

            
        }
        OpenFileDialog fileDialog;
        private void Dialog_Click(object sender, RoutedEventArgs e)
        {
            fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)|*.bmp;*.jpg;*.gif; *.tif; *.png; *.ico; *.emf; *.wmf";
            if (fileDialog.ShowDialog() == true)
            {
                PhotoBox.Source = LoadImage(File.ReadAllBytes(fileDialog.FileName));

            }
        }
        private static BitmapImage LoadImage(byte[] imageData)
        {
            if (imageData == null || imageData.Length == 0) return null;
            var image = new BitmapImage();
            using (var mem = new MemoryStream(imageData))
            {
                mem.Position = 0;
                image.BeginInit();
                image.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.UriSource = null;
                image.StreamSource = mem;
                image.EndInit();
            }
            image.Freeze();
            return image;
        }
    }
}
