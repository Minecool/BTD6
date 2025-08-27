namespace Assets.Scripts.Simulation.SimulationBehaviors;

public class RemovePropsOnRound : SimulationBehavior
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public Prop prop; //Field offset: 0x10

		public <>c__DisplayClass5_0() { }

		internal bool <PerformAction>b__0(string x) { }

	}

	private RemovePropsOnRoundModel behaviorModel; //Field offset: 0x58

	public RemovePropsOnRound() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnMatchReady(bool loadedSave) { }

	public virtual void OnRoundEnd(int roundArrayIndex) { }

	private void PerformAction(bool isLoadingSave = false) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

