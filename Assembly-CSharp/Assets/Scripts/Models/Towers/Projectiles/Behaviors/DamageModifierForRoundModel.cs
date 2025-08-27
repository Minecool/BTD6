namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(DamageModifierForRound), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DamageModifierForRoundModel : DamageModifierModel
{
	public float damagePerRound; //Field offset: 0x38
	public int roundCap; //Field offset: 0x3C

	public DamageModifierForRoundModel(string name, float damagePerRound, int roundCap) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

