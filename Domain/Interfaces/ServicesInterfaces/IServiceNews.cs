﻿using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.ServicesInterfaces
{
    public interface IServiceNews
    {
        Task AddNews(News news);
        Task UploadNews(News news);
        Task<List<News>> GetAllNews();
    }
}
