Imports System.Data
Imports System.Data.OleDb
Public Class FrmNip

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        txtNip.Text = txtNip.Text & "1"
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        txtNip.Text = txtNip.Text & "2"
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        txtNip.Text = txtNip.Text & "3"
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        txtNip.Text = txtNip.Text & "4"
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        txtNip.Text = txtNip.Text & "5"
    End Sub

    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles Btn6.Click
        txtNip.Text = txtNip.Text & "6"
    End Sub

    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles Btn7.Click
        txtNip.Text = txtNip.Text & "7"
    End Sub

    Private Sub Bn8_Click(sender As Object, e As EventArgs) Handles Btn8.Click
        txtNip.Text = txtNip.Text & "8"
    End Sub

    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles Btn9.Click
        txtNip.Text = txtNip.Text & "9"
    End Sub

    Private Sub Btn0_Click(sender As Object, e As EventArgs) Handles Btn0.Click
        txtNip.Text = txtNip.Text & "0"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If txtNip.Text = "" Then
            MsgBox("NIP no valido.")
            txtNip.Focus()
            Exit Sub
        End If

        Try
            Dim sentsql As String
            sentsql = "SELECT * from tarjetas where nip=" & txtNip.Text & " and NOtarjeta='" & IdTarjeta & "'"
            Dim conexion As New OleDbConnection()
            conexion.ConnectionString = ("PROVIDER=Microsoft.ACE.OLEDB.12.0;Data Source=" & Ruta)
            Dim objadap As New OleDbDataAdapter(sentsql, conexion)
            Dim miConsulta As New DataTable() 'consulta
            conexion.Open()
            objadap.Fill(miConsulta)
            If (miConsulta.Rows.Count) = 0 Then
                ' no hay registros coincidentes.
                MessageBox.Show("El NIP es incorrecto. intente de nuevo")
            Else
                txtNip.DataBindings.Add("text", miConsulta, "NIP")
                IdTarjeta = txtNip.Text
                FrmMenu.Show()
                Me.Close()
            End If
            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub FrmNip_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
    End Sub

    Private Sub FrmNip_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim sentsql As String
            sentsql = "SELECT NoCuenta from tarjetas where IdTarjeta='" & IdTarjeta & "'"
            Dim conexion As New OleDbConnection()
            conexion.ConnectionString = ("PROVIDER=Microsoft.ACE.OLEDB.12.0;Data Source=" & Ruta)
            Dim objadap As New OleDbDataAdapter(sentsql, conexion)
            Dim miConsulta As New DataTable() 'consulta
            conexion.Open()
            objadap.Fill(miConsulta)

            txtNoCuenta.Visible = True
            txtNoCuenta.DataBindings.Add("text", miConsulta, "NoCuenta")
            NoCuenta = txtNoCuenta.Text
            txtNoCuenta.DataBindings.Clear()




            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        End
    End Sub
End Class