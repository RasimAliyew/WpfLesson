using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Lesson.ViewModel
{
   
    class A 
    {
        public void Foo()
        {
            Console.WriteLine("asd");
        }
        public Action action;
        public event Action EventAction;
        public A()
        {
            action = Foo;
            EventAction = Foo;

            action.Invoke();
            EventAction.Invoke();

            action = null;
            EventAction = null;
        }
    }
    class ViewModelBase : INotifyPropertyChanged
    {

       //A a = new A();
       //public void Zoo()
       //{
       //    Console.WriteLine("qqq");
       //}
        //public ViewModelBase()
        //{
            //c += 1;
            //c = 1;
            //a.action = Zoo;
            //a.action.Invoke();
            //a.EventAction = Zoo; islemir
            //a.EventAction += Zoo;
            //a.EventAction -= Zoo;

           // a.action.Invoke();
            //a.EventAction Invoke yoxdur !
       // }
        //private int myProperty;

        //public int MyProperty { get => myProperty; set => myProperty = value; }
        //public event Action<int> zero;
        //public void Foo(int value)
        //{
        //    Console.WriteLine("Salam");
        //}
        public event PropertyChangedEventHandler PropertyChanged;

        public void Set<T>(ref T prop, T value, [CallerMemberName] string propertyname = "")
        {
            prop = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
            //constraint.
            //zero = Foo;
            //Action action; //= Foo;
            //action.Invoke(2);
            //action.Invoke(2);
            //action.Invoke(2);
            //action.Invoke(2);

        }
    }
}
