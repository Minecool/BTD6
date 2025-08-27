namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "CreateEffectProjectileAfterTime", menuName = "BTD6/Behaviors/Projectiles/CreateEffectProjectileAfterTime")]
public class CreateEffectProjectileAfterTime : ProjectileBehavior
{
	public Effect effect; //Field offset: 0x30
	public float time; //Field offset: 0x38
	public bool repeat; //Field offset: 0x3C
	public bool isBuffedByRate; //Field offset: 0x3D
	public bool useTargetPosition; //Field offset: 0x3E

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 273
	}

	public CreateEffectProjectileAfterTime() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

