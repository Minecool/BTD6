namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "SaudaAfflictionDamageModifier", menuName = "BTD6/Behaviors/Projectiles/SaudaAfflictionDamageModifier")]
public class SaudaAfflictionDamageModifier : ProjectileBehavior
{
	public string lv7Tags; //Field offset: 0x30
	public float lv7NonMoabBonus; //Field offset: 0x38
	public float lv7MoabBonus; //Field offset: 0x3C
	public string lv11ExcludeTags; //Field offset: 0x40
	public float lv11NonMoabBonus; //Field offset: 0x48
	public float lv11MoabBonus; //Field offset: 0x4C
	public string lv19BloonTags; //Field offset: 0x50
	public float lv19NonMoabBonus; //Field offset: 0x58
	public float lv19MoabBonus; //Field offset: 0x5C

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 285
	}

	public SaudaAfflictionDamageModifier() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

