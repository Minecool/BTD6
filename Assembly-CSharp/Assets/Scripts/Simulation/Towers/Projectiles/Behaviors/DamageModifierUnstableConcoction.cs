namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class DamageModifierUnstableConcoction : DamageModifier
{
	public DamageModifierUnstableConcoctionModel damageModifierUnstableConcoctionModel; //Field offset: 0x68
	private float bloonDamage; //Field offset: 0x70
	private float moabDamage; //Field offset: 0x74

	public DamageModifierUnstableConcoction() { }

	public float GetBloonDamage() { }

	public virtual float GetDamageAdditive(Bloon bloon) { }

	public float GetMoabDamage() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public void SetBloonDamage(float dmg) { }

	public void SetMoabDamage(float dmg) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

