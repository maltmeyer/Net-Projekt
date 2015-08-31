Public Class Ware

    Private _id As Integer
    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Private _gericht As Gericht
    Public Property gericht() As Gericht
        Get
            Return _gericht
        End Get
        Set(ByVal value As Gericht)
            _gericht = value
        End Set
    End Property

    Private _anzahl As Integer
    Public Property anzahl() As Integer
        Get
            Return _anzahl
        End Get
        Set(ByVal value As Integer)
            _anzahl = value
        End Set
    End Property

    Public Sub New(ByVal gericht As Gericht, ByVal anzahl As Integer)
        Me.gericht = gericht
        Me.anzahl = anzahl
        Me.id = -1
    End Sub
End Class
