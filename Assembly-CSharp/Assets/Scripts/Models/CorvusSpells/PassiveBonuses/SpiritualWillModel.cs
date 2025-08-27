namespace Assets.Scripts.Models.CorvusSpells.PassiveBonuses;

[Implementation(typeof(SpiritualWill), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SpiritualWillModel : TowerBehaviorModel
{
	public int manaPerSecond; //Field offset: 0x30

	public SpiritualWillModel(string name, int manaPerSecond) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

