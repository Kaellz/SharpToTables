using Microsoft.Win32;
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

namespace SharpToTables.WPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CommonOpenFileDialog dialog = new CommonOpenFileDialog();
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_SkillNameTable(object sender, RoutedEventArgs e)
        {
            _openFileDialog = new OpenFileDialog();
            _openFileDialog.ShowDialog();

            if (!string.IsNullOrEmpty(_openFileDialog.FileName))
            {
                this.txtSkillnametable.Text = _openFileDialog.FileName;
            }
        }
    }
}
