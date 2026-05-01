using System;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace HOTEL
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            
            ApplicationConfiguration.Initialize();

            
            Application.Run(new SpshFrom());
        }
    }
}