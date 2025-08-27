namespace Assets.Scripts.Models.Map;

public class SplitterModel : Model
{
	public String[] paths; //Field offset: 0x30
	public string overriddenBossPath; //Field offset: 0x38

	public SplitterModel(string name, String[] paths, string overriddenBossPath) { }

	public virtual Model Clone() { }

	public override Splitter GetSplitter() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

