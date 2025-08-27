namespace GestureSystem;

public class MouseCursor : Cursor, ICursor
{
	private Vector2 previousMousePosition; //Field offset: 0x70

	public MouseCursor() { }

	protected virtual void OnSwitchedInputMode(InputMode mode) { }

	public virtual void Update() { }

	private bool UpdateMouse() { }

}

