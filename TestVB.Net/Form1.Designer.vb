<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        ListBox1 = New ListBox()
        btnAdd = New Button()
        btnDelete = New Button()
        btnSearch = New Button()
        btnModify = New Button()
        gbData = New GroupBox()
        lbDNI = New Label()
        tbDNI = New TextBox()
        cbMaritalStatus = New ComboBox()
        lbMaritalStatus = New Label()
        lbOccupation = New Label()
        lbAge = New Label()
        tbOccupation = New TextBox()
        tbAge = New TextBox()
        lbSurname = New Label()
        tbSurname = New TextBox()
        lbName = New Label()
        tbName = New TextBox()
        btnClean = New Button()
        gbData.SuspendLayout()
        SuspendLayout()
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(25, 12)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(150, 404)
        ListBox1.TabIndex = 10
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(239, 317)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(95, 40)
        btnAdd.TabIndex = 6
        btnAdd.Text = "Agregar"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(340, 317)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(95, 40)
        btnDelete.TabIndex = 7
        btnDelete.Text = "Borrar"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(340, 363)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(95, 40)
        btnSearch.TabIndex = 9
        btnSearch.Text = "Buscar"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' btnModify
        ' 
        btnModify.Location = New Point(239, 363)
        btnModify.Name = "btnModify"
        btnModify.Size = New Size(95, 40)
        btnModify.TabIndex = 8
        btnModify.Text = "Modificar"
        btnModify.UseVisualStyleBackColor = True
        ' 
        ' gbData
        ' 
        gbData.Controls.Add(lbDNI)
        gbData.Controls.Add(tbDNI)
        gbData.Controls.Add(cbMaritalStatus)
        gbData.Controls.Add(lbMaritalStatus)
        gbData.Controls.Add(lbOccupation)
        gbData.Controls.Add(lbAge)
        gbData.Controls.Add(tbOccupation)
        gbData.Controls.Add(tbAge)
        gbData.Controls.Add(lbSurname)
        gbData.Controls.Add(tbSurname)
        gbData.Controls.Add(lbName)
        gbData.Controls.Add(tbName)
        gbData.Location = New Point(194, 12)
        gbData.Name = "gbData"
        gbData.Size = New Size(270, 299)
        gbData.TabIndex = 5
        gbData.TabStop = False
        gbData.Text = "Datos"
        ' 
        ' lbDNI
        ' 
        lbDNI.AutoSize = True
        lbDNI.Location = New Point(19, 29)
        lbDNI.Name = "lbDNI"
        lbDNI.Size = New Size(35, 20)
        lbDNI.TabIndex = 10
        lbDNI.Text = "DNI"
        ' 
        ' tbDNI
        ' 
        tbDNI.Location = New Point(107, 26)
        tbDNI.Name = "tbDNI"
        tbDNI.Size = New Size(151, 27)
        tbDNI.TabIndex = 0
        ' 
        ' cbMaritalStatus
        ' 
        cbMaritalStatus.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cbMaritalStatus.AutoCompleteSource = AutoCompleteSource.ListItems
        cbMaritalStatus.FormattingEnabled = True
        cbMaritalStatus.Items.AddRange(New Object() {"Soltero/a", "Casado/a", "Viudo/a", "Unión libre"})
        cbMaritalStatus.Location = New Point(107, 233)
        cbMaritalStatus.Name = "cbMaritalStatus"
        cbMaritalStatus.Size = New Size(151, 28)
        cbMaritalStatus.TabIndex = 5
        ' 
        ' lbMaritalStatus
        ' 
        lbMaritalStatus.AutoSize = True
        lbMaritalStatus.Location = New Point(19, 236)
        lbMaritalStatus.Name = "lbMaritalStatus"
        lbMaritalStatus.Size = New Size(86, 20)
        lbMaritalStatus.TabIndex = 7
        lbMaritalStatus.Text = "Estado Civil"
        ' 
        ' lbOccupation
        ' 
        lbOccupation.AutoSize = True
        lbOccupation.Location = New Point(19, 193)
        lbOccupation.Name = "lbOccupation"
        lbOccupation.Size = New Size(80, 20)
        lbOccupation.TabIndex = 7
        lbOccupation.Text = "Ocupacion"
        ' 
        ' lbAge
        ' 
        lbAge.AutoSize = True
        lbAge.Location = New Point(19, 151)
        lbAge.Name = "lbAge"
        lbAge.Size = New Size(43, 20)
        lbAge.TabIndex = 5
        lbAge.Text = "Edad"
        ' 
        ' tbOccupation
        ' 
        tbOccupation.Location = New Point(107, 190)
        tbOccupation.Name = "tbOccupation"
        tbOccupation.Size = New Size(151, 27)
        tbOccupation.TabIndex = 4
        ' 
        ' tbAge
        ' 
        tbAge.Location = New Point(107, 148)
        tbAge.Name = "tbAge"
        tbAge.Size = New Size(151, 27)
        tbAge.TabIndex = 3
        ' 
        ' lbSurname
        ' 
        lbSurname.AutoSize = True
        lbSurname.Location = New Point(19, 112)
        lbSurname.Name = "lbSurname"
        lbSurname.Size = New Size(66, 20)
        lbSurname.TabIndex = 3
        lbSurname.Text = "Apellido"
        ' 
        ' tbSurname
        ' 
        tbSurname.Location = New Point(107, 105)
        tbSurname.Name = "tbSurname"
        tbSurname.Size = New Size(151, 27)
        tbSurname.TabIndex = 2
        ' 
        ' lbName
        ' 
        lbName.AutoSize = True
        lbName.Location = New Point(19, 66)
        lbName.Name = "lbName"
        lbName.Size = New Size(64, 20)
        lbName.TabIndex = 1
        lbName.Text = "Nombre"
        ' 
        ' tbName
        ' 
        tbName.Location = New Point(107, 63)
        tbName.Name = "tbName"
        tbName.Size = New Size(151, 27)
        tbName.TabIndex = 1
        ' 
        ' btnClean
        ' 
        btnClean.Location = New Point(188, 335)
        btnClean.Name = "btnClean"
        btnClean.Size = New Size(45, 45)
        btnClean.TabIndex = 11
        btnClean.Text = "img Clean"
        btnClean.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(491, 435)
        Controls.Add(btnClean)
        Controls.Add(gbData)
        Controls.Add(btnSearch)
        Controls.Add(btnModify)
        Controls.Add(btnDelete)
        Controls.Add(btnAdd)
        Controls.Add(ListBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Form1"
        Text = "Form1"
        gbData.ResumeLayout(False)
        gbData.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnModify As Button
    Friend WithEvents gbData As GroupBox
    Friend WithEvents tbName As TextBox
    Friend WithEvents lbName As Label
    Friend WithEvents lbAge As Label
    Friend WithEvents tbAge As TextBox
    Friend WithEvents lbSurname As Label
    Friend WithEvents tbSurname As TextBox
    Friend WithEvents lbOccupation As Label
    Friend WithEvents tbOccupation As TextBox
    Friend WithEvents lbMaritalStatus As Label
    Friend WithEvents cbMaritalStatus As ComboBox
    Friend WithEvents lbDNI As Label
    Friend WithEvents tbDNI As TextBox
    Friend WithEvents btnClean As Button

End Class
