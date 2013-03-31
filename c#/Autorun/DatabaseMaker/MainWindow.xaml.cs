using System;
using System.Collections.Generic;
using System.Linq;
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

namespace DatabaseMaker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string filePlatform = "";
        string fileCategory = "";
        string fileItemIcon = "";
        string fileItemImage = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            //Database.Instance.OpenConnection();
            //Database.Instance.Category.Delete(6);
            //Database.Instance.CloseConnection();
        }

        private void btnBrowsePlatformImage_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            if (dlg.ShowDialog().Value)
            {
                imgPlatform.Source = new BitmapImage(new Uri(dlg.FileName, UriKind.Absolute));
                filePlatform = dlg.FileName;
            }
        }

        private void btnInsertPlatform_Click(object sender, RoutedEventArgs e)
        {
            PlatformTableAdapter.Row row = new PlatformTableAdapter.Row();

            row.Name = txtPlatformName.Text;
            row.Image = System.IO.File.ReadAllBytes(filePlatform);

            try
            {
                Database.Instance.OpenConnection();
                Database.Instance.Platform.Insert(row);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Database.Instance.CloseConnection();
            }
        }

        private void btnPlatformSelect_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Database.Instance.OpenConnection();
                PlatformTableAdapter.Row[] rows = Database.Instance.Platform.Select();

                grdPlatform.ItemsSource = rows;
            }
            finally
            {
                Database.Instance.CloseConnection();
            }
        }

        private void btnBrowseCategoryImage_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            if (dlg.ShowDialog().Value)
            {
                imgCategoryImage.Source = new BitmapImage(new Uri(dlg.FileName, UriKind.Absolute));
                fileCategory = dlg.FileName;
            }
        }

        private void btnInsertCategory_Click(object sender, RoutedEventArgs e)
        {
            CategoryTableAdapter.Row row = new CategoryTableAdapter.Row();

            row.Name = txtCategoryName.Text;
            row.Description = txtCategoryDescription.Text;
            row.Image = System.IO.File.ReadAllBytes(fileCategory);

            try
            {
                Database.Instance.OpenConnection();
                Database.Instance.Category.Insert(row);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Database.Instance.CloseConnection();
            }
        }

        private void btnSelectCategory_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Database.Instance.OpenConnection();
                CategoryTableAdapter.Row[] rows = Database.Instance.Category.Select();

                grdCategory.ItemsSource = rows;
            }
            finally
            {
                Database.Instance.CloseConnection();
            }
        }

        private void btnBrowseItemIcon_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            if (dlg.ShowDialog().Value)
            {
                imgItemIcon.Source = new BitmapImage(new Uri(dlg.FileName, UriKind.Absolute));
                fileItemIcon = dlg.FileName;
            }
        }

        private void btnBrowseItemImage_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            if (dlg.ShowDialog().Value)
            {
                imgItemImage.Source = new BitmapImage(new Uri(dlg.FileName, UriKind.Absolute));
                fileItemImage = dlg.FileName;
            }
        }

        private void btnBrowseItemPath_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            if (dlg.ShowDialog().Value)
            {
                System.IO.FileInfo f = new System.IO.FileInfo(dlg.FileName);
                txtItemFileSize.Text = f.Length.ToString();
                txtItemPath.Text = f.Name;
            }
        }
    }
}
