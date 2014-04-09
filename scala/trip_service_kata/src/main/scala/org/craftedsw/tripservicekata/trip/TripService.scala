package org.craftedsw.tripservicekata.trip

import org.craftedsw.tripservicekata.user.{UserSession, User}
import org.craftedsw.tripservicekata.exception.UserNotLoggedInException

import scala.util.control.Breaks._

class TripService {

	def getTripsByUser(user: User): List[Trip] = {
    if (getLoggedInUser == null) throw new UserNotLoggedInException

    if (user isFriendsWith getLoggedInUser) tripsBy(user)
    else List()
  }

  protected def tripsBy(user: User): List[Trip] = {
    TripDAO.findTripsByUser(user)
  }

  protected def getLoggedInUser: User = {
    UserSession getLoggedUser()
  }
}
