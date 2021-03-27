using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace CommandsAndPropertyChanged
{
   public class ViewModelBase : INotifyPropertyChanged
   {
       public event PropertyChangedEventHandler PropertyChanged;
   
       public void Set<T>(ref T prop,T value,[CallerMemberName] string propname = "")
       {
           prop = value;
           PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(propname));
       }
   }
}
