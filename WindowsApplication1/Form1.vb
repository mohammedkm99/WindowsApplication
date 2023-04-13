Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' حساب مساحة الدائرة
        Dim radius As Double = CDbl(TextBox1.Text)
        Dim area As Double = 3.14 * radius * radius
        TextBox2.Text = area.ToString()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class
