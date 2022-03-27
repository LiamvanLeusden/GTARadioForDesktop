using GrandTheftAutoRadioForDesktop;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTARadioTest
{
    [TestClass]
    public class StartupTest
    {
        Startup startup = new Startup();

        [TestMethod]
        public void TestSaveAndLoadPreferencesToFile()
        {
            //Set variables:
            string filePath = "C:\\temp\\TestGTARadioConfigFile.txt";
            string pathToRadioFolder = "C:\\";
            int volume = 10;
            Radio.RATIO_CHANCE_SONG = 11;
            Radio.RATIO_CHANCE_STINGER = 12;
            Radio.RATIO_CHANCE_QUOTE = 13;
            Radio.RATIO_CHANCE_NEWSITEM = 14;
            Radio.RATIO_CHANCE_ADVERTISEMENT = 15;

            //Save to file:
            startup.SavePreferencesToFile(filePath, pathToRadioFolder, volume);

            //Clear all variables for testing:
            pathToRadioFolder = null;
            volume = 0;
            Radio.RATIO_CHANCE_SONG = 0;
            Radio.RATIO_CHANCE_STINGER = 0;
            Radio.RATIO_CHANCE_QUOTE = 0;
            Radio.RATIO_CHANCE_NEWSITEM = 0;
            Radio.RATIO_CHANCE_ADVERTISEMENT = 0;

            //Load from saved file:
            pathToRadioFolder = startup.LoadPreferencesFromFile("C:\\temp\\TestGTARadioConfigFile.txt", ref volume);

            //Test if settings are correct:
            Assert.AreEqual(pathToRadioFolder, "C:\\");
            Assert.AreEqual(volume, 10);
            Assert.AreEqual(Radio.RATIO_CHANCE_SONG, 11);
            Assert.AreEqual(Radio.RATIO_CHANCE_STINGER, 12);
            Assert.AreEqual(Radio.RATIO_CHANCE_QUOTE, 13);
            Assert.AreEqual(Radio.RATIO_CHANCE_NEWSITEM, 14);
            Assert.AreEqual(Radio.RATIO_CHANCE_ADVERTISEMENT, 15);
        }

        [TestMethod]
        [ExpectedException(typeof(NumberOfLinesException))]
        public void TestLoadPreferencesFromFileIncorrectLines()
        {
            int volume = 0;

            //This is saving a file except one last line. When reading, this will create an exception.
            using (StreamWriter writer = File.CreateText("C:\\temp\\TestGTARadioConfigFileBad.txt"))
            {
                writer.WriteLine("//GTARadioForDesktop configuration file. If you want to edit this; only edit the lines directly after the lines with colons.");
                writer.WriteLine("");
                writer.WriteLine("");
                writer.WriteLine("RADIO_LOCATION: //Accepted argument = text, full valid file path (For example: D:\\Documents\\GTA_RADIO_EXTRACT)");
                writer.WriteLine("1");
                writer.WriteLine("");
                writer.WriteLine("SET_VOLUME: //Accepted argument = numbers between 0 and 100 (For example 44, NOT 044)");
                writer.WriteLine("1");
                writer.WriteLine("");
                writer.WriteLine("//Following is the probability of different items. Accepted argument = numbers between 0 and 100 (For example 44, NOT 044). They may not all be 0 (at least one must be 1 or higher).");
                writer.WriteLine("");
                writer.WriteLine("SONG_PROBABILITY:");
                writer.WriteLine(Radio.RATIO_CHANCE_SONG);
                writer.WriteLine("");
                writer.WriteLine("STINGER_PROBABILITY:");
                writer.WriteLine(Radio.RATIO_CHANCE_STINGER);
                writer.WriteLine("");
                writer.WriteLine("QUOTE_PROBABILITY:");
                writer.WriteLine(Radio.RATIO_CHANCE_QUOTE);
                writer.WriteLine("");
                writer.WriteLine("NEWS_PROBABILITY:");
                writer.WriteLine(Radio.RATIO_CHANCE_NEWSITEM);
                writer.WriteLine("");
                writer.WriteLine("ADVERTISEMENT_PROBABILITY:");
                writer.WriteLine(Radio.RATIO_CHANCE_ADVERTISEMENT);
                writer.Close();
            }

            string pathToRadioFolder = startup.LoadPreferencesFromFile("C:\\temp\\TestGTARadioConfigFileBad.txt", ref volume);
        }

        [TestMethod]
        public void TestGetStationNameCorrect()
        {
            Assert.AreEqual(startup.GetStationName(0), "RADIO_01_CLASS_ROCK");
            Assert.AreEqual(startup.GetStationName(1), "RADIO_02_POP");
            Assert.AreEqual(startup.GetStationName(2), "RADIO_03_HIPHOP_NEW");
            Assert.AreEqual(startup.GetStationName(3), "RADIO_04_PUNK");
            Assert.AreEqual(startup.GetStationName(4), "RADIO_05_TALK_01");
            Assert.AreEqual(startup.GetStationName(5), "RADIO_06_COUNTRY");
            Assert.AreEqual(startup.GetStationName(6), "RADIO_07_DANCE_01");
            Assert.AreEqual(startup.GetStationName(7), "RADIO_08_MEXICAN");
            Assert.AreEqual(startup.GetStationName(8), "RADIO_09_HIPHOP_OLD");
            Assert.AreEqual(startup.GetStationName(9), "RADIO_11_TALK_02");
            Assert.AreEqual(startup.GetStationName(10), "RADIO_12_REGGAE");
            Assert.AreEqual(startup.GetStationName(11), "RADIO_13_JAZZ");
            Assert.AreEqual(startup.GetStationName(12), "RADIO_14_DANCE_02");
            Assert.AreEqual(startup.GetStationName(13), "RADIO_15_MOTOWN");
            Assert.AreEqual(startup.GetStationName(14), "RADIO_16_SILVERLAKE");
            Assert.AreEqual(startup.GetStationName(15), "RADIO_17_FUNK");
            Assert.AreEqual(startup.GetStationName(16), "RADIO_18_90S_ROCK");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void TestGetStationNameIncorrectIndex()
        {
            string name = startup.GetStationName(100);
        }

        [TestMethod]
        public void TestLoadRadioLogoCorrect()
        {
            Assert.AreEqual(startup.LoadRadioLogo(startup.GetStationName(0)).Height, 229);
            Assert.AreEqual(startup.LoadRadioLogo(startup.GetStationName(0)).Width, 360);

            Assert.AreEqual(startup.LoadRadioLogo(startup.GetStationName(7)).Height, 600);
            Assert.AreEqual(startup.LoadRadioLogo(startup.GetStationName(7)).Width, 600);
        }

        [TestMethod]
        [ExpectedException(typeof(System.NullReferenceException))]
        public void TestLoadRadioLogoBadStationName()
        {
            Assert.AreNotEqual(startup.LoadRadioLogo("BOGUS_RADIO").Height, 512); //512 is the height of the "NO_RADIO" image that it would load if the exception did not work.
            Assert.AreNotEqual(startup.LoadRadioLogo("BOGUS_RADIO").Width, 512); //512 is the width of the "NO_RADIO" image that it would load if the exception did not work.
        }

        [TestCleanup]
        public void Cleanup()
        {
            File.Delete("C:\\Temp\\TestGTARadioConfigFile.txt");
            File.Delete("C:\\Temp\\TestGTARadioConfigFileBad.txt");
        }
    }
}
