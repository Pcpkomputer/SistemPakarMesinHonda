Public Class EntitasAturan
    Private id_aturan, id_kerusakan As String

    Public Property id_aturan_ As String
        Get
            Return id_aturan
        End Get
        Set(value As String)
            id_aturan = value
        End Set
    End Property

    Public Property id_kerusakan_ As String
        Get
            Return id_kerusakan
        End Get
        Set(value As String)
            id_kerusakan = value
        End Set
    End Property
End Class
