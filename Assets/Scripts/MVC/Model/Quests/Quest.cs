public abstract class Quest : IQuest
{
    public string Title { get; private set; }
    public bool IsCompleted { get; protected set; }

    protected Quest(string title)
    {
        Title = title;
        IsCompleted = false;
    }
    
    public abstract void CheckProgress();
}
