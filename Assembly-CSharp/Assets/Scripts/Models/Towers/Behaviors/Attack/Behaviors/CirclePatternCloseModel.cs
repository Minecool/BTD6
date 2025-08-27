namespace Assets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;

[Implementation(typeof(CirclePatternClose), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CirclePatternCloseModel : CirclePatternModel
{

	public CirclePatternCloseModel(string name, float radius, bool isSelectable, bool reverse, PrefabReference display, int displayCount, bool isOnSubTower) { }

	public virtual Model Clone() { }

	public virtual string GetName() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

