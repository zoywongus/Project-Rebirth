<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.btnFloorTimes = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnToDo = New System.Windows.Forms.Button()
        Me.btnUnitTracker = New System.Windows.Forms.Button()
        Me.btnTestAuthorizations = New System.Windows.Forms.Button()
        Me.lblDaysLeft = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(48, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(435, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(48, 207)
        Me.MonthCalendar1.MaxDate = New Date(2017, 6, 30, 0, 0, 0, 0)
        Me.MonthCalendar1.MinDate = New Date(2016, 9, 1, 0, 0, 0, 0)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 1
        '
        'btnFloorTimes
        '
        Me.btnFloorTimes.Location = New System.Drawing.Point(6, 19)
        Me.btnFloorTimes.Name = "btnFloorTimes"
        Me.btnFloorTimes.Size = New System.Drawing.Size(134, 23)
        Me.btnFloorTimes.TabIndex = 2
        Me.btnFloorTimes.Text = "Teacher Floor Times"
        Me.btnFloorTimes.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnToDo)
        Me.GroupBox1.Controls.Add(Me.btnUnitTracker)
        Me.GroupBox1.Controls.Add(Me.btnTestAuthorizations)
        Me.GroupBox1.Controls.Add(Me.btnFloorTimes)
        Me.GroupBox1.Location = New System.Drawing.Point(319, 207)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(148, 162)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'btnToDo
        '
        Me.btnToDo.Location = New System.Drawing.Point(6, 106)
        Me.btnToDo.Name = "btnToDo"
        Me.btnToDo.Size = New System.Drawing.Size(133, 23)
        Me.btnToDo.TabIndex = 6
        Me.btnToDo.Text = "To Do List"
        Me.btnToDo.UseVisualStyleBackColor = True
        '
        'btnUnitTracker
        '
        Me.btnUnitTracker.Location = New System.Drawing.Point(6, 77)
        Me.btnUnitTracker.Name = "btnUnitTracker"
        Me.btnUnitTracker.Size = New System.Drawing.Size(133, 23)
        Me.btnUnitTracker.TabIndex = 5
        Me.btnUnitTracker.Text = "Unit Tracker"
        Me.btnUnitTracker.UseVisualStyleBackColor = True
        '
        'btnTestAuthorizations
        '
        Me.btnTestAuthorizations.Location = New System.Drawing.Point(6, 48)
        Me.btnTestAuthorizations.Name = "btnTestAuthorizations"
        Me.btnTestAuthorizations.Size = New System.Drawing.Size(134, 23)
        Me.btnTestAuthorizations.TabIndex = 3
        Me.btnTestAuthorizations.Text = "Test Authorizations"
        Me.btnTestAuthorizations.UseVisualStyleBackColor = True
        '
        'lblDaysLeft
        '
        Me.lblDaysLeft.AutoSize = True
        Me.lblDaysLeft.Location = New System.Drawing.Point(45, 386)
        Me.lblDaysLeft.Name = "lblDaysLeft"
        Me.lblDaysLeft.Size = New System.Drawing.Size(0, 13)
        Me.lblDaysLeft.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(448, 376)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Help"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(535, 408)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblDaysLeft)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Home"
        Me.Text = "Project Rebirth"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents btnFloorTimes As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnUnitTracker As System.Windows.Forms.Button
    Friend WithEvents btnTestAuthorizations As System.Windows.Forms.Button
    Friend WithEvents lblDaysLeft As System.Windows.Forms.Label
    Friend WithEvents btnToDo As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
