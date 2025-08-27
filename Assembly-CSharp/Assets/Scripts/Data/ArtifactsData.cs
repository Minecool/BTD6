namespace Assets.Scripts.Data;

public class ArtifactsData : ScriptableObject
{
	[CompilerGenerated]
	private sealed class <GetArtifactModelsOfType>d__8 : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private T <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		public ArtifactsData <>4__this; //Field offset: 0x0
		private string baseId; //Field offset: 0x0
		public string <>3__baseId; //Field offset: 0x0
		private int tier; //Field offset: 0x0
		public int <>3__tier; //Field offset: 0x0
		private Enumerator<ArtifactModelBase> <>7__wrap1; //Field offset: 0x0

		private override T System.Collections.Generic.IEnumerator<T>.Current
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
		public <GetArtifactModelsOfType>d__8`1(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

		[DebuggerHidden]
		private override T System.Collections.Generic.IEnumerator<T>.get_Current() { }

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
	private sealed class <GetBaseArtifactModels>d__6 : IEnumerable<ArtifactModelBase>, IEnumerable, IEnumerator<ArtifactModelBase>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private ArtifactModelBase <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public ArtifactsData <>4__this; //Field offset: 0x28
		private string baseId; //Field offset: 0x30
		public string <>3__baseId; //Field offset: 0x38
		private int tier; //Field offset: 0x40
		public int <>3__tier; //Field offset: 0x44
		private Enumerator<String, ArtifactDataBase> <>7__wrap1; //Field offset: 0x48

		private override ArtifactModelBase System.Collections.Generic.IEnumerator<Assets.Scripts.Models.Artifacts.ArtifactModelBase>.Current
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
		public <GetBaseArtifactModels>d__6(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<ArtifactModelBase> System.Collections.Generic.IEnumerable<Assets.Scripts.Models.Artifacts.ArtifactModelBase>.GetEnumerator() { }

		[DebuggerHidden]
		private override ArtifactModelBase System.Collections.Generic.IEnumerator<Assets.Scripts.Models.Artifacts.ArtifactModelBase>.get_Current() { }

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
	private struct <LoadAsync>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ArtifactsData <>4__this; //Field offset: 0x20
		private TaskAwaiter<IList`1<ArtifactDataBase>> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly Dictionary<String, ArtifactDataBase> artifactDatas; //Field offset: 0x18
	private readonly Dictionary<Type, List`1<ArtifactModelBase>> artifactModelsByType; //Field offset: 0x20

	public ArtifactsData() { }

	private void AddArtifactData(ArtifactDataBase artifactData) { }

	public ArtifactDataBase GetArtifactData(string id) { }

	public IEnumerable<ArtifactDataBase> GetArtifactDatas() { }

	public T GetArtifactModelOfType(string id) { }

	public T GetArtifactModelOfType(string baseId = "", int tier = -1) { }

	[IteratorStateMachine(typeof(<GetArtifactModelsOfType>d__8`1))]
	public IEnumerable<T> GetArtifactModelsOfType(string baseId = "", int tier = -1) { }

	public ArtifactModelBase GetBaseArtifactModel(string id) { }

	[IteratorStateMachine(typeof(<GetBaseArtifactModels>d__6))]
	public IEnumerable<ArtifactModelBase> GetBaseArtifactModels(string baseId = "", int tier = -1) { }

	[AsyncStateMachine(typeof(<LoadAsync>d__2))]
	public Task LoadAsync() { }

}

