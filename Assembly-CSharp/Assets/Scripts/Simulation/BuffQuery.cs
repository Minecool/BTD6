namespace Assets.Scripts.Simulation;

public struct BuffQuery
{
	public BuffIndicatorModel buffIndicator; //Field offset: 0x0
	public TimedMutator timedMutator; //Field offset: 0x8
	public Tower tower; //Field offset: 0x10
	public bool canEventuallyBuff; //Field offset: 0x18
	public bool canCurrentlyBuff; //Field offset: 0x19
	public int availableBuffCount; //Field offset: 0x1C
	public int unavailableBuffCount; //Field offset: 0x20
	public bool countBuffTowardsAchievement; //Field offset: 0x24

}

