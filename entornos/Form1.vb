Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Public Sub BtnCalcular_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtValor1.Clear()
        txtValor2.Clear()
        txtResta.Clear()
        txtSuma.Clear()
        txtMulti.Clear()
        txtDiv.Clear()
        txtRaiz.Clear()
        txtPotencia.Clear()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Public Sub CheckBoxSUMA_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxSUMA.CheckedChanged
        If Not IsNumeric(txtValor1.Text) Or txtValor1.Text = "" Then
            MsgBox("INGRESE VALOR NUMERICO", vbInformation)
            txtValor1.Clear()
            txtValor2.Clear()

        End If
        If Not IsNumeric(txtValor2.Text) Or txtValor2.Text = "" Then
            MsgBox("INGRESE VALOR NUMERICO", vbInformation)
            txtValor1.Clear()
            txtValor2.Clear()

        End If

        Dim Valor1 As Integer
        Dim Valor2 As Integer
        Dim Suma As Integer

        Valor1 = Val(txtValor1.Text)
        Valor2 = Val(txtValor2.Text)

        Suma = Valor1 + Valor2
        txtSuma.Text = Suma
    End Sub

    Public Sub CheckBoxRESTA_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxRESTA.CheckedChanged
        If Not IsNumeric(txtValor1.Text) Or txtValor1.Text = "" Then
            MsgBox("INGRESE VALOR NUMERICO", vbInformation)
            txtValor1.Clear()
            txtValor2.Clear()
            End
        End If
        If Not IsNumeric(txtValor2.Text) Or txtValor2.Text = "" Then
            MsgBox("INGRESE VALOR NUMERICO", vbInformation)
            txtValor1.Clear()
            txtValor2.Clear()
            End
        End If
        Dim Valor1 As Integer
        Dim Valor2 As Integer
        Dim Resta As Integer

        Valor1 = Val(txtValor1.Text)
        Valor2 = Val(txtValor2.Text)

        Resta = Valor1 - Valor2
        txtResta.Text = Resta
    End Sub

    Public Sub CheckBoxMULTI_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxMULTI.CheckedChanged
        If Not IsNumeric(txtValor1.Text) Or txtValor1.Text = "" Then
            MsgBox("INGRESE VALOR NUMERICO", vbInformation)
            txtValor1.Clear()
            txtValor2.Clear()
            End
        End If
        If Not IsNumeric(txtValor2.Text) Or txtValor2.Text = "" Then
            MsgBox("INGRESE VALOR NUMERICO", vbInformation)
            txtValor1.Clear()
            txtValor2.Clear()
            End
        End If
        Dim Valor1 As Integer
        Dim Valor2 As Integer
        Dim Multi As Integer

        Valor1 = Val(txtValor1.Text)
        Valor2 = Val(txtValor2.Text)

        Multi = Valor1 * Valor2
        txtMulti.Text = Multi
    End Sub

    Public Sub CheckBoDIV_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoDIV.CheckedChanged
        If Not IsNumeric(txtValor1.Text) Or txtValor1.Text = "" Then
            MsgBox("INGRESE VALOR NUMERICO", vbInformation)
            txtValor1.Clear()
            txtValor2.Clear()
            End
        End If
        If Not IsNumeric(txtValor2.Text) Or txtValor2.Text = "" Then
            MsgBox("INGRESE VALOR NUMERICO", vbInformation)
            txtValor1.Clear()
            txtValor2.Clear()
            End
        End If
        Dim Valor1 As Integer
        Dim Valor2 As Integer
        Dim Div As Double

        Valor1 = Val(txtValor1.Text)
        Valor2 = Val(txtValor2.Text)

        If Valor2 = 0 Then
            MsgBox("ERROR EN LA DIVISION")
            txtDiv.Text = "ERROR"
        Else
            Div = Valor1 / Valor2
            txtDiv.Text = Div
        End If


    End Sub

    Public Sub CheckBox1POTENCIA_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1POTENCIA.CheckedChanged
        If Not IsNumeric(txtValor1.Text) Or txtValor1.Text = "" Then
            MsgBox("INGRESE VALOR NUMERICO", vbInformation)
            txtValor1.Clear()
            txtValor2.Clear()
            End
        End If
        If Not IsNumeric(txtValor2.Text) Or txtValor2.Text = "" Then
            MsgBox("INGRESE VALOR NUMERICO", vbInformation)
            txtValor1.Clear()
            txtValor2.Clear()
            End
        End If
        Dim Valor1 As Integer
        Dim Valor2 As Integer
        Dim Potencia As Integer

        Valor1 = Val(txtValor1.Text)
        Valor2 = Val(txtValor2.Text)

        Potencia = Valor1 ^ Valor2
        txtPotencia.Text = Potencia

    End Sub

    Private Sub CheckBoxRAIZ_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxRAIZ.CheckedChanged
        If Not IsNumeric(txtValor1.Text) Or txtValor1.Text = "" Then
            MsgBox("INGRESE VALOR NUMERICO", vbInformation)
            txtValor1.Clear()
            txtValor2.Clear()
            End
        End If
        If Not IsNumeric(txtValor2.Text) Or txtValor2.Text = "" Then
            MsgBox("INGRESE VALOR NUMERICO", vbInformation)
            txtValor1.Clear()
            txtValor2.Clear()
            End
        End If
        Dim Valor1 As Integer
        Dim Valor2 As Integer
        Dim Raiz As Double


        Valor1 = Val(txtValor1.Text)
        Valor2 = Val(txtValor2.Text)

        Raiz = Valor1 ^ (1 / Valor2)
        txtRaiz.Text = Raiz
    End Sub
End Class
