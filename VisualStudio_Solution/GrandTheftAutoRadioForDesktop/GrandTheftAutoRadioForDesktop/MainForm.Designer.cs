
namespace GrandTheftAutoRadioForDesktop
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnChooseFolder = new System.Windows.Forms.Button();
            this.dlgChooseFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.txtChooseFolder = new System.Windows.Forms.TextBox();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnStart = new System.Windows.Forms.Button();
            this.cbbSelectStation = new System.Windows.Forms.ComboBox();
            this.lblStaticSelectStation = new System.Windows.Forms.Label();
            this.btnSkip = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnSavePreferences = new System.Windows.Forms.Button();
            this.btnLoadPreferences = new System.Windows.Forms.Button();
            this.pctRadioLogo = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.trcPreferencesSong = new System.Windows.Forms.TrackBar();
            this.trcPreferencesStinger = new System.Windows.Forms.TrackBar();
            this.lblStaticPreferences3 = new System.Windows.Forms.Label();
            this.lblStaticPreferences2 = new System.Windows.Forms.Label();
            this.lblStaticPreferences1 = new System.Windows.Forms.Label();
            this.trcPreferencesQuote = new System.Windows.Forms.TrackBar();
            this.trcPreferencesAdvertisement = new System.Windows.Forms.TrackBar();
            this.trcPreferencesNewsItem = new System.Windows.Forms.TrackBar();
            this.lblStaticPreferences5 = new System.Windows.Forms.Label();
            this.lblStaticPreferences4 = new System.Windows.Forms.Label();
            this.btnToggleSettingsVisibility = new System.Windows.Forms.Button();
            this.lblDisplayValueSong = new System.Windows.Forms.Label();
            this.lblDisplayValueNewsItem = new System.Windows.Forms.Label();
            this.lblDisplayValueQuote = new System.Windows.Forms.Label();
            this.lblDisplayValueAdvertisement = new System.Windows.Forms.Label();
            this.lblDisplayValueStinger = new System.Windows.Forms.Label();
            this.btnDebugShowPlayer = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.tmrCheckError = new System.Windows.Forms.Timer(this.components);
            this.btnStart1 = new System.Windows.Forms.Button();
            this.dlgFileLoad = new System.Windows.Forms.OpenFileDialog();
            this.dlgFileSave = new System.Windows.Forms.SaveFileDialog();
            this.trcVolume = new System.Windows.Forms.TrackBar();
            this.lblStaticVolume = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRadioLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcPreferencesSong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcPreferencesStinger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcPreferencesQuote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcPreferencesAdvertisement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcPreferencesNewsItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChooseFolder
            // 
            this.btnChooseFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChooseFolder.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btnChooseFolder.Location = new System.Drawing.Point(713, 11);
            this.btnChooseFolder.Name = "btnChooseFolder";
            this.btnChooseFolder.Size = new System.Drawing.Size(75, 22);
            this.btnChooseFolder.TabIndex = 0;
            this.btnChooseFolder.Text = "Browse";
            this.btnChooseFolder.UseVisualStyleBackColor = true;
            this.btnChooseFolder.Click += new System.EventHandler(this.btnChooseFolder_Click);
            // 
            // dlgChooseFolder
            // 
            this.dlgChooseFolder.Description = "Choose folder where files for Grand Theft Auto radio are located.";
            this.dlgChooseFolder.ShowNewFolderButton = false;
            // 
            // txtChooseFolder
            // 
            this.txtChooseFolder.Enabled = false;
            this.txtChooseFolder.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.txtChooseFolder.Location = new System.Drawing.Point(12, 12);
            this.txtChooseFolder.Name = "txtChooseFolder";
            this.txtChooseFolder.Size = new System.Drawing.Size(695, 21);
            this.txtChooseFolder.TabIndex = 1;
            this.txtChooseFolder.Text = "<No folder chosen, GTA radio will not work!>";
            // 
            // player
            // 
            this.player.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(0, 383);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(800, 65);
            this.player.TabIndex = 2;
            this.player.Visible = false;
            this.player.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.player_PlayStateChange);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStart.Enabled = false;
            this.btnStart.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btnStart.Location = new System.Drawing.Point(7, 392);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(258, 44);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cbbSelectStation
            // 
            this.cbbSelectStation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbSelectStation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSelectStation.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.cbbSelectStation.ForeColor = System.Drawing.Color.Black;
            this.cbbSelectStation.FormattingEnabled = true;
            this.cbbSelectStation.Items.AddRange(new object[] {
            "Los Santos Rock Radio",
            "Non Stop Pop FM",
            "Radio Los Santos",
            "Channel X",
            "WCTR",
            "Rebel Radio",
            "Soulwax FM",
            "East Los FM",
            "West Coast Classics",
            "Blaine County Radio",
            "Blue Ark",
            "WorldWide FM",
            "FlyLo FM",
            "The Lowdown 91.1",
            "Radio Mirror Park",
            "Space 103.2",
            "Vinewood Boulevard Radio",
            "(DEBUG): To test out of range"});
            this.cbbSelectStation.Location = new System.Drawing.Point(587, 78);
            this.cbbSelectStation.Name = "cbbSelectStation";
            this.cbbSelectStation.Size = new System.Drawing.Size(201, 21);
            this.cbbSelectStation.TabIndex = 7;
            this.cbbSelectStation.SelectedIndexChanged += new System.EventHandler(this.cbbSelectStation_SelectedIndexChanged);
            // 
            // lblStaticSelectStation
            // 
            this.lblStaticSelectStation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStaticSelectStation.AutoSize = true;
            this.lblStaticSelectStation.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.lblStaticSelectStation.ForeColor = System.Drawing.Color.White;
            this.lblStaticSelectStation.Location = new System.Drawing.Point(584, 62);
            this.lblStaticSelectStation.Name = "lblStaticSelectStation";
            this.lblStaticSelectStation.Size = new System.Drawing.Size(133, 13);
            this.lblStaticSelectStation.TabIndex = 8;
            this.lblStaticSelectStation.Text = "Select a radio station:";
            // 
            // btnSkip
            // 
            this.btnSkip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSkip.Enabled = false;
            this.btnSkip.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btnSkip.Location = new System.Drawing.Point(535, 392);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(258, 44);
            this.btnSkip.TabIndex = 10;
            this.btnSkip.Text = "Skip";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // btnPause
            // 
            this.btnPause.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPause.Enabled = false;
            this.btnPause.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btnPause.Location = new System.Drawing.Point(271, 392);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(258, 44);
            this.btnPause.TabIndex = 11;
            this.btnPause.Text = "Pause / Play";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnSavePreferences
            // 
            this.btnSavePreferences.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btnSavePreferences.Location = new System.Drawing.Point(15, 57);
            this.btnSavePreferences.Name = "btnSavePreferences";
            this.btnSavePreferences.Size = new System.Drawing.Size(232, 23);
            this.btnSavePreferences.TabIndex = 12;
            this.btnSavePreferences.Text = "Save preferences to file";
            this.btnSavePreferences.UseVisualStyleBackColor = true;
            this.btnSavePreferences.Visible = false;
            this.btnSavePreferences.Click += new System.EventHandler(this.btnSavePreferences_Click);
            // 
            // btnLoadPreferences
            // 
            this.btnLoadPreferences.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btnLoadPreferences.Location = new System.Drawing.Point(286, 57);
            this.btnLoadPreferences.Name = "btnLoadPreferences";
            this.btnLoadPreferences.Size = new System.Drawing.Size(232, 23);
            this.btnLoadPreferences.TabIndex = 15;
            this.btnLoadPreferences.Text = "Load preferences from file";
            this.btnLoadPreferences.UseVisualStyleBackColor = true;
            this.btnLoadPreferences.Visible = false;
            this.btnLoadPreferences.Click += new System.EventHandler(this.btnLoadPreferences_Click);
            // 
            // pctRadioLogo
            // 
            this.pctRadioLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctRadioLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pctRadioLogo.Image = global::GrandTheftAutoRadioForDesktop.Properties.Resources.NO_RADIO;
            this.pctRadioLogo.Location = new System.Drawing.Point(233, 37);
            this.pctRadioLogo.Name = "pctRadioLogo";
            this.pctRadioLogo.Size = new System.Drawing.Size(345, 345);
            this.pctRadioLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctRadioLogo.TabIndex = 9;
            this.pctRadioLogo.TabStop = false;
            // 
            // trcPreferencesSong
            // 
            this.trcPreferencesSong.LargeChange = 10;
            this.trcPreferencesSong.Location = new System.Drawing.Point(15, 124);
            this.trcPreferencesSong.Maximum = 100;
            this.trcPreferencesSong.Name = "trcPreferencesSong";
            this.trcPreferencesSong.Size = new System.Drawing.Size(212, 45);
            this.trcPreferencesSong.SmallChange = 5;
            this.trcPreferencesSong.TabIndex = 17;
            this.trcPreferencesSong.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trcPreferencesSong.Visible = false;
            this.trcPreferencesSong.Scroll += new System.EventHandler(this.trcPreferencesSong_Scroll);
            // 
            // trcPreferencesStinger
            // 
            this.trcPreferencesStinger.LargeChange = 10;
            this.trcPreferencesStinger.Location = new System.Drawing.Point(286, 124);
            this.trcPreferencesStinger.Maximum = 100;
            this.trcPreferencesStinger.Name = "trcPreferencesStinger";
            this.trcPreferencesStinger.Size = new System.Drawing.Size(212, 45);
            this.trcPreferencesStinger.SmallChange = 5;
            this.trcPreferencesStinger.TabIndex = 19;
            this.trcPreferencesStinger.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trcPreferencesStinger.Visible = false;
            this.trcPreferencesStinger.Scroll += new System.EventHandler(this.trcPreferencesStinger_Scroll);
            // 
            // lblStaticPreferences3
            // 
            this.lblStaticPreferences3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStaticPreferences3.AutoSize = true;
            this.lblStaticPreferences3.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.lblStaticPreferences3.ForeColor = System.Drawing.Color.White;
            this.lblStaticPreferences3.Location = new System.Drawing.Point(12, 181);
            this.lblStaticPreferences3.Name = "lblStaticPreferences3";
            this.lblStaticPreferences3.Size = new System.Drawing.Size(200, 13);
            this.lblStaticPreferences3.TabIndex = 24;
            this.lblStaticPreferences3.Text = "Set probability of occuring: Quote";
            this.lblStaticPreferences3.Visible = false;
            // 
            // lblStaticPreferences2
            // 
            this.lblStaticPreferences2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStaticPreferences2.AutoSize = true;
            this.lblStaticPreferences2.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.lblStaticPreferences2.ForeColor = System.Drawing.Color.White;
            this.lblStaticPreferences2.Location = new System.Drawing.Point(283, 108);
            this.lblStaticPreferences2.Name = "lblStaticPreferences2";
            this.lblStaticPreferences2.Size = new System.Drawing.Size(207, 13);
            this.lblStaticPreferences2.TabIndex = 25;
            this.lblStaticPreferences2.Text = "Set probability of occuring: Stinger";
            this.lblStaticPreferences2.Visible = false;
            // 
            // lblStaticPreferences1
            // 
            this.lblStaticPreferences1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStaticPreferences1.AutoSize = true;
            this.lblStaticPreferences1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.lblStaticPreferences1.ForeColor = System.Drawing.Color.White;
            this.lblStaticPreferences1.Location = new System.Drawing.Point(12, 108);
            this.lblStaticPreferences1.Name = "lblStaticPreferences1";
            this.lblStaticPreferences1.Size = new System.Drawing.Size(195, 13);
            this.lblStaticPreferences1.TabIndex = 26;
            this.lblStaticPreferences1.Text = "Set probability of occuring: Song";
            this.lblStaticPreferences1.Visible = false;
            // 
            // trcPreferencesQuote
            // 
            this.trcPreferencesQuote.LargeChange = 10;
            this.trcPreferencesQuote.Location = new System.Drawing.Point(15, 197);
            this.trcPreferencesQuote.Maximum = 100;
            this.trcPreferencesQuote.Name = "trcPreferencesQuote";
            this.trcPreferencesQuote.Size = new System.Drawing.Size(212, 45);
            this.trcPreferencesQuote.SmallChange = 5;
            this.trcPreferencesQuote.TabIndex = 20;
            this.trcPreferencesQuote.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trcPreferencesQuote.Visible = false;
            this.trcPreferencesQuote.Scroll += new System.EventHandler(this.trcPreferencesQuote_Scroll);
            // 
            // trcPreferencesAdvertisement
            // 
            this.trcPreferencesAdvertisement.LargeChange = 10;
            this.trcPreferencesAdvertisement.Location = new System.Drawing.Point(286, 197);
            this.trcPreferencesAdvertisement.Maximum = 100;
            this.trcPreferencesAdvertisement.Name = "trcPreferencesAdvertisement";
            this.trcPreferencesAdvertisement.Size = new System.Drawing.Size(212, 45);
            this.trcPreferencesAdvertisement.SmallChange = 5;
            this.trcPreferencesAdvertisement.TabIndex = 21;
            this.trcPreferencesAdvertisement.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trcPreferencesAdvertisement.Visible = false;
            this.trcPreferencesAdvertisement.Scroll += new System.EventHandler(this.trcPreferencesAdvertisement_Scroll);
            // 
            // trcPreferencesNewsItem
            // 
            this.trcPreferencesNewsItem.LargeChange = 10;
            this.trcPreferencesNewsItem.Location = new System.Drawing.Point(15, 261);
            this.trcPreferencesNewsItem.Maximum = 100;
            this.trcPreferencesNewsItem.Name = "trcPreferencesNewsItem";
            this.trcPreferencesNewsItem.Size = new System.Drawing.Size(212, 45);
            this.trcPreferencesNewsItem.SmallChange = 5;
            this.trcPreferencesNewsItem.TabIndex = 18;
            this.trcPreferencesNewsItem.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trcPreferencesNewsItem.Visible = false;
            this.trcPreferencesNewsItem.Scroll += new System.EventHandler(this.trcPreferencesNewsItem_Scroll);
            // 
            // lblStaticPreferences5
            // 
            this.lblStaticPreferences5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStaticPreferences5.AutoSize = true;
            this.lblStaticPreferences5.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.lblStaticPreferences5.ForeColor = System.Drawing.Color.White;
            this.lblStaticPreferences5.Location = new System.Drawing.Point(12, 245);
            this.lblStaticPreferences5.Name = "lblStaticPreferences5";
            this.lblStaticPreferences5.Size = new System.Drawing.Size(225, 13);
            this.lblStaticPreferences5.TabIndex = 22;
            this.lblStaticPreferences5.Text = "Set probability of occuring: News item";
            this.lblStaticPreferences5.Visible = false;
            // 
            // lblStaticPreferences4
            // 
            this.lblStaticPreferences4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStaticPreferences4.AutoSize = true;
            this.lblStaticPreferences4.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.lblStaticPreferences4.ForeColor = System.Drawing.Color.White;
            this.lblStaticPreferences4.Location = new System.Drawing.Point(283, 181);
            this.lblStaticPreferences4.Name = "lblStaticPreferences4";
            this.lblStaticPreferences4.Size = new System.Drawing.Size(249, 13);
            this.lblStaticPreferences4.TabIndex = 23;
            this.lblStaticPreferences4.Text = "Set probability of occuring: Advertisement";
            this.lblStaticPreferences4.Visible = false;
            // 
            // btnToggleSettingsVisibility
            // 
            this.btnToggleSettingsVisibility.Location = new System.Drawing.Point(623, 349);
            this.btnToggleSettingsVisibility.Name = "btnToggleSettingsVisibility";
            this.btnToggleSettingsVisibility.Size = new System.Drawing.Size(165, 23);
            this.btnToggleSettingsVisibility.TabIndex = 27;
            this.btnToggleSettingsVisibility.Text = "Toggle display settings";
            this.btnToggleSettingsVisibility.UseVisualStyleBackColor = true;
            this.btnToggleSettingsVisibility.Click += new System.EventHandler(this.btnToggleSettingsVisibility_Click);
            // 
            // lblDisplayValueSong
            // 
            this.lblDisplayValueSong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDisplayValueSong.AutoSize = true;
            this.lblDisplayValueSong.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.lblDisplayValueSong.ForeColor = System.Drawing.Color.White;
            this.lblDisplayValueSong.Location = new System.Drawing.Point(233, 124);
            this.lblDisplayValueSong.Name = "lblDisplayValueSong";
            this.lblDisplayValueSong.Size = new System.Drawing.Size(14, 13);
            this.lblDisplayValueSong.TabIndex = 28;
            this.lblDisplayValueSong.Text = "0";
            this.lblDisplayValueSong.Visible = false;
            // 
            // lblDisplayValueNewsItem
            // 
            this.lblDisplayValueNewsItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDisplayValueNewsItem.AutoSize = true;
            this.lblDisplayValueNewsItem.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.lblDisplayValueNewsItem.ForeColor = System.Drawing.Color.White;
            this.lblDisplayValueNewsItem.Location = new System.Drawing.Point(233, 261);
            this.lblDisplayValueNewsItem.Name = "lblDisplayValueNewsItem";
            this.lblDisplayValueNewsItem.Size = new System.Drawing.Size(14, 13);
            this.lblDisplayValueNewsItem.TabIndex = 29;
            this.lblDisplayValueNewsItem.Text = "0";
            this.lblDisplayValueNewsItem.Visible = false;
            // 
            // lblDisplayValueQuote
            // 
            this.lblDisplayValueQuote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDisplayValueQuote.AutoSize = true;
            this.lblDisplayValueQuote.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.lblDisplayValueQuote.ForeColor = System.Drawing.Color.White;
            this.lblDisplayValueQuote.Location = new System.Drawing.Point(233, 197);
            this.lblDisplayValueQuote.Name = "lblDisplayValueQuote";
            this.lblDisplayValueQuote.Size = new System.Drawing.Size(14, 13);
            this.lblDisplayValueQuote.TabIndex = 30;
            this.lblDisplayValueQuote.Text = "0";
            this.lblDisplayValueQuote.Visible = false;
            // 
            // lblDisplayValueAdvertisement
            // 
            this.lblDisplayValueAdvertisement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDisplayValueAdvertisement.AutoSize = true;
            this.lblDisplayValueAdvertisement.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.lblDisplayValueAdvertisement.ForeColor = System.Drawing.Color.White;
            this.lblDisplayValueAdvertisement.Location = new System.Drawing.Point(504, 197);
            this.lblDisplayValueAdvertisement.Name = "lblDisplayValueAdvertisement";
            this.lblDisplayValueAdvertisement.Size = new System.Drawing.Size(14, 13);
            this.lblDisplayValueAdvertisement.TabIndex = 31;
            this.lblDisplayValueAdvertisement.Text = "0";
            this.lblDisplayValueAdvertisement.Visible = false;
            // 
            // lblDisplayValueStinger
            // 
            this.lblDisplayValueStinger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDisplayValueStinger.AutoSize = true;
            this.lblDisplayValueStinger.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.lblDisplayValueStinger.ForeColor = System.Drawing.Color.White;
            this.lblDisplayValueStinger.Location = new System.Drawing.Point(504, 124);
            this.lblDisplayValueStinger.Name = "lblDisplayValueStinger";
            this.lblDisplayValueStinger.Size = new System.Drawing.Size(14, 13);
            this.lblDisplayValueStinger.TabIndex = 32;
            this.lblDisplayValueStinger.Text = "0";
            this.lblDisplayValueStinger.Visible = false;
            // 
            // btnDebugShowPlayer
            // 
            this.btnDebugShowPlayer.Location = new System.Drawing.Point(286, 256);
            this.btnDebugShowPlayer.Name = "btnDebugShowPlayer";
            this.btnDebugShowPlayer.Size = new System.Drawing.Size(232, 23);
            this.btnDebugShowPlayer.TabIndex = 33;
            this.btnDebugShowPlayer.Text = "Toggle show WMP (debug)";
            this.btnDebugShowPlayer.UseVisualStyleBackColor = true;
            this.btnDebugShowPlayer.Visible = false;
            this.btnDebugShowPlayer.Click += new System.EventHandler(this.btnDebugShowPlayer_Click);
            // 
            // lblError
            // 
            this.lblError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.lblError.ForeColor = System.Drawing.Color.White;
            this.lblError.Location = new System.Drawing.Point(12, 349);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 34;
            // 
            // tmrCheckError
            // 
            this.tmrCheckError.Enabled = true;
            this.tmrCheckError.Interval = 500;
            this.tmrCheckError.Tick += new System.EventHandler(this.tmrCheckError_Tick);
            // 
            // btnStart1
            // 
            this.btnStart1.Location = new System.Drawing.Point(587, 113);
            this.btnStart1.Name = "btnStart1";
            this.btnStart1.Size = new System.Drawing.Size(201, 23);
            this.btnStart1.TabIndex = 35;
            this.btnStart1.Text = "Secondairy button to start";
            this.btnStart1.UseVisualStyleBackColor = true;
            this.btnStart1.Visible = false;
            this.btnStart1.Click += new System.EventHandler(this.btnStart1_Click);
            // 
            // dlgFileLoad
            // 
            this.dlgFileLoad.Filter = "GTARadioForDesktop configuration files|*.txt|All files|*.*";
            // 
            // dlgFileSave
            // 
            this.dlgFileSave.FileName = "gta_radio_config.txt";
            this.dlgFileSave.Filter = "GTARadioForDesktop configuration file|*.txt";
            // 
            // trcVolume
            // 
            this.trcVolume.LargeChange = 10;
            this.trcVolume.Location = new System.Drawing.Point(623, 317);
            this.trcVolume.Maximum = 100;
            this.trcVolume.Name = "trcVolume";
            this.trcVolume.Size = new System.Drawing.Size(165, 45);
            this.trcVolume.SmallChange = 5;
            this.trcVolume.TabIndex = 36;
            this.trcVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trcVolume.Value = 50;
            this.trcVolume.Scroll += new System.EventHandler(this.trcVolume_Scroll);
            // 
            // lblStaticVolume
            // 
            this.lblStaticVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStaticVolume.AutoSize = true;
            this.lblStaticVolume.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.lblStaticVolume.ForeColor = System.Drawing.Color.White;
            this.lblStaticVolume.Location = new System.Drawing.Point(620, 301);
            this.lblStaticVolume.Name = "lblStaticVolume";
            this.lblStaticVolume.Size = new System.Drawing.Size(54, 13);
            this.lblStaticVolume.TabIndex = 37;
            this.lblStaticVolume.Text = "Volume:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(800, 448);
            this.Controls.Add(this.lblStaticVolume);
            this.Controls.Add(this.btnToggleSettingsVisibility);
            this.Controls.Add(this.trcVolume);
            this.Controls.Add(this.btnStart1);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnDebugShowPlayer);
            this.Controls.Add(this.lblDisplayValueStinger);
            this.Controls.Add(this.lblDisplayValueAdvertisement);
            this.Controls.Add(this.lblDisplayValueQuote);
            this.Controls.Add(this.lblDisplayValueNewsItem);
            this.Controls.Add(this.lblDisplayValueSong);
            this.Controls.Add(this.lblStaticPreferences1);
            this.Controls.Add(this.lblStaticPreferences2);
            this.Controls.Add(this.lblStaticPreferences3);
            this.Controls.Add(this.lblStaticPreferences4);
            this.Controls.Add(this.lblStaticPreferences5);
            this.Controls.Add(this.btnLoadPreferences);
            this.Controls.Add(this.btnSavePreferences);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.lblStaticSelectStation);
            this.Controls.Add(this.cbbSelectStation);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.player);
            this.Controls.Add(this.txtChooseFolder);
            this.Controls.Add(this.btnChooseFolder);
            this.Controls.Add(this.trcPreferencesNewsItem);
            this.Controls.Add(this.trcPreferencesAdvertisement);
            this.Controls.Add(this.trcPreferencesQuote);
            this.Controls.Add(this.trcPreferencesStinger);
            this.Controls.Add(this.trcPreferencesSong);
            this.Controls.Add(this.pctRadioLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "GrandTheftAutoRadioForDesktop";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRadioLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcPreferencesSong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcPreferencesStinger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcPreferencesQuote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcPreferencesAdvertisement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcPreferencesNewsItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChooseFolder;
        private System.Windows.Forms.FolderBrowserDialog dlgChooseFolder;
        private System.Windows.Forms.TextBox txtChooseFolder;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox cbbSelectStation;
        private System.Windows.Forms.Label lblStaticSelectStation;
        private System.Windows.Forms.PictureBox pctRadioLogo;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnSavePreferences;
        private System.Windows.Forms.Button btnLoadPreferences;
        public AxWMPLib.AxWindowsMediaPlayer player;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TrackBar trcPreferencesSong;
        private System.Windows.Forms.TrackBar trcPreferencesStinger;
        private System.Windows.Forms.Label lblStaticPreferences3;
        private System.Windows.Forms.Label lblStaticPreferences2;
        private System.Windows.Forms.Label lblStaticPreferences1;
        private System.Windows.Forms.TrackBar trcPreferencesQuote;
        private System.Windows.Forms.TrackBar trcPreferencesAdvertisement;
        private System.Windows.Forms.TrackBar trcPreferencesNewsItem;
        private System.Windows.Forms.Label lblStaticPreferences5;
        private System.Windows.Forms.Label lblStaticPreferences4;
        private System.Windows.Forms.Button btnToggleSettingsVisibility;
        private System.Windows.Forms.Label lblDisplayValueSong;
        private System.Windows.Forms.Label lblDisplayValueNewsItem;
        private System.Windows.Forms.Label lblDisplayValueQuote;
        private System.Windows.Forms.Label lblDisplayValueAdvertisement;
        private System.Windows.Forms.Label lblDisplayValueStinger;
        private System.Windows.Forms.Button btnDebugShowPlayer;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Timer tmrCheckError;
        private System.Windows.Forms.Button btnStart1;
        private System.Windows.Forms.OpenFileDialog dlgFileLoad;
        private System.Windows.Forms.SaveFileDialog dlgFileSave;
        private System.Windows.Forms.TrackBar trcVolume;
        private System.Windows.Forms.Label lblStaticVolume;
    }
}

