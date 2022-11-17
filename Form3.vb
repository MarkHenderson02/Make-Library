Imports MySql.Data.MySqlClient
Public Class FrmAnggota
    Private Sub FrmAnggota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call TampilDataGrid()
        Call AturLebarKolomGrid()
        Call NonAktif()
        DGVAnggota.ReadOnly = True
    End Sub

    Sub TampilDataGrid()
        DA = New MySqlDataAdapter("select * from TBAnggota", CONN)
        DS = New DataSet
        Dim v = DA.Fill(DS, "tbanggota")
        DGVAnggota.DataSource = DS.Tables("tbanggota")
    End Sub
    Sub AturLebarKolomGrid()
        DGVAnggota.Columns(0).Width = 60
        DGVAnggota.Columns(1).Width = 100
        DGVAnggota.Columns(2).Width = 150
        DGVAnggota.Columns(3).Width = 60
    End Sub
    Sub Aktif()
        TxtIDAnggota.Enabled = True
        TxtNamaAnggota.Enabled = True
        TxtAlamat.Enabled = True
        TxtTelepon.Enabled = True
        TblSimpan.Enabled = True
        TblTambah.Text = "BATAL"
        TxtIDAnggota.Focus()
    End Sub
    Sub Bersih()
        TxtIDAnggota.Text = ""
        TxtNamaAnggota.Text = ""
        TxtAlamat.Text = ""
        TxtTelepon.Text = ""
        TxtCari.Text = ""
    End Sub
    Sub NonAktif()
        TxtIDAnggota.Enabled = False
        TxtNamaAnggota.Enabled = False
        TxtAlamat.Enabled = False
        TxtTelepon.Enabled = False
        TblHapus.Enabled = False
        TblSimpan.Enabled = False
        TblUbah.Enabled = False
        TblTambah.Text = "TAMBAH"
    End Sub
    Private Sub TblTambah_Click(sender As Object, e As EventArgs) Handles TblTambah.Click
        If TblTambah.Text = "TAMBAH" Then
            Call Bersih()
            Call Aktif()
            Call TampilDataGrid()
            Call AturLebarKolomGrid()
        Else
            Call NonAktif()
            Call Bersih()
            Call TampilDataGrid()
            Call AturLebarKolomGrid()
        End If
    End Sub

    Private Sub TblSimpan_Click(sender As Object, e As EventArgs) Handles TblSimpan.Click
        'terlebih dahulu berikan validasi data harusdiisi, dan tidak boleh kosong
        If TxtIDAnggota.Text = "" Or TxtNamaAnggota.Text = "" Or TxtAlamat.Text = "" Or TxtTelepon.Text = "" Then
            MessageBox.Show("Data Harus Diisi!",
            "Informasi", MessageBoxButtons.OK,
            MessageBoxIcon.Exclamation)
        Else
            Dim SQLSimpan As String = "insert into tbanggota(IDAnggota,NamaAnggota,Alamat,Telepon) values('" & TxtIDAnggota.Text & "','" & TxtNamaAnggota.Text & "','" & TxtAlamat.Text & "','" & TxtTelepon.Text & "')"
            CMD = New MySqlCommand(SQLSimpan, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data Sudah Disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call TampilDataGrid()
            Call AturLebarKolomGrid()
            Call NonAktif()
            Call Bersih()
        End If
    End Sub

    Private Sub TblKeluar_Click(sender As Object, e As EventArgs) Handles TblKeluar.Click
        Me.Close()
    End Sub

    Private Sub TblHapus_Click(sender As Object, e As EventArgs) Handles TblHapus.Click
        If TxtIDAnggota.Text = "" Then
            MessageBox.Show("Pilih Kode Barang dengan Benar", "Peringatan", MessageBoxButtons.OK,
            MessageBoxIcon.Exclamation)
            Exit Sub
        Else
            If MessageBox.Show("Yakin akan dihapus?",
            "Konfirmasi", MessageBoxButtons.YesNo) =
            Windows.Forms.DialogResult.Yes Then
                CMD = New MySqlCommand("Delete from tbanggota where IDAnggota = '" & TxtIDAnggota.Text &
                "'", CONN)
                CMD.ExecuteNonQuery()
                Call Bersih()
                Call TampilDataGrid()
                Call NonAktif()
            Else
                Call NonAktif()
                Call Bersih()
                Call TampilDataGrid()
            End If
        End If
    End Sub

    Private Sub TblRefresh_Click(sender As Object, e As EventArgs) Handles TblRefresh.Click
        Call TampilDataGrid()
        Call AturLebarKolomGrid()
        TxtCari.Text = ""
    End Sub

    Private Sub TxtCari_TextChanged(sender As Object, e As EventArgs) Handles TxtCari.TextChanged
        Dim tables As DataTableCollection = DS.Tables
        Dim source1 As New BindingSource
        DA = New MySqlDataAdapter("select * from tbanggota", CONN)
        DS = New DataSet
        DA.Fill(DS, "tbanggota")
        'memunculkan data-data di dalam tabel
        Dim tampil As New DataView(tables(0))
        source1.DataSource = tampil
        DGVAnggota.DataSource = tampil
        DGVAnggota.Refresh()
        'memunculkan data tabel berdasarkan pencarian TxtCari (memasukkan ID Anggota)
        tampil.RowFilter = "NamaAnggota Like '%" & TxtCari.Text & "%'"
        DGVAnggota.Refresh()
    End Sub

    Private Sub TblUbah_Click(sender As Object, e As EventArgs) Handles TblUbah.Click
        If TxtIDAnggota.Text = "" Or TxtNamaAnggota.Text = "" Or TxtAlamat.Text = "" Or TxtTelepon.Text = "" Then
        Else
            MessageBox.Show("Data Harus Diisi!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Dim SQLUpdate As String = "update tbanggota set IDAnggota = '" & TxtIDAnggota.Text & "', NamaAnggota = '" & TxtNamaAnggota.Text & "', Alamat = '" & TxtAlamat.Text & "', Telepon = '" & TxtTelepon.Text & "' where IDAnggota = '" & TxtIDAnggota.Text & "'"
            CMD = New MySqlCommand(SQLUpdate, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data Sudah DiUbah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call TampilDataGrid()
            Call AturLebarKolomGrid()
            Call NonAktif()
            Call Bersih()
        End If
    End Sub

    Private Sub DGVAnggota_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVAnggota.CellContentClick
        Dim baris As Integer
        With DGVAnggota
            baris = .CurrentRow.Index
            TxtIDAnggota.Text = .Item(0, baris).Value
            TxtNamaAnggota.Text = .Item(1, baris).Value
            TxtAlamat.Text = .Item(2, baris).Value
            TxtTelepon.Text = .Item(3, baris).Value
        End With
        TblUbah.Enabled = True
        TblHapus.Enabled = True
        Call Aktif()
        TblSimpan.Enabled = False
    End Sub
End Class