using MVVM_Lesson.Model;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Lesson.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    class MainVM : ViewModelBase
    {
        public ViewModelBase CurrentVM { get; set; }
        public MainVM()
        {
             CurrentVM = new RegisterVM();
            // ObservableCollection<UserInformation> information;
           // Test();
        }
       //public void Test()
       //{
       //    CurrentVM = new LoginVM();
       //}
    }
}
