﻿using Core.JobTracking.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.JobTracking.DataAccess.Interfaces
{
    public interface INotificationDal : IGenericDal<Notification>
    {
        List<Notification> GetNotRead(int AppUserId);

        int GetNotReadNumber(int AppUserId);
    }
}
