using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellMessenger.ViewModels
{
    class ViewModelLocator
    {
        public ChatViewModel ChatView
        {
            get { return new ChatViewModel(); }
        }

        public EnterViewModel EnterView
        {
            get { return new EnterViewModel(); }
        }
    }
}
