Imports TripServiceKata.TripServiceKata.Exception

Namespace TripServiceKata.User
    Public Class UserSession
        Private Shared ReadOnly userSession As New UserSession()

        Private Sub New()
        End Sub

        Public Shared Function GetInstance() As UserSession
            Return userSession
        End Function

        Public Function IsUserLoggedIn(ByVal user As User) As Boolean
            Throw New DependendClassCallDuringUnitTestException("UserSession.IsUserLoggedIn() should not be called in an unit test")
        End Function

        Public Function GetLoggedUser() As User
            Throw New DependendClassCallDuringUnitTestException("UserSession.GetLoggedUser() should not be called in an unit test")
        End Function
    End Class
End Namespace