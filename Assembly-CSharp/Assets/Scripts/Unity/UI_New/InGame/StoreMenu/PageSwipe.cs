namespace Assets.Scripts.Unity.UI_New.InGame.StoreMenu;

public class PageSwipe : MonoBehaviour
{
	internal sealed class OnPageSwipe : MulticastDelegate
	{

		public OnPageSwipe(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	public OnPageSwipe pageSwipeDelegate; //Field offset: 0x20
	public GridLayoutGroup layoutGroup; //Field offset: 0x28
	public RectTransform rect; //Field offset: 0x30
	public float lerpSpeed; //Field offset: 0x38
	protected bool locked; //Field offset: 0x3C
	protected bool pointerDown; //Field offset: 0x3D
	protected bool checkSwipe; //Field offset: 0x3E
	protected Vector2 prevPointerPos; //Field offset: 0x40
	protected ITowerPurchaseButton[] towerButtons; //Field offset: 0x48
	protected Vector3 startPos; //Field offset: 0x50
	protected Vector3 targetPos; //Field offset: 0x5C
	protected float lerpDelta; //Field offset: 0x68

	public PageSwipe() { }

	public void CheckPointer() { }

	protected Vector2 ConvertToPercentile(Vector2 pos) { }

	protected override int GetButtonCount() { }

	protected bool GetButtons() { }

	public Vector2 GetPointerPos(bool convertToPercentile) { }

	public bool IsPointerDown() { }

	public void Lock() { }

	public void OnPointerDown() { }

	public override void Reset() { }

	public void Unlock() { }

}

