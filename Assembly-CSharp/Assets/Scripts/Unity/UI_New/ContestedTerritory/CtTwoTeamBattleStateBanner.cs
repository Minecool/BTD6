namespace Assets.Scripts.Unity.UI_New.ContestedTerritory;

public class CtTwoTeamBattleStateBanner : MonoBehaviour
{
	[CompilerGenerated]
	private struct <Load>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public string teamOneId; //Field offset: 0x28
		public CtTwoTeamBattleStateBanner <>4__this; //Field offset: 0x30
		public string teamTwoId; //Field offset: 0x38
		private TaskAwaiter<TeamCosmetics> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public Image teamOneFlag; //Field offset: 0x20
	public Image teamOneFrame; //Field offset: 0x28
	public Image teamOneIcon; //Field offset: 0x30
	public Image teamTwoFlag; //Field offset: 0x38
	public Image teamTwoFrame; //Field offset: 0x40
	public Image teamTwoIcon; //Field offset: 0x48

	public CtTwoTeamBattleStateBanner() { }

	[AsyncStateMachine(typeof(<Load>d__6))]
	public void Load(string teamOneId, string teamTwoId) { }

}

