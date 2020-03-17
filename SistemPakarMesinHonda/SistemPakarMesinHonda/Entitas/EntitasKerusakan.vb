Public Class EntitasKerusakan
    Private id_kerusakan, nama_kerusakan, sistem_kerusakan, solusi As String

    Public Property id_kerusakan_ As String
        Get
            Return id_kerusakan
        End Get
        Set(value As String)
            id_kerusakan = value
        End Set
    End Property

    Public Property nama_kerusakan_ As String
        Get
            Return nama_kerusakan
        End Get
        Set(value As String)
            nama_kerusakan = value
        End Set
    End Property

    Public Property sistem_kerusakan_ As String
        Get
            Return sistem_kerusakan
        End Get
        Set(value As String)
            sistem_kerusakan = value
        End Set
    End Property

    Public Property solusi_ As String
        Get
            Return solusi
        End Get
        Set(value As String)
            solusi = value
        End Set
    End Property
End Class
