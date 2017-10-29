using CrystalDecisions.CrystalReports.Engine;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CRViewerDemo
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            reportViewer.Owner = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Crystal Reports (*.rpt)|*.rpt|All files (*.*)|*.*";

            var result = openFileDialog.ShowDialog();

            if (result.HasValue && result.Value)
            {
                var rpt = new ReportDocument();
                rpt.Load(openFileDialog.FileName);

                reportViewer.ViewerCore.ReportSource = rpt;
                
            }
                
        }
    }
}
