Imports System.Data.OleDb

Public Class Form1
    Public Sub tampilkanisidata()
        Dim tampil As String
        tampil = "select * from biodata where nis='" & tb_nis.Text & "'"
        Try
            Using koneksi As New OleDbConnection(My.Settings.Koneksi)
                Using isitabel As New OleDbCommand(tampil, koneksi) 'berhubungan dengan perintah querynya'
                    koneksi.Open()
                    Dim bacatabel As OleDbDataReader = isitabel.ExecuteReader 'membaca perbaris'
                    While bacatabel.Read
                        tb_nama.Text = bacatabel.GetValue(1)
                        tb_alamat.Text = bacatabel.GetValue(2)

                    End While
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Public Sub tampilkandata()
        Using koneksi As New OleDbConnection(My.Settings.Koneksi) 'menghubungkan VB dengan yang Access'
            Using isitabel As New OleDbDataAdapter("select * from biodata", koneksi) 'membaca tabel yang sudah dikoneksikan'
                'membaca'
                koneksi.Open()
                Dim datatabel As New DataTable
                isitabel.Fill(datatabel)
                dg_view.DataSource = datatabel

            End Using
        End Using
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilkandata()
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        Dim nis, nama, alamat As String
        nis = tb_nis.Text
        nama = tb_nama.Text
        alamat = tb_alamat.Text
        Dim simpan As String
        simpan = "insert into biodata values ('" & nis & "','" & nama & "','" & alamat & "')"
        Try
            Using koneksi As New OleDbConnection(My.Settings.Koneksi)
                Using isitabel As New OleDbCommand(simpan, koneksi)
                    koneksi.Open()
                    '^membuka koneksi'
                    isitabel.ExecuteNonQuery()
                    '^menjalankan query '
                    MessageBox.Show("Data berhasil disimpan")
                    tampilkandata()

                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub tb_nis_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_nis.KeyDown
        If e.KeyValue = 13 Then
            tampilkanisidata()

        End If
    End Sub
End Class
