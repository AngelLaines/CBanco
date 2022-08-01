Imports System.Data
Imports System.Data.OleDb
Public Class frmConsulta

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtSaldo.TextChanged

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs)
        FrmMenu.Show()
        Me.Close()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub frmConsulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim sentsql As String
            sentsql = "SELECT Saldo from CUENTAS where NOCUENTA=" & NoCuenta
            Dim conexion As New OleDbConnection()
            conexion.ConnectionString = ("PROVIDER=Microsoft.ACE.OLEDB.12.0;Data Source=" & Ruta)
            Dim objadap As New OleDbDataAdapter(sentsql, conexion)
            Dim miConsulta As New DataTable() 'consulta
            conexion.Open()
            objadap.Fill(miConsulta)

            txtSaldo.DataBindings.Add("text", miConsulta, "Saldo")


            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub btnSi_Click(sender As Object, e As EventArgs) Handles btnSi.Click
        FrmMenu.Show()
        Me.Close()
    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        FrmTarjeta.Show()
        Me.Close()
    End Sub
End Class