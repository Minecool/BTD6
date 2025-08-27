namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(DamageModifierForTag), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DamageModifierForTagModel : DamageModifierModel
{
	public string tag; //Field offset: 0x38
	public String[] tags; //Field offset: 0x40
	public float damageMultiplier; //Field offset: 0x48
	public float damageAddative; //Field offset: 0x4C
	public bool mustIncludeAllTags; //Field offset: 0x50
	public bool applyOverMaxDamage; //Field offset: 0x51

	public DamageModifierForTagModel(string name, string tag, float damageMultiplier, float damageAddative, bool mustIncludeAllTags, bool applyOverMaxDamage) { }

	public virtual Model Clone() { }

	private bool DoesApplyBonus(Bloon bloon) { }

	public virtual float GetDamageAdditive(Bloon bloon) { }

	public virtual float GetDamageMultiplier(Bloon bloon) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

