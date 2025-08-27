namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(RotateToDefaultPositionTower), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class RotateToDefaultPositionTowerModel : TowerBehaviorModel
{
	public float rotation; //Field offset: 0x30
	public int onlyOnReachingTier; //Field offset: 0x34

	public RotateToDefaultPositionTowerModel(string name, float rotation, int onlyOnReachingTier) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

