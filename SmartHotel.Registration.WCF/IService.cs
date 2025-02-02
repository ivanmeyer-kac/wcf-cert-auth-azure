﻿using SmartHotel.Registration.Wcf.Models;
using System.Collections.Generic;
using System.ServiceModel;

namespace SmartHotel.Registration.Wcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        IEnumerable<Models.Registration> GetTodayRegistrations();

        [OperationContract]
        RegistrationDaySummary GetTodayRegistrationSummary();

        [OperationContract]
        Models.Registration GetCheckin(int registrationId);

        [OperationContract]
        Models.Registration GetCheckout(int registrationId);
    }
}