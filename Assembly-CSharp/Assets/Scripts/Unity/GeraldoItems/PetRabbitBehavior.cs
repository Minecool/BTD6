namespace Assets.Scripts.Unity.GeraldoItems;

public class PetRabbitBehavior : GeraldoItemBehavior
{
	[SerializeField]
	private SyncedPet pet; //Field offset: 0x18
	[SerializeField]
	private string wererabbitTowerId; //Field offset: 0x20
	[SerializeField]
	private int mergeAmountRequired; //Field offset: 0x28
	[SerializeField]
	private PrefabReference effectDuringMerge; //Field offset: 0x30

	public virtual GeraldoItemBehaviorModel Def
	{
		 get { } //Length: 1751
	}

	public PetRabbitBehavior() { }

	public virtual GeraldoItemBehaviorModel get_Def() { }

}

