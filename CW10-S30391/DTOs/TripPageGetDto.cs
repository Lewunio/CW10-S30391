namespace CW10_S30391;

public class TripPageGetDto
{
    public int PageNum {get; set;}
    public int PageSize {get; set;}
    public int AllPages {get; set;}
    public List<TripGetDto> Trips {get; set;}
}