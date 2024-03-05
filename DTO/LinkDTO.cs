namespace MyBGList.DTO
{
  public class LinkDTO
  {
    public string Href { get; set; }

    public string Rel { get; set; }

    public string Type { get; set; }
    
    public LinkDTO(string href, string rel, string type)
    {
      Href = href;
      Rel = rel;
      Type = type;
    }
  }
}