'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Zutaten
    Public Property Id As Integer
    Public Property Name As String
    Public Property Preis As Decimal

    Public Overridable Property Gericht_Zutaten As ICollection(Of Gericht_Zutaten) = New HashSet(Of Gericht_Zutaten)

End Class
