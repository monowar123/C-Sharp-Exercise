using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BlackJackService
{
    
    [ServiceContract(SessionMode=SessionMode.Required)]
    public interface IBlackJack
    {
        //deals a card that has not been delt.
        [OperationContract]
        string DealCard();

        //creates and shuffle the deck
        [OperationContract]
        void Shuffle();

        //calculates the value of a hand
        [OperationContract]
        int GetHandValue(string delt);

        
    }


    
}
