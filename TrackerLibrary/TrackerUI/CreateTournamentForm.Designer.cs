
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
            this.tournamentNameLabel = new System.Windows.Forms.Label();
            this.tournamentNameValue = new System.Windows.Forms.TextBox();
            this.teamsListBox = new System.Windows.Forms.ListBox();
            this.teamDropdown = new System.Windows.Forms.ComboBox();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.prizeListBox = new System.Windows.Forms.ListBox();
            this.teamsLabel = new System.Windows.Forms.Label();
            this.prizesLabel = new System.Windows.Forms.Label();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.removePrizeButton = new System.Windows.Forms.Button();
            this.newTeamButton = new System.Windows.Forms.Button();
            this.removeTeamButton = new System.Windows.Forms.Button();
            this.entryFeeValue = new System.Windows.Forms.TextBox();
            this.entryFeeLabel = new System.Windows.Forms.Label();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.BackColor = System.Drawing.Color.Transparent;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.White;
            this.headerLabel.Location = new System.Drawing.Point(57, 56);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(430, 65);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Create Tournament";
            this.headerLabel.Click += new System.EventHandler(this.headerLabel_Click);
            // 
            // tournamentNameLabel
            // 
            this.tournamentNameLabel.AutoSize = true;
            this.tournamentNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.tournamentNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentNameLabel.ForeColor = System.Drawing.Color.White;
            this.tournamentNameLabel.Location = new System.Drawing.Point(61, 150);
            this.tournamentNameLabel.Name = "tournamentNameLabel";
            this.tournamentNameLabel.Size = new System.Drawing.Size(256, 40);
            this.tournamentNameLabel.TabIndex = 4;
            this.tournamentNameLabel.Text = "Tournament name";
            // 
            // tournamentNameValue
            // 
            this.tournamentNameValue.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.tournamentNameValue.Location = new System.Drawing.Point(68, 193);
            this.tournamentNameValue.Name = "tournamentNameValue";
            this.tournamentNameValue.Size = new System.Drawing.Size(324, 33);
            this.tournamentNameValue.TabIndex = 10;
            // 
            // teamsListBox
            // 
            this.teamsListBox.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.teamsListBox.FormattingEnabled = true;
            this.teamsListBox.ItemHeight = 25;
            this.teamsListBox.Location = new System.Drawing.Point(71, 418);
            this.teamsListBox.Name = "teamsListBox";
            this.teamsListBox.Size = new System.Drawing.Size(321, 279);
            this.teamsListBox.TabIndex = 11;
            // 
            // teamDropdown
            // 
            this.teamDropdown.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamDropdown.FormattingEnabled = true;
            this.teamDropdown.Location = new System.Drawing.Point(71, 704);
            this.teamDropdown.Name = "teamDropdown";
            this.teamDropdown.Size = new System.Drawing.Size(277, 33);
            this.teamDropdown.TabIndex = 12;
            // 
            // addTeamButton
            // 
            this.addTeamButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.addTeamButton.FlatAppearance.BorderSize = 0;
            this.addTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamButton.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.addTeamButton.ForeColor = System.Drawing.Color.White;
            this.addTeamButton.Location = new System.Drawing.Point(354, 704);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(38, 33);
            this.addTeamButton.TabIndex = 13;
            this.addTeamButton.Text = "⬆";
            this.addTeamButton.UseVisualStyleBackColor = false;
            this.addTeamButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // prizeListBox
            // 
            this.prizeListBox.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.prizeListBox.FormattingEnabled = true;
            this.prizeListBox.ItemHeight = 25;
            this.prizeListBox.Location = new System.Drawing.Point(449, 418);
            this.prizeListBox.Name = "prizeListBox";
            this.prizeListBox.Size = new System.Drawing.Size(321, 279);
            this.prizeListBox.TabIndex = 15;
            // 
            // teamsLabel
            // 
            this.teamsLabel.AutoSize = true;
            this.teamsLabel.BackColor = System.Drawing.Color.Transparent;
            this.teamsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamsLabel.ForeColor = System.Drawing.Color.White;
            this.teamsLabel.Location = new System.Drawing.Point(64, 375);
            this.teamsLabel.Name = "teamsLabel";
            this.teamsLabel.Size = new System.Drawing.Size(99, 40);
            this.teamsLabel.TabIndex = 19;
            this.teamsLabel.Text = "Teams";
            // 
            // prizesLabel
            // 
            this.prizesLabel.AutoSize = true;
            this.prizesLabel.BackColor = System.Drawing.Color.Transparent;
            this.prizesLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizesLabel.ForeColor = System.Drawing.Color.White;
            this.prizesLabel.Location = new System.Drawing.Point(442, 375);
            this.prizesLabel.Name = "prizesLabel";
            this.prizesLabel.Size = new System.Drawing.Size(94, 40);
            this.prizesLabel.TabIndex = 20;
            this.prizesLabel.Text = "Prizes";
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.BackColor = System.Drawing.Color.LimeGreen;
            this.createPrizeButton.FlatAppearance.BorderSize = 0;
            this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizeButton.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.createPrizeButton.ForeColor = System.Drawing.Color.White;
            this.createPrizeButton.Location = new System.Drawing.Point(688, 379);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(38, 33);
            this.createPrizeButton.TabIndex = 23;
            this.createPrizeButton.Text = "➕";
            this.createPrizeButton.UseVisualStyleBackColor = false;
            this.createPrizeButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // removePrizeButton
            // 
            this.removePrizeButton.BackColor = System.Drawing.Color.IndianRed;
            this.removePrizeButton.FlatAppearance.BorderSize = 0;
            this.removePrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removePrizeButton.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.removePrizeButton.ForeColor = System.Drawing.Color.White;
            this.removePrizeButton.Location = new System.Drawing.Point(732, 379);
            this.removePrizeButton.Name = "removePrizeButton";
            this.removePrizeButton.Size = new System.Drawing.Size(38, 33);
            this.removePrizeButton.TabIndex = 22;
            this.removePrizeButton.Text = "✖";
            this.removePrizeButton.UseVisualStyleBackColor = false;
            this.removePrizeButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // newTeamButton
            // 
            this.newTeamButton.BackColor = System.Drawing.Color.LimeGreen;
            this.newTeamButton.FlatAppearance.BorderSize = 0;
            this.newTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newTeamButton.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.newTeamButton.ForeColor = System.Drawing.Color.White;
            this.newTeamButton.Location = new System.Drawing.Point(310, 379);
            this.newTeamButton.Name = "newTeamButton";
            this.newTeamButton.Size = new System.Drawing.Size(38, 33);
            this.newTeamButton.TabIndex = 25;
            this.newTeamButton.Text = "➕";
            this.newTeamButton.UseVisualStyleBackColor = false;
            // 
            // removeTeamButton
            // 
            this.removeTeamButton.BackColor = System.Drawing.Color.IndianRed;
            this.removeTeamButton.FlatAppearance.BorderSize = 0;
            this.removeTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeTeamButton.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.removeTeamButton.ForeColor = System.Drawing.Color.White;
            this.removeTeamButton.Location = new System.Drawing.Point(354, 379);
            this.removeTeamButton.Name = "removeTeamButton";
            this.removeTeamButton.Size = new System.Drawing.Size(38, 33);
            this.removeTeamButton.TabIndex = 24;
            this.removeTeamButton.Text = "✖";
            this.removeTeamButton.UseVisualStyleBackColor = false;
            // 
            // entryFeeValue
            // 
            this.entryFeeValue.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.entryFeeValue.Location = new System.Drawing.Point(68, 298);
            this.entryFeeValue.Name = "entryFeeValue";
            this.entryFeeValue.Size = new System.Drawing.Size(148, 33);
            this.entryFeeValue.TabIndex = 27;
            this.entryFeeValue.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // entryFeeLabel
            // 
            this.entryFeeLabel.AutoSize = true;
            this.entryFeeLabel.BackColor = System.Drawing.Color.Transparent;
            this.entryFeeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryFeeLabel.ForeColor = System.Drawing.Color.White;
            this.entryFeeLabel.Location = new System.Drawing.Point(61, 255);
            this.entryFeeLabel.Name = "entryFeeLabel";
            this.entryFeeLabel.Size = new System.Drawing.Size(139, 40);
            this.entryFeeLabel.TabIndex = 26;
            this.entryFeeLabel.Text = "Entry Fee";
            this.entryFeeLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTournamentButton.ForeColor = System.Drawing.Color.White;
            this.createTournamentButton.Location = new System.Drawing.Point(280, 797);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(291, 62);
            this.createTournamentButton.TabIndex = 28;
            this.createTournamentButton.Text = "CREATE TOURNAMENT";
            this.createTournamentButton.UseVisualStyleBackColor = false;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(841, 905);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.entryFeeValue);
            this.Controls.Add(this.entryFeeLabel);
            this.Controls.Add(this.newTeamButton);
            this.Controls.Add(this.removeTeamButton);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.removePrizeButton);
            this.Controls.Add(this.prizesLabel);
            this.Controls.Add(this.teamsLabel);
            this.Controls.Add(this.prizeListBox);
            this.Controls.Add(this.addTeamButton);
            this.Controls.Add(this.teamDropdown);
            this.Controls.Add(this.teamsListBox);
            this.Controls.Add(this.tournamentNameValue);
            this.Controls.Add(this.tournamentNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Name = "CreateTournamentForm";
            this.Text = "CreateTournamentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label tournamentNameLabel;
        private System.Windows.Forms.TextBox tournamentNameValue;
        private System.Windows.Forms.ListBox teamsListBox;
        private System.Windows.Forms.ComboBox teamDropdown;
        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.ListBox prizeListBox;
        private System.Windows.Forms.Label teamsLabel;
        private System.Windows.Forms.Label prizesLabel;
        private System.Windows.Forms.Button createPrizeButton;
        private System.Windows.Forms.Button removePrizeButton;
        private System.Windows.Forms.Button newTeamButton;
        private System.Windows.Forms.Button removeTeamButton;
        private System.Windows.Forms.TextBox entryFeeValue;
        private System.Windows.Forms.Label entryFeeLabel;
        private System.Windows.Forms.Button createTournamentButton;
    }
}