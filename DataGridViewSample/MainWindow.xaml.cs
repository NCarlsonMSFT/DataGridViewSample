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

namespace DataGridViewSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.DataContext = new MainWindowViewModel();
            InitializeComponent();
        }

        public class MainWindowViewModel
        {
            public ObservableCollection<ParameterViewModel> Parameters { get; }

            public MainWindowViewModel()
            {
                Parameters = new ObservableCollection<ParameterViewModel>()
            {
                new ParameterViewModel("name1", "value1"),
                new ParameterViewModel("name2", "value2"),
                new ParameterViewModel("name3", "value3"),
                new ParameterViewModel("name4", "value4"),
                new ParameterViewModel("name5", "value5"),
            };
            }
        }

        public class ParameterViewModel
        {
            public string Name { get; }
            public string Value { get; set; }

            public ParameterViewModel(string name, string value)
            {
                this.Name = name;
                this.Value = value;
            }
        }
    }
}
