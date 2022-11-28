using AxWMPLib;
using GrandTheftAutoRadioForDesktop;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTARadioTest
{
    //[TestClass]
    public class RadioTest
    {
        //[TestMethod]
        public void TestConstructor()
        {
            AxWindowsMediaPlayer player = new AxWindowsMediaPlayer();
            Radio radio = new Radio(player, "D:\\Documenten\\Git Repositories\\PROJECT_FILES\\GTA_RADIO_EXTRACT\\RADIO_01_CLASS_ROCK", "D:\\Documenten\\Git Repositories\\PROJECT_FILES\\GTA_RADIO_EXTRACT");

        }
    }
}
