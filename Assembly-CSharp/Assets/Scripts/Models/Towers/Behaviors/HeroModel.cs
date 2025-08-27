namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(Hero), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class HeroModel : TowerBehaviorModel
{
	public float xpScale; //Field offset: 0x30
	public float costPerXpToLevel; //Field offset: 0x34

	public HeroModel(string name, float xpScale, float costPerXpToLevel) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

