using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;

namespace WinExtBase
{
    //[ContextClass("РаботаСТекстом", "WorkWithText")]
    public class WorkWithTextBase
    {
        private AutomationElement _curWnd;

        //[ContextMethod("ПолучитьТекстПоля")]
        public string GetModuleText()
        {
            var uia = new UIAuto();
            return uia.GetModuleText();
        }

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
    }
}
