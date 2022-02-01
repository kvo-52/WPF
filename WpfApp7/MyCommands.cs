using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF7
{
    class MyCommands
    {
        public static RoutedUICommand Exit { get; set; }
        static MyCommands()
        {
            InputGestureCollection inputs = new InputGestureCollection();
            inputs.Add(new KeyGesture(Key.F4, ModifierKeys.Alt, "Alt+F4"));
            Exit = new RoutedUICommand("Выход", "Exit", typeof(MyCommands), inputs);
        }
    }
}
