namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class VineRupture : AbilityBehavior
{
	public VineRupture parent; //Field offset: 0x88
	public Effect effect; //Field offset: 0x90
	public Effect expEffect; //Field offset: 0x98
	public float interval; //Field offset: 0xA0
	public string expInterval; //Field offset: 0xA8
	public Projectile projectile; //Field offset: 0xB0
	public Projectile expProjectile; //Field offset: 0xB8
	public AudioClip sound1; //Field offset: 0xC0
	public AudioClip expSound1; //Field offset: 0xC8
	public AudioClip sound2; //Field offset: 0xD0
	public AudioClip expSound2; //Field offset: 0xD8
	public AudioClip sound3; //Field offset: 0xE0
	public AudioClip expSound3; //Field offset: 0xE8
	public AudioClip sound4; //Field offset: 0xF0
	public AudioClip expSound4; //Field offset: 0xF8

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 1101
	}

	public VineRupture() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

