Imports System.Data.OleDb

Public Interface InterfaceGejala
    Sub CreateData(objek As Object)
    Function ReadData() As DataSet
    Sub UpdateData(objek As Object)
    Sub DeleteData(id As String)
End Interface
