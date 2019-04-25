using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace EX45_GUI_03
{
    public sealed class ApplicationViewTitleBar : IApplicationViewTitleBar
    {
        public Nullable<Black> BackgroundColor { get; set; }
        public Nullable<Color> ForegroundColor { get; set; }
    }

    public struct Black
    {

    }

    public interface IApplicationViewTitleBar
    {
    }
    
}
