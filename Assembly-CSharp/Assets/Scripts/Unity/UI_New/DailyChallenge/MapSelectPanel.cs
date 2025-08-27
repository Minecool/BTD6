namespace Assets.Scripts.Unity.UI_New.DailyChallenge;

public class MapSelectPanel : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass23_0
	{
		public MapSelectPanel <>4__this; //Field offset: 0x10
		public MapTypeCallback mapChangedEvent; //Field offset: 0x18

		public <>c__DisplayClass23_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass23_1
	{
		public MapDetails map; //Field offset: 0x10
		public <>c__DisplayClass23_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass23_1() { }

		internal void <Open>b__0() { }

	}

	internal sealed class MapTypeCallback : MulticastDelegate
	{

		public MapTypeCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string mapID, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(string mapID) { }

	}

	private bool mapSelectInit; //Field offset: 0x20
	public Transform mapDisplayParent; //Field offset: 0x28
	public MapSelectDisplay mapDisplayPrefab; //Field offset: 0x30
	public Material grayscaleMaterial; //Field offset: 0x38
	private RectTransform targetMap; //Field offset: 0x40
	private RectTransform beginnerMap; //Field offset: 0x48
	private RectTransform interMap; //Field offset: 0x50
	private RectTransform advancedMap; //Field offset: 0x58
	private RectTransform expertMap; //Field offset: 0x60
	public Toggle filterDefeatedBtn; //Field offset: 0x68
	public Toggle beginnerTog; //Field offset: 0x70
	public Toggle intermedTog; //Field offset: 0x78
	public Toggle advancedTog; //Field offset: 0x80
	public Toggle expertTog; //Field offset: 0x88
	public ScrollRect mapSelectScrollRect; //Field offset: 0x90
	public float mapScrollSpeedAdjuster; //Field offset: 0x98
	[HideInInspector]
	public GameObject selectedMapDisplay; //Field offset: 0xA0
	[HideInInspector]
	public string selectedMapID; //Field offset: 0xA8
	private bool difficultyClicked; //Field offset: 0xB0

	public MapSelectPanel() { }

	private void Awake() { }

	private ValueTuple<Boolean, Boolean> CheckIfMapDefeated(BossType bossType, string mapID) { }

	private void FilterDefeated(bool isOn) { }

	private void MapSelectAdvancedToggled(bool isOn) { }

	private void MapSelectBeginnerToggled(bool isOn) { }

	private void MapSelectExpertToggled(bool isOn) { }

	private void MapSelectInterToggled(bool isOn) { }

	private void OnDestroy() { }

	public void Open(MapTypeCallback mapChangedEvent, BossType bossType = 0, bool showBossVisuals = false) { }

	private void Update() { }

}

