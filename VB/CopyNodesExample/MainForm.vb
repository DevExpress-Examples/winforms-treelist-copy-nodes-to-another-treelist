Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraTreeList.Nodes

Namespace CopyNodesExample
    Public Partial Class MainForm
        Inherits DevExpress.XtraBars.Ribbon.RibbonForm

        Public Sub New()
            InitializeComponent()
            treeList1.Columns.AddVisible("Value")
            treeList2.Columns.AddVisible("Value")

            For i = 1 To 4
                Dim parentId = treeList1.AppendNode((New Object() {$"{i}"}), -1).Id

                For j = 1 To 3
                    Dim childId = treeList1.AppendNode((New Object() {$"{i}.{j}"}), parentId).Id

                    For k = 1 To 2
                        treeList1.AppendNode(New Object() {$"{i}.{j}.{k}"}, childId)
                    Next
                Next
            Next

            AddHandler copyButtonItem.ItemClick, AddressOf CopyButtonItem_ItemClick
            AddHandler clearButtonItem.ItemClick, AddressOf ClearButtonItem_ItemClick
        End Sub

        Private Sub CopyButtonItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
            For Each node As TreeListNode In treeList1.Nodes
                CopyNodeWithChildren(node, treeList2.Nodes)
            Next
        End Sub

        Private Sub ClearButtonItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
            treeList2.ClearNodes()
        End Sub

        ''' <summary>
        ''' Copies a single node to the target node collection.
        ''' </summary>
        ''' <returns>The newly created node.</returns>
        Private Function CopyNode(ByVal sourceNode As TreeListNode, ByVal targetNodes As TreeListNodes) As TreeListNode
            Dim columnCount = sourceNode.TreeList.Columns.Count
            Dim values As Object() = Enumerable.Range(0, columnCount).[Select](Function(x) sourceNode.GetValue(x)).ToArray()
            Dim newNode = targetNodes.Add(values)
            newNode.Assign(sourceNode)
            Return newNode
        End Function

        ''' <summary>
        ''' Copies a single node, along with all its children, to the target node collection.
        ''' </summary>
        ''' <returns>The newly created node.</returns>
        Private Function CopyNodeWithChildren(ByVal sourceNode As TreeListNode, ByVal targetNodes As TreeListNodes) As TreeListNode
            Dim result As TreeListNode = Nothing
            Dim stack = New Stack(Of (SourceNode As TreeListNode, TargetNodes As TreeListNodes))()
            stack.Push((sourceNode, targetNodes))

            While stack.Any()
                Dim operation = stack.Pop()
                Dim newNode = Me.CopyNode(operation.SourceNode, operation.TargetNodes)
                If result Is Nothing Then result = newNode

                For Each node As TreeListNode In operation.SourceNode.Nodes.Reverse()
                    stack.Push((node, newNode.Nodes))
                Next
            End While

            Return result
        End Function
    End Class
End Namespace
