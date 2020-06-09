Public Class Ejercicio3
    Private almacenes(10) As Double
    Private acumular As Integer
    Private Sub MENUPRINCIPALToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MENUPRINCIPALToolStripMenuItem.Click
        Me.Hide()
    End Sub

    Private Sub ButtonIngresar_Click(sender As Object, e As EventArgs) Handles ButtonIngresar.Click


        If acumular < 10 Then
            almacenes(acumular) = Val(txtBoxTotalVentas.Text)
            txtBoxTotalVentas.Text = ""
            acumular += 1
        Else
            MessageBox.Show("YA INGRESO 10 ALMACENES")
        End If


    End Sub

    Private Sub ButtonMostrar_Click(sender As Object, e As EventArgs) Handles ButtonMostrar.Click
        Dim promedio As Double
        Dim suma As Double

        For i As Integer = 0 To 10
            suma = suma + almacenes(i)
        Next
        promedio = suma / 10
        Dim superiores(10) As String
        Dim x As Integer

        For i As Integer = 0 To 10
            If almacenes(i) > promedio Then
                superiores(x) = "Almacen: " & i + 1
                txtSuperiores.Text = txtSuperiores.Text & superiores(x) & " "
                x = x + 1

            End If

        Next


    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click

    End Sub
End Class