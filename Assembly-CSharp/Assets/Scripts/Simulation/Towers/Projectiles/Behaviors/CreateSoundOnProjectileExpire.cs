namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class CreateSoundOnProjectileExpire : ProjectileBehavior
{
	public CreateSoundOnProjectileExpireModel createSoundOnProjectileExpireModel; //Field offset: 0x68
	private List<AudioClipReference> sounds; //Field offset: 0x70

	public CreateSoundOnProjectileExpire() { }

	public virtual void Expired() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void PlayProjectileExpireSound() { }

	private void SetupSounds() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

