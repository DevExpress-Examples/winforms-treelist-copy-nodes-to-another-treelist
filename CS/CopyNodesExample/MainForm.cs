using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;

namespace CopyNodesExample {
    public partial class MainForm :XtraForm {
        public MainForm() {
            InitializeComponent();
        }

        void UpdateControlsState() {
            btnAddChild.Enabled = sourceTreeList.FocusedNode != null;
            btnCopy.Enabled = sourceTreeList.Nodes.Count > 0;
            btnDeleteNode.Enabled = sourceTreeList.FocusedNode != null;
            btnAddColumn.Enabled = !string.IsNullOrEmpty(txtColumnName.Text);
        }

        private void OnFormLoad(object sender, EventArgs e) {
            UpdateControlsState();
        }

        private void OnEditorColumnNameTextChanged(object sender, EventArgs e) {
            UpdateControlsState();
        }

        private void OnSourceTreeListNodeChanged(object sender, NodeChangedEventArgs e) {
            if (e.ChangeType == NodeChangeTypeEnum.Add || e.ChangeType == NodeChangeTypeEnum.Remove)
                UpdateControlsState();
        }

        private void OnSourceTreeListFocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e) {
            UpdateControlsState();
        }

        private void OnAddColumnButtonClick(object sender, EventArgs e) {
            if (sourceTreeList.Columns.ColumnByFieldName(txtColumnName.Text) == null)
                sourceTreeList.Columns.AddField(txtColumnName.Text).Visible = true;
             else XtraMessageBox.Show(string.Format("The source TreeList already contains the {0} column",
                  txtColumnName.Text), "Copy Nodes Example", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OnAddRootButtonClick(object sender, EventArgs e) {
            sourceTreeList.AppendNode(null, null);
        }

        private void OnAddChildButtonClick(object sender, EventArgs e) {
            sourceTreeList.AppendNode(null, sourceTreeList.FocusedNode);
            sourceTreeList.FocusedNode.Expanded = true;
        }

        private void OnDeleteNodeButtonClick(object sender, EventArgs e) {
            sourceTreeList.DeleteNode(sourceTreeList.FocusedNode);
        }

        private void OnCopyButtonClick(object sender, EventArgs e) {
            TreeList destTreeList = container.Panel2.Controls.Count > 0 ?
                (TreeList)container.Panel2.Controls[0] : CreateDestTreeList();
            destTreeList.ClearNodes();
            destTreeList.Columns.Clear();
            foreach (TreeListColumn col in sourceTreeList.Columns)
                destTreeList.Columns.AddField(col.FieldName).Visible = true;
            sourceTreeList.NodesIterator.DoOperation(new CopyNodesOperation(destTreeList));
        }

        TreeList CreateDestTreeList() {
            TreeList result = new TreeList();
            result.Dock = DockStyle.Fill;
            result.Parent = container.Panel2;
            return result;
        }
    }
}