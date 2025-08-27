namespace Assets.Scripts.Unity.UI_New.ContestedTerritory;

public class CTBaseIsland : MonoBehaviour
{
	[CompilerGenerated]
	private struct <<SlotTasks>b__24_0>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public CTBaseIsland <>4__this; //Field offset: 0x28
		public AsyncOperationHandle<GameObject> o; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <<SlotTasks>b__24_1>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public CTBaseIsland <>4__this; //Field offset: 0x28
		public AsyncOperationHandle<GameObject> o; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_0
	{
		public GuildModel guildModel; //Field offset: 0x10

		public <>c__DisplayClass20_0() { }

		internal bool <Initialise>b__0(GuildInfo x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass25_0
	{
		public string slotObjectId; //Field offset: 0x10

		public <>c__DisplayClass25_0() { }

		internal bool <ChangeMaterial>b__0(TeamsStoreItem x) { }

		internal bool <ChangeMaterial>b__1(TeamsStoreItem x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass28_0
	{
		public string storeId; //Field offset: 0x10

		public <>c__DisplayClass28_0() { }

		internal bool <SetShaderTexture>b__0(TeamsStoreItem x) { }

	}

	[CompilerGenerated]
	private struct <ChangeFlagMaterial>d__27 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CTBaseIsland <>4__this; //Field offset: 0x20
		public GameObject objectToModify; //Field offset: 0x28
		private AsyncOperationHandle<Material> <materialHandle>5__2; //Field offset: 0x30
		private TaskAwaiter<Material> <>u__1; //Field offset: 0x48
		private TaskAwaiter <>u__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ChangeMaterial>d__25 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string slotObjectId; //Field offset: 0x20
		public TeamStoreWorldSlot slotType; //Field offset: 0x28
		public int slotNum; //Field offset: 0x2C
		public CTBaseIsland <>4__this; //Field offset: 0x30
		public GameObject objectToModify; //Field offset: 0x38
		private TeamsStoreFlairData[] <>7__wrap1; //Field offset: 0x40
		private int <>7__wrap2; //Field offset: 0x48
		private TaskAwaiter <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ChangeMaterial>d__26 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CTBaseIsland <>4__this; //Field offset: 0x20
		public CTTeamsBuildingMaterialSwap swapData; //Field offset: 0x28
		public GameObject objectToModify; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Initialise>d__20 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public GuildModel guildModel; //Field offset: 0x20
		public CTBaseIsland <>4__this; //Field offset: 0x28
		public string guildId; //Field offset: 0x30
		public TeamIslandCosmeticData forceOverrideCosmetics; //Field offset: 0x38
		private <>c__DisplayClass20_0 <>8__1; //Field offset: 0x40
		public bool hasCtEvent; //Field offset: 0x48
		private TaskAwaiter <>u__1; //Field offset: 0x50
		private TaskAwaiter<GuildModel> <>u__2; //Field offset: 0x58
		private TaskAwaiter<CtApiActionResult> <>u__3; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadCosmeticsData>d__23 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CTBaseIsland <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SetShaderTexture>d__28 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string storeId; //Field offset: 0x20
		public TeamStoreFlairType flareType; //Field offset: 0x28
		public CTBaseIsland <>4__this; //Field offset: 0x30
		public GameObject objectToModify; //Field offset: 0x38
		public string textureName; //Field offset: 0x40
		private AsyncOperationHandle<Sprite> <loadHandle>5__2; //Field offset: 0x48
		private TaskAwaiter<Sprite> <>u__1; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <SlotTasks>d__24 : IEnumerable<Task>, IEnumerable, IEnumerator<Task>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Task <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public CTBaseIsland <>4__this; //Field offset: 0x28
		private TeamsStoreItems <teamsStoreItems>5__2; //Field offset: 0x30

		private override Task System.Collections.Generic.IEnumerator<System.Threading.Tasks.Task>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <SlotTasks>d__24(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<Task> System.Collections.Generic.IEnumerable<System.Threading.Tasks.Task>.GetEnumerator() { }

		[DebuggerHidden]
		private override Task System.Collections.Generic.IEnumerator<System.Threading.Tasks.Task>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private struct <SwapMaterial>d__30 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CTTeamsBuildingMaterialSwap swapData; //Field offset: 0x20
		public CTBaseIsland <>4__this; //Field offset: 0x28
		public GameObject objectToModify; //Field offset: 0x30
		public MaterialReference swapToMaterial; //Field offset: 0x38
		private AsyncOperationHandle<Material> <defaultMaterialHandle>5__2; //Field offset: 0x40
		private string <defaultMaterialName>5__3; //Field offset: 0x58
		private TaskAwaiter<Material> <>u__1; //Field offset: 0x60
		private Renderer[] <>7__wrap3; //Field offset: 0x68
		private int <>7__wrap4; //Field offset: 0x70
		private Renderer <renderer>5__6; //Field offset: 0x78
		private Material[] <materials>5__7; //Field offset: 0x80
		private int <index>5__8; //Field offset: 0x88

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private class MaterialHandleHolder : MonoBehaviour
	{
		public AsyncOperationHandle<Material> materialHandle; //Field offset: 0x20

		public MaterialHandleHolder() { }

		private void OnDestroy() { }

	}

	[SerializeField]
	private GameObject slotBuildingObj; //Field offset: 0x20
	[SerializeField]
	private GameObject slotFlyingObj; //Field offset: 0x28
	[SerializeField]
	private GameObject slotWaterObj; //Field offset: 0x30
	[SerializeField]
	private GameObject slotFlagObj; //Field offset: 0x38
	[SerializeField]
	private GameObject slot1Obj; //Field offset: 0x40
	[SerializeField]
	private GameObject slot2Obj; //Field offset: 0x48
	[SerializeField]
	private GameObject slot3Obj; //Field offset: 0x50
	[SerializeField]
	private GameObject slot4Obj; //Field offset: 0x58
	[SerializeField]
	private GameObject lifeBuoyObj; //Field offset: 0x60
	private AsyncOperationHandle<GameObject> slotBuildingHandle; //Field offset: 0x68
	private AsyncOperationHandle<GameObject> slotFlyingHandle; //Field offset: 0x80
	private AsyncOperationHandle<GameObject> slotWaterHandle; //Field offset: 0x98
	private AsyncOperationHandle<GameObject> slotFlagHandle; //Field offset: 0xB0
	private AsyncOperationHandle<GameObject> slot1Handle; //Field offset: 0xC8
	private AsyncOperationHandle<GameObject> slot2Handle; //Field offset: 0xE0
	private AsyncOperationHandle<GameObject> slot3Handle; //Field offset: 0xF8
	private AsyncOperationHandle<GameObject> slot4Handle; //Field offset: 0x110
	private TeamDetail teamCtData; //Field offset: 0x128
	private TeamIslandCosmeticData cosmetics; //Field offset: 0x130
	private GuildMetadata teamMetaData; //Field offset: 0x138

	public CTBaseIsland() { }

	[AsyncStateMachine(typeof(<<SlotTasks>b__24_0>d))]
	[CompilerGenerated]
	private void <SlotTasks>b__24_0(AsyncOperationHandle<GameObject> o) { }

	[AsyncStateMachine(typeof(<<SlotTasks>b__24_1>d))]
	[CompilerGenerated]
	private void <SlotTasks>b__24_1(AsyncOperationHandle<GameObject> o) { }

	[AsyncStateMachine(typeof(<ChangeFlagMaterial>d__27))]
	private Task ChangeFlagMaterial(GameObject objectToModify) { }

	[AsyncStateMachine(typeof(<ChangeMaterial>d__25))]
	private Task ChangeMaterial(GameObject objectToModify, string slotObjectId, TeamStoreWorldSlot slotType, int slotNum = 1) { }

	[AsyncStateMachine(typeof(<ChangeMaterial>d__26))]
	private Task ChangeMaterial(GameObject objectToModify, CTTeamsBuildingMaterialSwap swapData) { }

	public void DestroyAllSlots() { }

	[AsyncStateMachine(typeof(<Initialise>d__20))]
	public Task Initialise(bool hasCtEvent, string guildId = "", GuildModel guildModel = null, TeamIslandCosmeticData forceOverrideCosmetics = null) { }

	[AsyncStateMachine(typeof(<LoadCosmeticsData>d__23))]
	private Task LoadCosmeticsData() { }

	private void OnDestroy() { }

	[AsyncStateMachine(typeof(<SetShaderTexture>d__28))]
	private Task SetShaderTexture(GameObject objectToModify, string storeId, string textureName, TeamStoreFlairType flareType) { }

	[IteratorStateMachine(typeof(<SlotTasks>d__24))]
	private IEnumerable<Task> SlotTasks() { }

	[AsyncStateMachine(typeof(<SwapMaterial>d__30))]
	private Task SwapMaterial(CTTeamsBuildingMaterialSwap swapData, MaterialReference swapToMaterial, GameObject objectToModify) { }

	private void SwapMaterialShader(Texture mainTexture, GameObject objectToModify, string textureName) { }

}

