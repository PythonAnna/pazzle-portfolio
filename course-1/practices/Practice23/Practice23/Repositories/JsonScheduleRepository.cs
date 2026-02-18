using Practice23.Models;
using System.Text.Json;

namespace Practice23.Repositories;
public class JsonScheduleRepository : IScheduleRepository
{
    private readonly string _path;
    private readonly JsonSerializerOptions _opts = new() { PropertyNameCaseInsensitive = true };

    public JsonScheduleRepository(string path)
    {
        _path = path;
        if (!File.Exists(_path))
        {
            var sample = new ScheduleFile
            {
                Groups = new List<GroupSchedule>
               {
                   new GroupSchedule
                   {
                       Group = "ПР-2-А",
                       Days = new List<DaySchedule>
                       {
                           new DaySchedule { Day = "Monday", Lessons = new List<Lesson> { new Lesson("13:25", "МДК 02.01.", "Ivanov") } },
                           new DaySchedule { Day = "Tuesday", Lessons = new List<Lesson> { new Lesson("09:45", "Высшая математика", "Kotova") } },
                           new DaySchedule { Day = "Wednesday", Lessons = new List<Lesson> { new Lesson("09:45", "Иностранный язык", "Petrov") } },
                           new DaySchedule { Day = "Thursday", Lessons = new List<Lesson> { new Lesson("09:45", "МДК 02.02.", "Ivanov") } },
                           new DaySchedule { Day = "Fridey", Lessons = new List<Lesson> { new Lesson("08:00", "Численные методы", "Kotova") } },
                           new DaySchedule { Day = "Saturday", Lessons = new List<Lesson> { new Lesson("13:25", "МДК 02.03.", "Umnova") } }
                       }
                   }
               }
            };
            File.WriteAllText(_path, JsonSerializer.Serialize(sample, new JsonSerializerOptions { WriteIndented = true }));
        }
    }

    public ScheduleFile Load()
    {
        using var s = File.OpenRead(_path);
        return JsonSerializer.Deserialize<ScheduleFile>(s, _opts) ?? new ScheduleFile();
    }
}

