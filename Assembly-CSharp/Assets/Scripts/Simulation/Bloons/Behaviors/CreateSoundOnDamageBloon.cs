namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class CreateSoundOnDamageBloon : BloonBehavior
{
	public CreateSoundOnDamageBloonModel createSoundOnDamageBloonModel; //Field offset: 0x70

	public CreateSoundOnDamageBloon() { }

	public virtual void Damage(int amount) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void PlayDamageSound() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

