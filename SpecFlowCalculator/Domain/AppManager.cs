using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Resources;
using TestStack.White;
using TestStack.White.Factory;
using TestStack.White.UIItems.WindowItems;

namespace SpecFlowCalculator
{
    public class AppManager
    {
        private static readonly ResourceManager ConfData = Resources.ConfData.ResourceManager;
        private static Application _application;

        public static void GetApplication()
        {
            _application = Application.Launch(ConfData.GetString("AppName"));
        }

        public static void CloseAllInstants()
        {
            IEnumerable<Process> calculatorProcesses = Process.GetProcesses().
                Where(pr => pr.ProcessName == ConfData.GetString("ProcessName"));

            foreach (var process in calculatorProcesses)
            {
                process.Kill();
            }
        }

        public static Window GetWindow()
        {
            return _application.GetWindow(ConfData.GetString("WindowName"), InitializeOption.NoCache);
        }

        public static void Close()
        {
            _application.Kill();
        }

        public static string GetWindowName()
        {
            return GetWindow().Title;
        }
    }
}