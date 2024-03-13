using SearchProgamModul3.Shared.Models;
using System.Net.Http.Json;

namespace SearchProgamModul3.Client.Services
{
    public class DatabaseService : IDatabaseService
    {
        private readonly HttpClient _httpClient;
        public DatabaseService(HttpClient httpClient)
        {

            _httpClient = httpClient;

        }

        public Task<Word[]?> GetAllWords()
        {
            var result = _httpClient.GetFromJsonAsync<Word[]>("database/words");
            return result;
        }

        public Task<BEDocument[]?> GetDocDetails(List<int> docIds)
        {
            var result = _httpClient.GetFromJsonAsync<BEDocument[]>("database");
            return result;
        }
        public Task<Word?> GetWord(int id)
        {
            var result = _httpClient.GetFromJsonAsync<Word>("database/4");
            return result;
        }

        public Task<KeyValuePair<int, int>[]?> GetDocuments(List<int> wordIds)
        {
            throw new NotImplementedException();
        }

        public Task<int[]?> GetMissing(int docId, List<int> wordIds)
        {
            throw new NotImplementedException();
        }


        public Task<int[]?> GetWordIds(string[] query, out List<string> outIgnored, bool caseSensitive)
        {
            throw new NotImplementedException();
        }

        public Task<string[]?> WordsFromIds(List<int> wordIds)
        {
            throw new NotImplementedException();
        }

        public Task<SearchResult?> GetSearchResultWithCondition(string names, bool caseSensitiveFlag)
        {
            string caseString = caseSensitiveFlag ? "true" : "false";
            string input = $"database/names?query={names}&cs={caseString}";
            var result = _httpClient.GetFromJsonAsync<SearchResult>(input);
            return result;
        }
    }
}
