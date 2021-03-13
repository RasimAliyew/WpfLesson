using MVVM_Lesson.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVM_Lesson.ViewModel
{
    class LoginVM : ViewModelBase
    {
        //public RelayCommand command { get; set; }
        //RegisterButton
        public Command RegisterButton { get; set; }
        
        public LoginVM()
        {
            RegisterButton = new Command(x => GoToRegisterUC());
        }
        public void GoToRegisterUC()
        {
            //CurrentVM = new RegisterVM();
        }


    }
}
