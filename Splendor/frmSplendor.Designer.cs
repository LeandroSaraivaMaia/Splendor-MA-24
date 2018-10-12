﻿namespace Splendor
{
    partial class frmSplendor
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblGoldCoin = new System.Windows.Forms.Label();
            this.lblRubisCoin = new System.Windows.Forms.Label();
            this.lblSaphirCoin = new System.Windows.Forms.Label();
            this.lblOnyxCoin = new System.Windows.Forms.Label();
            this.lblEmeraudeCoin = new System.Windows.Forms.Label();
            this.lblDiamantCoin = new System.Windows.Forms.Label();
            this.txtLevel31 = new System.Windows.Forms.TextBox();
            this.txtLevel32 = new System.Windows.Forms.TextBox();
            this.txtLevel33 = new System.Windows.Forms.TextBox();
            this.txtLevel34 = new System.Windows.Forms.TextBox();
            this.txtLevel21 = new System.Windows.Forms.TextBox();
            this.txtLevel22 = new System.Windows.Forms.TextBox();
            this.txtLevel23 = new System.Windows.Forms.TextBox();
            this.txtLevel24 = new System.Windows.Forms.TextBox();
            this.txtLevel14 = new System.Windows.Forms.TextBox();
            this.txtLevel13 = new System.Windows.Forms.TextBox();
            this.txtLevel12 = new System.Windows.Forms.TextBox();
            this.txtLevel11 = new System.Windows.Forms.TextBox();
            this.cmdInsertPlayer = new System.Windows.Forms.Button();
            this.cmdPlay = new System.Windows.Forms.Button();
            this.txtPlayerEmeraudeCard = new System.Windows.Forms.TextBox();
            this.txtPlayerOnyxCard = new System.Windows.Forms.TextBox();
            this.txtPlayerSaphirCard = new System.Windows.Forms.TextBox();
            this.txtPlayerRubisCard = new System.Windows.Forms.TextBox();
            this.lblPlayerDiamantCoin = new System.Windows.Forms.Label();
            this.lblPlayerEmeraudeCoin = new System.Windows.Forms.Label();
            this.lblPlayerOnyxCoin = new System.Windows.Forms.Label();
            this.lblPlayerSaphirCoin = new System.Windows.Forms.Label();
            this.lblPlayerRubisCoin = new System.Windows.Forms.Label();
            this.lblPlayerGoldCoin = new System.Windows.Forms.Label();
            this.txtPlayerBookedCard = new System.Windows.Forms.TextBox();
            this.txtPlayerDiamandCard = new System.Windows.Forms.TextBox();
            this.lblChoiceRubis = new System.Windows.Forms.Label();
            this.lblChoiceSaphir = new System.Windows.Forms.Label();
            this.lblChoiceOnyx = new System.Windows.Forms.Label();
            this.lblChoiceEmeraude = new System.Windows.Forms.Label();
            this.lblChoiceDiamant = new System.Windows.Forms.Label();
            this.cmdValidateChoice = new System.Windows.Forms.Button();
            this.cmdNextPlayer = new System.Windows.Forms.Button();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblChoiceCard = new System.Windows.Forms.Label();
            this.txtLevel44 = new System.Windows.Forms.TextBox();
            this.txtLevel43 = new System.Windows.Forms.TextBox();
            this.txtLevel42 = new System.Windows.Forms.TextBox();
            this.txtLevel41 = new System.Windows.Forms.TextBox();
            this.lblNbPtPrestige = new System.Windows.Forms.Label();
            this.flwCardLevel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flwCardLevel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flwCardLevel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flwCardLevel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.flwCardLevel1.SuspendLayout();
            this.flwCardLevel2.SuspendLayout();
            this.flwCardLevel3.SuspendLayout();
            this.flwCardLevel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGoldCoin
            // 
            this.lblGoldCoin.AutoSize = true;
            this.lblGoldCoin.ForeColor = System.Drawing.Color.Yellow;
            this.lblGoldCoin.Location = new System.Drawing.Point(542, 15);
            this.lblGoldCoin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGoldCoin.Name = "lblGoldCoin";
            this.lblGoldCoin.Size = new System.Drawing.Size(50, 13);
            this.lblGoldCoin.TabIndex = 0;
            this.lblGoldCoin.Text = "GoldCoin";
            // 
            // lblRubisCoin
            // 
            this.lblRubisCoin.AutoSize = true;
            this.lblRubisCoin.BackColor = System.Drawing.Color.Red;
            this.lblRubisCoin.ForeColor = System.Drawing.Color.White;
            this.lblRubisCoin.Location = new System.Drawing.Point(19, 15);
            this.lblRubisCoin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRubisCoin.Name = "lblRubisCoin";
            this.lblRubisCoin.Size = new System.Drawing.Size(55, 13);
            this.lblRubisCoin.TabIndex = 1;
            this.lblRubisCoin.Text = "RubisCoin";
            this.lblRubisCoin.UseMnemonic = false;
            this.lblRubisCoin.Click += new System.EventHandler(this.lblRubisCoin_Click);
            // 
            // lblSaphirCoin
            // 
            this.lblSaphirCoin.AutoSize = true;
            this.lblSaphirCoin.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblSaphirCoin.ForeColor = System.Drawing.SystemColors.Window;
            this.lblSaphirCoin.Location = new System.Drawing.Point(100, 15);
            this.lblSaphirCoin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSaphirCoin.Name = "lblSaphirCoin";
            this.lblSaphirCoin.Size = new System.Drawing.Size(58, 13);
            this.lblSaphirCoin.TabIndex = 2;
            this.lblSaphirCoin.Text = "SaphirCoin";
            this.lblSaphirCoin.Click += new System.EventHandler(this.lblSaphirCoin_Click);
            // 
            // lblOnyxCoin
            // 
            this.lblOnyxCoin.AutoSize = true;
            this.lblOnyxCoin.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblOnyxCoin.ForeColor = System.Drawing.SystemColors.Window;
            this.lblOnyxCoin.Location = new System.Drawing.Point(186, 15);
            this.lblOnyxCoin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOnyxCoin.Name = "lblOnyxCoin";
            this.lblOnyxCoin.Size = new System.Drawing.Size(52, 13);
            this.lblOnyxCoin.TabIndex = 3;
            this.lblOnyxCoin.Text = "OnyxCoin";
            this.lblOnyxCoin.Click += new System.EventHandler(this.lblOnyxCoin_Click);
            // 
            // lblEmeraudeCoin
            // 
            this.lblEmeraudeCoin.AutoSize = true;
            this.lblEmeraudeCoin.BackColor = System.Drawing.Color.Green;
            this.lblEmeraudeCoin.ForeColor = System.Drawing.SystemColors.Window;
            this.lblEmeraudeCoin.Location = new System.Drawing.Point(265, 15);
            this.lblEmeraudeCoin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmeraudeCoin.Name = "lblEmeraudeCoin";
            this.lblEmeraudeCoin.Size = new System.Drawing.Size(76, 13);
            this.lblEmeraudeCoin.TabIndex = 4;
            this.lblEmeraudeCoin.Text = "EmeraudeCoin";
            this.lblEmeraudeCoin.Click += new System.EventHandler(this.lblEmeraudeCoin_Click);
            // 
            // lblDiamantCoin
            // 
            this.lblDiamantCoin.AutoSize = true;
            this.lblDiamantCoin.BackColor = System.Drawing.SystemColors.Window;
            this.lblDiamantCoin.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lblDiamantCoin.Location = new System.Drawing.Point(368, 15);
            this.lblDiamantCoin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiamantCoin.Name = "lblDiamantCoin";
            this.lblDiamantCoin.Size = new System.Drawing.Size(67, 13);
            this.lblDiamantCoin.TabIndex = 5;
            this.lblDiamantCoin.Text = "DiamantCoin";
            this.lblDiamantCoin.Click += new System.EventHandler(this.lblDiamandCoin_Click);
            // 
            // txtLevel31
            // 
            this.txtLevel31.BackColor = System.Drawing.SystemColors.Window;
            this.txtLevel31.Location = new System.Drawing.Point(320, 2);
            this.txtLevel31.Margin = new System.Windows.Forms.Padding(2);
            this.txtLevel31.Multiline = true;
            this.txtLevel31.Name = "txtLevel31";
            this.txtLevel31.ReadOnly = true;
            this.txtLevel31.Size = new System.Drawing.Size(102, 98);
            this.txtLevel31.TabIndex = 6;
            // 
            // txtLevel32
            // 
            this.txtLevel32.BackColor = System.Drawing.SystemColors.Window;
            this.txtLevel32.Location = new System.Drawing.Point(214, 2);
            this.txtLevel32.Margin = new System.Windows.Forms.Padding(2);
            this.txtLevel32.Multiline = true;
            this.txtLevel32.Name = "txtLevel32";
            this.txtLevel32.ReadOnly = true;
            this.txtLevel32.Size = new System.Drawing.Size(102, 98);
            this.txtLevel32.TabIndex = 7;
            // 
            // txtLevel33
            // 
            this.txtLevel33.BackColor = System.Drawing.SystemColors.Window;
            this.txtLevel33.Location = new System.Drawing.Point(108, 2);
            this.txtLevel33.Margin = new System.Windows.Forms.Padding(2);
            this.txtLevel33.Multiline = true;
            this.txtLevel33.Name = "txtLevel33";
            this.txtLevel33.ReadOnly = true;
            this.txtLevel33.Size = new System.Drawing.Size(102, 98);
            this.txtLevel33.TabIndex = 8;
            // 
            // txtLevel34
            // 
            this.txtLevel34.BackColor = System.Drawing.SystemColors.Window;
            this.txtLevel34.Location = new System.Drawing.Point(2, 2);
            this.txtLevel34.Margin = new System.Windows.Forms.Padding(2);
            this.txtLevel34.Multiline = true;
            this.txtLevel34.Name = "txtLevel34";
            this.txtLevel34.ReadOnly = true;
            this.txtLevel34.Size = new System.Drawing.Size(102, 98);
            this.txtLevel34.TabIndex = 9;
            // 
            // txtLevel21
            // 
            this.txtLevel21.BackColor = System.Drawing.SystemColors.Window;
            this.txtLevel21.Location = new System.Drawing.Point(320, 2);
            this.txtLevel21.Margin = new System.Windows.Forms.Padding(2);
            this.txtLevel21.Multiline = true;
            this.txtLevel21.Name = "txtLevel21";
            this.txtLevel21.ReadOnly = true;
            this.txtLevel21.Size = new System.Drawing.Size(102, 98);
            this.txtLevel21.TabIndex = 10;
            // 
            // txtLevel22
            // 
            this.txtLevel22.BackColor = System.Drawing.SystemColors.Window;
            this.txtLevel22.Location = new System.Drawing.Point(214, 2);
            this.txtLevel22.Margin = new System.Windows.Forms.Padding(2);
            this.txtLevel22.Multiline = true;
            this.txtLevel22.Name = "txtLevel22";
            this.txtLevel22.ReadOnly = true;
            this.txtLevel22.Size = new System.Drawing.Size(102, 98);
            this.txtLevel22.TabIndex = 11;
            // 
            // txtLevel23
            // 
            this.txtLevel23.BackColor = System.Drawing.SystemColors.Window;
            this.txtLevel23.Location = new System.Drawing.Point(108, 2);
            this.txtLevel23.Margin = new System.Windows.Forms.Padding(2);
            this.txtLevel23.Multiline = true;
            this.txtLevel23.Name = "txtLevel23";
            this.txtLevel23.ReadOnly = true;
            this.txtLevel23.Size = new System.Drawing.Size(102, 98);
            this.txtLevel23.TabIndex = 12;
            // 
            // txtLevel24
            // 
            this.txtLevel24.BackColor = System.Drawing.SystemColors.Window;
            this.txtLevel24.Location = new System.Drawing.Point(2, 2);
            this.txtLevel24.Margin = new System.Windows.Forms.Padding(2);
            this.txtLevel24.Multiline = true;
            this.txtLevel24.Name = "txtLevel24";
            this.txtLevel24.ReadOnly = true;
            this.txtLevel24.Size = new System.Drawing.Size(102, 98);
            this.txtLevel24.TabIndex = 13;
            // 
            // txtLevel14
            // 
            this.txtLevel14.BackColor = System.Drawing.SystemColors.Window;
            this.txtLevel14.Location = new System.Drawing.Point(2, 2);
            this.txtLevel14.Margin = new System.Windows.Forms.Padding(2);
            this.txtLevel14.Multiline = true;
            this.txtLevel14.Name = "txtLevel14";
            this.txtLevel14.ReadOnly = true;
            this.txtLevel14.Size = new System.Drawing.Size(102, 96);
            this.txtLevel14.TabIndex = 17;
            this.txtLevel14.TextChanged += new System.EventHandler(this.txtLevel14_TextChanged);
            // 
            // txtLevel13
            // 
            this.txtLevel13.BackColor = System.Drawing.SystemColors.Window;
            this.txtLevel13.Location = new System.Drawing.Point(108, 2);
            this.txtLevel13.Margin = new System.Windows.Forms.Padding(2);
            this.txtLevel13.Multiline = true;
            this.txtLevel13.Name = "txtLevel13";
            this.txtLevel13.ReadOnly = true;
            this.txtLevel13.Size = new System.Drawing.Size(102, 98);
            this.txtLevel13.TabIndex = 15;
            // 
            // txtLevel12
            // 
            this.txtLevel12.BackColor = System.Drawing.SystemColors.Window;
            this.txtLevel12.Location = new System.Drawing.Point(214, 2);
            this.txtLevel12.Margin = new System.Windows.Forms.Padding(2);
            this.txtLevel12.Multiline = true;
            this.txtLevel12.Name = "txtLevel12";
            this.txtLevel12.ReadOnly = true;
            this.txtLevel12.Size = new System.Drawing.Size(102, 98);
            this.txtLevel12.TabIndex = 16;
            // 
            // txtLevel11
            // 
            this.txtLevel11.BackColor = System.Drawing.SystemColors.Window;
            this.txtLevel11.Location = new System.Drawing.Point(320, 2);
            this.txtLevel11.Margin = new System.Windows.Forms.Padding(2);
            this.txtLevel11.Multiline = true;
            this.txtLevel11.Name = "txtLevel11";
            this.txtLevel11.ReadOnly = true;
            this.txtLevel11.Size = new System.Drawing.Size(102, 98);
            this.txtLevel11.TabIndex = 17;
            // 
            // cmdInsertPlayer
            // 
            this.cmdInsertPlayer.Location = new System.Drawing.Point(501, 153);
            this.cmdInsertPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.cmdInsertPlayer.Name = "cmdInsertPlayer";
            this.cmdInsertPlayer.Size = new System.Drawing.Size(82, 39);
            this.cmdInsertPlayer.TabIndex = 18;
            this.cmdInsertPlayer.Text = "Entrer joueur";
            this.cmdInsertPlayer.UseVisualStyleBackColor = true;
            this.cmdInsertPlayer.Click += new System.EventHandler(this.cmdInsertPlayer_Click);
            // 
            // cmdPlay
            // 
            this.cmdPlay.Location = new System.Drawing.Point(501, 211);
            this.cmdPlay.Margin = new System.Windows.Forms.Padding(2);
            this.cmdPlay.Name = "cmdPlay";
            this.cmdPlay.Size = new System.Drawing.Size(82, 39);
            this.cmdPlay.TabIndex = 19;
            this.cmdPlay.Text = "Jouer";
            this.cmdPlay.UseVisualStyleBackColor = true;
            this.cmdPlay.Click += new System.EventHandler(this.cmdPlay_Click);
            // 
            // txtPlayerEmeraudeCard
            // 
            this.txtPlayerEmeraudeCard.ForeColor = System.Drawing.Color.Green;
            this.txtPlayerEmeraudeCard.Location = new System.Drawing.Point(380, 624);
            this.txtPlayerEmeraudeCard.Margin = new System.Windows.Forms.Padding(2);
            this.txtPlayerEmeraudeCard.Multiline = true;
            this.txtPlayerEmeraudeCard.Name = "txtPlayerEmeraudeCard";
            this.txtPlayerEmeraudeCard.Size = new System.Drawing.Size(81, 98);
            this.txtPlayerEmeraudeCard.TabIndex = 30;
            // 
            // txtPlayerOnyxCard
            // 
            this.txtPlayerOnyxCard.Location = new System.Drawing.Point(260, 624);
            this.txtPlayerOnyxCard.Margin = new System.Windows.Forms.Padding(2);
            this.txtPlayerOnyxCard.Multiline = true;
            this.txtPlayerOnyxCard.Name = "txtPlayerOnyxCard";
            this.txtPlayerOnyxCard.Size = new System.Drawing.Size(81, 98);
            this.txtPlayerOnyxCard.TabIndex = 29;
            // 
            // txtPlayerSaphirCard
            // 
            this.txtPlayerSaphirCard.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtPlayerSaphirCard.Location = new System.Drawing.Point(140, 624);
            this.txtPlayerSaphirCard.Margin = new System.Windows.Forms.Padding(2);
            this.txtPlayerSaphirCard.Multiline = true;
            this.txtPlayerSaphirCard.Name = "txtPlayerSaphirCard";
            this.txtPlayerSaphirCard.Size = new System.Drawing.Size(81, 98);
            this.txtPlayerSaphirCard.TabIndex = 28;
            // 
            // txtPlayerRubisCard
            // 
            this.txtPlayerRubisCard.ForeColor = System.Drawing.Color.Red;
            this.txtPlayerRubisCard.Location = new System.Drawing.Point(20, 624);
            this.txtPlayerRubisCard.Margin = new System.Windows.Forms.Padding(2);
            this.txtPlayerRubisCard.Multiline = true;
            this.txtPlayerRubisCard.Name = "txtPlayerRubisCard";
            this.txtPlayerRubisCard.Size = new System.Drawing.Size(81, 98);
            this.txtPlayerRubisCard.TabIndex = 27;
            // 
            // lblPlayerDiamantCoin
            // 
            this.lblPlayerDiamantCoin.AutoSize = true;
            this.lblPlayerDiamantCoin.BackColor = System.Drawing.SystemColors.Window;
            this.lblPlayerDiamantCoin.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lblPlayerDiamantCoin.Location = new System.Drawing.Point(379, 593);
            this.lblPlayerDiamantCoin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayerDiamantCoin.Name = "lblPlayerDiamantCoin";
            this.lblPlayerDiamantCoin.Size = new System.Drawing.Size(67, 13);
            this.lblPlayerDiamantCoin.TabIndex = 26;
            this.lblPlayerDiamantCoin.Text = "DiamantCoin";
            // 
            // lblPlayerEmeraudeCoin
            // 
            this.lblPlayerEmeraudeCoin.AutoSize = true;
            this.lblPlayerEmeraudeCoin.BackColor = System.Drawing.Color.Green;
            this.lblPlayerEmeraudeCoin.ForeColor = System.Drawing.Color.White;
            this.lblPlayerEmeraudeCoin.Location = new System.Drawing.Point(284, 593);
            this.lblPlayerEmeraudeCoin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayerEmeraudeCoin.Name = "lblPlayerEmeraudeCoin";
            this.lblPlayerEmeraudeCoin.Size = new System.Drawing.Size(76, 13);
            this.lblPlayerEmeraudeCoin.TabIndex = 25;
            this.lblPlayerEmeraudeCoin.Text = "EmeraudeCoin";
            // 
            // lblPlayerOnyxCoin
            // 
            this.lblPlayerOnyxCoin.AutoSize = true;
            this.lblPlayerOnyxCoin.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblPlayerOnyxCoin.ForeColor = System.Drawing.SystemColors.Window;
            this.lblPlayerOnyxCoin.Location = new System.Drawing.Point(200, 593);
            this.lblPlayerOnyxCoin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayerOnyxCoin.Name = "lblPlayerOnyxCoin";
            this.lblPlayerOnyxCoin.Size = new System.Drawing.Size(52, 13);
            this.lblPlayerOnyxCoin.TabIndex = 24;
            this.lblPlayerOnyxCoin.Text = "OnyxCoin";
            // 
            // lblPlayerSaphirCoin
            // 
            this.lblPlayerSaphirCoin.AutoSize = true;
            this.lblPlayerSaphirCoin.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblPlayerSaphirCoin.ForeColor = System.Drawing.SystemColors.Window;
            this.lblPlayerSaphirCoin.Location = new System.Drawing.Point(108, 593);
            this.lblPlayerSaphirCoin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayerSaphirCoin.Name = "lblPlayerSaphirCoin";
            this.lblPlayerSaphirCoin.Size = new System.Drawing.Size(58, 13);
            this.lblPlayerSaphirCoin.TabIndex = 23;
            this.lblPlayerSaphirCoin.Text = "SaphirCoin";
            // 
            // lblPlayerRubisCoin
            // 
            this.lblPlayerRubisCoin.AutoSize = true;
            this.lblPlayerRubisCoin.BackColor = System.Drawing.Color.Red;
            this.lblPlayerRubisCoin.ForeColor = System.Drawing.Color.White;
            this.lblPlayerRubisCoin.Location = new System.Drawing.Point(18, 593);
            this.lblPlayerRubisCoin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayerRubisCoin.Name = "lblPlayerRubisCoin";
            this.lblPlayerRubisCoin.Size = new System.Drawing.Size(55, 13);
            this.lblPlayerRubisCoin.TabIndex = 22;
            this.lblPlayerRubisCoin.Text = "RubisCoin";
            this.lblPlayerRubisCoin.UseMnemonic = false;
            // 
            // lblPlayerGoldCoin
            // 
            this.lblPlayerGoldCoin.AutoSize = true;
            this.lblPlayerGoldCoin.ForeColor = System.Drawing.Color.Yellow;
            this.lblPlayerGoldCoin.Location = new System.Drawing.Point(501, 348);
            this.lblPlayerGoldCoin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayerGoldCoin.Name = "lblPlayerGoldCoin";
            this.lblPlayerGoldCoin.Size = new System.Drawing.Size(50, 13);
            this.lblPlayerGoldCoin.TabIndex = 21;
            this.lblPlayerGoldCoin.Text = "GoldCoin";
            // 
            // txtPlayerBookedCard
            // 
            this.txtPlayerBookedCard.Location = new System.Drawing.Point(503, 374);
            this.txtPlayerBookedCard.Margin = new System.Windows.Forms.Padding(2);
            this.txtPlayerBookedCard.Multiline = true;
            this.txtPlayerBookedCard.Name = "txtPlayerBookedCard";
            this.txtPlayerBookedCard.Size = new System.Drawing.Size(81, 98);
            this.txtPlayerBookedCard.TabIndex = 31;
            // 
            // txtPlayerDiamandCard
            // 
            this.txtPlayerDiamandCard.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPlayerDiamandCard.Location = new System.Drawing.Point(502, 624);
            this.txtPlayerDiamandCard.Margin = new System.Windows.Forms.Padding(2);
            this.txtPlayerDiamandCard.Multiline = true;
            this.txtPlayerDiamandCard.Name = "txtPlayerDiamandCard";
            this.txtPlayerDiamandCard.Size = new System.Drawing.Size(81, 98);
            this.txtPlayerDiamandCard.TabIndex = 32;
            // 
            // lblChoiceRubis
            // 
            this.lblChoiceRubis.AutoSize = true;
            this.lblChoiceRubis.BackColor = System.Drawing.Color.Red;
            this.lblChoiceRubis.ForeColor = System.Drawing.SystemColors.Window;
            this.lblChoiceRubis.Location = new System.Drawing.Point(18, 524);
            this.lblChoiceRubis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChoiceRubis.Name = "lblChoiceRubis";
            this.lblChoiceRubis.Size = new System.Drawing.Size(57, 13);
            this.lblChoiceRubis.TabIndex = 33;
            this.lblChoiceRubis.Text = "choix rubis";
            // 
            // lblChoiceSaphir
            // 
            this.lblChoiceSaphir.AutoSize = true;
            this.lblChoiceSaphir.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblChoiceSaphir.ForeColor = System.Drawing.SystemColors.Window;
            this.lblChoiceSaphir.Location = new System.Drawing.Point(108, 524);
            this.lblChoiceSaphir.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChoiceSaphir.Name = "lblChoiceSaphir";
            this.lblChoiceSaphir.Size = new System.Drawing.Size(63, 13);
            this.lblChoiceSaphir.TabIndex = 34;
            this.lblChoiceSaphir.Text = "choix saphir";
            // 
            // lblChoiceOnyx
            // 
            this.lblChoiceOnyx.AutoSize = true;
            this.lblChoiceOnyx.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblChoiceOnyx.ForeColor = System.Drawing.SystemColors.Window;
            this.lblChoiceOnyx.Location = new System.Drawing.Point(200, 524);
            this.lblChoiceOnyx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChoiceOnyx.Name = "lblChoiceOnyx";
            this.lblChoiceOnyx.Size = new System.Drawing.Size(57, 13);
            this.lblChoiceOnyx.TabIndex = 35;
            this.lblChoiceOnyx.Text = "choix onyx";
            // 
            // lblChoiceEmeraude
            // 
            this.lblChoiceEmeraude.AutoSize = true;
            this.lblChoiceEmeraude.BackColor = System.Drawing.Color.Green;
            this.lblChoiceEmeraude.ForeColor = System.Drawing.SystemColors.Window;
            this.lblChoiceEmeraude.Location = new System.Drawing.Point(284, 524);
            this.lblChoiceEmeraude.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChoiceEmeraude.Name = "lblChoiceEmeraude";
            this.lblChoiceEmeraude.Size = new System.Drawing.Size(82, 13);
            this.lblChoiceEmeraude.TabIndex = 36;
            this.lblChoiceEmeraude.Text = "choix émeraude";
            // 
            // lblChoiceDiamant
            // 
            this.lblChoiceDiamant.AutoSize = true;
            this.lblChoiceDiamant.BackColor = System.Drawing.SystemColors.Window;
            this.lblChoiceDiamant.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lblChoiceDiamant.Location = new System.Drawing.Point(379, 524);
            this.lblChoiceDiamant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChoiceDiamant.Name = "lblChoiceDiamant";
            this.lblChoiceDiamant.Size = new System.Drawing.Size(72, 13);
            this.lblChoiceDiamant.TabIndex = 37;
            this.lblChoiceDiamant.Text = "choix diamant";
            // 
            // cmdValidateChoice
            // 
            this.cmdValidateChoice.Location = new System.Drawing.Point(20, 554);
            this.cmdValidateChoice.Margin = new System.Windows.Forms.Padding(2);
            this.cmdValidateChoice.Name = "cmdValidateChoice";
            this.cmdValidateChoice.Size = new System.Drawing.Size(83, 21);
            this.cmdValidateChoice.TabIndex = 38;
            this.cmdValidateChoice.Text = "Valider choix";
            this.cmdValidateChoice.UseVisualStyleBackColor = true;
            this.cmdValidateChoice.Click += new System.EventHandler(this.cmdValidateChoice_Click);
            // 
            // cmdNextPlayer
            // 
            this.cmdNextPlayer.Location = new System.Drawing.Point(135, 554);
            this.cmdNextPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.cmdNextPlayer.Name = "cmdNextPlayer";
            this.cmdNextPlayer.Size = new System.Drawing.Size(106, 20);
            this.cmdNextPlayer.TabIndex = 39;
            this.cmdNextPlayer.Text = "Joueur suivant";
            this.cmdNextPlayer.UseVisualStyleBackColor = true;
            this.cmdNextPlayer.Click += new System.EventHandler(this.cmdNextPlayer_Click);
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Location = new System.Drawing.Point(22, 499);
            this.lblPlayer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(58, 13);
            this.lblPlayer.TabIndex = 40;
            this.lblPlayer.Text = "Plateau de";
            // 
            // lblChoiceCard
            // 
            this.lblChoiceCard.AutoSize = true;
            this.lblChoiceCard.Location = new System.Drawing.Point(472, 524);
            this.lblChoiceCard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChoiceCard.Name = "lblChoiceCard";
            this.lblChoiceCard.Size = new System.Drawing.Size(67, 13);
            this.lblChoiceCard.TabIndex = 41;
            this.lblChoiceCard.Text = "carte choisie";
            // 
            // txtLevel44
            // 
            this.txtLevel44.BackColor = System.Drawing.SystemColors.Window;
            this.txtLevel44.Location = new System.Drawing.Point(2, 2);
            this.txtLevel44.Margin = new System.Windows.Forms.Padding(2);
            this.txtLevel44.Multiline = true;
            this.txtLevel44.Name = "txtLevel44";
            this.txtLevel44.ReadOnly = true;
            this.txtLevel44.Size = new System.Drawing.Size(102, 98);
            this.txtLevel44.TabIndex = 45;
            // 
            // txtLevel43
            // 
            this.txtLevel43.BackColor = System.Drawing.SystemColors.Window;
            this.txtLevel43.Location = new System.Drawing.Point(108, 2);
            this.txtLevel43.Margin = new System.Windows.Forms.Padding(2);
            this.txtLevel43.Multiline = true;
            this.txtLevel43.Name = "txtLevel43";
            this.txtLevel43.ReadOnly = true;
            this.txtLevel43.Size = new System.Drawing.Size(102, 98);
            this.txtLevel43.TabIndex = 44;
            // 
            // txtLevel42
            // 
            this.txtLevel42.BackColor = System.Drawing.SystemColors.Window;
            this.txtLevel42.Location = new System.Drawing.Point(214, 2);
            this.txtLevel42.Margin = new System.Windows.Forms.Padding(2);
            this.txtLevel42.Multiline = true;
            this.txtLevel42.Name = "txtLevel42";
            this.txtLevel42.ReadOnly = true;
            this.txtLevel42.Size = new System.Drawing.Size(102, 98);
            this.txtLevel42.TabIndex = 43;
            // 
            // txtLevel41
            // 
            this.txtLevel41.BackColor = System.Drawing.SystemColors.Window;
            this.txtLevel41.Location = new System.Drawing.Point(320, 2);
            this.txtLevel41.Margin = new System.Windows.Forms.Padding(2);
            this.txtLevel41.Multiline = true;
            this.txtLevel41.Name = "txtLevel41";
            this.txtLevel41.ReadOnly = true;
            this.txtLevel41.Size = new System.Drawing.Size(102, 98);
            this.txtLevel41.TabIndex = 42;
            // 
            // lblNbPtPrestige
            // 
            this.lblNbPtPrestige.AutoSize = true;
            this.lblNbPtPrestige.Location = new System.Drawing.Point(467, 592);
            this.lblNbPtPrestige.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNbPtPrestige.Name = "lblNbPtPrestige";
            this.lblNbPtPrestige.Size = new System.Drawing.Size(73, 13);
            this.lblNbPtPrestige.TabIndex = 46;
            this.lblNbPtPrestige.Text = "Nb pt prestige";
            // 
            // flwCardLevel1
            // 
            this.flwCardLevel1.Controls.Add(this.txtLevel14);
            this.flwCardLevel1.Controls.Add(this.txtLevel13);
            this.flwCardLevel1.Controls.Add(this.txtLevel12);
            this.flwCardLevel1.Controls.Add(this.txtLevel11);
            this.flwCardLevel1.Location = new System.Drawing.Point(14, 374);
            this.flwCardLevel1.Margin = new System.Windows.Forms.Padding(2);
            this.flwCardLevel1.Name = "flwCardLevel1";
            this.flwCardLevel1.Size = new System.Drawing.Size(452, 107);
            this.flwCardLevel1.TabIndex = 47;
            // 
            // flwCardLevel2
            // 
            this.flwCardLevel2.Controls.Add(this.txtLevel24);
            this.flwCardLevel2.Controls.Add(this.txtLevel23);
            this.flwCardLevel2.Controls.Add(this.txtLevel22);
            this.flwCardLevel2.Controls.Add(this.txtLevel21);
            this.flwCardLevel2.Location = new System.Drawing.Point(14, 257);
            this.flwCardLevel2.Margin = new System.Windows.Forms.Padding(2);
            this.flwCardLevel2.Name = "flwCardLevel2";
            this.flwCardLevel2.Size = new System.Drawing.Size(452, 117);
            this.flwCardLevel2.TabIndex = 48;
            // 
            // flwCardLevel3
            // 
            this.flwCardLevel3.Controls.Add(this.txtLevel34);
            this.flwCardLevel3.Controls.Add(this.txtLevel33);
            this.flwCardLevel3.Controls.Add(this.txtLevel32);
            this.flwCardLevel3.Controls.Add(this.txtLevel31);
            this.flwCardLevel3.Location = new System.Drawing.Point(14, 145);
            this.flwCardLevel3.Margin = new System.Windows.Forms.Padding(2);
            this.flwCardLevel3.Name = "flwCardLevel3";
            this.flwCardLevel3.Size = new System.Drawing.Size(452, 111);
            this.flwCardLevel3.TabIndex = 49;
            // 
            // flwCardLevel4
            // 
            this.flwCardLevel4.Controls.Add(this.txtLevel44);
            this.flwCardLevel4.Controls.Add(this.txtLevel43);
            this.flwCardLevel4.Controls.Add(this.txtLevel42);
            this.flwCardLevel4.Controls.Add(this.txtLevel41);
            this.flwCardLevel4.Location = new System.Drawing.Point(14, 37);
            this.flwCardLevel4.Margin = new System.Windows.Forms.Padding(2);
            this.flwCardLevel4.Name = "flwCardLevel4";
            this.flwCardLevel4.Size = new System.Drawing.Size(452, 109);
            this.flwCardLevel4.TabIndex = 50;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 105);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 46;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // frmSplendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 763);
            this.Controls.Add(this.flwCardLevel4);
            this.Controls.Add(this.flwCardLevel3);
            this.Controls.Add(this.flwCardLevel2);
            this.Controls.Add(this.flwCardLevel1);
            this.Controls.Add(this.lblNbPtPrestige);
            this.Controls.Add(this.lblChoiceCard);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.cmdNextPlayer);
            this.Controls.Add(this.cmdValidateChoice);
            this.Controls.Add(this.lblChoiceDiamant);
            this.Controls.Add(this.lblChoiceEmeraude);
            this.Controls.Add(this.lblChoiceOnyx);
            this.Controls.Add(this.lblChoiceSaphir);
            this.Controls.Add(this.lblChoiceRubis);
            this.Controls.Add(this.txtPlayerDiamandCard);
            this.Controls.Add(this.txtPlayerBookedCard);
            this.Controls.Add(this.txtPlayerEmeraudeCard);
            this.Controls.Add(this.txtPlayerOnyxCard);
            this.Controls.Add(this.txtPlayerSaphirCard);
            this.Controls.Add(this.txtPlayerRubisCard);
            this.Controls.Add(this.lblPlayerDiamantCoin);
            this.Controls.Add(this.lblPlayerEmeraudeCoin);
            this.Controls.Add(this.lblPlayerOnyxCoin);
            this.Controls.Add(this.lblPlayerSaphirCoin);
            this.Controls.Add(this.lblPlayerRubisCoin);
            this.Controls.Add(this.lblPlayerGoldCoin);
            this.Controls.Add(this.cmdPlay);
            this.Controls.Add(this.cmdInsertPlayer);
            this.Controls.Add(this.lblDiamantCoin);
            this.Controls.Add(this.lblEmeraudeCoin);
            this.Controls.Add(this.lblOnyxCoin);
            this.Controls.Add(this.lblSaphirCoin);
            this.Controls.Add(this.lblRubisCoin);
            this.Controls.Add(this.lblGoldCoin);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmSplendor";
            this.Text = "Splendor";
            this.Load += new System.EventHandler(this.frmSplendor_Load);
            this.flwCardLevel1.ResumeLayout(false);
            this.flwCardLevel1.PerformLayout();
            this.flwCardLevel2.ResumeLayout(false);
            this.flwCardLevel2.PerformLayout();
            this.flwCardLevel3.ResumeLayout(false);
            this.flwCardLevel3.PerformLayout();
            this.flwCardLevel4.ResumeLayout(false);
            this.flwCardLevel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGoldCoin;
        private System.Windows.Forms.Label lblRubisCoin;
        private System.Windows.Forms.Label lblSaphirCoin;
        private System.Windows.Forms.Label lblOnyxCoin;
        private System.Windows.Forms.Label lblEmeraudeCoin;
        private System.Windows.Forms.Label lblDiamantCoin;
        private System.Windows.Forms.TextBox txtLevel31;
        private System.Windows.Forms.TextBox txtLevel32;
        private System.Windows.Forms.TextBox txtLevel33;
        private System.Windows.Forms.TextBox txtLevel34;
        private System.Windows.Forms.TextBox txtLevel21;
        private System.Windows.Forms.TextBox txtLevel22;
        private System.Windows.Forms.TextBox txtLevel23;
        private System.Windows.Forms.TextBox txtLevel24;
        private System.Windows.Forms.TextBox txtLevel14;
        private System.Windows.Forms.TextBox txtLevel13;
        private System.Windows.Forms.TextBox txtLevel12;
        private System.Windows.Forms.TextBox txtLevel11;
        private System.Windows.Forms.Button cmdInsertPlayer;
        private System.Windows.Forms.Button cmdPlay;
        private System.Windows.Forms.TextBox txtPlayerEmeraudeCard;
        private System.Windows.Forms.TextBox txtPlayerOnyxCard;
        private System.Windows.Forms.TextBox txtPlayerSaphirCard;
        private System.Windows.Forms.TextBox txtPlayerRubisCard;
        private System.Windows.Forms.Label lblPlayerDiamantCoin;
        private System.Windows.Forms.Label lblPlayerEmeraudeCoin;
        private System.Windows.Forms.Label lblPlayerOnyxCoin;
        private System.Windows.Forms.Label lblPlayerSaphirCoin;
        private System.Windows.Forms.Label lblPlayerRubisCoin;
        private System.Windows.Forms.Label lblPlayerGoldCoin;
        private System.Windows.Forms.TextBox txtPlayerBookedCard;
        private System.Windows.Forms.TextBox txtPlayerDiamandCard;
        private System.Windows.Forms.Label lblChoiceRubis;
        private System.Windows.Forms.Label lblChoiceSaphir;
        private System.Windows.Forms.Label lblChoiceOnyx;
        private System.Windows.Forms.Label lblChoiceEmeraude;
        private System.Windows.Forms.Label lblChoiceDiamant;
        private System.Windows.Forms.Button cmdValidateChoice;
        private System.Windows.Forms.Button cmdNextPlayer;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblChoiceCard;
        private System.Windows.Forms.TextBox txtLevel44;
        private System.Windows.Forms.TextBox txtLevel43;
        private System.Windows.Forms.TextBox txtLevel42;
        private System.Windows.Forms.TextBox txtLevel41;
        private System.Windows.Forms.Label lblNbPtPrestige;
        private System.Windows.Forms.FlowLayoutPanel flwCardLevel1;
        private System.Windows.Forms.FlowLayoutPanel flwCardLevel2;
        private System.Windows.Forms.FlowLayoutPanel flwCardLevel3;
        private System.Windows.Forms.FlowLayoutPanel flwCardLevel4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

