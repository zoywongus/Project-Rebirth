<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HelpForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HelpForm))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtflr = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txtauth = New System.Windows.Forms.TextBox()
        Me.txttrack = New System.Windows.Forms.TextBox()
        Me.txttodo = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(95, 114)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(152, 61)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Floor Times"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(911, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CLICK ON THE PROPER BUTTON FOR SPECIFIC HELP"
        '
        'txtflr
        '
        Me.txtflr.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtflr.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtflr.Location = New System.Drawing.Point(0, 233)
        Me.txtflr.Multiline = True
        Me.txtflr.Name = "txtflr"
        Me.txtflr.ReadOnly = True
        Me.txtflr.Size = New System.Drawing.Size(1041, 412)
        Me.txtflr.TabIndex = 2
        Me.txtflr.Text = resources.GetString("txtflr.Text")
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(306, 114)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(158, 61)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Test Authorizations"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(517, 114)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(152, 61)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Unit Tracker"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(741, 114)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(152, 61)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "To Do List"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'txtauth
        '
        Me.txtauth.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtauth.Location = New System.Drawing.Point(0, 233)
        Me.txtauth.Multiline = True
        Me.txtauth.Name = "txtauth"
        Me.txtauth.ReadOnly = True
        Me.txtauth.Size = New System.Drawing.Size(1041, 412)
        Me.txtauth.TabIndex = 6
        Me.txtauth.Text = resources.GetString("txtauth.Text")
        '
        'txttrack
        '
        Me.txttrack.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttrack.Location = New System.Drawing.Point(0, 233)
        Me.txttrack.Multiline = True
        Me.txttrack.Name = "txttrack"
        Me.txttrack.ReadOnly = True
        Me.txttrack.Size = New System.Drawing.Size(1041, 412)
        Me.txttrack.TabIndex = 7
        Me.txttrack.Text = resources.GetString("txttrack.Text")
        '
        'txttodo
        '
        Me.txttodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttodo.Location = New System.Drawing.Point(0, 233)
        Me.txttodo.Multiline = True
        Me.txttodo.Name = "txttodo"
        Me.txttodo.ReadOnly = True
        Me.txttodo.Size = New System.Drawing.Size(1041, 412)
        Me.txttodo.TabIndex = 8
        Me.txttodo.Text = resources.GetString("txttodo.Text")
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(954, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "Go Back"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'HelpForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1041, 645)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.txttodo)
        Me.Controls.Add(Me.txttrack)
        Me.Controls.Add(Me.txtauth)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtflr)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "HelpForm"
        Me.Text = "HelpForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtflr As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents txtauth As System.Windows.Forms.TextBox
    Friend WithEvents txttrack As System.Windows.Forms.TextBox
    Friend WithEvents txttodo As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
