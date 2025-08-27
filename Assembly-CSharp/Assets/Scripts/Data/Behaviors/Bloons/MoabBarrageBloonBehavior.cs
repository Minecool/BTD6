namespace Assets.Scripts.Data.Behaviors.Bloons;

[CreateAssetMenu(fileName = "MoabBarrageBloonBehavior", menuName = "BTD6/Behaviors/Bloons/MoabBarrageBloonBehavior")]
public class MoabBarrageBloonBehavior : BloonBehavior
{
	public int damage; //Field offset: 0x30
	public float initialDelay; //Field offset: 0x34
	public float interval; //Field offset: 0x38
	public string damageType; //Field offset: 0x40
	public string ignoreImmunityForBloonTypes; //Field offset: 0x48
	public AssetPath missileDisplay; //Field offset: 0x50
	public AssetPath splosionDisplay; //Field offset: 0x58
	public float missileDisplayLifespan; //Field offset: 0x60
	public float explosionDisplayLifespan; //Field offset: 0x64
	public bool rotateEffectWithBloon; //Field offset: 0x68
	public float randomDelayMax; //Field offset: 0x6C
	public int numOfMissiles; //Field offset: 0x70
	public AudioClipReference sound1; //Field offset: 0x78
	public AudioClipReference sound2; //Field offset: 0x80
	public AudioClipReference sound3; //Field offset: 0x88
	public AudioClipReference sound4; //Field offset: 0x90
	public AudioClipReference sound5; //Field offset: 0x98

	public virtual BloonBehaviorModel Def
	{
		 get { } //Length: 718
	}

	public MoabBarrageBloonBehavior() { }

	public virtual BloonBehaviorModel get_Def() { }

}

