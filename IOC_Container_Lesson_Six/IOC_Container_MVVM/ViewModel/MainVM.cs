using CommandsAndPropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace IOC_Container_MVVM.ViewModel
{
    //public class B<T>
    //{
    //    public B()
    //    {
    //       var a =  typeof(T);
    //        a.GetConstructor;
    //    }
    //}
    //public sealed class A
    //{
    //    private static A instance = new A();
    //    public static A Instance
    //    {
    //        get { return instance; }     
    //    }
    //}
    class MainVM : ViewModelBase
    {
       //A a = A.Instance;
       //A b = A.Instance;
       //A c = new A();
       
        public MainVM()
        {
        
        }
        private ViewModelBase currentVM;
        private Command signUpButton;
        private Command signInButton;


        public ViewModelBase CurrentVM { get => currentVM; set { Set(ref currentVM, value); } }

        public Command SignInButton => signInButton ?? (signInButton = new Command((object x) => GoToSignIn()));

        public Command SignUpButton => signUpButton ?? (signUpButton = new Command((object x) => GoToSignUp(x)));

        //public ViewModelBase CurrentVMT { get; }
      //public MainVM()
      //{
      //    CurrentVMT = new ViewModelBase();
      //    //Action action = GoToSignIn;
      //    //Action<object> action2 = GoToSignUp;
      //    //action2.Invoke("asd");
      //    Action action = () => Console.WriteLine("qwqeqwe");
      //}
        public void Test() => Console.WriteLine("asdasdasdas");

        public void GoToSignIn()
        {
            CurrentVM = App.container.GetInstance<SignInVM>();
            //SignUpButton.CanExecute();
            //SignUpButton.CanExecuteChange();
        }
        public void GoToSignUp(object x)
        {
            CurrentVM = App.container.GetInstance<SignUpVM>();
            MessageBox.Show(x as string);
        }
    }
}
