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
        ListBox messagesList;
        TextBox messageBox;

        public MainWindow()
        {
            InitializeComponent();

            //chat panel
            //TextBlock testMessage = new TextBlock();
            //testMessage.Text = "hello world";

            messagesList = new ListBox();
            messagesList.Items.Add(new MessageDock("nullbyte", "hello world").panel());

            chatPanel.Children.Add(messagesList);

            //send panel
            Button sendButton = new Button();
            sendButton.Click += SendButton_Click;
            sendButton.Content = "Test";
            DockPanel.SetDock(sendButton, Dock.Right);

            messageBox = new TextBox();
            messageBox.TextWrapping = TextWrapping.Wrap;
            messageBox.AcceptsReturn = true;

            sendPanel.Children.Add(sendButton);
            sendPanel.Children.Add(messageBox);
        }

        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            if (messageBox.Text.Length < 1)
                return;

            messagesList.Items.Add(new MessageDock("nullbyte", messageBox.Text).panel());
        }
    }

    public class MessageDock
    {
        DockPanel dockPanel = new DockPanel();
        public MessageDock(string username, string message)
        {
            Button usernameBlock = new Button();
            usernameBlock.Content = username;
            usernameBlock.Click += UsernameBlock_Click;
            DockPanel.SetDock(usernameBlock, Dock.Left);

            Button messageBlock = new Button();
            messageBlock.Click += MessageBlock_Click;
            messageBlock.Content = message;

            dockPanel.Children.Add(usernameBlock);
            dockPanel.Children.Add(messageBlock);
        }

        private void MessageBlock_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("mess click"); ;
        }

        private void UsernameBlock_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("user click");
        }

        public DockPanel panel()
        {
            return dockPanel;
        }
    }
}
