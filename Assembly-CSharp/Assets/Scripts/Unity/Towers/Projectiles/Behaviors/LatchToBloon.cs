namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class LatchToBloon : ProjectileBehavior
{
	public LatchToBloon parent; //Field offset: 0x88
	public bool rotateWithBloon; //Field offset: 0x90
	public string expRotateWithBloon; //Field offset: 0x98
	public int animationStateOnSetTarget; //Field offset: 0xA0
	public string expAnimationStateOnSetTarget; //Field offset: 0xA8
	public int animationStateOnTowerOnDestroy; //Field offset: 0xB0
	public string expAnimationStateOnTowerOnDestroy; //Field offset: 0xB8
	public float postBloonDestroyTime; //Field offset: 0xC0
	public string expPostBloonDestroyTime; //Field offset: 0xC8
	public float bloonSpeedMultiplier; //Field offset: 0xD0
	public string expBloonSpeedMultiplier; //Field offset: 0xD8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 204
	}

	public LatchToBloon() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

