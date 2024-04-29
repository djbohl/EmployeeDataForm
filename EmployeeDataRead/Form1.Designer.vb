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
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        txtEmail = New TextBox()
        txtExtension = New TextBox()
        txtTelephone = New TextBox()
        txtDepartment = New TextBox()
        txtEmployeeNum = New TextBox()
        txtLastName = New TextBox()
        txtMiddleName = New TextBox()
        txtFirstName = New TextBox()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        btnNext = New Button()
        btnClear = New Button()
        btnExit = New Button()
        txtRecordNum = New TextBox()
        ofdOpenFile = New OpenFileDialog()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(116, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(117, 20)
        Label1.TabIndex = 0
        Label1.Text = "Record Number:"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtEmail)
        GroupBox1.Controls.Add(txtExtension)
        GroupBox1.Controls.Add(txtTelephone)
        GroupBox1.Controls.Add(txtDepartment)
        GroupBox1.Controls.Add(txtEmployeeNum)
        GroupBox1.Controls.Add(txtLastName)
        GroupBox1.Controls.Add(txtMiddleName)
        GroupBox1.Controls.Add(txtFirstName)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(22, 83)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(402, 380)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Enter Employee Data"
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = SystemColors.Control
        txtEmail.Location = New Point(185, 314)
        txtEmail.Name = "txtEmail"
        txtEmail.ReadOnly = True
        txtEmail.Size = New Size(166, 27)
        txtEmail.TabIndex = 15
        ' 
        ' txtExtension
        ' 
        txtExtension.BackColor = SystemColors.Control
        txtExtension.Location = New Point(185, 277)
        txtExtension.Name = "txtExtension"
        txtExtension.ReadOnly = True
        txtExtension.Size = New Size(166, 27)
        txtExtension.TabIndex = 14
        ' 
        ' txtTelephone
        ' 
        txtTelephone.BackColor = SystemColors.Control
        txtTelephone.Location = New Point(185, 240)
        txtTelephone.Name = "txtTelephone"
        txtTelephone.ReadOnly = True
        txtTelephone.Size = New Size(166, 27)
        txtTelephone.TabIndex = 13
        ' 
        ' txtDepartment
        ' 
        txtDepartment.BackColor = SystemColors.Control
        txtDepartment.Location = New Point(185, 203)
        txtDepartment.Name = "txtDepartment"
        txtDepartment.ReadOnly = True
        txtDepartment.Size = New Size(166, 27)
        txtDepartment.TabIndex = 12
        ' 
        ' txtEmployeeNum
        ' 
        txtEmployeeNum.BackColor = SystemColors.Control
        txtEmployeeNum.Location = New Point(185, 166)
        txtEmployeeNum.Name = "txtEmployeeNum"
        txtEmployeeNum.ReadOnly = True
        txtEmployeeNum.Size = New Size(166, 27)
        txtEmployeeNum.TabIndex = 11
        ' 
        ' txtLastName
        ' 
        txtLastName.BackColor = SystemColors.Control
        txtLastName.Location = New Point(185, 129)
        txtLastName.Name = "txtLastName"
        txtLastName.ReadOnly = True
        txtLastName.Size = New Size(166, 27)
        txtLastName.TabIndex = 10
        ' 
        ' txtMiddleName
        ' 
        txtMiddleName.BackColor = SystemColors.Control
        txtMiddleName.Location = New Point(185, 92)
        txtMiddleName.Name = "txtMiddleName"
        txtMiddleName.ReadOnly = True
        txtMiddleName.Size = New Size(166, 27)
        txtMiddleName.TabIndex = 9
        ' 
        ' txtFirstName
        ' 
        txtFirstName.BackColor = SystemColors.Control
        txtFirstName.Location = New Point(185, 55)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.ReadOnly = True
        txtFirstName.Size = New Size(166, 27)
        txtFirstName.TabIndex = 5
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(73, 314)
        Label9.Name = "Label9"
        Label9.Size = New Size(106, 20)
        Label9.TabIndex = 8
        Label9.Text = "Email Address:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(104, 277)
        Label8.Name = "Label8"
        Label8.Size = New Size(75, 20)
        Label8.TabIndex = 7
        Label8.Text = "Extension:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(98, 240)
        Label7.Name = "Label7"
        Label7.Size = New Size(81, 20)
        Label7.TabIndex = 6
        Label7.Text = "Telephone:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(87, 203)
        Label6.Name = "Label6"
        Label6.Size = New Size(92, 20)
        Label6.TabIndex = 5
        Label6.Text = "Department:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(43, 166)
        Label5.Name = "Label5"
        Label5.Size = New Size(136, 20)
        Label5.TabIndex = 4
        Label5.Text = "Employee Number:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(97, 129)
        Label4.Name = "Label4"
        Label4.Size = New Size(82, 20)
        Label4.TabIndex = 3
        Label4.Text = "Last Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(76, 92)
        Label3.Name = "Label3"
        Label3.Size = New Size(103, 20)
        Label3.TabIndex = 2
        Label3.Text = "Middle Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(96, 55)
        Label2.Name = "Label2"
        Label2.Size = New Size(83, 20)
        Label2.TabIndex = 1
        Label2.Text = "First Name:"
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = SystemColors.ScrollBar
        btnNext.Location = New Point(22, 469)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(112, 66)
        btnNext.TabIndex = 2
        btnNext.Text = "Next Record"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = SystemColors.ScrollBar
        btnClear.Location = New Point(168, 469)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(112, 66)
        btnClear.TabIndex = 3
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = SystemColors.ScrollBar
        btnExit.Location = New Point(312, 469)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(112, 66)
        btnExit.TabIndex = 4
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' txtRecordNum
        ' 
        txtRecordNum.BackColor = SystemColors.Control
        txtRecordNum.Enabled = False
        txtRecordNum.Location = New Point(236, 41)
        txtRecordNum.Name = "txtRecordNum"
        txtRecordNum.ReadOnly = True
        txtRecordNum.Size = New Size(85, 27)
        txtRecordNum.TabIndex = 16
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(449, 547)
        Controls.Add(txtRecordNum)
        Controls.Add(btnExit)
        Controls.Add(btnClear)
        Controls.Add(btnNext)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Employee Data"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtExtension As TextBox
    Friend WithEvents txtTelephone As TextBox
    Friend WithEvents txtDepartment As TextBox
    Friend WithEvents txtEmployeeNum As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents btnNext As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtRecordNum As TextBox
    Friend WithEvents ofdOpenFile As OpenFileDialog

End Class
