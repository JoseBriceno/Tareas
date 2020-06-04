Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnJugar_Click(sender As Object, e As EventArgs) Handles btnJugar.Click
        Dim valor As Int16
        Dim x As Integer
        Dim MyValue As Integer
        Dim contadorGano As Integer
        Dim contadorPerdio As Integer

        Try
            If txtNombre.Text = "" Then
                MsgBox("INGRESE UN NOMBRE", vbInformation)
            End If
            If txtPartidos.Text = "" Then
                MsgBox("INGRESE VALOR", vbInformation)
            ElseIf Not IsNumeric(txtPartidos.Text) Then
                MsgBox("INGRESE VALOR NUMERICO", vbInformation)
                txtPartidos.Text = ""
            ElseIf IsNumeric(valor) Then
                valor = Val(txtPartidos.Text)
                If valor = 0 Then
                    MsgBox("VALOR ES 0", vbInformation)
                End If
            End If

            For x = 1 To valor Step 1
                MyValue = Int((2 * Rnd()))
                Select Case MyValue
                    Case 0
                        ListBox1.Items.Add(txtNombre.Text & ":PERDIO")
                        contadorPerdio += 1
                    Case 1
                        ListBox1.Items.Add(txtNombre.Text & ":GANO")
                        contadorGano += 1
                End Select

            Next

            ListBox1.Items.Add("")
            ListBox1.Items.Add("PARTIDOS GANADOS:" & contadorGano)
            ListBox1.Items.Add("")
            ListBox1.Items.Add("PARTIDOS PERDIDOS:" & contadorPerdio)

        Catch ex As Exception
            MessageBox.Show("ERROR 504")
        End Try
        If contadorGano > contadorPerdio Then
            MessageBox.Show(txtNombre.Text & " CAMPEONES!!")
        ElseIf contadorPerdio > contadorGano Then
            MessageBox.Show(txtNombre.Text & " LOSER!!")
        ElseIf contadorGano = contadorPerdio Then
            MessageBox.Show("AMBECES TE VA BIEN Y AMBECES TE VA MAL...")
        End If
    End Sub

    Private Sub btnLimpia_Click(sender As Object, e As EventArgs) Handles btnLimpia.Click
        txtNombre.Clear()
        txtPartidos.Clear()
        ListBox1.Items.Clear()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class
