namespace Assets.Scripts.Data.Gameplay;

public class FreeplayGroupDataItem
{
	public string name; //Field offset: 0x10
	[BloonType]
	public string bloon; //Field offset: 0x18
	public int count; //Field offset: 0x20
	public float score; //Field offset: 0x24
	public Bounds[] validRounds; //Field offset: 0x28
	public float end; //Field offset: 0x30

	public FreeplayGroupDataItem() { }

	public FreeplayBloonGroupModel ToModel() { }

}

