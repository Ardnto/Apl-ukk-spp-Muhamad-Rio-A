Imports System.Data.SqlClient

Public Class Kelola_Kelas

    Private Sub Kelola_Kelas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        aturdgv()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        admin.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        connect()
        If txtidkls.Text = "" Or txtnama.Text = "" Or txtkom.Text = "" Then
            MsgBox("Pastikan mengisi semua field dengan benar")
        Else
            sql = "INSERT into kelas (id_kelas, nama_kelas, kompetensi_keahlian) VALUES ('" & txtidkls.Text & "', '" & txtnama.Text & "', '" & txtkom.Text & "')"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil Tambah Data")
            aturdgv()
            kosong()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        connect()
        If txtidkls.Text = "" Or txtnama.Text = "" Or txtkom.Text = "" Then
            MsgBox("Pastikan mengisi semua field dengan benar")
        Else
            sql = "UPDATE kelas set nama_kelas='" & txtnama.Text & "',kompetensi_keahlian = '" & txtkom.Text & "'where id_kelas = '" & txtidkls.Text & "'"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil Edit Data")
            aturdgv()
            kosong()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        connect()
        If txtidkls.Text = "" Or txtnama.Text = "" Or txtkom.Text = "" Then
            MsgBox("Pastikan mengisi semua field dengan benar")
        Else
            sql = "DELETE FROM kelas where id_kelas = '" & txtidkls.Text & "'"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil Hapus Data")
            aturdgv()
            kosong()
        End If
    End Sub
    Sub aturdgv()
        sql = "SELECT * FROM kelas"
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "kelas")
        dgv_user.DataSource = ds.Tables("kelas")
    End Sub

    Sub kosong()
        txtidkls.Text = ""
        txtnama.Text = ""
        txtkom.Text = ""
    End Sub


    Private Sub txtcari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcari.KeyPress
        sql = "SELECT * FROM kelas Where (nama_kelas like '%" & txtcari.Text & "%')"
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "kelas")
        dgv_user.DataSource = ds.Tables("kelas")
    End Sub

    Private Sub dgv_user_MouseClick(sender As Object, e As MouseEventArgs) Handles dgv_user.MouseClick
        txtidkls.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(0).Value
        txtnama.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(1).Value
        txtkom.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(2).Value
    End Sub


    Private Sub txtidkls_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtidkls.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            MsgBox("Pastikan Angka Yang Di Inputkan")
            e.Handled = True
        End If
    End Sub
End Class