Imports System.IO

Public Class Form1
    Dim inputFile As StreamReader   ' name of inputFile
    Dim intCount As Integer = 0     ' loop counter
    Dim recordNumber As Integer = 0 ' tracks record number and then stores max num of records

    ' Structure for employee record
    Structure EmployeeRecord
        Dim recordNumber As Integer
        Dim strFirstName As String
        Dim strMiddleName As String
        Dim strLastName As String
        Dim strEmployeeNum As String
        Dim strDepartment As String
        Dim strTelephone As String
        Dim strExtension As String
        Dim strEmail As String
    End Structure

    ' create array of employees using structure
    Const intMAX_SIZE As Integer = 25
    Dim employees(intMAX_SIZE) As EmployeeRecord

    ' Clears the form
    Sub ClearForm()
        txtDepartment.Clear()
        txtEmail.Clear()
        txtEmployeeNum.Clear()
        txtExtension.Clear()
        txtFirstName.Clear()
        txtMiddleName.Clear()
        txtLastName.Clear()
        txtRecordNum.Clear()
        txtTelephone.Clear()
    End Sub

    ' Opens a new file
    Sub OpenFile()
        With ofdOpenFile
            .Filter = "Text Files (*.txt) | *.txt"
            .InitialDirectory = "C:\Users\djboh\OneDrive\Documents"
            .Title = "Select a File to Open"
            If .ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                inputFile = File.OpenText(.FileName)
            End If
        End With
    End Sub

    ' Creates employees from input file
    Sub CreateRecords()
        Try
            ' Open the file
            OpenFile()

            Do Until inputFile.EndOfStream
                With employees(recordNumber)
                    .recordNumber = recordNumber
                    .strFirstName = inputFile.ReadLine()
                    .strMiddleName = inputFile.ReadLine()
                    .strLastName = inputFile.ReadLine()
                    .strEmployeeNum = inputFile.ReadLine()
                    .strDepartment = inputFile.ReadLine()
                    .strTelephone = inputFile.ReadLine()
                    .strExtension = inputFile.ReadLine()
                    .strEmail = inputFile.ReadLine()
                End With
                recordNumber += 1
                inputFile.ReadLine()
            Loop
            inputFile.Close()
        Catch ex As Exception
            MessageBox.Show("Sorry, cannot read file.")
        End Try

    End Sub

    ' copies resizes employees then outputs the data onto the form for each record
    Sub ReadRecord(ByVal intCount As Integer)
        ' Copy and resize employees to employee
        Dim employee(recordNumber) As EmployeeRecord
        employee = employees
        ' ouput employee data to form
        With employee(intCount)
            txtRecordNum.Text = .recordNumber.ToString()
            txtFirstName.Text = .strFirstName
            txtMiddleName.Text = .strMiddleName
            txtLastName.Text = .strLastName
            txtEmployeeNum.Text = .strEmployeeNum
            txtDepartment.Text = .strDepartment
            txtTelephone.Text = .strTelephone
            txtExtension.Text = .strExtension
            txtEmail.Text = .strEmail
        End With

    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        ' if the counter reaches the maximum number of records then display end of records
        ' otherwise read the next record
        If intCount = recordNumber - 1 Then
            MessageBox.Show("End of Records.")
        Else
            intCount += 1
            ReadRecord(intCount)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' calls creatrecords to request user to open file and then creates records
        CreateRecords()
        ' fills the form with the first record once opened and records have been completed 
        ' readrecord also copies and resizes the array of employees to employee array
        ReadRecord(0)
    End Sub
End Class
