namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "RemoveBloonModifiers", menuName = "BTD6/Behaviors/Projectiles/RemoveBloonModifiers")]
public class RemoveBloonModifiers : ProjectileBehavior
{
	public bool cleanseRegen; //Field offset: 0x30
	public bool cleanseCamo; //Field offset: 0x31
	public bool cleanseLead; //Field offset: 0x32
	public bool cleanseFortified; //Field offset: 0x33
	public bool cleanseOnlyIfDamaged; //Field offset: 0x34
	public string bloonTagExclude; //Field offset: 0x38
	public string bloonTagExplicit; //Field offset: 0x40

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 282
	}

	public RemoveBloonModifiers() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

