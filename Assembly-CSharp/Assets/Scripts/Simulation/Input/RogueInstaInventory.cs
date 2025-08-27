namespace Assets.Scripts.Simulation.Input;

public class RogueInstaInventory
{
	private const string tagInsta = "RogueInsta"; //Field offset: 0x0
	private const string tagBoost = "RogueQueuedBoost"; //Field offset: 0x0
	public List<RogueInstaMonkey> instas; //Field offset: 0x10
	public List<RogueLootData> queuedBoosts; //Field offset: 0x18

	public RogueInstaInventory() { }

	public void AddInstaTower(RogueInstaMonkey toAdd) { }

	public void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public void Init(List<RogueInstaMonkey> instas) { }

	public void OnRoundEnd() { }

	public void RemoveInstaTower(RogueInstaMonkey toRemove) { }

	public void SetSaveMetaData(Dictionary<String, String> metaData) { }

}

