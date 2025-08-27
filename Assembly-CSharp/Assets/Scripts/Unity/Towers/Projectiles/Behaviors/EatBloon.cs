namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class EatBloon : ProjectileBehavior
{
	public EatBloon parent; //Field offset: 0x88
	public float rbeCapacity; //Field offset: 0x90
	public string expRbeCapacity; //Field offset: 0x98
	public float rbeCashMultiplier; //Field offset: 0xA0
	public string expRbeCashMultiplier; //Field offset: 0xA8
	public Projectile projectile; //Field offset: 0xB0
	public Projectile expProjectile; //Field offset: 0xB8
	public Emission emission; //Field offset: 0xC0
	public Emission expEmission; //Field offset: 0xC8
	public int animationStateOpen; //Field offset: 0xD0
	public string expAnimationStateOpen; //Field offset: 0xD8
	public int animationStateClosed; //Field offset: 0xE0
	public string expAnimationStateClosed; //Field offset: 0xE8
	public float timeUntilClose; //Field offset: 0xF0
	public string expTimeUntilClose; //Field offset: 0xF8
	public Effect effectOnEat; //Field offset: 0x100
	public Effect expEffectOnEat; //Field offset: 0x108
	public AudioClip bloonTrapOpenSound; //Field offset: 0x110
	public AudioClip expBloonTrapOpenSound; //Field offset: 0x118
	public AudioClip bloonTrapCloseSound; //Field offset: 0x120
	public AudioClip expBloonTrapCloseSound; //Field offset: 0x128

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 809
	}

	public EatBloon() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

