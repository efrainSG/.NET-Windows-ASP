Imports Doge.Model

Public Class Service1
    Implements IService1

    Public Property ConnString As String Implements IService1.ConnString

    Public Function GetOrders() As List(Of Order) Implements IService1.GetOrders
        Dim orders = New List(Of Order)
        Dim RandomSeconds = New Random(300)

        Select Case ConnString
            Case "DbConnString"
                orders.AddRange({
                        New Order With {.OrderId = "DB-001", .RequiredShippedTimestamp = DateTime.Now.AddSeconds(RandomSeconds.Next()).Ticks},
                        New Order With {.OrderId = "DB-002", .RequiredShippedTimestamp = DateTime.Now.AddSeconds(RandomSeconds.Next()).Ticks},
                        New Order With {.OrderId = "DB-003", .RequiredShippedTimestamp = DateTime.Now.AddSeconds(RandomSeconds.Next()).Ticks},
                        New Order With {.OrderId = "DB-005", .RequiredShippedTimestamp = DateTime.Now.AddSeconds(RandomSeconds.Next()).Ticks},
                        New Order With {.OrderId = "DB-008", .RequiredShippedTimestamp = DateTime.Now.AddSeconds(RandomSeconds.Next()).Ticks},
                        New Order With {.OrderId = "DB-013", .RequiredShippedTimestamp = DateTime.Now.AddSeconds(RandomSeconds.Next()).Ticks},
                        New Order With {.OrderId = "DB-021", .RequiredShippedTimestamp = DateTime.Now.AddSeconds(RandomSeconds.Next()).Ticks}})

            Case "FileConnString"
                orders.AddRange({
                        New Order With {.OrderId = "F-034", .RequiredShippedTimestamp = DateTime.Now.AddSeconds(RandomSeconds.Next(150)).Ticks},
                        New Order With {.OrderId = "F-055", .RequiredShippedTimestamp = DateTime.Now.AddSeconds(RandomSeconds.Next(150)).Ticks},
                        New Order With {.OrderId = "F-089", .RequiredShippedTimestamp = DateTime.Now.AddSeconds(RandomSeconds.Next(150)).Ticks},
                        New Order With {.OrderId = "F-144", .RequiredShippedTimestamp = DateTime.Now.AddSeconds(RandomSeconds.Next(150)).Ticks},
                        New Order With {.OrderId = "F-233", .RequiredShippedTimestamp = DateTime.Now.AddSeconds(RandomSeconds.Next(150)).Ticks},
                        New Order With {.OrderId = "F-377", .RequiredShippedTimestamp = DateTime.Now.AddSeconds(RandomSeconds.Next(150)).Ticks},
                        New Order With {.OrderId = "F-610", .RequiredShippedTimestamp = DateTime.Now.AddSeconds(RandomSeconds.Next(150)).Ticks}})
        End Select
        Return orders
    End Function

    Protected Overrides Sub OnStart(ByVal args() As String)
        If args Is "1" Then
            ConnString = "DbConnString"
        ElseIf args Is "2" Then
            ConnString = "FileConnString"
        End If

    End Sub

    Protected Overrides Sub OnStop()

    End Sub

End Class
