using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;

namespace WinExtBase
{
    //[ContextClass("РаботаСОкнами", "WorkWithWindows")]
    public class WorkWithWindowsBase
    {
        private AutomationElement _curWnd;

        //[ContextMethod("ЗапомнитьТекущееОкно")]
        public void GetLinkToCurWindow()
        {
            var uia = new UIAuto();
            _curWnd = uia.GetCurrentWindow();
        }

        //[ContextMethod("АктивироватьЗапомненноеОкно")]
        public void WndActivate()
        {
            var uia = new UIAuto();
            uia.SetCurrentWindow(_curWnd);
        }

        //[ContextMethod("АктивироватьОкноПоЗаголовку", "SwitchToWinByTitle")]
        public bool SwitchToWin(string WinTitle)
        {
            return ScottsUtils.SwitchToWindow.Switch(WinTitle);
        }

    }
}
