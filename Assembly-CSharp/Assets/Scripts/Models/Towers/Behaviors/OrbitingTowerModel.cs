namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(OrbitingTower), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class OrbitingTowerModel : TowerBehaviorModel
{
	public float rotationDegreesPerFrame; //Field offset: 0x30
	public float radius; //Field offset: 0x34
	public bool ignoreRotation; //Field offset: 0x38
	public Vector2 offset; //Field offset: 0x3C
	public bool dontUseParentOrigin; //Field offset: 0x44

	public OrbitingTowerModel(string name, float rotationDegreesPerFrame, float radius, bool ignoreRotation, Vector2 offset, bool dontUseParentOrigin) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

