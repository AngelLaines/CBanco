Public Class frmotra

    Private Sub frmotra_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txtCantidad.Text = txtCantidad.Text & "8"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txtCantidad.Text = txtCantidad.Text & "0"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txtCantidad.Text = txtCantidad.Text & "9"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtCantidad.Text = txtCantidad.Text & "2"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txtCantidad.Text = txtCantidad.Text & "7"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txtCantidad.Text = txtCantidad.Text & "6"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtCantidad.Text = txtCantidad.Text & "5"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txtCantidad.Text = txtCantidad.Text & "4"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtCantidad.Text = txtCantidad.Text & "3"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtCantidad.Text = txtCantidad.Text & "1"
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs)
        FrmEntregac.Show()
        Me.Close()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs)
        txtCantidad.Text = ""
    End Sub

    Private Sub btnSi_Click(sender As Object, e As EventArgs) Handles btnSi.Click
        saldo = txtCantidad.Text
        FrmEntregac.Show()
        Me.Close()
    End Sub
End Class