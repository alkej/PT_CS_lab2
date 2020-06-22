using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PT_lab2
{
    /// <summary>
    /// Interaction logic for CreateOptionsDialog.xaml
    /// </summary>
    public partial class CreateOptionsDialog : Window
    {
        protected string path = null;
        protected string fullPath = null;
        public CreateOptionsDialog(string path)
        {
            this.path = path;

            InitializeComponent();
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            string fileTitle = nameInputTextBox.Text;
           
            if (this.path != null)
            {
                bool readonly_atr = (bool)ReadOnlyCheckBox.IsChecked;
                bool archive = (bool)ArchiveCheckBox.IsChecked;
                bool hidden = (bool)HiddenCheckBox.IsChecked;
                bool system = (bool)SystemCheckBox.IsChecked;

                bool dirFlag = (bool)directoryRadioButton.IsChecked;
                bool fileFlag = (bool)fileRadioButton.IsChecked;

                bool regexMatch = Regex.IsMatch(fileTitle, "^[a-zA-Z0-9_~-]{1,8}(.txt|.html|.php)$");

                if (fileFlag && !regexMatch)
                {
                    string msg = "Name length should be between 1 and 8 \n" +
                            "Allowed extensions .txt, .php, .html \n\n" +
                            "Example: test.txt";
                    System.Windows.MessageBox.Show(msg, "Error",
                        MessageBoxButton.OK, MessageBoxImage.Exclamation);
                } 
                else if (dirFlag && fileTitle == "")
                { 
                    string msg = "Folder name cannot be empty!";
                    System.Windows.MessageBox.Show(msg, "Error",
                        MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
                else{
                    this.fullPath = path + @"\" + fileTitle;

                    if (dirFlag)
                    {
                        Directory.CreateDirectory(this.fullPath);
                    }
                    else if (fileFlag)
                    {
                        File.Create(this.fullPath);
                    }

                    FileAttributes attr = FileAttributes.Normal;

                    if (readonly_atr)
                        attr |= FileAttributes.ReadOnly;
                    if (archive)
                        attr |= FileAttributes.Archive;
                    if (hidden)
                        attr |= FileAttributes.Hidden;
                    if (system)
                        attr |= FileAttributes.System;

                    File.SetAttributes(this.fullPath, attr);

                    if (dirFlag || fileFlag) // just in case of smth :)
                        this.DialogResult = true;
                    else
                        this.DialogResult = false;

                    Close();
                }

            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            Close();
        }

        public string GetFullPath()
        {
            return this.fullPath;
        }
    }
}
