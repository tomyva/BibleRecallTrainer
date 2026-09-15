namespace BibleRecallTrainer.Models;
public enum ChapterLearningStatus { NotStarted, Learning, Mastered }
public sealed class LearningProgress { public string Book { get; init; } = string.Empty; public int ChapterNumber { get; init; } public ChapterLearningStatus Status { get; set; } = ChapterLearningStatus.NotStarted; public DateTimeOffset? LastStudiedAt { get; set; } }
