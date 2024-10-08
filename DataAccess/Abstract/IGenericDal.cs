﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IGenericDal<T>
    {
        void Instert(T t);
        void Delete(T t);
        void Update(T t);
        List<T> GetList();   
    }
}
