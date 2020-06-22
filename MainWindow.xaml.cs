using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PT_lab2
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

        private TreeViewItem GenerateTreeDirectory(DirectoryInfo dir)
        {
            TreeViewItem node = new TreeViewItem
            {
                Header = dir.Name,
                Tag = dir.FullName
            };

            foreach (var f in dir.GetFiles())
            {
                node.Items.Add(GenerateTreeFile(f));
            }
            foreach (var d in dir.GetDirectories())
            {
                node.Items.Add(GenerateTreeDirectory(d));
            }

            node.ContextMenu = new System.Windows.Controls.ContextMenu();
            var openMI = new System.Windows.Controls.MenuItem { Header = "Create" };
            openMI.Click += new RoutedEventHandler(CreateTreeViewContexMenu);
            var deleteMI = new System.Windows.Controls.MenuItem { Header = "Delete" };
            deleteMI.Click += new RoutedEventHandler(DeleteTreeViewContexMenu);
            node.ContextMenu.Items.Add(openMI);
            node.ContextMenu.Items.Add(deleteMI);

            node.Selected += new RoutedEventHandler(PrintRAHSAttributes);

            return node;
        }
        private TreeViewItem GenerateTreeFile(FileInfo file)
        {
            var node = new TreeViewItem
            {
                Header = file.Name,
                Tag = file.FullName
            };

            node.ContextMenu = new System.Windows.Controls.ContextMenu();
            var openMI = new System.Windows.Controls.MenuItem { Header = "Open" };
            openMI.Click += new RoutedEventHandler(OpenTreeViewContexMenu);
            var deleteMI = new System.Windows.Controls.MenuItem { Header = "Delete" };
            deleteMI.Click += new RoutedEventHandler(DeleteTreeViewContexMenu);
            node.ContextMenu.Items.Add(openMI);
            node.ContextMenu.Items.Add(deleteMI);

            node.Selected += new RoutedEventHandler(PrintRAHSAttributes);

            return node;
        }

        private void PrintRAHSAttributes(object sender, RoutedEventArgs e)
        {
            TreeViewItem node = (TreeViewItem)treeViewMain.SelectedItem;
            string path = (string)node.Tag;

            string attr = GetRAHS(path);

            textStatusBarMain.Text = attr;
        }

        private string GetRAHS(string path)
        {
            string result = "";

            FileAttributes fileAttributes = File.GetAttributes(path);

            if ((fileAttributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
            {
                result += "r";
            }
            else
            {
                result += "-";
            }

            if ((fileAttributes & FileAttributes.Archive) == FileAttributes.Archive)
            {
                result += "a";
            }
            else
            {
                result += "-";
            }

            if ((fileAttributes & FileAttributes.Hidden) == FileAttributes.Hidden)
            {
                result += "h";
            }
            else
            {
                result += "-";
            }

            if ((fileAttributes & FileAttributes.System) == FileAttributes.System)
            {
                result += "s";
            }
            else
            {
                result += "-";
            }

            return result;
        }

        private void CreateTreeViewContexMenu(object sender, RoutedEventArgs e)
        {
            TreeViewItem node = (TreeViewItem)treeViewMain.SelectedItem;
            string path = (string)node.Tag;

            CreateOptionsDialog dlg = new CreateOptionsDialog(path);
            dlg.Owner = this;
            var dialogResult = dlg.ShowDialog();

            string fullPath = dlg.GetFullPath();

            if (dialogResult == true && fullPath != null)
            {
                TreeViewItem newNode = null;

                if ((bool)dlg.fileRadioButton.IsChecked)
                {
                    newNode = GenerateTreeFile(new FileInfo(fullPath));
                }
                else if ((bool)dlg.directoryRadioButton.IsChecked)
                {
                    newNode = GenerateTreeDirectory(new DirectoryInfo(fullPath));
                }

                if (newNode != null)
                    node.Items.Add(newNode);
            }

        }

        private void DeleteTreeViewContexMenu(object sender, RoutedEventArgs e)
        {
            TreeViewItem node = (TreeViewItem) treeViewMain.SelectedItem;
            string path = (string) node.Tag;

            FileAttributes attr = File.GetAttributes(path);

            if (attr.HasFlag(FileAttributes.ReadOnly))
            {
                File.SetAttributes(path, attr & ~FileAttributes.ReadOnly);
            }

            if (attr.HasFlag(FileAttributes.Directory))
            {
                DirectoryInfo dir = new DirectoryInfo(path);
                DeleteDir(dir);
            }
            else
            {
                File.Delete(path);
            }

            if (node.Parent.GetType() == typeof(TreeViewItem) && node.Parent != null)
            {
                TreeViewItem parentNode = (TreeViewItem)node.Parent;
                parentNode.Items.Remove(node);
            }
            else
            {
                treeViewMain.Items.Clear();
            }
        }

        private void DeleteDir(DirectoryInfo dir)
        {
            
            foreach (var d in dir.GetDirectories())
            {
                DeleteDir(d);
            }

            foreach (var f in dir.GetFiles())
            {
                f.Delete();
            }

            dir.Delete();
        }

        private void OpenTreeViewContexMenu(object sender, RoutedEventArgs e)
        {
            TreeViewItem node = (TreeViewItem)treeViewMain.SelectedItem;
            string path = (string)node.Tag;

            var data = File.ReadAllText(path);
            TextBlock textBlock = textBlockMain;
            textBlock.Text =data;
        }

        private void OpenMenu_Click(object sender, RoutedEventArgs e)
        {
            var dlg = new FolderBrowserDialog() { Description = "Select directory to open" };
            var dialogResult = dlg.ShowDialog();

            if (dialogResult == System.Windows.Forms.DialogResult.OK)
            {
                var path = dlg.SelectedPath;

                treeViewMain.Items.Clear();
                DirectoryInfo dir = new DirectoryInfo(path);
                var root = GenerateTreeDirectory(dir);
                treeViewMain.Items.Add(root);
            }
            
        }
        private void ExitMenu_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
