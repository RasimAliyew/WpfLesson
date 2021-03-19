using CommandsAndPropertyChanged;
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
        public MainVM mainvm { get; set; }
        public SignInVM(MainVM vm)
        {
            mainvm = vm;
        }
        private Command signUpButton;
        public Command SignUpButton => signUpButton ?? (signUpButton = new Command(x => GoToSignUp()));
        public void GoToSignUp()
        {
            mainvm.CurrentVM = App.container.GetInstance<SignUpVM>();
            MessageBox.Show("TTTTTTTTTTT");
        }
    }
}
