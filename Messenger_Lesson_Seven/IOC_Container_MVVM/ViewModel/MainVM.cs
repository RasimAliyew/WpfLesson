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

    class MainVM : ViewModelBase
    {
        public Messenger messenger { get; set; }
        public MessengerBase messengerBase { get; set; }
        public MainVM(Messenger messenger, MessengerBase messengerBase)
        {
            this.messengerBase = messengerBase;
            PrimaryMessage.action = GoToSignIn;
            // messenger.Register<NavigationMessage>(this,x=> Test(x));
            messengerBase.Register<NavigationMessage>(x=> 
            { 
                if(x is NavigationMessage navigation)
                CurrentVM = navigation.Current; 
            });
            //(x as NavigationMessage).Current
            this.messenger = messenger;          
        }
       //public void Test(NavigationMessage navigation)
       //{
       //    CurrentVM = navigation.Current;
       //}

        private ViewModelBase currentVM;
        private RelayCommand signUpButton;
        private RelayCommand signInButton;


        public ViewModelBase CurrentVM { get => currentVM; set { Set(ref currentVM, value); } }

        public RelayCommand SignInButton => signInButton ?? (signInButton = new RelayCommand(() => GoToSignIn()));

        public RelayCommand SignUpButton => signUpButton ?? (signUpButton = new RelayCommand(() => GoToSignUp()));
   
        public void Test() => Console.WriteLine("asdasdasdas");

        public void GoToSignIn()
        {
            CurrentVM = App.container.GetInstance<SignInVM>();
        }
        public void GoToSignUp()
        {
            CurrentVM = App.container.GetInstance<SignUpVM>();
        }
    }
}
