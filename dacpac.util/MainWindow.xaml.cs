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
using Microsoft.Win32;

namespace dacpac.util
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

        private void AddFileButton_Click(object sender, RoutedEventArgs e)
        {
            /// OpenFileDialog
            OpenFileDialog dialog = new OpenFileDialog();
            
            dialog.DefaultExt = ".dacpac";
            dialog.Filter = "Dacpac Files (*.dacpac)|*.dacpac|Bacpac Files (*.bacpac)|*.bacpac|All Files (*.*)|*.*";

            Nullable<bool> result = dialog.ShowDialog();

            if (result == true)
            {
                string filename = dialog.FileName;
                MessageBox.Show(filename.ToString());
            }

        }
    }
}
