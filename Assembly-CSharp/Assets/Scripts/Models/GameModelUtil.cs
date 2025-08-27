namespace Assets.Scripts.Models;

public static class GameModelUtil
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public IGameModelLoader modelGen; //Field offset: 0x10
		public Byte[] data; //Field offset: 0x18

		public <>c__DisplayClass4_0() { }

		internal GameModel <LoadGameModelAsync>b__0() { }

	}

	[CompilerGenerated]
	private struct <LoadGameModelAsync>d__4 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<GameModel> <>t__builder; //Field offset: 0x8
		private AsyncOperationHandle<TextAsset> <resRequest>5__2; //Field offset: 0x20
		private TaskAwaiter<TextAsset> <>u__1; //Field offset: 0x38
		private TaskAwaiter<GameModel> <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static GameModel cachedModel; //Field offset: 0x0

	public static GameModel CachedModel
	{
		 get { } //Length: 78
		 set { } //Length: 65
	}

	public static bool ApplyModToAllBloons(GameModel model, Predicate<BloonModel> _pred) { }

	public static GameModel get_CachedModel() { }

	[AsyncStateMachine(typeof(<LoadGameModelAsync>d__4))]
	public static Task<GameModel> LoadGameModelAsync() { }

	public static void NotifyBloonsModdedForModel(GameModel model) { }

	public static void set_CachedModel(GameModel value) { }

}

