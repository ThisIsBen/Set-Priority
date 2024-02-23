using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SetPriority
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void HighPriority_Btn_Click(object sender, RoutedEventArgs e)
        {


            using (Process highProcess = Process.Start("NotePad.exe"))
            {


                highProcess.PriorityClass = ProcessPriorityClass.AboveNormal;



              
                 

                   

                // Display current process statistics.

                Console.WriteLine($"{highProcess} -");
                Console.WriteLine("-------------------------------------");

                Console.WriteLine($"  Physical memory usage     : {highProcess.WorkingSet64}");
                Console.WriteLine($"  Base priority             : {highProcess.BasePriority}");
                Console.WriteLine($"  Priority class            : {highProcess.PriorityClass}");
                Console.WriteLine($"  User processor time       : {highProcess.UserProcessorTime}");
                Console.WriteLine($"  Privileged processor time : {highProcess.PrivilegedProcessorTime}");
                Console.WriteLine($"  Total processor time      : {highProcess.TotalProcessorTime}");
                Console.WriteLine($"  Paged system memory size  : {highProcess.PagedSystemMemorySize64}");
                Console.WriteLine($"  Paged memory size         : {highProcess.PagedMemorySize64}");

                   
                

            }
                
            
                
                
            
        }

        private void LowPriority_Btn_Click(object sender, RoutedEventArgs e)
        {

            using (Process lowProcess = Process.Start("cmd.exe"))
            {
                lowProcess.PriorityClass = ProcessPriorityClass.BelowNormal;



                
                   
                  
                // Display current process statistics.

                Console.WriteLine($"{lowProcess} -");
                Console.WriteLine("-------------------------------------");

                Console.WriteLine($"  Physical memory usage     : {lowProcess.WorkingSet64}");
                Console.WriteLine($"  Base priority             : {lowProcess.BasePriority}");
                Console.WriteLine($"  Priority class            : {lowProcess.PriorityClass}");
                Console.WriteLine($"  User processor time       : {lowProcess.UserProcessorTime}");
                Console.WriteLine($"  Privileged processor time : {lowProcess.PrivilegedProcessorTime}");
                Console.WriteLine($"  Total processor time      : {lowProcess.TotalProcessorTime}");
                Console.WriteLine($"  Paged system memory size  : {lowProcess.PagedSystemMemorySize64}");
                Console.WriteLine($"  Paged memory size         : {lowProcess.PagedMemorySize64}");

                   
                

            }
        }
    }
}
