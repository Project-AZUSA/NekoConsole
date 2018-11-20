using System.Threading.Tasks;
using System.Windows;
using MahApps.Metro.Controls;

namespace NekoConsole
{
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public async Task CheckUpdate()
        {

        }

        private void Test(object sender, RoutedEventArgs e)
        {
            NekoAgent.Test();
        }
    }
}
