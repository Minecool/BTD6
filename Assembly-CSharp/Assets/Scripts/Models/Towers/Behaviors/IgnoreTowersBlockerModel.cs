namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(IgnoreTowersBlocker), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class IgnoreTowersBlockerModel : TowerBehaviorModel
{
	public String[] filteredTowers; //Field offset: 0x30

	public IgnoreTowersBlockerModel(string name, String[] filteredTowers) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

