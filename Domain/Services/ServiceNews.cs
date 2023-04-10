using Domain.Interfaces;
using Domain.Interfaces.ServicesInterfaces;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class ServiceNews : IServiceNews
    {
        private readonly INews _INews;

        public ServiceNews(INews INews)
        {
            _INews = INews;     
        }

        public async Task AddNews(News news)
        {
            var validateTitle = news.StringPropoertyValidation(news.Title, "Title");
            var validateDescription = news.StringPropoertyValidation(news.Description, "Description"); 
            
            if (validateTitle && validateDescription)
            {
                news.UploadDate = DateTime.Now;
                news.RegisterDate = DateTime.Now;
                news.Active = true;
                await _INews.Create(news);
            }
        }

        public async Task<List<News>> GetAllNews()
        {
            return await _INews.GetNews(n => n.Active);
        }

        public async Task UploadNews(News news)
        {
            var validateTitle = news.StringPropoertyValidation(news.Title, "Title");
            var validateDescription = news.StringPropoertyValidation(news.Description, "Description");

            if (validateTitle && validateDescription)
            {
                news.UploadDate = DateTime.Now;
                news.RegisterDate = DateTime.Now;
                news.Active = true;
                await _INews.Upload(news);
            }
        }
    }
}
