namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "CreateEffectOnExhausted", menuName = "BTD6/Behaviors/Projectiles/CreateEffectOnExhausted")]
public class CreateEffectOnExhausted : ProjectileBehavior
{
	public Effect effect; //Field offset: 0x30
	public float lifespan; //Field offset: 0x38
	public Fullscreen fullscreen; //Field offset: 0x3C
	public bool randomRotation; //Field offset: 0x40
	public PrefabReference display; //Field offset: 0x48
	public ParticleSystem[] particleSystems; //Field offset: 0x50

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 268
	}

	public CreateEffectOnExhausted() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

