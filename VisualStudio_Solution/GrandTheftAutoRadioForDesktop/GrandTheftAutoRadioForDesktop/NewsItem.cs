using AxWMPLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandTheftAutoRadioForDesktop
{
    class NewsItem : AudioFile, IPlayable
    {
        private readonly List<AudioFile> NewsIntros;

        public NewsItem(string pathToFile, List<AudioFile> intros) : base("NewsItem", pathToFile) //CONSTRUCTOR
        {
            NewsIntros = intros;
        }

        public async Task Play(AxWindowsMediaPlayer player)
        {
            if (NewsIntros.Count > 0)
            {
                int numberOfIntro = Radio.rnd.Next(0, NewsIntros.Count); //Randomly select an intro from the list
                string introFilePath = NewsIntros.ElementAt(numberOfIntro).fullPath;
                player.URL = introFilePath;
                await Radio.PlayAfterThis();
            }

            player.URL = fullPath;
            await Radio.PlayAfterThis();
        }
    }
}