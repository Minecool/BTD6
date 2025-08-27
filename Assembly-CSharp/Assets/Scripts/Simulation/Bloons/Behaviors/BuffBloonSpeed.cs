namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class BuffBloonSpeed : BloonBehavior
{
	public BuffBloonSpeedModel modl; //Field offset: 0x70

	public BuffBloonSpeed() { }

	public virtual void Attatched() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void OnBloonSpawned(Bloon bloon) { }

	protected virtual void OnDestroy() { }

	private void Process(int elasped) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

