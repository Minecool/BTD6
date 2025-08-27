namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(BloodSacrifice), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class BloodSacrificeModel : AbilityBehaviorModel
{
	internal class BloodSacrificeMutator : BehaviorMutator
	{
		private readonly BloodSacrificeModel bloodSacrificeModel; //Field offset: 0x70
		public readonly int bonusCount; //Field offset: 0x78

		public BloodSacrificeMutator(BloodSacrificeModel bloodSacrificeModel, int bonusCount, string sourceTowerModelName) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public float xpMultiplier; //Field offset: 0x30
	public PrefabReference selectionObjectPath; //Field offset: 0x38
	public EffectModel effectAtSacrificeModel; //Field offset: 0x40
	public AudioClipReference activateSound; //Field offset: 0x48
	public AudioClipReference confirmSound; //Field offset: 0x50
	public float rateBonusMultiplier; //Field offset: 0x58
	public float rangeBonusMultiplier; //Field offset: 0x5C
	public float buffDuration; //Field offset: 0x60
	public int buffDurationFrames; //Field offset: 0x64
	public PrefabReference buffDisplayPath; //Field offset: 0x68
	public string buffLocsName; //Field offset: 0x70
	public string buffIconName; //Field offset: 0x78
	private DisplayModel buffDisplayModel; //Field offset: 0x80
	public float bonusMultiplierPerSacrifice; //Field offset: 0x88
	public float bonusSacrificeAmount; //Field offset: 0x8C
	public int maxBonusCount; //Field offset: 0x90
	private readonly Dictionary<Int32, BloodSacrificeMutator> mutators; //Field offset: 0x98

	public BloodSacrificeModel(string name, float xpMultiplier, PrefabReference selectionObjectPath, EffectModel effectAtSacrificeModel, AudioClipReference activateSound, AudioClipReference confirmSound, float rateBonusMultiplier, float rangeBonusMultiplier, float buffDuration, PrefabReference buffDisplayPath, string buffLocsName, string buffIconName, float bonusMultiplierPerSacrifice, float bonusSacrificeAmount, int maxBonusCount) { }

	public virtual Model Clone() { }

	public BuffIndicatorModel GetBuffIndicatorModel() { }

	public BloodSacrificeMutator GetMutator(int bonusCount, string sourceTowerModelName) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

