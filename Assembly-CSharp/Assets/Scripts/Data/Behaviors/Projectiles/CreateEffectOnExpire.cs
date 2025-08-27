namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "CreateEffectOnExpire", menuName = "BTD6/Behaviors/Projectiles/CreateEffectOnExpire")]
public class CreateEffectOnExpire : ProjectileBehavior
{
	public float lifespan; //Field offset: 0x30
	public PrefabReference display; //Field offset: 0x38
	public Fullscreen fullscreen; //Field offset: 0x40
	public bool randomRotation; //Field offset: 0x44
	public Effect effect; //Field offset: 0x48
	public bool useTargetPosition; //Field offset: 0x50

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 297
	}

	public CreateEffectOnExpire() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

