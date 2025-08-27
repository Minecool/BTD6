namespace Assets.Scripts.Unity.UI_New.LiNKSocial;

public class LiNKGuildMemberPanelScore : MonoBehaviour
{
	[SerializeField]
	private NK_TextMeshProUGUI scoreText; //Field offset: 0x20
	[SerializeField]
	private Image ctIcon; //Field offset: 0x28
	[SerializeField]
	private Image bossRushIcon; //Field offset: 0x30
	[CompilerGenerated]
	private long <Score>k__BackingField; //Field offset: 0x38

	public private long Score
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public LiNKGuildMemberPanelScore() { }

	[CompilerGenerated]
	public long get_Score() { }

	public void Set(long score, Nullable<MemberScoreType> memberScoreType) { }

	[CompilerGenerated]
	private void set_Score(long value) { }

}

