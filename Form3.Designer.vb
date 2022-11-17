<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAnggota
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtIDAnggota = New System.Windows.Forms.TextBox()
        Me.TxtNamaAnggota = New System.Windows.Forms.TextBox()
        Me.TxtAlamat = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtTelepon = New System.Windows.Forms.TextBox()
        Me.TblTambah = New System.Windows.Forms.Button()
        Me.TblSimpan = New System.Windows.Forms.Button()
        Me.TblUbah = New System.Windows.Forms.Button()
        Me.TblHapus = New System.Windows.Forms.Button()
        Me.TblKeluar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtCari = New System.Windows.Forms.TextBox()
        Me.TblRefresh = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DGVAnggota = New System.Windows.Forms.DataGridView()
        CType(Me.DGVAnggota, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(294, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DATA ANGGOTA PERPUSTAKAAN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Anggota"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Alamat"
        '
        'TxtIDAnggota
        '
        Me.TxtIDAnggota.Location = New System.Drawing.Point(97, 58)
        Me.TxtIDAnggota.Name = "TxtIDAnggota"
        Me.TxtIDAnggota.Size = New System.Drawing.Size(100, 20)
        Me.TxtIDAnggota.TabIndex = 4
        '
        'TxtNamaAnggota
        '
        Me.TxtNamaAnggota.Location = New System.Drawing.Point(97, 89)
        Me.TxtNamaAnggota.Name = "TxtNamaAnggota"
        Me.TxtNamaAnggota.Size = New System.Drawing.Size(237, 20)
        Me.TxtNamaAnggota.TabIndex = 5
        '
        'TxtAlamat
        '
        Me.TxtAlamat.Location = New System.Drawing.Point(97, 121)
        Me.TxtAlamat.Name = "TxtAlamat"
        Me.TxtAlamat.Size = New System.Drawing.Size(237, 57)
        Me.TxtAlamat.TabIndex = 6
        Me.TxtAlamat.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "No. Telepon"
        '
        'TxtTelepon
        '
        Me.TxtTelepon.Location = New System.Drawing.Point(97, 188)
        Me.TxtTelepon.Name = "TxtTelepon"
        Me.TxtTelepon.Size = New System.Drawing.Size(100, 20)
        Me.TxtTelepon.TabIndex = 8
        '
        'TblTambah
        '
        Me.TblTambah.Location = New System.Drawing.Point(14, 233)
        Me.TblTambah.Name = "TblTambah"
        Me.TblTambah.Size = New System.Drawing.Size(63, 23)
        Me.TblTambah.TabIndex = 9
        Me.TblTambah.Text = "ADD"
        Me.TblTambah.UseVisualStyleBackColor = True
        '
        'TblSimpan
        '
        Me.TblSimpan.Location = New System.Drawing.Point(83, 233)
        Me.TblSimpan.Name = "TblSimpan"
        Me.TblSimpan.Size = New System.Drawing.Size(63, 23)
        Me.TblSimpan.TabIndex = 10
        Me.TblSimpan.Text = "SAVE"
        Me.TblSimpan.UseVisualStyleBackColor = True
        '
        'TblUbah
        '
        Me.TblUbah.Location = New System.Drawing.Point(152, 233)
        Me.TblUbah.Name = "TblUbah"
        Me.TblUbah.Size = New System.Drawing.Size(63, 23)
        Me.TblUbah.TabIndex = 11
        Me.TblUbah.Text = "CHANGE"
        Me.TblUbah.UseVisualStyleBackColor = True
        '
        'TblHapus
        '
        Me.TblHapus.Location = New System.Drawing.Point(221, 233)
        Me.TblHapus.Name = "TblHapus"
        Me.TblHapus.Size = New System.Drawing.Size(63, 23)
        Me.TblHapus.TabIndex = 12
        Me.TblHapus.Text = "DELETE"
        Me.TblHapus.UseVisualStyleBackColor = True
        '
        'TblKeluar
        '
        Me.TblKeluar.Location = New System.Drawing.Point(290, 233)
        Me.TblKeluar.Name = "TblKeluar"
        Me.TblKeluar.Size = New System.Drawing.Size(63, 23)
        Me.TblKeluar.TabIndex = 13
        Me.TblKeluar.Text = "EXIT"
        Me.TblKeluar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 267)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 26)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Cari Berdasarkan" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "IDAnggota"
        '
        'TxtCari
        '
        Me.TxtCari.Location = New System.Drawing.Point(118, 267)
        Me.TxtCari.Name = "TxtCari"
        Me.TxtCari.Size = New System.Drawing.Size(134, 20)
        Me.TxtCari.TabIndex = 15
        '
        'TblRefresh
        '
        Me.TblRefresh.Location = New System.Drawing.Point(264, 265)
        Me.TblRefresh.Name = "TblRefresh"
        Me.TblRefresh.Size = New System.Drawing.Size(75, 23)
        Me.TblRefresh.TabIndex = 16
        Me.TblRefresh.Text = "REFRESH"
        Me.TblRefresh.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "ID Anggota"
        '
        'DGVAnggota
        '
        Me.DGVAnggota.AllowUserToOrderColumns = True
        Me.DGVAnggota.Location = New System.Drawing.Point(9, 313)
        Me.DGVAnggota.Name = "DGVAnggota"
        Me.DGVAnggota.Size = New System.Drawing.Size(345, 153)
        Me.DGVAnggota.TabIndex = 20
        '
        'FrmAnggota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 478)
        Me.Controls.Add(Me.DGVAnggota)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TblRefresh)
        Me.Controls.Add(Me.TxtCari)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TblKeluar)
        Me.Controls.Add(Me.TblHapus)
        Me.Controls.Add(Me.TblUbah)
        Me.Controls.Add(Me.TblSimpan)
        Me.Controls.Add(Me.TblTambah)
        Me.Controls.Add(Me.TxtTelepon)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtAlamat)
        Me.Controls.Add(Me.TxtNamaAnggota)
        Me.Controls.Add(Me.TxtIDAnggota)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmAnggota"
        Me.Text = "FrmAnggota"
        CType(Me.DGVAnggota, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtIDAnggota As TextBox
    Friend WithEvents TxtNamaAnggota As TextBox
    Friend WithEvents TxtAlamat As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtTelepon As TextBox
    Friend WithEvents TblTambah As Button
    Friend WithEvents TblSimpan As Button
    Friend WithEvents TblUbah As Button
    Friend WithEvents TblHapus As Button
    Friend WithEvents TblKeluar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtCari As TextBox
    Friend WithEvents TblRefresh As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents DGVAnggota As DataGridView
End Class
