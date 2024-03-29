﻿using System;
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

namespace CompanyofPlants
{
    /// <summary>
    /// Логика взаимодействия для EmployesShowWindow.xaml
    /// </summary>
    public partial class EmployesShowWindow : Window
    {
        public EmployesShowWindow()
        {
            InitializeComponent();
            DataGridEmploy.ItemsSource = planting_parksEntities.GetContext().Workers.ToList();    ///Присвоение атрибуту элемента для вывода списка сотрудников таблицы Workers
        }
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
