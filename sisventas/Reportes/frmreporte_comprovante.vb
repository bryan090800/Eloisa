Public Class frmreporte_comprovante

    Private Sub frmreporte_comprovante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbventasDataSet1.generar_comprobante' Puede moverla o quitarla según sea necesario.
        'dbventasDataSet1.EnforceConstraints = False

        Try
            Me.generar_comprobanteTableAdapter.Fill(Me.dbventasDataSet1.generar_comprobante, idventa:=txtidventa.Text)
            Me.ReportViewer1.Refresh()
        Catch ex As Exception
            Me.ReportViewer1.Refresh()
        End Try

    End Sub

End Class