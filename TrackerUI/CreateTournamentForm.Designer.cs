namespace TrackerUI
{
    partial class CreateTournamentForm
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.tournamentNameTB = new System.Windows.Forms.TextBox();
            this.tournamentNameLabel = new System.Windows.Forms.Label();
            this.entryFeeTB = new System.Windows.Forms.TextBox();
            this.entryFeeLabel = new System.Windows.Forms.Label();
            this.selectTeamDropDown = new System.Windows.Forms.ComboBox();
            this.selectTeamLabel = new System.Windows.Forms.Label();
            this.createNewTeamLinkLabel = new System.Windows.Forms.LinkLabel();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.tournamentPlayersListBox = new System.Windows.Forms.ListBox();
            this.teamPlayersLabel = new System.Windows.Forms.Label();
            this.deleteSelectedPrizeButton = new System.Windows.Forms.Button();
            this.teamsPlayersLabel2 = new System.Windows.Forms.Label();
            this.prizesListBox = new System.Windows.Forms.ListBox();
            this.deleteSelectedPlayerButton = new System.Windows.Forms.Button();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.Location = new System.Drawing.Point(30, 28);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(356, 42);
            this.headerLabel.TabIndex = 29;
            this.headerLabel.Text = "Create Tournament";
            // 
            // tournamentNameTB
            // 
            this.tournamentNameTB.Location = new System.Drawing.Point(222, 102);
            this.tournamentNameTB.Name = "tournamentNameTB";
            this.tournamentNameTB.Size = new System.Drawing.Size(243, 31);
            this.tournamentNameTB.TabIndex = 38;
            // 
            // tournamentNameLabel
            // 
            this.tournamentNameLabel.AutoSize = true;
            this.tournamentNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tournamentNameLabel.ForeColor = System.Drawing.Color.White;
            this.tournamentNameLabel.Location = new System.Drawing.Point(30, 100);
            this.tournamentNameLabel.Name = "tournamentNameLabel";
            this.tournamentNameLabel.Size = new System.Drawing.Size(186, 30);
            this.tournamentNameLabel.TabIndex = 37;
            this.tournamentNameLabel.Text = "Tournament Name";
            // 
            // entryFeeTB
            // 
            this.entryFeeTB.Location = new System.Drawing.Point(140, 167);
            this.entryFeeTB.Name = "entryFeeTB";
            this.entryFeeTB.Size = new System.Drawing.Size(140, 31);
            this.entryFeeTB.TabIndex = 40;
            this.entryFeeTB.Text = "0";
            // 
            // entryFeeLabel
            // 
            this.entryFeeLabel.AutoSize = true;
            this.entryFeeLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.entryFeeLabel.ForeColor = System.Drawing.Color.White;
            this.entryFeeLabel.Location = new System.Drawing.Point(36, 165);
            this.entryFeeLabel.Name = "entryFeeLabel";
            this.entryFeeLabel.Size = new System.Drawing.Size(98, 30);
            this.entryFeeLabel.TabIndex = 39;
            this.entryFeeLabel.Text = "Entry Fee";
            // 
            // selectTeamDropDown
            // 
            this.selectTeamDropDown.FormattingEnabled = true;
            this.selectTeamDropDown.Location = new System.Drawing.Point(166, 234);
            this.selectTeamDropDown.Name = "selectTeamDropDown";
            this.selectTeamDropDown.Size = new System.Drawing.Size(299, 31);
            this.selectTeamDropDown.TabIndex = 42;
            // 
            // selectTeamLabel
            // 
            this.selectTeamLabel.AutoSize = true;
            this.selectTeamLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectTeamLabel.ForeColor = System.Drawing.Color.White;
            this.selectTeamLabel.Location = new System.Drawing.Point(37, 232);
            this.selectTeamLabel.Name = "selectTeamLabel";
            this.selectTeamLabel.Size = new System.Drawing.Size(123, 30);
            this.selectTeamLabel.TabIndex = 41;
            this.selectTeamLabel.Text = "Select Team";
            // 
            // createNewTeamLinkLabel
            // 
            this.createNewTeamLinkLabel.AutoSize = true;
            this.createNewTeamLinkLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createNewTeamLinkLabel.LinkColor = System.Drawing.Color.White;
            this.createNewTeamLinkLabel.Location = new System.Drawing.Point(341, 215);
            this.createNewTeamLinkLabel.Name = "createNewTeamLinkLabel";
            this.createNewTeamLinkLabel.Size = new System.Drawing.Size(124, 16);
            this.createNewTeamLinkLabel.TabIndex = 43;
            this.createNewTeamLinkLabel.TabStop = true;
            this.createNewTeamLinkLabel.Text = "Create New Team";
            // 
            // addTeamButton
            // 
            this.addTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.addTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addTeamButton.ForeColor = System.Drawing.Color.White;
            this.addTeamButton.Location = new System.Drawing.Point(37, 295);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(141, 43);
            this.addTeamButton.TabIndex = 44;
            this.addTeamButton.Text = "Add Team";
            this.addTeamButton.UseVisualStyleBackColor = true;
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizeButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createPrizeButton.ForeColor = System.Drawing.Color.White;
            this.createPrizeButton.Location = new System.Drawing.Point(205, 295);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(141, 43);
            this.createPrizeButton.TabIndex = 45;
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.UseVisualStyleBackColor = true;
            // 
            // tournamentPlayersListBox
            // 
            this.tournamentPlayersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tournamentPlayersListBox.FormattingEnabled = true;
            this.tournamentPlayersListBox.ItemHeight = 23;
            this.tournamentPlayersListBox.Location = new System.Drawing.Point(499, 81);
            this.tournamentPlayersListBox.Name = "tournamentPlayersListBox";
            this.tournamentPlayersListBox.Size = new System.Drawing.Size(275, 117);
            this.tournamentPlayersListBox.TabIndex = 46;
            // 
            // teamPlayersLabel
            // 
            this.teamPlayersLabel.AutoSize = true;
            this.teamPlayersLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamPlayersLabel.ForeColor = System.Drawing.Color.White;
            this.teamPlayersLabel.Location = new System.Drawing.Point(499, 48);
            this.teamPlayersLabel.Name = "teamPlayersLabel";
            this.teamPlayersLabel.Size = new System.Drawing.Size(156, 30);
            this.teamPlayersLabel.TabIndex = 47;
            this.teamPlayersLabel.Text = "Teams / Players";
            // 
            // deleteSelectedPrizeButton
            // 
            this.deleteSelectedPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.deleteSelectedPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.deleteSelectedPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedPrizeButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteSelectedPrizeButton.ForeColor = System.Drawing.Color.White;
            this.deleteSelectedPrizeButton.Location = new System.Drawing.Point(661, 204);
            this.deleteSelectedPrizeButton.Name = "deleteSelectedPrizeButton";
            this.deleteSelectedPrizeButton.Size = new System.Drawing.Size(113, 36);
            this.deleteSelectedPrizeButton.TabIndex = 51;
            this.deleteSelectedPrizeButton.Text = "Delete Selected";
            this.deleteSelectedPrizeButton.UseVisualStyleBackColor = true;
            // 
            // teamsPlayersLabel2
            // 
            this.teamsPlayersLabel2.AutoSize = true;
            this.teamsPlayersLabel2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamsPlayersLabel2.ForeColor = System.Drawing.Color.White;
            this.teamsPlayersLabel2.Location = new System.Drawing.Point(499, 213);
            this.teamsPlayersLabel2.Name = "teamsPlayersLabel2";
            this.teamsPlayersLabel2.Size = new System.Drawing.Size(156, 30);
            this.teamsPlayersLabel2.TabIndex = 50;
            this.teamsPlayersLabel2.Text = "Teams / Players";
            // 
            // prizesListBox
            // 
            this.prizesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prizesListBox.FormattingEnabled = true;
            this.prizesListBox.ItemHeight = 23;
            this.prizesListBox.Location = new System.Drawing.Point(499, 246);
            this.prizesListBox.Name = "prizesListBox";
            this.prizesListBox.Size = new System.Drawing.Size(275, 117);
            this.prizesListBox.TabIndex = 49;
            // 
            // deleteSelectedPlayerButton
            // 
            this.deleteSelectedPlayerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.deleteSelectedPlayerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.deleteSelectedPlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedPlayerButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteSelectedPlayerButton.ForeColor = System.Drawing.Color.White;
            this.deleteSelectedPlayerButton.Location = new System.Drawing.Point(661, 42);
            this.deleteSelectedPlayerButton.Name = "deleteSelectedPlayerButton";
            this.deleteSelectedPlayerButton.Size = new System.Drawing.Size(113, 36);
            this.deleteSelectedPlayerButton.TabIndex = 52;
            this.deleteSelectedPlayerButton.Text = "Delete Selected";
            this.deleteSelectedPlayerButton.UseVisualStyleBackColor = true;
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createTournamentButton.ForeColor = System.Drawing.Color.White;
            this.createTournamentButton.Location = new System.Drawing.Point(37, 367);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(212, 43);
            this.createTournamentButton.TabIndex = 53;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(786, 434);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.deleteSelectedPlayerButton);
            this.Controls.Add(this.deleteSelectedPrizeButton);
            this.Controls.Add(this.teamsPlayersLabel2);
            this.Controls.Add(this.prizesListBox);
            this.Controls.Add(this.teamPlayersLabel);
            this.Controls.Add(this.tournamentPlayersListBox);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.addTeamButton);
            this.Controls.Add(this.createNewTeamLinkLabel);
            this.Controls.Add(this.selectTeamDropDown);
            this.Controls.Add(this.selectTeamLabel);
            this.Controls.Add(this.entryFeeTB);
            this.Controls.Add(this.entryFeeLabel);
            this.Controls.Add(this.tournamentNameTB);
            this.Controls.Add(this.tournamentNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "CreateTournamentForm";
            this.Text = "Create Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label headerLabel;
        private TextBox tournamentNameTB;
        private Label tournamentNameLabel;
        private TextBox entryFeeTB;
        private Label entryFeeLabel;
        private ComboBox selectTeamDropDown;
        private Label selectTeamLabel;
        private LinkLabel createNewTeamLinkLabel;
        private Button addTeamButton;
        private Button createPrizeButton;
        private ListBox tournamentPlayersListBox;
        private Label teamPlayersLabel;
        private Button deleteSelectedPrizeButton;
        private Label teamsPlayersLabel2;
        private ListBox prizesListBox;
        private Button deleteSelectedPlayerButton;
        private Button createTournamentButton;
    }
}