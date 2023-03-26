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

namespace Lec_Ex_List_Manjula
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
    }
}

//Create a simple WPF form that that lets you
// Add value to your list
// An index of an element to display in a MessageBox
// An index that you use to remove an element at
// A value to remove from the list
// Two indexs to remove a Range of Items
// A button to clear the entire list
//You should have a button for all Events. A rich text box to display information. And label that
//updates the current COUNT of the list.
//Create a single List<string> in your .cs to add and remove from. This should all be used to display to the
//Run in the Rich Text Box.
//Code to help displaying information. You’ll need this to update your displayed list.
//Information can be found in the List<t> page in modules, and in the lecture.
//GUI – Change as you like