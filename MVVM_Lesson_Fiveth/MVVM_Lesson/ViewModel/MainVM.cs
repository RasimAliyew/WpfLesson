using MVVM_Lesson.Commands;
using MVVM_Lesson.Model;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVM_Lesson.ViewModel
{
    //[AddINotifyPropertyChangedInterface]
    class MainVM : ViewModelBase
    {
        private ViewModelBase currentVM;

        public ViewModelBase CurrentVM { get => currentVM; set { Set(ref currentVM, value); } }
        public Command RegisterButton { get; set; }
        public Command LoginButton { get; set; }
        public MainVM()
        {

            //Action<object> action;
            //action = Test;
            //CurrentVM = new LoginVM();
            RegisterButton = new Command(x => GoToRegisterUC());
            LoginButton = new Command(x => GoToLoginUC());
            //ObservableCollection<UserInformation> information;
            // Test();
        }
        public void GoToRegisterUC()
        {
            CurrentVM = new RegisterVM();
            //MessageBox.Show("It's working");
        }
        public void GoToLoginUC()
        {
            CurrentVM = new LoginVM();
            
        }
   
    }
}
