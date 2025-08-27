namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(PathMovementFromScreenCenter), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class PathMovementFromScreenCenterModel : TowerBehaviorModel
{
	[SerializeField]
	private float speed; //Field offset: 0x30
	public float speedFrames; //Field offset: 0x34
	public bool ignoreTargetType; //Field offset: 0x38

	public PathMovementFromScreenCenterModel(string name, float speed, bool ignoreTargetType) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

