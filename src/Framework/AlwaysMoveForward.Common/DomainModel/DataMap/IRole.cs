﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PucksAndProgramming.Framework.Common.DomainModel.DataMap
{
    public interface IRole
    {
        int RoleId { get; set; }
        string Name { get; set; }
    }
}
