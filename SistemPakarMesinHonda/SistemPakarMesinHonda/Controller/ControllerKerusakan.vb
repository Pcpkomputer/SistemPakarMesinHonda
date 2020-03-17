Imports SistemPakarMesinHonda

Public Class ControllerKerusakan : Implements InterfaceKerusakan

    Public Sub CreateData(objek As Object) Implements InterfaceKerusakan.CreateData
        Koneksi.tutupKoneksi()
        Dim query As New OleDb.OleDbCommand(String.Format("INSERT INTO kerusakan VALUES ('{0}','{1}','{2}','{3}')", objek.id_kerusakan_, objek.nama_kerusakan_, objek.sistem_kerusakan_, objek.solusi_), Koneksi.bukaKoneksi)
        query.ExecuteNonQuery()
    End Sub

    Public Sub UpdateData(objek As Object) Implements InterfaceKerusakan.UpdateData
        Koneksi.tutupKoneksi()
        Dim query As New OleDb.OleDbCommand(String.Format("UPDATE kerusakan SET nama_kerusakan='{0}',sistem_kerusakan='{1}',solusi='{2}' WHERE id_kerusakan='{3}'", objek.nama_kerusakan_, objek.sistem_kerusakan_, objek.solusi_, objek.id_kerusakan_), Koneksi.bukaKoneksi())
        query.ExecuteNonQuery()
    End Sub

    Public Sub DeleteData(id As String) Implements InterfaceKerusakan.DeleteData
        Koneksi.tutupKoneksi()
        Dim query As New OleDb.OleDbCommand(String.Format("DELETE FROM kerusakan WHERE id_kerusakan='{0}'", id), Koneksi.bukaKoneksi())
        query.ExecuteNonQuery()
    End Sub

    Public Function ReadData() As DataSet Implements InterfaceKerusakan.ReadData
        Koneksi.tutupKoneksi()
        Dim adapter As New OleDb.OleDbDataAdapter(String.Format("SELECT * FROM kerusakan"), Koneksi.bukaKoneksi())
        Dim ds As New DataSet
        adapter.Fill(ds, "tabelkerusakan")
        Return ds
    End Function
End Class
