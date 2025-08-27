namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "MoabTakedown", menuName = "BTD6/Behaviors/Projectiles/MoabTakedown")]
public class MoabTakedown : ProjectileBehavior
{
	public float speed; //Field offset: 0x30
	public float addative; //Field offset: 0x34
	public float multiplier; //Field offset: 0x38
	public bool increaseMoabBloonWorth; //Field offset: 0x3C
	public IncreaseWorthTextEffect increaseWorthTextEffect; //Field offset: 0x40
	public float destroyBloonRadius; //Field offset: 0x48
	public PrefabReference displayAtEject; //Field offset: 0x50

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 366
	}

	public MoabTakedown() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

