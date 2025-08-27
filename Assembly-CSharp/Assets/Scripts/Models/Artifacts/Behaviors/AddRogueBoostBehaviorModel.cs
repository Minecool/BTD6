namespace Assets.Scripts.Models.Artifacts.Behaviors;

public class AddRogueBoostBehaviorModel : MapArtifactBehaviorModel
{
	[CompilerGenerated]
	private sealed class <GetAdditionalBoostTowers>d__5 : IEnumerable<RogueInstaMonkey>, IEnumerable, IEnumerator<RogueInstaMonkey>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private RogueInstaMonkey <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public AddRogueBoostBehaviorModel <>4__this; //Field offset: 0x28
		private int <i>5__2; //Field offset: 0x30

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
		public <GetAdditionalBoostTowers>d__5(int <>1__state) { }

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

	public RogueInstaMonkey tower; //Field offset: 0x30
	public int amountToAdd; //Field offset: 0x38

	public AddRogueBoostBehaviorModel(string name, RogueInstaMonkey tower, int amountToAdd) { }

	public virtual void Activate(ILegendsDataProvider legendsDataProvider) { }

	public virtual Model Clone() { }

	public virtual void Deactivate(ILegendsDataProvider legendsDataProvider) { }

	[IteratorStateMachine(typeof(<GetAdditionalBoostTowers>d__5))]
	public virtual IEnumerable<RogueInstaMonkey> GetAdditionalBoostTowers() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

