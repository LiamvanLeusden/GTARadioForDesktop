using AxWMPLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandTheftAutoRadioForDesktop
{
    public class Stinger : AudioFile, IPlayable //TODO: This is public only for unit testing.
    {
        public Stinger(string pathToFile) : base("Stinger", pathToFile) //CONSTRUCTOR
        {

        }

        public async Task Play(AxWindowsMediaPlayer player)
        {
            player.URL = fullPath;
            await Radio.PlayAfterThis();
        }
    }
}
