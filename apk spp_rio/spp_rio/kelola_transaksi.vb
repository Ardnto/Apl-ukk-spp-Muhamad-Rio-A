Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Drawing.Printing

Public Class kelola_transaksi
    Dim WithEvents PD As New PrintDocument
    Dim PDD As New PrintPreviewDialog
    Private Sub kelola_transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        aturdgv()
    End Sub
    Sub aturdgv()
        sql = "SELECT * FROM pembayaran"
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "pembayaran")
        dgv_user.DataSource = ds.Tables("pembayaran")
    End Sub

    Sub kosong()
        txtidbayar.Text = ""
        txtidptgs.Text = ""
        txtnisn.Text = ""
        txtthnbayar.Text = ""
        txtblnbayar.Text = ""
        txtidspp.Text = ""
        txtjmlbayar.Text = ""

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        admin.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        connect()
        If txtidbayar.Text = "" Or txtidptgs.Text = "" Or txtnisn.Text = "" Or txtthnbayar.Text = "" Or txtblnbayar.Text = "" Or txtidspp.Text = "" Then
            MsgBox("Pastikan mengisi semua field dengan benar")
        Else
            sql = "INSERT into pembayaran (id_pembayaran, id_petugas, nisn, tgl_bayar, bulan_dibayar, tahun_dibayar, id_spp, jumlah_bayar) VALUES ('" & txtidbayar.Text & "', '" & txtidptgs.Text & "',  '" & txtnisn.Text & "', '" & Format(dttbayar.Value, "yyyy-MM-dd") & "', '" & txtblnbayar.Text & "', '" & txtthnbayar.Text & "', '" & txtidspp.Text & "', '" & txtjmlbayar.Text & "')"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil Tambah Data")
            aturdgv()
            kosong()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        connect()
        If txtidbayar.Text = "" Or txtidptgs.Text = "" Or txtnisn.Text = "" Or txtthnbayar.Text = "" Or txtblnbayar.Text = "" Or txtidspp.Text = "" Then
            MsgBox("Pastikan mengisi semua field dengan benar")
        Else
            sql = "Update pembayaran set id_petugas = '" & txtidptgs.Text & "', nisn =  '" & txtnisn.Text & "', tgl_bayar = '" & Format(dttbayar.Value, "yyyy-MM-dd") & "', bulan_dibayar = '" & txtblnbayar.Text & "', tahun_dibayar = '" & txtthnbayar.Text & "', id_spp = '" & txtidspp.Text & "', jumlah_bayar = '" & txtjmlbayar.Text & "' where id_pembayaran='" & txtidbayar.Text & "'"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil Edit Data")
            aturdgv()
            kosong()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        connect()
        If txtidbayar.Text = "" Or txtidptgs.Text = "" Or txtnisn.Text = "" Or txtthnbayar.Text = "" Or txtblnbayar.Text = "" Or txtidspp.Text = "" Then
            MsgBox("Pastikan mengisi semua field dengan benar")
        Else
            sql = "Delete FROM pembayaran where id_pembayaran ='" & txtidbayar.Text & "'"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil Hapus Data")
            aturdgv()
            kosong()
        End If
    End Sub

    Private Sub dgv_user_MouseClick(sender As Object, e As MouseEventArgs) Handles dgv_user.MouseClick
        txtidbayar.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(0).Value
        txtidptgs.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(1).Value
        txtnisn.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(2).Value
        dttbayar.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(3).Value
        txtblnbayar.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(4).Value
        txtthnbayar.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(5).Value
        txtidspp.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(6).Value
        txtjmlbayar.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(7).Value
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'printPD()
        PDD.Document = PD
        PDD.ShowDialog()
    End Sub
    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim f10 As New Font("Times New Roman", 10, FontStyle.Regular)
        Dim f10b As New Font("Times New Roman", 10, FontStyle.Bold)
        Dim f14 As New Font("Times New Roman", 14, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        Dim kanan As New StringFormat
        Dim tengah As New StringFormat
        kanan.Alignment = StringAlignment.Far
        tengah.Alignment = StringAlignment.Center

        Dim garis As String
        garis = "--------------------------------------------------------------------------------------"

        e.Graphics.DrawString("SPP SMK Negeri 2 Kuningan", f14, Brushes.Black, centermargin, 5, tengah)
        e.Graphics.DrawString("Jl.Sukamulya No.77", f10, Brushes.Black, centermargin, 25, tengah)
        e.Graphics.DrawString("No Tlp: 0812", f10, Brushes.Black, centermargin, 40, tengah)

        e.Graphics.DrawString("Petugas", f10, Brushes.Black, 0, 65)
        e.Graphics.DrawString(":", f10, Brushes.Black, 60, 65)
        e.Graphics.DrawString("Rio", f10, Brushes.Black, 80, 65)

        e.Graphics.DrawString("Siswa", f10, Brushes.Black, 150, 65)
        e.Graphics.DrawString(":", f10, Brushes.Black, 60, 65)
        e.Graphics.DrawString(":", f10, Brushes.Black, 80, 65)

        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 80)
        e.Graphics.DrawString("nisn", f10, Brushes.Black, 20, 95)
        e.Graphics.DrawString("harga", f10, Brushes.Black, 60, 95)
        e.Graphics.DrawString("tanggal bayar", f10, Brushes.Black, 120, 95)
        dgv_user.AllowUserToAddRows = False

        Dim tinggi As Integer
        For baris As Integer = 0 To dgv_user.RowCount - 1
            tinggi += 15
            e.Graphics.DrawString(dgv_user.Rows(baris).Cells(2).Value.ToString, f10, Brushes.Black, 20, 100 + tinggi)
            e.Graphics.DrawString(dgv_user.Rows(baris).Cells(7).Value.ToString, f10, Brushes.Black, 60, 100 + tinggi)
            e.Graphics.DrawString(dgv_user.Rows(baris).Cells(3).Value.ToString, f10, Brushes.Black, 120, 100 + tinggi)


        Next
        tinggi = 110 + tinggi
        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 400)
        e.Graphics.DrawString("Thank You:.....", f10, Brushes.Black, centermargin, 450, tengah)


    End Sub

    Sub printPD()
        PrintDoc.PrinterSettings.PrinterName = "Microsoft Print to PDF"
        PrintDoc.Print()
    End Sub

    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 350, 500)
        PD.DefaultPageSettings = pagesetup
    End Sub

    Private Sub txtidbayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtidbayar.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            MsgBox("Pastikan Angka Yang Di Inputkan")
            e.Handled = True
        End If
    End Sub

    Private Sub txtidptgs_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtidptgs.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            MsgBox("Pastikan Angka Yang Di Inputkan")
            e.Handled = True
        End If
    End Sub

    Private Sub txtnisn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnisn.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            MsgBox("Pastikan Angka Yang Di Inputkan")
            e.Handled = True
        End If
    End Sub

    Private Sub txtidspp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtidspp.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            MsgBox("Pastikan Angka Yang Di Inputkan")
            e.Handled = True
        End If
    End Sub

    Private Sub txtblnbayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtblnbayar.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            MsgBox("Pastikan Angka Yang Di Inputkan")
            e.Handled = True
        End If
    End Sub

    Private Sub txtthnbayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtthnbayar.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            MsgBox("Pastikan Angka Yang Di Inputkan")
            e.Handled = True
        End If
    End Sub

    Private Sub txtjmlbayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtjmlbayar.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            MsgBox("Pastikan Angka Yang Di Inputkan")
            e.Handled = True
        End If
    End Sub

    Private Sub txtcari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcari.KeyPress
        sql = "SELECT * FROM pembayaran Where (id_pembayaran like '%" & txtcari.Text & "%')"
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "pembayaran")
        dgv_user.DataSource = ds.Tables("pembayaran")
    End Sub


    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Label11.Text = 1000000
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Label12.Text = 1000000
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        connect()
        If txtkembali.text = 2000000 Then
            MsgBox("uang anda lebih!")
        End If
    End Sub
End Class