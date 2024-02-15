Public Class Form1
    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        Try
            Dim Firstnum As Integer
            Dim Secondnum As Integer

            Firstnum = txtFirstnum.Text
            Secondnum = txtSecondnum.Text

            lblResult.Text = Firstnum / Secondnum

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class
