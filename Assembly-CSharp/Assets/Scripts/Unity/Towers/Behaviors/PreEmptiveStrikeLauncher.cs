namespace Assets.Scripts.Unity.Towers.Behaviors;

public class PreEmptiveStrikeLauncher : TowerBehavior
{
	public PreEmptiveStrikeLauncher parent; //Field offset: 0x98
	public Projectile projectile; //Field offset: 0xA0
	public Projectile expProjectile; //Field offset: 0xA8
	public Emission emission; //Field offset: 0xB0
	public Emission expEmission; //Field offset: 0xB8
	public Effect ejectEffect; //Field offset: 0xC0
	public Effect expEjectEffect; //Field offset: 0xC8
	public int animationState; //Field offset: 0xD0
	public string expAnimationState; //Field offset: 0xD8
	public int animationStateSecond; //Field offset: 0xE0
	public string expAnimationStateSecond; //Field offset: 0xE8
	public GameObject throwMarker; //Field offset: 0xF0
	public GameObject throwMarkerSecond; //Field offset: 0xF8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 1084
	}

	public PreEmptiveStrikeLauncher() { }

	public virtual TowerBehaviorModel get_Def() { }

}

