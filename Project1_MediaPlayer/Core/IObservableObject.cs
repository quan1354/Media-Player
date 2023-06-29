using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_MediaPlayer
{ 
    public class IObservableObject
    {
        event PropertyChangedEventHandler PropertyChanged;
    }
}
