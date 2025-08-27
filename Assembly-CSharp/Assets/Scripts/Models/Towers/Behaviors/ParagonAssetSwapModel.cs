namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(ParagonAssetSwap), True, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ParagonAssetSwapModel : TowerBehaviorModel
{
	public PrefabReference displayToSwap; //Field offset: 0x30
	public PrefabReference newDisplay; //Field offset: 0x38
	public int displayDegree; //Field offset: 0x40
	public bool applyToAllAbove; //Field offset: 0x44

	public ParagonAssetSwapModel(string name, PrefabReference displayToSwap, PrefabReference newDisplay, int displayDegree, bool applyToAllAbove) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

