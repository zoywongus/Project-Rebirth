Imports System.IO

Public Class ToDoList
    Private dragging As Boolean
    Private beginX, beginY As Integer
    Private mouseClicked As Boolean = False

    Private Sub Sticky_MouseMove(sender As Object, e As MouseEventArgs)
        sender.BringToFront()
        OBJ_Resize.ResizeOBJ(sender, e, Me)
    End Sub

    Private Sub btnAddSticky_Click(sender As Object, e As EventArgs) Handles btnAddSticky.Click
        Static count As Integer

        Dim newSticky As New TextBox
        count += 1
        newSticky.Name = "StickyNote" & count
        newSticky.Multiline = True
        newSticky.Size = New Size(130, 130)
        newSticky.Font = New Font("Microsoft Sans Serif", 14)
        AddHandler newSticky.MouseMove, AddressOf Sticky_MouseMove
        AddHandler newSticky.MouseDoubleClick, AddressOf Sticky_MouseDoubleClick
        AddHandler newSticky.Click, AddressOf Sticky_Click

        Me.Controls.Add(newSticky)


    End Sub

    Private Sub ToDoList_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'If e.CloseReason = CloseReason.UserClosing Then
        'e.Cancel = True
        'Me.Hide()
        'End If
        File.WriteAllText("StickyNotes.txt", "")

        For Each Control As Control In Me.Controls
            If TypeOf Control Is TextBox Then
                Using sw As StreamWriter = File.AppendText("StickyNotes.txt")
                    sw.WriteLine(Control.Name)
                    If Control.Text = Nothing Then
                        sw.WriteLine()
                    Else
                        sw.WriteLine(Control.Text)
                    End If
                    sw.WriteLine(Control.Size)
                    sw.WriteLine(Control.Location)
                End Using
            End If
        Next
    End Sub

    Private Sub Sticky_Click(sender As Object, e As MouseEventArgs)
        sender.BringToFront()
    End Sub

    Private Sub Sticky_MouseDoubleClick(sender As Object, e As MouseEventArgs)
        Dim content() As String = File.ReadAllLines("StickyNotes.txt")
        Dim list As List(Of String) = content.ToList

        Dim mySticky As TextBox = CType(sender, TextBox)
        Dim stickyName As String = mySticky.Name

        For x As Integer = 0 To list.Count - 1
            If list.Count > 0 Then
                If list(x) = stickyName Then
                    list.RemoveAt(x + 3)
                    list.RemoveAt(x + 2)
                    list.RemoveAt(x + 1)
                    list.RemoveAt(x)
                    Exit For
                End If
            End If
        Next
        File.WriteAllLines("StickyNotes.txt", list)
        Me.Controls.Remove(sender)
    End Sub

    Private Sub ToDoList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim content() As String = File.ReadAllLines("StickyNotes.txt")
        Dim sticky As New TextBox
        If content.Length <> -1 Then
            For x As Integer = 0 To content.Length - 1
                If content(x).Length > 10 Then
                    If content(x).Substring(0, 10) = "StickyNote" Then
                        LoadStickyNotes(x)
                    End If
                End If
            Next
        End If
    End Sub

    Sub LoadStickyNotes(ByVal x As Integer)
        Dim start As Integer = x
        Dim content() As String = File.ReadAllLines("StickyNotes.txt")
        Dim sticky As New TextBox
        sticky.Name = content(x)
        sticky.Text = content(x + 1)

        For counter As Integer = x + 2 To content.Length - 1
            If content(counter).Length < 6 Or content(counter) = "" Then
                x += 1
            ElseIf content(counter).Length > 6 And content(counter).Substring(0, 6) <> "{Width" Then
                x += 1
            ElseIf content(counter).Length > 6 And content(counter).Substring(0, 6) = "{Width" Then
                x = counter
                Exit For
            End If
        Next

        For counter2 As Integer = start + 2 To x - 1
            sticky.Text = sticky.Text & vbNewLine & content(counter2)
        Next
        sticky.Size = GetPoints(content(x), "Size")
        sticky.Location = GetPoints(content(x + 1), "Location")
        sticky.Multiline = True
        sticky.Font = New Font("Microsoft Sans Serif", 14)
        AddHandler sticky.MouseMove, AddressOf Sticky_MouseMove
        AddHandler sticky.MouseDoubleClick, AddressOf Sticky_MouseDoubleClick
        AddHandler sticky.Click, AddressOf Sticky_Click
        Me.Controls.Add(sticky)
    End Sub


    Function GetPoints(ByVal Line As String, ByVal requirement As String)
        Dim xcoordinate As String = ""
        Dim ycoordinate As String = ""
        Dim x As Integer = 0
        While Line.Chars(x) <> "="
            x += 1
        End While
        x += 1

        While Line.Chars(x) <> ","
            xcoordinate = xcoordinate & Line.Chars(x)
            x += 1
        End While
        x += 1

        While Line.Chars(x) <> "="
            x += 1
        End While
        x += 1

        While Line.Chars(x) <> "}"
            ycoordinate = ycoordinate & Line.Chars(x)
            x += 1
        End While

        If requirement = "Size" Then
            Return New Size(Int(xcoordinate), Int(ycoordinate))
        Else
            Return New Point(Int(xcoordinate), Int(ycoordinate))
        End If

    End Function
End Class