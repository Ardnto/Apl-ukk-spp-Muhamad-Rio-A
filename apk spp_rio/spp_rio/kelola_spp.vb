Imports System.Data.SqlClient

Public Class kelola_spp
    Private Sub kelola_spp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        aturdgv()
    End Sub

    Sub aturdgv()
        sql = "SELECT * FROM spp"
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "spp")
        dgv_user.DataSource = ds.Tables("spp")
    End Sub

    Sub kosong()
        txtidspp.Text = ""
        txttahun.Text = ""
        txtnominal.Text = ""
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        admin.Show()
        Me.Hide()
    End Sub

    Private Sub txtcari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcari.KeyPress
        sql = "SELECT * FROM spp Where (id_spp like '%" & txtcari.Text & "%')"
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "spp")
        dgv_user.DataSource = ds.Tables("spp")
    End Sub

    Private Sub dgv_user_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_user.CellContentClick
        txtidspp.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(0).Value
        txttahun.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(1).Value
        txtnominal.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(2).Value
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        connect()
        If txtidspp.Text = "" Or txttahun.Text = "" Or txtnominal.Text = "" Then
            MsgBox("Pastikan mengisi semua field dengan benar")
        Else
            sql = "INSERT into spp (id_spp, tahun, nominal) VALUES ('" & txtidspp.Text & "', '" & txttahun.Text & "', '" & txtnominal.Text & "')"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil Tambah Data")
            aturdgv()
            kosong()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        connect()
        If txtidspp.Text = "" Or txttahun.Text = "" Or txtnominal.Text = "" Then
            MsgBox("Pastikan mengisi semua field dengan benar")
        Else
            sql = "UPDATE spp set tahun = '" & txttahun.Text & "',nominal = '" & txtnominal.Text & "' where id_spp= '" & txtidspp.Text & "'"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil Edit Data")
            aturdgv()
            kosong()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        connect()
        If txtidspp.Text = "" Or txttahun.Text = "" Or txtnominal.Text = "" Then
            MsgBox("Pastikan mengisi semua field dengan benar")
        Else
            sql = "DELETE spp where id_spp= '" & txtidspp.Text & "'"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil Edit Data")
            aturdgv()
            kosong()
        End If
    End Sub

    Private Sub txtidspp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtidspp.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            MsgBox("Pastikan Angka Yang Di Inputkan")
            e.Handled = True
        End If
    End Sub

    Private Sub txttahun_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttahun.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            MsgBox("Pastikan Angka Yang Di Inputkan")
            e.Handled = True
        End If
    End Sub



    Private Sub txtnominal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnominal.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            MsgBox("Pastikan Angka Yang Di Inputkan")
            e.Handled = True
        End If
    End Sub

    Private Sub txtcari_TextChanged(sender As Object, e As EventArgs) Handles txtcari.TextChanged

    End Sub
End Class