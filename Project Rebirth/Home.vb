Imports System.IO

Public Class Home
    'Shows the SelectTeacher form when it is the user's first time
    'Shows the FloorTimes form otherwise.
    Private Sub btnFloorTimes_Click(sender As Object, e As EventArgs) Handles btnFloorTimes.Click
        Dim content() As String = File.ReadAllLines("isFirstTime.txt")
        Dim isFirstTime As String = content(0)

        If isFirstTime = "True" Then
            SelectTeachers.Show()
        Else
            FloorTimes.Show()
        End If

    End Sub

    'Shows the TestAuthorizations form
    Private Sub btnTestAuthorizations_Click(sender As Object, e As EventArgs) Handles btnTestAuthorizations.Click
        TestAuthorizations.Show()
    End Sub

    'Reads through "TestAuthorizations.txt", then checks if any tests expire on the current day.
    Private Sub Home_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim content() As String = File.ReadAllLines("TestAuthorizations.txt")
        Dim list As List(Of String) = content.ToList
        Dim ExpiryDate As String
        Dim courseCode As String
        For x As Integer = 0 To content.Length - 1
            ExpiryDate = list(x).Substring(20, 5)
            ExpiryDate = ExpiryDate.Replace("/", "-")
            ExpiryDate = ExpiryDate & "-2017"
            courseCode = list(x).Substring(0, 6)

            If ExpiryDate = DateString Then
                MsgBox("Your " & courseCode & " test expires today!")
            End If
        Next

        'Tells you how many days left until graduation
        Dim gradDate As New System.DateTime(2017, 6, 29)
        Dim daysLeft As Integer = DateDiff(DateInterval.Day, Today, gradDate)
        lblDaysLeft.Text = Str(daysLeft) & " days left until graduation!"
    End Sub

    'Shows the ToDoList form
    Private Sub btnToDo_Click(sender As Object, e As EventArgs) Handles btnToDo.Click
        ToDoList.Show()
    End Sub

    'Shows the UnitTracker form
    Private Sub btnUnitTracker_Click(sender As Object, e As EventArgs) Handles btnUnitTracker.Click
        UnitTracker.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        HelpForm.Show()

    End Sub
End Class
