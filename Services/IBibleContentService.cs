using BibleRecallTrainer.Models;
namespace BibleRecallTrainer.Services;
public interface IBibleContentService { Task<Chapter?> GetChapterAsync(string book, int chapterNumber); }
