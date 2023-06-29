using Project1_MediaPlayer;
using System.Windows;

namespace Project1_MediaPlayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class ShellView : System.Windows.Window
    {
        public ShellView()
        {
            InitializeComponent();

            DataContext = new ShellViewModel(this);
        }
    }
}
