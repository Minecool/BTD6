namespace Assets.Scripts.Unity.Utils;

public class GameObjectEvents : MonoBehaviour, IDragHandler, IEventSystemHandler
{
	[CompilerGenerated]
	private Action OnDragEvent; //Field offset: 0x20

	public event Action OnDragEvent
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public GameObjectEvents() { }

	[CompilerGenerated]
	public void add_OnDragEvent(Action value) { }

	public override void OnDrag(PointerEventData eventData) { }

	[CompilerGenerated]
	public void remove_OnDragEvent(Action value) { }

}

