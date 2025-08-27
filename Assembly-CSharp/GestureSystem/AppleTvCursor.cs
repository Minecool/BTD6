namespace GestureSystem;

public class AppleTvCursor : Cursor, ICursor
{
	private Image cursorImage; //Field offset: 0x70
	private float timeTouchBegin; //Field offset: 0x78

	public AppleTvCursor() { }

	public virtual void Init(GameObject prefab, Transform parent) { }

	protected virtual void OnSwitchedInputMode(InputMode mode) { }

	public virtual void Update() { }

	private bool UpdateSiriRemote() { }

}

