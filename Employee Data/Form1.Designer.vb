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
        GroupBox1 = New GroupBox()
        boxDepartment = New ComboBox()
        txtEmail = New TextBox()
        txtExtension = New TextBox()
        txtTelephone = New TextBox()
        txtEmployeeNumber = New TextBox()
        txtLastName = New TextBox()
        txtMiddleName = New TextBox()
        txtFirstName = New TextBox()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        btnClear = New Button()
        btnExit = New Button()
        btnSave = New Button()
        sfdSaveFile = New SaveFileDialog()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(boxDepartment)
        GroupBox1.Controls.Add(txtEmail)
        GroupBox1.Controls.Add(txtExtension)
        GroupBox1.Controls.Add(txtTelephone)
        GroupBox1.Controls.Add(txtEmployeeNumber)
        GroupBox1.Controls.Add(txtLastName)
        GroupBox1.Controls.Add(txtMiddleName)
        GroupBox1.Controls.Add(txtFirstName)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(12, 27)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(368, 390)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Enter Employee Data"
        ' 
        ' boxDepartment
        ' 
        boxDepartment.FormattingEnabled = True
        boxDepartment.Items.AddRange(New Object() {"Accounting", "Administration", "Marketing", "MIS", "Sales"})
        boxDepartment.Location = New Point(148, 220)
        boxDepartment.Name = "boxDepartment"
        boxDepartment.Size = New Size(188, 28)
        boxDepartment.TabIndex = 18
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(148, 352)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(188, 27)
        txtEmail.TabIndex = 17
        ' 
        ' txtExtension
        ' 
        txtExtension.Location = New Point(148, 308)
        txtExtension.Name = "txtExtension"
        txtExtension.Size = New Size(188, 27)
        txtExtension.TabIndex = 16
        ' 
        ' txtTelephone
        ' 
        txtTelephone.Location = New Point(148, 264)
        txtTelephone.Name = "txtTelephone"
        txtTelephone.Size = New Size(188, 27)
        txtTelephone.TabIndex = 15
        ' 
        ' txtEmployeeNumber
        ' 
        txtEmployeeNumber.Location = New Point(148, 176)
        txtEmployeeNumber.Name = "txtEmployeeNumber"
        txtEmployeeNumber.Size = New Size(188, 27)
        txtEmployeeNumber.TabIndex = 14
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(148, 132)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(188, 27)
        txtLastName.TabIndex = 13
        ' 
        ' txtMiddleName
        ' 
        txtMiddleName.Location = New Point(148, 88)
        txtMiddleName.Name = "txtMiddleName"
        txtMiddleName.Size = New Size(188, 27)
        txtMiddleName.TabIndex = 12
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(148, 44)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(188, 27)
        txtFirstName.TabIndex = 11
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(30, 352)
        Label8.Name = "Label8"
        Label8.Size = New Size(112, 20)
        Label8.TabIndex = 10
        Label8.Text = "E-mail Address:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(67, 308)
        Label7.Name = "Label7"
        Label7.Size = New Size(75, 20)
        Label7.TabIndex = 9
        Label7.Text = "Extension:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(61, 264)
        Label6.Name = "Label6"
        Label6.Size = New Size(81, 20)
        Label6.TabIndex = 8
        Label6.Text = "Telephone:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(50, 220)
        Label5.Name = "Label5"
        Label5.Size = New Size(92, 20)
        Label5.TabIndex = 7
        Label5.Text = "Department:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(6, 176)
        Label4.Name = "Label4"
        Label4.Size = New Size(136, 20)
        Label4.TabIndex = 6
        Label4.Text = "Employee Number:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(60, 132)
        Label3.Name = "Label3"
        Label3.Size = New Size(82, 20)
        Label3.TabIndex = 5
        Label3.Text = "Last Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(39, 88)
        Label2.Name = "Label2"
        Label2.Size = New Size(103, 20)
        Label2.TabIndex = 4
        Label2.Text = "Middle Name:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(59, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(83, 20)
        Label1.TabIndex = 3
        Label1.Text = "First Name:"
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(133, 439)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(110, 55)
        btnClear.TabIndex = 0
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(249, 439)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(110, 55)
        btnExit.TabIndex = 1
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(17, 439)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(110, 55)
        btnSave.TabIndex = 2
        btnSave.Text = "Save Record"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(392, 550)
        Controls.Add(btnSave)
        Controls.Add(btnExit)
        Controls.Add(btnClear)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Employee Data"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtExtension As TextBox
    Friend WithEvents txtTelephone As TextBox
    Friend WithEvents txtEmployeeNumber As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents boxDepartment As ComboBox
    Friend WithEvents sfdSaveFile As SaveFileDialog

End Class
