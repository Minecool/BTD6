namespace Assets.Scripts.Models.Knowledge;

public class KnowledgeModel : Model
{
	public int idx; //Field offset: 0x30
	public KnowledgeCategory category; //Field offset: 0x34
	public int investmentRequired; //Field offset: 0x38
	public int monkeyMoneyCost; //Field offset: 0x3C
	public String[] prerequisiteIds; //Field offset: 0x40
	public ModModel mod; //Field offset: 0x48

	public KnowledgeModel(string name, int idx, KnowledgeCategory category, int investmentRequired, int monkeyMoneyCost, String[] prerequisiteIds, ModModel mod) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

