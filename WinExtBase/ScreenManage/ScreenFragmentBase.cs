using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WinExtBase
{
    //[ContextClass("ФрагментЭкрана", "ScreenFragment")]
    public class ScreenFragmentBase
    {
        private int top;
        private int left;
        private int height;
        private int width;


        //[ContextProperty("Верх", "Top")]
        public int Top
        {
            get { return this.top; }
        }

        //[ContextProperty("Лево", "Left")]
        public int Left
        {
            get { return this.left; }
        }

        //[ContextProperty("Высота", "Height")]
        public int Height
        {
            get { return this.height; }
        }

        //[ContextProperty("Ширина", "Width")]
        public int Width
        {
            get { return this.width; }
        }

        public ScreenFragmentBase(int posX, int posY, int height, int width)
        {
            this.top = posY;
            this.left = posX;
            this.height = height;
            this.width = width;
        }

        public override string ToString()
        {
            return "ФрагментЭкрана";
        }
    }
}
