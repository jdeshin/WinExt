using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinExtBase
{
    public class WinExtBase
    {
        // Отправка нажатий
        private MSSendKeysBase _sendkeys;
        public MSSendKeysBase MSSendKeys
        {
            get
            {
                return _sendkeys;
            }
        }

        // Работа с мышью
        private MouseBase _mouse;
        public MouseBase Mouse
        {
            get
            {
                return _mouse;
            }
        }

        // работа с окнами
        private WorkWithWindowsBase _window;
        public WorkWithWindowsBase WorkWithWindows
        {
            get
            {
                return _window;
            }
        }
        
        // работа с текстом
        private WorkWithTextBase _text;
        public WorkWithTextBase WorkWithText
        {
            get
            {
                return _text;
            }
        }
        
        // работа с экраном
        private ScreenBase _screen;
        public ScreenBase Screen
        {
            get
            {
                return _screen;
            }
        }
        
        public void Sleep(int milliseconds)
        {
            System.Threading.Thread.Sleep(milliseconds);
        }
        public WinExtBase()
        {
            _sendkeys = new MSSendKeysBase();
            _mouse = new MouseBase();
            _window = new WorkWithWindowsBase();
            _text = new WorkWithTextBase();
            _screen = new ScreenBase();
        }
    }
}
