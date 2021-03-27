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

namespace IOC_Container_MVVM.ViewModel
{
    class SignUpVM : ViewModelBase
    {
        public Messenger messenger { get; set; }
        public RelayCommand SignUpButton { get; set; }
        public SignUpVM(Messenger messenger)
        {
             this.messenger = messenger;
             SignUpButton = new RelayCommand(() => GO());
        }
        public void GO()
        {
            PrimaryMessage.action.Invoke();
        }
    }
}
