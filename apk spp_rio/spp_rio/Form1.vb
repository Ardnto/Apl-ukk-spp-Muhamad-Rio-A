Imports System.Data.SqlClient
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        connect()
        If txtusnm.Text = "" Or txtpass.Text = "" Then
            MsgBox("Pastikan Mengisi Semua Field")
        Else
            sql = "SELECT id_petugas, username, password, nama_petugas, level FROM petugas WHERE username='" & Trim(txtusnm.Text) & "' and password='" & Trim(txtpass.Text) & "'"
            cmd = New SqlClient.SqlCommand(sql, con)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                If rd.Item("level").Equals("Admin") Then
                    Admin.Show()
                    Me.Hide()
                ElseIf rd.Item("level").Equals("Petugas") Then
                    petugas.Show()
                    Me.Hide()
                ElseIf rd.Item("level").Equals("Siswa") Then
                    siswa.Show()
                    Me.Hide()
                Else
                    MsgBox("Username atau Password yang anda masukan tidak sesuai")
                    rd.Close()
                End If
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        connect()
        If txtusnm.Text = "" And txtpass.Text = "" Then
            MsgBox("Username dan Password Belum Di isi")
        Else
            txtusnm.Text = ""
            txtpass.Text = ""
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
    End Sub
End Class