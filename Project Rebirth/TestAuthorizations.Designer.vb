<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestAuthorizations
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
        Me.TestList = New System.Windows.Forms.ListBox()
        Me.btnAddTest = New System.Windows.Forms.Button()
        Me.btnRemoveTest = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TestList
        '
        Me.TestList.ColumnWidth = 5
        Me.TestList.FormattingEnabled = True
        Me.TestList.Location = New System.Drawing.Point(12, 67)
        Me.TestList.Name = "TestList"
        Me.TestList.Size = New System.Drawing.Size(306, 173)
        Me.TestList.Sorted = True
        Me.TestList.TabIndex = 0
        '
        'btnAddTest
        '
        Me.btnAddTest.Location = New System.Drawing.Point(12, 13)
        Me.btnAddTest.Name = "btnAddTest"
        Me.btnAddTest.Size = New System.Drawing.Size(75, 23)
        Me.btnAddTest.TabIndex = 1
        Me.btnAddTest.Text = "Add New"
        Me.btnAddTest.UseVisualStyleBackColor = True
        '
        'btnRemoveTest
        '
        Me.btnRemoveTest.Location = New System.Drawing.Point(200, 13)
        Me.btnRemoveTest.Name = "btnRemoveTest"
        Me.btnRemoveTest.Size = New System.Drawing.Size(75, 23)
        Me.btnRemoveTest.TabIndex = 2
        Me.btnRemoveTest.Text = "Remove"
        Me.btnRemoveTest.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Course/Section"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(106, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Unit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(153, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Test No."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(204, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Expires"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(254, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Status"
        '
        'TestAuthorizations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(339, 272)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRemoveTest)
        Me.Controls.Add(Me.btnAddTest)
        Me.Controls.Add(Me.TestList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "TestAuthorizations"
        Me.Text = "TestAuthorizations"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TestList As System.Windows.Forms.ListBox
    Friend WithEvents btnAddTest As System.Windows.Forms.Button
    Friend WithEvents btnRemoveTest As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
