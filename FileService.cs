using System.IO;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using TimeTracker;


public class FileService
{
    private readonly string filePath;

    public FileService(string fileName)
    {
        filePath = Path.Combine(FileSystem.AppDataDirectory, fileName);
    }

    public async Task SaveTimeEntriesAsync(IEnumerable<TimeEntry> entries)
    {
        var json = JsonSerializer.Serialize(entries);
        await File.WriteAllTextAsync(filePath, json);
    }

    public async Task<List<TimeEntry>> LoadTimeEntriesAsync()
    {
        if (!File.Exists(filePath))
            return new List<TimeEntry>();

        var json = await File.ReadAllTextAsync(filePath);
        return JsonSerializer.Deserialize<List<TimeEntry>>(json) ?? new List<TimeEntry>();
    }
}

