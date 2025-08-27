namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class CreateSoundOnPickup : ProjectileBehavior
{
	public CreateSoundOnPickupModel createSoundOnPickupModel; //Field offset: 0x68

	public CreateSoundOnPickup() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual float Pickup() { }

	private void PlayPickupSound() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

