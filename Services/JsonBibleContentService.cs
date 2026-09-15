using System.Text.Json;
using BibleRecallTrainer.Models;
namespace BibleRecallTrainer.Services;
public sealed class JsonBibleContentService : IBibleContentService { public async Task<Chapter?> GetChapterAsync(string book, int chapterNumber) { await using var stream = await FileSystem.OpenAppPackageFileAsync($"Bible/{book.Replace(" ", string.Empty)}.json"); var chapters = await JsonSerializer.DeserializeAsync<List<Chapter>>(stream, new JsonSerializerOptions { PropertyNameCaseInsensitive = true }); return chapters?.FirstOrDefault(c => c.Number == chapterNumber); } }
