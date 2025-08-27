namespace Assets.Scripts.Unity.Bridge;

public class BeastHandlerToSimulation
{
	[CompilerGenerated]
	private sealed class <GetBeastHandlerPets>d__3 : IEnumerable<TowerToSimulation>, IEnumerable, IEnumerator<TowerToSimulation>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private TowerToSimulation <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public BeastHandlerToSimulation <>4__this; //Field offset: 0x28
		private IEnumerator<Tower> <>7__wrap1; //Field offset: 0x30

		private override TowerToSimulation System.Collections.Generic.IEnumerator<Assets.Scripts.Unity.Bridge.TowerToSimulation>.Current
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
		public <GetBeastHandlerPets>d__3(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<TowerToSimulation> System.Collections.Generic.IEnumerable<Assets.Scripts.Unity.Bridge.TowerToSimulation>.GetEnumerator() { }

		[DebuggerHidden]
		private override TowerToSimulation System.Collections.Generic.IEnumerator<Assets.Scripts.Unity.Bridge.TowerToSimulation>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private readonly UnityToSimulation sim; //Field offset: 0x10
	private readonly Tower tower; //Field offset: 0x18

	public BeastHandlerToSimulation(UnityToSimulation sim, Tower tower) { }

	public bool CanBeastHandlerMergeBeast(string beastTowerId) { }

	public int GetBeastHandlerContributionsToUpgrade(string beastTowerId, int upgradeTier = -1) { }

	public int GetBeastHandlerCurrentPower(string beastTowerId) { }

	[IteratorStateMachine(typeof(<GetBeastHandlerPets>d__3))]
	public IEnumerable<TowerToSimulation> GetBeastHandlerPets() { }

	public int GetBeastIndex(string beastTowerId) { }

	public bool IsBeastHandlerBeastBuffed(string beastTowerId) { }

	public bool IsBeastHandlerBeastLostThroughContribution(string beastTowerId) { }

	public bool IsBeastHandlerContributingAndBuffing(string beastTowerId, int currentUpgradeTier) { }

}

