namespace BibleRecallTrainer.Models;
public sealed class Chapter { public string Book { get; init; } = string.Empty; public int Number { get; init; } public IReadOnlyList<BibleVerse> Verses { get; init; } = Array.Empty<BibleVerse>(); }
