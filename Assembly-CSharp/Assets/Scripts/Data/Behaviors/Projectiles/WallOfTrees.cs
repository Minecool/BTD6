namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "WallOfTrees", menuName = "BTD6/Behaviors/Projectiles/WallOfTrees")]
public class WallOfTrees : ProjectileBehavior
{
	public float rbeCapacity; //Field offset: 0x30
	public float rbeCashMultiplier; //Field offset: 0x34
	public Projectile projectile; //Field offset: 0x38
	public Emission emission; //Field offset: 0x40
	public int animationState; //Field offset: 0x48
	public bool onlyDamageLastBloon; //Field offset: 0x4C

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 284
	}

	public WallOfTrees() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

