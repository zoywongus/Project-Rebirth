Public Class HelpForm

    Private Sub HelpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        default_color()
        inivisible()

    End Sub



    Sub default_color()
        Button1.BackColor = Color.Salmon
        Button2.BackColor = Color.Salmon
        Button3.BackColor = Color.Salmon
        Button4.BackColor = Color.Salmon

    End Sub

    Sub inivisible()
        txtauth.Hide()
        txtflr.Hide()
        txttodo.Hide()
        txttrack.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        default_color()
        inivisible()
        Button1.BackColor = Color.LightSeaGreen
        txtflr.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        default_color()
        inivisible()
        Button2.BackColor = Color.LightSeaGreen
        txtauth.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        default_color()
        inivisible()
        Button3.BackColor = Color.LightSeaGreen
        txttrack.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        default_color()
        inivisible()
        Button4.BackColor = Color.LightSeaGreen
        txttodo.Show()

    End Sub

    Private Sub HelpForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        default_color()
        inivisible()
    End Sub
End Class