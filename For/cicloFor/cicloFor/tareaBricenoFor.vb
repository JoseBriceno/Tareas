Public Class tareaBricenoFor
    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        End
    End Sub

    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        Dim num As Integer
        Dim x As Integer
        num = txtNumero.Text

        For x = 1 To 12
            ListBox1.Items.Add(num * x)

        Next x
    End Sub
End Class
