<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.txtBase64 = New System.Windows.Forms.TextBox()
        Me.btnFileSave = New System.Windows.Forms.Button()
        Me.btnFileOpen = New System.Windows.Forms.Button()
        Me.btnPaste = New System.Windows.Forms.Button()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.btnFileExport = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtBase64
        '
        Me.txtBase64.Location = New System.Drawing.Point(46, 124)
        Me.txtBase64.MaxLength = 80000000
        Me.txtBase64.Multiline = True
        Me.txtBase64.Name = "txtBase64"
        Me.txtBase64.Size = New System.Drawing.Size(837, 372)
        Me.txtBase64.TabIndex = 0
        '
        'btnFileSave
        '
        Me.btnFileSave.Location = New System.Drawing.Point(426, 524)
        Me.btnFileSave.Name = "btnFileSave"
        Me.btnFileSave.Size = New System.Drawing.Size(115, 88)
        Me.btnFileSave.TabIndex = 1
        Me.btnFileSave.Text = "Convert Base64 to Binary and Save"
        Me.btnFileSave.UseVisualStyleBackColor = True
        '
        'btnFileOpen
        '
        Me.btnFileOpen.Location = New System.Drawing.Point(426, 27)
        Me.btnFileOpen.Name = "btnFileOpen"
        Me.btnFileOpen.Size = New System.Drawing.Size(115, 77)
        Me.btnFileOpen.TabIndex = 2
        Me.btnFileOpen.Text = "Open Binary File and Convert to Base64"
        Me.btnFileOpen.UseVisualStyleBackColor = True
        '
        'btnPaste
        '
        Me.btnPaste.Location = New System.Drawing.Point(913, 154)
        Me.btnPaste.Name = "btnPaste"
        Me.btnPaste.Size = New System.Drawing.Size(101, 67)
        Me.btnPaste.TabIndex = 3
        Me.btnPaste.Text = "Paste Clipboard to Base64 box"
        Me.btnPaste.UseVisualStyleBackColor = True
        '
        'btnCopy
        '
        Me.btnCopy.Location = New System.Drawing.Point(913, 281)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(101, 68)
        Me.btnCopy.TabIndex = 4
        Me.btnCopy.Text = "Copy Base64 Box to Clipboard"
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'btnFileExport
        '
        Me.btnFileExport.Location = New System.Drawing.Point(913, 405)
        Me.btnFileExport.Name = "btnFileExport"
        Me.btnFileExport.Size = New System.Drawing.Size(101, 64)
        Me.btnFileExport.TabIndex = 5
        Me.btnFileExport.Text = "Export Base64 box to text file"
        Me.btnFileExport.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1073, 624)
        Me.Controls.Add(Me.btnFileExport)
        Me.Controls.Add(Me.btnCopy)
        Me.Controls.Add(Me.btnPaste)
        Me.Controls.Add(Me.btnFileOpen)
        Me.Controls.Add(Me.btnFileSave)
        Me.Controls.Add(Me.txtBase64)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.Text = "Base64 Tool"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBase64 As TextBox
    Friend WithEvents btnFileSave As Button
    Friend WithEvents btnFileOpen As Button
    Friend WithEvents btnPaste As Button
    Friend WithEvents btnCopy As Button
    Friend WithEvents btnFileExport As Button
End Class
