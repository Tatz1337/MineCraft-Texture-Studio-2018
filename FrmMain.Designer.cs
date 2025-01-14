﻿using System;

using System.Windows.Forms;

namespace MinecraftTextureStudio
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            System.Windows.Forms.TabControl tabControl;
            this.lblTexturePack = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSaveToMinecraft = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnOpenDirectory = new System.Windows.Forms.Button();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblCoded = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.lblMinecraftPath = new System.Windows.Forms.Label();
            this.txtMinecraftPath = new System.Windows.Forms.TextBox();
            this.btnPathBrowse = new System.Windows.Forms.Button();
            this.lblMinecraftJarPath = new System.Windows.Forms.Label();
            this.txtMinecraftJarPath = new System.Windows.Forms.TextBox();
            this.btnJarBrowse = new System.Windows.Forms.Button();
            this.lblExtractedJarPath = new System.Windows.Forms.Label();
            this.txtExtractedJarPath = new System.Windows.Forms.TextBox();
            this.btnExtractedJarBrowse = new System.Windows.Forms.Button();
            this.radExtractFromJar = new System.Windows.Forms.RadioButton();
            this.radExtractedPath = new System.Windows.Forms.RadioButton();
            this.lblExtractJarOption = new System.Windows.Forms.Label();
            this.lblSortOption = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.radId = new System.Windows.Forms.RadioButton();
            this.radAlphabetical = new System.Windows.Forms.RadioButton();
            this.tabOrganise = new System.Windows.Forms.TabPage();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.lblShared1 = new System.Windows.Forms.Label();
            this.lblShared2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabFont = new System.Windows.Forms.TabPage();
            this.btnBrowseFont = new System.Windows.Forms.Button();
            this.lblFont = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.tabSounds = new System.Windows.Forms.TabPage();
            this.panelDropSound = new System.Windows.Forms.Panel();
            this.lblDropSound = new System.Windows.Forms.Label();
            this.cmbSounds = new System.Windows.Forms.ComboBox();
            this.btnAddSounds = new System.Windows.Forms.Button();
            this.lblAddSounds1 = new System.Windows.Forms.Label();
            this.lblAddSounds2 = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPlayNext = new System.Windows.Forms.Button();
            this.btnBrowseSound = new System.Windows.Forms.Button();
            this.tabItems = new System.Windows.Forms.TabPage();
            this.lblFilename = new System.Windows.Forms.Label();
            this.cmbItems = new System.Windows.Forms.ComboBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.itemPanelColour1 = new System.Windows.Forms.Panel();
            this.itemPanelColour9 = new System.Windows.Forms.Panel();
            this.itemPanelColour2 = new System.Windows.Forms.Panel();
            this.itemPanelColour10 = new System.Windows.Forms.Panel();
            this.itemPanelColour3 = new System.Windows.Forms.Panel();
            this.itemPanelColour11 = new System.Windows.Forms.Panel();
            this.itemPanelColour4 = new System.Windows.Forms.Panel();
            this.itemPanelColour12 = new System.Windows.Forms.Panel();
            this.itemPanelColour5 = new System.Windows.Forms.Panel();
            this.itemPanelColour13 = new System.Windows.Forms.Panel();
            this.itemPanelColour6 = new System.Windows.Forms.Panel();
            this.itemPanelColour14 = new System.Windows.Forms.Panel();
            this.itemPanelColour7 = new System.Windows.Forms.Panel();
            this.itemPanelColour15 = new System.Windows.Forms.Panel();
            this.itemPanelColour8 = new System.Windows.Forms.Panel();
            this.itemPanelColour16 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.itemPanelColour = new System.Windows.Forms.Panel();
            this.btnItemUndo = new System.Windows.Forms.Button();
            this.btnItemRedo = new System.Windows.Forms.Button();
            this.btnItemColour = new System.Windows.Forms.Button();
            this.itemPanelColour17 = new System.Windows.Forms.Panel();
            this.itemPanelColour18 = new System.Windows.Forms.Panel();
            this.itemPanelColour19 = new System.Windows.Forms.Panel();
            this.itemPanelColour20 = new System.Windows.Forms.Panel();
            this.itemPanelColour21 = new System.Windows.Forms.Panel();
            this.itemPanelColour22 = new System.Windows.Forms.Panel();
            this.itemPanelColour23 = new System.Windows.Forms.Panel();
            this.itemPanelColour24 = new System.Windows.Forms.Panel();
            this.cmbItemFrames = new System.Windows.Forms.ComboBox();
            this.tabBlocks = new System.Windows.Forms.TabPage();
            this.lblFilename5 = new System.Windows.Forms.Label();
            this.lblFilename7 = new System.Windows.Forms.Label();
            this.lblFilename4 = new System.Windows.Forms.Label();
            this.lblFilename6 = new System.Windows.Forms.Label();
            this.lblFilename2 = new System.Windows.Forms.Label();
            this.lblFilename8 = new System.Windows.Forms.Label();
            this.lblFilename3 = new System.Windows.Forms.Label();
            this.lblFilename9 = new System.Windows.Forms.Label();
            this.lblFilename1 = new System.Windows.Forms.Label();
            this.cmbBlocks = new System.Windows.Forms.ComboBox();
            this.cmbFrames1 = new System.Windows.Forms.ComboBox();
            this.cmbFrames2 = new System.Windows.Forms.ComboBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panelColour1 = new System.Windows.Forms.Panel();
            this.panelColour9 = new System.Windows.Forms.Panel();
            this.panelColour2 = new System.Windows.Forms.Panel();
            this.panelColour10 = new System.Windows.Forms.Panel();
            this.panelColour3 = new System.Windows.Forms.Panel();
            this.panelColour11 = new System.Windows.Forms.Panel();
            this.panelColour4 = new System.Windows.Forms.Panel();
            this.panelColour12 = new System.Windows.Forms.Panel();
            this.panelColour5 = new System.Windows.Forms.Panel();
            this.panelColour13 = new System.Windows.Forms.Panel();
            this.panelColour6 = new System.Windows.Forms.Panel();
            this.panelColour14 = new System.Windows.Forms.Panel();
            this.panelColour7 = new System.Windows.Forms.Panel();
            this.panelColour15 = new System.Windows.Forms.Panel();
            this.panelColour8 = new System.Windows.Forms.Panel();
            this.panelColour16 = new System.Windows.Forms.Panel();
            this.lblColour = new System.Windows.Forms.Label();
            this.panelColour = new System.Windows.Forms.Panel();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnRedo = new System.Windows.Forms.Button();
            this.btnColour = new System.Windows.Forms.Button();
            this.panelColour17 = new System.Windows.Forms.Panel();
            this.panelColour18 = new System.Windows.Forms.Panel();
            this.panelColour19 = new System.Windows.Forms.Panel();
            this.panelColour20 = new System.Windows.Forms.Panel();
            this.panelColour21 = new System.Windows.Forms.Panel();
            this.panelColour22 = new System.Windows.Forms.Panel();
            this.panelColour23 = new System.Windows.Forms.Panel();
            this.panelColour24 = new System.Windows.Forms.Panel();
            this.chkShowCubes = new System.Windows.Forms.CheckBox();
            this.lblTexture3D = new System.Windows.Forms.Label();
            this.tabPackDetails = new System.Windows.Forms.TabPage();
            this.lblTexturePackName = new System.Windows.Forms.Label();
            this.lblPackThumbnail = new System.Windows.Forms.Label();
            this.btnImageBrowse = new System.Windows.Forms.Button();
            this.lblMarkup = new System.Windows.Forms.Label();
            this.txtMarkup = new System.Windows.Forms.TextBox();
            this.txtResourcePackName = new System.Windows.Forms.RichTextBox();
            this.btnAddColour = new System.Windows.Forms.Button();
            this.cmbTextColour = new System.Windows.Forms.ComboBox();
            this.btnBold = new System.Windows.Forms.Button();
            this.btnItalic = new System.Windows.Forms.Button();
            this.btnUnderline = new System.Windows.Forms.Button();
            this.btnStrikethrough = new System.Windows.Forms.Button();
            this.btnRemoveFormatting = new System.Windows.Forms.Button();
            this.panelThumbnail = new MinecraftTextureStudio.DoubleBufferedPanel();
            this.lblDropImage = new System.Windows.Forms.Label();
            this.btnPicker = new MinecraftTextureStudio.ToggleButton();
            this.btnClear = new MinecraftTextureStudio.ToggleButton();
            this.btnBucket = new MinecraftTextureStudio.ToggleButton();
            this.btnRectangle = new MinecraftTextureStudio.ToggleButton();
            this.btnLine = new MinecraftTextureStudio.ToggleButton();
            this.btnPen = new MinecraftTextureStudio.ToggleButton();
            this.panel5 = new MinecraftTextureStudio.DoubleBufferedPanel();
            this.panel6 = new MinecraftTextureStudio.DoubleBufferedPanel();
            this.panel4 = new MinecraftTextureStudio.DoubleBufferedPanel();
            this.panel8 = new MinecraftTextureStudio.DoubleBufferedPanel();
            this.panel2 = new MinecraftTextureStudio.DoubleBufferedPanel();
            this.panel9 = new MinecraftTextureStudio.DoubleBufferedPanel();
            this.panel3 = new MinecraftTextureStudio.DoubleBufferedPanel();
            this.panel1 = new MinecraftTextureStudio.DoubleBufferedPanel();
            this.panel7 = new MinecraftTextureStudio.DoubleBufferedPanel();
            this.btnItemPicker = new MinecraftTextureStudio.ToggleButton();
            this.btnItemClear = new MinecraftTextureStudio.ToggleButton();
            this.btnItemBucket = new MinecraftTextureStudio.ToggleButton();
            this.btnItemRectangle = new MinecraftTextureStudio.ToggleButton();
            this.btnItemLine = new MinecraftTextureStudio.ToggleButton();
            this.btnItemPen = new MinecraftTextureStudio.ToggleButton();
            this.itemPanel = new MinecraftTextureStudio.DoubleBufferedPanel();
            this.panelFont = new MinecraftTextureStudio.DoubleBufferedPanel();
            this.lblFontDropImage = new System.Windows.Forms.Label();
            tabControl = new System.Windows.Forms.TabControl();
            this.tabAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabSettings.SuspendLayout();
            this.panel10.SuspendLayout();
            this.tabOrganise.SuspendLayout();
            this.tabFont.SuspendLayout();
            this.tabSounds.SuspendLayout();
            this.panelDropSound.SuspendLayout();
            this.tabItems.SuspendLayout();
            this.panel12.SuspendLayout();
            this.tabBlocks.SuspendLayout();
            this.panel11.SuspendLayout();
            this.tabPackDetails.SuspendLayout();
            tabControl.SuspendLayout();
            this.panelThumbnail.SuspendLayout();
            this.panelFont.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTexturePack
            // 
            this.lblTexturePack.AutoSize = true;
            this.lblTexturePack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexturePack.Location = new System.Drawing.Point(9, 7);
            this.lblTexturePack.Name = "lblTexturePack";
            this.lblTexturePack.Size = new System.Drawing.Size(186, 16);
            this.lblTexturePack.TabIndex = 33;
            this.lblTexturePack.Text = "Resource Pack: None loaded";
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(12, 43);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(139, 40);
            this.btnNew.TabIndex = 34;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(12, 86);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(139, 39);
            this.btnOpen.TabIndex = 35;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(12, 174);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(139, 43);
            this.btnSave.TabIndex = 36;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSaveToMinecraft
            // 
            this.btnSaveToMinecraft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveToMinecraft.Location = new System.Drawing.Point(12, 223);
            this.btnSaveToMinecraft.Name = "btnSaveToMinecraft";
            this.btnSaveToMinecraft.Size = new System.Drawing.Size(139, 43);
            this.btnSaveToMinecraft.TabIndex = 37;
            this.btnSaveToMinecraft.Text = "Save To Minecraft";
            this.btnSaveToMinecraft.UseVisualStyleBackColor = true;
            this.btnSaveToMinecraft.Click += new System.EventHandler(this.btnSaveToMinecraft_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnOpenDirectory
            // 
            this.btnOpenDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenDirectory.Location = new System.Drawing.Point(12, 127);
            this.btnOpenDirectory.Name = "btnOpenDirectory";
            this.btnOpenDirectory.Size = new System.Drawing.Size(139, 41);
            this.btnOpenDirectory.TabIndex = 38;
            this.btnOpenDirectory.Text = "Open Directory";
            this.btnOpenDirectory.UseVisualStyleBackColor = true;
            this.btnOpenDirectory.Click += new System.EventHandler(this.btnOpenDirectory_Click);
            // 
            // tabAbout
            // 
            this.tabAbout.BackColor = System.Drawing.Color.White;
            this.tabAbout.Controls.Add(this.label9);
            this.tabAbout.Controls.Add(this.pictureBox1);
            this.tabAbout.Controls.Add(this.lblEmail);
            this.tabAbout.Controls.Add(this.lblCoded);
            this.tabAbout.Controls.Add(this.lblVersion);
            this.tabAbout.Controls.Add(this.lblTitle);
            this.tabAbout.Location = new System.Drawing.Point(4, 28);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Size = new System.Drawing.Size(768, 750);
            this.tabAbout.TabIndex = 5;
            this.tabAbout.Text = "About";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(21, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(323, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Minecraft Texture Studio 2018 v1.12.2";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(21, 54);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(130, 24);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "Version 1.12.2";
            this.lblVersion.Click += new System.EventHandler(this.lblVersion_Click);
            // 
            // lblCoded
            // 
            this.lblCoded.AutoSize = true;
            this.lblCoded.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoded.Location = new System.Drawing.Point(21, 87);
            this.lblCoded.Name = "lblCoded";
            this.lblCoded.Size = new System.Drawing.Size(416, 24);
            this.lblCoded.TabIndex = 2;
            this.lblCoded.Text = "Based on tertrih MineCraft Texture Studio 1.0.8 V";
            this.lblCoded.Click += new System.EventHandler(this.lblCoded_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(21, 137);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(300, 24);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email:einfachlindow@outlook.com";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 203);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(465, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(287, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Minecraft texture Studio 2018 by MeicoomonVR";
            // 
            // tabSettings
            // 
            this.tabSettings.BackColor = System.Drawing.Color.White;
            this.tabSettings.Controls.Add(this.panel10);
            this.tabSettings.Controls.Add(this.lblSortOption);
            this.tabSettings.Controls.Add(this.lblExtractJarOption);
            this.tabSettings.Controls.Add(this.radExtractedPath);
            this.tabSettings.Controls.Add(this.radExtractFromJar);
            this.tabSettings.Controls.Add(this.btnExtractedJarBrowse);
            this.tabSettings.Controls.Add(this.txtExtractedJarPath);
            this.tabSettings.Controls.Add(this.txtMinecraftJarPath);
            this.tabSettings.Controls.Add(this.txtMinecraftPath);
            this.tabSettings.Controls.Add(this.lblExtractedJarPath);
            this.tabSettings.Controls.Add(this.btnJarBrowse);
            this.tabSettings.Controls.Add(this.lblMinecraftJarPath);
            this.tabSettings.Controls.Add(this.btnPathBrowse);
            this.tabSettings.Controls.Add(this.lblMinecraftPath);
            this.tabSettings.Location = new System.Drawing.Point(4, 28);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(768, 750);
            this.tabSettings.TabIndex = 3;
            this.tabSettings.Text = "Settings";
            // 
            // lblMinecraftPath
            // 
            this.lblMinecraftPath.AutoSize = true;
            this.lblMinecraftPath.Location = new System.Drawing.Point(12, 12);
            this.lblMinecraftPath.Name = "lblMinecraftPath";
            this.lblMinecraftPath.Size = new System.Drawing.Size(92, 16);
            this.lblMinecraftPath.TabIndex = 0;
            this.lblMinecraftPath.Text = "Minecraft Path";
            // 
            // txtMinecraftPath
            // 
            this.txtMinecraftPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMinecraftPath.Location = new System.Drawing.Point(135, 9);
            this.txtMinecraftPath.Name = "txtMinecraftPath";
            this.txtMinecraftPath.Size = new System.Drawing.Size(429, 22);
            this.txtMinecraftPath.TabIndex = 1;
            // 
            // btnPathBrowse
            // 
            this.btnPathBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPathBrowse.Location = new System.Drawing.Point(579, 9);
            this.btnPathBrowse.Name = "btnPathBrowse";
            this.btnPathBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnPathBrowse.TabIndex = 2;
            this.btnPathBrowse.Text = "Browse";
            this.btnPathBrowse.UseVisualStyleBackColor = true;
            this.btnPathBrowse.Click += new System.EventHandler(this.btnPathBrowse_Click);
            // 
            // lblMinecraftJarPath
            // 
            this.lblMinecraftJarPath.AutoSize = true;
            this.lblMinecraftJarPath.Location = new System.Drawing.Point(12, 45);
            this.lblMinecraftJarPath.Name = "lblMinecraftJarPath";
            this.lblMinecraftJarPath.Size = new System.Drawing.Size(114, 16);
            this.lblMinecraftJarPath.TabIndex = 3;
            this.lblMinecraftJarPath.Text = "Minecraft Jar Path";
            // 
            // txtMinecraftJarPath
            // 
            this.txtMinecraftJarPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMinecraftJarPath.Location = new System.Drawing.Point(135, 42);
            this.txtMinecraftJarPath.Name = "txtMinecraftJarPath";
            this.txtMinecraftJarPath.Size = new System.Drawing.Size(429, 22);
            this.txtMinecraftJarPath.TabIndex = 4;
            // 
            // btnJarBrowse
            // 
            this.btnJarBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnJarBrowse.Location = new System.Drawing.Point(579, 42);
            this.btnJarBrowse.Name = "btnJarBrowse";
            this.btnJarBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnJarBrowse.TabIndex = 5;
            this.btnJarBrowse.Text = "Browse";
            this.btnJarBrowse.UseVisualStyleBackColor = true;
            this.btnJarBrowse.Click += new System.EventHandler(this.btnJarBrowse_Click);
            // 
            // lblExtractedJarPath
            // 
            this.lblExtractedJarPath.AutoSize = true;
            this.lblExtractedJarPath.Location = new System.Drawing.Point(12, 78);
            this.lblExtractedJarPath.Name = "lblExtractedJarPath";
            this.lblExtractedJarPath.Size = new System.Drawing.Size(116, 16);
            this.lblExtractedJarPath.TabIndex = 6;
            this.lblExtractedJarPath.Text = "Extracted Jar Path";
            // 
            // txtExtractedJarPath
            // 
            this.txtExtractedJarPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExtractedJarPath.Location = new System.Drawing.Point(135, 75);
            this.txtExtractedJarPath.Name = "txtExtractedJarPath";
            this.txtExtractedJarPath.Size = new System.Drawing.Size(429, 22);
            this.txtExtractedJarPath.TabIndex = 7;
            // 
            // btnExtractedJarBrowse
            // 
            this.btnExtractedJarBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExtractedJarBrowse.Location = new System.Drawing.Point(579, 71);
            this.btnExtractedJarBrowse.Name = "btnExtractedJarBrowse";
            this.btnExtractedJarBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnExtractedJarBrowse.TabIndex = 8;
            this.btnExtractedJarBrowse.Text = "Browse";
            this.btnExtractedJarBrowse.UseVisualStyleBackColor = true;
            this.btnExtractedJarBrowse.Click += new System.EventHandler(this.btnExtractedJarBrowse_Click);
            // 
            // radExtractFromJar
            // 
            this.radExtractFromJar.AutoSize = true;
            this.radExtractFromJar.Checked = true;
            this.radExtractFromJar.Location = new System.Drawing.Point(135, 110);
            this.radExtractFromJar.Name = "radExtractFromJar";
            this.radExtractFromJar.Size = new System.Drawing.Size(174, 20);
            this.radExtractFromJar.TabIndex = 9;
            this.radExtractFromJar.TabStop = true;
            this.radExtractFromJar.Text = "Extract from Minecraft Jar";
            this.radExtractFromJar.UseVisualStyleBackColor = true;
            this.radExtractFromJar.CheckedChanged += new System.EventHandler(this.radExtractFromJar_CheckedChanged);
            // 
            // radExtractedPath
            // 
            this.radExtractedPath.AutoSize = true;
            this.radExtractedPath.Location = new System.Drawing.Point(329, 111);
            this.radExtractedPath.Name = "radExtractedPath";
            this.radExtractedPath.Size = new System.Drawing.Size(162, 20);
            this.radExtractedPath.TabIndex = 10;
            this.radExtractedPath.Text = "Use Extracted Jar Path";
            this.radExtractedPath.UseVisualStyleBackColor = true;
            this.radExtractedPath.CheckedChanged += new System.EventHandler(this.radExtractedPath_CheckedChanged);
            // 
            // lblExtractJarOption
            // 
            this.lblExtractJarOption.AutoSize = true;
            this.lblExtractJarOption.Location = new System.Drawing.Point(12, 111);
            this.lblExtractJarOption.Name = "lblExtractJarOption";
            this.lblExtractJarOption.Size = new System.Drawing.Size(70, 16);
            this.lblExtractJarOption.TabIndex = 11;
            this.lblExtractJarOption.Text = "Extract Jar";
            // 
            // lblSortOption
            // 
            this.lblSortOption.AutoSize = true;
            this.lblSortOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortOption.Location = new System.Drawing.Point(12, 144);
            this.lblSortOption.Name = "lblSortOption";
            this.lblSortOption.Size = new System.Drawing.Size(74, 16);
            this.lblSortOption.TabIndex = 12;
            this.lblSortOption.Text = "Sort Option";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.radAlphabetical);
            this.panel10.Controls.Add(this.radId);
            this.panel10.Location = new System.Drawing.Point(122, 136);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(364, 34);
            this.panel10.TabIndex = 15;
            // 
            // radId
            // 
            this.radId.AutoSize = true;
            this.radId.Checked = true;
            this.radId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radId.Location = new System.Drawing.Point(13, 6);
            this.radId.Name = "radId";
            this.radId.Size = new System.Drawing.Size(39, 20);
            this.radId.TabIndex = 15;
            this.radId.TabStop = true;
            this.radId.Text = "ID";
            this.radId.UseVisualStyleBackColor = true;
            this.radId.CheckedChanged += new System.EventHandler(this.radId_CheckedChanged);
            // 
            // radAlphabetical
            // 
            this.radAlphabetical.AutoSize = true;
            this.radAlphabetical.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAlphabetical.Location = new System.Drawing.Point(108, 6);
            this.radAlphabetical.Name = "radAlphabetical";
            this.radAlphabetical.Size = new System.Drawing.Size(101, 20);
            this.radAlphabetical.TabIndex = 16;
            this.radAlphabetical.Text = "Alphabetical";
            this.radAlphabetical.UseVisualStyleBackColor = true;
            this.radAlphabetical.CheckedChanged += new System.EventHandler(this.radAlphabetical_CheckedChanged);
            // 
            // tabOrganise
            // 
            this.tabOrganise.BackColor = System.Drawing.Color.White;
            this.tabOrganise.Controls.Add(this.label5);
            this.tabOrganise.Controls.Add(this.label4);
            this.tabOrganise.Controls.Add(this.label3);
            this.tabOrganise.Controls.Add(this.label2);
            this.tabOrganise.Controls.Add(this.label1);
            this.tabOrganise.Controls.Add(this.lblShared2);
            this.tabOrganise.Controls.Add(this.lblShared1);
            this.tabOrganise.Controls.Add(this.btnSaveChanges);
            this.tabOrganise.Location = new System.Drawing.Point(4, 28);
            this.tabOrganise.Name = "tabOrganise";
            this.tabOrganise.Size = new System.Drawing.Size(768, 750);
            this.tabOrganise.TabIndex = 4;
            this.tabOrganise.Text = "Organise";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Enabled = false;
            this.btnSaveChanges.Location = new System.Drawing.Point(351, 15);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(118, 24);
            this.btnSaveChanges.TabIndex = 0;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // lblShared1
            // 
            this.lblShared1.AutoSize = true;
            this.lblShared1.Location = new System.Drawing.Point(351, 57);
            this.lblShared1.Name = "lblShared1";
            this.lblShared1.Size = new System.Drawing.Size(161, 16);
            this.lblShared1.TabIndex = 1;
            this.lblShared1.Text = "Some textures are shared";
            // 
            // lblShared2
            // 
            this.lblShared2.AutoSize = true;
            this.lblShared2.Location = new System.Drawing.Point(351, 75);
            this.lblShared2.Name = "lblShared2";
            this.lblShared2.Size = new System.Drawing.Size(215, 16);
            this.lblShared2.TabIndex = 2;
            this.lblShared2.Text = "Even if you deselect the block here";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "If the texture it uses is used by other blocks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "The texture will remain in the resource pack";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "If a deselected block shares all of its textures";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "With blocks that remain in the resource pack";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "It too will remain in the resource pack";
            // 
            // tabFont
            // 
            this.tabFont.BackColor = System.Drawing.Color.White;
            this.tabFont.Controls.Add(this.linkLabel2);
            this.tabFont.Controls.Add(this.linkLabel1);
            this.tabFont.Controls.Add(this.lblFont);
            this.tabFont.Controls.Add(this.btnBrowseFont);
            this.tabFont.Controls.Add(this.panelFont);
            this.tabFont.Location = new System.Drawing.Point(4, 28);
            this.tabFont.Name = "tabFont";
            this.tabFont.Size = new System.Drawing.Size(768, 750);
            this.tabFont.TabIndex = 7;
            this.tabFont.Text = "Font";
            // 
            // btnBrowseFont
            // 
            this.btnBrowseFont.Enabled = false;
            this.btnBrowseFont.Location = new System.Drawing.Point(306, 143);
            this.btnBrowseFont.Name = "btnBrowseFont";
            this.btnBrowseFont.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseFont.TabIndex = 7;
            this.btnBrowseFont.Text = "Browse";
            this.btnBrowseFont.UseVisualStyleBackColor = true;
            this.btnBrowseFont.Click += new System.EventHandler(this.btnBrowseFont_Click);
            // 
            // lblFont
            // 
            this.lblFont.AutoSize = true;
            this.lblFont.Location = new System.Drawing.Point(7, 9);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(75, 16);
            this.lblFont.TabIndex = 5;
            this.lblFont.Text = "Font Image";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.linkLabel1.Location = new System.Drawing.Point(12, 683);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(336, 24);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.Text = "Either create the font picture yourself or";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkArea = new System.Windows.Forms.LinkArea(9, 19);
            this.linkLabel2.Location = new System.Drawing.Point(12, 716);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(469, 27);
            this.linkLabel2.TabIndex = 9;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Download MinecraftFontEditor to simplify the process";
            this.linkLabel2.UseCompatibleTextRendering = true;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // tabSounds
            // 
            this.tabSounds.BackColor = System.Drawing.Color.White;
            this.tabSounds.Controls.Add(this.btnBrowseSound);
            this.tabSounds.Controls.Add(this.btnPlayNext);
            this.tabSounds.Controls.Add(this.btnPlay);
            this.tabSounds.Controls.Add(this.lblAddSounds2);
            this.tabSounds.Controls.Add(this.lblAddSounds1);
            this.tabSounds.Controls.Add(this.btnAddSounds);
            this.tabSounds.Controls.Add(this.cmbSounds);
            this.tabSounds.Controls.Add(this.panelDropSound);
            this.tabSounds.Location = new System.Drawing.Point(4, 28);
            this.tabSounds.Name = "tabSounds";
            this.tabSounds.Size = new System.Drawing.Size(768, 750);
            this.tabSounds.TabIndex = 6;
            this.tabSounds.Text = "Sounds";
            // 
            // panelDropSound
            // 
            this.panelDropSound.AllowDrop = true;
            this.panelDropSound.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDropSound.Controls.Add(this.lblDropSound);
            this.panelDropSound.Location = new System.Drawing.Point(9, 82);
            this.panelDropSound.Name = "panelDropSound";
            this.panelDropSound.Size = new System.Drawing.Size(200, 200);
            this.panelDropSound.TabIndex = 38;
            this.panelDropSound.Visible = false;
            // 
            // lblDropSound
            // 
            this.lblDropSound.AllowDrop = true;
            this.lblDropSound.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDropSound.Location = new System.Drawing.Point(30, 37);
            this.lblDropSound.Name = "lblDropSound";
            this.lblDropSound.Size = new System.Drawing.Size(135, 113);
            this.lblDropSound.TabIndex = 1;
            this.lblDropSound.Text = "Drop Sound Here";
            this.lblDropSound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbSounds
            // 
            this.cmbSounds.Enabled = false;
            this.cmbSounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSounds.FormattingEnabled = true;
            this.cmbSounds.Location = new System.Drawing.Point(9, 8);
            this.cmbSounds.Name = "cmbSounds";
            this.cmbSounds.Size = new System.Drawing.Size(232, 24);
            this.cmbSounds.TabIndex = 33;
            // 
            // btnAddSounds
            // 
            this.btnAddSounds.Enabled = false;
            this.btnAddSounds.Location = new System.Drawing.Point(96, 100);
            this.btnAddSounds.Name = "btnAddSounds";
            this.btnAddSounds.Size = new System.Drawing.Size(108, 23);
            this.btnAddSounds.TabIndex = 34;
            this.btnAddSounds.Text = "Add sounds";
            this.btnAddSounds.UseVisualStyleBackColor = true;
            this.btnAddSounds.Click += new System.EventHandler(this.btnAddSounds_Click);
            // 
            // lblAddSounds1
            // 
            this.lblAddSounds1.AutoSize = true;
            this.lblAddSounds1.Location = new System.Drawing.Point(43, 47);
            this.lblAddSounds1.Name = "lblAddSounds1";
            this.lblAddSounds1.Size = new System.Drawing.Size(213, 16);
            this.lblAddSounds1.TabIndex = 35;
            this.lblAddSounds1.Text = "Sounds are not included by default";
            // 
            // lblAddSounds2
            // 
            this.lblAddSounds2.AutoSize = true;
            this.lblAddSounds2.Location = new System.Drawing.Point(18, 70);
            this.lblAddSounds2.Name = "lblAddSounds2";
            this.lblAddSounds2.Size = new System.Drawing.Size(281, 16);
            this.lblAddSounds2.TabIndex = 36;
            this.lblAddSounds2.Text = "Click below to add them to your resource pack";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(9, 44);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 37;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Visible = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPlayNext
            // 
            this.btnPlayNext.Location = new System.Drawing.Point(100, 44);
            this.btnPlayNext.Name = "btnPlayNext";
            this.btnPlayNext.Size = new System.Drawing.Size(90, 23);
            this.btnPlayNext.TabIndex = 39;
            this.btnPlayNext.Text = "Play Next";
            this.btnPlayNext.UseVisualStyleBackColor = true;
            this.btnPlayNext.Visible = false;
            this.btnPlayNext.Click += new System.EventHandler(this.btnPlayNext_Click);
            // 
            // btnBrowseSound
            // 
            this.btnBrowseSound.Enabled = false;
            this.btnBrowseSound.Location = new System.Drawing.Point(255, 9);
            this.btnBrowseSound.Name = "btnBrowseSound";
            this.btnBrowseSound.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseSound.TabIndex = 40;
            this.btnBrowseSound.Text = "Browse";
            this.btnBrowseSound.UseVisualStyleBackColor = true;
            this.btnBrowseSound.Visible = false;
            this.btnBrowseSound.Click += new System.EventHandler(this.btnBrowseSound_Click);
            // 
            // tabItems
            // 
            this.tabItems.AutoScroll = true;
            this.tabItems.BackColor = System.Drawing.Color.White;
            this.tabItems.Controls.Add(this.cmbItemFrames);
            this.tabItems.Controls.Add(this.panel12);
            this.tabItems.Controls.Add(this.cmbItems);
            this.tabItems.Controls.Add(this.lblFilename);
            this.tabItems.Controls.Add(this.itemPanel);
            this.tabItems.Location = new System.Drawing.Point(4, 28);
            this.tabItems.Name = "tabItems";
            this.tabItems.Size = new System.Drawing.Size(768, 750);
            this.tabItems.TabIndex = 8;
            this.tabItems.Text = "Items";
            // 
            // lblFilename
            // 
            this.lblFilename.AutoSize = true;
            this.lblFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilename.Location = new System.Drawing.Point(341, 41);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(64, 16);
            this.lblFilename.TabIndex = 37;
            this.lblFilename.Text = "Filename";
            // 
            // cmbItems
            // 
            this.cmbItems.Enabled = false;
            this.cmbItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbItems.FormattingEnabled = true;
            this.cmbItems.Location = new System.Drawing.Point(344, 3);
            this.cmbItems.Name = "cmbItems";
            this.cmbItems.Size = new System.Drawing.Size(232, 24);
            this.cmbItems.TabIndex = 35;
            // 
            // panel12
            // 
            this.panel12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel12.Controls.Add(this.itemPanelColour24);
            this.panel12.Controls.Add(this.itemPanelColour23);
            this.panel12.Controls.Add(this.itemPanelColour22);
            this.panel12.Controls.Add(this.itemPanelColour21);
            this.panel12.Controls.Add(this.itemPanelColour20);
            this.panel12.Controls.Add(this.itemPanelColour19);
            this.panel12.Controls.Add(this.itemPanelColour18);
            this.panel12.Controls.Add(this.itemPanelColour17);
            this.panel12.Controls.Add(this.btnItemPicker);
            this.panel12.Controls.Add(this.btnItemClear);
            this.panel12.Controls.Add(this.btnItemColour);
            this.panel12.Controls.Add(this.btnItemRedo);
            this.panel12.Controls.Add(this.btnItemUndo);
            this.panel12.Controls.Add(this.itemPanelColour);
            this.panel12.Controls.Add(this.label7);
            this.panel12.Controls.Add(this.itemPanelColour16);
            this.panel12.Controls.Add(this.itemPanelColour8);
            this.panel12.Controls.Add(this.itemPanelColour15);
            this.panel12.Controls.Add(this.itemPanelColour7);
            this.panel12.Controls.Add(this.itemPanelColour14);
            this.panel12.Controls.Add(this.itemPanelColour6);
            this.panel12.Controls.Add(this.itemPanelColour13);
            this.panel12.Controls.Add(this.itemPanelColour5);
            this.panel12.Controls.Add(this.itemPanelColour12);
            this.panel12.Controls.Add(this.itemPanelColour4);
            this.panel12.Controls.Add(this.itemPanelColour11);
            this.panel12.Controls.Add(this.itemPanelColour3);
            this.panel12.Controls.Add(this.itemPanelColour10);
            this.panel12.Controls.Add(this.itemPanelColour2);
            this.panel12.Controls.Add(this.itemPanelColour9);
            this.panel12.Controls.Add(this.itemPanelColour1);
            this.panel12.Controls.Add(this.btnItemBucket);
            this.panel12.Controls.Add(this.btnItemRectangle);
            this.panel12.Controls.Add(this.btnItemLine);
            this.panel12.Controls.Add(this.btnItemPen);
            this.panel12.Location = new System.Drawing.Point(3, 30);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(239, 344);
            this.panel12.TabIndex = 85;
            // 
            // itemPanelColour1
            // 
            this.itemPanelColour1.BackColor = System.Drawing.Color.Black;
            this.itemPanelColour1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemPanelColour1.Location = new System.Drawing.Point(11, 37);
            this.itemPanelColour1.Name = "itemPanelColour1";
            this.itemPanelColour1.Size = new System.Drawing.Size(20, 20);
            this.itemPanelColour1.TabIndex = 85;
            // 
            // itemPanelColour9
            // 
            this.itemPanelColour9.BackColor = System.Drawing.Color.White;
            this.itemPanelColour9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemPanelColour9.Location = new System.Drawing.Point(11, 63);
            this.itemPanelColour9.Name = "itemPanelColour9";
            this.itemPanelColour9.Size = new System.Drawing.Size(20, 20);
            this.itemPanelColour9.TabIndex = 87;
            // 
            // itemPanelColour2
            // 
            this.itemPanelColour2.BackColor = System.Drawing.Color.Red;
            this.itemPanelColour2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemPanelColour2.Location = new System.Drawing.Point(37, 37);
            this.itemPanelColour2.Name = "itemPanelColour2";
            this.itemPanelColour2.Size = new System.Drawing.Size(20, 20);
            this.itemPanelColour2.TabIndex = 86;
            // 
            // itemPanelColour10
            // 
            this.itemPanelColour10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.itemPanelColour10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemPanelColour10.Location = new System.Drawing.Point(37, 63);
            this.itemPanelColour10.Name = "itemPanelColour10";
            this.itemPanelColour10.Size = new System.Drawing.Size(20, 20);
            this.itemPanelColour10.TabIndex = 88;
            // 
            // itemPanelColour3
            // 
            this.itemPanelColour3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.itemPanelColour3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemPanelColour3.Location = new System.Drawing.Point(63, 37);
            this.itemPanelColour3.Name = "itemPanelColour3";
            this.itemPanelColour3.Size = new System.Drawing.Size(20, 20);
            this.itemPanelColour3.TabIndex = 89;
            // 
            // itemPanelColour11
            // 
            this.itemPanelColour11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.itemPanelColour11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemPanelColour11.Location = new System.Drawing.Point(63, 63);
            this.itemPanelColour11.Name = "itemPanelColour11";
            this.itemPanelColour11.Size = new System.Drawing.Size(20, 20);
            this.itemPanelColour11.TabIndex = 91;
            // 
            // itemPanelColour4
            // 
            this.itemPanelColour4.BackColor = System.Drawing.Color.Yellow;
            this.itemPanelColour4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemPanelColour4.Location = new System.Drawing.Point(89, 37);
            this.itemPanelColour4.Name = "itemPanelColour4";
            this.itemPanelColour4.Size = new System.Drawing.Size(20, 20);
            this.itemPanelColour4.TabIndex = 90;
            // 
            // itemPanelColour12
            // 
            this.itemPanelColour12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.itemPanelColour12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemPanelColour12.Location = new System.Drawing.Point(89, 63);
            this.itemPanelColour12.Name = "itemPanelColour12";
            this.itemPanelColour12.Size = new System.Drawing.Size(20, 20);
            this.itemPanelColour12.TabIndex = 92;
            // 
            // itemPanelColour5
            // 
            this.itemPanelColour5.BackColor = System.Drawing.Color.Lime;
            this.itemPanelColour5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemPanelColour5.Location = new System.Drawing.Point(115, 37);
            this.itemPanelColour5.Name = "itemPanelColour5";
            this.itemPanelColour5.Size = new System.Drawing.Size(20, 20);
            this.itemPanelColour5.TabIndex = 93;
            // 
            // itemPanelColour13
            // 
            this.itemPanelColour13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.itemPanelColour13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemPanelColour13.Location = new System.Drawing.Point(115, 63);
            this.itemPanelColour13.Name = "itemPanelColour13";
            this.itemPanelColour13.Size = new System.Drawing.Size(20, 20);
            this.itemPanelColour13.TabIndex = 95;
            // 
            // itemPanelColour6
            // 
            this.itemPanelColour6.BackColor = System.Drawing.Color.Cyan;
            this.itemPanelColour6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemPanelColour6.Location = new System.Drawing.Point(141, 37);
            this.itemPanelColour6.Name = "itemPanelColour6";
            this.itemPanelColour6.Size = new System.Drawing.Size(20, 20);
            this.itemPanelColour6.TabIndex = 94;
            // 
            // itemPanelColour14
            // 
            this.itemPanelColour14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.itemPanelColour14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemPanelColour14.Location = new System.Drawing.Point(141, 63);
            this.itemPanelColour14.Name = "itemPanelColour14";
            this.itemPanelColour14.Size = new System.Drawing.Size(20, 20);
            this.itemPanelColour14.TabIndex = 96;
            // 
            // itemPanelColour7
            // 
            this.itemPanelColour7.BackColor = System.Drawing.Color.Blue;
            this.itemPanelColour7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemPanelColour7.Location = new System.Drawing.Point(167, 37);
            this.itemPanelColour7.Name = "itemPanelColour7";
            this.itemPanelColour7.Size = new System.Drawing.Size(20, 20);
            this.itemPanelColour7.TabIndex = 97;
            // 
            // itemPanelColour15
            // 
            this.itemPanelColour15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.itemPanelColour15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemPanelColour15.Location = new System.Drawing.Point(167, 63);
            this.itemPanelColour15.Name = "itemPanelColour15";
            this.itemPanelColour15.Size = new System.Drawing.Size(20, 20);
            this.itemPanelColour15.TabIndex = 99;
            // 
            // itemPanelColour8
            // 
            this.itemPanelColour8.BackColor = System.Drawing.Color.Fuchsia;
            this.itemPanelColour8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemPanelColour8.Location = new System.Drawing.Point(193, 37);
            this.itemPanelColour8.Name = "itemPanelColour8";
            this.itemPanelColour8.Size = new System.Drawing.Size(20, 20);
            this.itemPanelColour8.TabIndex = 98;
            // 
            // itemPanelColour16
            // 
            this.itemPanelColour16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.itemPanelColour16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemPanelColour16.Location = new System.Drawing.Point(193, 63);
            this.itemPanelColour16.Name = "itemPanelColour16";
            this.itemPanelColour16.Size = new System.Drawing.Size(20, 20);
            this.itemPanelColour16.TabIndex = 100;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 101;
            this.label7.Text = "Brush";
            // 
            // itemPanelColour
            // 
            this.itemPanelColour.BackColor = System.Drawing.Color.Black;
            this.itemPanelColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemPanelColour.Location = new System.Drawing.Point(64, 121);
            this.itemPanelColour.Name = "itemPanelColour";
            this.itemPanelColour.Size = new System.Drawing.Size(20, 20);
            this.itemPanelColour.TabIndex = 102;
            // 
            // btnItemUndo
            // 
            this.btnItemUndo.Location = new System.Drawing.Point(11, 237);
            this.btnItemUndo.Name = "btnItemUndo";
            this.btnItemUndo.Size = new System.Drawing.Size(75, 23);
            this.btnItemUndo.TabIndex = 107;
            this.btnItemUndo.Text = "Undo";
            this.btnItemUndo.UseVisualStyleBackColor = true;
            this.btnItemUndo.Click += new System.EventHandler(this.btnItemUndo_Click);
            // 
            // btnItemRedo
            // 
            this.btnItemRedo.Location = new System.Drawing.Point(103, 237);
            this.btnItemRedo.Name = "btnItemRedo";
            this.btnItemRedo.Size = new System.Drawing.Size(75, 23);
            this.btnItemRedo.TabIndex = 108;
            this.btnItemRedo.Text = "Redo";
            this.btnItemRedo.UseVisualStyleBackColor = true;
            this.btnItemRedo.Click += new System.EventHandler(this.btnItemRedo_Click);
            // 
            // btnItemColour
            // 
            this.btnItemColour.Location = new System.Drawing.Point(103, 121);
            this.btnItemColour.Name = "btnItemColour";
            this.btnItemColour.Size = new System.Drawing.Size(75, 23);
            this.btnItemColour.TabIndex = 109;
            this.btnItemColour.Text = "Colour";
            this.btnItemColour.UseVisualStyleBackColor = true;
            this.btnItemColour.Click += new System.EventHandler(this.btnItemColour_Click);
            // 
            // itemPanelColour17
            // 
            this.itemPanelColour17.BackColor = System.Drawing.Color.White;
            this.itemPanelColour17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemPanelColour17.Location = new System.Drawing.Point(11, 89);
            this.itemPanelColour17.Name = "itemPanelColour17";
            this.itemPanelColour17.Size = new System.Drawing.Size(20, 20);
            this.itemPanelColour17.TabIndex = 112;
            // 
            // itemPanelColour18
            // 
            this.itemPanelColour18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.itemPanelColour18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemPanelColour18.Location = new System.Drawing.Point(37, 89);
            this.itemPanelColour18.Name = "itemPanelColour18";
            this.itemPanelColour18.Size = new System.Drawing.Size(20, 20);
            this.itemPanelColour18.TabIndex = 113;
            // 
            // itemPanelColour19
            // 
            this.itemPanelColour19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.itemPanelColour19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemPanelColour19.Location = new System.Drawing.Point(63, 89);
            this.itemPanelColour19.Name = "itemPanelColour19";
            this.itemPanelColour19.Size = new System.Drawing.Size(20, 20);
            this.itemPanelColour19.TabIndex = 114;
            // 
            // itemPanelColour20
            // 
            this.itemPanelColour20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.itemPanelColour20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemPanelColour20.Location = new System.Drawing.Point(89, 89);
            this.itemPanelColour20.Name = "itemPanelColour20";
            this.itemPanelColour20.Size = new System.Drawing.Size(20, 20);
            this.itemPanelColour20.TabIndex = 115;
            // 
            // itemPanelColour21
            // 
            this.itemPanelColour21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.itemPanelColour21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemPanelColour21.Location = new System.Drawing.Point(115, 89);
            this.itemPanelColour21.Name = "itemPanelColour21";
            this.itemPanelColour21.Size = new System.Drawing.Size(20, 20);
            this.itemPanelColour21.TabIndex = 116;
            // 
            // itemPanelColour22
            // 
            this.itemPanelColour22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.itemPanelColour22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemPanelColour22.Location = new System.Drawing.Point(141, 89);
            this.itemPanelColour22.Name = "itemPanelColour22";
            this.itemPanelColour22.Size = new System.Drawing.Size(20, 20);
            this.itemPanelColour22.TabIndex = 117;
            // 
            // itemPanelColour23
            // 
            this.itemPanelColour23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.itemPanelColour23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemPanelColour23.Location = new System.Drawing.Point(167, 89);
            this.itemPanelColour23.Name = "itemPanelColour23";
            this.itemPanelColour23.Size = new System.Drawing.Size(20, 20);
            this.itemPanelColour23.TabIndex = 118;
            // 
            // itemPanelColour24
            // 
            this.itemPanelColour24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.itemPanelColour24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemPanelColour24.Location = new System.Drawing.Point(193, 89);
            this.itemPanelColour24.Name = "itemPanelColour24";
            this.itemPanelColour24.Size = new System.Drawing.Size(20, 20);
            this.itemPanelColour24.TabIndex = 119;
            // 
            // cmbItemFrames
            // 
            this.cmbItemFrames.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbItemFrames.FormattingEnabled = true;
            this.cmbItemFrames.Location = new System.Drawing.Point(411, 38);
            this.cmbItemFrames.Name = "cmbItemFrames";
            this.cmbItemFrames.Size = new System.Drawing.Size(90, 24);
            this.cmbItemFrames.TabIndex = 86;
            this.cmbItemFrames.Visible = false;
            // 
            // tabBlocks
            // 
            this.tabBlocks.AutoScroll = true;
            this.tabBlocks.BackColor = System.Drawing.Color.White;
            this.tabBlocks.Controls.Add(this.lblTexture3D);
            this.tabBlocks.Controls.Add(this.chkShowCubes);
            this.tabBlocks.Controls.Add(this.panel11);
            this.tabBlocks.Controls.Add(this.cmbFrames2);
            this.tabBlocks.Controls.Add(this.cmbFrames1);
            this.tabBlocks.Controls.Add(this.cmbBlocks);
            this.tabBlocks.Controls.Add(this.lblFilename1);
            this.tabBlocks.Controls.Add(this.lblFilename9);
            this.tabBlocks.Controls.Add(this.lblFilename3);
            this.tabBlocks.Controls.Add(this.lblFilename8);
            this.tabBlocks.Controls.Add(this.lblFilename2);
            this.tabBlocks.Controls.Add(this.lblFilename6);
            this.tabBlocks.Controls.Add(this.lblFilename4);
            this.tabBlocks.Controls.Add(this.lblFilename7);
            this.tabBlocks.Controls.Add(this.lblFilename5);
            this.tabBlocks.Controls.Add(this.panel5);
            this.tabBlocks.Controls.Add(this.panel6);
            this.tabBlocks.Controls.Add(this.panel4);
            this.tabBlocks.Controls.Add(this.panel8);
            this.tabBlocks.Controls.Add(this.panel2);
            this.tabBlocks.Controls.Add(this.panel9);
            this.tabBlocks.Controls.Add(this.panel3);
            this.tabBlocks.Controls.Add(this.panel1);
            this.tabBlocks.Controls.Add(this.panel7);
            this.tabBlocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabBlocks.Location = new System.Drawing.Point(4, 28);
            this.tabBlocks.Name = "tabBlocks";
            this.tabBlocks.Padding = new System.Windows.Forms.Padding(3);
            this.tabBlocks.Size = new System.Drawing.Size(768, 750);
            this.tabBlocks.TabIndex = 0;
            this.tabBlocks.Text = "Blocks";
            // 
            // lblFilename5
            // 
            this.lblFilename5.AutoSize = true;
            this.lblFilename5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilename5.Location = new System.Drawing.Point(270, 441);
            this.lblFilename5.Name = "lblFilename5";
            this.lblFilename5.Size = new System.Drawing.Size(64, 16);
            this.lblFilename5.TabIndex = 42;
            this.lblFilename5.Text = "Filename";
            this.lblFilename5.Visible = false;
            // 
            // lblFilename7
            // 
            this.lblFilename7.AutoSize = true;
            this.lblFilename7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilename7.Location = new System.Drawing.Point(602, 50);
            this.lblFilename7.Name = "lblFilename7";
            this.lblFilename7.Size = new System.Drawing.Size(64, 16);
            this.lblFilename7.TabIndex = 44;
            this.lblFilename7.Text = "Filename";
            this.lblFilename7.Visible = false;
            // 
            // lblFilename4
            // 
            this.lblFilename4.AutoSize = true;
            this.lblFilename4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilename4.Location = new System.Drawing.Point(439, 247);
            this.lblFilename4.Name = "lblFilename4";
            this.lblFilename4.Size = new System.Drawing.Size(64, 16);
            this.lblFilename4.TabIndex = 40;
            this.lblFilename4.Text = "Filename";
            this.lblFilename4.Visible = false;
            // 
            // lblFilename6
            // 
            this.lblFilename6.AutoSize = true;
            this.lblFilename6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilename6.Location = new System.Drawing.Point(439, 441);
            this.lblFilename6.Name = "lblFilename6";
            this.lblFilename6.Size = new System.Drawing.Size(64, 16);
            this.lblFilename6.TabIndex = 46;
            this.lblFilename6.Text = "Filename";
            this.lblFilename6.Visible = false;
            // 
            // lblFilename2
            // 
            this.lblFilename2.AutoSize = true;
            this.lblFilename2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilename2.Location = new System.Drawing.Point(439, 50);
            this.lblFilename2.Name = "lblFilename2";
            this.lblFilename2.Size = new System.Drawing.Size(64, 16);
            this.lblFilename2.TabIndex = 38;
            this.lblFilename2.Text = "Filename";
            this.lblFilename2.Visible = false;
            // 
            // lblFilename8
            // 
            this.lblFilename8.AutoSize = true;
            this.lblFilename8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilename8.Location = new System.Drawing.Point(602, 244);
            this.lblFilename8.Name = "lblFilename8";
            this.lblFilename8.Size = new System.Drawing.Size(64, 16);
            this.lblFilename8.TabIndex = 48;
            this.lblFilename8.Text = "Filename";
            this.lblFilename8.Visible = false;
            // 
            // lblFilename3
            // 
            this.lblFilename3.AutoSize = true;
            this.lblFilename3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilename3.Location = new System.Drawing.Point(270, 247);
            this.lblFilename3.Name = "lblFilename3";
            this.lblFilename3.Size = new System.Drawing.Size(64, 16);
            this.lblFilename3.TabIndex = 36;
            this.lblFilename3.Text = "Filename";
            this.lblFilename3.Visible = false;
            // 
            // lblFilename9
            // 
            this.lblFilename9.AutoSize = true;
            this.lblFilename9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilename9.Location = new System.Drawing.Point(602, 441);
            this.lblFilename9.Name = "lblFilename9";
            this.lblFilename9.Size = new System.Drawing.Size(64, 16);
            this.lblFilename9.TabIndex = 50;
            this.lblFilename9.Text = "Filename";
            this.lblFilename9.Visible = false;
            // 
            // lblFilename1
            // 
            this.lblFilename1.AutoSize = true;
            this.lblFilename1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilename1.Location = new System.Drawing.Point(270, 48);
            this.lblFilename1.Name = "lblFilename1";
            this.lblFilename1.Size = new System.Drawing.Size(64, 16);
            this.lblFilename1.TabIndex = 34;
            this.lblFilename1.Text = "Filename";
            this.lblFilename1.Visible = false;
            // 
            // cmbBlocks
            // 
            this.cmbBlocks.Enabled = false;
            this.cmbBlocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBlocks.FormattingEnabled = true;
            this.cmbBlocks.Location = new System.Drawing.Point(9, 8);
            this.cmbBlocks.Name = "cmbBlocks";
            this.cmbBlocks.Size = new System.Drawing.Size(232, 24);
            this.cmbBlocks.TabIndex = 32;
            // 
            // cmbFrames1
            // 
            this.cmbFrames1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFrames1.FormattingEnabled = true;
            this.cmbFrames1.Location = new System.Drawing.Point(343, 45);
            this.cmbFrames1.Name = "cmbFrames1";
            this.cmbFrames1.Size = new System.Drawing.Size(90, 24);
            this.cmbFrames1.TabIndex = 54;
            this.cmbFrames1.Visible = false;
            // 
            // cmbFrames2
            // 
            this.cmbFrames2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFrames2.FormattingEnabled = true;
            this.cmbFrames2.Location = new System.Drawing.Point(509, 45);
            this.cmbFrames2.Name = "cmbFrames2";
            this.cmbFrames2.Size = new System.Drawing.Size(90, 24);
            this.cmbFrames2.TabIndex = 55;
            this.cmbFrames2.Visible = false;
            // 
            // panel11
            // 
            this.panel11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel11.Controls.Add(this.panelColour17);
            this.panel11.Controls.Add(this.panelColour18);
            this.panel11.Controls.Add(this.panelColour19);
            this.panel11.Controls.Add(this.panelColour20);
            this.panel11.Controls.Add(this.panelColour21);
            this.panel11.Controls.Add(this.panelColour22);
            this.panel11.Controls.Add(this.panelColour23);
            this.panel11.Controls.Add(this.panelColour24);
            this.panel11.Controls.Add(this.btnPicker);
            this.panel11.Controls.Add(this.btnClear);
            this.panel11.Controls.Add(this.btnColour);
            this.panel11.Controls.Add(this.btnRedo);
            this.panel11.Controls.Add(this.btnUndo);
            this.panel11.Controls.Add(this.panelColour);
            this.panel11.Controls.Add(this.lblColour);
            this.panel11.Controls.Add(this.panelColour1);
            this.panel11.Controls.Add(this.panelColour9);
            this.panel11.Controls.Add(this.panelColour2);
            this.panel11.Controls.Add(this.panelColour10);
            this.panel11.Controls.Add(this.panelColour3);
            this.panel11.Controls.Add(this.panelColour11);
            this.panel11.Controls.Add(this.panelColour4);
            this.panel11.Controls.Add(this.panelColour12);
            this.panel11.Controls.Add(this.panelColour5);
            this.panel11.Controls.Add(this.panelColour13);
            this.panel11.Controls.Add(this.panelColour6);
            this.panel11.Controls.Add(this.panelColour14);
            this.panel11.Controls.Add(this.panelColour7);
            this.panel11.Controls.Add(this.panelColour15);
            this.panel11.Controls.Add(this.panelColour8);
            this.panel11.Controls.Add(this.panelColour16);
            this.panel11.Controls.Add(this.btnBucket);
            this.panel11.Controls.Add(this.btnRectangle);
            this.panel11.Controls.Add(this.btnLine);
            this.panel11.Controls.Add(this.btnPen);
            this.panel11.Location = new System.Drawing.Point(9, 263);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(238, 305);
            this.panel11.TabIndex = 84;
            // 
            // panelColour1
            // 
            this.panelColour1.BackColor = System.Drawing.Color.Black;
            this.panelColour1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColour1.Location = new System.Drawing.Point(11, 37);
            this.panelColour1.Name = "panelColour1";
            this.panelColour1.Size = new System.Drawing.Size(20, 20);
            this.panelColour1.TabIndex = 85;
            // 
            // panelColour9
            // 
            this.panelColour9.BackColor = System.Drawing.Color.White;
            this.panelColour9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColour9.Location = new System.Drawing.Point(11, 63);
            this.panelColour9.Name = "panelColour9";
            this.panelColour9.Size = new System.Drawing.Size(20, 20);
            this.panelColour9.TabIndex = 87;
            // 
            // panelColour2
            // 
            this.panelColour2.BackColor = System.Drawing.Color.Red;
            this.panelColour2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColour2.Location = new System.Drawing.Point(37, 37);
            this.panelColour2.Name = "panelColour2";
            this.panelColour2.Size = new System.Drawing.Size(20, 20);
            this.panelColour2.TabIndex = 86;
            this.panelColour2.Paint += new System.Windows.Forms.PaintEventHandler(this.panelColour2_Paint);
            // 
            // panelColour10
            // 
            this.panelColour10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelColour10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColour10.Location = new System.Drawing.Point(37, 63);
            this.panelColour10.Name = "panelColour10";
            this.panelColour10.Size = new System.Drawing.Size(20, 20);
            this.panelColour10.TabIndex = 88;
            // 
            // panelColour3
            // 
            this.panelColour3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelColour3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColour3.Location = new System.Drawing.Point(63, 37);
            this.panelColour3.Name = "panelColour3";
            this.panelColour3.Size = new System.Drawing.Size(20, 20);
            this.panelColour3.TabIndex = 89;
            // 
            // panelColour11
            // 
            this.panelColour11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panelColour11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColour11.Location = new System.Drawing.Point(63, 63);
            this.panelColour11.Name = "panelColour11";
            this.panelColour11.Size = new System.Drawing.Size(20, 20);
            this.panelColour11.TabIndex = 91;
            // 
            // panelColour4
            // 
            this.panelColour4.BackColor = System.Drawing.Color.Yellow;
            this.panelColour4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColour4.Location = new System.Drawing.Point(89, 37);
            this.panelColour4.Name = "panelColour4";
            this.panelColour4.Size = new System.Drawing.Size(20, 20);
            this.panelColour4.TabIndex = 90;
            // 
            // panelColour12
            // 
            this.panelColour12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelColour12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColour12.Location = new System.Drawing.Point(89, 63);
            this.panelColour12.Name = "panelColour12";
            this.panelColour12.Size = new System.Drawing.Size(20, 20);
            this.panelColour12.TabIndex = 92;
            // 
            // panelColour5
            // 
            this.panelColour5.BackColor = System.Drawing.Color.Lime;
            this.panelColour5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColour5.Location = new System.Drawing.Point(115, 37);
            this.panelColour5.Name = "panelColour5";
            this.panelColour5.Size = new System.Drawing.Size(20, 20);
            this.panelColour5.TabIndex = 93;
            // 
            // panelColour13
            // 
            this.panelColour13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelColour13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColour13.Location = new System.Drawing.Point(115, 63);
            this.panelColour13.Name = "panelColour13";
            this.panelColour13.Size = new System.Drawing.Size(20, 20);
            this.panelColour13.TabIndex = 95;
            // 
            // panelColour6
            // 
            this.panelColour6.BackColor = System.Drawing.Color.Cyan;
            this.panelColour6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColour6.Location = new System.Drawing.Point(141, 37);
            this.panelColour6.Name = "panelColour6";
            this.panelColour6.Size = new System.Drawing.Size(20, 20);
            this.panelColour6.TabIndex = 94;
            // 
            // panelColour14
            // 
            this.panelColour14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelColour14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColour14.Location = new System.Drawing.Point(141, 63);
            this.panelColour14.Name = "panelColour14";
            this.panelColour14.Size = new System.Drawing.Size(20, 20);
            this.panelColour14.TabIndex = 96;
            // 
            // panelColour7
            // 
            this.panelColour7.BackColor = System.Drawing.Color.Blue;
            this.panelColour7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColour7.Location = new System.Drawing.Point(167, 37);
            this.panelColour7.Name = "panelColour7";
            this.panelColour7.Size = new System.Drawing.Size(20, 20);
            this.panelColour7.TabIndex = 97;
            // 
            // panelColour15
            // 
            this.panelColour15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panelColour15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColour15.Location = new System.Drawing.Point(167, 63);
            this.panelColour15.Name = "panelColour15";
            this.panelColour15.Size = new System.Drawing.Size(20, 20);
            this.panelColour15.TabIndex = 99;
            // 
            // panelColour8
            // 
            this.panelColour8.BackColor = System.Drawing.Color.Fuchsia;
            this.panelColour8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColour8.Location = new System.Drawing.Point(193, 37);
            this.panelColour8.Name = "panelColour8";
            this.panelColour8.Size = new System.Drawing.Size(20, 20);
            this.panelColour8.TabIndex = 98;
            // 
            // panelColour16
            // 
            this.panelColour16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panelColour16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColour16.Location = new System.Drawing.Point(193, 63);
            this.panelColour16.Name = "panelColour16";
            this.panelColour16.Size = new System.Drawing.Size(20, 20);
            this.panelColour16.TabIndex = 100;
            // 
            // lblColour
            // 
            this.lblColour.AutoSize = true;
            this.lblColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColour.Location = new System.Drawing.Point(7, 112);
            this.lblColour.Name = "lblColour";
            this.lblColour.Size = new System.Drawing.Size(51, 20);
            this.lblColour.TabIndex = 101;
            this.lblColour.Text = "Brush";
            // 
            // panelColour
            // 
            this.panelColour.BackColor = System.Drawing.Color.Black;
            this.panelColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColour.Location = new System.Drawing.Point(64, 112);
            this.panelColour.Name = "panelColour";
            this.panelColour.Size = new System.Drawing.Size(20, 20);
            this.panelColour.TabIndex = 102;
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(11, 234);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(75, 23);
            this.btnUndo.TabIndex = 107;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnRedo
            // 
            this.btnRedo.Location = new System.Drawing.Point(89, 234);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(75, 23);
            this.btnRedo.TabIndex = 108;
            this.btnRedo.Text = "Redo";
            this.btnRedo.UseVisualStyleBackColor = true;
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            // 
            // btnColour
            // 
            this.btnColour.Location = new System.Drawing.Point(90, 115);
            this.btnColour.Name = "btnColour";
            this.btnColour.Size = new System.Drawing.Size(75, 23);
            this.btnColour.TabIndex = 109;
            this.btnColour.Text = "Colour";
            this.btnColour.UseVisualStyleBackColor = true;
            this.btnColour.Click += new System.EventHandler(this.btnColour_Click);
            // 
            // panelColour17
            // 
            this.panelColour17.BackColor = System.Drawing.Color.White;
            this.panelColour17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColour17.Location = new System.Drawing.Point(11, 89);
            this.panelColour17.Name = "panelColour17";
            this.panelColour17.Size = new System.Drawing.Size(20, 20);
            this.panelColour17.TabIndex = 112;
            // 
            // panelColour18
            // 
            this.panelColour18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelColour18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColour18.Location = new System.Drawing.Point(37, 89);
            this.panelColour18.Name = "panelColour18";
            this.panelColour18.Size = new System.Drawing.Size(20, 20);
            this.panelColour18.TabIndex = 113;
            // 
            // panelColour19
            // 
            this.panelColour19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panelColour19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColour19.Location = new System.Drawing.Point(63, 89);
            this.panelColour19.Name = "panelColour19";
            this.panelColour19.Size = new System.Drawing.Size(20, 20);
            this.panelColour19.TabIndex = 114;
            // 
            // panelColour20
            // 
            this.panelColour20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelColour20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColour20.Location = new System.Drawing.Point(89, 89);
            this.panelColour20.Name = "panelColour20";
            this.panelColour20.Size = new System.Drawing.Size(20, 20);
            this.panelColour20.TabIndex = 115;
            // 
            // panelColour21
            // 
            this.panelColour21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelColour21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColour21.Location = new System.Drawing.Point(115, 89);
            this.panelColour21.Name = "panelColour21";
            this.panelColour21.Size = new System.Drawing.Size(20, 20);
            this.panelColour21.TabIndex = 116;
            // 
            // panelColour22
            // 
            this.panelColour22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelColour22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColour22.Location = new System.Drawing.Point(141, 89);
            this.panelColour22.Name = "panelColour22";
            this.panelColour22.Size = new System.Drawing.Size(20, 20);
            this.panelColour22.TabIndex = 117;
            // 
            // panelColour23
            // 
            this.panelColour23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panelColour23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColour23.Location = new System.Drawing.Point(167, 89);
            this.panelColour23.Name = "panelColour23";
            this.panelColour23.Size = new System.Drawing.Size(20, 20);
            this.panelColour23.TabIndex = 118;
            this.panelColour23.Paint += new System.Windows.Forms.PaintEventHandler(this.panelColour23_Paint);
            // 
            // panelColour24
            // 
            this.panelColour24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panelColour24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColour24.Location = new System.Drawing.Point(193, 89);
            this.panelColour24.Name = "panelColour24";
            this.panelColour24.Size = new System.Drawing.Size(20, 20);
            this.panelColour24.TabIndex = 119;
            // 
            // chkShowCubes
            // 
            this.chkShowCubes.AutoSize = true;
            this.chkShowCubes.Checked = true;
            this.chkShowCubes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowCubes.Enabled = false;
            this.chkShowCubes.Location = new System.Drawing.Point(637, 10);
            this.chkShowCubes.Name = "chkShowCubes";
            this.chkShowCubes.Size = new System.Drawing.Size(102, 20);
            this.chkShowCubes.TabIndex = 85;
            this.chkShowCubes.Text = "Show Cubes";
            this.chkShowCubes.UseVisualStyleBackColor = true;
            this.chkShowCubes.Visible = false;
            this.chkShowCubes.CheckedChanged += new System.EventHandler(this.chkShowCubes_CheckedChanged);
            // 
            // lblTexture3D
            // 
            this.lblTexture3D.AutoSize = true;
            this.lblTexture3D.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexture3D.Location = new System.Drawing.Point(280, 13);
            this.lblTexture3D.Name = "lblTexture3D";
            this.lblTexture3D.Size = new System.Drawing.Size(327, 16);
            this.lblTexture3D.TabIndex = 86;
            this.lblTexture3D.Text = "3D texture painting not available for this model";
            this.lblTexture3D.Visible = false;
            // 
            // tabPackDetails
            // 
            this.tabPackDetails.BackColor = System.Drawing.Color.White;
            this.tabPackDetails.Controls.Add(this.btnRemoveFormatting);
            this.tabPackDetails.Controls.Add(this.btnStrikethrough);
            this.tabPackDetails.Controls.Add(this.btnUnderline);
            this.tabPackDetails.Controls.Add(this.btnItalic);
            this.tabPackDetails.Controls.Add(this.btnBold);
            this.tabPackDetails.Controls.Add(this.cmbTextColour);
            this.tabPackDetails.Controls.Add(this.btnAddColour);
            this.tabPackDetails.Controls.Add(this.txtResourcePackName);
            this.tabPackDetails.Controls.Add(this.txtMarkup);
            this.tabPackDetails.Controls.Add(this.lblMarkup);
            this.tabPackDetails.Controls.Add(this.btnImageBrowse);
            this.tabPackDetails.Controls.Add(this.panelThumbnail);
            this.tabPackDetails.Controls.Add(this.lblPackThumbnail);
            this.tabPackDetails.Controls.Add(this.lblTexturePackName);
            this.tabPackDetails.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.tabPackDetails.Location = new System.Drawing.Point(4, 28);
            this.tabPackDetails.Name = "tabPackDetails";
            this.tabPackDetails.Size = new System.Drawing.Size(768, 750);
            this.tabPackDetails.TabIndex = 2;
            this.tabPackDetails.Text = "Pack Details";
            this.tabPackDetails.Click += new System.EventHandler(this.tabPackDetails_Click);
            // 
            // lblTexturePackName
            // 
            this.lblTexturePackName.AutoSize = true;
            this.lblTexturePackName.Location = new System.Drawing.Point(9, 11);
            this.lblTexturePackName.Name = "lblTexturePackName";
            this.lblTexturePackName.Size = new System.Drawing.Size(141, 16);
            this.lblTexturePackName.TabIndex = 0;
            this.lblTexturePackName.Text = "Resource Pack Name";
            // 
            // lblPackThumbnail
            // 
            this.lblPackThumbnail.AutoSize = true;
            this.lblPackThumbnail.Location = new System.Drawing.Point(10, 71);
            this.lblPackThumbnail.Name = "lblPackThumbnail";
            this.lblPackThumbnail.Size = new System.Drawing.Size(105, 16);
            this.lblPackThumbnail.TabIndex = 2;
            this.lblPackThumbnail.Text = "Pack Thumbnail";
            // 
            // btnImageBrowse
            // 
            this.btnImageBrowse.Enabled = false;
            this.btnImageBrowse.Location = new System.Drawing.Point(309, 205);
            this.btnImageBrowse.Name = "btnImageBrowse";
            this.btnImageBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnImageBrowse.TabIndex = 4;
            this.btnImageBrowse.Text = "Browse";
            this.btnImageBrowse.UseVisualStyleBackColor = true;
            this.btnImageBrowse.Click += new System.EventHandler(this.btnImageBrowse_Click);
            // 
            // lblMarkup
            // 
            this.lblMarkup.AutoSize = true;
            this.lblMarkup.Location = new System.Drawing.Point(10, 41);
            this.lblMarkup.Name = "lblMarkup";
            this.lblMarkup.Size = new System.Drawing.Size(53, 16);
            this.lblMarkup.TabIndex = 5;
            this.lblMarkup.Text = "Markup";
            // 
            // txtMarkup
            // 
            this.txtMarkup.Enabled = false;
            this.txtMarkup.Location = new System.Drawing.Point(156, 38);
            this.txtMarkup.Name = "txtMarkup";
            this.txtMarkup.Size = new System.Drawing.Size(152, 22);
            this.txtMarkup.TabIndex = 6;
            // 
            // txtResourcePackName
            // 
            this.txtResourcePackName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResourcePackName.Enabled = false;
            this.txtResourcePackName.Location = new System.Drawing.Point(156, 11);
            this.txtResourcePackName.Name = "txtResourcePackName";
            this.txtResourcePackName.Size = new System.Drawing.Size(152, 21);
            this.txtResourcePackName.TabIndex = 7;
            this.txtResourcePackName.Text = "";
            // 
            // btnAddColour
            // 
            this.btnAddColour.Enabled = false;
            this.btnAddColour.Location = new System.Drawing.Point(316, 9);
            this.btnAddColour.Name = "btnAddColour";
            this.btnAddColour.Size = new System.Drawing.Size(99, 23);
            this.btnAddColour.TabIndex = 8;
            this.btnAddColour.Text = "Add colour";
            this.btnAddColour.UseVisualStyleBackColor = true;
            this.btnAddColour.Click += new System.EventHandler(this.btnAddColour_Click);
            // 
            // cmbTextColour
            // 
            this.cmbTextColour.Enabled = false;
            this.cmbTextColour.FormattingEnabled = true;
            this.cmbTextColour.Items.AddRange(new object[] {
            "Black",
            "Dark Blue",
            "Dark Green",
            "Dark Aqua",
            "Dark Red",
            "Dark Purple",
            "Gold",
            "Gray",
            "Dark Gray",
            "Blue",
            "Green",
            "Aqua",
            "Red",
            "Light Purple",
            "Yellow",
            "White",
            "No Colour"});
            this.cmbTextColour.Location = new System.Drawing.Point(424, 9);
            this.cmbTextColour.Name = "cmbTextColour";
            this.cmbTextColour.Size = new System.Drawing.Size(121, 24);
            this.cmbTextColour.TabIndex = 9;
            // 
            // btnBold
            // 
            this.btnBold.Enabled = false;
            this.btnBold.Location = new System.Drawing.Point(316, 37);
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(68, 24);
            this.btnBold.TabIndex = 10;
            this.btnBold.Text = "Bold";
            this.btnBold.UseVisualStyleBackColor = true;
            this.btnBold.Click += new System.EventHandler(this.btnBold_Click);
            // 
            // btnItalic
            // 
            this.btnItalic.Enabled = false;
            this.btnItalic.Location = new System.Drawing.Point(392, 37);
            this.btnItalic.Name = "btnItalic";
            this.btnItalic.Size = new System.Drawing.Size(60, 24);
            this.btnItalic.TabIndex = 11;
            this.btnItalic.Text = "Italic";
            this.btnItalic.UseVisualStyleBackColor = true;
            this.btnItalic.Click += new System.EventHandler(this.btnItalic_Click);
            // 
            // btnUnderline
            // 
            this.btnUnderline.Enabled = false;
            this.btnUnderline.Location = new System.Drawing.Point(459, 36);
            this.btnUnderline.Name = "btnUnderline";
            this.btnUnderline.Size = new System.Drawing.Size(78, 24);
            this.btnUnderline.TabIndex = 12;
            this.btnUnderline.Text = "Underline";
            this.btnUnderline.UseVisualStyleBackColor = true;
            this.btnUnderline.Click += new System.EventHandler(this.btnUnderline_Click);
            // 
            // btnStrikethrough
            // 
            this.btnStrikethrough.Enabled = false;
            this.btnStrikethrough.Location = new System.Drawing.Point(543, 36);
            this.btnStrikethrough.Name = "btnStrikethrough";
            this.btnStrikethrough.Size = new System.Drawing.Size(95, 24);
            this.btnStrikethrough.TabIndex = 13;
            this.btnStrikethrough.Text = "Strikethrough";
            this.btnStrikethrough.UseVisualStyleBackColor = true;
            this.btnStrikethrough.Click += new System.EventHandler(this.btnStrikethrough_Click);
            // 
            // btnRemoveFormatting
            // 
            this.btnRemoveFormatting.Enabled = false;
            this.btnRemoveFormatting.Location = new System.Drawing.Point(316, 67);
            this.btnRemoveFormatting.Name = "btnRemoveFormatting";
            this.btnRemoveFormatting.Size = new System.Drawing.Size(136, 24);
            this.btnRemoveFormatting.TabIndex = 14;
            this.btnRemoveFormatting.Text = "Remove formatting";
            this.btnRemoveFormatting.UseVisualStyleBackColor = true;
            this.btnRemoveFormatting.Click += new System.EventHandler(this.btnRemoveFormatting_Click);
            // 
            // tabControl
            // 
            tabControl.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            tabControl.AllowDrop = true;
            tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            tabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            tabControl.Controls.Add(this.tabPackDetails);
            tabControl.Controls.Add(this.tabBlocks);
            tabControl.Controls.Add(this.tabItems);
            tabControl.Controls.Add(this.tabSounds);
            tabControl.Controls.Add(this.tabFont);
            tabControl.Controls.Add(this.tabOrganise);
            tabControl.Controls.Add(this.tabSettings);
            tabControl.Controls.Add(this.tabAbout);
            tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tabControl.ImeMode = System.Windows.Forms.ImeMode.Disable;
            tabControl.Location = new System.Drawing.Point(173, 31);
            tabControl.Multiline = true;
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.ShowToolTips = true;
            tabControl.Size = new System.Drawing.Size(776, 782);
            tabControl.TabIndex = 32;
            tabControl.TabStop = false;
            // 
            // panelThumbnail
            // 
            this.panelThumbnail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelThumbnail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelThumbnail.Controls.Add(this.lblDropImage);
            this.panelThumbnail.Enabled = false;
            this.panelThumbnail.Location = new System.Drawing.Point(13, 96);
            this.panelThumbnail.Name = "panelThumbnail";
            this.panelThumbnail.Size = new System.Drawing.Size(256, 256);
            this.panelThumbnail.TabIndex = 3;
            // 
            // lblDropImage
            // 
            this.lblDropImage.Enabled = false;
            this.lblDropImage.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDropImage.Location = new System.Drawing.Point(58, 61);
            this.lblDropImage.Name = "lblDropImage";
            this.lblDropImage.Size = new System.Drawing.Size(135, 113);
            this.lblDropImage.TabIndex = 0;
            this.lblDropImage.Text = "Drop Image Here";
            this.lblDropImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPicker
            // 
            this.btnPicker.BackColor = System.Drawing.SystemColors.Control;
            this.btnPicker.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPicker.Font = new System.Drawing.Font("Arial", 10F);
            this.btnPicker.ForeColor = System.Drawing.Color.Black;
            this.btnPicker.Location = new System.Drawing.Point(11, 205);
            this.btnPicker.Name = "btnPicker";
            this.btnPicker.Size = new System.Drawing.Size(75, 23);
            this.btnPicker.TabIndex = 111;
            this.btnPicker.Text = "Picker";
            this.btnPicker.Toggled = false;
            this.btnPicker.UseVisualStyleBackColor = true;
            this.btnPicker.Click += new System.EventHandler(this.btnPicker_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.Control;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClear.Font = new System.Drawing.Font("Arial", 10F);
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(90, 205);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 110;
            this.btnClear.Text = "Clear";
            this.btnClear.Toggled = false;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBucket
            // 
            this.btnBucket.BackColor = System.Drawing.SystemColors.Control;
            this.btnBucket.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBucket.Font = new System.Drawing.Font("Arial", 10F);
            this.btnBucket.ForeColor = System.Drawing.Color.Black;
            this.btnBucket.Location = new System.Drawing.Point(9, 176);
            this.btnBucket.Name = "btnBucket";
            this.btnBucket.Size = new System.Drawing.Size(75, 23);
            this.btnBucket.TabIndex = 106;
            this.btnBucket.Text = "Bucket";
            this.btnBucket.Toggled = false;
            this.btnBucket.UseVisualStyleBackColor = false;
            this.btnBucket.Click += new System.EventHandler(this.btnBucket_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.BackColor = System.Drawing.SystemColors.Control;
            this.btnRectangle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRectangle.Font = new System.Drawing.Font("Arial", 10F);
            this.btnRectangle.ForeColor = System.Drawing.Color.Black;
            this.btnRectangle.Location = new System.Drawing.Point(90, 176);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(75, 23);
            this.btnRectangle.TabIndex = 105;
            this.btnRectangle.Text = "Rectangle";
            this.btnRectangle.Toggled = false;
            this.btnRectangle.UseVisualStyleBackColor = false;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnLine
            // 
            this.btnLine.BackColor = System.Drawing.SystemColors.Control;
            this.btnLine.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLine.Font = new System.Drawing.Font("Arial", 10F);
            this.btnLine.ForeColor = System.Drawing.Color.Black;
            this.btnLine.Location = new System.Drawing.Point(89, 144);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(75, 23);
            this.btnLine.TabIndex = 104;
            this.btnLine.Text = "Line";
            this.btnLine.Toggled = false;
            this.btnLine.UseVisualStyleBackColor = false;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnPen
            // 
            this.btnPen.BackColor = System.Drawing.Color.Green;
            this.btnPen.Font = new System.Drawing.Font("Arial", 10F);
            this.btnPen.ForeColor = System.Drawing.Color.White;
            this.btnPen.Location = new System.Drawing.Point(9, 147);
            this.btnPen.Name = "btnPen";
            this.btnPen.Size = new System.Drawing.Size(75, 23);
            this.btnPen.TabIndex = 103;
            this.btnPen.Text = "Pen";
            this.btnPen.Toggled = true;
            this.btnPen.UseVisualStyleBackColor = false;
            this.btnPen.Click += new System.EventHandler(this.btnPen_Click);
            // 
            // panel5
            // 
            this.panel5.AllowDrop = true;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(273, 460);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(160, 160);
            this.panel5.TabIndex = 41;
            this.panel5.Visible = false;
            // 
            // panel6
            // 
            this.panel6.AllowDrop = true;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(439, 460);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(160, 160);
            this.panel6.TabIndex = 45;
            this.panel6.Visible = false;
            // 
            // panel4
            // 
            this.panel4.AllowDrop = true;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(439, 266);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(160, 160);
            this.panel4.TabIndex = 39;
            this.panel4.Visible = false;
            // 
            // panel8
            // 
            this.panel8.AllowDrop = true;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Location = new System.Drawing.Point(605, 266);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(160, 160);
            this.panel8.TabIndex = 47;
            this.panel8.Visible = false;
            // 
            // panel2
            // 
            this.panel2.AllowDrop = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(439, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 160);
            this.panel2.TabIndex = 37;
            this.panel2.Visible = false;
            // 
            // panel9
            // 
            this.panel9.AllowDrop = true;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Location = new System.Drawing.Point(605, 460);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(160, 160);
            this.panel9.TabIndex = 49;
            this.panel9.Visible = false;
            // 
            // panel3
            // 
            this.panel3.AllowDrop = true;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(273, 266);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(160, 160);
            this.panel3.TabIndex = 35;
            this.panel3.Visible = false;
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(273, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 160);
            this.panel1.TabIndex = 33;
            this.panel1.Visible = false;
            // 
            // panel7
            // 
            this.panel7.AllowDrop = true;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Location = new System.Drawing.Point(605, 72);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(160, 160);
            this.panel7.TabIndex = 43;
            this.panel7.Visible = false;
            // 
            // btnItemPicker
            // 
            this.btnItemPicker.BackColor = System.Drawing.SystemColors.Control;
            this.btnItemPicker.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnItemPicker.Font = new System.Drawing.Font("Arial", 10F);
            this.btnItemPicker.ForeColor = System.Drawing.Color.Black;
            this.btnItemPicker.Location = new System.Drawing.Point(11, 208);
            this.btnItemPicker.Name = "btnItemPicker";
            this.btnItemPicker.Size = new System.Drawing.Size(75, 23);
            this.btnItemPicker.TabIndex = 111;
            this.btnItemPicker.Text = "Picker";
            this.btnItemPicker.Toggled = false;
            this.btnItemPicker.UseVisualStyleBackColor = true;
            this.btnItemPicker.Click += new System.EventHandler(this.btnItemPicker_Click);
            // 
            // btnItemClear
            // 
            this.btnItemClear.BackColor = System.Drawing.SystemColors.Control;
            this.btnItemClear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnItemClear.Font = new System.Drawing.Font("Arial", 10F);
            this.btnItemClear.ForeColor = System.Drawing.Color.Black;
            this.btnItemClear.Location = new System.Drawing.Point(103, 208);
            this.btnItemClear.Name = "btnItemClear";
            this.btnItemClear.Size = new System.Drawing.Size(75, 23);
            this.btnItemClear.TabIndex = 110;
            this.btnItemClear.Text = "Clear";
            this.btnItemClear.Toggled = false;
            this.btnItemClear.UseVisualStyleBackColor = false;
            this.btnItemClear.Click += new System.EventHandler(this.btnItemClear_Click);
            // 
            // btnItemBucket
            // 
            this.btnItemBucket.BackColor = System.Drawing.SystemColors.Control;
            this.btnItemBucket.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnItemBucket.Font = new System.Drawing.Font("Arial", 10F);
            this.btnItemBucket.ForeColor = System.Drawing.Color.Black;
            this.btnItemBucket.Location = new System.Drawing.Point(103, 179);
            this.btnItemBucket.Name = "btnItemBucket";
            this.btnItemBucket.Size = new System.Drawing.Size(75, 23);
            this.btnItemBucket.TabIndex = 106;
            this.btnItemBucket.Text = "Bucket";
            this.btnItemBucket.Toggled = false;
            this.btnItemBucket.UseVisualStyleBackColor = false;
            this.btnItemBucket.Click += new System.EventHandler(this.btnItemBucket_Click);
            // 
            // btnItemRectangle
            // 
            this.btnItemRectangle.BackColor = System.Drawing.SystemColors.Control;
            this.btnItemRectangle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnItemRectangle.Font = new System.Drawing.Font("Arial", 10F);
            this.btnItemRectangle.ForeColor = System.Drawing.Color.Black;
            this.btnItemRectangle.Location = new System.Drawing.Point(103, 150);
            this.btnItemRectangle.Name = "btnItemRectangle";
            this.btnItemRectangle.Size = new System.Drawing.Size(75, 23);
            this.btnItemRectangle.TabIndex = 105;
            this.btnItemRectangle.Text = "Rectangle";
            this.btnItemRectangle.Toggled = false;
            this.btnItemRectangle.UseVisualStyleBackColor = false;
            this.btnItemRectangle.Click += new System.EventHandler(this.btnItemRectangle_Click);
            // 
            // btnItemLine
            // 
            this.btnItemLine.BackColor = System.Drawing.SystemColors.Control;
            this.btnItemLine.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnItemLine.Font = new System.Drawing.Font("Arial", 10F);
            this.btnItemLine.ForeColor = System.Drawing.Color.Black;
            this.btnItemLine.Location = new System.Drawing.Point(11, 179);
            this.btnItemLine.Name = "btnItemLine";
            this.btnItemLine.Size = new System.Drawing.Size(75, 23);
            this.btnItemLine.TabIndex = 104;
            this.btnItemLine.Text = "Line";
            this.btnItemLine.Toggled = false;
            this.btnItemLine.UseVisualStyleBackColor = false;
            this.btnItemLine.Click += new System.EventHandler(this.btnItemLine_Click);
            // 
            // btnItemPen
            // 
            this.btnItemPen.BackColor = System.Drawing.Color.Green;
            this.btnItemPen.Font = new System.Drawing.Font("Arial", 10F);
            this.btnItemPen.ForeColor = System.Drawing.Color.White;
            this.btnItemPen.Location = new System.Drawing.Point(11, 150);
            this.btnItemPen.Name = "btnItemPen";
            this.btnItemPen.Size = new System.Drawing.Size(75, 23);
            this.btnItemPen.TabIndex = 103;
            this.btnItemPen.Text = "Pen";
            this.btnItemPen.Toggled = true;
            this.btnItemPen.UseVisualStyleBackColor = false;
            this.btnItemPen.Click += new System.EventHandler(this.btnItemPen_Click);
            // 
            // itemPanel
            // 
            this.itemPanel.AllowDrop = true;
            this.itemPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemPanel.Location = new System.Drawing.Point(344, 71);
            this.itemPanel.Name = "itemPanel";
            this.itemPanel.Size = new System.Drawing.Size(160, 160);
            this.itemPanel.TabIndex = 36;
            // 
            // panelFont
            // 
            this.panelFont.BackColor = System.Drawing.Color.Black;
            this.panelFont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelFont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFont.Controls.Add(this.lblFontDropImage);
            this.panelFont.Enabled = false;
            this.panelFont.Location = new System.Drawing.Point(10, 34);
            this.panelFont.Name = "panelFont";
            this.panelFont.Size = new System.Drawing.Size(256, 256);
            this.panelFont.TabIndex = 6;
            // 
            // lblFontDropImage
            // 
            this.lblFontDropImage.Enabled = false;
            this.lblFontDropImage.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFontDropImage.ForeColor = System.Drawing.Color.White;
            this.lblFontDropImage.Location = new System.Drawing.Point(58, 61);
            this.lblFontDropImage.Name = "lblFontDropImage";
            this.lblFontDropImage.Size = new System.Drawing.Size(135, 113);
            this.lblFontDropImage.TabIndex = 0;
            this.lblFontDropImage.Text = "Drop Image Here";
            this.lblFontDropImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(950, 812);
            this.Controls.Add(this.btnOpenDirectory);
            this.Controls.Add(this.btnSaveToMinecraft);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.lblTexturePack);
            this.Controls.Add(tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Minecraft Texture Studio 2018";
            this.tabAbout.ResumeLayout(false);
            this.tabAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.tabOrganise.ResumeLayout(false);
            this.tabOrganise.PerformLayout();
            this.tabFont.ResumeLayout(false);
            this.tabFont.PerformLayout();
            this.tabSounds.ResumeLayout(false);
            this.tabSounds.PerformLayout();
            this.panelDropSound.ResumeLayout(false);
            this.tabItems.ResumeLayout(false);
            this.tabItems.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.tabBlocks.ResumeLayout(false);
            this.tabBlocks.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.tabPackDetails.ResumeLayout(false);
            this.tabPackDetails.PerformLayout();
            tabControl.ResumeLayout(false);
            this.panelThumbnail.ResumeLayout(false);
            this.panelFont.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void tabPackDetails_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Label lblTexturePack;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSaveToMinecraft;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnOpenDirectory;
        private TabPage tabAbout;
        private Label label9;
        private PictureBox pictureBox1;
        private Label lblEmail;
        private Label lblCoded;
        private Label lblVersion;
        private Label lblTitle;
        private TabPage tabSettings;
        private Panel panel10;
        private RadioButton radAlphabetical;
        private RadioButton radId;
        private Label lblSortOption;
        private Label lblExtractJarOption;
        private RadioButton radExtractedPath;
        private RadioButton radExtractFromJar;
        private Button btnExtractedJarBrowse;
        private TextBox txtExtractedJarPath;
        private TextBox txtMinecraftJarPath;
        private TextBox txtMinecraftPath;
        private Label lblExtractedJarPath;
        private Button btnJarBrowse;
        private Label lblMinecraftJarPath;
        private Button btnPathBrowse;
        private Label lblMinecraftPath;
        private TabPage tabOrganise;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblShared2;
        private Label lblShared1;
        private Button btnSaveChanges;
        private TabPage tabFont;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
        private Label lblFont;
        private Button btnBrowseFont;
        private DoubleBufferedPanel panelFont;
        private Label lblFontDropImage;
        private TabPage tabSounds;
        private Button btnBrowseSound;
        private Button btnPlayNext;
        private Button btnPlay;
        private Label lblAddSounds2;
        private Label lblAddSounds1;
        private Button btnAddSounds;
        public ComboBox cmbSounds;
        private Panel panelDropSound;
        private Label lblDropSound;
        private TabPage tabItems;
        private ComboBox cmbItemFrames;
        private Panel panel12;
        private Panel itemPanelColour24;
        private Panel itemPanelColour23;
        private Panel itemPanelColour22;
        private Panel itemPanelColour21;
        private Panel itemPanelColour20;
        private Panel itemPanelColour19;
        private Panel itemPanelColour18;
        private Panel itemPanelColour17;
        private ToggleButton btnItemPicker;
        private ToggleButton btnItemClear;
        private Button btnItemColour;
        private Button btnItemRedo;
        private Button btnItemUndo;
        private Panel itemPanelColour;
        private Label label7;
        private Panel itemPanelColour16;
        private Panel itemPanelColour8;
        private Panel itemPanelColour15;
        private Panel itemPanelColour7;
        private Panel itemPanelColour14;
        private Panel itemPanelColour6;
        private Panel itemPanelColour13;
        private Panel itemPanelColour5;
        private Panel itemPanelColour12;
        private Panel itemPanelColour4;
        private Panel itemPanelColour11;
        private Panel itemPanelColour3;
        private Panel itemPanelColour10;
        private Panel itemPanelColour2;
        private Panel itemPanelColour9;
        private Panel itemPanelColour1;
        private ToggleButton btnItemBucket;
        private ToggleButton btnItemRectangle;
        private ToggleButton btnItemLine;
        private ToggleButton btnItemPen;
        public ComboBox cmbItems;
        private Label lblFilename;
        private DoubleBufferedPanel itemPanel;
        private TabPage tabBlocks;
        private Label lblTexture3D;
        private CheckBox chkShowCubes;
        private Panel panel11;
        private Panel panelColour24;
        private Panel panelColour23;
        private Panel panelColour22;
        private Panel panelColour21;
        private Panel panelColour20;
        private Panel panelColour19;
        private Panel panelColour18;
        private Panel panelColour17;
        private ToggleButton btnPicker;
        private ToggleButton btnClear;
        private Button btnColour;
        private Button btnRedo;
        private Button btnUndo;
        private Panel panelColour;
        private Label lblColour;
        private Panel panelColour16;
        private Panel panelColour8;
        private Panel panelColour15;
        private Panel panelColour7;
        private Panel panelColour14;
        private Panel panelColour6;
        private Panel panelColour13;
        private Panel panelColour5;
        private Panel panelColour12;
        private Panel panelColour4;
        private Panel panelColour11;
        private Panel panelColour3;
        private Panel panelColour10;
        private Panel panelColour2;
        private Panel panelColour9;
        private Panel panelColour1;
        private ToggleButton btnBucket;
        private ToggleButton btnRectangle;
        private ToggleButton btnLine;
        private ToggleButton btnPen;
        private ComboBox cmbFrames2;
        private ComboBox cmbFrames1;
        public ComboBox cmbBlocks;
        private Label lblFilename1;
        private Label lblFilename9;
        private Label lblFilename3;
        private Label lblFilename8;
        private Label lblFilename2;
        private Label lblFilename6;
        private Label lblFilename4;
        private Label lblFilename7;
        private Label lblFilename5;
        private DoubleBufferedPanel panel1;
        private DoubleBufferedPanel panel3;
        private DoubleBufferedPanel panel9;
        private DoubleBufferedPanel panel2;
        private DoubleBufferedPanel panel8;
        private DoubleBufferedPanel panel4;
        private DoubleBufferedPanel panel6;
        private DoubleBufferedPanel panel5;
        private DoubleBufferedPanel panel7;
        public TabPage tabPackDetails;
        private Button btnRemoveFormatting;
        private Button btnStrikethrough;
        private Button btnUnderline;
        private Button btnItalic;
        private Button btnBold;
        private ComboBox cmbTextColour;
        private Button btnAddColour;
        private RichTextBox txtResourcePackName;
        private TextBox txtMarkup;
        private Label lblMarkup;
        private Button btnImageBrowse;
        private DoubleBufferedPanel panelThumbnail;
        private Label lblDropImage;
        private Label lblPackThumbnail;
        private Label lblTexturePackName;

        public object TabPage { get; private set; }
    }
}