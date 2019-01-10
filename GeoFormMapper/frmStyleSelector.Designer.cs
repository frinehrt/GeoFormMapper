namespace GeoFormMapper
{
    partial class frmStyleSelector
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
            this.ctlBindingSourceDBF = new System.Windows.Forms.BindingSource(this.components);
            this.ctlBindingSourceStyle = new System.Windows.Forms.BindingSource(this.components);
            this.ctlSplit = new System.Windows.Forms.SplitContainer();
            this.ctlDataGridViewStyle = new Zuby.ADGV.AdvancedDataGridView();
            this.ctlDataGridViewDBF = new Zuby.ADGV.AdvancedDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ctlBindingSourceDBF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctlBindingSourceStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctlSplit)).BeginInit();
            this.ctlSplit.Panel1.SuspendLayout();
            this.ctlSplit.Panel2.SuspendLayout();
            this.ctlSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctlDataGridViewStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctlDataGridViewDBF)).BeginInit();
            this.SuspendLayout();
            // 
            // ctlBindingSourceDBF
            // 
            this.ctlBindingSourceDBF.AllowNew = false;
            // 
            // ctlBindingSourceStyle
            // 
            this.ctlBindingSourceStyle.AllowNew = false;
            // 
            // ctlSplit
            // 
            this.ctlSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlSplit.Location = new System.Drawing.Point(0, 0);
            this.ctlSplit.Name = "ctlSplit";
            // 
            // ctlSplit.Panel1
            // 
            this.ctlSplit.Panel1.Controls.Add(this.ctlDataGridViewStyle);
            this.ctlSplit.Panel1MinSize = 100;
            // 
            // ctlSplit.Panel2
            // 
            this.ctlSplit.Panel2.Controls.Add(this.ctlDataGridViewDBF);
            this.ctlSplit.Panel2MinSize = 100;
            this.ctlSplit.Size = new System.Drawing.Size(800, 450);
            this.ctlSplit.SplitterDistance = 500;
            this.ctlSplit.TabIndex = 4;
            // 
            // ctlDataGridViewStyle
            // 
            this.ctlDataGridViewStyle.AllowUserToAddRows = false;
            this.ctlDataGridViewStyle.AllowUserToDeleteRows = false;
            this.ctlDataGridViewStyle.AutoGenerateColumns = false;
            this.ctlDataGridViewStyle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.ctlDataGridViewStyle.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ctlDataGridViewStyle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctlDataGridViewStyle.DataSource = this.ctlBindingSourceDBF;
            this.ctlDataGridViewStyle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlDataGridViewStyle.FilterAndSortEnabled = true;
            this.ctlDataGridViewStyle.Location = new System.Drawing.Point(0, 0);
            this.ctlDataGridViewStyle.Name = "ctlDataGridViewStyle";
            this.ctlDataGridViewStyle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullColumnSelect;
            this.ctlDataGridViewStyle.Size = new System.Drawing.Size(500, 450);
            this.ctlDataGridViewStyle.TabIndex = 4;
            this.ctlDataGridViewStyle.UseWaitCursor = true;
            // 
            // ctlDataGridViewDBF
            // 
            this.ctlDataGridViewDBF.AllowUserToAddRows = false;
            this.ctlDataGridViewDBF.AllowUserToDeleteRows = false;
            this.ctlDataGridViewDBF.AutoGenerateColumns = false;
            this.ctlDataGridViewDBF.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.ctlDataGridViewDBF.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ctlDataGridViewDBF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctlDataGridViewDBF.DataSource = this.ctlBindingSourceDBF;
            this.ctlDataGridViewDBF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlDataGridViewDBF.FilterAndSortEnabled = true;
            this.ctlDataGridViewDBF.Location = new System.Drawing.Point(0, 0);
            this.ctlDataGridViewDBF.Name = "ctlDataGridViewDBF";
            this.ctlDataGridViewDBF.ReadOnly = true;
            this.ctlDataGridViewDBF.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullColumnSelect;
            this.ctlDataGridViewDBF.Size = new System.Drawing.Size(296, 450);
            this.ctlDataGridViewDBF.TabIndex = 3;
            this.ctlDataGridViewDBF.UseWaitCursor = true;
            // 
            // frmStyleSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ctlSplit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStyleSelector";
            this.ShowIcon = false;
            this.Text = "Style Selector";
            this.Load += new System.EventHandler(this.frmStyleSelector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctlBindingSourceDBF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctlBindingSourceStyle)).EndInit();
            this.ctlSplit.Panel1.ResumeLayout(false);
            this.ctlSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctlSplit)).EndInit();
            this.ctlSplit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctlDataGridViewStyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctlDataGridViewDBF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource ctlBindingSourceDBF;
        private System.Windows.Forms.BindingSource ctlBindingSourceStyle;
        private System.Windows.Forms.SplitContainer ctlSplit;
        private Zuby.ADGV.AdvancedDataGridView ctlDataGridViewStyle;
        private Zuby.ADGV.AdvancedDataGridView ctlDataGridViewDBF;
    }
}