namespace Assets.Scripts.Unity.UI.InGameMenu.StoreMenu;

public class BottomPageSwipe : PageSwipe
{
	private bool startScrolling; //Field offset: 0x70
	private float trigger; //Field offset: 0x74
	private float targetX; //Field offset: 0x78
	private float triggerY; //Field offset: 0x7C
	private float swipeRatio; //Field offset: 0x80

	public BottomPageSwipe() { }

	public virtual void Reset() { }

	public void Start() { }

	public void Update() { }

}

