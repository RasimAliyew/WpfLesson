using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Lesson.ViewModel
{
    class LoginVM : ViewModelBase
    {
        private int myProperty;

        public int MyProperty { get => myProperty; set => myProperty = value; }
    }
}
