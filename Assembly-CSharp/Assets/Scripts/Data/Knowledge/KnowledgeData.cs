namespace Assets.Scripts.Data.Knowledge;

[CreateAssetMenu(menuName = "BTD6/Knowledge Data")]
public class KnowledgeData : ScriptableObject
{
	public KnowledgeItem[] primaryKnowledge; //Field offset: 0x18
	public KnowledgeItem[] militaryKnowledge; //Field offset: 0x20
	public KnowledgeItem[] magicKnowledge; //Field offset: 0x28
	public KnowledgeItem[] supportKnowledge; //Field offset: 0x30
	public KnowledgeItem[] heroesKnowledge; //Field offset: 0x38
	public KnowledgeItem[] powersKnowledge; //Field offset: 0x40

	public KnowledgeData() { }

}

