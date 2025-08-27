namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(TargetSupplierSupport), True, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class TargetSupplierSupportModel : SupportModel
{
	internal class MutatorTower : BehaviorMutator
	{
		private readonly TargetSupplierSupportModel supportModel; //Field offset: 0x70

		public MutatorTower(TargetSupplierSupportModel TargetSupplierSupportModel) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public string mutatorId; //Field offset: 0x60
	public TargetSupplierModel targetSupplier; //Field offset: 0x68
	private MutatorTower mutator; //Field offset: 0x70

	public MutatorTower Mutator
	{
		 get { } //Length: 213
	}

	public TargetSupplierSupportModel(string name, string mutatorId, TargetSupplierModel targetSupplier, TowerFilterModel[] filters, MutatorTower mutatorParam) { }

	public virtual Model Clone() { }

	public MutatorTower get_Mutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

