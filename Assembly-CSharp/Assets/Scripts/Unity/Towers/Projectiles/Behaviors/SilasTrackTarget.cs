namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class SilasTrackTarget : ProjectileBehavior
{
	public SilasTrackTarget parent; //Field offset: 0x88
	public bool usingSharedRange; //Field offset: 0x90
	public string expUsingSharedRange; //Field offset: 0x98
	public float rotation; //Field offset: 0xA0
	public string expRotation; //Field offset: 0xA8
	public float minimumSpeed; //Field offset: 0xB0
	public string expMinimumSpeed; //Field offset: 0xB8
	public float maximumSpeed; //Field offset: 0xC0
	public string expMaximumSpeed; //Field offset: 0xC8
	public float acceleration; //Field offset: 0xD0
	public string expAcceleration; //Field offset: 0xD8
	public float lifespan; //Field offset: 0xE0
	public string expLifespan; //Field offset: 0xE8
	public AudioClip sound1; //Field offset: 0xF0
	public AudioClip expSound1; //Field offset: 0xF8
	public AudioClip sound2; //Field offset: 0x100
	public AudioClip expSound2; //Field offset: 0x108
	public AudioClip sound3; //Field offset: 0x110
	public AudioClip expSound3; //Field offset: 0x118
	public AudioClip sound4; //Field offset: 0x120
	public AudioClip expSound4; //Field offset: 0x128
	public AudioClip sound5; //Field offset: 0x130
	public AudioClip expSound5; //Field offset: 0x138
	public GameObject spawnMarker; //Field offset: 0x140
	public GameObject expSpawnMarker; //Field offset: 0x148
	public float projectileWaitTime; //Field offset: 0x150
	public string expProjectileWaitTime; //Field offset: 0x158

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 1748
	}

	public SilasTrackTarget() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

