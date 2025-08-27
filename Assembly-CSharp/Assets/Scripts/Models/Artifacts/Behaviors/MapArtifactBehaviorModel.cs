namespace Assets.Scripts.Models.Artifacts.Behaviors;

public abstract class MapArtifactBehaviorModel : ArtifactBehaviorModelBase
{
	[CompilerGenerated]
	private sealed class <GetAdditionalBoostTowers>d__3 : IEnumerable<RogueInstaMonkey>, IEnumerable, IEnumerator<RogueInstaMonkey>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private RogueInstaMonkey <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20

		private override RogueInstaMonkey System.Collections.Generic.IEnumerator<Assets.Scripts.Data.Legends.RogueInstaMonkey>.Current
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
		public <GetAdditionalBoostTowers>d__3(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<RogueInstaMonkey> System.Collections.Generic.IEnumerable<Assets.Scripts.Data.Legends.RogueInstaMonkey>.GetEnumerator() { }

		[DebuggerHidden]
		private override RogueInstaMonkey System.Collections.Generic.IEnumerator<Assets.Scripts.Data.Legends.RogueInstaMonkey>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}


	protected MapArtifactBehaviorModel(string name) { }

	public abstract void Activate(ILegendsDataProvider legendsDataProvider) { }

	public abstract void Deactivate(ILegendsDataProvider legendsDataProvider) { }

	[IteratorStateMachine(typeof(<GetAdditionalBoostTowers>d__3))]
	public override IEnumerable<RogueInstaMonkey> GetAdditionalBoostTowers() { }

}

