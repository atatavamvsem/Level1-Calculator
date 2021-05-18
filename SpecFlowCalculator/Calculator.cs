using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestStack.White;
using TestStack.White.Bricks;
using TestStack.White.Factory;
using TestStack.White.UIItems.Finders;
using TestStack.White.InputDevices;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.Configuration;
using TestStack.White.UIItems;
using TestStack.White.WindowsAPI;

namespace SpecFlowCalculator
{
    public class Calculator
    {
        private static Application _application;
        private static Window _window;

        public static Calculator GetCalculator()
        {
            _application = Application.Launch(@"calc1.exe");
            _window = _application.GetWindow("Calculator", InitializeOption.NoCache);
            return new Calculator();
        }

        public static void CloseAllInstants()
        {
            List<Window> lWindows = Desktop.Instance.Windows(); 
            foreach (Window win in lWindows)
            {
                if (win.Title.Equals("Calculator"))
                {
                    win.Close();
                    win.Dispose();
                }
            }
        }

        public static Window GetWindow()
        {
            return _application.GetWindow("Calculator", InitializeOption.NoCache);
        }

        public static void Close()
        {
            _application.Close();
            _application.Dispose();
        }
    }
}