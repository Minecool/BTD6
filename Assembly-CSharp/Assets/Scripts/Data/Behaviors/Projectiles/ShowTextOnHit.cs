namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "ShowTextOnHit", menuName = "BTD6/Behaviors/Projectiles/ShowTextOnHit")]
public class ShowTextOnHit : ProjectileBehavior
{
	public float lifespan; //Field offset: 0x30
	public bool useTowerPosition; //Field offset: 0x34
	public string text; //Field offset: 0x38
	public PrefabReference display; //Field offset: 0x40

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 169
	}

	public ShowTextOnHit() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

