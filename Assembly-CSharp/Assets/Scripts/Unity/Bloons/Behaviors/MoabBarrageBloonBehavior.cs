namespace Assets.Scripts.Unity.Bloons.Behaviors;

public class MoabBarrageBloonBehavior : BloonBehavior
{
	public int damage; //Field offset: 0x88
	public string expDamage; //Field offset: 0x90
	public float initialDelay; //Field offset: 0x98
	public string expInitialDelay; //Field offset: 0xA0
	public float interval; //Field offset: 0xA8
	public string expInterval; //Field offset: 0xB0
	public string damageType; //Field offset: 0xB8
	public string expDamageType; //Field offset: 0xC0
	public string ignoreImmunityForBloonTypes; //Field offset: 0xC8
	public string expIgnoreImmunityForBloonTypes; //Field offset: 0xD0
	public GameObject missileDisplay; //Field offset: 0xD8
	public GameObject expMissileDisplay; //Field offset: 0xE0
	public GameObject splosionDisplay; //Field offset: 0xE8
	public GameObject expSplosionDisplay; //Field offset: 0xF0
	public float missileDisplayLifespan; //Field offset: 0xF8
	public string expMissileDisplayLifespan; //Field offset: 0x100
	public float splosionDisplayLifespan; //Field offset: 0x108
	public string expSplosionDisplayLifespan; //Field offset: 0x110
	public bool rotateEffectWithBloon; //Field offset: 0x118
	public string expRotateEffectWithBloon; //Field offset: 0x120
	public float randomDelayMax; //Field offset: 0x128
	public string expRandomDelayMax; //Field offset: 0x130
	public int numOfMissiles; //Field offset: 0x138
	public string expNumOfMissiles; //Field offset: 0x140
	public AudioClip sound1; //Field offset: 0x148
	public AudioClip expSound1; //Field offset: 0x150
	public AudioClip sound2; //Field offset: 0x158
	public AudioClip expSound2; //Field offset: 0x160
	public AudioClip sound3; //Field offset: 0x168
	public AudioClip expSound3; //Field offset: 0x170
	public AudioClip sound4; //Field offset: 0x178
	public AudioClip expSound4; //Field offset: 0x180
	public AudioClip sound5; //Field offset: 0x188
	public AudioClip expSound5; //Field offset: 0x190

	public virtual BloonBehaviorModel Def
	{
		 get { } //Length: 1371
	}

	public MoabBarrageBloonBehavior() { }

	public virtual BloonBehaviorModel get_Def() { }

}

