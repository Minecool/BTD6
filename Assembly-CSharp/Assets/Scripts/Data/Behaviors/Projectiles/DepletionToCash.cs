namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "DepletionToCash", menuName = "BTD6/Behaviors/Projectiles/DepletionToCash")]
public class DepletionToCash : ProjectileBehavior
{
	public float minimum; //Field offset: 0x30
	public float maximum; //Field offset: 0x34
	public float salvage; //Field offset: 0x38

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 155
	}

	public DepletionToCash() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

