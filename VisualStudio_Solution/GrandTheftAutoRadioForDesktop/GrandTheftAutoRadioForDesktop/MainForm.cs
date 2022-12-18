using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrandTheftAutoRadioForDesktop
{
    public partial class MainForm : Form
    {
        private string stationName = "NO_RADIO"; //Internal name, not user friendly name
        private string currentStation = "NO_RADIO";
        private string pathToRadioExtractFolder = "<No folder chosen, GTA radio will not work!>";
        private bool folderChosen = false;
        private int volume = 50;
        private string pathToRadioFolder = ""; //Global variable, used in too many classes to be private
        private Radio Radio { get; set; } //Constructor does not get called here, because I dont have the radio folder yet
        private Startup startup { get; set; }

        public MainForm() //CONSTRUCTOR
        {
            InitializeComponent();
        }

        private void btnChooseFolder_Click(object sender, EventArgs e)
        {
            if (dlgChooseFolder.ShowDialog() == DialogResult.OK)
            {
                txtChooseFolder.Text = dlgChooseFolder.SelectedPath;
                pathToRadioExtractFolder = dlgChooseFolder.SelectedPath;
                folderChosen = true;
            }
        }

        private void UpdateSliders()
        {
            try
            {
                trcPreferencesSong.Value = Radio.RATIO_CHANCE_SONG;
                trcPreferencesQuote.Value = Radio.RATIO_CHANCE_QUOTE;
                trcPreferencesNewsItem.Value = Radio.RATIO_CHANCE_NEWSITEM;
                trcPreferencesStinger.Value = Radio.RATIO_CHANCE_STINGER;
                trcPreferencesAdvertisement.Value = Radio.RATIO_CHANCE_ADVERTISEMENT;
                trcPreferencesTimeOfDayMSG.Value = Radio.RATIO_CHANCE_TIMEOFDAYMSG;
                lblDisplayValueSong.Text = Radio.RATIO_CHANCE_SONG.ToString();
                lblDisplayValueQuote.Text = Radio.RATIO_CHANCE_QUOTE.ToString();
                lblDisplayValueNewsItem.Text = Radio.RATIO_CHANCE_NEWSITEM.ToString();
                lblDisplayValueStinger.Text = Radio.RATIO_CHANCE_STINGER.ToString();
                lblDisplayValueAdvertisement.Text = Radio.RATIO_CHANCE_ADVERTISEMENT.ToString();
                lblDisplayValueTimeOfDayMSG.Text = Radio.RATIO_CHANCE_TIMEOFDAYMSG.ToString();
                txtChooseFolder.Text = pathToRadioExtractFolder;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Configuration file incorrect. Delete or fix the configuration file.", "An unexpected error has occured!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PlayButtonAction()
        {
            if (Radio != null)
            {
                Radio.RadioPlaying = false;
                Radio.DestructRadio();
            }

            btnStart.Enabled = false;
            btnStart1.Enabled = false;
            currentStation = stationName;
            btnPause.Enabled = true;
            btnSkip.Enabled = true;

            try
            {
                Radio = new Radio(player, pathToRadioFolder, pathToRadioExtractFolder);
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("Directory not found. Have you selected the right directory?", "An unexpected error has occured!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnStart1.Enabled = true;
                btnStart.Enabled = true;
                btnSkip.Enabled = false;
                btnPause.Enabled = false;
                currentStation = "NO_RADIO";
            }
        }


        private void SetVolume()
        {
            player.settings.volume = volume;
            trcVolume.Value = volume;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            startup = new Startup();
            SetVolume();
            UpdateSliders();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            PlayButtonAction();
        }

        private void cbbSelectStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                stationName = startup.GetStationName(cbbSelectStation.SelectedIndex);
            }
            catch (ArgumentOutOfRangeException)
            {
                //TODO: Before release, remove the debug option from radio list.
                MessageBox.Show("Radio not found internally. Incorrect index? Contact the developer.", "An unexpected error has occured!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            pctRadioLogo.Image = startup.LoadRadioLogo(stationName);
            pathToRadioFolder = pathToRadioExtractFolder + "\\" + stationName + "\\";
            txtChooseFolder.Text = pathToRadioFolder;

            if (currentStation != stationName && folderChosen)
            {
                btnStart.Enabled = true;
                btnStart1.Enabled = true;
            }
            else
            {
                btnStart.Enabled = false;
                btnStart1.Enabled = false;
            }
        }

        private void player_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (Radio != null)
            {
                if (player.playState == WMPLib.WMPPlayState.wmppsStopped)
                {
                    Radio.AudioFileFinished = true;
                }
                else
                {
                    Radio.AudioFileFinished = false;
                }
            }
        }

        private void btnToggleSettingsVisibility_Click(object sender, EventArgs e)
        {
            if (pctRadioLogo.Visible) //From default to settings view
            {
                pctRadioLogo.Visible = false;
                btnSavePreferences.Visible = true;
                btnLoadPreferences.Visible = true;
                btnDebugShowPlayer.Visible = true;

                lblStaticPreferences1.Visible = true;
                lblStaticPreferences2.Visible = true;
                lblStaticPreferences3.Visible = true;
                lblStaticPreferences4.Visible = true;
                lblStaticPreferences5.Visible = true;
                lblStaticPreferences6.Visible = true;

                lblDisplayValueSong.Visible = true;
                lblDisplayValueStinger.Visible = true;
                lblDisplayValueQuote.Visible = true;
                lblDisplayValueAdvertisement.Visible = true;
                lblDisplayValueNewsItem.Visible = true;
                lblDisplayValueTimeOfDayMSG.Visible = true;

                trcPreferencesSong.Visible = true;
                trcPreferencesStinger.Visible = true;
                trcPreferencesQuote.Visible = true;
                trcPreferencesAdvertisement.Visible = true;
                trcPreferencesNewsItem.Visible = true;
                trcPreferencesTimeOfDayMSG.Visible = true;
            }
            else //From settings view back to default
            {
                pctRadioLogo.Visible = true;
                btnSavePreferences.Visible = false;
                btnLoadPreferences.Visible = false;
                btnDebugShowPlayer.Visible = false;

                lblStaticPreferences1.Visible = false;
                lblStaticPreferences2.Visible = false;
                lblStaticPreferences3.Visible = false;
                lblStaticPreferences4.Visible = false;
                lblStaticPreferences5.Visible = false;
                lblStaticPreferences6.Visible = false;

                lblDisplayValueSong.Visible = false;
                lblDisplayValueStinger.Visible = false;
                lblDisplayValueQuote.Visible = false;
                lblDisplayValueAdvertisement.Visible = false;
                lblDisplayValueNewsItem.Visible = false;
                lblDisplayValueTimeOfDayMSG.Visible = false;

                trcPreferencesSong.Visible = false;
                trcPreferencesStinger.Visible = false;
                trcPreferencesQuote.Visible = false;
                trcPreferencesAdvertisement.Visible = false;
                trcPreferencesNewsItem.Visible = false;
                trcPreferencesTimeOfDayMSG.Visible = false;
            }
        }

        private void trcPreferencesSong_Scroll(object sender, EventArgs e)
        {
            lblDisplayValueSong.Text = trcPreferencesSong.Value.ToString();
            Radio.RATIO_CHANCE_SONG = trcPreferencesSong.Value;
            Radio.RATIO_TOTAL = Radio.RATIO_CHANCE_SONG + Radio.RATIO_CHANCE_STINGER + Radio.RATIO_CHANCE_QUOTE + Radio.RATIO_CHANCE_ADVERTISEMENT + Radio.RATIO_CHANCE_NEWSITEM + Radio.RATIO_CHANCE_TIMEOFDAYMSG;
        }

        private void trcPreferencesQuote_Scroll(object sender, EventArgs e)
        {
            lblDisplayValueQuote.Text = trcPreferencesQuote.Value.ToString();
            Radio.RATIO_CHANCE_QUOTE = trcPreferencesQuote.Value;
            Radio.RATIO_TOTAL = Radio.RATIO_CHANCE_SONG + Radio.RATIO_CHANCE_STINGER + Radio.RATIO_CHANCE_QUOTE + Radio.RATIO_CHANCE_ADVERTISEMENT + Radio.RATIO_CHANCE_NEWSITEM + Radio.RATIO_CHANCE_TIMEOFDAYMSG;
        }

        private void trcPreferencesNewsItem_Scroll(object sender, EventArgs e)
        {
            lblDisplayValueNewsItem.Text = trcPreferencesNewsItem.Value.ToString();
            Radio.RATIO_CHANCE_NEWSITEM = trcPreferencesNewsItem.Value;
            Radio.RATIO_TOTAL = Radio.RATIO_CHANCE_SONG + Radio.RATIO_CHANCE_STINGER + Radio.RATIO_CHANCE_QUOTE + Radio.RATIO_CHANCE_ADVERTISEMENT + Radio.RATIO_CHANCE_NEWSITEM + Radio.RATIO_CHANCE_TIMEOFDAYMSG;
        }

        private void trcPreferencesStinger_Scroll(object sender, EventArgs e)
        {
            lblDisplayValueStinger.Text = trcPreferencesStinger.Value.ToString();
            Radio.RATIO_CHANCE_STINGER = trcPreferencesStinger.Value;
            Radio.RATIO_TOTAL = Radio.RATIO_CHANCE_SONG + Radio.RATIO_CHANCE_STINGER + Radio.RATIO_CHANCE_QUOTE + Radio.RATIO_CHANCE_ADVERTISEMENT + Radio.RATIO_CHANCE_NEWSITEM + Radio.RATIO_CHANCE_TIMEOFDAYMSG;
        }

        private void trcPreferencesAdvertisement_Scroll(object sender, EventArgs e)
        {
            lblDisplayValueAdvertisement.Text = trcPreferencesAdvertisement.Value.ToString();
            Radio.RATIO_CHANCE_ADVERTISEMENT = trcPreferencesAdvertisement.Value;
            Radio.RATIO_TOTAL = Radio.RATIO_CHANCE_SONG + Radio.RATIO_CHANCE_STINGER + Radio.RATIO_CHANCE_QUOTE + Radio.RATIO_CHANCE_ADVERTISEMENT + Radio.RATIO_CHANCE_NEWSITEM + Radio.RATIO_CHANCE_TIMEOFDAYMSG;
        }

        private void trcPreferencesTimeOfDayMSG_Scroll(object sender, EventArgs e)
        {
            lblDisplayValueTimeOfDayMSG.Text = trcPreferencesTimeOfDayMSG.Value.ToString();
            Radio.RATIO_CHANCE_TIMEOFDAYMSG = trcPreferencesTimeOfDayMSG.Value;
            Radio.RATIO_TOTAL = Radio.RATIO_CHANCE_SONG + Radio.RATIO_CHANCE_STINGER + Radio.RATIO_CHANCE_QUOTE + Radio.RATIO_CHANCE_ADVERTISEMENT + Radio.RATIO_CHANCE_NEWSITEM + Radio.RATIO_CHANCE_TIMEOFDAYMSG;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                player.Ctlcontrols.pause();
            }
            else if (player.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                player.Ctlcontrols.play();
            }
        }

        private void btnDebugShowPlayer_Click(object sender, EventArgs e)
        {
            if (player.Visible == false)
            {
                player.Visible = true;
                btnPause.Visible = false;
                btnSkip.Visible = false;
                btnStart.Visible = false;
                btnStart1.Visible = true;
            }
            else
            {
                player.Visible = false;
                btnPause.Visible = true;
                btnSkip.Visible = true;
                btnStart.Visible = true;
                btnStart1.Visible = false;
            }
        }

        private void tmrCheckError_Tick(object sender, EventArgs e)
        {
            lblError.Text = Radio.error;
            int[] probabilities = { Radio.RATIO_CHANCE_SONG, Radio.RATIO_CHANCE_STINGER, Radio.RATIO_CHANCE_QUOTE, Radio.RATIO_CHANCE_ADVERTISEMENT, Radio.RATIO_CHANCE_NEWSITEM, Radio.RATIO_CHANCE_TIMEOFDAYMSG };
            if (probabilities.Count(n => n > 0) < 2)
            {
                Radio.RATIO_CHANCE_SONG = 10;
                Radio.RATIO_CHANCE_STINGER = 10;
                UpdateSliders();
                MessageBox.Show("You must have at least two categories of items that are not at 0 probability.");
            }
        }

        private void btnStart1_Click(object sender, EventArgs e)
        {
            PlayButtonAction();
        }

        private void btnSavePreferences_Click(object sender, EventArgs e)
        {
            if (dlgFileSave.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    startup.SavePreferencesToFile(dlgFileSave.FileName, pathToRadioExtractFolder, volume);
                }
                catch (IOException)
                {
                    MessageBox.Show("Occured while writing the file. Do you have enough disk space?", "An unexpected error has occured!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLoadPreferences_Click(object sender, EventArgs e)
        {
            if (dlgFileLoad.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pathToRadioExtractFolder = startup.LoadPreferencesFromFile(dlgFileLoad.FileName, ref volume);
                    if (pathToRadioFolder != "ERROR")
                    {
                        UpdateSliders();
                        SetVolume();
                        pathToRadioFolder = pathToRadioExtractFolder + "\\" + stationName + "\\";
                        folderChosen = true;
                        if (stationName != "NO_RADIO")
                        {
                            btnStart.Enabled = true;
                            btnStart1.Enabled = true;
                        }
                    }
                }
                catch (NumberOfLinesException)
                {
                    MessageBox.Show("Number of lines in the file is not correct. Did you select a GTARadioForDesktop configuration file?", "An unexpected error has occured!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("Out of range. Did you select a GTARadioForDesktop configuration file?", "An unexpected error has occured!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            Radio.AudioFileFinished = true;
        }

        private void trcVolume_Scroll(object sender, EventArgs e)
        {
            volume = trcVolume.Value;
            SetVolume();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.MediaPlayPause)
            {
                if (btnStart.Enabled == false) 
                {
                    btnPause_Click(sender, e);
                }
                else
                {
                    PlayButtonAction();
                }
                
            }
            else if (e.KeyCode == Keys.MediaNextTrack)
            {
                btnSkip_Click(sender, e);
            }
        }
    }
}