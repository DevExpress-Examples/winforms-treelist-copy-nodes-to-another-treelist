Imports System
Imports System.Windows.Forms
Imports DevExpress.Skins

Namespace CopyNodesExample
    Friend Module Program
        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread>
        Sub Main()
            Call Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Call SkinManager.EnableFormSkins()
            Call Application.Run(New MainForm())
        End Sub
    End Module
End Namespace
