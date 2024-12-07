Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.MAGS = NumericUpDown1.Value
        My.Settings.HOME = NumericUpDown2.Value
        My.Settings.compo = TextBox1.Text
        My.Settings.Save()
        Me.Hide()


        TextBox1.Text = My.Settings.compo

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NumericUpDown1.Value = My.Settings.MAGS
        NumericUpDown2.Value = My.Settings.HOME

    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged

    End Sub
End Class