namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "AnimateParentTowerOnCollide", menuName = "BTD6/Behaviors/Projectiles/AnimateParentTowerOnCollide")]
public class AnimateParentTowerOnCollide : ProjectileBehavior
{
	public int animationState; //Field offset: 0x30
	public float minTimeBetween; //Field offset: 0x34

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 137
	}

	public AnimateParentTowerOnCollide() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

