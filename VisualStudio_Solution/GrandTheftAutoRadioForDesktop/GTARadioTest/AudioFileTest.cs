using GrandTheftAutoRadioForDesktop;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTARadioTest
{
    [TestClass]
    public class AudioFileTest
    {
        [TestMethod]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void TestConstructorFilePathNull()
        {
            AudioFile audioFileForTestFilePath = new Stinger(null);
        }

        [TestMethod]
        public void TestConstructorCorrect()
        {
            AudioFile audioFile = new Stinger("C:\\OGLC\\file.ogg");
            Assert.AreEqual("Stinger", audioFile.type);
            Assert.AreEqual("C:\\OGLC\\file.ogg", audioFile.fullPath);
        }
    }
}
