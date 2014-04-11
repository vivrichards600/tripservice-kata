Imports System.Runtime.Serialization

Namespace TripServiceKata.Exception
    <Serializable()> _
    Public Class DependendClassCallDuringUnitTestException
        Inherits System.Exception
        Public Sub New()
            MyBase.New()
        End Sub

        Public Sub New(ByVal message As String, ByVal innerException As System.Exception)
            MyBase.New(message, innerException)
        End Sub

        Public Sub New(ByVal message As String)
            MyBase.New(message)
        End Sub

        Private Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
            MyBase.New(info, context)
        End Sub
    End Class
End Namespace
