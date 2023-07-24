﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.DataAccessLayer.Infrustructure.IRepository
{
    public interface IUnitofWork
    {
         ICategoryRepository Category { get; }
        void Save();
    }
}