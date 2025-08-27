namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class DamageInRingRadius : Damage
{
	public float innerRingRadius; //Field offset: 0x120
	public string expInnerRingRadius; //Field offset: 0x128

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 548
	}

	public DamageInRingRadius() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

