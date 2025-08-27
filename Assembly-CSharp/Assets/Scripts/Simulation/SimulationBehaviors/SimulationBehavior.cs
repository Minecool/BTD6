namespace Assets.Scripts.Simulation.SimulationBehaviors;

public abstract class SimulationBehavior : RootBehavior
{

	protected SimulationBehavior() { }

	public override double AddCashTransform(double amount, CashType from, CashSource source) { }

	public override PathSegment BloonSpawnOrigin() { }

	public override void OnBloonSpawned(Bloon bloon) { }

	public override void OnMatchReady(bool loadedSave) { }

	public override void OnRoundEnd(int roundArrayIndex) { }

	public override void OnRoundStart(int roundArrayIndex) { }

	public override double RemoveCashTransform(double amount, CashType from, CashSource source) { }

}

