namespace Assets.Scripts.Unity.UI_New.DailyChallenge;

public class BossRushStagePanelDisplay : MonoBehaviour
{
	[SerializeField]
	private Animator anim; //Field offset: 0x20
	[SerializeField]
	private Image defeatIcon; //Field offset: 0x28
	[SerializeField]
	private Image normalIcon; //Field offset: 0x30

	public BossRushStagePanelDisplay() { }

	public void Bind(BossType bossType, bool completed, bool active, bool justCompleted) { }

}

