namespace Assets.Scripts.Data.Knowledge;

[CreateAssetMenu(menuName = "BTD6/Knowledge Item")]
public class KnowledgeItem : ScriptableObject
{
	[HideInInspector]
	public int idx; //Field offset: 0x18
	public int investmentRequired; //Field offset: 0x1C
	public int monkeyMoneyCost; //Field offset: 0x20
	public String[] prerequisiteKnowledge; //Field offset: 0x28
	[ExtendedDrawer]
	public ModModel mod; //Field offset: 0x30

	public KnowledgeItem() { }

	public KnowledgeModel ToModel(KnowledgeCategory category) { }

}

