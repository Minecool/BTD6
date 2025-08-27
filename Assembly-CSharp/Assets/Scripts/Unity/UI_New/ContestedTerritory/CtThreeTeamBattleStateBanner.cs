namespace Assets.Scripts.Unity.UI_New.ContestedTerritory;

public class CtThreeTeamBattleStateBanner : MonoBehaviour
{
	[CompilerGenerated]
	private struct <Load>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public string teamOneId; //Field offset: 0x28
		public CtThreeTeamBattleStateBanner <>4__this; //Field offset: 0x30
		public string teamTwoId; //Field offset: 0x38
		public string teamThreeId; //Field offset: 0x40
		private TaskAwaiter<TeamCosmetics> <>u__1; //Field offset: 0x48

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
	public Image teamThreeFlag; //Field offset: 0x50
	public Image teamThreeFrame; //Field offset: 0x58
	public Image teamThreeIcon; //Field offset: 0x60

	public CtThreeTeamBattleStateBanner() { }

	[AsyncStateMachine(typeof(<Load>d__9))]
	public void Load(string teamOneId, string teamTwoId, string teamThreeId) { }

}

