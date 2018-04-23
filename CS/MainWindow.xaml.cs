using System.IO;
using System.Windows;

namespace RichEditBindingConvertersWpf {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void reBindingSource_Loaded(object sender, RoutedEventArgs e) {
            reBindingSource.LoadDocument("test.html");
        }

        private void tbBindingSource_Loaded(object sender, RoutedEventArgs e) {
            tbBindingSource.Text = File.ReadAllText("test.html");
        }
    }
}
