using SearchProgamModul3.Shared.Models;

namespace SearchProgamModul3.Client.Search
{
    public class DocumentHit
    {
        public DocumentHit(BEDocument doc, int noOfHits, List<string> missing)
        {
            Document = doc;
            NoOfHits = noOfHits;
            Missing = missing;
        }

        public BEDocument Document { get; }

        public int NoOfHits { get; }

        public List<string> Missing { get; }
    }
}
