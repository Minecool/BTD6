namespace Assets.Scripts.Data.Knowledge;

[CreateAssetMenu(menuName = "BTD6/RelicKnowledgeData")]
public class RelicKnowledgeData : ScriptableObject
{
	[SerializeReference]
	private RelicKnowledgeItemBase[] items; //Field offset: 0x18

	public IEnumerable<RelicKnowledgeItemBase> All
	{
		 get { } //Length: 5
	}

	public RelicKnowledgeData() { }

	public IEnumerable<RelicKnowledgeItemBase> get_All() { }

	public RelicKnowledgeItemBase GetKnowledgeByName(string name) { }

	public RelicKnowledgeItemBase GetKnowledgeByType(ContestedTerritoryRelicType relicType) { }

}

