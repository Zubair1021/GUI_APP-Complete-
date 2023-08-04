using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessAppGUI.DL;
using BussinessAppGUI.BL;
namespace BussinessAppGUI
{
    static class Program
    {
        ///<summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Hard Code Some Data (Dummy Data)

            AdminDl a = new AdminDl();
            AdminDl.hardcodeU();
            stockDl s = new stockDl();
            stockDl.hardcodestock();
            EmployeeDl e = new EmployeeDl();
            EmployeeDl.hardcodeEmpCred();
            EmployeeDl.hardcodeEmployee();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}