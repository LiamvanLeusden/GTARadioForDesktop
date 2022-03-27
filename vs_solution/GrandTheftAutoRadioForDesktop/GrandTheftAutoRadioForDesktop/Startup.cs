using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GrandTheftAutoRadioForDesktop
{
    public class Startup //TODO: This is public only for unit testing.
    {
        public Startup() //CONSTRUCTOR
        {

        }

        public void SavePreferencesToFile(string filePath, string pathToRadioFolder, int volume)
        {
            using (StreamWriter writer = File.CreateText(filePath))
            {
                writer.WriteLine("//GTARadioForDesktop configuration file. If you want to edit this; only edit the lines directly after the lines with colons.");
                writer.WriteLine("");
                writer.WriteLine("");
                writer.WriteLine("RADIO_LOCATION: //Accepted argument = text, full valid file path (For example: D:\\Documents\\GTA_RADIO_EXTRACT)");
                writer.WriteLine(pathToRadioFolder);
                writer.WriteLine("");
                writer.WriteLine("SET_VOLUME: //Accepted argument = numbers between 0 and 100 (For example 44, NOT 044)");
                writer.WriteLine(volume);
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
                writer.WriteLine("");
                writer.Close();
            }
        }

        public string LoadPreferencesFromFile(string filePath, ref int volume)
        {
            string pathToRadioFolder = "ERROR";
            string[] lines = File.ReadAllLines(filePath);
            if (lines.Length != 26)
            {
                throw new NumberOfLinesException();
            }
            pathToRadioFolder = lines[4];
            Int32.TryParse(lines[7], out volume);
            Int32.TryParse(lines[12], out Radio.RATIO_CHANCE_SONG);
            Int32.TryParse(lines[15], out Radio.RATIO_CHANCE_STINGER);
            Int32.TryParse(lines[18], out Radio.RATIO_CHANCE_QUOTE);
            Int32.TryParse(lines[21], out Radio.RATIO_CHANCE_NEWSITEM);
            Int32.TryParse(lines[24], out Radio.RATIO_CHANCE_ADVERTISEMENT);

            Radio.RATIO_TOTAL = Radio.RATIO_CHANCE_SONG + Radio.RATIO_CHANCE_STINGER + Radio.RATIO_CHANCE_QUOTE + Radio.RATIO_CHANCE_ADVERTISEMENT + Radio.RATIO_CHANCE_NEWSITEM;
            return pathToRadioFolder;
        }

        public string GetStationName(int selectedIndex) //User friendly to internal
        {
            string internalName = "NO_RADIO";
            selectedIndex++; //To match index with number of radio station
            switch (selectedIndex)
            {
                case 1:
                    internalName = "RADIO_01_CLASS_ROCK";
                    break;
                case 2:
                    internalName = "RADIO_02_POP";
                    break;
                case 3:
                    internalName = "RADIO_03_HIPHOP_NEW";
                    break;
                case 4:
                    internalName = "RADIO_04_PUNK";
                    break;
                case 5:
                    internalName = "RADIO_05_TALK_01";
                    break;
                case 6:
                    internalName = "RADIO_06_COUNTRY";
                    break;
                case 7:
                    internalName = "RADIO_07_DANCE_01";
                    break;
                case 8:
                    internalName = "RADIO_08_MEXICAN";
                    break;
                case 9:
                    internalName = "RADIO_09_HIPHOP_OLD";
                    break;
                case 10:
                    internalName = "RADIO_11_TALK_02";
                    break;
                case 11:
                    internalName = "RADIO_12_REGGAE";
                    break;
                case 12:
                    internalName = "RADIO_13_JAZZ";
                    break;
                case 13:
                    internalName = "RADIO_14_DANCE_02";
                    break;
                case 14:
                    internalName = "RADIO_15_MOTOWN";
                    break;
                case 15:
                    internalName = "RADIO_16_SILVERLAKE";
                    break;
                case 16:
                    internalName = "RADIO_17_FUNK";
                    break;
                case 17:
                    internalName = "RADIO_18_90S_ROCK";
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            return internalName;
        }

        public System.Drawing.Image LoadRadioLogo(String stationName)
        {
            System.Drawing.Image fileForPictureBox = Properties.Resources.NO_RADIO;
            fileForPictureBox = (System.Drawing.Image)Properties.Resources.ResourceManager.GetObject(stationName);
            return fileForPictureBox;
        }
    }
}
