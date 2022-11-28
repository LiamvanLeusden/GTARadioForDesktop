using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;
using AxWMPLib;

namespace GrandTheftAutoRadioForDesktop
{
    class Song : AudioFile, IPlayable //This is public only for unit testing.
    {
        private readonly List<AudioFile> songIntros = new List<AudioFile>();
        private string SongName { get; set; }  //This is public only for unit testing.
        private readonly Random rnd = new Random();

        public Song(string pathToSong, string pathToRadioFolder) : base("Song", pathToSong) //CONSTRUCTOR
        {
            //Get song name from file path
            int first = pathToSong.IndexOf("SONG_") + 5; //5 is the length of SONG_. To get the correct start of the song name, it must be added.
            int last = pathToSong.LastIndexOf(".wav");
            SongName = pathToSong.Substring(first, last - first);

            //Get song intros and add them to a list
            string[] files = System.IO.Directory.GetFiles(pathToRadioFolder);
            foreach (string filePath in files)
            {
                if (filePath.Contains(SongName) && filePath.Contains("\\INTRO_"))
                {
                    SongIntro songIntro = new SongIntro(filePath);
                    songIntros.Add(songIntro);
                }
            }
        }

        public async Task Play(AxWindowsMediaPlayer player)
        {
            //TODO: Make it a possibility to play a song without an intro (lower probability?)
            if (songIntros.Count != 0)
            {
                int numberOfIntro = rnd.Next(songIntros.Count); //Randomly select an intro from the list
                string introFilePath = songIntros.ElementAt(numberOfIntro).fullPath;
                player.URL = introFilePath;
            }
            else
            {
                Radio.AudioFileFinished = true;
            }

            //This task is necessary because the while (!audioFileFinished) will otherwise run in the UI and hang the app.
            await Radio.PlayAfterThis();
            player.URL = fullPath;
            await Radio.PlayAfterThis();
        }
    }
}
