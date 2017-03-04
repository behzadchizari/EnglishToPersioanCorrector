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

namespace EnglishToPersioanCorrector
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
        char[] p = {'ض','ص','ث','ق','ف','غ','ع','ه','خ','ح','ج','چ','پ','ش','س','ی','ب','ل','ا','ت','ن','م','ک','گ','ظ','ط','ز','ر','ذ','د','ئ','و' };
        char[]  e = {'q','w','e','r','t','y','u','i','o','p','[',']','\\','a','s','d','f','g','h','j','k','l',';','\'','z', 'x', 'c', 'v', 'b', 'n', 'm', ','};
        char[]  E = {'Q','W','E','R','T','Y','U','I','O','P','[',']','\\','A','S','D','F','G','H','J','K','L',';','\'','Z', 'X', 'C', 'V', 'B', 'N', 'M', ','};

        public string Function(string txt)
        {
            var c = txt.ToCharArray();
            var s = "";
            var i = 0;
            foreach (var item in c)
            {
                for (int j = 0; j < e.Length; j++)
                {
                    if (item == e[j] || item == E[j])
                    {
                        c[i] = p[j];  
                    }
                    if (item == p[j])
                    {
                        c[i] = e[j];
                    }
                }
                i++;
            }
            foreach (var item in c)
            {
                s += item;
            }
            return s;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            txtCorect.Text = Function(txtWrong.Text);
        }
    }
}
