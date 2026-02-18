namespace Practice23.Models
{
    public class GroupHomework
    {
        public string Group { get; set; } = string.Empty;
        public List<DayHomework> Days { get; set; } = new();
    }
}