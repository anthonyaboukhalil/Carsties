namespace SearchService;

public class SearchParams
{
  // Is this a model ?
  public string SearchTerm { get; set; }
  public int PageNumber { get; set; }
  public int PageSize { get; set; }
  public string Seller { get; set; }
  public string Winner { get; set; }
  public string OrderBy { get; set; }
  public string FilterBy { get; set; }


}
