package org.craftedsw.tripservicekata.trip

import org.craftedsw.tripservicekata.user.{UserSession, User}
import org.craftedsw.tripservicekata.exception.UserNotLoggedInException

import scala.util.control.Breaks._

class TripService {

	def getTripsByUser(user: User): List[Trip] = {
		var tripList: List[Trip] = List()
		val loggedInUser = getLoggedInUser
		var isFriend = false
		if (loggedInUser != null) {
			breakable { for (friend <- user.friends()) {
          if (friend == loggedInUser) {
            isFriend = true
            break
          }
			}}
			if (isFriend) {
				tripList = tripsBy(user)
			}
			tripList
		} else {
			throw new UserNotLoggedInException
		}
	}

  protected def tripsBy(user: User): List[Trip] = {
    TripDAO.findTripsByUser(user)
  }

  protected def getLoggedInUser: User = {
    UserSession getLoggedUser()
  }
}
