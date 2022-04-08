Public Class OrderStatusForm

    Dim selectedOrder As String
    Private Sub btnComplete_Click(sender As Object, e As EventArgs) Handles btnComplete.Click
        selectedOrder = chlboxOrder.SelectedItem
        lsBoxDone.Items.Add(selectedOrder)
        chlboxOrder.Items.Remove(selectedOrder)
    End Sub
End Class