using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Calc
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int numTemp1, numTemp2;
        private void num1_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextChange[] change = new TextChange[e.Changes.Count];
            e.Changes.CopyTo(change, 0);                
            int offset = change[0].Offset;
            if (change[0].AddedLength > 0)
            {
                bool num1Trans = Int32.TryParse(num1.Text, out numTemp1);
                if (num1Trans == false)
                {
                    num1result.Text = "非法";
                }
                else
                {
                    num1result.Text = null;
                }
            }
        }

        private void num2_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextChange[] change = new TextChange[e.Changes.Count];
            e.Changes.CopyTo(change, 0);
            int offset = change[0].Offset;
            if (change[0].AddedLength > 0)
            {
                bool num2Trans = Int32.TryParse(num2.Text, out numTemp2);
                if (num2Trans == false)
                {
                    num2result.Text = "非法";
                }
                else
                {
                    num2result.Text = null;
                    clacresult.Text = (numTemp1 + numTemp2).ToString();
                }
            }
        }
    }
}
