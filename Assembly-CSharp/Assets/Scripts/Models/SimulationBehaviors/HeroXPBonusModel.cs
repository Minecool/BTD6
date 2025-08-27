namespace Assets.Scripts.Models.SimulationBehaviors;

[Implementation(typeof(HeroXPBonus), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class HeroXPBonusModel : SimulationBehaviorModel
{
	public float xpBonus; //Field offset: 0x30

	public HeroXPBonusModel(string name, float xpBonus) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

