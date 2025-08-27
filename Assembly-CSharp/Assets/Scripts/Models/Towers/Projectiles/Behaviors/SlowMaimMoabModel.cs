namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(SlowMaimMoab), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SlowMaimMoabModel : ProjectileBehaviorWithOverlayModel
{
	internal class Mutator : BehaviorMutator
	{
		public float multiplier; //Field offset: 0x70
		public string mutationId; //Field offset: 0x78
		public string overlayType; //Field offset: 0x80
		public float bloonPerHitDamageAddition; //Field offset: 0x88

		public Mutator(float bloonPerHitDamageAddition, float multiplier, string mutationId, bool isUnique, string overlayType) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	[SerializeField]
	private float moabDuration; //Field offset: 0x40
	public int moabDurationFrames; //Field offset: 0x44
	[SerializeField]
	private float bfbDuration; //Field offset: 0x48
	public int bfbDurationFrames; //Field offset: 0x4C
	[SerializeField]
	private float zomgDuration; //Field offset: 0x50
	public int zomgDurationFrames; //Field offset: 0x54
	[SerializeField]
	private float ddtDuration; //Field offset: 0x58
	public int ddtDurationFrames; //Field offset: 0x5C
	[SerializeField]
	private float badDuration; //Field offset: 0x60
	public int badDurationFrames; //Field offset: 0x64
	public float multiplier; //Field offset: 0x68
	private Mutator _moabMutator; //Field offset: 0x70
	private Mutator _bfbMutator; //Field offset: 0x78
	private Mutator _zomgMutator; //Field offset: 0x80
	private Mutator _ddtMutator; //Field offset: 0x88
	private Mutator _badMutator; //Field offset: 0x90
	public float bloonPerHitDamageAddition; //Field offset: 0x98

	public Mutator badMutator
	{
		 get { } //Length: 179
	}

	public Mutator bfbMutator
	{
		 get { } //Length: 183
	}

	public Mutator ddtMutator
	{
		 get { } //Length: 189
	}

	public Mutator moabMutator
	{
		 get { } //Length: 183
	}

	public Mutator zomgMutator
	{
		 get { } //Length: 189
	}

	public SlowMaimMoabModel(string name, float moabDuration, float bfbDuration, float zomgDuration, float ddtDuration, float badDuration, float multiplier, float bloonPerHitDamageAddition, string overlayType) { }

	public virtual Model Clone() { }

	public Mutator get_badMutator() { }

	public Mutator get_bfbMutator() { }

	public Mutator get_ddtMutator() { }

	public Mutator get_moabMutator() { }

	public Mutator get_zomgMutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

