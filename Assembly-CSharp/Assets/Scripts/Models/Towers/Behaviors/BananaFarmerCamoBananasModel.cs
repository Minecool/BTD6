namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(BananaFarmerCamoBananas), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class BananaFarmerCamoBananasModel : TowerBehaviorModel
{
	internal class CamoBananaMutator : BehaviorMutator
	{
		private readonly WeaponModel weaponModel; //Field offset: 0x70

		public CamoBananaMutator(WeaponModel weaponModel, BuffIndicatorModel buffIndicatorModel) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public const string mutatorId = "CamoBananaMutator"; //Field offset: 0x0
	private const string buffIconId = "BuffIconCamoBananas"; //Field offset: 0x0
	public WeaponModel camoBananaWeaponModel; //Field offset: 0x30
	public int camoBananaFarmCount; //Field offset: 0x38
	private CamoBananaMutator mutator; //Field offset: 0x40
	private BuffIndicatorModel buffIndicatorModel; //Field offset: 0x48

	public CamoBananaMutator Mutator
	{
		 get { } //Length: 249
	}

	public BananaFarmerCamoBananasModel(string name, WeaponModel camoBananaWeaponModel, int camoBananaFarmCount) { }

	public virtual Model Clone() { }

	public CamoBananaMutator get_Mutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

