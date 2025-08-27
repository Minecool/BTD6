namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(SkimBloons), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SkimBloonsModel : TowerBehaviorModel
{
	public float skimAmount; //Field offset: 0x30

	public SkimBloonsModel(string name, float skimAmount) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

