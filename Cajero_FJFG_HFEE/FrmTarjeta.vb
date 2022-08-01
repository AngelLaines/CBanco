Imports System.Data
Imports System.Data.OleDb
Public Class FrmTarjeta

    Private Sub FrmTarjeta_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        
    End Sub


    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        txtIdTarjeta.Text = txtIdTarjeta.Text & "1"
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        txtIdTarjeta.Text = txtIdTarjeta.Text & "2"
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        txtIdTarjeta.Text = txtIdTarjeta.Text & "3"
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        txtIdTarjeta.Text = txtIdTarjeta.Text & "4"
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        txtIdTarjeta.Text = txtIdTarjeta.Text & "5"
    End Sub

    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles Btn6.Click
        txtIdTarjeta.Text = txtIdTarjeta.Text & "6"
    End Sub

    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles Btn7.Click
        txtIdTarjeta.Text = txtIdTarjeta.Text & "7"
    End Sub

    Private Sub Bn8_Click(sender As Object, e As EventArgs) Handles Bn8.Click
        txtIdTarjeta.Text = txtIdTarjeta.Text & "8"
    End Sub

    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles Btn9.Click
        txtIdTarjeta.Text = txtIdTarjeta.Text & "9"
    End Sub

    Private Sub Btn0_Click(sender As Object, e As EventArgs) Handles Btn0.Click
        txtIdTarjeta.Text = txtIdTarjeta.Text & "0"
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtIdTarjeta.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnTarjeta_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If txtIdTarjeta.Text = "" Then
            MsgBox("No.Tarjeta no valido.")
            txtIdTarjeta.Focus()
            Exit Sub
        End If

        Try
            Dim sentsql As String
            sentsql = "SELECT * from tarjetas where NOTarjeta='" & txtIdTarjeta.Text & "'"
            Dim conexion As New OleDbConnection()
            conexion.ConnectionString = ("PROVIDER=Microsoft.ACE.OLEDB.12.0;Data Source=" & Ruta)
            Dim objadap As New OleDbDataAdapter(sentsql, conexion)
            Dim miConsulta As New DataTable() 'consulta
            conexion.Open()
            objadap.Fill(miConsulta)
            If (miConsulta.Rows.Count) = 0 Then
                ' no hay registros coincidentes.
                MessageBox.Show("El numero de tarjeta es incorrecto. intente de nuevo")
            Else
                txtIdTarjeta.DataBindings.Add("text", miConsulta, "NOTarjeta")
                IdTarjeta = txtIdTarjeta.Text
                txtIdTarjeta.DataBindings.Clear()

                FrmNip.Show()
                Me.Close()
            End If
            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub btnCancelar_Click_1(sender As Object, e As EventArgs) Handles btnCancelar.Click
        End
    End Sub
End Class