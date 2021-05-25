Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each i In GetObject("winmgmts:").ExecQuery("Select * from Win32_NetworkAdapter")
            ListBox1.Items.Add(i.Name)
        Next
    End Sub
End Class