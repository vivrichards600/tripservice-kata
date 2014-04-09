package org.craftedsw.tripservicekata.trip

import org.craftedsw.tripservicekata.infrastructure.UnitSpec
import org.craftedsw.tripservicekata.exception.UserNotLoggedInException
import org.craftedsw.tripservicekata.user.User
import org.craftedsw.tripservicekata.user.UserBuilder.aUser

class TripServiceSpec extends UnitSpec  {

  var loggedInUser: User = null
  val GUEST = null
  val REGISTERED_USER = new User

  "Trip service" should {
    "Throw an exception if the user is not logged in" in {
      loggedInUser = GUEST

      an [UserNotLoggedInException] should be thrownBy tripService.getTripsByUser(A_USER)
    }

    "return no trips when users are not friends" in new context {
      val stranger = aUser()
                        .friendsWith(ANOTHER_USER)
                        .withTripsTo(BRAZIL)
                        .build()

      val trips = tripService.getTripsByUser(stranger)

      trips shouldBe empty
    }

    "return trips when users are friends" in new context {
      val friend = aUser()
                      .friendsWith(REGISTERED_USER, ANOTHER_USER)
                      .withTripsTo(BRAZIL, LONDON)
                      .build()

      val trips = tripService.getTripsByUser(friend)

      trips should be(List(BRAZIL, LONDON))
    }

  }


  class TestableTripService extends TripService {
    override protected def getLoggedInUser: User = (loggedInUser)

    override protected def tripsBy(user: User): List[Trip] = user trips
  }
  
  val A_USER = new User
  val ANOTHER_USER = new User
  val BRAZIL = new Trip
  val LONDON = new Trip
  val tripService = new TestableTripService

  trait context {
    loggedInUser = REGISTERED_USER
  }
}

