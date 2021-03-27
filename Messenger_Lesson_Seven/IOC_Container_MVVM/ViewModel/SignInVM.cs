//using CommandsAndPropertyChanged;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using IOC_Container_MVVM.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace IOC_Container_MVVM.ViewModel
{
    class SignInVM : ViewModelBase
    {
        Messenger messenger { get; set; }
        MessengerBase messengerBase { get; set; }
        public SignInVM(Messenger messenger, MessengerBase messengerBase)
        {
            this.messengerBase = messengerBase;
            this.messenger = messenger;
        }
        private RelayCommand signUpButton;
        public RelayCommand SignUpButton => signUpButton ?? (signUpButton = new RelayCommand(() => GoToSignUp()));
        public void GoToSignUp()
        {
            //messenger.Send(new NavigationMessage() { Current = App.container.GetInstance<SignUpVM>() });
            messengerBase.Send<NavigationMessage>(new NavigationMessage() { Current = App.container.GetInstance<SignUpVM>() });

        }
    }
}
