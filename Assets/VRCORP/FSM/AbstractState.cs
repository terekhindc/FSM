public enum StatesEvents
{
    NONE,
    START,
    UPDATE,
    FINISHED
}

public abstract class AbstractState
{
    public StatesEvents StatesEvents { get; protected set; }

    public virtual bool OnEnabled ()
    {
        StatesEvents = StatesEvents.NONE;
        return true;
    }

    public virtual bool Start ()
    {
        StatesEvents = StatesEvents.START;
        return true;
    }

    public abstract void Update();

    public virtual bool OnExit ()
    {
        StatesEvents = StatesEvents.FINISHED;
        return true;
    }
}
