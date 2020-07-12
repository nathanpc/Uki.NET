namespace Uki.NET {
	partial class MainForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.lblStatusStrip = new System.Windows.Forms.ToolStripStatusLabel();
			this.mnuMain = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			this.treeView = new System.Windows.Forms.TreeView();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPageEditor = new System.Windows.Forms.TabPage();
			this.tabPagePreview = new System.Windows.Forms.TabPage();
			this.richTextEditor = new System.Windows.Forms.RichTextBox();
			this.webBrowserPreview = new System.Windows.Forms.WebBrowser();
			this.statusStrip.SuspendLayout();
			this.mnuMain.SuspendLayout();
			this.splitContainer.Panel1.SuspendLayout();
			this.splitContainer.Panel2.SuspendLayout();
			this.splitContainer.SuspendLayout();
			this.tabControl.SuspendLayout();
			this.tabPageEditor.SuspendLayout();
			this.tabPagePreview.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip
			// 
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusStrip});
			this.statusStrip.Location = new System.Drawing.Point(0, 371);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(605, 22);
			this.statusStrip.TabIndex = 0;
			// 
			// lblStatusStrip
			// 
			this.lblStatusStrip.Name = "lblStatusStrip";
			this.lblStatusStrip.Size = new System.Drawing.Size(103, 17);
			this.lblStatusStrip.Text = "Welcome to Uki.NET";
			// 
			// mnuMain
			// 
			this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.mnuMain.Location = new System.Drawing.Point(0, 0);
			this.mnuMain.Name = "mnuMain";
			this.mnuMain.Size = new System.Drawing.Size(605, 24);
			this.mnuMain.TabIndex = 1;
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// toolStrip
			// 
			this.toolStrip.Location = new System.Drawing.Point(0, 24);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new System.Drawing.Size(605, 25);
			this.toolStrip.TabIndex = 2;
			// 
			// splitContainer
			// 
			this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer.Location = new System.Drawing.Point(0, 49);
			this.splitContainer.Name = "splitContainer";
			// 
			// splitContainer.Panel1
			// 
			this.splitContainer.Panel1.Controls.Add(this.treeView);
			// 
			// splitContainer.Panel2
			// 
			this.splitContainer.Panel2.Controls.Add(this.tabControl);
			this.splitContainer.Size = new System.Drawing.Size(605, 322);
			this.splitContainer.SplitterDistance = 201;
			this.splitContainer.TabIndex = 3;
			// 
			// treeView
			// 
			this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeView.Location = new System.Drawing.Point(0, 0);
			this.treeView.Name = "treeView";
			this.treeView.Size = new System.Drawing.Size(201, 322);
			this.treeView.TabIndex = 0;
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabPageEditor);
			this.tabControl.Controls.Add(this.tabPagePreview);
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl.Location = new System.Drawing.Point(0, 0);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(400, 322);
			this.tabControl.TabIndex = 0;
			// 
			// tabPageEditor
			// 
			this.tabPageEditor.Controls.Add(this.richTextEditor);
			this.tabPageEditor.Location = new System.Drawing.Point(4, 22);
			this.tabPageEditor.Name = "tabPageEditor";
			this.tabPageEditor.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageEditor.Size = new System.Drawing.Size(392, 296);
			this.tabPageEditor.TabIndex = 0;
			this.tabPageEditor.Text = "Editor";
			this.tabPageEditor.UseVisualStyleBackColor = true;
			// 
			// tabPagePreview
			// 
			this.tabPagePreview.Controls.Add(this.webBrowserPreview);
			this.tabPagePreview.Location = new System.Drawing.Point(4, 22);
			this.tabPagePreview.Name = "tabPagePreview";
			this.tabPagePreview.Padding = new System.Windows.Forms.Padding(3);
			this.tabPagePreview.Size = new System.Drawing.Size(392, 296);
			this.tabPagePreview.TabIndex = 1;
			this.tabPagePreview.Text = "Preview";
			this.tabPagePreview.UseVisualStyleBackColor = true;
			// 
			// richTextEditor
			// 
			this.richTextEditor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextEditor.Location = new System.Drawing.Point(3, 3);
			this.richTextEditor.Name = "richTextEditor";
			this.richTextEditor.Size = new System.Drawing.Size(386, 290);
			this.richTextEditor.TabIndex = 0;
			this.richTextEditor.Text = "";
			// 
			// webBrowserPreview
			// 
			this.webBrowserPreview.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webBrowserPreview.Location = new System.Drawing.Point(3, 3);
			this.webBrowserPreview.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowserPreview.Name = "webBrowserPreview";
			this.webBrowserPreview.Size = new System.Drawing.Size(386, 290);
			this.webBrowserPreview.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(605, 393);
			this.Controls.Add(this.splitContainer);
			this.Controls.Add(this.toolStrip);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.mnuMain);
			this.MainMenuStrip = this.mnuMain;
			this.Name = "MainForm";
			this.Text = "Uki.NET";
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.mnuMain.ResumeLayout(false);
			this.mnuMain.PerformLayout();
			this.splitContainer.Panel1.ResumeLayout(false);
			this.splitContainer.Panel2.ResumeLayout(false);
			this.splitContainer.ResumeLayout(false);
			this.tabControl.ResumeLayout(false);
			this.tabPageEditor.ResumeLayout(false);
			this.tabPagePreview.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel lblStatusStrip;
		private System.Windows.Forms.MenuStrip mnuMain;
		private System.Windows.Forms.ToolStrip toolStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.SplitContainer splitContainer;
		private System.Windows.Forms.TreeView treeView;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPageEditor;
		private System.Windows.Forms.TabPage tabPagePreview;
		private System.Windows.Forms.RichTextBox richTextEditor;
		private System.Windows.Forms.WebBrowser webBrowserPreview;
	}
}

