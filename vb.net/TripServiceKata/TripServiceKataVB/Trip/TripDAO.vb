Imports System.Collections.Generic
Imports TripServiceKata.TripServiceKata.Exception

Namespace TripServiceKata.Trip
    Public Class TripDAO
        Public Shared Function FindTripsByUser(ByVal user As User.User) As List(Of Trip)
            Throw New DependendClassCallDuringUnitTestException("TripDAO should not be invoked on an unit test.")
        End Function
    End Class
End Namespace