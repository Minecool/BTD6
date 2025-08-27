namespace Assets.Scripts.Unity.UI_New.InGame;

public class QuestRaceHud : CTScoreHud
{
	private const float warningDelay = 5; //Field offset: 0x0
	private float warningTimer; //Field offset: 0x90
	private ChallengeGoal raceChallengeGoal; //Field offset: 0x98
	private TaskData taskData; //Field offset: 0xA0
	public GameObject trackedStatPanel; //Field offset: 0xA8
	public TMP_Text trackedStatTxt; //Field offset: 0xB0

	private TaskData TaskData
	{
		private get { } //Length: 369
	}

	public QuestRaceHud() { }

	protected virtual void AttachEvents() { }

	private TaskData get_TaskData() { }

	protected virtual int GetCurrentTarget() { }

	protected virtual string GetDisplayText() { }

	protected virtual bool NoTargetSet() { }

	private void OnUpdateEndlessRoundsMode(bool enduranceMode, long data) { }

	protected virtual void RemoveEvents() { }

	protected virtual bool ShowWarning() { }

	public void Update() { }

}

