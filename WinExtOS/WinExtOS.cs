using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ScriptEngine.HostedScript.Library;
using ScriptEngine.Machine;
using ScriptEngine.Machine.Contexts;
using System.Drawing;
using System.Windows.Forms;

namespace WinExtOS
{
    [ContextClass("Экран", "Sreen")]
    public class WinExtOS : AutoContext<WinExtOS>
    {
        private WinExtBase.WinExtBase _winextBase;

        public WinExtOS()
        {
            _winextBase = new WinExtBase.WinExtBase();
        }

        [ScriptConstructor]
        public static IRuntimeContextInstance Constructor()
        {
            return new WinExtOS();
        }

        [ContextMethod("НажатьКлавиши", "PressKeys")]
        public void OriginalSendKeys(string keys)
        {
            _winextBase.MSSendKeys.OriginalSendKeys(keys);
        }

        [ContextMethod("НажатьCtrlG", "PressCtrlG")]
        public void SendCtrlG()
        {
            _winextBase.MSSendKeys.SendCtrlG();
        }

        [ContextMethod("НажатьCtrlF", "PressCtrlF")]
        public void SendCtrlF()
        {
            _winextBase.MSSendKeys.SendCtrlF();
        }

        [ContextMethod("НажатьCtrlA", "PressCtrlA")]
        public void SendCtrlA()
        {
            _winextBase.MSSendKeys.SendCtrlA();
        }

        [ContextMethod("НажатьCtrlO", "PressCtrl0")]
        public void SendCtrlO()
        {
            _winextBase.MSSendKeys.SendCtrlO();
        }

        [ContextMethod("НажатьCtrlQ", "PressCtrlQ")]
        public void SendCtrlQ()
        {
            _winextBase.MSSendKeys.SendCtrlQ();
        }

        [ContextMethod("НажатьCtrlT", "PressCtrlT")]
        public void SendCtrlT()
        {
            _winextBase.MSSendKeys.SendCtrlT();
        }

        [ContextMethod("НажатьКвадратнуюСкобкуЛевую", "PressCtrlSquareBracketLeft")]
        public void SendCtrlSquareBracketLeft()
        {
            _winextBase.MSSendKeys.SendCtrlSquareBracketLeft();
        }

        [ContextMethod("НажатьКвадратнуюСкобкуПравую", "PressCtrlSquareBracketRight")]
        public void SendCtrlSquareBracketRight()
        {
            _winextBase.MSSendKeys.SendCtrlSquareBracketRight();
        }


        [ContextMethod("НажатьCtrlIns", "PressCtrlIns")]
        public void SendCtrlInsert()
        {
            _winextBase.MSSendKeys.SendCtrlInsert();
        }

        [ContextMethod("НажатьЛевуюКнопкуМыши")]
        public void LeftMouseClick(int xpos, int ypos)
        {
            _winextBase.Mouse.LeftMouseClick(xpos, ypos);
        }

        //This simulates a left mouse click
        [ContextMethod("НажатьПравуюКнопкуМыши")]
        public void RightMouseClick(int xpos, int ypos)
        {
            _winextBase.Mouse.RightMouseClick(xpos, ypos);
        }

        //This simulates a left mouse click
        [ContextMethod("НажатьСреднююКнопкуМыши")]
        public void MiddleMouseClick(int xpos, int ypos)
        {
            _winextBase.Mouse.MiddleMouseClick(xpos, ypos);
        }

        [ContextMethod("УстановитьТекущуюПозициюКурсора")]
        public bool SetCursorPosition(int posX, int posY)
        {
            return _winextBase.Mouse.SetCursorPosition(posX, posY);
        }

        [ContextMethod("ПолучитьТекущуюПозициюКурсора")]
        public IValue GetCursorPosition()
        {
            Point pos = _winextBase.Mouse.GetCursorPosition();
            StructureImpl strct = new StructureImpl();
            strct.Insert("Верх", ValueFactory.Create(pos.Y));
            strct.Insert("Лево", ValueFactory.Create(pos.X));
            FixedStructureImpl FixStruct = new FixedStructureImpl(strct);

            return FixStruct;
        }

        [ContextMethod("ПолучитьРазрешениеЭкрана")]
        public IValue ScreenResolution(int SreenNumber = 0)
        {
            Size resolution = _winextBase.Screen.ScreenResolution(0);

            StructureImpl strct = new StructureImpl();
            strct.Insert("Ширина", ValueFactory.Create(resolution.Width));
            strct.Insert("Высота", ValueFactory.Create(resolution.Height));
            FixedStructureImpl FixStruct = new FixedStructureImpl(strct);

            return FixStruct;
        }

        [ContextMethod("НайтиФрагмент", "FindFragment")]
        public IValue findFragment(string fragmentFileName)
        {
            WinExtBase.ScreenFragmentBase fragment = _winextBase.Screen.findFragment(fragmentFileName);

            if (fragment == null)
            {
                return ValueFactory.Create();
            }

            ScreenFragment screenFragment = new ScreenFragment(fragment.Left, fragment.Top, fragment.Height, fragment.Width);

            return screenFragment;
        }

        [ContextMethod("ПолучитьТекстПоля")]
        public string GetModuleText()
        {
            return _winextBase.WorkWithText.GetModuleText();
        }

        [ContextMethod("ЗапомнитьТекущееОкно")]
        public void GetLinkToCurWindow()
        {
            _winextBase.WorkWithWindows.GetLinkToCurWindow();
        }

        [ContextMethod("АктивироватьЗапомненноеОкно")]
        public void WndActivate()
        {
            _winextBase.WorkWithWindows.WndActivate();
        }

        [ContextMethod("АктивироватьОкноПоЗаголовку", "SwitchToWinByTitle")]
        public bool SwitchToWin(string WinTitle)
        {
            return _winextBase.WorkWithWindows.SwitchToWin(WinTitle);
        }

        [ContextMethod("Подождать", "Sleep")]
        public void Sleep(int milliseconds)
        {
            _winextBase.Sleep(milliseconds);
        }
    }
}
