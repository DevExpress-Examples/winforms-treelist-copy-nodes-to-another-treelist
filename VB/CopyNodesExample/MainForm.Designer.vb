Imports System

Namespace CopyNodesExample
    Partial Class MainForm
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <paramname="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
            Me.formAssistant1 = New DevExpress.XtraBars.FormAssistant()
            Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.copyButtonItem = New DevExpress.XtraBars.BarButtonItem()
            Me.clearButtonItem = New DevExpress.XtraBars.BarButtonItem()
            Me.skinDropDownButtonItem1 = New DevExpress.XtraBars.SkinDropDownButtonItem()
            Me.skinPaletteRibbonGalleryBarItem1 = New DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem()
            Me.barStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
            Me.barStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
            Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
            Me.ribbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
            Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
            Me.treeList2 = New DevExpress.XtraTreeList.TreeList()
            CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.splitContainerControl1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainerControl1.Panel1.SuspendLayout()
            CType(Me.splitContainerControl1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainerControl1.Panel2.SuspendLayout()
            Me.splitContainerControl1.SuspendLayout()
            CType(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.treeList2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'ribbonControl1
            '
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.copyButtonItem, Me.clearButtonItem, Me.skinDropDownButtonItem1, Me.skinPaletteRibbonGalleryBarItem1, Me.barStaticItem1, Me.barStaticItem2})
            Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl1.MaxItemId = 8
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1})
            Me.ribbonControl1.Size = New System.Drawing.Size(956, 158)
            Me.ribbonControl1.StatusBar = Me.ribbonStatusBar1
            '
            'copyButtonItem
            '
            Me.copyButtonItem.Caption = "Copy"
            Me.copyButtonItem.Id = 1
            Me.copyButtonItem.ImageOptions.SvgImage = CType(resources.GetObject("copyButtonItem.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
            Me.copyButtonItem.Name = "copyButtonItem"
            '
            'clearButtonItem
            '
            Me.clearButtonItem.Caption = "Clear"
            Me.clearButtonItem.Id = 2
            Me.clearButtonItem.ImageOptions.SvgImage = Global.Resources.clearall
            Me.clearButtonItem.Name = "clearButtonItem"
            '
            'skinDropDownButtonItem1
            '
            Me.skinDropDownButtonItem1.Id = 3
            Me.skinDropDownButtonItem1.Name = "skinDropDownButtonItem1"
            '
            'skinPaletteRibbonGalleryBarItem1
            '
            Me.skinPaletteRibbonGalleryBarItem1.Caption = "skinPaletteRibbonGalleryBarItem1"
            Me.skinPaletteRibbonGalleryBarItem1.Id = 5
            Me.skinPaletteRibbonGalleryBarItem1.Name = "skinPaletteRibbonGalleryBarItem1"
            '
            'barStaticItem1
            '
            Me.barStaticItem1.Caption = "Source TreeList"
            Me.barStaticItem1.Id = 6
            Me.barStaticItem1.Name = "barStaticItem1"
            '
            'barStaticItem2
            '
            Me.barStaticItem2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
            Me.barStaticItem2.Caption = "Target TreeList"
            Me.barStaticItem2.Id = 7
            Me.barStaticItem2.Name = "barStaticItem2"
            '
            'ribbonPage1
            '
            Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup2, Me.ribbonPageGroup1})
            Me.ribbonPage1.Name = "ribbonPage1"
            Me.ribbonPage1.Text = "Main"
            '
            'ribbonPageGroup2
            '
            Me.ribbonPageGroup2.ItemLinks.Add(Me.skinDropDownButtonItem1)
            Me.ribbonPageGroup2.ItemLinks.Add(Me.skinPaletteRibbonGalleryBarItem1)
            Me.ribbonPageGroup2.Name = "ribbonPageGroup2"
            Me.ribbonPageGroup2.Text = "Look and Feel"
            '
            'ribbonPageGroup1
            '
            Me.ribbonPageGroup1.ItemLinks.Add(Me.copyButtonItem)
            Me.ribbonPageGroup1.ItemLinks.Add(Me.clearButtonItem)
            Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
            Me.ribbonPageGroup1.Text = "Actions"
            '
            'ribbonStatusBar1
            '
            Me.ribbonStatusBar1.ItemLinks.Add(Me.barStaticItem1)
            Me.ribbonStatusBar1.ItemLinks.Add(Me.barStaticItem2)
            Me.ribbonStatusBar1.Location = New System.Drawing.Point(0, 400)
            Me.ribbonStatusBar1.Name = "ribbonStatusBar1"
            Me.ribbonStatusBar1.Ribbon = Me.ribbonControl1
            Me.ribbonStatusBar1.Size = New System.Drawing.Size(956, 24)
            '
            'ribbonPage2
            '
            Me.ribbonPage2.Name = "ribbonPage2"
            Me.ribbonPage2.Text = "ribbonPage2"
            '
            'splitContainerControl1
            '
            Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.splitContainerControl1.Location = New System.Drawing.Point(0, 158)
            Me.splitContainerControl1.Name = "splitContainerControl1"
            '
            'splitContainerControl1.Panel1
            '
            Me.splitContainerControl1.Panel1.Controls.Add(Me.treeList1)
            Me.splitContainerControl1.Panel1.Text = "Panel1"
            '
            'splitContainerControl1.Panel2
            '
            Me.splitContainerControl1.Panel2.Controls.Add(Me.treeList2)
            Me.splitContainerControl1.Panel2.Text = "Panel2"
            Me.splitContainerControl1.Size = New System.Drawing.Size(956, 242)
            Me.splitContainerControl1.SplitterPosition = 458
            Me.splitContainerControl1.TabIndex = 2
            '
            'treeList1
            '
            Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.treeList1.Location = New System.Drawing.Point(0, 0)
            Me.treeList1.MenuManager = Me.ribbonControl1
            Me.treeList1.Name = "treeList1"
            Me.treeList1.Size = New System.Drawing.Size(458, 242)
            Me.treeList1.TabIndex = 0
            '
            'treeList2
            '
            Me.treeList2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.treeList2.Location = New System.Drawing.Point(0, 0)
            Me.treeList2.MenuManager = Me.ribbonControl1
            Me.treeList2.Name = "treeList2"
            Me.treeList2.Size = New System.Drawing.Size(488, 242)
            Me.treeList2.TabIndex = 0
            '
            'MainForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(956, 424)
            Me.Controls.Add(Me.splitContainerControl1)
            Me.Controls.Add(Me.ribbonStatusBar1)
            Me.Controls.Add(Me.ribbonControl1)
            Me.Name = "MainForm"
            Me.Ribbon = Me.ribbonControl1
            Me.StatusBar = Me.ribbonStatusBar1
            Me.Text = "Form1"
            CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.splitContainerControl1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl1.Panel1.ResumeLayout(False)
            CType(Me.splitContainerControl1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl1.Panel2.ResumeLayout(False)
            CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl1.ResumeLayout(False)
            CType(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.treeList2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private formAssistant1 As DevExpress.XtraBars.FormAssistant
        Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
        Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
        Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Private ribbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
        Private ribbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
        Private copyButtonItem As DevExpress.XtraBars.BarButtonItem
        Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
        Private treeList1 As DevExpress.XtraTreeList.TreeList
        Private treeList2 As DevExpress.XtraTreeList.TreeList
        Private clearButtonItem As DevExpress.XtraBars.BarButtonItem
        Private skinDropDownButtonItem1 As DevExpress.XtraBars.SkinDropDownButtonItem
        Private skinPaletteRibbonGalleryBarItem1 As DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem
        Private ribbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Private barStaticItem1 As DevExpress.XtraBars.BarStaticItem
        Private barStaticItem2 As DevExpress.XtraBars.BarStaticItem
    End Class
End Namespace
