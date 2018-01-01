Imports System.IO

Public Class SelectTeachers

    'All the following subroutines just make sure that the user selects the teachers one at a time.
    Private Sub SlctTeacherBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SlctTeacherBox1.SelectedIndexChanged
        SlctTeacherBox2.Enabled = True
    End Sub

    Private Sub SlctTeacherBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SlctTeacherBox2.SelectedIndexChanged
        SlctTeacherBox3.Enabled = True
    End Sub

    Private Sub SlctTeacherBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SlctTeacherBox3.SelectedIndexChanged
        SlctTeacherBox4.Enabled = True
    End Sub

    Private Sub SlctTeacherBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SlctTeacherBox4.SelectedIndexChanged
        SlctTeacherBox5.Enabled = True
    End Sub

    'If the user selects "---Not Applicable---", the Submit Teacher button is enabled.
    'Otherwise, the next button enables and same thing happens.
    Private Sub SlctTeacherBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SlctTeacherBox5.SelectedIndexChanged
        If SlctTeacherBox5.SelectedIndex = 0 Then
            btnSubmitTeachers.Enabled = True
            SlctTeacherBox6.Text = Nothing
            SlctTeacherBox7.Text = Nothing
            SlctTeacherBox8.Text = Nothing
            SlctTeacherBox6.Enabled = False
            SlctTeacherBox7.Enabled = False
            SlctTeacherBox8.Enabled = False
        Else
            SlctTeacherBox6.Enabled = True
        End If
    End Sub

    Private Sub SlctTeacherBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SlctTeacherBox6.SelectedIndexChanged
        If SlctTeacherBox6.SelectedIndex = 0 Then
            btnSubmitTeachers.Enabled = True
            SlctTeacherBox7.Text = Nothing
            SlctTeacherBox8.Text = Nothing
            SlctTeacherBox7.Enabled = False
            SlctTeacherBox8.Enabled = False
        Else
            SlctTeacherBox7.Enabled = True
        End If
    End Sub

    Private Sub SlctTeacherBox7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SlctTeacherBox7.SelectedIndexChanged
        If SlctTeacherBox7.SelectedIndex = 0 Then
            btnSubmitTeachers.Enabled = True
            SlctTeacherBox8.Text = Nothing
            SlctTeacherBox8.Enabled = False
        Else
            SlctTeacherBox8.Enabled = True
        End If
    End Sub

    Private Sub SlctTeacherBox8_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SlctTeacherBox8.SelectedIndexChanged
        If SlctTeacherBox8.SelectedIndex > -1 Then
            btnSubmitTeachers.Enabled = True
        End If
    End Sub

    'Save all teachers' names in 'teachers.txt", and sets isFirstTime to false.
    'Then displays the FloorTimes form.
    Private Sub btnSubmitTeachers_Click(sender As Object, e As EventArgs) Handles btnSubmitTeachers.Click
        Dim teachers(7) As String
        teachers(0) = SlctTeacherBox1.Text
        teachers(1) = SlctTeacherBox2.Text
        teachers(2) = SlctTeacherBox3.Text
        teachers(3) = SlctTeacherBox4.Text

        If SlctTeacherBox5.SelectedIndex > 0 Then
            teachers(4) = SlctTeacherBox5.Text
        End If
        If SlctTeacherBox6.SelectedIndex > 0 Then
            teachers(5) = SlctTeacherBox6.Text
        End If
        If SlctTeacherBox7.SelectedIndex > 0 Then
            teachers(6) = SlctTeacherBox7.Text
        End If
        If SlctTeacherBox8.SelectedIndex > 0 Then
            teachers(7) = SlctTeacherBox8.Text
        End If

        ReDim Preserve teachers(teachers.Length - 1)

        File.WriteAllLines("teachers.txt", teachers)
        File.WriteAllLines("teachers.txt", File.ReadAllLines("teachers.txt").Where(Function(s) s <> String.Empty))

        File.WriteAllText("isFirstTime.txt", "False")
        FloorTimes.Show()
        Me.Close()
    End Sub
End Class