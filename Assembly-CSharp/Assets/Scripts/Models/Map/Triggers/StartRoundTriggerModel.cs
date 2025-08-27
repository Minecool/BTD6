namespace Assets.Scripts.Models.Map.Triggers;

[Implementation(typeof(StartRoundTrigger), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class StartRoundTriggerModel : MapTriggerModel
{
	public int round; //Field offset: 0x38
	public int everyNthRound; //Field offset: 0x3C
	public bool usePrimeNumbers; //Field offset: 0x40
	public bool countFromStartRound; //Field offset: 0x41

	public StartRoundTriggerModel(string name, int round, int everyNthRound, bool usePrimeNumbers, bool countFromStartRound) { }

}

