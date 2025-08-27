namespace Assets.Scripts.Models.Towers.Behaviors.Emissions;

[Implementation(typeof(NecromancerEmission), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class NecromancerEmissionModel : EmissionModel
{
	internal class DamageMutator : BehaviorMutator
	{
		private int additionalDamage; //Field offset: 0x70

		public DamageMutator(int additionalDamage) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	internal class PierceMutator : BehaviorMutator
	{
		public readonly int pierce; //Field offset: 0x70

		public PierceMutator(int pierce) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public int minBloonsSpawnedPerWave; //Field offset: 0x38
	public int maxBloonsSpawnedPerWave; //Field offset: 0x3C
	public int maxRbeSpawnedPerSecond; //Field offset: 0x40
	public int maxPathRandomRange; //Field offset: 0x44
	public int maxPiercePerBloon; //Field offset: 0x48
	public int maxPathOffset; //Field offset: 0x4C
	public int maxRbeStored; //Field offset: 0x50
	public int rateStackMax; //Field offset: 0x54
	public int rateRbePerStack; //Field offset: 0x58
	public int damageStackMax; //Field offset: 0x5C
	public int damageRbePerStack; //Field offset: 0x60
	public int roundsBeforeDecay; //Field offset: 0x64
	public Dictionary<Int32, PierceMutator> pierceMutators; //Field offset: 0x68
	public Dictionary<Int32, DamageMutator> damageMutators; //Field offset: 0x70

	public NecromancerEmissionModel(string name, int maxRbeStored, int maxRbeSpawnedPerSecond, int minBloonsSpawnedPerWave, int maxBloonsSpawnedPerWave, int maxPiercePerBloon, int maxPathRandomRange, int maxPathOffset, EmissionBehaviorModel[] behaviors, Dictionary<Int32, PierceMutator> pierceMutators, Dictionary<Int32, DamageMutator> damageMutators, int rateStackMax, int rateRbePerStack, int damageStackMax, int damageRbePerStack, int roundsBeforeDecay) { }

	public virtual Model Clone() { }

	public DamageMutator GetDamageMutator(int damage) { }

	public PierceMutator GetPierceMutator(int pierce) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

