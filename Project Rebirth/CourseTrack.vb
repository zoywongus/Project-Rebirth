Imports System.IO

Public Class CourseTrack


    Private Sub btnUnit_Click(sender As Object, e As EventArgs) Handles btnUnit1.Click, btnUnit2.Click, btnUnit3.Click, btnUnit4.Click, _
        btnUnit5.Click, btnUnit6.Click, btnUnit7.Click, btnUnit8.Click, btnUnit9.Click, btnUnit10.Click, btnUnit11.Click, btnUnit12.Click, _
        btnUnit13.Click, btnUnit14.Click, btnUnit15.Click, btnUnit16.Click, btnUnit17.Click

        If sender.BackColor = DefaultBackColor Then
            sender.BackColor = Color.Green
        Else
            sender.BackColor = DefaultBackColor
        End If
    End Sub


End Class
