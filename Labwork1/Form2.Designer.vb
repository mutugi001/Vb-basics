<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Button2 = New Button()
        RadioButton6 = New RadioButton()
        RadioButton5 = New RadioButton()
        RadioButton4 = New RadioButton()
        CheckBox3 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox1 = New CheckBox()
        PictureBox1 = New PictureBox()
        RadioButton3 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        TextBox1 = New TextBox()
        OFGSelectImage = New OpenFileDialog()
        Button1 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(646, 356)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 25
        Button2.Text = "Exit"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton6
        ' 
        RadioButton6.AutoSize = True
        RadioButton6.Location = New Point(494, 262)
        RadioButton6.Name = "RadioButton6"
        RadioButton6.Size = New Size(45, 19)
        RadioButton6.TabIndex = 24
        RadioButton6.TabStop = True
        RadioButton6.Text = "Red"
        RadioButton6.UseVisualStyleBackColor = True
        ' 
        ' RadioButton5
        ' 
        RadioButton5.AutoSize = True
        RadioButton5.Location = New Point(495, 210)
        RadioButton5.Name = "RadioButton5"
        RadioButton5.Size = New Size(48, 19)
        RadioButton5.TabIndex = 23
        RadioButton5.TabStop = True
        RadioButton5.Text = "Blue"
        RadioButton5.UseVisualStyleBackColor = True
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Location = New Point(491, 169)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(56, 19)
        RadioButton4.TabIndex = 22
        RadioButton4.TabStop = True
        RadioButton4.Text = "Green"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        CheckBox3.Location = New Point(300, 263)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(85, 19)
        CheckBox3.TabIndex = 21
        CheckBox3.Text = "Bold Italic"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CheckBox2.Location = New Point(300, 217)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(51, 19)
        CheckBox2.TabIndex = 20
        CheckBox2.Text = "Bold"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        CheckBox1.Location = New Point(299, 173)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(51, 19)
        CheckBox1.TabIndex = 19
        CheckBox1.Text = "Italic"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Location = New Point(79, 156)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(157, 182)
        PictureBox1.TabIndex = 18
        PictureBox1.TabStop = False
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(594, 94)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(67, 19)
        RadioButton3.TabIndex = 17
        RadioButton3.TabStop = True
        RadioButton3.Text = "Tahoma"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(438, 94)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(73, 19)
        RadioButton2.TabIndex = 16
        RadioButton2.TabStop = True
        RadioButton2.Text = "Magneto"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(289, 91)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(81, 19)
        RadioButton1.TabIndex = 15
        RadioButton1.TabStop = True
        RadioButton1.Text = "Garamond"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(79, 71)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(153, 60)
        TextBox1.TabIndex = 14
        TextBox1.Text = "Sample test"
        ' 
        ' OFGSelectImage
        ' 
        OFGSelectImage.Title = "OFGSelectImage"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(97, 356)
        Button1.Name = "Button1"
        Button1.Size = New Size(115, 23)
        Button1.TabIndex = 26
        Button1.Text = "Load Image"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(RadioButton6)
        Controls.Add(RadioButton5)
        Controls.Add(RadioButton4)
        Controls.Add(CheckBox3)
        Controls.Add(CheckBox2)
        Controls.Add(CheckBox1)
        Controls.Add(PictureBox1)
        Controls.Add(RadioButton3)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        Name = "Form2"
        Text = "Form2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents OFGSelectImage As OpenFileDialog
    Friend WithEvents Button1 As Button
End Class
