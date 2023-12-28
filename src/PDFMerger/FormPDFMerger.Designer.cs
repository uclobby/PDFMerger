namespace PDFMerger
{
    partial class FormPDFMerger
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
            this.buttonMerge = new System.Windows.Forms.Button();
            this.buttonAddFile = new System.Windows.Forms.Button();
            this.buttonAddFolder = new System.Windows.Forms.Button();
            this.buttonMoveUp = new System.Windows.Forms.Button();
            this.buttonMoveDown = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonRemoveAll = new System.Windows.Forms.Button();
            this.dataGridViewFileTable = new System.Windows.Forms.DataGridView();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.rbAlternateMode = new System.Windows.Forms.RadioButton();
            this.rbSplitMode = new System.Windows.Forms.RadioButton();
            this.groupBoxMode = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFileTable)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.groupBoxMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonMerge
            // 
            this.buttonMerge.Location = new System.Drawing.Point(652, 567);
            this.buttonMerge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonMerge.Name = "buttonMerge";
            this.buttonMerge.Size = new System.Drawing.Size(182, 46);
            this.buttonMerge.TabIndex = 0;
            this.buttonMerge.Text = "Merge";
            this.buttonMerge.UseVisualStyleBackColor = true;
            this.buttonMerge.Click += new System.EventHandler(this.ButtonMerge_Click);
            // 
            // buttonAddFile
            // 
            this.buttonAddFile.Location = new System.Drawing.Point(652, 12);
            this.buttonAddFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddFile.Name = "buttonAddFile";
            this.buttonAddFile.Size = new System.Drawing.Size(182, 46);
            this.buttonAddFile.TabIndex = 1;
            this.buttonAddFile.Text = "Add File";
            this.buttonAddFile.UseVisualStyleBackColor = true;
            this.buttonAddFile.Click += new System.EventHandler(this.ButtonAddFile_Click);
            // 
            // buttonAddFolder
            // 
            this.buttonAddFolder.Location = new System.Drawing.Point(652, 66);
            this.buttonAddFolder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddFolder.Name = "buttonAddFolder";
            this.buttonAddFolder.Size = new System.Drawing.Size(182, 46);
            this.buttonAddFolder.TabIndex = 2;
            this.buttonAddFolder.Text = "Add Folder";
            this.buttonAddFolder.UseVisualStyleBackColor = true;
            // 
            // buttonMoveUp
            // 
            this.buttonMoveUp.Location = new System.Drawing.Point(652, 129);
            this.buttonMoveUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonMoveUp.Name = "buttonMoveUp";
            this.buttonMoveUp.Size = new System.Drawing.Size(182, 46);
            this.buttonMoveUp.TabIndex = 3;
            this.buttonMoveUp.Text = "Move Up";
            this.buttonMoveUp.UseVisualStyleBackColor = true;
            this.buttonMoveUp.Click += new System.EventHandler(this.ButtonMoveUp_Click);
            // 
            // buttonMoveDown
            // 
            this.buttonMoveDown.Location = new System.Drawing.Point(652, 183);
            this.buttonMoveDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonMoveDown.Name = "buttonMoveDown";
            this.buttonMoveDown.Size = new System.Drawing.Size(182, 46);
            this.buttonMoveDown.TabIndex = 4;
            this.buttonMoveDown.Text = "Move Down";
            this.buttonMoveDown.UseVisualStyleBackColor = true;
            this.buttonMoveDown.Click += new System.EventHandler(this.ButtonMoveDown_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(652, 246);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(182, 46);
            this.buttonRemove.TabIndex = 5;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.ButtonRemove_Click);
            // 
            // buttonRemoveAll
            // 
            this.buttonRemoveAll.Location = new System.Drawing.Point(652, 300);
            this.buttonRemoveAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRemoveAll.Name = "buttonRemoveAll";
            this.buttonRemoveAll.Size = new System.Drawing.Size(182, 46);
            this.buttonRemoveAll.TabIndex = 6;
            this.buttonRemoveAll.Text = "Remove All";
            this.buttonRemoveAll.UseVisualStyleBackColor = true;
            this.buttonRemoveAll.Click += new System.EventHandler(this.ButtonRemoveAll_Click);
            // 
            // dataGridViewFileTable
            // 
            this.dataGridViewFileTable.AllowDrop = true;
            this.dataGridViewFileTable.AllowUserToAddRows = false;
            this.dataGridViewFileTable.AllowUserToDeleteRows = false;
            this.dataGridViewFileTable.AllowUserToResizeColumns = false;
            this.dataGridViewFileTable.AllowUserToResizeRows = false;
            this.dataGridViewFileTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFileTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFileTable.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewFileTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewFileTable.MultiSelect = false;
            this.dataGridViewFileTable.Name = "dataGridViewFileTable";
            this.dataGridViewFileTable.ReadOnly = true;
            this.dataGridViewFileTable.RowHeadersVisible = false;
            this.dataGridViewFileTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewFileTable.RowTemplate.Height = 33;
            this.dataGridViewFileTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFileTable.Size = new System.Drawing.Size(634, 601);
            this.dataGridViewFileTable.TabIndex = 7;
            this.dataGridViewFileTable.DragDrop += new System.Windows.Forms.DragEventHandler(this.DataGridViewFileTable_DragDrop);
            this.dataGridViewFileTable.DragEnter += new System.Windows.Forms.DragEventHandler(this.DataGridViewFileTable_DragEnter);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip.Location = new System.Drawing.Point(0, 627);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(0, 0, 14, 0);
            this.statusStrip.Size = new System.Drawing.Size(846, 42);
            this.statusStrip.TabIndex = 9;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(79, 32);
            this.toolStripStatusLabel1.Text = "Ready";
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Checked = true;
            this.rbNormal.Location = new System.Drawing.Point(18, 43);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(111, 29);
            this.rbNormal.TabIndex = 10;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "Normal";
            this.rbNormal.UseVisualStyleBackColor = true;
            // 
            // rbAlternateMode
            // 
            this.rbAlternateMode.AutoSize = true;
            this.rbAlternateMode.Location = new System.Drawing.Point(18, 78);
            this.rbAlternateMode.Name = "rbAlternateMode";
            this.rbAlternateMode.Size = new System.Drawing.Size(129, 29);
            this.rbAlternateMode.TabIndex = 11;
            this.rbAlternateMode.Text = "Alternate";
            this.rbAlternateMode.UseVisualStyleBackColor = true;
            // 
            // rbSplitMode
            // 
            this.rbSplitMode.AutoSize = true;
            this.rbSplitMode.Location = new System.Drawing.Point(18, 113);
            this.rbSplitMode.Name = "rbSplitMode";
            this.rbSplitMode.Size = new System.Drawing.Size(85, 29);
            this.rbSplitMode.TabIndex = 12;
            this.rbSplitMode.Text = "Split";
            this.rbSplitMode.UseVisualStyleBackColor = true;
            // 
            // groupBoxMode
            // 
            this.groupBoxMode.Controls.Add(this.rbNormal);
            this.groupBoxMode.Controls.Add(this.rbSplitMode);
            this.groupBoxMode.Controls.Add(this.rbAlternateMode);
            this.groupBoxMode.Location = new System.Drawing.Point(652, 396);
            this.groupBoxMode.Name = "groupBoxMode";
            this.groupBoxMode.Size = new System.Drawing.Size(182, 164);
            this.groupBoxMode.TabIndex = 13;
            this.groupBoxMode.TabStop = false;
            this.groupBoxMode.Text = "Mode";
            // 
            // FormPDFMerger
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 669);
            this.Controls.Add(this.groupBoxMode);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.dataGridViewFileTable);
            this.Controls.Add(this.buttonRemoveAll);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonMoveDown);
            this.Controls.Add(this.buttonMoveUp);
            this.Controls.Add(this.buttonAddFolder);
            this.Controls.Add(this.buttonAddFile);
            this.Controls.Add(this.buttonMerge);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormPDFMerger";
            this.Text = "PDF Merger";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFileTable)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.groupBoxMode.ResumeLayout(false);
            this.groupBoxMode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMerge;
        private System.Windows.Forms.Button buttonAddFile;
        private System.Windows.Forms.Button buttonAddFolder;
        private System.Windows.Forms.Button buttonMoveUp;
        private System.Windows.Forms.Button buttonMoveDown;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonRemoveAll;
        private System.Windows.Forms.DataGridView dataGridViewFileTable;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.RadioButton rbAlternateMode;
        private System.Windows.Forms.RadioButton rbSplitMode;
        private System.Windows.Forms.GroupBox groupBoxMode;
    }
}

