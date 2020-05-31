Public Class ValidarNumero
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bntValidar.Click
        Dim valor As Int16
        If txtNumero.Text = "" Then
            MsgBox("INGRESE VALOR", vbInformation)
        ElseIf Not IsNumeric(txtNumero.Text) Then
            MsgBox("INGRESE VALOR NUMERICO", vbInformation)
            txtNumero.Text = ""
        ElseIf IsNumeric(valor) Then
            valor = Val(txtNumero.Text)
            If valor = 0 Then
                MsgBox("VALOR ES 0", vbInformation)
            ElseIf valor > 0 Then
                MsgBox("POSITIVO")
            ElseIf valor < 0 Then
                MsgBox("NEGATIVO")
            End If
        End If
    End Sub

    Private Sub TxtNumero_TextChanged(sender As Object, e As EventArgs) Handles txtNumero.TextChanged

    End Sub
End Class