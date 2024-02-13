<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Button1 = New Button()
        Button2 = New Button()
        ToolTip1 = New ToolTip(components)
        ToolTip2 = New ToolTip(components)
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(117, 208)
        Button1.Name = "Button1"
        Button1.Size = New Size(151, 51)
        Button1.TabIndex = 0
        Button1.Text = "Load Object Demo"
        ToolTip2.SetToolTip(Button1, "this button opens the form load object demo")
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(345, 208)
        Button2.Name = "Button2"
        Button2.Size = New Size(133, 51)
        Button2.TabIndex = 1
        Button2.Text = "Exit"
        ToolTip1.SetToolTip(Button2, "this button will close the window")
        Button2.UseVisualStyleBackColor = True
        ' 
        ' ToolTip1
        ' 
        ToolTip1.ToolTipTitle = "Exit"
        ' 
        ' ToolTip2
        ' 
        ToolTip2.ToolTipTitle = "LOD"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Red
        ClientSize = New Size(749, 450)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Welcoming Form"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ToolTip2 As ToolTip

End Class
