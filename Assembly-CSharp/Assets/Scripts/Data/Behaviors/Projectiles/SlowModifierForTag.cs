namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "SlowModifierForTag", menuName = "BTD6/Behaviors/Projectiles/SlowModifierForTag")]
public class SlowModifierForTag : ProjectileBehavior
{
	public float multiplier; //Field offset: 0x30
	public string tagValue; //Field offset: 0x38
	public bool makeNotTag; //Field offset: 0x40
	public string slowId; //Field offset: 0x48
	public bool resetToUnmodified; //Field offset: 0x50
	public bool preventMutation; //Field offset: 0x51
	public float lifespanOverride; //Field offset: 0x54

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 216
	}

	public SlowModifierForTag() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

