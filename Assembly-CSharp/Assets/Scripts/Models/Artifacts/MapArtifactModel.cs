namespace Assets.Scripts.Models.Artifacts;

public class MapArtifactModel : ArtifactModelWithBehaviors<MapArtifactBehaviorModel>
{
	[CompilerGenerated]
	private sealed class <GetAdditionalBoostTowers>d__5 : IEnumerable<RogueInstaMonkey>, IEnumerable, IEnumerator<RogueInstaMonkey>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private RogueInstaMonkey <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public MapArtifactModel <>4__this; //Field offset: 0x28
		private MapArtifactBehaviorModel[] <>7__wrap1; //Field offset: 0x30
		private int <>7__wrap2; //Field offset: 0x38
		private IEnumerator<RogueInstaMonkey> <>7__wrap3; //Field offset: 0x40

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

		private void <>m__Finally1() { }

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


	public MapArtifactModel(string name, int tier, string baseId, MapArtifactBehaviorModel[] artifactBehaviors, string nameLocKey, string descriptionLocKey, String[] descriptionParams, SpriteReference icon, string rarityFrameType, bool isBossArtifact, bool isQuestArtifact, int merchantCostMultiplier) { }

	public void ActivateAllBehaviors(ILegendsDataProvider legendsDataProvider) { }

	public virtual Model Clone() { }

	public void DeactivateAllBehaviors(ILegendsDataProvider legendsDataProvider) { }

	[IteratorStateMachine(typeof(<GetAdditionalBoostTowers>d__5))]
	public IEnumerable<RogueInstaMonkey> GetAdditionalBoostTowers() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

