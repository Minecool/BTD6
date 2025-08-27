namespace Assets.Scripts.Unity.UI_New.InGame.Races;

public class RaceUI : DynamicUiObject
{
	public static RaceUI instance; //Field offset: 0x0
	public TMP_Text raceTimerTxt; //Field offset: 0x20
	public GameObject sendRoundFlagObj; //Field offset: 0x28
	public Animator sendRoundFlagAnim; //Field offset: 0x30
	public TMP_Text ghostTimeTxt; //Field offset: 0x38
	public Animator ghostTimeAnimator; //Field offset: 0x40
	public AudioClip raceStartSound; //Field offset: 0x48
	public Color ghostTimeRed; //Field offset: 0x50
	public Color ghostTimeGreen; //Field offset: 0x60
	public GameObject customRaceHudContainer; //Field offset: 0x70
	private CTScoreHud customScoreHud; //Field offset: 0x78
	private Nullable<TimeSpan> enduranceRaceTarget; //Field offset: 0x80

	public RaceUI() { }

	[CompilerGenerated]
	private void <Setup>b__14_0(AsyncOperationHandle<GameObject> h) { }

	private void AddListeners() { }

	public void Awake() { }

	public bool GetContextSpecificRaceTime(int round, out float bestTime) { }

	private void OnDestroy() { }

	public virtual void OnGameEnd() { }

	public virtual void OnGameStart() { }

	public virtual void OnRestartGame() { }

	private void OnRoundStart(int round) { }

	private void OnStartedRaceRound() { }

	public void SendRoundClicked() { }

	public void Setup() { }

	public void ShowTimePenalty(TimeSpan time) { }

	public void Update() { }

}

