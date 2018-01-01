<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ToDoList
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
        Me.btnAddSticky = New System.Windows.Forms.Button()
        Me.lblTopLeft = New System.Windows.Forms.Label()
        Me.lblTopRight = New System.Windows.Forms.Label()
        Me.lblBottomLeft = New System.Windows.Forms.Label()
        Me.lblBottomRight = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAddSticky
        '
        Me.btnAddSticky.Location = New System.Drawing.Point(12, 12)
        Me.btnAddSticky.Name = "btnAddSticky"
        Me.btnAddSticky.Size = New System.Drawing.Size(99, 23)
        Me.btnAddSticky.TabIndex = 1
        Me.btnAddSticky.Text = "Add Sticky Note"
        Me.btnAddSticky.UseVisualStyleBackColor = True
        '
        'lblTopLeft
        '
        Me.lblTopLeft.AutoSize = True
        Me.lblTopLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTopLeft.Location = New System.Drawing.Point(12, 56)
        Me.lblTopLeft.Name = "lblTopLeft"
        Me.lblTopLeft.Size = New System.Drawing.Size(129, 18)
        Me.lblTopLeft.TabIndex = 2
        Me.lblTopLeft.Text = "Planning Your Day"
        '
        'lblTopRight
        '
        Me.lblTopRight.AutoSize = True
        Me.lblTopRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTopRight.Location = New System.Drawing.Point(661, 56)
        Me.lblTopRight.Name = "lblTopRight"
        Me.lblTopRight.Size = New System.Drawing.Size(71, 18)
        Me.lblTopRight.TabIndex = 3
        Me.lblTopRight.Text = "Seminars"
        '
        'lblBottomLeft
        '
        Me.lblBottomLeft.AutoSize = True
        Me.lblBottomLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBottomLeft.Location = New System.Drawing.Point(12, 288)
        Me.lblBottomLeft.Name = "lblBottomLeft"
        Me.lblBottomLeft.Size = New System.Drawing.Size(99, 18)
        Me.lblBottomLeft.TabIndex = 4
        Me.lblBottomLeft.Text = "Units + Notes"
        '
        'lblBottomRight
        '
        Me.lblBottomRight.AutoSize = True
        Me.lblBottomRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBottomRight.Location = New System.Drawing.Point(633, 288)
        Me.lblBottomRight.Name = "lblBottomRight"
        Me.lblBottomRight.Size = New System.Drawing.Size(99, 18)
        Me.lblBottomRight.TabIndex = 5
        Me.lblBottomRight.Text = "Future Events"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(117, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Double-Click to remove*"
        '
        'ToDoList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(744, 531)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblBottomRight)
        Me.Controls.Add(Me.lblBottomLeft)
        Me.Controls.Add(Me.lblTopRight)
        Me.Controls.Add(Me.lblTopLeft)
        Me.Controls.Add(Me.btnAddSticky)
        Me.Name = "ToDoList"
        Me.Text = "ToDoList"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAddSticky As System.Windows.Forms.Button
    Friend WithEvents lblTopLeft As System.Windows.Forms.Label
    Friend WithEvents lblTopRight As System.Windows.Forms.Label
    Friend WithEvents lblBottomLeft As System.Windows.Forms.Label
    Friend WithEvents lblBottomRight As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
