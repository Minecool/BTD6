namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class CreateSoundOnSpawnBloon : BloonBehavior
{
	public CreateSoundOnSpawnBloonModel createSoundOnSpawnBloonModel; //Field offset: 0x70

	public CreateSoundOnSpawnBloon() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnSpawn() { }

	private void PlaySpawnSound() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

