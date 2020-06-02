Public Class Form1

    Private Sub tombolCari_Click(sender As Object, e As EventArgs) Handles tombolCari.Click
        For Each strKota As String In listKota.Items
            If strKota = teksKota.Text Then
                labelHasil.Text = "Kota ditemukan!"
            End If
        Next
    End Sub
End Class