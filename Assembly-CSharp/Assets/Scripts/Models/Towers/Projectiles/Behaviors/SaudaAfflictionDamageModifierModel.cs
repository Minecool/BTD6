namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(SaudaAfflictionDamageModifier), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SaudaAfflictionDamageModifierModel : DamageModifierModel
{
	public string lv7Tags; //Field offset: 0x38
	public String[] lv7TagsList; //Field offset: 0x40
	public float lv7NonMoabBonus; //Field offset: 0x48
	public float lv7MoabBonus; //Field offset: 0x4C
	public string lv11ExcludeTags; //Field offset: 0x50
	public String[] lv11ExcludeTagsList; //Field offset: 0x58
	public float lv11NonMoabBonus; //Field offset: 0x60
	public float lv11MoabBonus; //Field offset: 0x64
	public string lv19BloonTags; //Field offset: 0x68
	public String[] lv19BloonTagsList; //Field offset: 0x70
	public float lv19NonMoabBonus; //Field offset: 0x78
	public float lv19MoabBonus; //Field offset: 0x7C

	public SaudaAfflictionDamageModifierModel(string name, string lv7Tags, float lv7NonMoabBonus, float lv7MoabBonus, string lv11ExcludeTags, float lv11NonMoabBonus, float lv11MoabBonus, string lv19BloonTags, float lv19NonMoabBonus, float lv19MoabBonus) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

