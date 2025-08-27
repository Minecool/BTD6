namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(SellTrigger), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SellTriggerModel : BloonBehaviorTriggerModel
{
	public String[] actionIds; //Field offset: 0x30

	public SellTriggerModel(string name, String[] actionIds) { }

	public SellTriggerModel(string name) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

