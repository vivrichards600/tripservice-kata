package org.craftedsw.tripservicekata.user

import org.craftedsw.tripservicekata.infrastructure.UnitSpec
import UserBuilder._

class UserSpec extends UnitSpec {
   "User" should {
     "inform when friends with another user" in {
       val user = aUser() .friendsWith(ANOTHER_USER) .build()

       user.isFriendsWith(ANOTHER_USER) shouldBe true
     }

     "inform when not friends with a stranger" in {
       val user = aUser() .friendsWith(ANOTHER_USER) .build()

       user.isFriendsWith(STRANGER) shouldBe false
     }
   }

   val ANOTHER_USER = new User
   val STRANGER = new User

}
