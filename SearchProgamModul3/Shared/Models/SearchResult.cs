using SearchProgamModul3.Shared.Models;

namespace SearchProgamModul3.Shared.Models
{
    public class SearchResult
    {

        public String[] Query { get; } = Array.Empty<String>();

        public int Hits { get; }

        public List<DocumentHit> DocumentHits { get; } = new List<DocumentHit>();

        public List<string> Ignored { get; } = new List<string>();

        public TimeSpan TimeUsed { get; }
        public SearchResult(String[] query, int hits, List<DocumentHit> documents, List<string> ignored, TimeSpan timeUsed)
        {
            Query = query;
            Hits = hits;
            DocumentHits = documents;
            Ignored = ignored;
            TimeUsed = timeUsed;
        }
        public SearchResult()
        {
            
        }
    }
}
