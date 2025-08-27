namespace Assets.Scripts.Simulation.Artifacts.Behaviors;

public class EndOfRoundCashBoostBehavior : BoostArtifactBehavior
{
	public EndOfRoundCashBoostBehaviorModel endOfRoundCashBoostBehaviorModel; //Field offset: 0x78

	public EndOfRoundCashBoostBehavior() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void OnRoundEnd(int round) { }

	public virtual void OnTowerEnterZone(Tower tower) { }

	public virtual void OnTowerExitZone(Tower tower) { }

}

