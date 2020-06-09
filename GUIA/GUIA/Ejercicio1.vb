Public Class Ejercicio1
    Dim operacion As String
    Dim valorResultado As Double
    Dim valor1 As Double
    Dim valor2 As Double

    Private Sub MENUPRINCIPALToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MENUPRINCIPALToolStripMenuItem.Click
        Me.Hide()
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click

        txtBoxNumero.Text = txtBoxNumero.Text & 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        txtBoxNumero.Text = txtBoxNumero.Text & 1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        txtBoxNumero.Text = txtBoxNumero.Text & 2
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        txtBoxNumero.Text = txtBoxNumero.Text & 3
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        txtBoxNumero.Text = txtBoxNumero.Text & 4
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        txtBoxNumero.Text = txtBoxNumero.Text & 5
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        txtBoxNumero.Text = txtBoxNumero.Text & 6
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        txtBoxNumero.Text = txtBoxNumero.Text & 7
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        txtBoxNumero.Text = txtBoxNumero.Text & 8
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        txtBoxNumero.Text = txtBoxNumero.Text & 9
    End Sub

    Public Sub ButtonSuma_Click(sender As Object, e As EventArgs) Handles ButtonSuma.Click

        valor1 = Val(txtBoxNumero.Text)
        operacion = "+"
        txtBoxNumero.Text = ""

    End Sub

    Public Sub ButtonIgual_Click(sender As Object, e As EventArgs) Handles ButtonIgual.Click
        valor2 = Val(txtBoxNumero.Text)
        txtBoxNumero.Clear()
        Select Case operacion
            Case "+"
                valorResultado = valor1 + valor2
                txtBoxHistory.Text = txtBoxHistory.Text & valor1 & "+" & valor2 & "=" & valorResultado & vbCrLf
            Case "-"
                valorResultado = valor1 - valor2
                txtBoxHistory.Text = txtBoxHistory.Text & valor1 & "-" & valor2 & "=" & valorResultado & vbCrLf
            Case "*"
                valorResultado = valor1 * valor2
                txtBoxHistory.Text = txtBoxHistory.Text & valor1 & "*" & valor2 & "=" & valorResultado & vbCrLf
            Case "/"
                If (valor2 <> 0) Then
                    valorResultado = valor1 / valor2
                    txtBoxHistory.Text = txtBoxHistory.Text & valor1 & "/" & valor2 & "=" & valorResultado & vbCrLf
                ElseIf (valor2 = 0) Then
                    MsgBox("Ingrese un divisor que no sea 0")
                End If
        End Select
        txtBoxNumero.Text = valorResultado
        operacion = 0
        txtBoxNumero.Text = ""

    End Sub

    Private Sub ButtonResta_Click(sender As Object, e As EventArgs) Handles ButtonResta.Click

        valor1 = Val(txtBoxNumero.Text)
        operacion = "-"
        txtBoxNumero.Text = ""
    End Sub

    Private Sub ButtonMulti_Click(sender As Object, e As EventArgs) Handles ButtonMulti.Click

        valor1 = Val(txtBoxNumero.Text)
        operacion = "*"
        txtBoxNumero.Text = ""
    End Sub

    Private Sub ButtonDiv_Click(sender As Object, e As EventArgs) Handles ButtonDiv.Click

        valor1 = Val(txtBoxNumero.Text)
        operacion = "/"
        txtBoxNumero.Text = ""
    End Sub


    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        txtBoxNumero.Text = ""
        txtBoxHistory.Text = ""
    End Sub
End Class