<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UnitTracker
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
        Me.btnAddCourse = New System.Windows.Forms.Button()
        Me.btnRemoveCourse = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAddCourse
        '
        Me.btnAddCourse.Location = New System.Drawing.Point(12, 12)
        Me.btnAddCourse.Name = "btnAddCourse"
        Me.btnAddCourse.Size = New System.Drawing.Size(75, 23)
        Me.btnAddCourse.TabIndex = 0
        Me.btnAddCourse.Text = "Add Course"
        Me.btnAddCourse.UseVisualStyleBackColor = True
        '
        'btnRemoveCourse
        '
        Me.btnRemoveCourse.Location = New System.Drawing.Point(93, 12)
        Me.btnRemoveCourse.Name = "btnRemoveCourse"
        Me.btnRemoveCourse.Size = New System.Drawing.Size(95, 23)
        Me.btnRemoveCourse.TabIndex = 1
        Me.btnRemoveCourse.Text = "Remove Course"
        Me.btnRemoveCourse.UseVisualStyleBackColor = True
        Me.btnRemoveCourse.Visible = False
        '
        'UnitTracker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(193, 54)
        Me.Controls.Add(Me.btnRemoveCourse)
        Me.Controls.Add(Me.btnAddCourse)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "UnitTracker"
        Me.Text = "UnitTracker"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAddCourse As System.Windows.Forms.Button
    Friend WithEvents btnRemoveCourse As System.Windows.Forms.Button
End Class
