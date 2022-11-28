# GTARadioForDesktop
Ever wanted the radio from GTA V in a desktop application for Windows? Probably not, but here it is anyway!

Disclaimer: This was made by a first year IT student. For bugs, glitches, feature requests and anything else, you can open a GitHub issue.

### Installing / using the application

#### Step 1: Getting the app

I made a .msi Windows installer for this program to be found in the [Releases](https://github.com/LiamvanLeusden/GTARadioForDesktop/releases) tab.

#### Step 2: Extracting audio files

To use the application, you have to export all the audio files from GTA V with [OpenIV](https://ntscorp.ru/ovi/setup/ovisetup.exe) (click for direct download). The radio files are located in GTA V/x64/audio/sfx/. You will need to export all the audio files from all the .rpf archives starting with RADIO_ as .WAV audio files.

Once exported, you need to put them in folders with the same names they have as .rpf archives. In a radio folder, there should be no subdirectories, only loose audio files. You will end up with this folder structure:

![](/Documentation/screenshots/folder_structure.PNG/)

The name of the folder these directories are located in does not matter.

#### Step 3: Renaming songs

Then comes a tedious part of renaming some files.

From OpenIV, the song names are named only with [SONGNAME], so for each song, you'll have to rename it to this:

| Type of file  | Name from OpenIV      | Name required               |
| ------------- | --------------------- | --------------------------- |
| Song          | `[SONGNAME]`          | `SONG_[SONGNAME]`           |
| Intro to song | `[SONGNAME]_[NUMBER]` | `INTRO_[SONGNAME]_[NUMBER]` |

These, you can export directly from OpenIV without the need to rename:

| Type of file            | Name from OpenIV and usable in the app     |
| ----------------------- | ------------------------------------------ |
| Stinger                 | `ID_[NUMBER]`                              |
| General quote           | `GENERAL_[NUMBER]` or `MONO_SOLO_[NUMBER]` |
| Morning quote           | `MORNING_[NUMBER]`                         |
| Evening quote           | `EVENING_[NUMBER]`                         |
| Intro for advertisement | `TO_AD_[NUMBER]`                           |
| Intro for news items    | `TO_NEWS_[NUMBER]`                         |
| Advertisements          | All files in folder `RADIO_ADVERTS`        |
| News items              | All files in folder `RADIO_NEWS`           |

#### Step 4: Configuring the app

Launching the app will give you this screen:

![](/Documentation/screenshots/launch_app.PNG)

First, you'll have to click browse to find the folder where all the audio files are located. Now, you can test the application and see if it works. You don't have to configure any further to get a good experience, but you can. If you press "Toggle display settings", you'll get some sliders to set probability of categories occuring. 

![](/Documentation/screenshots/settings.PNG)

You can also save the settings. This will save these items to a text file for you to be able to load later:

- Location of radio folder
- Probability of all the items
- Preferred volume

You can also edit this text file.

#### Step 5: Enjoy!

After all this work you can finally enjoy the radio stations from GTA V without the eternal loading screens. Select a radio from the dropdown and click "Start". If you press "Skip", the next item plays.

![](/Documentation/screenshots/playing.PNG)
