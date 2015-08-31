''' <summary>
''' Stellt eine Zutat dar
''' </summary>
Public Class Zutat

    Private _id As Integer
    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Private _name As String
    Public Property name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    Private _preis As Double
    Public Property preis() As Double
        Get
            Return _preis
        End Get
        Set(ByVal value As Double)
            _preis = value
        End Set
    End Property

    Public Sub New(ByVal name As String, ByVal preis As Double)
        Me.name = name
        Me.preis = preis
        Me.id = -1
    End Sub
End Class
