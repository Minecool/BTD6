namespace Assets.Scripts.Unity;

[CreateAssetMenu(menuName = "BTD6/Benchmark Scenario")]
public class BenchmarkScenario : ScriptableObject
{
	internal class TowerInfo
	{
		public string name; //Field offset: 0x10
		public Vector2 pos; //Field offset: 0x18

		public TowerInfo() { }

	}

	public string map; //Field offset: 0x18
	public string difficulty; //Field offset: 0x20
	public bool isImmune; //Field offset: 0x28
	public double startingCash; //Field offset: 0x30
	public int startingRound; //Field offset: 0x38
	public TowerInfo[] towers; //Field offset: 0x40

	public BenchmarkScenario() { }

}

