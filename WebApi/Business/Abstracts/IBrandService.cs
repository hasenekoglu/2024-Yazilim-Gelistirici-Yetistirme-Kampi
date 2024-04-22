﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Entities.Concretes;

namespace Business.Abstracts
{
    public interface IBrandService
    {
        CreatedBrandResponse Add(CreateBrandRequest brand);
        List<GetAllBrandResponse> GetAll();
    }
}
