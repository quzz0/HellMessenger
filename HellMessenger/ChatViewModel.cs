using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using HellMessenger.Messenger;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HellMessenger
{
    class ChatViewModel : ViewModelBase
    {
        private Chat chat = new Chat();

        public ObservableCollection<Message> Messages { get; private set; }

        public string Text { get; set; }
        public string Username { get; set; }

        private ICommand _send;
        public ICommand Send
        {
            get
            {
                return _send ?? (_send = new RelayCommand(() => {
                    Message message = new Message(Username, Text);
                    if(chat.SendMessage(message))
                        Messages.Add(message);
                }));
            }
        }

        public ChatViewModel()
        {
            Username = "S470-kun";
            Messages = new ObservableCollection<Message>()
            {
                new Message("nullbyte", "Hello world lolo loladoasodaosd aso doasdo asod oasdo asod o "),
            };
        }
    }
}
