Imports System.Collections.Generic
Imports TripServiceKata.TripServiceKata.User
Imports TripServiceKata.TripServiceKata.Exception

Namespace TripServiceKata.Trip
    Public Class TripService
        Public Function GetTripsByUser(ByVal user As User.User) As List(Of Trip)
            Dim tripList As New List(Of Trip)()
            Dim loggedUser As User.User = UserSession.GetInstance().GetLoggedUser()
            Dim isFriend As Boolean = False
            If loggedUser IsNot Nothing Then
                For Each [friend] As User.User In user.GetFriends()
                    If [friend].Equals(loggedUser) Then
                        isFriend = True
                        Exit For
                    End If
                Next
                If isFriend Then
                    tripList = TripDAO.FindTripsByUser(user)
                End If
                Return tripList
            Else
                Throw New UserNotLoggedInException()
            End If
        End Function
    End Class
End Namespace