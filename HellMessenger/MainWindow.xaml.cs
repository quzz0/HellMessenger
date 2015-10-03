using System.Windows;
using System.Windows.Controls;

namespace HellMessenger
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //WindowController controller = new WindowController();

        public MainWindow()
        {
            InitializeComponent();


            Button sendButton = new Button();
            sendButton.Content = "Test";
            DockPanel.SetDock(sendButton, Dock.Right);

            TextBox messageBox = new TextBox();
            messageBox.TextWrapping = TextWrapping.Wrap;
            messageBox.AcceptsReturn = true;

            sendPanel.Children.Add(sendButton);
            sendPanel.Children.Add(messageBox);
        }
    }
}
