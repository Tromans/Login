Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As String = Userbox.Text
        Dim y As String = PassBox.Text
        If x = ("CCLC") And y = ("Summer17") Then
            MsgBox("Welcome to the Matrix")
        Else
            MsgBox("You are incorrect")
        End If

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim webadress As String = "//www.google.com/doodles/"
        Process.Start(webadress)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
