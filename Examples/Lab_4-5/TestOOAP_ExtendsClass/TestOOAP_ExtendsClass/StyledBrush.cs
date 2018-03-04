using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOAP_ExtendsClass
{
    class StyledBrush: BaseBrush
    {
        private BrushStyle _BrushStyle;

        public BrushStyle CurretBrushStyle
        {
            get
            {
                return this._BrushStyle;
            }
            set
            {
                this._BrushStyle = value;
            }
        }

        public StyledBrush(ConsoleColor BrushColor, int BrushSize, string StyleName) : base(BrushColor, BrushSize)
        {
            this.CurretBrushStyle = new BrushStyle(StyleName);
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Стиль кисти: " + CurretBrushStyle);
        }

        public void ShowStyle()
        {
            Console.WriteLine("Стиль кисти: " + CurretBrushStyle);
        }
    }
}
