namespace Assets.Scripts.Unity.Map.Triggers;

public class StartRoundTrigger : MapTrigger
{
	public int round; //Field offset: 0x20
	public int everyNthRound; //Field offset: 0x24
	public bool usePrimeNumbers; //Field offset: 0x28
	public bool countFromStartRound; //Field offset: 0x29
	private StartRoundTriggerModel def; //Field offset: 0x30

	public virtual MapTriggerModel Def
	{
		 get { } //Length: 230
	}

	public StartRoundTrigger() { }

	public virtual MapTriggerModel get_Def() { }

}

