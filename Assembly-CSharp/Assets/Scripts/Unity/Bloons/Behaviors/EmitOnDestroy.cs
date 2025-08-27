namespace Assets.Scripts.Unity.Bloons.Behaviors;

public class EmitOnDestroy : BloonBehavior
{
	public Projectile projectile; //Field offset: 0x88
	public Projectile expProjectile; //Field offset: 0x90
	public Emission emission; //Field offset: 0x98
	public Emission expEmission; //Field offset: 0xA0
	public Effect effect; //Field offset: 0xA8
	public Effect expEffect; //Field offset: 0xB0
	public AudioClip sound1; //Field offset: 0xB8
	public AudioClip expSound1; //Field offset: 0xC0
	public AudioClip sound2; //Field offset: 0xC8
	public AudioClip expSound2; //Field offset: 0xD0

	public virtual BloonBehaviorModel Def
	{
		 get { } //Length: 677
	}

	public EmitOnDestroy() { }

	public virtual BloonBehaviorModel get_Def() { }

}

