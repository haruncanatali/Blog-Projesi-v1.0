﻿using BlogUygulamasi.DataAccess.Abstract;
using BlogUygulamasi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogUygulamasi.DataAccess.Concrete.EntityFramework
{
    public class YorumDal:EfRepositoryBase<Yorum,BlogUygulamasiContext>,IYorumDal
    {
    }
}
