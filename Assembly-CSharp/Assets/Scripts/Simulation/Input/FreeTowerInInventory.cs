namespace Assets.Scripts.Simulation.Input;

public class FreeTowerInInventory
{
	public string towerBaseId; //Field offset: 0x10
	public int charges; //Field offset: 0x18
	public string mutuallyExclusiveWith; //Field offset: 0x20
	public String[] mutuallyExclusiveWithList; //Field offset: 0x28
	public int priority; //Field offset: 0x30

	public FreeTowerInInventory() { }

}

