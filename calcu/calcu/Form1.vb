Public Class Form1
    Dim a As Integer
    Dim b As Integer
    Dim c As Integer
    Dim d As Integer
    Dim root1 As Single
    Dim root2 As Single



    Private Sub Buttonclickmethod(sender As Object, e As EventArgs) Handles compute.Click, clear.Click, exitIt.Click
        Dim button As Button = CType(sender, Button)
        If button.Name = "compute" Then
            a = textBox1.Text
            b = textBox2.Text
            c = textBox3.Text
            d = (b ^ 2) - (4 * a * c)
            root1 = (-b + Math.Sqrt(d)) / (2 * a)
            root2 = (-b + Math.Sqrt(d)) / (2 * a)
            textRoot1.Text = root1
            textRoot2.Text = root2
        End If
        If button.Name = "clear" Then
            textRoot1.Text = ""
            textRoot2.Text = ""
            textBox1.Text = ""
            textBox2.Text = ""
            textBox3.Text = ""

        End If
        If button.Name = "exitIt" Then

            Application.Exit()
        End If
    End Sub

    Private Sub textBox1_TextChanged(sender As Object, e As EventArgs) Handles textBox1.TextChanged

    End Sub
End Class
