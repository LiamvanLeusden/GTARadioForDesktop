using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandTheftAutoRadioForDesktop
{
    public abstract class AudioFile
    {
        public string type { get; set; }
        public string fullPath { get; set; }

        public AudioFile(string type, string fullPath)
        {
            if (fullPath == null)
            {
                throw new ArgumentNullException("Either the type or the file path of the audio file is null!");
            }
            this.type = type;
            this.fullPath = fullPath;
        }
    }
}
