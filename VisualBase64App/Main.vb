Public Class Main
    Private Sub btnFileSave_Click(sender As Object, e As EventArgs) Handles btnFileSave.Click
        Dim base64String As String
        Dim SaveFileDialog1 As New SaveFileDialog()

        'Write out the decoded data. 
        Dim outFile As System.IO.FileStream

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Me.Cursor = Cursors.WaitCursor
            base64String = Me.txtBase64.Text

            ' Convert the Base64 UUEncoded input into binary output. 
            Dim binaryData() As Byte
            Try
                binaryData = System.Convert.FromBase64String(base64String)
            Catch exp As System.ArgumentNullException
                Me.Cursor = Cursors.Default
                MsgBox("Base 64 string is null.")
                Return
            Catch exp As System.FormatException
                Me.Cursor = Cursors.Default
                MsgBox("Base 64 length is not even multiple of 4.")
                Return
            End Try

            outFile = SaveFileDialog1.OpenFile()
            If (outFile IsNot Nothing) Then
                ' Code to write the stream goes here.
                Try
                    outFile.Write(binaryData, 0, binaryData.Length - 1)
                    outFile.Close()
                Catch exp As System.Exception
                    ' Error creating stream or writing to it. Resignal message to user
                    Me.Cursor = Cursors.Default
                    MsgBox(exp.Message)
                End Try
                outFile.Close()
            End If
            Me.Cursor = Cursors.Default
        End If

    End Sub

    Private Sub btnFileOpen_Click(sender As Object, e As EventArgs) Handles btnFileOpen.Click
        Dim openFileDialog1 As New OpenFileDialog()

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            ' open the file

            Dim inFile As System.IO.FileStream
            Dim binaryData() As Byte

            Me.Cursor = Cursors.WaitCursor

            Try
                inFile = openFileDialog1.OpenFile()
                ReDim binaryData(inFile.Length)
                Dim bytesRead As Long = inFile.Read(binaryData,
                                                0,
                                                inFile.Length)
                inFile.Close()
            Catch exp As System.Exception
                ' Error creating stream or reading from it.
                Me.Cursor = Cursors.Default
                MsgBox(exp.Message)
                Return
            End Try

            ' Convert the binary input into Base64 UUEncoded output. 
            Dim base64String As String
            Try
                base64String = System.Convert.ToBase64String(binaryData, 0, binaryData.Length)
            Catch exp As System.ArgumentNullException
                Me.Cursor = Cursors.Default
                MsgBox("Binary data array is null.")
                Return
            End Try

            ' Write the UUEncoded version to the output file. 
            Me.txtBase64.Text = base64String
            Me.Cursor = Cursors.Default

        End If

    End Sub

    Private Sub btnPaste_Click(sender As Object, e As EventArgs) Handles btnPaste.Click
        Me.txtBase64.Text = Clipboard.GetText

    End Sub

    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        Clipboard.Clear()
        Clipboard.SetText(Me.txtBase64.Text)
    End Sub

    Private Sub btnFileExport_Click(sender As Object, e As EventArgs) Handles btnFileExport.Click
        'Write out the decoded data. 
        Dim SaveFileDialog1 As New SaveFileDialog()
        Dim outFile As System.IO.FileStream
        Dim fileWriter As System.IO.StreamWriter
        Dim base64String As String

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Me.Cursor = Cursors.WaitCursor
            base64String = Me.txtBase64.Text
            outFile = SaveFileDialog1.OpenFile()
            If (outFile IsNot Nothing) Then
                ' Code to write the stream goes here.
                Try
                    fileWriter = New System.IO.StreamWriter(outFile)
                    fileWriter.WriteLine(base64String)
                    outFile.Close()
                Catch exp As System.Exception
                    ' Error creating stream or writing to it. Resignal message to user
                    Me.Cursor = Cursors.Default
                    MsgBox(exp.Message)
                End Try
                outFile.Close()
            End If
            Me.Cursor = Cursors.Default
        End If

    End Sub
End Class
