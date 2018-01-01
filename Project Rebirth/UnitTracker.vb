Imports System.IO

Public Class UnitTracker
    Private location1Taken As Boolean = False
    Private location2Taken As Boolean = False
    Private location3Taken As Boolean = False
    Private location4Taken As Boolean = False
    Private location5Taken As Boolean = False
    Private location6Taken As Boolean = False
    Private location7Taken As Boolean = False
    Private location8Taken As Boolean = False
    Const location1to4x As Integer = -2
    Const location1and5y As Integer = 30
    Const location2and6y As Integer = 30 + 155
    Const location3and7y As Integer = 30 + 155 * 2
    Const location4and8y As Integer = 30 + 155 * 3
    Const location5to8x As Integer = 545

    Private Sub btnAddCourse_Click(sender As Object, e As EventArgs) Handles btnAddCourse.Click
        Dim numOfCourses As Integer = 0
        For Each Control As Control In Me.Controls
            If TypeOf Control Is CourseTrack Then
                numOfCourses += 1
            End If
        Next

        Dim courseCode As String = InputBox("Add Course", "Enter Course Code and Section" & vbNewLine & "E.g. HRE4M1/05")

        If courseCode <> "" Then
            If courseCode.Length = 9 Then
                If courseCode.Chars(6) = "/" Then
                    Dim CourseBox As New CourseTrack
                    Me.Controls.Add(CourseBox)
                    Me.Size = New Size(547 * 2, 227 + 155 * 3)

                    If location1Taken = False Then
                        CourseBox.Location = New Point(location1to4x, location1and5y)
                        location1Taken = True
                    ElseIf location2Taken = False Then
                        CourseBox.Location = New Point(location1to4x, location2and6y)
                        location2Taken = True
                    ElseIf location3Taken = False Then
                        CourseBox.Location = New Point(location1to4x, location3and7y)
                        location3Taken = True
                    ElseIf location4Taken = False Then
                        CourseBox.Location = New Point(location1to4x, location4and8y)
                        location4Taken = True
                    ElseIf location5Taken = False Then
                        CourseBox.Location = New Point(location5to8x, location1and5y)
                        location5Taken = True
                    ElseIf location6Taken = False Then
                        CourseBox.Location = New Point(location5to8x, location2and6y)
                        location6Taken = True
                    ElseIf location7Taken = False Then
                        CourseBox.Location = New Point(location5to8x, location3and7y)
                        location7Taken = True
                    ElseIf location8Taken = False Then
                        CourseBox.Location = New Point(location5to8x, location4and8y)
                        location8Taken = True
                    End If

                    CourseBox.unitBox.Text = New String(courseCode)

                    If numOfCourses = 7 Then
                        Me.btnAddCourse.Enabled = False
                    End If

                    btnRemoveCourse.Visible = True
                Else
                    MsgBox("Please enter correctly.")
                End If
            Else
                MsgBox("Please enter correctly.")
            End If
        End If
    End Sub

    Sub CreateButton(ByVal groupBox As GroupBox, ByVal button As Button)
        groupBox.Controls.Add(button)
    End Sub

    Private Sub btnRemoveCourse_Click(sender As Object, e As EventArgs) Handles btnRemoveCourse.Click
        Dim courseCode As String = InputBox("Remove Course", "Enter Course Code")
        Dim courseFound As Boolean = False
        If courseCode <> "" Then
            For Each Control As Control In Me.Controls
                If TypeOf Control Is CourseTrack Then
                    For Each childControl As Control In Control.Controls
                        If courseFound = False Then
                            If childControl.Text = courseCode Then
                                CheckLocation(Control)
                                Me.Controls.Remove(Control)
                                courseFound = True
                            End If
                        End If
                    Next
                End If
            Next
        End If

        If courseFound = False And courseCode <> "" Then
            MsgBox("Invalid.")
        Else
            Me.btnAddCourse.Enabled = True
        End If
    End Sub

    Sub CheckLocation(ByVal childControl As Control)
        If childControl.Location.X = location1to4x Then
            If childControl.Location.Y = location1and5y Then
                location1Taken = False
            ElseIf childControl.Location.Y = location2and6y Then
                location2Taken = False
            ElseIf childControl.Location.Y = location3and7y Then
                location3Taken = False
            ElseIf childControl.Location.Y = location4and8y Then
                location4Taken = False
            End If
        ElseIf childControl.Location.X = location5to8x Then
            If childControl.Location.Y = location1and5y Then
                location5Taken = False
            ElseIf childControl.Location.Y = location2and6y Then
                location6Taken = False
            ElseIf childControl.Location.Y = location3and7y Then
                location7Taken = False
            ElseIf childControl.Location.Y = location4and8y Then
                location8Taken = False
            End If
        End If
    End Sub

    Private Sub UnitTracker_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim numberOfCourses As Integer = 0
        
        For Each Control In Me.Controls
            If TypeOf Control Is CourseTrack Then
                numberOfCourses += 1
            End If
        Next

        Dim content(numberOfCourses * 18) As String
        Dim x As Integer = 0

        For Each CourseTrack In Me.Controls.OfType(Of CourseTrack)()
            content(x) = CourseTrack.unitBox.Text
            x += 1

            If CourseTrack.btnUnit1.BackColor = Color.Green Then
                content(x) = "Green"
            Else
                content(x) = "Default"
            End If
            x += 1
            If CourseTrack.btnUnit2.BackColor = Color.Green Then
                content(x) = "Green"
            Else
                content(x) = "Default"
            End If
            x += 1
            If CourseTrack.btnUnit3.BackColor = Color.Green Then
                content(x) = "Green"
            Else
                content(x) = "Default"
            End If
            x += 1
            If CourseTrack.btnUnit4.BackColor = Color.Green Then
                content(x) = "Green"
            Else
                content(x) = "Default"
            End If
            x += 1
            If CourseTrack.btnUnit5.BackColor = Color.Green Then
                content(x) = "Green"
            Else
                content(x) = "Default"
            End If
            x += 1
            If CourseTrack.btnUnit6.BackColor = Color.Green Then
                content(x) = "Green"
            Else
                content(x) = "Default"
            End If
            x += 1
            If CourseTrack.btnUnit7.BackColor = Color.Green Then
                content(x) = "Green"
            Else
                content(x) = "Default"
            End If
            x += 1
            If CourseTrack.btnUnit8.BackColor = Color.Green Then
                content(x) = "Green"
            Else
                content(x) = "Default"
            End If
            x += 1
            If CourseTrack.btnUnit9.BackColor = Color.Green Then
                content(x) = "Green"
            Else
                content(x) = "Default"
            End If
            x += 1
            If CourseTrack.btnUnit10.BackColor = Color.Green Then
                content(x) = "Green"
            Else
                content(x) = "Default"
            End If
            x += 1
            If CourseTrack.btnUnit11.BackColor = Color.Green Then
                content(x) = "Green"
            Else
                content(x) = "Default"
            End If
            x += 1
            If CourseTrack.btnUnit12.BackColor = Color.Green Then
                content(x) = "Green"
            Else
                content(x) = "Default"
            End If
            x += 1
            If CourseTrack.btnUnit13.BackColor = Color.Green Then
                content(x) = "Green"
            Else
                content(x) = "Default"
            End If
            x += 1
            If CourseTrack.btnUnit14.BackColor = Color.Green Then
                content(x) = "Green"
            Else
                content(x) = "Default"
            End If
            x += 1
            If CourseTrack.btnUnit15.BackColor = Color.Green Then
                content(x) = "Green"
            Else
                content(x) = "Default"
            End If
            x += 1
            If CourseTrack.btnUnit16.BackColor = Color.Green Then
                content(x) = "Green"
            Else
                content(x) = "Default"
            End If
            x += 1
            If CourseTrack.btnUnit17.BackColor = Color.Green Then
                content(x) = "Green"
            Else
                content(x) = "Default"
            End If
            x += 1
        Next

        File.WriteAllLines("UnitTracker.txt", content)
        File.WriteAllLines("UnitTracker.txt", File.ReadAllLines("UnitTracker.txt").Where(Function(s) s <> String.Empty))

    End Sub

    Private Sub UnitTracker_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim fileReader As New System.IO.StreamReader("UnitTracker.txt")
        Dim content() As String = File.ReadAllLines("UnitTracker.txt")

        If content.Length <> 0 Then
            If content(0) <> "" Then
                Me.Size = New Size(547 * 2, 227 + 155 * 3)

                While fileReader.Peek() <> -1
                    Dim CourseBox As New CourseTrack
                    Me.Controls.Add(CourseBox)
                    CourseBox.unitBox.Text = fileReader.ReadLine()
                    If fileReader.ReadLine() = "Green" Then
                        CourseBox.btnUnit1.BackColor = Color.Green
                    Else
                        CourseBox.btnUnit1.BackColor = DefaultBackColor
                    End If
                    If fileReader.ReadLine() = "Green" Then
                        CourseBox.btnUnit2.BackColor = Color.Green
                    Else
                        CourseBox.btnUnit2.BackColor = DefaultBackColor
                    End If
                    If fileReader.ReadLine() = "Green" Then
                        CourseBox.btnUnit3.BackColor = Color.Green
                    Else
                        CourseBox.btnUnit3.BackColor = DefaultBackColor
                    End If
                    If fileReader.ReadLine() = "Green" Then
                        CourseBox.btnUnit4.BackColor = Color.Green
                    Else
                        CourseBox.btnUnit4.BackColor = DefaultBackColor
                    End If
                    If fileReader.ReadLine() = "Green" Then
                        CourseBox.btnUnit5.BackColor = Color.Green
                    Else
                        CourseBox.btnUnit5.BackColor = DefaultBackColor
                    End If
                    If fileReader.ReadLine() = "Green" Then
                        CourseBox.btnUnit6.BackColor = Color.Green
                    Else
                        CourseBox.btnUnit6.BackColor = DefaultBackColor
                    End If
                    If fileReader.ReadLine() = "Green" Then
                        CourseBox.btnUnit7.BackColor = Color.Green
                    Else
                        CourseBox.btnUnit7.BackColor = DefaultBackColor
                    End If
                    If fileReader.ReadLine() = "Green" Then
                        CourseBox.btnUnit8.BackColor = Color.Green
                    Else
                        CourseBox.btnUnit8.BackColor = DefaultBackColor
                    End If
                    If fileReader.ReadLine() = "Green" Then
                        CourseBox.btnUnit9.BackColor = Color.Green
                    Else
                        CourseBox.btnUnit9.BackColor = DefaultBackColor
                    End If
                    If fileReader.ReadLine() = "Green" Then
                        CourseBox.btnUnit10.BackColor = Color.Green
                    Else
                        CourseBox.btnUnit10.BackColor = DefaultBackColor
                    End If
                    If fileReader.ReadLine() = "Green" Then
                        CourseBox.btnUnit11.BackColor = Color.Green
                    Else
                        CourseBox.btnUnit11.BackColor = DefaultBackColor
                    End If
                    If fileReader.ReadLine() = "Green" Then
                        CourseBox.btnUnit12.BackColor = Color.Green
                    Else
                        CourseBox.btnUnit12.BackColor = DefaultBackColor
                    End If
                    If fileReader.ReadLine() = "Green" Then
                        CourseBox.btnUnit13.BackColor = Color.Green
                    Else
                        CourseBox.btnUnit13.BackColor = DefaultBackColor
                    End If
                    If fileReader.ReadLine() = "Green" Then
                        CourseBox.btnUnit14.BackColor = Color.Green
                    Else
                        CourseBox.btnUnit14.BackColor = DefaultBackColor
                    End If
                    If fileReader.ReadLine() = "Green" Then
                        CourseBox.btnUnit15.BackColor = Color.Green
                    Else
                        CourseBox.btnUnit15.BackColor = DefaultBackColor
                    End If
                    If fileReader.ReadLine() = "Green" Then
                        CourseBox.btnUnit16.BackColor = Color.Green
                    Else
                        CourseBox.btnUnit16.BackColor = DefaultBackColor
                    End If
                    If fileReader.ReadLine() = "Green" Then
                        CourseBox.btnUnit17.BackColor = Color.Green
                    Else
                        CourseBox.btnUnit17.BackColor = DefaultBackColor
                    End If

                    If location1Taken = False Then
                        CourseBox.Location = New Point(location1to4x, location1and5y)
                        location1Taken = True
                    ElseIf location2Taken = False Then
                        CourseBox.Location = New Point(location1to4x, location2and6y)
                        location2Taken = True
                    ElseIf location3Taken = False Then
                        CourseBox.Location = New Point(location1to4x, location3and7y)
                        location3Taken = True
                    ElseIf location4Taken = False Then
                        CourseBox.Location = New Point(location1to4x, location4and8y)
                        location4Taken = True
                    ElseIf location5Taken = False Then
                        CourseBox.Location = New Point(location5to8x, location1and5y)
                        location5Taken = True
                    ElseIf location6Taken = False Then
                        CourseBox.Location = New Point(location5to8x, location2and6y)
                        location6Taken = True
                    ElseIf location7Taken = False Then
                        CourseBox.Location = New Point(location5to8x, location3and7y)
                        location7Taken = True
                    ElseIf location8Taken = False Then
                        CourseBox.Location = New Point(location5to8x, location4and8y)
                        location8Taken = True
                    End If


                End While
            End If
        End If
        fileReader.Close()

        Dim numOfCourse As Integer = 0
        For Each Control As Control In Me.Controls
            If TypeOf Control Is CourseTrack Then
                numOfCourse += 1
            End If
        Next

        If numOfCourse > 0 Then
            Me.btnRemoveCourse.Visible = True
        End If

        If numOfCourse = 8 Then
            Me.btnAddCourse.Enabled = False
        End If
    End Sub

End Class