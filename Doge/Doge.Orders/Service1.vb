Imports System.Collections.Generic
Imports System.Linq
Imports Doge.Model

Public Class Service1
    Implements IService1

    Public Property ConnString As String Implements IService1.ConnString
    Private Shared ReadOnly now1 As Date = Date.Now
    Private orders As Order() = {
                        New Order With {.OrderId = "F-034", .RequiredShippedTimestamp = now1.AddSeconds(100).Ticks},
                        New Order With {.OrderId = "F-055", .RequiredShippedTimestamp = now1.AddSeconds(30).Ticks},
                        New Order With {.OrderId = "F-089", .RequiredShippedTimestamp = now1.AddSeconds(45).Ticks},
                        New Order With {.OrderId = "F-144", .RequiredShippedTimestamp = now1.AddSeconds(15).Ticks},
                        New Order With {.OrderId = "F-233", .RequiredShippedTimestamp = now1.AddSeconds(86).Ticks},
                        New Order With {.OrderId = "F-377", .RequiredShippedTimestamp = now1.AddSeconds(34).Ticks},
                        New Order With {.OrderId = "F-610", .RequiredShippedTimestamp = now1.AddSeconds(29).Ticks}}

    Public Function GetOrders() As List(Of Order) Implements IService1.GetOrders
        Return orders.ToList()
    End Function

    Protected Overrides Sub OnStart(ByVal args() As String)

    End Sub

    Protected Overrides Sub OnStop()

    End Sub

End Class
