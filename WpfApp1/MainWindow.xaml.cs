using Axe.Windows.Core.Bases;
using Axe.Windows.Desktop.UIAutomation;
using Axe.Windows.Desktop.UIAutomation.TreeWalkers;
using System;
using System.Collections.Generic;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        A11yElement element;
        TreeWalkerForLive tw;

        public MainWindow()
        {
            InitializeComponent();

            element = A11yAutomation.ElementFromDesktop();
            tw = new TreeWalkerForLive();
            tw.GetTreeHierarchy(element, Axe.Windows.Core.Enums.TreeViewMode.Control);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tw.GetTreeHierarchy(element, Axe.Windows.Core.Enums.TreeViewMode.Control);
        }
    }
}
