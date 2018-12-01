﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScottsUtils;
using System.Windows.Forms;

namespace WinExtBase
{
    // [ContextClass("МСПослатьКлавиши", "MSSendKeys")]
    public class MSSendKeysBase
    {

        /// <summary>
        /// Послать нажатия клавиш. Правила: https://docs.microsoft.com/ru-ru/dotnet/api/system.windows.forms.sendkeys?view=netframework-4.7
        /// </summary>
        /// <param name="keys">Строка - набор клавиш</param>
        //[ContextMethod("ПослатьКлавиши", "SendKeys")]
        public void OriginalSendKeys(string keys)
        {
            var kShift = (uint)WinAPI.KeyCode.Shift;
            var kAlt = (uint)WinAPI.KeyCode.Alt;
            var kCtrl = (uint)WinAPI.KeyCode.Control;

            ScottsUtils.Keys.ClearModifiers(ref kShift);
            ScottsUtils.Keys.ClearModifiers(ref kAlt);
            ScottsUtils.Keys.ClearModifiers(ref kCtrl);

            SendKeys.SendWait(keys);
        }

        static public void PressKeyVK(ScottsUtils.WinAPI.KeyCode key)
        {
            PressKeyVK(key, true, true, false);
        }

        static public void PressKeyVK(ScottsUtils.WinAPI.KeyCode key, bool press, bool release, bool compatible)
        {

            uint scanCode = ScottsUtils.WinAPI.MapVirtualKey((uint)key, 0);
            uint extended = IsExtendedKey(key) ? (uint)ScottsUtils.WinAPI.KeybdEventFlag.ExtendedKey : 0;

            if (compatible)
            {
                extended = 0;
            }

            if (press)
            {
                ScottsUtils.WinAPI.keybd_event((byte)key, (byte)scanCode, (ScottsUtils.WinAPI.KeybdEventFlag)extended, 0);
            }

            if (release)
            {
                ScottsUtils.WinAPI.keybd_event((byte)key, (byte)scanCode, (ScottsUtils.WinAPI.KeybdEventFlag)(extended | (uint)ScottsUtils.WinAPI.KeybdEventFlag.KeyUp), 0);
            }
        }

        static public bool IsExtendedKey(ScottsUtils.WinAPI.KeyCode key)
        {
            switch (key)
            {
                case ScottsUtils.WinAPI.KeyCode.Left:
                case ScottsUtils.WinAPI.KeyCode.Up:
                case ScottsUtils.WinAPI.KeyCode.Right:
                case ScottsUtils.WinAPI.KeyCode.Down:
                case ScottsUtils.WinAPI.KeyCode.Prior:
                case ScottsUtils.WinAPI.KeyCode.Next:
                case ScottsUtils.WinAPI.KeyCode.End:
                case ScottsUtils.WinAPI.KeyCode.Home:
                case ScottsUtils.WinAPI.KeyCode.Insert:
                case ScottsUtils.WinAPI.KeyCode.Delete:
                case ScottsUtils.WinAPI.KeyCode.Divide:
                case ScottsUtils.WinAPI.KeyCode.NumLock:
                    return true;

                default:
                    return false;
            }
        }

        //[ContextMethod("ПослатьCtrlG", "SendCtrlG")]
        public void SendCtrlG()
        {
            PressKeyVK(ScottsUtils.WinAPI.KeyCode.Control, true, false, false);
            PressKeyVK(ScottsUtils.WinAPI.KeyCode.LetG, true, false, false);
            PressKeyVK(ScottsUtils.WinAPI.KeyCode.Control, false, true, false);
        }

        //[ContextMethod("ПослатьCtrlF", "SendCtrlF")]
        public void SendCtrlF()
        {
            PressKeyVK(ScottsUtils.WinAPI.KeyCode.Control, true, false, false);
            PressKeyVK(ScottsUtils.WinAPI.KeyCode.LetF, true, false, false);
            PressKeyVK(ScottsUtils.WinAPI.KeyCode.Control, false, true, false);
        }

        //[ContextMethod("ПослатьCtrlA", "SendCtrlA")]
        public void SendCtrlA()
        {
            PressKeyVK(ScottsUtils.WinAPI.KeyCode.Control, true, false, false);
            PressKeyVK(ScottsUtils.WinAPI.KeyCode.LetA, true, false, false);
            PressKeyVK(ScottsUtils.WinAPI.KeyCode.Control, false, true, false);
        }

        //[ContextMethod("ПослатьCtrlO", "SendCtrl0")]
        public void SendCtrlO()
        {
            PressKeyVK(ScottsUtils.WinAPI.KeyCode.Control, true, false, false);
            PressKeyVK(ScottsUtils.WinAPI.KeyCode.LetO, true, false, false);
            PressKeyVK(ScottsUtils.WinAPI.KeyCode.Control, false, true, false);
        }

        //[ContextMethod("ПослатьCtrlQ", "SendCtrlQ")]
        public void SendCtrlQ()
        {
            PressKeyVK(ScottsUtils.WinAPI.KeyCode.Control, true, false, false);
            PressKeyVK(ScottsUtils.WinAPI.KeyCode.LetQ, true, false, false);
            PressKeyVK(ScottsUtils.WinAPI.KeyCode.Control, false, true, false);
        }

        //[ContextMethod("ПослатьCtrlT", "SendCtrlT")]
        public void SendCtrlT()
        {
            PressKeyVK(ScottsUtils.WinAPI.KeyCode.Control, true, false, false);
            PressKeyVK(ScottsUtils.WinAPI.KeyCode.LetT, true, false, false);
            PressKeyVK(ScottsUtils.WinAPI.KeyCode.Control, false, true, false);
        }

        //[ContextMethod("ПослатьКвадратнуюСкобкуЛевую", "SendCtrlSquareBracketLeft")]
        public void SendCtrlSquareBracketLeft()
        {
            PressKeyVK(ScottsUtils.WinAPI.KeyCode.Control, true, false, false);
            PressKeyVK(ScottsUtils.WinAPI.KeyCode.Oem4, true, false, false);
            PressKeyVK(ScottsUtils.WinAPI.KeyCode.Control, false, true, false);
        }

        //[ContextMethod("ПослатьКвадратнуюСкобкуПравую", "SendCtrlSquareBracketRight")]
        public void SendCtrlSquareBracketRight()
        {
            PressKeyVK(ScottsUtils.WinAPI.KeyCode.Control, true, false, false);
            PressKeyVK(ScottsUtils.WinAPI.KeyCode.Oem4, true, false, false);
            PressKeyVK(ScottsUtils.WinAPI.KeyCode.Control, false, true, false);
        }


        //[ContextMethod("ПослатьКонтролИнсерт", "SendCtrlInsert")]
        public void SendCtrlInsert()
        {
            PressKeyVK(ScottsUtils.WinAPI.KeyCode.Control, true, false, false);
            PressKeyVK(ScottsUtils.WinAPI.KeyCode.Insert, true, false, false);
            PressKeyVK(ScottsUtils.WinAPI.KeyCode.Control, false, true, false);
        }

    }
}
