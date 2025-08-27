namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class CreateSoundOnProjectileExhaust : ProjectileBehavior
{
	public CreateSoundOnProjectileExhaustModel createSoundOnProjectileExhaustModel; //Field offset: 0x68

	public CreateSoundOnProjectileExhaust() { }

	public virtual void Exhausted() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void PlayProjectileExhaustSound() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

