namespace Assets.Scripts.Data.Knowledge.Effects;

public class TargetBloonsContainer
{
	public const string AllBloons = "All Bloons"; //Field offset: 0x0
	public const string AllRegularBloons = "All Regular (non-MOAB) Bloons"; //Field offset: 0x0
	public const string AllMoabs = "All MOABs"; //Field offset: 0x0
	public String[] targetBloonNames; //Field offset: 0x10

	public TargetBloonsContainer() { }

}

