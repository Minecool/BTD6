namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(BananaFarmerRegrowBananas), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class BananaFarmerRegrowBananasModel : TowerBehaviorBuffModel
{
	internal class RegrowBananasMutator : BehaviorMutator
	{
		private readonly BananaFarmerRegrowBananasWeaponBehaviorModel weaponBehaviorModel; //Field offset: 0x70

		public RegrowBananasMutator(string mutatorId, BananaFarmerRegrowBananasWeaponBehaviorModel weaponBehaviorModel, int priority, BuffIndicatorModel buffIndicatorUi) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	private const string buffIconId = "BuffIconRegrowBananas"; //Field offset: 0x0
	public const string mutatorId = "RegrowBananasMutator"; //Field offset: 0x0
	public ProjectileModel regrowBananaSkinModel; //Field offset: 0x48
	public int regrowPerBanana; //Field offset: 0x50
	public PrefabReference selectionObjectPath; //Field offset: 0x58
	public PrefabReference isSelectableGameObject; //Field offset: 0x60
	public SoundModel activateSound; //Field offset: 0x68
	public SoundModel confirmSound; //Field offset: 0x70
	public PrefabReference lineDisplayPath; //Field offset: 0x78
	public float lineDotOffset; //Field offset: 0x80
	public float lineDotSpacing; //Field offset: 0x84
	public bool isBananaIntelligenceBureau; //Field offset: 0x88
	public BananaFarmerRegrowBananasWeaponBehaviorModel weaponBehaviorWeakModel; //Field offset: 0x90
	public BananaFarmerRegrowBananasWeaponBehaviorModel weaponBehaviorStrongModel; //Field offset: 0x98
	public CreateProjectileOnPickupModel createProjectileOnPickupModel; //Field offset: 0xA0
	public CreateProjectileOnExpireModel createProjectileOnExpireModel; //Field offset: 0xA8
	private RegrowBananasMutator mutatorWeak; //Field offset: 0xB0
	private RegrowBananasMutator mutatorStrong; //Field offset: 0xB8
	private BuffIndicatorModel buffIndicatorModel; //Field offset: 0xC0

	public RegrowBananasMutator GetCurrentTargetMutator
	{
		 get { } //Length: 318
	}

	public RegrowBananasMutator MutatorStrong
	{
		 get { } //Length: 174
	}

	public RegrowBananasMutator MutatorWeak
	{
		 get { } //Length: 174
	}

	public BananaFarmerRegrowBananasModel(string name, ProjectileModel regrowBananaSkinModel, int regrowPerBanana, PrefabReference selectionObjectPath, PrefabReference isSelectableGameObject, SoundModel activateSound, SoundModel confirmSound, PrefabReference lineDisplayPath, float lineDotOffset, float lineDotSpacing, bool isBananaIntelligenceBureau) { }

	public virtual Model Clone() { }

	public RegrowBananasMutator get_GetCurrentTargetMutator() { }

	public RegrowBananasMutator get_MutatorStrong() { }

	public RegrowBananasMutator get_MutatorWeak() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

