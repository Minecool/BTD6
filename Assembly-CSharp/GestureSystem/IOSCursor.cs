namespace GestureSystem;

public class IOSCursor : Cursor, ICursor
{

	public IOSCursor() { }

	protected virtual void OnSwitchedInputMode(InputMode mode) { }

	public virtual void Update() { }

}

