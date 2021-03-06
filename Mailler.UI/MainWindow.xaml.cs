﻿using Mailler.DataAccess;
using Mailler.UI.ViewModel;
using System.Threading.Tasks;
using System.Windows;

namespace Mailler.UI
{
    
    public partial class MainWindow : Window
    {
        private MainViewModel _viewModel;

        public MainWindow(MainViewModel viewModel)
        {
            
            InitializeComponent();
            _viewModel = viewModel;
            DataContext = _viewModel;
            Loaded += MainWindow_Loaded;
        }

        private async void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            
            await _viewModel.LoadAsync();            
        }
    }
}
