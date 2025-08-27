namespace Assets.Scripts.Unity.Gamepad.InputSystem;

public abstract class MultiplayerSelectable : MonoBehaviour, IMoveHandler, IEventSystemHandler, ISubmitHandler
{
	internal sealed class CalcScoreHandler : MulticastDelegate
	{

		public CalcScoreHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(MultiplayerSelectable src, Vector3 pos, Vector2 dir, MultiplayerSelectable mSel, out float score, AsyncCallback callback, object object) { }

		public override bool EndInvoke(out float score, IAsyncResult result) { }

		public override bool Invoke(MultiplayerSelectable src, Vector3 pos, Vector2 dir, MultiplayerSelectable mSel, out float score) { }

	}

	internal sealed class CanNavHandler : MulticastDelegate
	{

		public CanNavHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(MultiplayerSelectable sel, AsyncCallback callback, object object) { }

		public override bool EndInvoke(IAsyncResult result) { }

		public override bool Invoke(MultiplayerSelectable sel) { }

	}

	private static Vector3[] worldCorners; //Field offset: 0x0
	private static Selectable[] selectables; //Field offset: 0x8
	private static Vector3[] corners; //Field offset: 0x10
	private static List<RaycastResult> m_RaycastResultCache; //Field offset: 0x18
	public static CanNavHandler CanNavCallback; //Field offset: 0x20
	[FormerlySerializedAs("navigation")]
	[SerializeField]
	private Navigation m_Navigation; //Field offset: 0x20
	public MultiplayerSelectable ownerSelectable; //Field offset: 0x48
	public NavGroup navGroup; //Field offset: 0x50
	public Selectable selectable; //Field offset: 0x58
	public RectTransform rt; //Field offset: 0x60
	public RectTransform rtRaycastTarget; //Field offset: 0x68
	public bool _isOver; //Field offset: 0x70
	protected int pointerDownCount; //Field offset: 0x74
	[CompilerGenerated]
	private Action<Boolean> OnIsOverChanged; //Field offset: 0x78
	public EventSystem eventSystem; //Field offset: 0x80
	public PointerEventData pointerEventData; //Field offset: 0x88
	public bool mainPlayerOnly; //Field offset: 0x90
	public bool _enableNavMove; //Field offset: 0x91
	[CompilerGenerated]
	private Action<MultiplayerSelectable> OnSubmitEvent; //Field offset: 0x98

	public event Action<Boolean> OnIsOverChanged
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	public event Action<MultiplayerSelectable> OnSubmitEvent
	{
		[CompilerGenerated]
		 add { } //Length: 174
		[CompilerGenerated]
		 remove { } //Length: 174
	}

	public bool enableNavMove
	{
		 get { } //Length: 8
		 set { } //Length: 7
	}

	private static MultiplayerSelectable() { }

	protected MultiplayerSelectable() { }

	[CompilerGenerated]
	public void add_OnIsOverChanged(Action<Boolean> value) { }

	[CompilerGenerated]
	public void add_OnSubmitEvent(Action<MultiplayerSelectable> value) { }

	private static bool CalcNavGroupDownScore(MultiplayerSelectable src, Vector3 pos, Vector2 dir, MultiplayerSelectable mSel, out float score) { }

	private static bool CalcNavGroupLeftScore(MultiplayerSelectable src, Vector3 pos, Vector2 dir, MultiplayerSelectable mSel, out float score) { }

	private static bool CalcNavGroupRightScore(MultiplayerSelectable src, Vector3 pos, Vector2 dir, MultiplayerSelectable mSel, out float score) { }

	private static bool CalcNavGroupUpScore(MultiplayerSelectable src, Vector3 pos, Vector2 dir, MultiplayerSelectable mSel, out float score) { }

	private static bool CalcNearestScore(MultiplayerSelectable src, Vector3 pos, Vector2 dir, MultiplayerSelectable mSel, bool includeDir, out float score) { }

	public static bool CalcNearestScoreWithDir(MultiplayerSelectable src, Vector3 pos, Vector2 dir, MultiplayerSelectable mSel, out float score) { }

	private static bool CalcNearestScoreWithoutDir(MultiplayerSelectable src, Vector3 pos, Vector2 dir, MultiplayerSelectable mSel, out float score) { }

	private static bool CalcUnityScore(MultiplayerSelectable src, Vector3 pos, Vector2 dir, MultiplayerSelectable mSel, out float score) { }

	public static bool CanClick(Transform rootTransform, MultiplayerSelectable mSel) { }

	public static bool CanSee(RectTransform rt, Rect bounds) { }

	private MultiplayerSelectable CustomNavigate(Selectable sel) { }

	public MultiplayerSelectable CustomOnMove(Transform rootTransform, MoveDirection moveDir) { }

	protected static GameObject FindFirstRaycastSelectable(Transform rootTransform, List<RaycastResult> candidates) { }

	public MultiplayerSelectable FindHorizontalNavGroup(Transform rootTransform, MoveDirection dir) { }

	public static MultiplayerSelectable FindNearestSelectable(Transform rootTransform, Vector3 pos, Vector2 dir) { }

	private Selectable FindScrollContentSelectable(ScrollRect sr, Vector3 dir) { }

	public Selectable FindSelectable(Transform rootTransform, Vector3 dir) { }

	public override Selectable FindSelectableOnDown(Transform rootTransform) { }

	public override Selectable FindSelectableOnLeft(Transform rootTransform) { }

	public override Selectable FindSelectableOnRight(Transform rootTransform) { }

	public override Selectable FindSelectableOnUp(Transform rootTransform) { }

	public MultiplayerSelectable FindVerticalNavGroup(Transform rootTransform, MoveDirection dir) { }

	public bool get_enableNavMove() { }

	private Vector3 GetLocalPos(Vector3 dir) { }

	public static MultiplayerSelectable GetMultiplayerSelectable(Selectable sel, bool allowFakeSelectable = true) { }

	public static Rect GetPaddedWorldBounds() { }

	private static Vector3 GetPointOnRectEdge(RectTransform rect, Vector2 dir) { }

	private RectTransform GetRaycastTarget() { }

	private MultiplayerSelectable GetRootSelectable() { }

	public static bool IsEqual(MultiplayerSelectable a, MultiplayerSelectable b) { }

	private static MultiplayerSelectable MultiSelectableGroupSelected(MultiplayerSelectable sel) { }

	private void Navigate(AxisEventData eventData, Selectable sel) { }

	public override void OnMove(AxisEventData eventData) { }

	protected override void OnOverChanged(bool isOver) { }

	public override void OnPointerDown(PointerEventData eventData) { }

	public override void OnPointerUp(PointerEventData eventData) { }

	public override void OnPress() { }

	public override void OnSubmit(BaseEventData eventData) { }

	public static Rect RectTransformToScreenSpace(RectTransform transform) { }

	protected static T Register(GameObject gameObject, RectTransform rtRaycastTarget = null, bool allowFakeSelectable = true) { }

	[CompilerGenerated]
	public void remove_OnIsOverChanged(Action<Boolean> value) { }

	[CompilerGenerated]
	public void remove_OnSubmitEvent(Action<MultiplayerSelectable> value) { }

	public void set_enableNavMove(bool value) { }

	public void SetExplicit(Selectable up, Selectable down, Selectable left, Selectable right) { }

	private void SetIsOver(bool isOver) { }

	public void SetNavMode(Mode mode = 0) { }

	public void SetOver(bool isOver) { }

	private static Selectable SharedFindSelectable(Transform rootTransform, MultiplayerSelectable current, NavGroup navGroup, Vector2 cursorPos, Vector2 dir, bool canClickValidation, CalcScoreHandler calcScore) { }

	public static bool ValidSelectable(Selectable sel, out MultiplayerSelectable mSel, Rect worldBounds, bool checkWorldBounds = true) { }

}

