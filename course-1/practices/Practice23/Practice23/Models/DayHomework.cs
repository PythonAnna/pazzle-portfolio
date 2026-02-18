namespace Practice23.Models
{
    public class DayHomework
    {
        public string Day { get; set; } = string.Empty;
        public List<Homework> Homework { get; set; } = new();
    }
}
