namespace Assets.Scripts.Unity.Bridge;

public class BloonToSimulation
{
	public ObjectId id; //Field offset: 0x10
	public Vector3 position; //Field offset: 0x14
	private UnityToSimulation sim; //Field offset: 0x20
	[CompilerGenerated]
	private BloonModel <Def>k__BackingField; //Field offset: 0x28

	public private BloonModel Def
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public BloonToSimulation(UnityToSimulation sim, ObjectId id, Vector3 position, BloonModel def) { }

	[CompilerGenerated]
	public BloonModel get_Def() { }

	public int GetArmourAmount() { }

	public BloonModel GetBaseModel() { }

	public int GetHealth() { }

	public Bloon GetSimBloon() { }

	[CompilerGenerated]
	private void set_Def(BloonModel value) { }

}

