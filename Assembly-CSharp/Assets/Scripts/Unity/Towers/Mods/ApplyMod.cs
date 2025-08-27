namespace Assets.Scripts.Unity.Towers.Mods;

public class ApplyMod : CascadingItem
{
	public KnowledgeItem mod; //Field offset: 0x80
	public CascadingItem target; //Field offset: 0x88
	public string targetNames; //Field offset: 0x90
	private ApplyModModel def; //Field offset: 0x98

	public ApplyModModel Def
	{
		 get { } //Length: 472
	}

	public virtual Model Model
	{
		 get { } //Length: 7
	}

	public ApplyMod() { }

	public ApplyModModel get_Def() { }

	public virtual Model get_Model() { }

}

