using System;

namespace CreditCard.Validators
{

    public class FrequentFlyerNumberValidatorService : IFrequentFlyerNumberValidator
    {
        //TODO: 02 - Implemento la propiedad
        public string LicenseKey => throw new NotImplementedException();

        public bool IsValid(string frequentFlyerNumber)
        {
            throw new NotImplementedException("Demo");
        }

        public void IsValid(string frequentFlyerNumber, out bool isValid)
        {
            throw new NotImplementedException("Demo");
        }
        public IServiceInformation ServiceInformation
        {
            get
            {
                throw new NotImplementedException("Demo");
            }
        }

        public ValidationMode ValidationMode
        {
            get => throw new NotImplementedException("Demo");
            set => throw new NotImplementedException("Demo");
        }
    }
}
