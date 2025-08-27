namespace Assets.Scripts.Unity.UI_New;

public class AccoladeStatsDisplay : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<KeyValuePair`2<AccoladeType, Int32>, Int32> <>9__8_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <Initialize>b__8_0(KeyValuePair<AccoladeType, Int32> x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public AccoladeStatsDisplay <>4__this; //Field offset: 0x10
		public AccoladeType accoladeType; //Field offset: 0x18
		public int quantity; //Field offset: 0x1C

		public <>c__DisplayClass11_0() { }

		internal void <CreatePopupIcon>b__0(AsyncOperationHandle<GameObject> handle) { }

	}

	[SerializeField]
	protected AccoladeDisplay displayIcon; //Field offset: 0x20
	[SerializeField]
	protected PrefabReference popupDisplayIconPrefab; //Field offset: 0x28
	[SerializeField]
	protected Button displayPopupButton; //Field offset: 0x30
	[SerializeField]
	protected GameObject extraDisplayObj; //Field offset: 0x38
	[SerializeField]
	protected Transform extraDisplayIconContainer; //Field offset: 0x40

	protected static AccoladesSettings AccoladesSettings
	{
		 get { } //Length: 162
	}

	public AccoladeStatsDisplay() { }

	protected override void Awake() { }

	protected AsyncOperationHandle<GameObject> CreatePopupIcon(PrefabReference prefab, Transform container, AccoladeType accoladeType, int quantity) { }

	protected static AccoladesSettings get_AccoladesSettings() { }

	protected void HidePopup(BaseEventData eventData) { }

	public void Initialize(Dictionary<AccoladeType, Int32> accolades, bool hasGifted) { }

	protected void ShowPopup(BaseEventData eventData) { }

}

