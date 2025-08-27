namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class AnimateParentTowerOnCollide : ProjectileBehavior
{
	private AnimateParentTowerOnCollideModel def; //Field offset: 0x88
	public int animationState; //Field offset: 0x90
	public string expAnimationState; //Field offset: 0x98
	public float minTimeBetween; //Field offset: 0xA0
	public string expMinTimeBetween; //Field offset: 0xA8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 184
	}

	public AnimateParentTowerOnCollide() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

