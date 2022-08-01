Imports System.Data
Imports System.Data.OleDb
Public Class frmRetiro100

    Private Sub Button12_Click(sender As Object, e As EventArgs)
        FrmMenu.Show()
    End Sub

    Private Sub frmRetiro100_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim conexion As New OleDbConnection
            conexion.ConnectionString = ("PROVIDER=Microsoft.ACE.OLEDB.12.0;Data Source=" & Ruta)
            Dim SentsqlUpdate As String
            SentsqlUpdate = "UPDATE CUENTAS set Saldo=([Saldo]-" & 100 & ") where NOCUENTA=" & NoCuenta

            Dim comando As New OleDbCommand(SentsqlUpdate, conexion)
            conexion.Open()
            comando.ExecuteNonQuery()


            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
            Exit Sub
        End Try
        Try
            Dim sentsql As String
            sentsql = "SELECT Saldo from CUENTAS where NOCUENTA=" & NoCuenta
            Dim conexion As New OleDbConnection()
            conexion.ConnectionString = ("PROVIDER=Microsoft.ACE.OLEDB.12.0;Data Source=" & Ruta)
            Dim objadap As New OleDbDataAdapter(sentsql, conexion)
            Dim miConsulta As New DataTable() 'consulta
            conexion.Open()
            objadap.Fill(miConsulta)

            txtDisponible.DataBindings.Add("text", miConsulta, "Saldo")

            txtDisponible.DataBindings.Clear()



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