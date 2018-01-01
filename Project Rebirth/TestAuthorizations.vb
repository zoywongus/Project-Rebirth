Imports System.IO

Public Class TestAuthorizations
    'Gets user's test authorization info
    Private Sub btnAddTest_Click(sender As Object, e As EventArgs) Handles btnAddTest.Click
        Dim correctCourseSection As Boolean = False
        Dim correctUnitNum As Boolean = False
        Dim correctTestNum As Boolean = False
        Dim correctExpiryDate As Boolean = False

        Dim CourseSection As String = InputBox("Enter Course Code and Section Number" & vbNewLine & "[Course_Code]/[Section Number]:", "Course/Section")
        If CourseSection <> "" Then
            While correctCourseSection = False
                While CourseSection.Length = 9 And correctCourseSection = False
                    If CourseSection.Chars(6) <> "/" Then
                        MsgBox("Please enter it correctly. E.g. HRE4M1/05")
                        CourseSection = InputBox("Enter Course Code and Section Number" & vbNewLine & "[Course_Code]/[Section Number]:", "Course/Section")
                    Else
                        correctCourseSection = True
                    End If
                End While

                While CourseSection.Length <> 9
                    MsgBox("Please enter it correctly. E.g. HRE4M1/05")
                    CourseSection = InputBox("Enter Course Code and Section Number" & vbNewLine & "[Course_Code]/[Section Number]:", "Course/Section")
                End While
            End While
            CourseSection = CourseSection.ToUpper()
            Dim UnitNum As String = InputBox("Enter Unit Number: ", "Unit Number")
            While correctUnitNum = False
                If UnitNum <> "" Then
                    While IsNumeric(UnitNum) <> True
                        MsgBox("Please enter a valid unit number. E.g. 02")
                        UnitNum = InputBox("Enter Unit Number: ", "Unit Number")
                    End While

                    If IsNumeric(UnitNum) Then
                        While UnitNum.Length <> 2 Or UnitNum > 18 Or UnitNum < 1
                            MsgBox("Please enter a valid unit number. E.g. 02")
                            UnitNum = InputBox("Enter Unit Number: ", "Unit Number")
                        End While
                    End If
                    correctUnitNum = True
                Else
                    Exit Sub
                End If
            End While
            Dim TestNumber As String = InputBox("Enter Test Authorization Number", "Test Number")
            While correctTestNum = False
                If TestNumber <> "" Then
                    While TestNumber.Length <> 6 Or IsNumeric(TestNumber) <> True
                        MsgBox("Please enter a valid test number.")
                        TestNumber = InputBox("Enter Test Authorization Number", "Test Number")
                    End While
                    correctTestNum = True
                Else
                    Exit Sub
                End If
            End While
            Dim ExpiryDate As String = InputBox("Enter Expiry Date (MM/DD):", "Expiry Date")
            If ExpiryDate <> "" Then
                While correctExpiryDate = False
                    While ExpiryDate.Length <> 5
                        MsgBox("Please enter it correctly. E.g. 11/24")
                        ExpiryDate = InputBox("Enter Expiry Date (MM/DD):", "Expiry Date")
                    End While

                    While ExpiryDate.Chars(2) <> "/"
                        MsgBox("Please enter it correctly. E.g. 11/24")
                        ExpiryDate = InputBox("Enter Expiry Date (MM/DD):", "Expiry Date")
                    End While

                    While IsNumeric(ExpiryDate.Substring(0, 2)) <> True Or IsNumeric(ExpiryDate.Substring(3, 2)) <> True
                        MsgBox("Please enter it correctly. E.g. 11/24")
                        ExpiryDate = InputBox("Enter Expiry Date (MM/DD):", "Expiry Date")
                    End While

                    While Val(ExpiryDate.Substring(0, 2)) < 1 Or Val(ExpiryDate.Substring(0, 2)) > 12 Or Val(ExpiryDate.Substring(3, 2)) < 1 Or Val(ExpiryDate.Substring(3, 2)) > 31
                        MsgBox("Please enter it correctly. E.g. 11/24")
                        ExpiryDate = InputBox("Enter Expiry Date (MM/DD):", "Expiry Date")
                    End While
                    correctExpiryDate = True
                End While

                Dim ExpiryDateAsDate As Date = Date.Parse(ExpiryDate)

                Dim daysTillExpire As Integer
                Dim status As String

                'Checks how many days left until the test expires
                If Today < ExpiryDateAsDate Then
                    daysTillExpire = DateDiff(DateInterval.Day, Today, ExpiryDateAsDate)
                    status = Str(daysTillExpire) & " days left"
                ElseIf Today = ExpiryDateAsDate Then
                    daysTillExpire = 0
                    status = Str(daysTillExpire) & " days left"
                Else
                    status = " Expired"
                End If

                'Adds the test authorization
                Dim newEntry As String = CourseSection & vbTab & UnitNum & vbTab & TestNumber & vbTab & ExpiryDate
                TestList.Items.Add(newEntry & vbTab & status)

                'Saves the test authorizations in "TestAuthorizations.txt"
                Using sw As StreamWriter = File.AppendText("TestAuthorizations.txt")
                    sw.WriteLine(newEntry)
                End Using
                File.WriteAllLines("TestAuthorizations.txt", File.ReadAllLines("TestAuthorizations.txt").Where(Function(s) s <> String.Empty))
            End If
        End If


    End Sub

    'Removes the test authorization from the listbox, and from "TestAuthorizations.txt"
    Private Sub btnRemoveTest_Click(sender As Object, e As EventArgs) Handles btnRemoveTest.Click
        Dim content() As String = File.ReadAllLines("TestAuthorizations.txt")
        Dim list As List(Of String) = content.ToList
        Try
            list.RemoveAt(TestList.SelectedIndex)
            File.WriteAllLines("TestAuthorizations.txt", list)
            TestList.Items.Remove(TestList.SelectedItem)
        Catch ex As System.ArgumentOutOfRangeException
            MsgBox("Please select a test authorization")
        End Try
    End Sub

    'Every time the form loads, it reads through "TestAuthorizations.txt", and updates the expiry date status for each
    'test authorization, and adds them to the list.
    Private Sub TestAuthorizations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim content() As String = File.ReadAllLines("TestAuthorizations.txt")
        Dim status As String
        Dim daysTillExpire As Integer
        Dim expiryDate As String
        Dim expiryDateAsDate As Date
        For x As Integer = 0 To content.Length - 1
            expiryDate = content(x).Substring(20, 5)
            expiryDateAsDate = Date.Parse(expiryDate)
            If Today < expiryDateAsDate Then
                daysTillExpire = DateDiff(DateInterval.Day, Today, expiryDateAsDate)
                status = Str(daysTillExpire) & " days left"
            ElseIf Today = expiryDateAsDate Then
                daysTillExpire = 0
                status = Str(daysTillExpire) & " days left"
            Else
                status = " Expired"
            End If
            TestList.Items.Add(content(x) & vbTab & status)
        Next
    End Sub
End Class