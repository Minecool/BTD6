namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "CreateTextEffect", menuName = "BTD6/Behaviors/Projectiles/CreateTextEffect")]
public class CreateTextEffect : ProjectileBehavior
{
	public float lifespan; //Field offset: 0x30
	public bool useTowerPosition; //Field offset: 0x34
	public PrefabReference display; //Field offset: 0x38

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 148
	}

	public CreateTextEffect() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

