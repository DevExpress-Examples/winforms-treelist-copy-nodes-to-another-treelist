using System;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList.Nodes.Operations;

namespace CopyNodesExample {
    public class CopyNodesOperation :TreeListOperation {
        TreeList DestTreeList;

        public CopyNodesOperation(TreeList destTreeList) {
            if (destTreeList == null)
                throw new ArgumentNullException("destTreeList");
            this.DestTreeList = destTreeList;
        }

        public override void Execute(TreeListNode node) {
            object[] values = new object[node.TreeList.Columns.Count];
            for (int i = 0; i < node.TreeList.Columns.Count; i++)
                values[i] = node.GetValue(i);
            if (node.ParentNode == null)
                DestTreeList.AppendNode(values, null);
            else DestTreeList.AppendNode(values, node.ParentNode.Id);
        }
    }
}