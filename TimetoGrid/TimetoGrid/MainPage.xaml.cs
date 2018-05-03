using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x804 上介绍了“空白页”项模板

namespace TimetoGrid
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {            
            TimeSpan timePreValue = timeTimePicker.Time;//怎么输入一个名字 Name
            string timeDealtValue = timePreValue.ToString();

            int hourValue = TimeTransform(timeDealtValue)[0];
            int minuteValue = TimeTransform(timeDealtValue)[1];

            //计算部分 也使用一个方法写
            gridTextBlockH.Text = hourValue.ToString();
            gridTextBlockM.Text = minuteValue.ToString();

            int testValue = 60 * hourValue + minuteValue;

            testTextBlock.Text = testValue.ToString();
            testRelativePanel.Height = testValue/10;

            timeBlock0.Height = testValue%480;

            //显示时间
            oneRelativePanel.Text = timeDealtValue.Substring(0, 5);

            //TODO: 换行，两个时间之差
        }

        public static int[] TimeTransform(string timeDealtValue)
        {
            int hourValue = Int32.Parse(timeDealtValue.Substring(0, 2));
            int minuteValue = Int32.Parse(timeDealtValue.Substring(3, 2));

            int[] HourAndMinute= { hourValue, minuteValue};
            return HourAndMinute;            
        }

    }
}
