namespace Assets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;

[Implementation(typeof(RotateToDefaultPosition), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class RotateToDefaultPositionModel : AttackBehaviorModel
{
	public float rotation; //Field offset: 0x30

	public RotateToDefaultPositionModel(string name, float rotation) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

