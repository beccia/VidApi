using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VidyaApi.services
{

    
    public interface IArticleService
    {
        string[] GetArticles();
    }

}
