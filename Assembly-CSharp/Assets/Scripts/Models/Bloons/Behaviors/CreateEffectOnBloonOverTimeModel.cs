namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(CreateEffectOnBloonOverTime), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateEffectOnBloonOverTimeModel : BloonBehaviorModelWithTowerTracking
{
	public int intervalFrames; //Field offset: 0x38
	[SerializeField]
	private float interval; //Field offset: 0x3C
	public PrefabReference displayPath; //Field offset: 0x40
	public float displayLifetime; //Field offset: 0x48
	public bool triggerImmediate; //Field offset: 0x4C
	public bool rotateEffectWithBloon; //Field offset: 0x4D
	[SerializeField]
	private float initialDelay; //Field offset: 0x50
	public int initialDelayFrames; //Field offset: 0x54
	public AudioClipReference sound1; //Field offset: 0x58
	public AudioClipReference sound2; //Field offset: 0x60
	public AudioClipReference sound3; //Field offset: 0x68
	public AudioClipReference sound4; //Field offset: 0x70
	public AudioClipReference sound5; //Field offset: 0x78

	public float Interval
	{
		 get { } //Length: 6
		 set { } //Length: 21
	}

	public CreateEffectOnBloonOverTimeModel() { }

	public CreateEffectOnBloonOverTimeModel(string name, float interval, PrefabReference displayPath, float displayLifetime, bool triggerImmediate, ObjectId tower, bool rotateEffectWithBloon, float initialDelay, AudioClipReference sound1, AudioClipReference sound2, AudioClipReference sound3, AudioClipReference sound4, AudioClipReference sound5) { }

	public virtual Model Clone() { }

	public float get_Interval() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public void set_Interval(float value) { }

}

