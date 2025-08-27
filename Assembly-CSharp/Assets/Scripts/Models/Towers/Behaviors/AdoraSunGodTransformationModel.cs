namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(AdoraSunGodTransformation), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AdoraSunGodTransformationModel : TowerBehaviorModel
{
	internal class DarkMutator : BehaviorMutator
	{
		private readonly AdoraSunGodTransformationModel adoraSunGodTransformationModel; //Field offset: 0x70

		public DarkMutator(AdoraSunGodTransformationModel adoraSunGodTransformationModel, string mutatorId, int priority) { }

		private void ChangeSounds(AdoraTransformSoundModel adoraTransformSoundModel, TowerModel towerModel) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	internal class Mutator : BehaviorMutator
	{
		private readonly AdoraSunGodTransformationModel adoraSunGodTransformationModel; //Field offset: 0x70

		public Mutator(AdoraSunGodTransformationModel adoraSunGodTransformationModel, string mutatorId, int priority) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public AssetPathModel newDisplayPath; //Field offset: 0x30
	public int damageBonus; //Field offset: 0x38
	public int pierceBonus; //Field offset: 0x3C
	public int ballOfLightDamageBonus; //Field offset: 0x40
	public int ballOfLightPierceBonus; //Field offset: 0x44
	public int upgradeAnimation; //Field offset: 0x48
	[SerializeField]
	private float weaponDelay; //Field offset: 0x4C
	public int weaponDelayFrames; //Field offset: 0x50
	public EffectModel effectModel; //Field offset: 0x58
	public SpriteReference portraitRef; //Field offset: 0x60
	public AssetPathModel newDisplayDarkPath; //Field offset: 0x68
	public AssetPathModel projectileDisplayDarkPath; //Field offset: 0x70
	public AssetPathModel bolDisplayDarkPath; //Field offset: 0x78
	public AssetPathModel bolProjectileDisplayDarkPath; //Field offset: 0x80
	public AssetPathModel laolProjectileDisplayDarkPath; //Field offset: 0x88
	public EffectModel effectDarkModel; //Field offset: 0x90
	public SpriteReference portraitDarkRef; //Field offset: 0x98
	public AssetPathModel beamHitDisplayDarkPath; //Field offset: 0xA0
	public int upgradeAnimationDarkPath; //Field offset: 0xA8
	public LongArmOfLightModel longArmOfLightBehaviorModel; //Field offset: 0xB0
	public TowerModel ballOfLightModel; //Field offset: 0xB8
	public AdoraTransformSoundModel adoraTransformSoundModel; //Field offset: 0xC0
	private Mutator _regularMutator; //Field offset: 0xC8
	private DarkMutator _darkMutator; //Field offset: 0xD0

	public DarkMutator darkMutator
	{
		 get { } //Length: 231
	}

	public Mutator regularMutator
	{
		 get { } //Length: 230
	}

	public AdoraSunGodTransformationModel(string name, AssetPathModel newDisplayPath, int damageBonus, int pierceBonus, int ballOfLightDamageBonus, int ballOfLightPierceBonus, int upgradeAnimation, float weaponDelay, EffectModel effectModel, SpriteReference portraitRef, AssetPathModel newDisplayDarkPath, AssetPathModel projectileDisplayDarkPath, AssetPathModel bolDisplayDarkPath, AssetPathModel bolProjectileDisplayDarkPath, AssetPathModel laolProjectileDisplayDarkPath, EffectModel effectDarkModel, SpriteReference portraitDarkRef, AssetPathModel beamHitDisplayDarkPath, int upgradeAnimationDarkPath, LongArmOfLightModel longArmOfLightBehaviorModel, TowerModel ballOfLightModel, AdoraTransformSoundModel adoraTransformSoundModel) { }

	public virtual Model Clone() { }

	public DarkMutator get_darkMutator() { }

	public Mutator get_regularMutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

