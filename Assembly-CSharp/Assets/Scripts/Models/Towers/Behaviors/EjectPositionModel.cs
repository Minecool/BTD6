namespace Assets.Scripts.Models.Towers.Behaviors;

public class EjectPositionModel : TowerBehaviorModel
{
	public float x; //Field offset: 0x30
	public float y; //Field offset: 0x34
	public float z; //Field offset: 0x38

	public EjectPositionModel(float x, float y, float z) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

