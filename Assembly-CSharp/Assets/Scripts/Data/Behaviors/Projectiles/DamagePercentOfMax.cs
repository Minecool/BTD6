namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "DamagePercentOfMax", menuName = "BTD6/Behaviors/Projectiles/DamagePercentOfMax")]
public class DamagePercentOfMax : ProjectileBehavior
{
	public float percent; //Field offset: 0x30
	public string tagValue; //Field offset: 0x38
	public bool damageBloonsOffscreenOnly; //Field offset: 0x40

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 201
	}

	public DamagePercentOfMax() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

