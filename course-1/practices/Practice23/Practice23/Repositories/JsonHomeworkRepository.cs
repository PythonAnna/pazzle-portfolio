using Practice23.Models;
using System.Text.Json;

namespace Practice23.Repositories
{
    public class JsonHomeworkRepository : IHomeworkRepository
    {
        private readonly string _path;
        private readonly JsonSerializerOptions _opts = new()
        {
            PropertyNameCaseInsensitive = true
        };

        public JsonHomeworkRepository(string path)
        {
            _path = path;
            if (!File.Exists(_path))
            {
                var sample = new HomeworkFile
                {
                    Groups = new List<GroupHomework>
                    {
                        new GroupHomework
                        {
                            Group = "ПР-2-А",
                            Days = new List<DayHomework>
                            {
                                new DayHomework {Day = "Tuesday", Homework = new List<Homework>{new Homework("Закрепить тему \"Двойные интегралы\"", "Высшая математика", "Kotova")} },
                                new DayHomework {Day = "Wednesday", Homework = new List<Homework>{new Homework("Выучить новые слова, перевести текст", "Иностранный язык", "Petrov")} },
                                new DayHomework {Day = "Friday", Homework = new List<Homework>{new Homework("Подготовиться к контрольной работе", "МДК 02.03.", "Umnova")} }
                            }
                        }
                    }
                };
                File.WriteAllText(_path, JsonSerializer.Serialize(sample, new JsonSerializerOptions { WriteIndented = true }));
            }
        }

        public HomeworkFile Load()
        {
            using var s = File.OpenRead(_path);
            return JsonSerializer.Deserialize<HomeworkFile>(s, _opts) ?? new HomeworkFile();
        }
    }
}
