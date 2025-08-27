namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "Cash", menuName = "BTD6/Behaviors/Projectiles/Cash")]
public class Cash : ProjectileBehavior
{
	public float minimum; //Field offset: 0x30
	public float maximum; //Field offset: 0x34
	public float bonusMultiplier; //Field offset: 0x38
	public float salvage; //Field offset: 0x3C
	public bool noTransformCash; //Field offset: 0x40
	public bool distributeSalvage; //Field offset: 0x41
	public bool forceCreateProjectile; //Field offset: 0x42
	public bool isDoubleable; //Field offset: 0x43
	public bool distributeBonusIncome; //Field offset: 0x44

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 278
	}

	public Cash() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

