Namespace CopyNodesExample

    Partial Class MainForm

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.container = New DevExpress.XtraEditors.SplitContainerControl()
            Me.sourceTreeList = New DevExpress.XtraTreeList.TreeList()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.btnCopy = New DevExpress.XtraEditors.SimpleButton()
            Me.btnDeleteNode = New DevExpress.XtraEditors.SimpleButton()
            Me.btnAddChild = New DevExpress.XtraEditors.SimpleButton()
            Me.btnAddRoot = New DevExpress.XtraEditors.SimpleButton()
            Me.btnAddColumn = New DevExpress.XtraEditors.SimpleButton()
            Me.txtColumnName = New DevExpress.XtraEditors.TextEdit()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            CType((Me.container), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.container.SuspendLayout()
            CType((Me.sourceTreeList), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType((Me.txtColumnName.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' container
            ' 
            Me.container.Dock = System.Windows.Forms.DockStyle.Fill
            Me.container.Location = New System.Drawing.Point(0, 0)
            Me.container.Name = "container"
            Me.container.Panel1.Controls.Add(Me.sourceTreeList)
            Me.container.Panel1.Text = "Panel1"
            Me.container.Panel2.Text = "Panel2"
            Me.container.Size = New System.Drawing.Size(1259, 582)
            Me.container.SplitterPosition = 644
            Me.container.TabIndex = 0
            Me.container.Text = "splitContainerControl1"
            ' 
            ' sourceTreeList
            ' 
            Me.sourceTreeList.Dock = System.Windows.Forms.DockStyle.Fill
            Me.sourceTreeList.Location = New System.Drawing.Point(0, 0)
            Me.sourceTreeList.Name = "sourceTreeList"
            Me.sourceTreeList.Size = New System.Drawing.Size(644, 582)
            Me.sourceTreeList.TabIndex = 0
            AddHandler Me.sourceTreeList.FocusedNodeChanged, New DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(AddressOf Me.OnSourceTreeListFocusedNodeChanged)
            AddHandler Me.sourceTreeList.NodeChanged, New DevExpress.XtraTreeList.NodeChangedEventHandler(AddressOf Me.OnSourceTreeListNodeChanged)
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Controls.Add(Me.btnCopy)
            Me.panelControl1.Controls.Add(Me.btnDeleteNode)
            Me.panelControl1.Controls.Add(Me.btnAddChild)
            Me.panelControl1.Controls.Add(Me.btnAddRoot)
            Me.panelControl1.Controls.Add(Me.btnAddColumn)
            Me.panelControl1.Controls.Add(Me.txtColumnName)
            Me.panelControl1.Controls.Add(Me.labelControl1)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panelControl1.Location = New System.Drawing.Point(0, 582)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(1259, 33)
            Me.panelControl1.TabIndex = 1
            ' 
            ' btnCopy
            ' 
            Me.btnCopy.Location = New System.Drawing.Point(519, 5)
            Me.btnCopy.Name = "btnCopy"
            Me.btnCopy.Size = New System.Drawing.Size(75, 23)
            Me.btnCopy.TabIndex = 6
            Me.btnCopy.Text = "Copy"
            AddHandler Me.btnCopy.Click, New System.EventHandler(AddressOf Me.OnCopyButtonClick)
            ' 
            ' btnDeleteNode
            ' 
            Me.btnDeleteNode.Location = New System.Drawing.Point(438, 5)
            Me.btnDeleteNode.Name = "btnDeleteNode"
            Me.btnDeleteNode.Size = New System.Drawing.Size(75, 23)
            Me.btnDeleteNode.TabIndex = 5
            Me.btnDeleteNode.Text = "Delete Node"
            AddHandler Me.btnDeleteNode.Click, New System.EventHandler(AddressOf Me.OnDeleteNodeButtonClick)
            ' 
            ' btnAddChild
            ' 
            Me.btnAddChild.Location = New System.Drawing.Point(357, 5)
            Me.btnAddChild.Name = "btnAddChild"
            Me.btnAddChild.Size = New System.Drawing.Size(75, 23)
            Me.btnAddChild.TabIndex = 4
            Me.btnAddChild.Text = "Add Child"
            AddHandler Me.btnAddChild.Click, New System.EventHandler(AddressOf Me.OnAddChildButtonClick)
            ' 
            ' btnAddRoot
            ' 
            Me.btnAddRoot.Location = New System.Drawing.Point(276, 5)
            Me.btnAddRoot.Name = "btnAddRoot"
            Me.btnAddRoot.Size = New System.Drawing.Size(75, 23)
            Me.btnAddRoot.TabIndex = 3
            Me.btnAddRoot.Text = "Add Root"
            AddHandler Me.btnAddRoot.Click, New System.EventHandler(AddressOf Me.OnAddRootButtonClick)
            ' 
            ' btnAddColumn
            ' 
            Me.btnAddColumn.Location = New System.Drawing.Point(195, 5)
            Me.btnAddColumn.Name = "btnAddColumn"
            Me.btnAddColumn.Size = New System.Drawing.Size(75, 23)
            Me.btnAddColumn.TabIndex = 2
            Me.btnAddColumn.Text = "Add Column"
            AddHandler Me.btnAddColumn.Click, New System.EventHandler(AddressOf Me.OnAddColumnButtonClick)
            ' 
            ' txtColumnName
            ' 
            Me.txtColumnName.Location = New System.Drawing.Point(89, 6)
            Me.txtColumnName.Name = "txtColumnName"
            Me.txtColumnName.Size = New System.Drawing.Size(100, 20)
            Me.txtColumnName.TabIndex = 1
            AddHandler Me.txtColumnName.TextChanged, New System.EventHandler(AddressOf Me.OnEditorColumnNameTextChanged)
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.Location = New System.Drawing.Point(13, 7)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(69, 13)
            Me.labelControl1.TabIndex = 0
            Me.labelControl1.Text = "Column Name:"
            ' 
            ' MainForm
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1259, 615)
            Me.Controls.Add(Me.container)
            Me.Controls.Add(Me.panelControl1)
            Me.Name = "MainForm"
            Me.Text = "Form1"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.OnFormLoad)
            CType((Me.container), System.ComponentModel.ISupportInitialize).EndInit()
            Me.container.ResumeLayout(False)
            CType((Me.sourceTreeList), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.panelControl1.PerformLayout()
            CType((Me.txtColumnName.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private container As DevExpress.XtraEditors.SplitContainerControl

        Private sourceTreeList As DevExpress.XtraTreeList.TreeList

        Private panelControl1 As DevExpress.XtraEditors.PanelControl

        Private btnCopy As DevExpress.XtraEditors.SimpleButton

        Private btnDeleteNode As DevExpress.XtraEditors.SimpleButton

        Private btnAddChild As DevExpress.XtraEditors.SimpleButton

        Private btnAddRoot As DevExpress.XtraEditors.SimpleButton

        Private btnAddColumn As DevExpress.XtraEditors.SimpleButton

        Private txtColumnName As DevExpress.XtraEditors.TextEdit

        Private labelControl1 As DevExpress.XtraEditors.LabelControl
    End Class
End Namespace
