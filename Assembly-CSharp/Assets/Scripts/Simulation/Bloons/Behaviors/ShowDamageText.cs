namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class ShowDamageText : BloonBehavior
{
	public ShowDamageTextModel showDamageTextModel; //Field offset: 0x70

	public ShowDamageText() { }

	public virtual void Damage(int amount) { }

	public virtual void DamageArmour(int amount) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnImmuneFromHit(bool destroyedTheProjectile) { }

	private void ShowValue(int amount) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

