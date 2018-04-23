Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Nodes
Imports DevExpress.XtraTreeList.Nodes.Operations

Namespace CopyNodesExample
	Public Class CopyNodesOperation
		Inherits TreeListOperation
		Private DestTreeList As TreeList

		Public Sub New(ByVal destTreeList As TreeList)
			If destTreeList Is Nothing Then
				Throw New ArgumentNullException("destTreeList")
			End If
			Me.DestTreeList = destTreeList
		End Sub

		Public Overrides Sub Execute(ByVal node As TreeListNode)
			Dim values(node.TreeList.Columns.Count - 1) As Object
			For i As Integer = 0 To node.TreeList.Columns.Count - 1
				values(i) = node.GetValue(i)
			Next i
			If node.ParentNode Is Nothing Then
                DestTreeList.AppendNode(values, CType(Nothing, TreeListNode))
			Else
				DestTreeList.AppendNode(values, node.ParentNode.Id)
			End If
		End Sub
	End Class
End Namespace