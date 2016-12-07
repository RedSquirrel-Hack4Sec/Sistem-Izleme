Public Class Form1

    'Hack4sec.NeT - Red Squirrel

    Private Sub btnKlasorSec_Click(sender As Object, e As EventArgs) Handles btnKlasorSec.Click
        If fbdKlasorSec.ShowDialog = Windows.Forms.DialogResult.OK Then
            tbKlasor.Text = fbdKlasorSec.SelectedPath
            fsw1.Path = fbdKlasorSec.SelectedPath
        End If
    End Sub

    Private Sub fsw1_Changed(sender As Object, e As IO.FileSystemEventArgs) Handles fsw1.Changed
        lbLog.Items.Add("Changed: " + e.FullPath)
    End Sub

    Private Sub fsw1_Created(sender As Object, e As IO.FileSystemEventArgs) Handles fsw1.Created
        lbLog.Items.Add("Created: " + e.FullPath)
    End Sub

    Private Sub fsw1_Deleted(sender As Object, e As IO.FileSystemEventArgs) Handles fsw1.Deleted
        lbLog.Items.Add("Deleted: " + e.FullPath)
    End Sub

    Private Sub fsw1_Error(sender As Object, e As IO.ErrorEventArgs) Handles fsw1.Error
        lbLog.Items.Add("ERROR: " + e.GetException.Message)
    End Sub

    Private Sub fsw1_Renamed(sender As Object, e As IO.RenamedEventArgs) Handles fsw1.Renamed
        lbLog.Items.Add("Renamed: " + e.OldFullPath + " - " + e.FullPath)
    End Sub
End Class
