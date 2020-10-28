using System.Windows;

namespace CustomControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Incriment(object sender, RoutedEventArgs e)
        {
            RatingControl.Value++;
        }

        private void Decriment(object sender, RoutedEventArgs e)
        {
            RatingControl.Value--;
        }
    }
}
