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

namespace Zadanie4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string numeral;
        public EventHandler eventHandler;
        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }

        private void a1_Click(object sender, RoutedEventArgs e)
        {
            if (Text2.Text == "0")
                Text2.Text = "1";
            else Text2.Text = Text2.Text + "1";
            if (eventHandler == null)
                Text1.Text = "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Text2.Text == "0")
                Text2.Text = "2";
           else Text2.Text = Text2.Text + "2";
            if (eventHandler == null)
                Text1.Text = "";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Text2.Text == "0")
                Text2.Text = "3";
           else Text2.Text = Text2.Text + "3";
            if (eventHandler == null)
                Text1.Text = "";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (Text2.Text == "0")
                Text2.Text = "4";
            else Text2.Text = Text2.Text + "4";
            if (eventHandler == null)
                Text1.Text = "";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (Text2.Text == "0")
                Text2.Text = "5";
            else Text2.Text = Text2.Text + "5";
            if (eventHandler == null)
                Text1.Text = "";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (Text2.Text == "0")
                Text2.Text = "6";
            else Text2.Text = Text2.Text + "6";
            if (eventHandler == null)
                Text1.Text = "";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (Text2.Text == "0")
                Text2.Text = "7";
            else Text2.Text = Text2.Text + "7";
            if (eventHandler == null)
                Text1.Text = "";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (Text2.Text == "0")
                Text2.Text = "8";
            else Text2.Text = Text2.Text + "8";
            if (eventHandler == null)
                Text1.Text = "";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (Text2.Text == "0")
                Text2.Text = "9";
            else Text2.Text = Text2.Text + "9";
            if (eventHandler == null)
                Text1.Text = "";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            if (Text2.Text == "0")
                Text2.Text = "0";
            else Text2.Text = Text2.Text + "0";
            if (eventHandler == null)
                Text1.Text = "";
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            eventHandler = null;
            Text2.Text = "0";
            Text1.Text = "";
        }

        public event EventHandler AddEvent = null;
        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            if (Text2.Text != "")       // защита от повторного вызова арифметического метода - события.
            {
                if ((Text1.Text == "")|| (Text1.Text.StartsWith("Err"))||(eventHandler==null))//первоначально невызываем арифм.метод -событие. Присваиваем значения...
                {
                    eventHandler = AddEvent;//.Invoke(sender, e);// нельзя ли в данных перенаправления события 'e', передать значение 'numeral';
                    numeral = Text2.Text;
                    Text1.Text = Text2.Text + "+";
                    Text2.Text = "";
                }
                else
                {
                    eventHandler.Invoke(sender, e); //запустится необязательно AddEvent,а метод сохраненный в переменной eventHandler.
                    if (Text1.Text.StartsWith("Err"))
                        eventHandler = null;
                    else eventHandler = AddEvent; // а потом в переменную запишется собыытие AddEvent.
                    numeral = Text1.Text;
                    Text1.Text = Text1.Text + "+";
                    Text2.Text = "";
                }
            }
        }
        public event EventHandler SubEvent = null;
        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            if (Text2.Text != "")
            { 
                if ((Text1.Text == "")|| (Text1.Text.StartsWith("Err"))|| (eventHandler == null))
                {
                    eventHandler = SubEvent;
                    numeral = Text2.Text;
                    Text1.Text = Text2.Text + "-";
                    Text2.Text = "";
                }
                else
                {                       //вызываем событие, если имеется значение в Text1.Можно проверить подписано ли событие:if(eventHandler != null)(выше)
                    eventHandler.Invoke(sender, e); //запустится необязательно SubEvent,а метод сохраненный в переменной eventHandler.
                    if (Text1.Text.StartsWith("Err"))
                        eventHandler = null;
                    else eventHandler = SubEvent;     // а потом в переменную запишется собыытие SubEvent.
                    numeral = Text1.Text;
                    Text1.Text = Text1.Text + "-";
                    Text2.Text = "";
                }
            }
        }
        public event EventHandler MultiEvent = null;
        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            if (Text2.Text != "")    // если и Text1.Text=Err, то заходим и меняем арифм. метод.
            {
                if ((Text1.Text == "") || (Text1.Text.StartsWith("Err")) || (eventHandler == null))
                {
                    eventHandler = MultiEvent;//.Invoke(sender, e);// нельзя ли в данных перенаправления события 'e', передать значение 'numeral';
                    numeral = Text2.Text;
                    Text1.Text = Text2.Text + "*";
                    Text2.Text = "";
                }
                else
                {
                    eventHandler.Invoke(sender, e); //запустится необязательно AddEvent,а метод сохраненный в переменной eventHandler.
                    if (Text1.Text.StartsWith("Err"))
                        eventHandler = null;
                    else eventHandler = MultiEvent; // а потом в переменную запишется собыытие AddEvent.
                    numeral = Text1.Text;
                    Text1.Text = Text1.Text + "*";
                    Text2.Text = "";
                }
            }
        }
        public event EventHandler DivEvent = null;
        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            if (Text2.Text != "")
            {
                if ((Text1.Text == "") || (Text1.Text.StartsWith("Err")) || (eventHandler == null))
                {
                    eventHandler = DivEvent;
                    numeral = Text2.Text;
                    Text1.Text = Text2.Text + "/";
                    Text2.Text = "";
                }
                else
                {
                    eventHandler.Invoke(sender, e);
                    if (Text1.Text.StartsWith("Err"))
                        eventHandler = null;
                    else eventHandler = DivEvent; 
                    numeral = Text1.Text;
                    Text1.Text = Text1.Text + "/";
                    Text2.Text = "";
                }
            }
        }
        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            if ((Text2.Text != "") && (!Text1.Text.StartsWith("Err")) && (Text1.Text != "") && (eventHandler != null))
            {
                eventHandler.Invoke(sender, e);
                Text2.Text = "";
            }
            else
            {
                Text1.Text = Text2.Text;
                Text2.Text = "";
            }
            eventHandler = null;

        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            if (Text2.Text == "")
                Text2.Text = "0,";
            else Text2.Text = Text2.Text + ",";
            if (eventHandler == null)
                Text1.Text = "";
        }
    }
}
//https://metanit.com/sharp/wpf/5.5.php
//Для изменения параметров отображаемого текста данный элемент имеет такие свойства, как LineHeight, TextWrapping и TextAlignment.

//Свойство LineHeight позволяет указывать высоту строк.

//Свойство TextWrapping позволяет переносить текст при установке этого свойства TextWrapping="Wrap". По умолчанию это свойство имеет значение NoWrap, поэтому текст не переносится.

//Свойство TextAlignment выравнивает текст по центру (значение Center), правому(Right) или левому краю (Left): < TextBlock TextAlignment = "Right" >

//Для декорации текста используется свойство TextDecorations, например, если TextDecorations="Underline", то текст будет подчеркнут.

//Если нам вдруг потребуется перенести текст на другую строку, то тогда мы можем использовать элемент LineBreak
