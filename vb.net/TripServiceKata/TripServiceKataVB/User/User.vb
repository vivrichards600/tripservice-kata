Imports System.Collections.Generic

Namespace TripServiceKata.User
    Public Class User
        'Private trips As New List(Of Trip.Trip)()
        Private friends As New List(Of User)()

        Public Function GetFriends() As List(Of User)
            Return friends
        End Function

        Public Sub AddFriend(ByVal user As User)
            friends.Add(user)
        End Sub

        Public Sub AddTrip(ByVal trip As Trip.Trip)
            trips.Add(trip)
        End Sub

        Public Function Trips() As List(Of Trip.Trip)
            Return Trips
        End Function

    End Class
End Namespace