namespace GeoFormMapper
{
    partial class frmGeoMap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGeoMap));
            this.ctlSplit = new System.Windows.Forms.SplitContainer();
            this.ctlMapZoom = new SharpMap.Forms.ToolBar.MapZoomToolStrip(this.components);
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ctlMapBox = new SharpMap.Forms.MapBox();
            this.ctlOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ctlSplit)).BeginInit();
            this.ctlSplit.Panel1.SuspendLayout();
            this.ctlSplit.Panel2.SuspendLayout();
            this.ctlSplit.SuspendLayout();
            this.ctlMapZoom.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctlSplit
            // 
            this.ctlSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.ctlSplit.IsSplitterFixed = true;
            this.ctlSplit.Location = new System.Drawing.Point(0, 0);
            this.ctlSplit.Name = "ctlSplit";
            this.ctlSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // ctlSplit.Panel1
            // 
            this.ctlSplit.Panel1.Controls.Add(this.ctlMapZoom);
            // 
            // ctlSplit.Panel2
            // 
            this.ctlSplit.Panel2.Controls.Add(this.ctlMapBox);
            this.ctlSplit.Size = new System.Drawing.Size(800, 450);
            this.ctlSplit.SplitterDistance = 30;
            this.ctlSplit.TabIndex = 2;
            // 
            // ctlMapZoom
            // 
            this.ctlMapZoom.AutoSize = false;
            this.ctlMapZoom.Enabled = false;
            this.ctlMapZoom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.printToolStripButton,
            this.toolStripSeparator,
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.toolStripSeparator1,
            this.helpToolStripButton});
            this.ctlMapZoom.Location = new System.Drawing.Point(0, 0);
            this.ctlMapZoom.MapControl = null;
            this.ctlMapZoom.Name = "ctlMapZoom";
            this.ctlMapZoom.Size = new System.Drawing.Size(800, 25);
            this.ctlMapZoom.TabIndex = 2;
            this.ctlMapZoom.Text = "mapZoomToolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "&New";
            this.newToolStripButton.ToolTipText = "Clear Maps";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            this.openToolStripButton.ToolTipText = "Open Shape\\Shape Zip File";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.printToolStripButton.Text = "&Print";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.cutToolStripButton.Text = "C&ut";
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.copyToolStripButton.Text = "&Copy";
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.pasteToolStripButton.Text = "&Paste";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // ctlMapBox
            // 
            this.ctlMapBox.ActiveTool = SharpMap.Forms.MapBox.Tools.None;
            this.ctlMapBox.BackColor = System.Drawing.SystemColors.Control;
            this.ctlMapBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.ctlMapBox.CustomTool = null;
            this.ctlMapBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlMapBox.FineZoomFactor = 10D;
            this.ctlMapBox.Location = new System.Drawing.Point(0, 0);
            this.ctlMapBox.MapQueryMode = SharpMap.Forms.MapBox.MapQueryType.LayerByIndex;
            this.ctlMapBox.Name = "ctlMapBox";
            this.ctlMapBox.QueryGrowFactor = 5F;
            this.ctlMapBox.QueryLayerIndex = 0;
            this.ctlMapBox.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ctlMapBox.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ctlMapBox.ShowProgressUpdate = false;
            this.ctlMapBox.Size = new System.Drawing.Size(800, 416);
            this.ctlMapBox.TabIndex = 1;
            this.ctlMapBox.WheelZoomMagnitude = -2D;
            // 
            // ctlOpenFileDialog
            // 
            this.ctlOpenFileDialog.DefaultExt = "shp";
            this.ctlOpenFileDialog.Filter = "Shape File|*.shp|Shape Zip File|*.zip";
            // 
            // frmGeoMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ctlSplit);
            this.Name = "frmGeoMap";
            this.Text = "Geo Map";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGeoMap_FormClosing);
            this.Load += new System.EventHandler(this.frmGeoMap_Load);
            this.ctlSplit.Panel1.ResumeLayout(false);
            this.ctlSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctlSplit)).EndInit();
            this.ctlSplit.ResumeLayout(false);
            this.ctlMapZoom.ResumeLayout(false);
            this.ctlMapZoom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer ctlSplit;
        private SharpMap.Forms.ToolBar.MapZoomToolStrip ctlMapZoom;
        private SharpMap.Forms.MapBox ctlMapBox;
        private System.Windows.Forms.OpenFileDialog ctlOpenFileDialog;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
    }
}

