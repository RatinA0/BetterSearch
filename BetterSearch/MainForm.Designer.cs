namespace BetterSearch
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.listSearchResult = new System.Windows.Forms.ListBox();
            this.listItemPresets = new System.Windows.Forms.ListBox();
            this.grpPresets = new System.Windows.Forms.GroupBox();
            this.grpSearchResults = new System.Windows.Forms.GroupBox();
            this.cbxDarkTheme = new System.Windows.Forms.CheckBox();
            this.cmsFavorites = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsiAddToFavs = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsiRemoveFromFavs = new System.Windows.Forms.ToolStripMenuItem();
            this.grpPresets.SuspendLayout();
            this.grpSearchResults.SuspendLayout();
            this.cmsFavorites.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(13, 10);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(7, 10, 3, 10);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(189, 20);
            this.txtSearch.TabIndex = 14;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // listSearchResult
            // 
            this.listSearchResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listSearchResult.FormattingEnabled = true;
            this.listSearchResult.Location = new System.Drawing.Point(0, 23);
            this.listSearchResult.Margin = new System.Windows.Forms.Padding(10, 7, 10, 3);
            this.listSearchResult.Name = "listSearchResult";
            this.listSearchResult.Size = new System.Drawing.Size(244, 134);
            this.listSearchResult.TabIndex = 13;
            this.listSearchResult.SelectedIndexChanged += new System.EventHandler(this.listSearchResult_SelectedIndexChanged);
            this.listSearchResult.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listSearchResult_KeyUp);
            this.listSearchResult.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listSearchResult_MouseDoubleClick);
            // 
            // listItemPresets
            // 
            this.listItemPresets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listItemPresets.FormattingEnabled = true;
            this.listItemPresets.Location = new System.Drawing.Point(0, 23);
            this.listItemPresets.Margin = new System.Windows.Forms.Padding(10, 7, 10, 0);
            this.listItemPresets.Name = "listItemPresets";
            this.listItemPresets.Size = new System.Drawing.Size(244, 134);
            this.listItemPresets.TabIndex = 13;
            this.listItemPresets.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listSearchResult_KeyUp);
            this.listItemPresets.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listSearchResult_MouseDoubleClick);
            // 
            // grpPresets
            // 
            this.grpPresets.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPresets.Controls.Add(this.listItemPresets);
            this.grpPresets.Location = new System.Drawing.Point(13, 207);
            this.grpPresets.Margin = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.grpPresets.Name = "grpPresets";
            this.grpPresets.Size = new System.Drawing.Size(244, 159);
            this.grpPresets.TabIndex = 16;
            this.grpPresets.TabStop = false;
            this.grpPresets.Text = "Presets";
            // 
            // grpSearchResults
            // 
            this.grpSearchResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSearchResults.Controls.Add(this.listSearchResult);
            this.grpSearchResults.Location = new System.Drawing.Point(13, 40);
            this.grpSearchResults.Margin = new System.Windows.Forms.Padding(0, 7, 0, 3);
            this.grpSearchResults.Name = "grpSearchResults";
            this.grpSearchResults.Size = new System.Drawing.Size(244, 159);
            this.grpSearchResults.TabIndex = 17;
            this.grpSearchResults.TabStop = false;
            this.grpSearchResults.Text = "Search results";
            // 
            // cbxDarkTheme
            // 
            this.cbxDarkTheme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxDarkTheme.AutoSize = true;
            this.cbxDarkTheme.Checked = true;
            this.cbxDarkTheme.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxDarkTheme.Location = new System.Drawing.Point(208, 12);
            this.cbxDarkTheme.Name = "cbxDarkTheme";
            this.cbxDarkTheme.Size = new System.Drawing.Size(49, 17);
            this.cbxDarkTheme.TabIndex = 18;
            this.cbxDarkTheme.Text = "Dark";
            this.cbxDarkTheme.UseVisualStyleBackColor = true;
            this.cbxDarkTheme.CheckedChanged += new System.EventHandler(this.cbxDarkTheme_CheckedChanged);
            // 
            // cmsFavorites
            // 
            this.cmsFavorites.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsiAddToFavs,
            this.cmsiRemoveFromFavs});
            this.cmsFavorites.Name = "cmsFavorites";
            this.cmsFavorites.Size = new System.Drawing.Size(181, 70);
            this.cmsFavorites.MouseLeave += new System.EventHandler(this.cmsFavorites_MouseLeave);
            // 
            // cmsiAddToFavs
            // 
            this.cmsiAddToFavs.Name = "cmsiAddToFavs";
            this.cmsiAddToFavs.Size = new System.Drawing.Size(180, 22);
            this.cmsiAddToFavs.Text = "Add to Favs";
            this.cmsiAddToFavs.Click += new System.EventHandler(this.cmsiAddToFavs_Click);
            // 
            // cmsiRemoveFromFavs
            // 
            this.cmsiRemoveFromFavs.Name = "cmsiRemoveFromFavs";
            this.cmsiRemoveFromFavs.Size = new System.Drawing.Size(180, 22);
            this.cmsiRemoveFromFavs.Text = "Remove from Favs";
            this.cmsiRemoveFromFavs.Click += new System.EventHandler(this.cmsiRemoveFromFavs_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.Controls.Add(this.cbxDarkTheme);
            this.Controls.Add(this.grpSearchResults);
            this.Controls.Add(this.grpPresets);
            this.Controls.Add(this.txtSearch);
            this.Name = "MainForm";
            this.Size = new System.Drawing.Size(270, 379);
            this.grpPresets.ResumeLayout(false);
            this.grpSearchResults.ResumeLayout(false);
            this.cmsFavorites.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListBox listSearchResult;
        private System.Windows.Forms.ListBox listItemPresets;
        private System.Windows.Forms.GroupBox grpPresets;
        private System.Windows.Forms.GroupBox grpSearchResults;
        private System.Windows.Forms.CheckBox cbxDarkTheme;
        private System.Windows.Forms.ContextMenuStrip cmsFavorites;
        private System.Windows.Forms.ToolStripMenuItem cmsiAddToFavs;
        private System.Windows.Forms.ToolStripMenuItem cmsiRemoveFromFavs;
    }
}
