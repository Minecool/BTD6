namespace Assets.Scripts.Unity.UI_New.GameOver;

public class CTDefeatScreen : CheckpointDefeatScreen
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public KonFuze continueMmCost; //Field offset: 0x10
		public CTDefeatScreen <>4__this; //Field offset: 0x18

		public <>c__DisplayClass13_0() { }

		internal void <Open>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_1
	{
		public KonFuze retryMmCost; //Field offset: 0x10
		public CTDefeatScreen <>4__this; //Field offset: 0x18

		public <>c__DisplayClass13_1() { }

		internal void <Open>b__1() { }

	}

	public TMP_Text finalRoundTxt; //Field offset: 0x158
	public BloonCauseDeathDisplay bloonCauseDeathDisplayPrefab; //Field offset: 0x160
	public GameObject bloonCoDContainer; //Field offset: 0x168
	public Button restartButton; //Field offset: 0x170
	public AudioClip defeatSound; //Field offset: 0x178
	private CtEvent ctEvent; //Field offset: 0x180
	private Dictionary<String, MapSaveDataModel> previousSaves; //Field offset: 0x188

	protected virtual bool CanPlayAgain
	{
		 get { } //Length: 118
	}

	private static string ContinueMapSaveId
	{
		private get { } //Length: 16
	}

	public CTDefeatScreen() { }

	[CompilerGenerated]
	private void <RestartClick>b__16_0() { }

	protected virtual void Awake() { }

	protected virtual void ButtonsInteractive(bool canInteract) { }

	private void GamepadUpdateNav() { }

	protected virtual bool get_CanPlayAgain() { }

	private static string get_ContinueMapSaveId() { }

	private KonFuze GetRetryMmCost() { }

	private void OnDestroy() { }

	public virtual void Open(object menuData) { }

	private void RestartClick() { }

	private void RestoreMapSaves() { }

	public void RunRestart() { }

}

