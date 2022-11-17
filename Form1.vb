Public Class FrmMenuUtama
    Private Sub ToolStripProgressBar1_Click(sender As Object, e As EventArgs) Handles ToolStripProgressBar1.Click
        'create two progress bars
        Dim ProgressBar1 As ProgressBar
        Dim ProgressBar2 As ProgressBar
        ProgressBar1 = New ProgressBar()
        ProgressBar2 = New ProgressBar()
        'set position
        ProgressBar1.Location = New Point(10, 10)
        ProgressBar2.Location = New Point(10, 50)
        'set values
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 200
        ProgressBar1.Value = 130
        ProgressBar2.Minimum = 0
        ProgressBar2.Maximum = 100
        ProgressBar2.Value = 40
        'add the progress bar to the form
        Me.Controls.Add(ProgressBar1)
        Me.Controls.Add(ProgressBar2)
    End Sub

    Private Sub DataAnggotaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataAnggotaToolStripMenuItem.Click
        FrmAnggota.Show()
    End Sub

    Private Sub FrmMenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
    End Sub
End Class
