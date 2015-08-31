''' <summary>
''' Stellt ein Gericht dar
''' </summary>
Public Class Gericht

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

    Private _beschreibung As String
    Public Property beschreibung() As String
        Get
            Return _beschreibung
        End Get
        Set(ByVal value As String)
            _beschreibung = value
        End Set
    End Property

    Private _photo As String
    Public Property photo() As String
        Get
            Return _photo
        End Get
        Set(ByVal value As String)
            _photo = value
        End Set
    End Property

    Private _zeigen As Boolean
    Public Property zeigen() As Boolean
        Get
            Return _zeigen
        End Get
        Set(ByVal value As Boolean)
            _zeigen = value
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

    Private _zutaten As List(Of Zutat)
    Public Property zutaten() As List(Of Zutat)
        Get
            Return _zutaten
        End Get
        Set(ByVal value As List(Of Zutat))
            _zutaten = value
        End Set
    End Property

    Public Sub New(ByVal name As String, ByVal beschreibung As String, ByVal photo As String, ByVal zeigen As Boolean, ByVal preis As Double)
        Me.name = name
        Me.beschreibung = beschreibung
        Me.photo = photo
        Me.zeigen = zeigen
        Me.preis = preis
        Me.zutaten = New List(Of Zutat)
        Me.id = -1
    End Sub

End Class
