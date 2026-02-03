Imports System.ComponentModel
Imports System.ComponentModel.Design

<ToolboxItem(True)>
<Designer("System.Windows.Forms.Design.ComponentDesigner, System.Design", GetType(IDesigner))>
Public Class DarkContextMenu
    Inherits ContextMenuStrip

    Public Sub New()
        Renderer = New DarkContextMenuCustomDraw()
    End Sub

End Class

