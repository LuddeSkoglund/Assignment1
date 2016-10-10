using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models {
   public class Player {
      public Int32 PlayerId { get; set; }
      public String Name { get; private set; }
      public Boolean IsFinished { get; set; }
      public Boolean IsThick { get; private set; }
      public Hand Hand { get; set; }
      private Int32 idx ;

      /// <summary>
      /// Constructor
      /// </summary>
      /// <param name="aName"></param>
      /// <param name="aIsfinished"></param>
      /// <param name="aIsThick"></param>
      /// <param name="id"></param>
      public Player(String aName, Boolean aIsfinished = false, Boolean aIsThick = false, Int32 id = 0) {
         PlayerId = id;
         
         Name = aName;
         IsFinished = aIsfinished;
         IsThick = aIsThick;
         Hand = new Hand();
      }

      /// <summary>
      /// Check if thick (Score higher than 21)
      /// </summary>
      /// <returns></returns>
      public Boolean isThick() {
         return Hand.Score > 21;
      }

      /// <summary>
      /// Calculate position
      /// </summary>
      /// <param name="aPositionX"></param>
      /// <returns></returns>
      public Int32 calculate(Int32 aPositionX) {
         
         aPositionX = aPositionX + 200;
         aPositionX = aPositionX - (1 * 200);
         
         Int32 ret = aPositionX - (Hand.NbrOfCards * 15);
         return ret;
      }

      /// <summary>
      /// Check if black jack
      /// </summary>
      /// <returns></returns>
      public Boolean hasBlackJack() {
         return Hand.Score == 21;
      }

      /// <summary>
      /// Reset
      /// </summary>
      public void newRound() {
         IsThick = false;
         IsFinished = false;
         Hand = new Hand();
      }
   }
}

