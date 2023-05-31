Public Class Order
    Public Property OrderId As String
    Public Property RequiredShippedTimestamp As Long
    Public ReadOnly Property RequiredShippedDateTime As DateTime
        Get
            Return New DateTime(RequiredShippedTimestamp)
        End Get
    End Property
    Public Property DeliverAddress As String

End Class
