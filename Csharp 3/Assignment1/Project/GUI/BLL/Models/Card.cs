using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL {
   public class Card {
      public Suits Suits { get; set; }
      public String ValueString { get; set; }
      public Value Value { get; set; }
      public Boolean FaceUp { get; set; }
      /// <summary>
      /// Constructor
      /// </summary>
      /// <param name="aSuits"></param>
      /// <param name="aValueString"></param>
      /// <param name="aValue"></param>
      /// <param name="aFaceUp"></param>
      public Card(Suits aSuits, String aValueString, Value aValue, Boolean aFaceUp) {
         Suits = aSuits;
         ValueString = aValueString;
         Value = aValue;
         FaceUp = aFaceUp;
      }

      

   }
}
