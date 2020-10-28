using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace DialogHost.RoutedCommand
{
    /// <summary>
    /// Interaction logic for SimpleDialog.xaml
    /// </summary>
    public partial class SimpleDialog : UserControl
    {
        public SimpleDialog()
        {
            InitializeComponent();
        }

        private void No_Click(object sender, RoutedEventArgs e)
        {
            CloseDialog();
        }

        private async void Yes_Click(object sender, RoutedEventArgs e)
        {
            await Task.Delay(TimeSpan.FromSeconds(1));
            CloseDialog();
        }

        private void CloseDialog()
        {
            var command = MaterialDesignThemes.Wpf.DialogHost.CloseDialogCommand;
            if (command.CanExecute(null, this))
            {
                command.Execute(null, this);
            }
        }
    }
}
