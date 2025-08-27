//Type is in global namespace

public class SweepstakesDailyTaskActiveIcon : MonoBehaviour
{
	public GameObject highlight; //Field offset: 0x20
	public GameObject lockIcon; //Field offset: 0x28
	public GameObject completedTickIcon; //Field offset: 0x30
	[SerializeField]
	private Button moveToTaskButton; //Field offset: 0x38
	private float dailyTaskSpacing; //Field offset: 0x40
	private float dailyTaskWidth; //Field offset: 0x44
	private int dailyTaskIndex; //Field offset: 0x48
	private SweepStakesEventScreen eventScreen; //Field offset: 0x50
	private bool isActive; //Field offset: 0x58
	private bool isCompleted; //Field offset: 0x59

	public SweepstakesDailyTaskActiveIcon() { }

	public void Bind(bool isActive, bool isCompleted, float dailyTaskSpacing, float dailyTaskWidth, int dailyTaskIndex, SweepStakesEventScreen eventScreen) { }

	private void OnIconPressed() { }

}

