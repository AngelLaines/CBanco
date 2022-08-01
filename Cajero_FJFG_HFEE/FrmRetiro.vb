Imports System.Data
Imports System.Data.OleDb
Public Class FrmRetiro

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        frmRetiro50.Show()
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        frmRetiro100.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        FrmRetiro200.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        FrmRetiro500.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        FrmRetiro1000.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        frmotra.Show()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btn50_Click(sender As Object, e As EventArgs) Handles btn50.Click
        frmRetiro50.Show()
        Me.Close()
    End Sub

    Private Sub FrmRetiro_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

    End Sub

    Private Sub btn100_Click(sender As Object, e As EventArgs) Handles btn100.Click
        frmRetiro100.Show()
        Me.Close()
    End Sub

    Private Sub btn200_Click(sender As Object, e As EventArgs) Handles btn200.Click
        FrmRetiro200.Show()
        Me.Close()
    End Sub

    Private Sub btn500_Click(sender As Object, e As EventArgs) Handles btn500.Click
        FrmRetiro500.Show()
        Me.Close()
    End Sub

    Private Sub btn1000_Click(sender As Object, e As EventArgs) Handles btn1000.Click
        FrmRetiro1000.Show()
        Me.Close()
    End Sub

    Private Sub btnOtra_Click(sender As Object, e As EventArgs) Handles btnOtra.Click
        frmotra.Show()
        Me.Close()
    End Sub
End Class