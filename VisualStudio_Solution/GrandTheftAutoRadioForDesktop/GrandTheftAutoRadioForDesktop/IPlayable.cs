using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandTheftAutoRadioForDesktop
{
    interface IPlayable
    {
        //Play method must play the audio file of the host class in the given player.
        //Play method must be an asynchronous method.
        //The last line of the method must be: await Radio.PlayAfterThis();. If not, the radio cannot play an item after this.
        Task Play(AxWMPLib.AxWindowsMediaPlayer player);
    }
}
