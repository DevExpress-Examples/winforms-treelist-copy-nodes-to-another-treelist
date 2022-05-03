using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraTreeList.Nodes;

namespace CopyNodesExample {
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm {
        public MainForm() {
            InitializeComponent();

            treeList1.Columns.AddVisible("Value");
            treeList2.Columns.AddVisible("Value");
            
            for (int i = 1; i < 5; i++) {
                int parentId = treeList1.AppendNode(new object[] { $"{i}" }, -1).Id;
                for (int j = 1; j < 4; j++) {
                    int childId = treeList1.AppendNode(new object[] { $"{i}.{j}" }, parentId).Id;
                    for (int k = 1; k < 3; k++) {
                        treeList1.AppendNode(new object[] { $"{i}.{j}.{k}" }, childId);
                    }
                }
            }

            copyButtonItem.ItemClick += CopyButtonItem_ItemClick;
            clearButtonItem.ItemClick += ClearButtonItem_ItemClick;
        }

        private void CopyButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            foreach (TreeListNode node in treeList1.Nodes) {
                CopyNodeWithChildren(node, treeList2.Nodes);
            }
        }

        private void ClearButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            treeList2.ClearNodes();
        }

        /// <summary>
        /// Copies a single node to the target node collection.
        /// </summary>
        /// <returns>The newly created node.</returns>
        private TreeListNode CopyNode(TreeListNode sourceNode, TreeListNodes targetNodes) {
            int columnCount = sourceNode.TreeList.Columns.Count;
            object[] values = Enumerable.Range(0, columnCount).Select(x => sourceNode.GetValue(x)).ToArray();
            var newNode = targetNodes.Add(values);
            newNode.Assign(sourceNode);
            return newNode;
        }

        /// <summary>
        /// Copies a single node, along with all its children, to the target node collection.
        /// </summary>
        /// <returns>The newly created node.</returns>
        private TreeListNode CopyNodeWithChildren(TreeListNode sourceNode, TreeListNodes targetNodes) {
            TreeListNode result = null;
            
            var stack = new Stack<(TreeListNode SourceNode, TreeListNodes TargetNodes)>();
            stack.Push((sourceNode, targetNodes));
            while (stack.Any()) {
                var operation = stack.Pop();
                var newNode = CopyNode(operation.SourceNode, operation.TargetNodes);
                if (result == null) result = newNode;
                foreach (TreeListNode node in operation.SourceNode.Nodes.Reverse()) {
                    stack.Push((node, newNode.Nodes));
                }
            }

            return result;
        }
    }
}