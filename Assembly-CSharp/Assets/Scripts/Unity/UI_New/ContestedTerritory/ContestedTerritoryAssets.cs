namespace Assets.Scripts.Unity.UI_New.ContestedTerritory;

[Extension]
public static class ContestedTerritoryAssets
{
	[CompilerGenerated]
	private struct <GetTeamCosmetics>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<TeamCosmetics> <>t__builder; //Field offset: 0x8
		public string teamId; //Field offset: 0x20
		private TeamCosmetics <teamCosmetics>5__2; //Field offset: 0x28
		private TaskAwaiter<GuildModel> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadAndAttachAsync>d__1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public PrefabReference prefab; //Field offset: 0x20
		public ContestedTerritoryGameTile gameTile; //Field offset: 0x28
		private TaskAwaiter<GameObject> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadAsync>d__0 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<GameObject> <>t__builder; //Field offset: 0x8
		public PrefabReference prefabReference; //Field offset: 0x20
		public GameObject parent; //Field offset: 0x28
		private AsyncOperationHandle<GameObject> <instantiationHandle>5__2; //Field offset: 0x30
		private TaskAwaiter<GameObject> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal class TeamCosmetics
	{
		public SpriteReference icon; //Field offset: 0x10
		public SpriteReference frame; //Field offset: 0x18
		public SpriteReference banner; //Field offset: 0x20
		public SpriteReference flag; //Field offset: 0x28

		public TeamCosmetics() { }

	}


	[Extension]
	public static void ChangeHighlightMaterial(ContestedTerritoryGameTile gameTile, MaterialReference material) { }

	[Extension]
	public static void ChangeMaterial(ContestedTerritoryGameTile gameTile, Material material) { }

	[Extension]
	public static void ChangeMaterial(ContestedTerritoryGameTile gameTile, MaterialReference material) { }

	[Extension]
	public static Material GetCurrentMaterial(ContestedTerritoryGameTile gameTile) { }

	[AsyncStateMachine(typeof(<GetTeamCosmetics>d__6))]
	public static Task<TeamCosmetics> GetTeamCosmetics(string teamId) { }

	[AsyncStateMachine(typeof(<LoadAndAttachAsync>d__1))]
	[Extension]
	public static Task<Boolean> LoadAndAttachAsync(ContestedTerritoryGameTile gameTile, PrefabReference prefab) { }

	[AsyncStateMachine(typeof(<LoadAsync>d__0))]
	public static Task<GameObject> LoadAsync(PrefabReference prefabReference, GameObject parent) { }

}

