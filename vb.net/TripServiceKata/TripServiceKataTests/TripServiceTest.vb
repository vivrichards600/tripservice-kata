Imports TripServiceKata.TripServiceKata.User
Imports TripServiceKata.TripServiceKata.Exception
Imports TripServiceKata.TripServiceKata.Trip

Namespace TripServiceKata.Tests

    <TestClass()>
    Public Class TripServiceTest

        Private testContextInstance As TestContext

        '''<summary>
        '''Gets or sets the test context which provides
        '''information about and functionality for the current test run.
        '''</summary>
        Public Property TestContext() As TestContext
            Get
                Return testContextInstance
            End Get
            Set(ByVal value As TestContext)
                testContextInstance = value
            End Set
        End Property

#Region "Additional test attributes"
        '
        ' You can use the following additional attributes as you write your tests:
        '
        ' Use ClassInitialize to run code before running the first test in the class
        ' <ClassInitialize()> Public Shared Sub MyClassInitialize(ByVal testContext As TestContext)
        ' End Sub
        '
        ' Use ClassCleanup to run code after all tests in a class have run
        ' <ClassCleanup()> Public Shared Sub MyClassCleanup()
        ' End Sub
        '
        ' Use TestInitialize to run code before running each test
        ' <TestInitialize()> Public Sub MyTestInitialize()
        ' End Sub
        '
        ' Use TestCleanup to run code after each test has run
        ' <TestCleanup()> Public Sub MyTestCleanup()
        ' End Sub
        '
#End Region

        <TestMethod()>
        <ExpectedException(GetType(UserNotLoggedInException))> _
        Public Sub TestUserNotLoggedInThrowsException()
           
            'Given we have a guest
            Dim GUEST As New User

            'When we call get trips by user we should get an exception as user is not logged in
            Dim tripService As New TripService
            tripService.GetTripsByUser(GUEST)

        End Sub

      
    End Class

End Namespace