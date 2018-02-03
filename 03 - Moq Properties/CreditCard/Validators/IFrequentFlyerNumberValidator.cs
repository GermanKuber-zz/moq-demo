using System;

namespace CreditCard.Validators

{
    public interface ILicenseData
    {
        string LicenseKey { get; }
    }

    public interface IServiceInformation
    {
        ILicenseData License { get; set; }
    }

    public enum ValidationMode
    {
        Quick,
        Detailed
    }

    public interface IFrequentFlyerNumberValidator
    {
        bool IsValid(string frequentFlyerNumber);
        void IsValid(string frequentFlyerNumber, out bool isValid);
        //TODO:04 - Hago refactor en nuevas interfaces
        IServiceInformation ServiceInformation { get; }
        ValidationMode ValidationMode { get; set; }

        //TODO: 01 - Agrego una propiedad con la licencia 
        //string LicenseKey { get; }
    }
}