using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4
{
    class Presenter
    {
        MainWindow mainWindow;
        Model method;
        public Presenter(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;//после инициализации в конструкторе поле mainWindow будет содержать все элементы класса MainWindow.
            method = new Model();
            this.mainWindow.AddEvent += new EventHandler(mainWindow_AddEvent);
            this.mainWindow.SubEvent += new EventHandler(mainWindow_SubEvent);
            this.mainWindow.MultiEvent += mainWindow_MultiEvent;    // предположение делегата.
            this.mainWindow.DivEvent += new EventHandler(mainWindow_DivEvent);
        }
        void mainWindow_AddEvent(object sender, System.EventArgs e) //что в аргументе!- объект события:клопка,+
        {                                                           // Text1  -это имя текстбокса.
            this.mainWindow.Text1.Text = this.method.Addition(decimal.Parse(this.mainWindow.numeral), decimal.Parse(this.mainWindow.Text2.Text)).ToString();
        }
        void mainWindow_SubEvent(object sender, System.EventArgs e)
        {
            this.mainWindow.Text1.Text = this.method.Subtraction(decimal.Parse(this.mainWindow.numeral), decimal.Parse(this.mainWindow.Text2.Text)).ToString();
        }
        void mainWindow_MultiEvent(object sender, System.EventArgs e)
        {
            this.mainWindow.Text1.Text = this.method.Multiplication(decimal.Parse(this.mainWindow.numeral), decimal.Parse(this.mainWindow.Text2.Text)).ToString();
        }
        void mainWindow_DivEvent(object sender, System.EventArgs e)
        {
            if (this.mainWindow.Text2.Text == "0")
                this.mainWindow.Text1.Text = "Err";
            else
                this.mainWindow.Text1.Text = this.method.Division(decimal.Parse(this.mainWindow.numeral), decimal.Parse(this.mainWindow.Text2.Text)).ToString();
        }
    }
}
