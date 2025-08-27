namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(TransformTowerXp), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class TransformTowerXpModel : TowerBehaviorModel
{
	public float multiplier; //Field offset: 0x30

	public TransformTowerXpModel(string name, float multiplier) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

