using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PucksAndProgramming.Framework.Common.DomainModel;

namespace PucksAndProgramming.Framework.Common.Security
{
    public interface ISecurityRepository
    {
        User GetUserInfo();
    }
}
