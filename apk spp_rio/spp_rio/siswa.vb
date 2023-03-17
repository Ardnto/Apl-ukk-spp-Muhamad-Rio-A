Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class siswa
    Dim WithEvents PD As New PrintDocument
    Dim PDD As New PrintPreviewDialog
    Private Sub siswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        aturdgv()
    End Sub

    Sub aturdgv()
        sql = "SELECT bulan_dibayar, tgl_bayar, jumlah_bayar FROM pembayaran"
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "pembayaran")
        dgv_user.DataSource = ds.Tables("pembayaran")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        sql = "SELECT bulan_dibayar, tgl_bayar, jumlah_bayar from pembayaran WHERE tgl_bayar between '" & dtdari.Value.Date.ToString("MM/dd/yyyy") & "' and '" & dtsampai.Value.Date.ToString("MM/dd/yyyy") & "'"
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "pembayaran")
        dgv_user.DataSource = ds.Tables("pembayaran")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub dgv_user_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_user.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Print.Click
        'printPD()
        PDD.Document = PD
        PDD.ShowDialog()
    End Sub
    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim f10 As New Font("Times New Roman", 15, FontStyle.Regular)
        Dim f10b As New Font("Times New Roman", 15, FontStyle.Bold)
        Dim f14 As New Font("Times New Roman", 22, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        Dim kanan As New StringFormat
        Dim tengah As New StringFormat
        kanan.Alignment = StringAlignment.Far
        tengah.Alignment = StringAlignment.Center

        Dim garis As String
        garis = "------------------------------------------------------------------------------------------------------------------------------------------------------------------------"

        e.Graphics.DrawString("SPP SMK Negeri 2 Kuningan", f14, Brushes.Black, centermargin, 10, tengah)
        Dim logoimg As Image = My.Resources.ResourceManager.GetObject("logo")
        e.Graphics.DrawImage(logoimg, CInt((e.PageBounds.Width - 600) / 2), 5, 100, 100)
        e.Graphics.DrawString("Jl.Sukamulya No.77", f10, Brushes.Black, centermargin, 45, tengah)
        e.Graphics.DrawString("No Tlp: 0812", f10, Brushes.Black, centermargin, 65, tengah)

        e.Graphics.DrawString("Petugas", f10, Brushes.Black, 20, 115)
        e.Graphics.DrawString(":", f10, Brushes.Black, 100, 115)
        e.Graphics.DrawString("Rio", f10, Brushes.Black, 120, 115)

        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 130)
        e.Graphics.DrawString("Bulan", f10, Brushes.Black, 20, 150)
        e.Graphics.DrawString("tanggal bayar", f10, Brushes.Black, 200, 150)
        e.Graphics.DrawString("jumlah bayar", f10, Brushes.Black, 450, 150)
        dgv_user.AllowUserToAddRows = False

        Dim tinggi As Integer
        For baris As Integer = 0 To dgv_user.RowCount - 1
            tinggi += 20
            e.Graphics.DrawString(dgv_user.Rows(baris).Cells(0).Value.ToString, f10, Brushes.Black, 20, 160 + tinggi)
            e.Graphics.DrawString(dgv_user.Rows(baris).Cells(1).Value.ToString, f10, Brushes.Black, 200, 160 + tinggi)
            e.Graphics.DrawString(dgv_user.Rows(baris).Cells(2).Value.ToString, f10, Brushes.Black, 450, 160 + tinggi)


        Next
        tinggi = 110 + tinggi
        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 400)
        e.Graphics.DrawString("Thank You .....", f10, Brushes.Black, centermargin, 450, tengah)


    End Sub

    Sub printPD()
        PrintDoc.PrinterSettings.PrinterName = "Microsoft Print to PDF"
        PrintDoc.Print()
    End Sub

    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 700, 700)
        PD.DefaultPageSettings = pagesetup
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class