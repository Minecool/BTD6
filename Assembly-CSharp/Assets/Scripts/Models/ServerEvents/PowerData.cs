namespace Assets.Scripts.Models.ServerEvents;

public class PowerData
{
	public string power; //Field offset: 0x10
	public int max; //Field offset: 0x18

	public PowerData() { }

	public PowerData Clone() { }

	public bool Compare(PowerData com) { }

}

