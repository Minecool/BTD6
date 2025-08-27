namespace Assets.Scripts.Models.SimulationBehaviors;

[Implementation(typeof(RemovePropsOnRound), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class RemovePropsOnRoundModel : SimulationBehaviorModel
{
	public int round; //Field offset: 0x30
	public String[] propIndexs; //Field offset: 0x38
	public bool disableRemoveableEffects; //Field offset: 0x40

	public RemovePropsOnRoundModel(int round, String[] propIndexs, bool disableRemoveableEffects) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

