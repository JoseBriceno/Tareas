Public Class FACTURA
    Dim descuento As Double
    Dim isv As Double
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub ComboDescuento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboDescuento.SelectedIndexChanged

        If comboDescuento.Text = ("DESCUENTO SOCIO") Then
            descuento = 0.85
        ElseIf comboDescuento.Text = ("DESCUENTO ESTUDIO") Then
            descuento = 0.35
        ElseIf comboDescuento.Text = ("DESCUENTO STAFF") Then
            descuento = 0.4
        ElseIf comboDescuento.Text = ("DESCUENTO VIP") Then
            descuento = 0.1
        ElseIf comboDescuento.Text = ("DESCUENTO ESPECIAL") Then
            descuento = 0.65
        ElseIf comboDescuento.Text = ("DESCUENTO NORMAL") Then
            descuento = 0.3
        End If


    End Sub

    Private Sub ComboISV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboISV.SelectedIndexChanged
        If comboISV.Text = ("15%") Then
            isv = 0.15
        ElseIf comboISV.Text = ("17%") Then
            isv = 0.17
        End If


    End Sub

    Private Sub CbDescuento_CheckedChanged(sender As Object, e As EventArgs) Handles cbDescuento.CheckedChanged
        If cbDescuento.Checked = True Then
            comboDescuento.Enabled = True
            comboISV.Enabled = False
            cbISV.Checked = False

        End If
    End Sub

    Private Sub CbISV_CheckedChanged(sender As Object, e As EventArgs) Handles cbISV.CheckedChanged
        If cbISV.Checked = True Then
            comboISV.Enabled = True
            comboDescuento.Enabled = False
            cbDescuento.Checked = False
        End If
    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        txtSubTotal.Text = txtPrecio.Text * txtCantidad.Text
        txtDescuento.Text = txtSubTotal.Text * descuento
        txtISV.Text = txtSubTotal.Text * isv
        If cbDescuento.Checked = True Then
            txtTotal.Text = txtSubTotal.Text - txtDescuento.Text
        ElseIf cbISV.Checked = True Then
            txtTotal.Text = txtSubTotal.Text - txtISV.Text

        End If

        btnNuevo.Enabled = True

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtISV.Clear()
        txtPrecio.Clear()
        txtSubTotal.Clear()
        txtTotal.Clear()
        txtCantidad.Clear()
        txtDescuento.Clear()

        cbDescuento.Checked = False
        cbISV.Checked = False

        comboDescuento.Enabled = False
        comboISV.Enabled = False

        comboISV.Text = ""
        comboDescuento.Text = ""
    End Sub

    Private Sub FACTURA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnNuevo.Enabled = False



    End Sub

    Private Sub TxtPrecio_TextChanged(sender As Object, e As EventArgs) Handles txtPrecio.TextChanged
        Dim valor As Int16
        If txtPrecio.Text = "" Then
            MsgBox("INGRESE VALOR", vbInformation)
        ElseIf Not IsNumeric(txtPrecio.Text) Then
            MsgBox("INGRESE VALOR NUMERICO", vbInformation)
            txtPrecio.Text = ""
        ElseIf IsNumeric(valor) Then
            valor = Val(txtPrecio.Text)
            If valor = 0 Then
                MsgBox("VALOR ES 0", vbInformation)
            ElseIf valor < 0 Then
                MsgBox("VALOR NEGATIVO")
            End If
        End If
    End Sub

    Private Sub TxtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged
        Dim valor As Int16
        If txtCantidad.Text = "" Then
            MsgBox("INGRESE VALOR", vbInformation)
        ElseIf Not IsNumeric(txtCantidad.Text) Then
            MsgBox("INGRESE VALOR NUMERICO", vbInformation)
            txtCantidad.Text = ""
        ElseIf IsNumeric(valor) Then
            valor = Val(txtCantidad.Text)
            If valor = 0 Then
                MsgBox("VALOR ES 0", vbInformation)
            ElseIf valor < 0 Then
                MsgBox("VALOR NEGATIVO")
            End If
        End If
    End Sub
End Class