''' <summary>
''' Stellt eine Bestellung dar und speichert Informationen über den Kunden und die Gerichte und deren Anzahl
''' </summary>
Public Class Bestellung

    Private _id As Integer
    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Private _vorname As String
    Public Property vorname() As String
        Get
            Return _vorname
        End Get
        Set(ByVal value As String)
            _vorname = value
        End Set
    End Property

    Private _nachname As String
    Public Property nachname() As String
        Get
            Return _nachname
        End Get
        Set(ByVal value As String)
            _nachname = value
        End Set
    End Property

    Private _hausnummer As Integer
    Public Property hausnummer() As Integer
        Get
            Return _hausnummer
        End Get
        Set(ByVal value As Integer)
            _hausnummer = value
        End Set
    End Property

    Private _gesamtpreis As Double
    Public Property gesamtpreis() As Double
        Get
            Return _gesamtpreis
        End Get
        Set(ByVal value As Double)
            _gesamtpreis = value
        End Set
    End Property

    Private _anrede As String
    Public Property anrede() As String
        Get
            Return _anrede
        End Get
        Set(ByVal value As String)
            _anrede = value
        End Set
    End Property

    Private _plz As Integer
    Public Property plz() As Integer
        Get
            Return _plz
        End Get
        Set(ByVal value As Integer)
            _plz = value
        End Set
    End Property

    Private _straße As String
    Public Property straße() As String
        Get
            Return _straße
        End Get
        Set(ByVal value As String)
            _straße = value
        End Set
    End Property

    Private _wohnort As String
    Public Property wohnort() As String
        Get
            Return _wohnort
        End Get
        Set(ByVal value As String)
            _wohnort = value
        End Set
    End Property

    Private _telefon As String
    Public Property telefon() As String
        Get
            Return _telefon
        End Get
        Set(ByVal value As String)
            _telefon = value
        End Set
    End Property

    Private _ware As List(Of Ware)
    Public Property waren() As List(Of Ware)
        Get
            Return _ware
        End Get
        Set(ByVal value As List(Of Ware))
            _ware = value
        End Set
    End Property

    Private _datum As Date
    Public Property datum() As DateTime
        Get
            Return _datum
        End Get
        Set(ByVal value As DateTime)
            _datum = value
        End Set
    End Property

    Public Sub New(ByVal vorname As String, ByVal nachname As String, ByVal hausnr As Integer, ByVal gesamtpreis As Double, ByVal anrede As String, ByVal plz As Integer, ByVal straße As String, ByVal wohnort As String, ByVal telefon As String)
        Me.vorname = vorname
        Me.nachname = nachname
        Me.hausnummer = hausnr
        Me.gesamtpreis = gesamtpreis
        Me.anrede = anrede
        Me.plz = plz
        Me.straße = straße
        Me.wohnort = wohnort
        Me.telefon = telefon
        Me.waren = New List(Of Ware)
        Me.id = -1
    End Sub


End Class
