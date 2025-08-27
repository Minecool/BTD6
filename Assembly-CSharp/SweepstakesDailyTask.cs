//Type is in global namespace

public class SweepstakesDailyTask : MonoBehaviour
{
	[Header("General UI")]
	[SerializeField]
	private NK_TextMeshProUGUI taskTitleText; //Field offset: 0x20
	[SerializeField]
	private Image taskIcon; //Field offset: 0x28
	[Header("Step UI")]
	[SerializeField]
	private GameObject taskContainer; //Field offset: 0x30
	[SerializeField]
	private GameObject taskTierTemplate; //Field offset: 0x38
	[Header("Locked State UI")]
	[SerializeField]
	private NK_TextMeshProUGUI taskLockedCountdownTimerText; //Field offset: 0x40
	[SerializeField]
	private NK_TextMeshProUGUI taskLockedText; //Field offset: 0x48
	[SerializeField]
	private GameObject taskLockedObject; //Field offset: 0x50
	[SerializeField]
	private GameObject taskLockedTimerGameObject; //Field offset: 0x58
	[SerializeField]
	private GameObject taskLockedTextGameObject; //Field offset: 0x60
	[SerializeField]
	private Animator lockedAnimator; //Field offset: 0x68
	[SerializeField]
	private Button unlockButton; //Field offset: 0x70
	private readonly List<GameObject> taskTiers; //Field offset: 0x78
	private string sweepstakesEventID; //Field offset: 0x80
	private bool isLocked; //Field offset: 0x88
	private bool isReadyToUnlock; //Field offset: 0x89
	private bool isTimerRunning; //Field offset: 0x8A
	private DateTime nextUnlockTime; //Field offset: 0x90
	private float updateSecondTimer; //Field offset: 0x98

	private static DateTime now
	{
		private get { } //Length: 7
	}

	public SweepstakesDailyTask() { }

	public void Bind(SweepstakesEvent sweepstakesEvent, SweepstakesTaskSettings taskSettings, int taskIndex, DateTime nextUnlockTime, SweepstakesStatusResponse sweepstakesStatus, bool hasUnlockedNewDay) { }

	private static DateTime get_now() { }

	private void OnUnlockClicked() { }

	private void Update() { }

	private void UpdateTimer() { }

}

