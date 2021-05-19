using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
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
    public class AppCalculator
    {
        private static readonly ResourceManager ConfData = Resources.ConfData.ResourceManager;

        private static Application _application;

        public static void GetCalculator()
        {
            _application = Application.Launch(ConfData.GetString("AppName"));
        }

        public static void CloseAllInstants()
        {
            IEnumerable<Process> calculatorProcesses = Process.GetProcesses().
                Where(pr => pr.ProcessName == "calc1");

            foreach (var process in calculatorProcesses)
            {
                process.Kill();
            }
        }

        public static Window GetWindow()
        {
            return _application.GetWindow("Calculator", InitializeOption.NoCache);
        }

        public static void Close()
        {
            _application.Kill();
        }

        public static bool IsOpened()
        {
            return _application.Name.Equals("calc1");
        }
    }
}