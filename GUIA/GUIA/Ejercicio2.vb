Public Class Ejercicio2
    Private Sub MENUPRINCIPALToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MENUPRINCIPALToolStripMenuItem.Click
        Me.Hide()
    End Sub

    Private Sub ButtonCalcular_Click(sender As Object, e As EventArgs) Handles ButtonCalcular.Click
        Dim a, b, c, result1, result2 As Double
        Dim comprobar As Double
        a = Val(txtBoXA.Text)
        b = Val(TextBoxB.Text)
        c = Val(TextBoxC.Text)
        comprobar = (b ^ 2) - ((4 * a) * c)
        If comprobar < 0 Then
            MessageBox.Show("NO EXISTE RESULTADO")
        Else
            result1 = ((-1 * b) + (comprobar ^ (0.5))) / (2 * a)
            result2 = ((-1 * b) - (comprobar ^ (0.5))) / (2 * a)
            TextBoxRESULT1.Text = result1
            TextBoxRESULT2.Text = result2

        End If
    End Sub

    Private Sub ButtonClean_Click(sender As Object, e As EventArgs) Handles ButtonClean.Click
        TextBoxB.Text = ""
        TextBoxC.Text = ""
        txtBoXA.Text = ""
        TextBoxRESULT1.Text = ""
        TextBoxRESULT2.Text = ""

    End Sub
End Class