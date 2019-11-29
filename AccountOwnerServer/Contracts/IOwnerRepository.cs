using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IOwnerRepository : IDataRepository<Owner>
    {
        IEnumerable<Owner> GetAllOwners();
    }
}
