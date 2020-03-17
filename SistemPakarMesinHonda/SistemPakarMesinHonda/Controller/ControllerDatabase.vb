Imports System.Data.OleDb
Public Class ControllerDatabase
    Dim connectionString = "Provider=SQLNCLI11;Data Source=(LocalDb)\MSSQLLocalDB;Integrated Security=SSPI;Initial Catalog=DBPAKARMESINHONDA"
    Dim Koneksi As New OleDbConnection(connectionString)

    Public Function bukaKoneksi() As OleDbConnection
        Koneksi.Open()
        Return Koneksi
    End Function

    Public Function tutupKoneksi() As OleDbConnection
        Koneksi.Close()
        Return Koneksi
    End Function

End Class
