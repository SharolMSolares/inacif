Public Class Form1
    Private Sub CadaveresBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CadaveresBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CadaveresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.InacifDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'InacifDataSet.cadaveres' Puede moverla o quitarla según sea necesario.
        Me.CadaveresTableAdapter.Fill(Me.InacifDataSet.cadaveres)

    End Sub
End Class
