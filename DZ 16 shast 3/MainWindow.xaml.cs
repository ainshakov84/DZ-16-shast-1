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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DZ_16_shast_3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, RoutedEventArgs e)

        {
            DoubleAnimation doubleAnimation = new DoubleAnimation();
            // doubleAnimation.By=10; //увиличивает размер кнопки на 10
            doubleAnimation.To=500;
            doubleAnimation.Duration=TimeSpan.FromSeconds(2);
            //doubleAnimation.RepeatBehavior= new RepeatBehavior(TimeSpan.FromSeconds(6));// анимация произойдет 3 раза
            // doubleAnimation.AccelerationRatio=0.5;//ускорение аналогично замедление
            //doubleAnimation.SpeedRatio=0.5;//замедление в 2 раза
            // doubleAnimation.AutoReverse=true;// задает цикл
            doubleAnimation.FillBehavior= FillBehavior.Stop;// возвращет в исходное значение

            btn.BeginAnimation(Button.WidthProperty, doubleAnimation);
            btn.BeginAnimation(Button.HeightProperty, doubleAnimation);

            ColorAnimation colorAnimation = new ColorAnimation();
            colorAnimation.From = Colors.Red;
            colorAnimation.To = Colors.Blue;
            colorAnimation.Duration = TimeSpan.FromSeconds(10);
            btn.Background = new SolidColorBrush(Colors.Red);
            btn.BeginAnimation(SolidColorBrush.ColorProperty, colorAnimation);
        }
    }
}
