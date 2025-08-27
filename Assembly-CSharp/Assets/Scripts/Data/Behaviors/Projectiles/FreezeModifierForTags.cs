namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "FreezeModifierForTags", menuName = "BTD6/Behaviors/Projectiles/FreezeModifierForTags")]
public class FreezeModifierForTags : ProjectileBehavior
{
	public float multiplier; //Field offset: 0x30
	public string tags; //Field offset: 0x38
	public string freezeId; //Field offset: 0x40
	public bool resetToUnmodified; //Field offset: 0x48
	public bool preventMutation; //Field offset: 0x49

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 231
	}

	public FreezeModifierForTags() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

