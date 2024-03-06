namespace MyBGList.DTO
{
  public class RestDTO<T>
  {
    public List<LinkDTO> Links { get; set; }

    public T Data { get; set; } = default!;
  }
}