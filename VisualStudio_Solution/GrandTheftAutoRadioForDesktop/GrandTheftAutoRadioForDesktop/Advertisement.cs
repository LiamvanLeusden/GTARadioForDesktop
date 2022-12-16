using AxWMPLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandTheftAutoRadioForDesktop
{
    class Advertisement : AudioFile, IPlayable
    {
        private readonly Random rnd = new Random();
        private readonly List<AudioFile> AdvertisementIntros;

        public Advertisement(string pathToFile, List<AudioFile> intros) : base("Advertisement", pathToFile) //CONSTRUCTOR
        {
            AdvertisementIntros = intros;
        }

        public async Task Play(AxWindowsMediaPlayer player)
        {
            if (AdvertisementIntros.Count > 0)
            {
                int numberOfIntro = rnd.Next(AdvertisementIntros.Count); //Randomly select an intro from the list
                string introFilePath = AdvertisementIntros.ElementAt(numberOfIntro).fullPath;
                player.URL = introFilePath;
                await Radio.PlayAfterThis();
            }

            player.URL = fullPath;
            await Radio.PlayAfterThis();
        }
    }
}