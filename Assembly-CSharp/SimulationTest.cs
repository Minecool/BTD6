//Type is in global namespace

[CreateAssetMenu(menuName = "BTD6/Simulation Test")]
public class SimulationTest : ScriptableObject, ISerializationCallbackReceiver
{
	internal enum Category
	{
		Short = 0,
		Medium = 1,
		Long = 2,
		Map = 3,
		SunGod = 4,
		Critical = 5,
	}

	[EnumAsString(typeof(Category))]
	public string category; //Field offset: 0x18
	[MapName]
	public string map; //Field offset: 0x20
	public RoundSet roundSet; //Field offset: 0x28
	[HideInInspector]
	[SerializeField]
	private string roundSetName; //Field offset: 0x30
	[Difficulty]
	public string difficulty; //Field offset: 0x38
	[Mode]
	public string mode; //Field offset: 0x40
	public int randomSeed; //Field offset: 0x48
	[ActiveKnowledge]
	public ActiveKnowledge knowledge; //Field offset: 0x50
	[ActiveRelicKnowledge]
	public ActiveRelicKnowledge relicKnowledge; //Field offset: 0x58
	[SerializeReference]
	public ISimulationTestStep[] steps; //Field offset: 0x60
	[SerializeReference]
	public ISimulationTestOutcome[] outcomes; //Field offset: 0x68

	public SimulationTest() { }

	public override void OnAfterDeserialize() { }

	public override void OnBeforeSerialize() { }

}

