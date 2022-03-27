# GTARadioForDesktop
Ever wanted the radio from GTA V in a desktop application for Windows? Probably not, but here it is anyway!

### Installing / using the application

#### Step 1: Getting the app

I have a pre-built version here: [here](/built_application/). You can download this directory or the .zip and put the program files in any random folder. The executable is GrandTheftAutoRadioForDesktop.exe

#### Step 2: Extracting audio files

To use the application, you have to export all the audio files from GTA V with [OpenIV](https://ntscorp.ru/ovi/setup/ovisetup.exe) (click for direct download). The radio files are located in GTA V/x64/audio/sfx/. You will need to export all the audio files from all the .rpf archives starting with RADIO_

Once exported, you need to put them in folders with the same names they have as .rpf archives. You will end up with this folder structure:

![](/documents/screenshots/folder_structure.PNG/)

The name of the folder these directories are located in does not matter.

#### Step 3: Renaming songs

Then comes a tedious part of renaming some files.

From OpenIV, the song names are named only with [SONGNAME], so for each song, you'll have to rename it to this:<br/>`SONG				=	SONG_[SONGNAME]`<br/>
`INTRO TO SONG		=	INTRO_[SONGNAME]_[NUMBER]`<br/>

These, you can export directly from OpenIV without the need to rename:

`STINGER				=	ID_[NUMBER]`<br/>

`GENERAL QUOTE		=	GENERAL_[NUMBER] or MONO_SOLO_[NUMBER]`<br/>
`MORNING				=	MORNING_[NUMBER]`<br/>
`EVENING				=	EVENING_[NUMBER]`<br/>
`TO ADVERTISEMENT	=	TO_AD_[NUMBER]`<br/>
`TO NEWS				=	TO_NEWS_[NUMBER]`<br/>
`ADVERTISEMENTS		= 	All in folder RADIO_ADVERTS`<br/>
`NEWS				=	All in folder RADIO_NEWS`<br/>

#### Step 4: Configuring the app

Launching the app will give you this screen:

![](/documents/screenshots/launch_app.PNG)
