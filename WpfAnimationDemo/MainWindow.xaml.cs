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
using System.Windows.Media.Animation;

namespace WpfAnimationDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //DoubleAnimation da = new DoubleAnimation();
            ////da.From = 50;
            //da.To = 100;
            //da.SpeedRatio = 2;
            ////da.AutoReverse = true;
            //da.AccelerationRatio = 1;
            ////da.DecelerationRatio = 0.5;
            //da.IsCumulative = true;
            //da.RepeatBehavior =new RepeatBehavior(2);
            //da.FillBehavior = FillBehavior.Stop;
            //da.Duration = new Duration(TimeSpan.FromSeconds(5));
            ////this.BeginAnimation(Window.HeightProperty, da);
            ////开始动画
            //Btn.BeginAnimation(Button.WidthProperty, da);
            for(int i=0;i<25;i++)
            {
                Button bt = new Button();
                bt.Content = i.ToString();
                Sp.Children.Add(bt);
            }
        }
    }
}
