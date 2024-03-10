using Microsoft.AspNetCore.Mvc;
using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SearchProgamModul3.Server.Models;
using SearchProgamModul3.Shared.Models;
using System.Net;
using SearchProgamModul3.Client.Search;
using SearchProgamModul3.Server.SearchMehanics;

namespace SearchProgamModul3.Server.Controllers
{
    [ApiController]
    [Route("Database")]
    public class DatabaseController : ControllerBase
    {
        private readonly IDatabaseRepository Repository = new DatabaseDBContext();



        public DatabaseController(IDatabaseRepository shoppingRepository)
        {
            if (Repository == null && shoppingRepository != null)
            {
                Repository = shoppingRepository;
                Console.WriteLine("Repository initialized");


            }
        }

        [HttpGet]
        public IEnumerable<Word> GetAllWords()
        {
            return Repository.GetAllWords();
        }

        [HttpGet("{id}")]
        public Word GetWord(int id)
        {
            return Repository.GetWord(id);
        }


        [HttpGet("names")]
        public SearchResult GetWordFreduncy([FromQuery] string query, [FromQuery] string caseSensitiveFlag)
        {
            SearchLogic searchLogic = new SearchLogic(Repository);

            string[] queryList = query.Split("_");
            return searchLogic.Search(queryList, 10, caseSensitiveFlag == "True");
        }
    }
}
