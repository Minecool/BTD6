namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class CreateSoundOnBloonDestroyed : TowerBehavior
{
	private const int limitCounter = 7200; //Field offset: 0x0
	public CreateSoundOnBloonDestroyedModel createSoundOnBloonDestroyedModel; //Field offset: 0x68

	public CreateSoundOnBloonDestroyed() { }

	private static bool Contains(String[] arr, string str) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public void OnBloonDegraded(Projectile projectile, Bloon bloon, Tower emittedBy, DamageResult damageResult) { }

	protected virtual void OnDestroy() { }

	private void PlayBloonDegradeSound() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

