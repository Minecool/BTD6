namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class DamagePercentOfMax : DamageModifier
{
	public DamagePercentOfMaxModel damagePercentOfMaxModel; //Field offset: 0x68
	private bool offscreenDamageOverride; //Field offset: 0x70

	public DamagePercentOfMax() { }

	public virtual float GetDamageAdditive(Bloon bloon) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public void OnBloonSpawned(Bloon bloon) { }

	protected virtual void OnDestroy() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

