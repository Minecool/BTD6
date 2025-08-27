namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class ScaleDamageWithTime : DamageModifier
{
	public ScaleDamageWithTimeModel scaleDamageWithTimeModel; //Field offset: 0x68
	private int timeEmitted; //Field offset: 0x70
	public float baseDamage; //Field offset: 0x74

	public ScaleDamageWithTime() { }

	public virtual float GetDamageMultiplier(Bloon bloon) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

