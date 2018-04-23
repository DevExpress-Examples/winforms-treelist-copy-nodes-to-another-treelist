namespace CopyNodesExample {
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
            this.container = new DevExpress.XtraEditors.SplitContainerControl();
            this.sourceTreeList = new DevExpress.XtraTreeList.TreeList();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnCopy = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteNode = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddChild = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddRoot = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddColumn = new DevExpress.XtraEditors.SimpleButton();
            this.txtColumnName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.container)).BeginInit();
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sourceTreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtColumnName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Name = "container";
            this.container.Panel1.Controls.Add(this.sourceTreeList);
            this.container.Panel1.Text = "Panel1";
            this.container.Panel2.Text = "Panel2";
            this.container.Size = new System.Drawing.Size(1259, 582);
            this.container.SplitterPosition = 644;
            this.container.TabIndex = 0;
            this.container.Text = "splitContainerControl1";
            // 
            // sourceTreeList
            // 
            this.sourceTreeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceTreeList.Location = new System.Drawing.Point(0, 0);
            this.sourceTreeList.Name = "sourceTreeList";
            this.sourceTreeList.Size = new System.Drawing.Size(644, 582);
            this.sourceTreeList.TabIndex = 0;
            this.sourceTreeList.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.OnSourceTreeListFocusedNodeChanged);
            this.sourceTreeList.NodeChanged += new DevExpress.XtraTreeList.NodeChangedEventHandler(this.OnSourceTreeListNodeChanged);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnCopy);
            this.panelControl1.Controls.Add(this.btnDeleteNode);
            this.panelControl1.Controls.Add(this.btnAddChild);
            this.panelControl1.Controls.Add(this.btnAddRoot);
            this.panelControl1.Controls.Add(this.btnAddColumn);
            this.panelControl1.Controls.Add(this.txtColumnName);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 582);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1259, 33);
            this.panelControl1.TabIndex = 1;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(519, 5);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 6;
            this.btnCopy.Text = "Copy";
            this.btnCopy.Click += new System.EventHandler(this.OnCopyButtonClick);
            // 
            // btnDeleteNode
            // 
            this.btnDeleteNode.Location = new System.Drawing.Point(438, 5);
            this.btnDeleteNode.Name = "btnDeleteNode";
            this.btnDeleteNode.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteNode.TabIndex = 5;
            this.btnDeleteNode.Text = "Delete Node";
            this.btnDeleteNode.Click += new System.EventHandler(this.OnDeleteNodeButtonClick);
            // 
            // btnAddChild
            // 
            this.btnAddChild.Location = new System.Drawing.Point(357, 5);
            this.btnAddChild.Name = "btnAddChild";
            this.btnAddChild.Size = new System.Drawing.Size(75, 23);
            this.btnAddChild.TabIndex = 4;
            this.btnAddChild.Text = "Add Child";
            this.btnAddChild.Click += new System.EventHandler(this.OnAddChildButtonClick);
            // 
            // btnAddRoot
            // 
            this.btnAddRoot.Location = new System.Drawing.Point(276, 5);
            this.btnAddRoot.Name = "btnAddRoot";
            this.btnAddRoot.Size = new System.Drawing.Size(75, 23);
            this.btnAddRoot.TabIndex = 3;
            this.btnAddRoot.Text = "Add Root";
            this.btnAddRoot.Click += new System.EventHandler(this.OnAddRootButtonClick);
            // 
            // btnAddColumn
            // 
            this.btnAddColumn.Location = new System.Drawing.Point(195, 5);
            this.btnAddColumn.Name = "btnAddColumn";
            this.btnAddColumn.Size = new System.Drawing.Size(75, 23);
            this.btnAddColumn.TabIndex = 2;
            this.btnAddColumn.Text = "Add Column";
            this.btnAddColumn.Click += new System.EventHandler(this.OnAddColumnButtonClick);
            // 
            // txtColumnName
            // 
            this.txtColumnName.Location = new System.Drawing.Point(89, 6);
            this.txtColumnName.Name = "txtColumnName";
            this.txtColumnName.Size = new System.Drawing.Size(100, 20);
            this.txtColumnName.TabIndex = 1;
            this.txtColumnName.TextChanged += new System.EventHandler(this.OnEditorColumnNameTextChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 7);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(69, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Column Name:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 615);
            this.Controls.Add(this.container);
            this.Controls.Add(this.panelControl1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.OnFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.container)).EndInit();
            this.container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sourceTreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtColumnName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl container;
        private DevExpress.XtraTreeList.TreeList sourceTreeList;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCopy;
        private DevExpress.XtraEditors.SimpleButton btnDeleteNode;
        private DevExpress.XtraEditors.SimpleButton btnAddChild;
        private DevExpress.XtraEditors.SimpleButton btnAddRoot;
        private DevExpress.XtraEditors.SimpleButton btnAddColumn;
        private DevExpress.XtraEditors.TextEdit txtColumnName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}

