namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "RetargetOnContactDelay", menuName = "BTD6/Behaviors/Projectiles/RetargetOnContactDelay")]
public class RetargetOnContactDelay : ProjectileBehavior
{
	public float distance; //Field offset: 0x30
	public int maxBounces; //Field offset: 0x34
	public float delay; //Field offset: 0x38
	public bool onlyIfFirstBloonDestroyed; //Field offset: 0x3C
	public PrefabReference display; //Field offset: 0x40
	public float displayLifetime; //Field offset: 0x48
	public float displayLengthScale; //Field offset: 0x4C
	public float displayLength; //Field offset: 0x50

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 272
	}

	public RetargetOnContactDelay() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

