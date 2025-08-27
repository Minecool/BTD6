namespace Assets.Scripts.Models.SimulationBehaviors;

[Implementation(typeof(HeroXpInjection), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class HeroXpInjectionModel : SimulationBehaviorModel
{
	public float amount; //Field offset: 0x30
	public int levels; //Field offset: 0x34
	public bool subtractHeroCost; //Field offset: 0x38

	public HeroXpInjectionModel(string name, float amount, int levels, bool subtractHeroCost) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

