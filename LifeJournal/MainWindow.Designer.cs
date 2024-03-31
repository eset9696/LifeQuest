namespace LifeQuest
{
	partial class MainWindow
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			this.tabControlMainPages = new System.Windows.Forms.TabControl();
			this.tabPageMain = new System.Windows.Forms.TabPage();
			this.checkedListBoxMainHabbits = new System.Windows.Forms.CheckedListBox();
			this.buttonMainAddHabbit = new System.Windows.Forms.Button();
			this.panelMainClaimReward = new System.Windows.Forms.Panel();
			this.labelMainProgress = new System.Windows.Forms.Label();
			this.btnClaimReward = new System.Windows.Forms.Button();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.tabPageQuestJournal = new System.Windows.Forms.TabPage();
			this.imageListTabs = new System.Windows.Forms.ImageList(this.components);
			this.tabControlMainPages.SuspendLayout();
			this.tabPageMain.SuspendLayout();
			this.panelMainClaimReward.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControlMainPages
			// 
			this.tabControlMainPages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControlMainPages.Appearance = System.Windows.Forms.TabAppearance.Buttons;
			this.tabControlMainPages.Controls.Add(this.tabPageMain);
			this.tabControlMainPages.Controls.Add(this.tabPageQuestJournal);
			this.tabControlMainPages.ImageList = this.imageListTabs;
			this.tabControlMainPages.ItemSize = new System.Drawing.Size(80, 80);
			this.tabControlMainPages.Location = new System.Drawing.Point(12, 12);
			this.tabControlMainPages.Multiline = true;
			this.tabControlMainPages.Name = "tabControlMainPages";
			this.tabControlMainPages.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.tabControlMainPages.SelectedIndex = 0;
			this.tabControlMainPages.Size = new System.Drawing.Size(826, 536);
			this.tabControlMainPages.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.tabControlMainPages.TabIndex = 0;
			// 
			// tabPageMain
			// 
			this.tabPageMain.BackColor = System.Drawing.Color.White;
			this.tabPageMain.Controls.Add(this.checkedListBoxMainHabbits);
			this.tabPageMain.Controls.Add(this.buttonMainAddHabbit);
			this.tabPageMain.Controls.Add(this.panelMainClaimReward);
			this.tabPageMain.ImageIndex = 1;
			this.tabPageMain.Location = new System.Drawing.Point(4, 84);
			this.tabPageMain.Name = "tabPageMain";
			this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageMain.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.tabPageMain.Size = new System.Drawing.Size(818, 448);
			this.tabPageMain.TabIndex = 0;
			// 
			// checkedListBoxMainHabbits
			// 
			this.checkedListBoxMainHabbits.CheckOnClick = true;
			this.checkedListBoxMainHabbits.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.checkedListBoxMainHabbits.FormattingEnabled = true;
			this.checkedListBoxMainHabbits.Location = new System.Drawing.Point(6, 107);
			this.checkedListBoxMainHabbits.Name = "checkedListBoxMainHabbits";
			this.checkedListBoxMainHabbits.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.checkedListBoxMainHabbits.Size = new System.Drawing.Size(803, 290);
			this.checkedListBoxMainHabbits.TabIndex = 4;
			// 
			// buttonMainAddHabbit
			// 
			this.buttonMainAddHabbit.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonMainAddHabbit.ForeColor = System.Drawing.Color.RoyalBlue;
			this.buttonMainAddHabbit.Location = new System.Drawing.Point(6, 396);
			this.buttonMainAddHabbit.Name = "buttonMainAddHabbit";
			this.buttonMainAddHabbit.Size = new System.Drawing.Size(803, 46);
			this.buttonMainAddHabbit.TabIndex = 0;
			this.buttonMainAddHabbit.Text = "+";
			this.buttonMainAddHabbit.UseVisualStyleBackColor = true;
			this.buttonMainAddHabbit.Click += new System.EventHandler(this.buttonMainAddHabbit_Click);
			// 
			// panelMainClaimReward
			// 
			this.panelMainClaimReward.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelMainClaimReward.BackColor = System.Drawing.Color.RoyalBlue;
			this.panelMainClaimReward.Controls.Add(this.labelMainProgress);
			this.panelMainClaimReward.Controls.Add(this.btnClaimReward);
			this.panelMainClaimReward.Controls.Add(this.progressBar1);
			this.panelMainClaimReward.Location = new System.Drawing.Point(6, 18);
			this.panelMainClaimReward.Name = "panelMainClaimReward";
			this.panelMainClaimReward.Size = new System.Drawing.Size(806, 82);
			this.panelMainClaimReward.TabIndex = 3;
			// 
			// labelMainProgress
			// 
			this.labelMainProgress.AutoSize = true;
			this.labelMainProgress.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelMainProgress.ForeColor = System.Drawing.Color.Khaki;
			this.labelMainProgress.Location = new System.Drawing.Point(3, 9);
			this.labelMainProgress.Name = "labelMainProgress";
			this.labelMainProgress.Size = new System.Drawing.Size(86, 23);
			this.labelMainProgress.TabIndex = 1;
			this.labelMainProgress.Text = "Points:";
			// 
			// btnClaimReward
			// 
			this.btnClaimReward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClaimReward.BackColor = System.Drawing.Color.Brown;
			this.btnClaimReward.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnClaimReward.FlatAppearance.BorderSize = 0;
			this.btnClaimReward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClaimReward.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClaimReward.ForeColor = System.Drawing.Color.Khaki;
			this.btnClaimReward.Location = new System.Drawing.Point(688, 31);
			this.btnClaimReward.Name = "btnClaimReward";
			this.btnClaimReward.Size = new System.Drawing.Size(98, 25);
			this.btnClaimReward.TabIndex = 1;
			this.btnClaimReward.Text = "Claim";
			this.btnClaimReward.UseVisualStyleBackColor = false;
			// 
			// progressBar1
			// 
			this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.progressBar1.Location = new System.Drawing.Point(3, 46);
			this.progressBar1.Maximum = 1000;
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(670, 10);
			this.progressBar1.TabIndex = 0;
			// 
			// tabPageQuestJournal
			// 
			this.tabPageQuestJournal.BackColor = System.Drawing.Color.White;
			this.tabPageQuestJournal.ImageIndex = 0;
			this.tabPageQuestJournal.Location = new System.Drawing.Point(4, 84);
			this.tabPageQuestJournal.Name = "tabPageQuestJournal";
			this.tabPageQuestJournal.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageQuestJournal.Size = new System.Drawing.Size(818, 448);
			this.tabPageQuestJournal.TabIndex = 1;
			// 
			// imageListTabs
			// 
			this.imageListTabs.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTabs.ImageStream")));
			this.imageListTabs.TransparentColor = System.Drawing.Color.Transparent;
			this.imageListTabs.Images.SetKeyName(0, "Journal.ico");
			this.imageListTabs.Images.SetKeyName(1, "Main.ico");
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(850, 560);
			this.Controls.Add(this.tabControlMainPages);
			this.Name = "MainWindow";
			this.Text = "Life Quest";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
			this.tabControlMainPages.ResumeLayout(false);
			this.tabPageMain.ResumeLayout(false);
			this.panelMainClaimReward.ResumeLayout(false);
			this.panelMainClaimReward.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControlMainPages;
		private System.Windows.Forms.TabPage tabPageMain;
		private System.Windows.Forms.TabPage tabPageQuestJournal;
		private System.Windows.Forms.Button btnClaimReward;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Label labelMainProgress;
		private System.Windows.Forms.Panel panelMainClaimReward;
		private System.Windows.Forms.ImageList imageListTabs;
		private System.Windows.Forms.CheckedListBox checkedListBoxMainHabbits;
		private System.Windows.Forms.Button buttonMainAddHabbit;
	}
}

