namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(SelfStackingSupportCompounding), True, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SelfStackingSupportModel : TowerBehaviorModel
{
	public int maxStacks; //Field offset: 0x30
	public string mutatorId; //Field offset: 0x38

	public SelfStackingSupportModel(string name, string mutatorId, int maxStacks) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

