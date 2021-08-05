﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularApp.Models
{
    public interface IUserDatabaseSettings
    {
        string UserCollectionName {  get;  set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
