﻿/**
 * Copyright (c) 2009 Arthur Correa.
 * All rights reserved. This program and the accompanying materials
 * are made available under the terms of the Common Public License v1.0
 * which accompanies this distribution, and is available at
 * http://www.opensource.org/licenses/cpl1.0.php
 *
 * Contributors:
 *    Arthur Correa – initial contribution
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace PucksAndProgramming.Common.DataLayer
{
    public interface IUnitOfWork : IDisposable
    {
        IDisposable BeginTransaction();

        IDisposable BeginTransaction(IsolationLevel isolationLevel);

        void EndTransaction(bool shouldCommit);

        void Flush();
    }
}
