namespace Assets.Scripts.Unity.Powers;

public abstract class PowerDetails : Behavior
{
	public PowerDetails parent; //Field offset: 0x80
	public int powerCount; //Field offset: 0x88
	public string expPowerCount; //Field offset: 0x90

	protected PowerDetails() { }

}

