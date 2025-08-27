namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(DruidOfWrathBuff), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DruidOfWrathBuffModel : TowerBehaviorModel
{
	public int newPopCount; //Field offset: 0x30

	public DruidOfWrathBuffModel(string name, int newPopCount) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

