namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "CreateEffectOnExhaustFraction", menuName = "BTD6/Behaviors/Projectiles/CreateEffectOnExhaustFraction")]
public class CreateEffectOnExhaustFraction : ProjectileBehavior
{
	public float lifespan; //Field offset: 0x30
	public Effect effect; //Field offset: 0x38
	public Fullscreen fullscreen; //Field offset: 0x40
	public float fraction; //Field offset: 0x44
	public float durationFraction; //Field offset: 0x48
	public bool randomRotation; //Field offset: 0x4C

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 326
	}

	public CreateEffectOnExhaustFraction() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

