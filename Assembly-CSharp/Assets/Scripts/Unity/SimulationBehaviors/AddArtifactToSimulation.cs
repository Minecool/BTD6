namespace Assets.Scripts.Unity.SimulationBehaviors;

public class AddArtifactToSimulation : SimulationBehavior, IArtifactIncluder
{
	[CompilerGenerated]
	private sealed class <GetArtifactIdsToInclude>d__5 : IEnumerable<String>, IEnumerable, IEnumerator<String>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private string <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public AddArtifactToSimulation <>4__this; //Field offset: 0x28
		private String[] <>7__wrap1; //Field offset: 0x30
		private int <>7__wrap2; //Field offset: 0x38

		private override string System.Collections.Generic.IEnumerator<System.String>.Current
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
		public <GetArtifactIdsToInclude>d__5(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<String> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

		[DebuggerHidden]
		private override string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

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
	private sealed class <GetArtifactModelsToInclude>d__4 : IEnumerable<Model>, IEnumerable, IEnumerator<Model>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Model <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public AddArtifactToSimulation <>4__this; //Field offset: 0x28
		private String[] <>7__wrap1; //Field offset: 0x30
		private int <>7__wrap2; //Field offset: 0x38

		private override Model System.Collections.Generic.IEnumerator<Assets.Scripts.Models.Model>.Current
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
		public <GetArtifactModelsToInclude>d__4(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<Model> System.Collections.Generic.IEnumerable<Assets.Scripts.Models.Model>.GetEnumerator() { }

		[DebuggerHidden]
		private override Model System.Collections.Generic.IEnumerator<Assets.Scripts.Models.Model>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	public String[] artifactIds; //Field offset: 0x18
	public EnableOptions enableOptions; //Field offset: 0x20

	public virtual SimulationBehaviorModel Def
	{
		 get { } //Length: 337
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public AddArtifactToSimulation() { }

	public virtual SimulationBehaviorModel get_Def() { }

	public virtual string get_Type() { }

	[IteratorStateMachine(typeof(<GetArtifactIdsToInclude>d__5))]
	public override IEnumerable<String> GetArtifactIdsToInclude() { }

	[IteratorStateMachine(typeof(<GetArtifactModelsToInclude>d__4))]
	public override IEnumerable<Model> GetArtifactModelsToInclude() { }

}

