package org.craftedsw.tripservicekata.user

import org.craftedsw.tripservicekata.trip.Trip

class UserBuilder {

  var friendList: Seq[User] = List()
  var tripList: Seq[Trip] = List()

  def friendsWith(friends: User*) = {
    friendList = friends
    this
  }

  def withTripsTo(trips: Trip*) = {
    tripList = trips
    this
  }

  def build(): User = {
    val user = new User
    friendList foreach(user addFriend)
    tripList foreach(user addTrip)
    user
  }

}

object UserBuilder {

  def aUser(): UserBuilder = {
    new UserBuilder
  }

}
