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
        private readonly Random rnd = new Random();
        private readonly List<AudioFile> NewsIntros;

        public NewsItem(string pathToFile, List<AudioFile> intros) : base("NewsItem", pathToFile) //CONSTRUCTOR
        {
            NewsIntros = intros;
        }

        public async Task Play(AxWindowsMediaPlayer player)
        {
            int numberOfIntro = rnd.Next(NewsIntros.Count); //Randomly select an intro from the list
            string introFilePath = NewsIntros.ElementAt(numberOfIntro).fullPath;
            player.URL = introFilePath;

            //This task is necessary because the while (!audioFileFinished) will otherwise run in the UI and hang the app.
            await Radio.PlayAfterThis();
            player.URL = fullPath;
            await Radio.PlayAfterThis();
        }
    }
}
