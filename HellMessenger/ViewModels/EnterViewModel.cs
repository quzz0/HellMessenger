using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using HellMessenger.Views;
using System.Windows;
using System.Windows.Input;

namespace HellMessenger.ViewModels
{
    class EnterViewModel : ViewModelBase
    {
        public string Username { get; set; }

        private ICommand _enter;
        public ICommand Enter
        {
            get
            {
                return _enter ?? (_enter = new RelayCommand<Window>(this.OpenChat));
            }
        }

        public void OpenChat(Window window)
        {
            ChatViewModel chatViewModel = new ViewModelLocator().ChatView;
            chatViewModel.Username = Username;

            ChatView chatView = new ChatView();
            chatView.DataContext = chatViewModel;

            window.Close();
            chatView.Show();
        }
    }
}
