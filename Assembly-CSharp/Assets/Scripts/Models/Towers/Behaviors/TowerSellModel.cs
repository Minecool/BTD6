namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(TowerSell), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class TowerSellModel : TowerBehaviorModel
{
	public int charges; //Field offset: 0x30
	public float multiplier; //Field offset: 0x34
	public float additional; //Field offset: 0x38

	public TowerSellModel(string name, float multiplier, float additional, int charges) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

