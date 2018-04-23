Imports Microsoft.VisualBasic
Imports System
Namespace CopyNodesExample
	Partial Public Class MainForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.fContainer = New DevExpress.XtraEditors.SplitContainerControl
            Me.sourceTreeList = New DevExpress.XtraTreeList.TreeList
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl
            Me.btnCopy = New DevExpress.XtraEditors.SimpleButton
            Me.btnDeleteNode = New DevExpress.XtraEditors.SimpleButton
            Me.btnAddChild = New DevExpress.XtraEditors.SimpleButton
            Me.btnAddRoot = New DevExpress.XtraEditors.SimpleButton
            Me.btnAddColumn = New DevExpress.XtraEditors.SimpleButton
            Me.txtColumnName = New DevExpress.XtraEditors.TextEdit
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl
            CType(Me.fContainer, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.fContainer.SuspendLayout()
            CType(Me.sourceTreeList, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType(Me.txtColumnName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'fContainer
            '
            Me.fContainer.Dock = System.Windows.Forms.DockStyle.Fill
            Me.fContainer.Location = New System.Drawing.Point(0, 0)
            Me.fContainer.Name = "fContainer"
            Me.fContainer.Panel1.Controls.Add(Me.sourceTreeList)
            Me.fContainer.Panel1.Text = "Panel1"
            Me.fContainer.Panel2.Text = "Panel2"
            Me.fContainer.Size = New System.Drawing.Size(1259, 582)
            Me.fContainer.SplitterPosition = 644
            Me.fContainer.TabIndex = 0
            Me.fContainer.Text = "splitContainerControl1"
            '
            'sourceTreeList
            '
            Me.sourceTreeList.Dock = System.Windows.Forms.DockStyle.Fill
            Me.sourceTreeList.Location = New System.Drawing.Point(0, 0)
            Me.sourceTreeList.Name = "sourceTreeList"
            Me.sourceTreeList.Size = New System.Drawing.Size(644, 582)
            Me.sourceTreeList.TabIndex = 0
            '
            'panelControl1
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
            'btnCopy
            '
            Me.btnCopy.Location = New System.Drawing.Point(519, 5)
            Me.btnCopy.Name = "btnCopy"
            Me.btnCopy.Size = New System.Drawing.Size(75, 23)
            Me.btnCopy.TabIndex = 6
            Me.btnCopy.Text = "Copy"
            '
            'btnDeleteNode
            '
            Me.btnDeleteNode.Location = New System.Drawing.Point(438, 5)
            Me.btnDeleteNode.Name = "btnDeleteNode"
            Me.btnDeleteNode.Size = New System.Drawing.Size(75, 23)
            Me.btnDeleteNode.TabIndex = 5
            Me.btnDeleteNode.Text = "Delete Node"
            '
            'btnAddChild
            '
            Me.btnAddChild.Location = New System.Drawing.Point(357, 5)
            Me.btnAddChild.Name = "btnAddChild"
            Me.btnAddChild.Size = New System.Drawing.Size(75, 23)
            Me.btnAddChild.TabIndex = 4
            Me.btnAddChild.Text = "Add Child"
            '
            'btnAddRoot
            '
            Me.btnAddRoot.Location = New System.Drawing.Point(276, 5)
            Me.btnAddRoot.Name = "btnAddRoot"
            Me.btnAddRoot.Size = New System.Drawing.Size(75, 23)
            Me.btnAddRoot.TabIndex = 3
            Me.btnAddRoot.Text = "Add Root"
            '
            'btnAddColumn
            '
            Me.btnAddColumn.Location = New System.Drawing.Point(195, 5)
            Me.btnAddColumn.Name = "btnAddColumn"
            Me.btnAddColumn.Size = New System.Drawing.Size(75, 23)
            Me.btnAddColumn.TabIndex = 2
            Me.btnAddColumn.Text = "Add Column"
            '
            'txtColumnName
            '
            Me.txtColumnName.Location = New System.Drawing.Point(89, 6)
            Me.txtColumnName.Name = "txtColumnName"
            Me.txtColumnName.Size = New System.Drawing.Size(100, 20)
            Me.txtColumnName.TabIndex = 1
            '
            'labelControl1
            '
            Me.labelControl1.Location = New System.Drawing.Point(13, 7)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(69, 13)
            Me.labelControl1.TabIndex = 0
            Me.labelControl1.Text = "Column Name:"
            '
            'MainForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1259, 615)
            Me.Controls.Add(Me.fContainer)
            Me.Controls.Add(Me.panelControl1)
            Me.Name = "MainForm"
            Me.Text = "Form1"
            CType(Me.fContainer, System.ComponentModel.ISupportInitialize).EndInit()
            Me.fContainer.ResumeLayout(False)
            CType(Me.sourceTreeList, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.panelControl1.PerformLayout()
            CType(Me.txtColumnName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private fContainer As DevExpress.XtraEditors.SplitContainerControl
		Private WithEvents sourceTreeList As DevExpress.XtraTreeList.TreeList
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private WithEvents btnCopy As DevExpress.XtraEditors.SimpleButton
		Private WithEvents btnDeleteNode As DevExpress.XtraEditors.SimpleButton
		Private WithEvents btnAddChild As DevExpress.XtraEditors.SimpleButton
		Private WithEvents btnAddRoot As DevExpress.XtraEditors.SimpleButton
		Private WithEvents btnAddColumn As DevExpress.XtraEditors.SimpleButton
		Private WithEvents txtColumnName As DevExpress.XtraEditors.TextEdit
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
	End Class
End Namespace

