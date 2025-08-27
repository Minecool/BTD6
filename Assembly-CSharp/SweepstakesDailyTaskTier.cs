//Type is in global namespace

public class SweepstakesDailyTaskTier : MonoBehaviour
{
	[Header("Task UI")]
	[SerializeField]
	private NK_TextMeshProUGUI ticketRewardCount; //Field offset: 0x20
	[SerializeField]
	private NK_TextMeshProUGUI taskDescription; //Field offset: 0x28
	[Header("Task Progress UI")]
	[SerializeField]
	private NK_TextMeshProUGUI taskBarTextProgress; //Field offset: 0x30
	[SerializeField]
	private GameObject taskCompletedIcon; //Field offset: 0x38
	[SerializeField]
	private GameObject taskProgressBar; //Field offset: 0x40
	[SerializeField]
	private Image taskBarProgress; //Field offset: 0x48
	[SerializeField]
	private GameObject lockedProgressIcon; //Field offset: 0x50
	[SerializeField]
	private Color lockedTextColor; //Field offset: 0x58
	private SweepstakesTaskSettings sweepstakesTaskSettings; //Field offset: 0x68
	private SweepstakesStatusResponse sweepstakesStatus; //Field offset: 0x70
	private int taskStepIndex; //Field offset: 0x78
	private int taskIndex; //Field offset: 0x7C
	private bool isCompleted; //Field offset: 0x80

	public SweepstakesDailyTaskTier() { }

	public void Bind(SweepstakesEvent sweepstakesEvent, SweepstakesTaskSettings settings, int stepIndex, int taskIndex, SweepstakesStatusResponse sweepstakesStatus) { }

	private int GetStatForStepConditionIds(SweepstakesStats stats, String[] stepConditionIds) { }

	private int GetStatForTaskId(SweepstakesStats stats, string taskId) { }

	private void SetupProgressText(SweepstakesStats stats) { }

}

