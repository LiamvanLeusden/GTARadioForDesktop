﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AxWMPLib;

namespace GrandTheftAutoRadioForDesktop
{
    public class Radio //TODO: This is public only for unit testing.
    {
        private readonly Random rnd = new Random();
        public static bool AudioFileFinished { get; set; }
        readonly private AxWindowsMediaPlayer localPlayer;
        public static string error = "";
        public bool RadioPlaying { get; set; }

        //There are 5 types of playable items. Each can be set to a priority between 0 and 100, with a higher number being a higher probability
        //It is also possible to have multiple types with the same priority level.
        public static int RATIO_CHANCE_SONG = 75;
        public static int RATIO_CHANCE_STINGER = 50;
        public static int RATIO_CHANCE_QUOTE = 25;
        public static int RATIO_CHANCE_ADVERTISEMENT = 10;
        public static int RATIO_CHANCE_NEWSITEM = 5;

        public static int RATIO_TOTAL = RATIO_CHANCE_SONG + RATIO_CHANCE_STINGER + RATIO_CHANCE_QUOTE + RATIO_CHANCE_ADVERTISEMENT + RATIO_CHANCE_NEWSITEM;

        private readonly List<IPlayable> Songs = new List<IPlayable>();
        private readonly List<IPlayable> Stingers = new List<IPlayable>();
        private readonly List<IPlayable> QuotesGeneral = new List<IPlayable>();
        private readonly List<IPlayable> QuotesMorning = new List<IPlayable>();
        private readonly List<IPlayable> QuotesEvening = new List<IPlayable>();
        private readonly List<IPlayable> NewsItems = new List<IPlayable>();
        private readonly List<AudioFile> NewsIntros = new List<AudioFile>();
        private readonly List<IPlayable> Advertisements = new List<IPlayable>();
        private readonly List<AudioFile> AdvertisementIntros = new List<AudioFile>();

        //In the constructor, all the lists get filled with audio files
        public Radio(AxWindowsMediaPlayer player, string pathToRadioFolder, string pathToRadioExtractFolder) //CONSTRUCTOR
        {
            localPlayer = player;

            string[] radioSpecificFiles = System.IO.Directory.GetFiles(pathToRadioFolder);
            foreach (string filePath in radioSpecificFiles)
            {
                if (filePath.Contains("\\SONG_")) //Song
                {
                    Song song = new Song(filePath, pathToRadioFolder);
                    Songs.Add(song);
                }
                else if (filePath.Contains("\\ID_")) //Stinger
                {
                    Stinger stinger = new Stinger(filePath);
                    Stingers.Add(stinger);
                }
                else if (filePath.Contains("\\GENERAL_") || filePath.Contains("\\MONO_SOLO_")) //General quote
                {
                    Quote generalQuote = new Quote(filePath);
                    QuotesGeneral.Add(generalQuote);
                }
                else if (filePath.Contains("\\MORNING_")) //Morning quote
                {
                    Quote morningQuote = new Quote(filePath);
                    QuotesMorning.Add(morningQuote);
                }
                else if (filePath.Contains("\\EVENING_")) //Evening quote
                {
                    Quote eveningQuote = new Quote(filePath);
                    QuotesEvening.Add(eveningQuote);
                }
                else if (filePath.Contains("\\TO_AD_")) //Advertisement intro
                {
                    ToAdvertisement toAdvertisement = new ToAdvertisement(filePath);
                    AdvertisementIntros.Add(toAdvertisement);
                }
                else if (filePath.Contains("\\TO_NEWS_")) //News intro
                {
                    ToNews toNews = new ToNews(filePath);
                    NewsIntros.Add(toNews);
                }
            }

            //Adverts:
            string[] advertFiles = System.IO.Directory.GetFiles(pathToRadioExtractFolder + "\\RADIO_ADVERTS");
            foreach (string filePath in advertFiles)
            {
                Advertisement advertisement = new Advertisement(filePath, AdvertisementIntros);
                Advertisements.Add(advertisement);
            }
            //News items:
            string[] newsFiles = System.IO.Directory.GetFiles(pathToRadioExtractFolder + "\\RADIO_NEWS");
            foreach (string filePath in newsFiles)
            {
                NewsItem newsItem = new NewsItem(filePath, NewsIntros);
                NewsItems.Add(newsItem);
            }


            error = "";
            RadioPlaying = true;
            StartRadio();
        }

        public void DestructRadio()
        {
            Songs.Clear();
            Stingers.Clear();
            QuotesGeneral.Clear();
            QuotesMorning.Clear();
            QuotesEvening.Clear();
            NewsItems.Clear();
            NewsIntros.Clear();
            Advertisements.Clear();
            AdvertisementIntros.Clear();
        }

        //This method is used to play files after a certain other one. This is necessary because this must run asynchronously and audioFileFinished would not be accessable or updated otherwise.
        public static async Task PlayAfterThis()
        {
            while (!AudioFileFinished) await Task.Delay(50);
        }

        private async void StartRadio()
        {
            while (RadioPlaying)
            {
                await PlayItem();
            }
        }

        private async Task PlayItem()
        {
            int x = rnd.Next(0, RATIO_TOTAL);

            //TODO: Make implementation for non standard radio formats
            //TODO: Make sure two of the same type of item can't play consecutively
            //TODO: Make sure the same song can't play consecutively

            try
            {
                if ((x -= RATIO_CHANCE_SONG) < 0)
                {
                    await Songs.ElementAt(rnd.Next(Songs.Count())).Play(localPlayer);
                }
                else if ((x -= RATIO_CHANCE_STINGER) < 0)
                {
                    await Stingers.ElementAt(rnd.Next(Stingers.Count())).Play(localPlayer);
                }
                else if ((x -= RATIO_CHANCE_QUOTE) < 0)
                {
                    //TODO: Time from computer to do morning or evening
                    await QuotesGeneral.ElementAt(rnd.Next(QuotesGeneral.Count())).Play(localPlayer);
                }
                else if ((x -= RATIO_CHANCE_ADVERTISEMENT) < 0)
                {
                    await Advertisements.ElementAt(rnd.Next(Advertisements.Count())).Play(localPlayer);
                }
                else if ((x -= RATIO_CHANCE_NEWSITEM) < 0)
                {
                    await NewsItems.ElementAt(rnd.Next(NewsItems.Count())).Play(localPlayer);
                }
                else
                {
                    throw new TypeOfFileNotFoundException();
                }
            }
            catch (TypeOfFileNotFoundException)
            {
                error = "Radio error: Type of file not found. You might have wrong probability settings.";
                RadioPlaying = false;
            }
            catch (ArgumentOutOfRangeException)
            {
                error = "Radio error: Argument out of range. You might have an incomplete or invalid radio folder.";
                RadioPlaying = false;
            }
        }
    }
}
