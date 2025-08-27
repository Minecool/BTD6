namespace Assets.Scripts.Unity.UI_New.ContestedTerritory;

public class CtOneTeamBattleStateBanner : MonoBehaviour
{
	[CompilerGenerated]
	private struct <Load>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public string teamId; //Field offset: 0x28
		public CtOneTeamBattleStateBanner <>4__this; //Field offset: 0x30
		private TaskAwaiter<TeamCosmetics> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public Image teamOneFlag; //Field offset: 0x20
	public Image teamOneFrame; //Field offset: 0x28
	public Image teamOneIcon; //Field offset: 0x30

	public CtOneTeamBattleStateBanner() { }

	[AsyncStateMachine(typeof(<Load>d__3))]
	public void Load(string teamId) { }

}

