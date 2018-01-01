Imports System.IO

Public Class FloorTimes
    'Reads how many teachers the user has, and creates a listbox for each teacher and a corresponding label.
    'The AddFloorTimes subroutine is called for each teacher.
    Private Sub FloorTimes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim contents() As String = File.ReadAllLines("teachers.txt")
        Dim list As List(Of String) = contents.ToList

        lblTeacher1.Text = list(0)
        Call AddFloorTimes(teacherBox1, list(0))

        lblTeacher2.Text = list(1)
        Call AddFloorTimes(teacherBox2, list(1))

        lblTeacher3.Text = list(2)
        Call AddFloorTimes(teacherBox3, list(2))

        lblTeacher4.Text = list(3)
        Call AddFloorTimes(teacherBox4, list(3))

        If list.Count > 4 Then
            Dim lblTeacher5 As New Label
            lblTeacher5.Text = list(4)
            lblTeacher5.Location = New Point(12, lblTeacher4.Location.Y + 23)

            Dim teacherBox5 As New ListBox
            teacherBox5.Size = New Size(240, 17)
            teacherBox5.Location = New Point(112, lblTeacher4.Location.Y + 23)
            teacherBox5.BringToFront()
            Call AddFloorTimes(teacherBox5, list(4))

            Me.Controls.Add(lblTeacher5)
            Me.Controls.Add(teacherBox5)
            Me.Size = New Size(Me.Size.Width, Me.Size.Height + 23)

            If list.Count > 5 Then
                Dim lblTeacher6 As New Label
                lblTeacher6.Text = list(5)
                lblTeacher6.Location = New Point(12, lblTeacher5.Location.Y + 23)

                Dim teacherBox6 As New ListBox
                teacherBox6.Size = New Size(240, 17)
                teacherBox6.Location = New Point(112, lblTeacher5.Location.Y + 23)
                Call AddFloorTimes(teacherBox6, list(5))

                Me.Controls.Add(lblTeacher6)
                Me.Controls.Add(teacherBox6)
                Me.Size = New Size(Me.Size.Width, Me.Size.Height + 23)

                If list.Count > 6 Then
                    Dim lblTeacher7 As New Label
                    lblTeacher7.Text = list(6)
                    lblTeacher7.Location = New Point(12, lblTeacher6.Location.Y + 23)

                    Dim teacherBox7 As New ListBox
                    teacherBox7.Size = New Size(240, 17)
                    teacherBox7.Location = New Point(112, lblTeacher6.Location.Y + 23)
                    Call AddFloorTimes(teacherBox7, list(6))

                    Me.Controls.Add(lblTeacher7)
                    Me.Controls.Add(teacherBox7)
                    Me.Size = New Size(Me.Size.Width, Me.Size.Height + 23)

                    If list.Count > 7 Then
                        Dim lblTeacher8 As New Label
                        lblTeacher8.Text = list(7)
                        lblTeacher8.Location = New Point(12, lblTeacher7.Location.Y + 23)

                        Dim teacherBox8 As New ListBox
                        teacherBox8.Size = New Size(240, 17)
                        teacherBox8.Location = New Point(112, lblTeacher7.Location.Y + 23)
                        Call AddFloorTimes(teacherBox8, list(7))

                        Me.Controls.Add(lblTeacher8)
                        Me.Controls.Add(teacherBox8)
                        Me.Size = New Size(Me.Size.Width, Me.Size.Height + 23)
                    End If
                End If
            End If
        End If
    End Sub

    'This subroutine adds the floor times of the teachers to their corresponding list box
    'Also checks the time schedule for that day, and displays it.
    Private Sub AddFloorTimes(ByVal listBox As ListBox, ByVal teacher As String)
        Dim floorTimes() As String = File.ReadAllLines("FloorTimes.txt")
        Dim listFloorTimes As List(Of String) = floorTimes.ToList

        Dim day() As String = File.ReadAllLines("days.txt")
        Dim listDay As List(Of String) = day.ToList
        Dim currentDay As String

        Dim period1 As String
        Dim period2 As String
        Dim period3 As String
        Dim period4 As String
        Dim period5 As String

        'Reads through "days.txt" to see what the schedule is, and displays it.
        For x As Integer = 0 To listDay.Count - 1
            If listDay(x) = DateString Then
                currentDay = listDay(x + 1)
                If listDay(x + 2) = "A" Then
                    scheduleBox.Items.Clear()
                    scheduleBox.Items.Add("        TA: 8:40 - 9:45")
                    scheduleBox.Items.Add("Period 1: 9:45 - 10:35")
                    scheduleBox.Items.Add("Period 2: 10:35 - 11:25")
                    scheduleBox.Items.Add("Period 3: 11:25 - 12:15")
                    scheduleBox.Items.Add("   Lunch: 12:15 - 1:10")
                    scheduleBox.Items.Add("Period 4: 1:10 - 2:05")
                    scheduleBox.Items.Add("Period 5: 2:05 - 2:50")
                    lblSchedule.Text = "Extended TA A Schedule"
                ElseIf listDay(x + 2) = "B" Then
                    scheduleBox.Items.Clear()
                    scheduleBox.Items.Add("        TA: 8:40 - 10:10")
                    scheduleBox.Items.Add("Period 1: 10:10 - 10:55")
                    scheduleBox.Items.Add("Period 2: 10:55 - 11:40")
                    scheduleBox.Items.Add("Period 3: 11:40 - 12:25")
                    scheduleBox.Items.Add("   Lunch: 12:25 - 1:20")
                    scheduleBox.Items.Add("Period 4: 1:20 - 2:05")
                    scheduleBox.Items.Add("Period 5: 2:05 - 2:50")
                    lblSchedule.Text = "Extended TA B Schedule"
                ElseIf listDay(x + 2) = "C" Then
                    scheduleBox.Items.Clear()
                    scheduleBox.Items.Add("It is a Day C")
                    scheduleBox.Items.Add("Day " & Str(currentDay) & " schedule.")
                    lblSchedule.Text = ""

                End If
                If currentDay = "E" Then
                    scheduleBox.Items.Clear()
                    scheduleBox.Items.Add("Exam Day")
                    lblSchedule.Text = ""
                ElseIf (currentDay = "A" Or currentDay = "B") Then
                    scheduleBox.Items.Clear()
                    scheduleBox.Items.Add("        TA: 8:40 - 8:55")
                    scheduleBox.Items.Add("Period 1: 9:00 - 10:10")
                    scheduleBox.Items.Add("Period 2: 10:15 - 11:25")
                    scheduleBox.Items.Add("   Lunch: 11:30 - 12:20")
                    scheduleBox.Items.Add("Period 4: 12:25 - 1:35")
                    scheduleBox.Items.Add("Period 5: 1:40 - 2:50")
                    lblSchedule.Text = "Day " & currentDay & " Schedule"
                End If
            End If
        Next

        'If it is a regular day, checks for each teacher's floor time in "Floortimes.txt",
        'and displays them in the listbox.
        If currentDay <> "E" Then
            lblDay.Text = "Day " & currentDay
            For x As Integer = 0 To listFloorTimes.Count - 1
                If listFloorTimes(x) = teacher Then
                    period1 = listFloorTimes(x + Convert.ToInt32(currentDay)).Chars(0)
                    period2 = listFloorTimes(x + Convert.ToInt32(currentDay)).Chars(1)
                    period3 = listFloorTimes(x + Convert.ToInt32(currentDay)).Chars(2)
                    period4 = listFloorTimes(x + Convert.ToInt32(currentDay)).Chars(3)
                    period5 = listFloorTimes(x + Convert.ToInt32(currentDay)).Chars(4)
                End If
            Next
            period1 = FillFloorTimes(period1)
            period2 = FillFloorTimes(period2)
            period3 = FillFloorTimes(period3)
            period4 = FillFloorTimes(period4)
            period5 = FillFloorTimes(period5)

            listBox.Items.Clear()
            listBox.Items.Add(period1 & vbTab & period2 & vbTab & period3 & vbTab & period4 & vbTab & period5)

            'If it is not a regular day, displays what day it is.
        Else
            If (currentDay = "A" Or currentDay = "B") Then
                lblDay.Text = "Day " & currentDay
            Else
                lblDay.Text = "Exam Day"
            End If
            listBox.Items.Clear()
        End If



    End Sub

    '"Floortimes.txt" includes many different letters that we use to represent different floor times, this function
    'returns what to show on the listboxes.
    Private Function FillFloorTimes(ByRef period As String)
        Select Case period
            Case "f"
                Return "F"
            Case "s"
                Return "S"
            Case "t"
                Return "Chapel"
            Case "y"
                Return "JR"
            Case "Z"
                Return "SR"
            Case "q"
                Return "Tech"
            Case "x"
                Return "Math"
            Case "o"
                Return "MathS"
            Case "e"
                Return "Library"
            Case "h"
                Return "Geo"
            Case "n"
                Return "GeoS"
            Case "j"
                Return "ESLRel"
            Case "l"
                Return "ESL"
            Case "r"
                Return "R"
            Case "b"
                Return "B"
            Case "p"
                Return "P"
            Case "c"
                Return "C"
        End Select
    End Function

    'Reset
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        File.WriteAllText("isFirstTime.txt", "True")
        Me.Close()
    End Sub
End Class