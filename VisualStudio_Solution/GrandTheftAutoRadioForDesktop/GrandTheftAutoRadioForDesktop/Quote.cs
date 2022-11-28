using AxWMPLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandTheftAutoRadioForDesktop
{
    class Quote : AudioFile, IPlayable
    {
        public Quote(string pathToFile) : base("Quote", pathToFile) //CONSTRUCTOR
        {
            
        }

        public async Task Play(AxWindowsMediaPlayer player)
        {
            player.URL = fullPath;
            await Radio.PlayAfterThis();
        }
    }
}