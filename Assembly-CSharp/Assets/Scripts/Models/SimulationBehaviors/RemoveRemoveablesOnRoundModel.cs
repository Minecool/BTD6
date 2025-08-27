namespace Assets.Scripts.Models.SimulationBehaviors;

[Implementation(typeof(RemoveRemoveablesOnRound), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class RemoveRemoveablesOnRoundModel : SimulationBehaviorModel
{
	public int round; //Field offset: 0x30
	public String[] removeableIds; //Field offset: 0x38
	public bool disableRemoveableEffects; //Field offset: 0x40

	public RemoveRemoveablesOnRoundModel(int round, String[] removeableIds, bool disableRemoveableEffects) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

