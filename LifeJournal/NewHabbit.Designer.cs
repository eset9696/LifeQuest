namespace LifeQuest
{
	partial class NewHabbit
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
			this.buttonNewHabbitOk = new System.Windows.Forms.Button();
			this.buttonNewHabbitCancel = new System.Windows.Forms.Button();
			this.textBoxNewHabbit = new System.Windows.Forms.TextBox();
			this.labelNewHabbit = new System.Windows.Forms.Label();
			this.comboBoxNewHabbitType = new System.Windows.Forms.ComboBox();
			this.comboBoxNewHabbitCategory = new System.Windows.Forms.ComboBox();
			this.labelRewardValue = new System.Windows.Forms.Label();
			this.labelRewardPreview = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// buttonNewHabbitOk
			// 
			this.buttonNewHabbitOk.Location = new System.Drawing.Point(484, 214);
			this.buttonNewHabbitOk.Name = "buttonNewHabbitOk";
			this.buttonNewHabbitOk.Size = new System.Drawing.Size(75, 23);
			this.buttonNewHabbitOk.TabIndex = 0;
			this.buttonNewHabbitOk.Text = "Ok";
			this.buttonNewHabbitOk.UseVisualStyleBackColor = true;
			this.buttonNewHabbitOk.Click += new System.EventHandler(this.buttonNewHabbitOk_Click);
			// 
			// buttonNewHabbitCancel
			// 
			this.buttonNewHabbitCancel.Location = new System.Drawing.Point(565, 214);
			this.buttonNewHabbitCancel.Name = "buttonNewHabbitCancel";
			this.buttonNewHabbitCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonNewHabbitCancel.TabIndex = 1;
			this.buttonNewHabbitCancel.Text = "Cancel";
			this.buttonNewHabbitCancel.UseVisualStyleBackColor = true;
			// 
			// textBoxNewHabbit
			// 
			this.textBoxNewHabbit.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxNewHabbit.Location = new System.Drawing.Point(12, 62);
			this.textBoxNewHabbit.Name = "textBoxNewHabbit";
			this.textBoxNewHabbit.Size = new System.Drawing.Size(374, 33);
			this.textBoxNewHabbit.TabIndex = 2;
			// 
			// labelNewHabbit
			// 
			this.labelNewHabbit.AutoSize = true;
			this.labelNewHabbit.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelNewHabbit.Location = new System.Drawing.Point(12, 24);
			this.labelNewHabbit.Name = "labelNewHabbit";
			this.labelNewHabbit.Size = new System.Drawing.Size(99, 25);
			this.labelNewHabbit.TabIndex = 3;
			this.labelNewHabbit.Text = "Habbit:";
			// 
			// comboBoxNewHabbitType
			// 
			this.comboBoxNewHabbitType.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBoxNewHabbitType.FormattingEnabled = true;
			this.comboBoxNewHabbitType.Location = new System.Drawing.Point(392, 62);
			this.comboBoxNewHabbitType.Name = "comboBoxNewHabbitType";
			this.comboBoxNewHabbitType.Size = new System.Drawing.Size(244, 33);
			this.comboBoxNewHabbitType.TabIndex = 4;
			this.comboBoxNewHabbitType.SelectedIndexChanged += new System.EventHandler(this.comboBoxNewHabbitType_SelectedIndexChanged);
			// 
			// comboBoxNewHabbitCategory
			// 
			this.comboBoxNewHabbitCategory.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBoxNewHabbitCategory.FormattingEnabled = true;
			this.comboBoxNewHabbitCategory.Location = new System.Drawing.Point(392, 112);
			this.comboBoxNewHabbitCategory.Name = "comboBoxNewHabbitCategory";
			this.comboBoxNewHabbitCategory.Size = new System.Drawing.Size(244, 33);
			this.comboBoxNewHabbitCategory.TabIndex = 4;
			this.comboBoxNewHabbitCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxNewHabbitCategory_SelectedIndexChanged);
			// 
			// labelRewardValue
			// 
			this.labelRewardValue.AutoSize = true;
			this.labelRewardValue.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelRewardValue.Location = new System.Drawing.Point(135, 120);
			this.labelRewardValue.Name = "labelRewardValue";
			this.labelRewardValue.Size = new System.Drawing.Size(0, 25);
			this.labelRewardValue.TabIndex = 5;
			// 
			// labelRewardPreview
			// 
			this.labelRewardPreview.AutoSize = true;
			this.labelRewardPreview.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelRewardPreview.Location = new System.Drawing.Point(7, 120);
			this.labelRewardPreview.Name = "labelRewardPreview";
			this.labelRewardPreview.Size = new System.Drawing.Size(117, 25);
			this.labelRewardPreview.TabIndex = 5;
			this.labelRewardPreview.Text = "Reward: ";
			// 
			// NewHabbit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(650, 249);
			this.Controls.Add(this.labelRewardPreview);
			this.Controls.Add(this.labelRewardValue);
			this.Controls.Add(this.comboBoxNewHabbitCategory);
			this.Controls.Add(this.comboBoxNewHabbitType);
			this.Controls.Add(this.labelNewHabbit);
			this.Controls.Add(this.textBoxNewHabbit);
			this.Controls.Add(this.buttonNewHabbitCancel);
			this.Controls.Add(this.buttonNewHabbitOk);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "NewHabbit";
			this.Text = "NewHabbit";
			this.Load += new System.EventHandler(this.NewHabbit_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonNewHabbitOk;
		private System.Windows.Forms.Button buttonNewHabbitCancel;
		private System.Windows.Forms.TextBox textBoxNewHabbit;
		private System.Windows.Forms.Label labelNewHabbit;
		private System.Windows.Forms.ComboBox comboBoxNewHabbitType;
		private System.Windows.Forms.ComboBox comboBoxNewHabbitCategory;
		private System.Windows.Forms.Label labelRewardValue;
		private System.Windows.Forms.Label labelRewardPreview;
	}
}