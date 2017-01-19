Imports System.Text.RegularExpressions

Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim Greek As Regex = New Regex("[^\p{IsGreek}]")
        TextBox1.Text = Greek.Replace(TextBox1.Text.ToUpper, "")


    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        'If Not Char.IsLetter(e.KeyChar) Then
        '    e.Handled = True
        'End If


    End Sub


End Class
