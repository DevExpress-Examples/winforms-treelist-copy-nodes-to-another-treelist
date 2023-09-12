Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Columns

Namespace CopyNodesExample

    Public Partial Class MainForm
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub UpdateControlsState()
            btnAddChild.Enabled = sourceTreeList.FocusedNode IsNot Nothing
            btnCopy.Enabled = sourceTreeList.Nodes.Count > 0
            btnDeleteNode.Enabled = sourceTreeList.FocusedNode IsNot Nothing
            btnAddColumn.Enabled = Not String.IsNullOrEmpty(txtColumnName.Text)
        End Sub

        Private Sub OnFormLoad(ByVal sender As Object, ByVal e As EventArgs)
            UpdateControlsState()
        End Sub

        Private Sub OnEditorColumnNameTextChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateControlsState()
        End Sub

        Private Sub OnSourceTreeListNodeChanged(ByVal sender As Object, ByVal e As NodeChangedEventArgs)
            If e.ChangeType = NodeChangeTypeEnum.Add OrElse e.ChangeType = NodeChangeTypeEnum.Remove Then UpdateControlsState()
        End Sub

        Private Sub OnSourceTreeListFocusedNodeChanged(ByVal sender As Object, ByVal e As FocusedNodeChangedEventArgs)
            UpdateControlsState()
        End Sub

        Private Sub OnAddColumnButtonClick(ByVal sender As Object, ByVal e As EventArgs)
            If sourceTreeList.Columns.ColumnByFieldName(txtColumnName.Text) Is Nothing Then
                sourceTreeList.Columns.AddField(txtColumnName.Text).Visible = True
            Else
                XtraMessageBox.Show(String.Format("The source TreeList already contains the {0} column", txtColumnName.Text), "Copy Nodes Example", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Sub

        Private Sub OnAddRootButtonClick(ByVal sender As Object, ByVal e As EventArgs)
            sourceTreeList.AppendNode(Nothing, Nothing)
        End Sub

        Private Sub OnAddChildButtonClick(ByVal sender As Object, ByVal e As EventArgs)
            sourceTreeList.AppendNode(Nothing, sourceTreeList.FocusedNode)
            sourceTreeList.FocusedNode.Expanded = True
        End Sub

        Private Sub OnDeleteNodeButtonClick(ByVal sender As Object, ByVal e As EventArgs)
            sourceTreeList.DeleteNode(sourceTreeList.FocusedNode)
        End Sub

        Private Sub OnCopyButtonClick(ByVal sender As Object, ByVal e As EventArgs)
            Dim destTreeList As TreeList = If(container.Panel2.Controls.Count > 0, CType(container.Panel2.Controls(0), TreeList), CreateDestTreeList())
            destTreeList.ClearNodes()
            destTreeList.Columns.Clear()
            For Each col As TreeListColumn In sourceTreeList.Columns
                destTreeList.Columns.AddField(col.FieldName).Visible = True
            Next

            sourceTreeList.NodesIterator.DoOperation(New CopyNodesOperation(destTreeList))
        End Sub

        Private Function CreateDestTreeList() As TreeList
            Dim result As TreeList = New TreeList()
            result.Dock = DockStyle.Fill
            result.Parent = container.Panel2
            Return result
        End Function
    End Class
End Namespace
