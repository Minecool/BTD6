namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(KineticChargeProjectile), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class KineticChargeProjectileModel : ProjectileBehaviorModel
{
	internal class DisplayMutator : BehaviorMutator
	{
		private readonly string displayMutatorId; //Field offset: 0x70

		public DisplayMutator(string displayMutatorId) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public const string DisplayMutatorId_Default = "KineticChargeDisplay"; //Field offset: 0x0
	public float deployRadiusMax; //Field offset: 0x38
	public float deployTime; //Field offset: 0x3C
	public int deployTimeFrames; //Field offset: 0x40
	public float duration; //Field offset: 0x44
	public int durationFrames; //Field offset: 0x48
	public float travelSpeed; //Field offset: 0x4C
	public int maxAdditionalDamageAmount; //Field offset: 0x50
	public int damageTakenMaxAmount; //Field offset: 0x54
	public ProjectileModel projectileExplosionModel; //Field offset: 0x58
	public EffectModel projectileExplosionEffectModel; //Field offset: 0x60
	public int attackState; //Field offset: 0x68
	public string overlay; //Field offset: 0x70
	public SingleEmissionModel singleEmissionModel; //Field offset: 0x78
	private DisplayMutator bloonDisplayMutator; //Field offset: 0x80

	public DisplayMutator BloonDisplayMutator
	{
		 get { } //Length: 129
	}

	public KineticChargeProjectileModel(string name, float deployRadiusMax, float deployTime, float duration, float travelSpeed, int maxAdditionalDamageAmount, int damageTakenMaxAmount, ProjectileModel projectileExplosionModel, EffectModel projectileExplosionEffectModel, int attackState, string overlay) { }

	public void ChangeOverlayId(string overlay) { }

	public virtual Model Clone() { }

	public DisplayMutator get_BloonDisplayMutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

