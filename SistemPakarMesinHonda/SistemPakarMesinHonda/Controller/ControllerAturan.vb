Imports SistemPakarMesinHonda

Public Class ControllerAturan : Implements InterfaceAturan

    Public Sub CreateData(objek As Object) Implements InterfaceAturan.CreateData
        Koneksi.tutupKoneksi()
        Dim query As New OleDb.OleDbCommand(String.Format("INSERT INTO aturan VALUES ('{0}','{1}')", objek.id_aturan_, objek.id_kerusakan_), Koneksi.bukaKoneksi)
        query.ExecuteNonQuery()
    End Sub

    Public Sub UpdateData(objek As Object) Implements InterfaceAturan.UpdateData
        Koneksi.tutupKoneksi()
        Dim query As New OleDb.OleDbCommand(String.Format("UPDATE aturan SET id_kerusakan='{0}' WHERE id_aturan='{1}'", objek.id_kerusakan_, objek.id_gejala_), Koneksi.bukaKoneksi())
        query.ExecuteNonQuery()
    End Sub

    Public Sub DeleteData(id As String) Implements InterfaceAturan.DeleteData
        Koneksi.tutupKoneksi()
        Dim query As New OleDb.OleDbCommand(String.Format("DELETE FROM aturan WHERE id_aturan='{0}'", id), Koneksi.bukaKoneksi())
        query.ExecuteNonQuery()
    End Sub

    Public Function ReadData() As DataSet Implements InterfaceAturan.ReadData
        Koneksi.tutupKoneksi()
        Dim adapter As New OleDb.OleDbDataAdapter(String.Format("SELECT aturan.id_aturan, aturan.id_kerusakan, kerusakan.nama_kerusakan FROM aturan INNER JOIN kerusakan ON kerusakan.id_kerusakan=aturan.id_kerusakan"), Koneksi.bukaKoneksi())
        Dim ds As New DataSet
        adapter.Fill(ds, "tabelaturan")
        Return ds
    End Function
End Class
