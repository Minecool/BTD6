namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "RandomDisplay", menuName = "BTD6/Behaviors/Projectiles/RandomDisplay")]
public class RandomDisplay : ProjectileBehavior
{
	public bool applyRandomRotation; //Field offset: 0x30
	public PrefabReference[] displays; //Field offset: 0x38

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 138
	}

	public RandomDisplay() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

