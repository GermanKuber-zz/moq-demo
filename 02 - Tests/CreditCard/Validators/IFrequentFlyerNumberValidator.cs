using System;

namespace CreditCard.Validators
{
    //TODO: 02 - Agrego una interface de validaci�n  
    public interface IFrequentFlyerNumberValidator
    {
        bool IsValid(string frequentFlyerNumber);
        void IsValid(string frequentFlyerNumber, out bool isValid);
    }
}