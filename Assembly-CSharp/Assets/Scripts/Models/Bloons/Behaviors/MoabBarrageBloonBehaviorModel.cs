namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(MoabBarrageBloonBehavior), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class MoabBarrageBloonBehaviorModel : BloonBehaviorModelWithTowerTracking
{
	public int damage; //Field offset: 0x38
	public String[] ignoreImmunityForBloonTypes; //Field offset: 0x40
	public BloonProperties immuneBloonProperties; //Field offset: 0x48
	public int initialDelayFrames; //Field offset: 0x4C
	[SerializeField]
	private float initialDelay; //Field offset: 0x50
	public int intervalFrames; //Field offset: 0x54
	[SerializeField]
	private float interval; //Field offset: 0x58
	public AssetPathModel missileDisplayPath; //Field offset: 0x60
	public float missileDisplayLifespan; //Field offset: 0x68
	public AssetPathModel explosionDisplayPath; //Field offset: 0x70
	public float explosionDisplayLifespan; //Field offset: 0x78
	public bool rotateEffectWithBloon; //Field offset: 0x7C
	[SerializeField]
	private float randomDelayMax; //Field offset: 0x80
	public int randomDelayMaxFrames; //Field offset: 0x84
	public int numOfMissiles; //Field offset: 0x88
	public AudioClipReference sound1; //Field offset: 0x90
	public AudioClipReference sound2; //Field offset: 0x98
	public AudioClipReference sound3; //Field offset: 0xA0
	public AudioClipReference sound4; //Field offset: 0xA8
	public AudioClipReference sound5; //Field offset: 0xB0

	public float InitialDelay
	{
		 get { } //Length: 6
		 set { } //Length: 21
	}

	public float Interval
	{
		 get { } //Length: 6
		 set { } //Length: 21
	}

	public MoabBarrageBloonBehaviorModel() { }

	public MoabBarrageBloonBehaviorModel(string name, int damage, float initialDelay, float interval, String[] ignoreImmunityForBloonTypes, BloonProperties immuneBloonProperties, AssetPathModel missileDisplayPath, float missileDisplayLifespan, AssetPathModel explosionDisplayPath, float explosionDisplayLifespan, ObjectId tower, bool rotateEffectWithBloon, float randomDelayMax, int numOfMissiles, AudioClipReference sound1, AudioClipReference sound2, AudioClipReference sound3, AudioClipReference sound4, AudioClipReference sound5) { }

	public virtual Model Clone() { }

	public float get_InitialDelay() { }

	public float get_Interval() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public void set_InitialDelay(float value) { }

	public void set_Interval(float value) { }

}

