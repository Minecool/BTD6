namespace Assets.Scripts.Unity.UI_New.Utils;

public class UIDragHandler : MonoBehaviour, IBeginDragHandler, IEventSystemHandler
{
	internal sealed class DragHandler : MulticastDelegate
	{

		public DragHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	[CompilerGenerated]
	private DragHandler onBeginDrag; //Field offset: 0x20

	public event DragHandler onBeginDrag
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public UIDragHandler() { }

	[CompilerGenerated]
	public void add_onBeginDrag(DragHandler value) { }

	public override void OnBeginDrag(PointerEventData data) { }

	[CompilerGenerated]
	public void remove_onBeginDrag(DragHandler value) { }

}

