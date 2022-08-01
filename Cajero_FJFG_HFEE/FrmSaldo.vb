Imports System.Data
Imports System.Data.OleDb
Public Class FrmSaldo
    Public ruta As String = Application.StartupPath & "\ BancoDLP.accdb" '***para bd de ofice 2007 y 2010
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmMenu.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        TextBox1.Text = TextBox1.Text & "1"
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs)
        TextBox1.Text = TextBox1.Text & "2"
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs)
        TextBox1.Text = TextBox1.Text & "3"
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs)
        TextBox1.Text = TextBox1.Text & "4"
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs)
        TextBox1.Text = TextBox1.Text & "5"
    End Sub

    Private Sub Btn6_Click(sender As Object, e As EventArgs)
        TextBox1.Text = TextBox1.Text & "6"
    End Sub

    Private Sub Btn7_Click(sender As Object, e As EventArgs)
        TextBox1.Text = TextBox1.Text & "7"
    End Sub

    Private Sub Btn8_Click(sender As Object, e As EventArgs)
        TextBox1.Text = TextBox1.Text & "8"
    End Sub

    Private Sub Btn9_Click(sender As Object, e As EventArgs)
        TextBox1.Text = TextBox1.Text & "9"
    End Sub

    Private Sub Btn0_Click(sender As Object, e As EventArgs)
        TextBox1.Text = TextBox1.Text & "0"
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        FrmMenu.Show()

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            MsgBox("falta el numero de tarjeta")
            TextBox1.Focus()
            Exit Sub
        End If
        Try
            Dim sentSQL As String
            sentSQL = "Select * from datos de la cuenta where saldo=" & TextBox1.Text
            Dim conexion As New OleDbConnection()
            conexion.ConnectionString = ("PROVIDER=Microsft.ACE.OLEDB.12.0;Data Source=" & ruta) '***para bd de office 2007 y 2010
            Dim objAdap As New OleDbDataAdapter(sentSQL, conexion)
            Dim miconsulta As New DataTable()
            conexion.Open()
            objAdap.Fill(miconsulta)
            If (miconsulta.Rows.Count) = 0 Then
                TextBox1.Clear()
                MessageBox.Show("el numero de tarjeta " & TextBox1.Text & " no existe. verifique")
            End If
            conexion.Close()


        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try

    End Sub
End Class