Imports MySql.Data.MySqlClient
Public Class LoginForm2

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.
    Private Sub TxtUserName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtUserName.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtPassword.Focus()
        End If
    End Sub

    Private Sub TxtPassword_TextChanged(sender As Object, e As EventArgs) Handles TxtPassword.TextChanged

    End Sub

    Private Sub TxtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPassword.KeyPress
        If e.KeyChar = Chr(13) Then
            btnLogIn.Focus()
        End If
    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        koneksi()
        CMD = New MySqlCommand("select * from tbpetugas where status = '" & TxtUserName.Text & "' and Password = '" & TxtPassword.Text & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            Me.Visible = False
            FrmMenuUtama.Show()
        ElseIf Not RD.HasRows Then
            MessageBox.Show("Periksa Kembali username dan Password", "PERINGATAN",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtUserName.Focus()
            TxtUserName.Text = ""
            TxtPassword.Text = ""
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        End
    End Sub
End Class
