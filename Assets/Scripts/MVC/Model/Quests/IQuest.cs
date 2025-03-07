namespace manulogics.Quests
{
    public interface IQuest
    {
        string Title { get; }
        bool IsCompleted { get; }
        void StartQuest();
        void CheckProgress();
    }
}