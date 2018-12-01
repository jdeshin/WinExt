using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;

namespace WinExtCOM
{
    [Guid("0F6DD1C7-7EB0-4259-A711-47BEFC1C91A2"),
        ClassInterface(ClassInterfaceType.None),
        ComSourceInterfaces(typeof(WinExtCOMEvents))]
     public class WinExtCOM : WinExtCOMInterface
    {
        private WinExtBase.WinExtBase _winextBase;
        private System.Drawing.Point _mousePosition;
        public int MousePositionX
        {
            get
            {
                return _mousePosition.X;
            }
        }
        public int MousePositionY
        {
            get
            {
                return _mousePosition.Y;
            }
        }
        private Size _screenResolution;
        public int ScreenResolutionHeight
        {
            get
            {
                return _screenResolution.Height;
            }
        }
        public int ScreenResolutionWidth
        {
            get
            {
                return _screenResolution.Width;
            }
        }
        private WinExtBase.ScreenFragmentBase _screenFragment;
        public int ScreenFragmentLeft
        {
            get
            {
                return _screenFragment.Left;
            }
        }
        public int ScreenFragmentTop
        {
            get
            {
                return _screenFragment.Top;
            }
        }
        public int ScreenFragmentHeight
        {
            get
            {
                return _screenFragment.Height;
            }
        }
        public int ScreenFragmentWidth
        {
            get
            {
                return _screenFragment.Width;
            }
        }
        public bool IsScreenFragmentFound
        {
            get
            {
                return _screenFragment != null;
            }
        }

        public WinExtCOM()
        {
            _winextBase = new WinExtBase.WinExtBase();
        }

        // Интерфейсные функции
        // Отправка нажатий клавиш
        //[ContextMethod("ПослатьКлавиши", "SendKeys")]
        public void OriginalSendKeys(string keys)
        {
            _winextBase.MSSendKeys.OriginalSendKeys(keys);
        }

        //[ContextMethod("ПослатьCtrlG", "SendCtrlG")]
        public void SendCtrlG()
        {
            _winextBase.MSSendKeys.SendCtrlG();
        }

        //[ContextMethod("ПослатьCtrlF", "SendCtrlF")]
        public void SendCtrlF()
        {
            _winextBase.MSSendKeys.SendCtrlF();
        }

        //[ContextMethod("ПослатьCtrlA", "SendCtrlA")]
        public void SendCtrlA()
        {
            _winextBase.MSSendKeys.SendCtrlA();
        }

        //[ContextMethod("ПослатьCtrlO", "SendCtrl0")]
        public void SendCtrlO()
        {
            _winextBase.MSSendKeys.SendCtrlO();
        }

        //[ContextMethod("ПослатьCtrlQ", "SendCtrlQ")]
        public void SendCtrlQ()
        {
            _winextBase.MSSendKeys.SendCtrlQ();
        }

        //[ContextMethod("ПослатьCtrlT", "SendCtrlT")]
        public void SendCtrlT()
        {
            _winextBase.MSSendKeys.SendCtrlT();
        }

        //[ContextMethod("ПослатьКвадратнуюСкобкуЛевую", "SendCtrlSquareBracketLeft")]
        public void SendCtrlSquareBracketLeft()
        {
            _winextBase.MSSendKeys.SendCtrlSquareBracketLeft();
        }

        //[ContextMethod("ПослатьКвадратнуюСкобкуПравую", "SendCtrlSquareBracketRight")]
        public void SendCtrlSquareBracketRight()
        {
            _winextBase.MSSendKeys.SendCtrlSquareBracketRight();
        }

        //[ContextMethod("ПослатьКонтролИнсерт", "SendCtrlInsert")]
        public void SendCtrlInsert()
        {
            _winextBase.MSSendKeys.SendCtrlInsert();
        }

        // работа с мышью
        //[ContextMethod("ЛеваяКнопкаКлик")]
        public void LeftMouseClick(int xpos, int ypos)
        {
            _winextBase.Mouse.LeftMouseClick(xpos, ypos);
        }

        //This simulates a left mouse click
        //[ContextMethod("ПраваяКнопкаКлик")]
        public void RightMouseClick(int xpos, int ypos)
        {
            _winextBase.Mouse.RightMouseClick(xpos, ypos);
        }

        //This simulates a left mouse click
        //[ContextMethod("СредняяКнопкаКлик")]
        public void MiddleMouseClick(int xpos, int ypos)
        {
            _winextBase.Mouse.MiddleMouseClick(xpos, ypos);
        }

        //[ContextMethod("УстановитьПозициюКурсора")]
        public bool SetMouseCursorPosition(int posX, int posY)
        {
            return _winextBase.Mouse.SetCursorPosition(posX, posY);
        }

        //[ContextMethod("ПолучитьПозициюКурсора")]
        public void GetMouseCursorPosition()
        {
            _mousePosition = _winextBase.Mouse.GetCursorPosition();
        }
        
        // работа с экраном
        //[ContextMethod("РазрешениеЭкрана")]
        public void GetScreenResolution(int screenNumber = 0)
        {
            _screenResolution = _winextBase.Screen.ScreenResolution(screenNumber);
        }

        //[ContextMethod("НайтиФрагмент", "FindFragment")]
        public void FindScreenFragment(string fragmentFileName)
        {
            _screenFragment = _winextBase.Screen.findFragment(fragmentFileName);
        }

        //работа с текстом
        //[ContextMethod("ПолучитьТекстПоля")]
        public string GetModuleText()
        {
            return _winextBase.WorkWithText.GetModuleText();
        }

        //[ContextMethod("ЗапомнитьТекущееОкно")]
        // функция есть в разделе работы с окнами
        //public void GetLinkToCurWindow()
        //{
        //    _winextBase.WorkWithText.GetLinkToCurWindow();
        //}

        //[ContextMethod("АктивироватьЗапомненноеОкно")]
        // функция есть в разделе работы с окнами
        //public void WndActivate()
        //{
        //    _winextBase.WorkWithText.WndActivate();
        //}

        // работа с окном
        //[ContextMethod("ЗапомнитьТекущееОкно")]
        public void GetLinkToCurWindow()
        {
            _winextBase.WorkWithWindows.GetLinkToCurWindow();
        }

        //[ContextMethod("АктивироватьЗапомненноеОкно")]
        public void WndActivate()
        {
            _winextBase.WorkWithWindows.WndActivate();
        }

        //[ContextMethod("АктивироватьОкноПоЗаголовку", "SwitchToWinByTitle")]
        public bool SwitchToWin(string WinTitle)
        {
            return _winextBase.WorkWithWindows.SwitchToWin(WinTitle);
        }

        // Прочие функции
        public void Sleep(int milliseconds)
        {
            _winextBase.Sleep(milliseconds);
        }

    }

    [Guid("17EBBACB-29F5-41B3-9459-819D667CE786")]
    public interface WinExtCOMInterface
    {
        int MousePositionX { get; }
        int MousePositionY { get; }
        int ScreenResolutionHeight { get; }
        int ScreenResolutionWidth { get; }
        bool IsScreenFragmentFound { get; }
        int ScreenFragmentLeft { get; }
        int ScreenFragmentTop { get; }
        int ScreenFragmentHeight { get; }
        int ScreenFragmentWidth { get; }

        // Интерфейсные функции
        // Отправка нажатий клавиш
        //[ContextMethod("ПослатьКлавиши", "SendKeys")]
        void OriginalSendKeys(string keys);

        //[ContextMethod("ПослатьCtrlG", "SendCtrlG")]
        void SendCtrlG();

        //[ContextMethod("ПослатьCtrlF", "SendCtrlF")]
        void SendCtrlF();

        //[ContextMethod("ПослатьCtrlA", "SendCtrlA")]
        void SendCtrlA();

        //[ContextMethod("ПослатьCtrlO", "SendCtrl0")]
        void SendCtrlO();

        //[ContextMethod("ПослатьCtrlQ", "SendCtrlQ")]
        void SendCtrlQ();

        //[ContextMethod("ПослатьCtrlT", "SendCtrlT")]
        void SendCtrlT();

        //[ContextMethod("ПослатьКвадратнуюСкобкуЛевую", "SendCtrlSquareBracketLeft")]
        void SendCtrlSquareBracketLeft();

        //[ContextMethod("ПослатьКвадратнуюСкобкуПравую", "SendCtrlSquareBracketRight")]
        void SendCtrlSquareBracketRight();

        //[ContextMethod("ПослатьКонтролИнсерт", "SendCtrlInsert")]
        void SendCtrlInsert();

        // работа с мышью
        //[ContextMethod("ЛеваяКнопкаКлик")]
        void LeftMouseClick(int xpos, int ypos);

        //This simulates a left mouse click
        //[ContextMethod("ПраваяКнопкаКлик")]
        void RightMouseClick(int xpos, int ypos);

        //This simulates a left mouse click
        //[ContextMethod("СредняяКнопкаКлик")]
        void MiddleMouseClick(int xpos, int ypos);

        //[ContextMethod("УстановитьПозициюКурсора")]
        bool SetMouseCursorPosition(int posX, int posY);

        //[ContextMethod("ПолучитьПозициюКурсора")]
        void GetMouseCursorPosition();

        // работа с экраном
        //[ContextMethod("РазрешениеЭкрана")]
        void GetScreenResolution(int screenNumber = 0);

        //[ContextMethod("НайтиФрагмент", "FindFragment")]
        void FindScreenFragment(string fragmentFileName);

        //работа с текстом
        //[ContextMethod("ПолучитьТекстПоля")]
        string GetModuleText();

        // работа с окном
        //[ContextMethod("ЗапомнитьТекущееОкно")]
        void GetLinkToCurWindow();

        //[ContextMethod("АктивироватьЗапомненноеОкно")]
        void WndActivate();

        //[ContextMethod("АктивироватьОкноПоЗаголовку", "SwitchToWinByTitle")]
        bool SwitchToWin(string WinTitle);

        void Sleep(int milliseconds);

    }

    [Guid("E02CB732-EBCE-4562-A0F7-15790829A672"),
        InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public interface WinExtCOMEvents
    {
    }
}
