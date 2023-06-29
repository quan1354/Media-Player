using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_MediaPlayer.Window
{
    public interface IWindowResizer {
        event Action<WindowDockPosition> WindowDockChanged;
    }
}
