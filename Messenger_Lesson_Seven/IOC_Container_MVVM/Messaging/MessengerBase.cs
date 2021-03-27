using IOC_Container_MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC_Container_MVVM.Messaging
{
    class MessengerBase
    {
        public readonly Dictionary<Type, List<Action<object>>> pairs = new Dictionary<Type, List<Action<object>>>();

        public void Register<T>(Action<object> action) where T : class
        {
            Type type = typeof(T);
            if (!pairs.ContainsKey(type))
            {
                //pairs.Add(type, new List<Action<object>>());
                pairs[type] = new List<Action<object>>();
            }
            pairs[type].Add(action);
        }
        public void Send<T>(object obj)
        {
            Type type = typeof(T);
            if (pairs.ContainsKey(type))
            {
                foreach (var action in pairs[type])
                {
                    action.Invoke(obj);
                }
            }
        }

    }
}
