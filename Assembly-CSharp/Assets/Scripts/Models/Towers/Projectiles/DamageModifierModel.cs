namespace Assets.Scripts.Models.Towers.Projectiles;

public abstract class DamageModifierModel : ProjectileBehaviorModel
{

	protected DamageModifierModel(string name) { }

	public override float GetDamageAdditive(Bloon bloon) { }

	public override float GetDamageMultiplier(Bloon bloon) { }

}

