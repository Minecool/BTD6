namespace Assets.Scripts.Unity.Utils;

public class ScrollRectWithDragCancel : ScrollRect, IScroller
{
	private PointerEventData dragData; //Field offset: 0x130

	public override bool DragEnabled
	{
		 get { } //Length: 7
		 set { } //Length: 8
	}

	public ScrollRectWithDragCancel() { }

	private override float Assets.Scripts.Unity.Utils.IScroller.get_horizontalNormalizedPosition() { }

	private override float Assets.Scripts.Unity.Utils.IScroller.get_verticalNormalizedPosition() { }

	private override void Assets.Scripts.Unity.Utils.IScroller.set_horizontalNormalizedPosition(float value) { }

	private override void Assets.Scripts.Unity.Utils.IScroller.set_verticalNormalizedPosition(float value) { }

	public override void CancelDrag() { }

	public override bool get_DragEnabled() { }

	public virtual void OnBeginDrag(PointerEventData eventData) { }

	public virtual void OnEndDrag(PointerEventData eventData) { }

	public override void set_DragEnabled(bool value) { }

}

