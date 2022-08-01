Public Class FrmMenu

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        FrmRetiro.Show()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub btnConsultaSaldo_Click(sender As Object, e As EventArgs) Handles btnConsultaSaldo.Click
        frmConsulta.Show()
        Me.Close()
    End Sub

    Private Sub btnRetiro_Click(sender As Object, e As EventArgs) Handles btnRetiro.Click
        FrmRetiro.Show()
        Me.Close()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
End Class