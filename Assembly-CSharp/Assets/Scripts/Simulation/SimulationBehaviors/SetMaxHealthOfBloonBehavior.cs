namespace Assets.Scripts.Simulation.SimulationBehaviors;

public class SetMaxHealthOfBloonBehavior : SimulationBehavior
{
	private SetMaxHealthOfBloonBehaviorModel setMaxHealthOfBloonBehaviorModel; //Field offset: 0x58

	public SetMaxHealthOfBloonBehavior() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void OnBloonSpawned(Bloon bloon) { }

	public virtual void OnRoundEnd(int roundArrayIndex) { }

	public virtual void OnRoundStart(int roundArrayIndex) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

