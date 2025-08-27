namespace Assets.Scripts.Models.GeraldoItems;

[Implementation(typeof(PetRabbitBehavior), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class PetRabbitBehaviorModel : GeraldoItemBehaviorModel
{
	public TowerModel petRabbitBaseTowerModel; //Field offset: 0x30

	public PetRabbitBehaviorModel(string name, TowerModel petRabbitBaseTowerModel) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

