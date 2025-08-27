namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class CreateSoundOnDamageArmour : BloonBehavior
{
	public CreateSoundOnDamageArmourModel createSoundOnDamageArmourModel; //Field offset: 0x70

	public CreateSoundOnDamageArmour() { }

	public virtual void DamageArmour(int amount) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void PlayDamageSound() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

