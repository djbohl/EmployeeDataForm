Imports System.IO

Public Class Form1

    Private strFilename As String = String.Empty

    Sub ClearDocument()
        txtEmail.Clear()
        txtEmployeeNumber.Clear()
        txtExtension.Clear()
        txtFirstName.Clear()
        txtLastName.Clear()
        txtMiddleName.Clear()
        txtTelephone.Clear()
        boxDepartment.ResetText()
    End Sub

    Sub SaveDocument()
        Dim outputFile As StreamWriter

        Try
            ' Create file or append text if file exists
            If strFilename = String.Empty Then
                outputFile = File.CreateText(strFilename)
            Else
                outputFile = File.AppendText(strFilename)
            End If

            ' Write the form to the file
            outputFile.WriteLine(txtFirstName.Text)
            outputFile.WriteLine(txtMiddleName.Text)
            outputFile.WriteLine(txtLastName.Text)
            outputFile.WriteLine(txtEmployeeNumber.Text)
            outputFile.WriteLine(boxDepartment.Text)
            outputFile.WriteLine(txtTelephone.Text)
            outputFile.WriteLine(txtExtension.Text)
            outputFile.WriteLine(txtEmail.Text)
            outputFile.WriteLine()

            ' Close the file
            outputFile.Close()
        Catch ex As Exception
            MessageBox.Show("Error creating the file.")
        End Try
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearDocument()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If strFilename = String.Empty Then
            With sfdSaveFile
                .Filter = "Text files (*.txt) | *.txt"
                .Title = "Save File As"
                If sfdSaveFile.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                    strFilename = sfdSaveFile.FileName
                    SaveDocument()
                End If
            End With
        Else
            SaveDocument()
        End If
    End Sub
End Class
