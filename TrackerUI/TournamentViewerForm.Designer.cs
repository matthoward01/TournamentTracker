namespace TrackerUI
{
    partial class TournamentViewerForm
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
            this.scoreButton = new System.Windows.Forms.Button();
            this.vsLabel = new System.Windows.Forms.Label();
            this.teamTwoScoreTB = new System.Windows.Forms.TextBox();
            this.teamTwoScoreLabel = new System.Windows.Forms.Label();
            this.teamTwoNameLabel = new System.Windows.Forms.Label();
            this.teamOneScoreTB = new System.Windows.Forms.TextBox();
            this.teamOneScoreLabel = new System.Windows.Forms.Label();
            this.teamOneNameLabel = new System.Windows.Forms.Label();
            this.matchupListBox = new System.Windows.Forms.ListBox();
            this.unplayedOnlyCBox = new System.Windows.Forms.CheckBox();
            this.roundDropDown = new System.Windows.Forms.ComboBox();
            this.roundLabel = new System.Windows.Forms.Label();
            this.tournamentName = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // scoreButton
            // 
            this.scoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.scoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.scoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreButton.Location = new System.Drawing.Point(609, 361);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(113, 54);
            this.scoreButton.TabIndex = 41;
            this.scoreButton.Text = "Score";
            this.scoreButton.UseVisualStyleBackColor = true;
            // 
            // vsLabel
            // 
            this.vsLabel.AutoSize = true;
            this.vsLabel.Location = new System.Drawing.Point(471, 299);
            this.vsLabel.Name = "vsLabel";
            this.vsLabel.Size = new System.Drawing.Size(20, 15);
            this.vsLabel.TabIndex = 40;
            this.vsLabel.Text = "VS";
            // 
            // teamTwoScoreTB
            // 
            this.teamTwoScoreTB.Location = new System.Drawing.Point(484, 382);
            this.teamTwoScoreTB.Name = "teamTwoScoreTB";
            this.teamTwoScoreTB.Size = new System.Drawing.Size(100, 23);
            this.teamTwoScoreTB.TabIndex = 39;
            // 
            // teamTwoScoreLabel
            // 
            this.teamTwoScoreLabel.AutoSize = true;
            this.teamTwoScoreLabel.Location = new System.Drawing.Point(406, 385);
            this.teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            this.teamTwoScoreLabel.Size = new System.Drawing.Size(36, 15);
            this.teamTwoScoreLabel.TabIndex = 38;
            this.teamTwoScoreLabel.Text = "Score";
            // 
            // teamTwoNameLabel
            // 
            this.teamTwoNameLabel.AutoSize = true;
            this.teamTwoNameLabel.Location = new System.Drawing.Point(406, 337);
            this.teamTwoNameLabel.Name = "teamTwoNameLabel";
            this.teamTwoNameLabel.Size = new System.Drawing.Size(59, 15);
            this.teamTwoNameLabel.TabIndex = 37;
            this.teamTwoNameLabel.Text = "<team 2>";
            // 
            // teamOneScoreTB
            // 
            this.teamOneScoreTB.Location = new System.Drawing.Point(484, 246);
            this.teamOneScoreTB.Name = "teamOneScoreTB";
            this.teamOneScoreTB.Size = new System.Drawing.Size(100, 23);
            this.teamOneScoreTB.TabIndex = 36;
            // 
            // teamOneScoreLabel
            // 
            this.teamOneScoreLabel.AutoSize = true;
            this.teamOneScoreLabel.Location = new System.Drawing.Point(406, 249);
            this.teamOneScoreLabel.Name = "teamOneScoreLabel";
            this.teamOneScoreLabel.Size = new System.Drawing.Size(36, 15);
            this.teamOneScoreLabel.TabIndex = 35;
            this.teamOneScoreLabel.Text = "Score";
            // 
            // teamOneNameLabel
            // 
            this.teamOneNameLabel.AutoSize = true;
            this.teamOneNameLabel.Location = new System.Drawing.Point(406, 201);
            this.teamOneNameLabel.Name = "teamOneNameLabel";
            this.teamOneNameLabel.Size = new System.Drawing.Size(59, 15);
            this.teamOneNameLabel.TabIndex = 34;
            this.teamOneNameLabel.Text = "<team 1>";
            // 
            // matchupListBox
            // 
            this.matchupListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchupListBox.FormattingEnabled = true;
            this.matchupListBox.ItemHeight = 15;
            this.matchupListBox.Location = new System.Drawing.Point(79, 201);
            this.matchupListBox.Name = "matchupListBox";
            this.matchupListBox.Size = new System.Drawing.Size(275, 227);
            this.matchupListBox.TabIndex = 33;
            // 
            // unplayedOnlyCBox
            // 
            this.unplayedOnlyCBox.AutoSize = true;
            this.unplayedOnlyCBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unplayedOnlyCBox.Location = new System.Drawing.Point(173, 151);
            this.unplayedOnlyCBox.Name = "unplayedOnlyCBox";
            this.unplayedOnlyCBox.Size = new System.Drawing.Size(101, 19);
            this.unplayedOnlyCBox.TabIndex = 32;
            this.unplayedOnlyCBox.Text = "Unplayed Only";
            this.unplayedOnlyCBox.UseVisualStyleBackColor = true;
            // 
            // roundDropDown
            // 
            this.roundDropDown.FormattingEnabled = true;
            this.roundDropDown.Location = new System.Drawing.Point(173, 100);
            this.roundDropDown.Name = "roundDropDown";
            this.roundDropDown.Size = new System.Drawing.Size(181, 23);
            this.roundDropDown.TabIndex = 31;
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.Location = new System.Drawing.Point(89, 103);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(42, 15);
            this.roundLabel.TabIndex = 30;
            this.roundLabel.Text = "Round";
            // 
            // tournamentName
            // 
            this.tournamentName.AutoSize = true;
            this.tournamentName.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tournamentName.Location = new System.Drawing.Point(329, 23);
            this.tournamentName.Name = "tournamentName";
            this.tournamentName.Size = new System.Drawing.Size(166, 42);
            this.tournamentName.TabIndex = 29;
            this.tournamentName.Text = "<None>";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.Location = new System.Drawing.Point(79, 23);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(244, 42);
            this.headerLabel.TabIndex = 28;
            this.headerLabel.Text = "Tournament:";
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.vsLabel);
            this.Controls.Add(this.teamTwoScoreTB);
            this.Controls.Add(this.teamTwoScoreLabel);
            this.Controls.Add(this.teamTwoNameLabel);
            this.Controls.Add(this.teamOneScoreTB);
            this.Controls.Add(this.teamOneScoreLabel);
            this.Controls.Add(this.teamOneNameLabel);
            this.Controls.Add(this.matchupListBox);
            this.Controls.Add(this.unplayedOnlyCBox);
            this.Controls.Add(this.roundDropDown);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.tournamentName);
            this.Controls.Add(this.headerLabel);
            this.Name = "TournamentViewerForm";
            this.Text = "TournamentViewerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button scoreButton;
        private Label vsLabel;
        private TextBox teamTwoScoreTB;
        private Label teamTwoScoreLabel;
        private Label teamTwoNameLabel;
        private TextBox teamOneScoreTB;
        private Label teamOneScoreLabel;
        private Label teamOneNameLabel;
        private ListBox matchupListBox;
        private CheckBox unplayedOnlyCBox;
        private ComboBox roundDropDown;
        private Label roundLabel;
        private Label tournamentName;
        private Label headerLabel;
    }
}