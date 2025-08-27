namespace Assets.Scripts.Simulation.SimulationBehaviors;

public class RefreshHeroCooldownsOnRoundEnd : SimulationBehavior
{
	private RefreshHeroCooldownsOnRoundEndModel behaviorModel; //Field offset: 0x58

	public RefreshHeroCooldownsOnRoundEnd() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnRoundEnd(int roundArrayIndex) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

