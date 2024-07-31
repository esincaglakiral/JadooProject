﻿using JadooProject.DataAccess.Entities;

namespace JadooProject.DataAccess.Abstract
{
    public interface IDestinationDal : IRepository<Destination>
    {
        int GetDestinationCount();
        List<Destination> GetLast6Destination();
        List<Destination> GetLast3Destination();
        Destination GetLastDestination();
    }
}
