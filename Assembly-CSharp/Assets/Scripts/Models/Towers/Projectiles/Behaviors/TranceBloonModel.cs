namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(TranceBloon), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class TranceBloonModel : ProjectileBehaviorModel
{
	public const string mutatorID = "Trance"; //Field offset: 0x0
	public float speedMultiplier; //Field offset: 0x38
	public float moabOrbitSpeed; //Field offset: 0x3C
	public float duration; //Field offset: 0x40
	public float orbitRadius; //Field offset: 0x44
	public float radiusBloonSizeMultiplier; //Field offset: 0x48
	public float cooldown; //Field offset: 0x4C
	public DamageModel fakeDamage; //Field offset: 0x50
	public int maxDotDamage; //Field offset: 0x58
	private OrbitBloonProjectileMutator mutator; //Field offset: 0x60

	public OrbitBloonProjectileMutator Mutator
	{
		 get { } //Length: 437
	}

	public TranceBloonModel(string name, float speedMultiplier, float duration, float orbitRadius, float radiusBloonSizeMultiplier, float cooldown, DamageModel fakeDamage, float moabOrbitSpeed, int maxDotDamage) { }

	public virtual Model Clone() { }

	public OrbitBloonProjectileMutator get_Mutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

