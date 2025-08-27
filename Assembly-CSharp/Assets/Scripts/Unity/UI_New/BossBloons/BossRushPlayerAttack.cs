namespace Assets.Scripts.Unity.UI_New.BossBloons;

public class BossRushPlayerAttack : MonoBehaviour
{
	[CompilerGenerated]
	private struct <Bind>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BossRushPlayerAttack <>4__this; //Field offset: 0x20
		public string avatarName; //Field offset: 0x28
		public Dictionary<String, String> appropriateDisplayNames; //Field offset: 0x30
		public string playerId; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private Image playerAvatar; //Field offset: 0x20
	[SerializeField]
	private NK_TextMeshProUGUI playerName; //Field offset: 0x28

	public BossRushPlayerAttack() { }

	[AsyncStateMachine(typeof(<Bind>d__2))]
	public Task Bind(string playerId, string avatarName, Dictionary<String, String> appropriateDisplayNames) { }

	public void Hide() { }

}

