namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(FireballAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class FireballActionModel : BloonBehaviorActionModel
{
	internal class MagmaPoolMutator : BehaviorMutator
	{
		public PrefabReference magmaPoolDisplay; //Field offset: 0x70
		public float magmaPoolRadius; //Field offset: 0x78
		public float rateMultiplier; //Field offset: 0x7C
		public float rangeMultiplier; //Field offset: 0x80

		public MagmaPoolMutator(string id, PrefabReference magmaPoolDisplay, float magmaPoolRadius, float rateMultiplier, float rangeMultiplier) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public const string mutatorIdStun = "TowerStun"; //Field offset: 0x0
	public const string mutatorIdMagma = "MagmaPool"; //Field offset: 0x0
	public PrefabReference towerStunEffect; //Field offset: 0x38
	public PrefabReference fireballDisplay; //Field offset: 0x40
	public PrefabReference magmaPoolDisplay; //Field offset: 0x48
	public AudioClipReference[] sounds; //Field offset: 0x50
	public float projectileSpeed; //Field offset: 0x58
	public float stunDuration; //Field offset: 0x5C
	public float magmaPoolDuration; //Field offset: 0x60
	public float magmaPoolRadius; //Field offset: 0x64
	public float rateMultiplier; //Field offset: 0x68
	public float rangeMultiplier; //Field offset: 0x6C
	public string animationCurveId; //Field offset: 0x70
	public int fireballAmount; //Field offset: 0x78
	private MagmaPoolMutator magmaPoolMutator; //Field offset: 0x80
	private TowerFreezeMutator stunMutator; //Field offset: 0x88
	private MagmaMutator magmaDebuffMutator; //Field offset: 0x90

	public MagmaMutator MagmaDebuffMutator
	{
		 get { } //Length: 162
	}

	public MagmaPoolMutator MagmaMutator
	{
		 get { } //Length: 345
	}

	public TowerFreezeMutator StunMutator
	{
		 get { } //Length: 156
	}

	public FireballActionModel() { }

	public FireballActionModel(string name, string actionId, PrefabReference towerStunEffect, PrefabReference fireballDisplay, PrefabReference magmaPoolDisplay, AudioClipReference[] sounds, int fireballAmount, float projectileSpeed, float stunDuration, float magmaPoolDuration, float magmaPoolRadius, float rateMultiplier, float rangeMultiplier, string animationCurveId) { }

	public virtual Model Clone() { }

	public MagmaMutator get_MagmaDebuffMutator() { }

	public MagmaPoolMutator get_MagmaMutator() { }

	public TowerFreezeMutator get_StunMutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

