namespace Assets.Scripts.Data.Behaviors.Towers.GeraldoItems;

[CreateAssetMenu(fileName = "PetRabbitBehavior", menuName = "BTD6/Behaviors/Towers/GeraldoItems/PetRabbitBehavior")]
public class PetRabbitBehavior : GeraldoItemBehavior
{
	public SyncedPet pet; //Field offset: 0x28
	public string wererabbitTowerId; //Field offset: 0x30
	public int mergeAmountRequired; //Field offset: 0x38
	public PrefabReference effectDuringMerge; //Field offset: 0x40

	public virtual GeraldoItemBehaviorModel Def
	{
		 get { } //Length: 1751
	}

	public PetRabbitBehavior() { }

	public virtual GeraldoItemBehaviorModel get_Def() { }

}

