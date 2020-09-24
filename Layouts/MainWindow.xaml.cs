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

namespace Layouts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            stackpanelBtn.Click += btnClick;
            dockBtn.Click += btnClick;
            gridBtn.Click += btnClick;
            gridsplitterBtn.Click += btnClick;
        }
        private void btnClick(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;

            if (btn == null)
            {
                throw new ArgumentException();
            }
            else
            {
                switch(btn.Name)
                {
                    case "stackpanelBtn":
                        StackPanelWindow stackpanel = new StackPanelWindow();
                        stackpanel.Show();
                        break;
                    case "dockBtn":
                        DockWindow dockwindow = new DockWindow();
                        dockwindow.Show();
                        break;
                    case "gridBtn":
                        GridWindow gridWindow = new GridWindow();
                        gridWindow.Show();
                        break;
                    case "gridsplitterBtn":
                        GridSplitterWindow gridsplitterWindow = new GridSplitterWindow();
                        gridsplitterWindow.Show();
                        break;
                }
            }
        }
    }
}
