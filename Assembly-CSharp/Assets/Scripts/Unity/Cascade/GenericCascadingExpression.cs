namespace Assets.Scripts.Unity.Cascade;

public interface GenericCascadingExpression
{

	public string Expression
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public Dictionary<String, Cache`1<GenericCascadingExpression>> SourceVariables
	{
		 get { } //Length: 0
	}

	public string SubstitutedExpression
	{
		 get { } //Length: 0
	}

	public void AddExpansion(string name, Cache<GenericCascadingExpression> source) { }

	public void AddOnChange(Action callback) { }

	public void AddSourceVariable(string name, Cache<GenericCascadingExpression> source) { }

	public void ClearVariables() { }

	public void ForceUpdate() { }

	public string get_Expression() { }

	public Dictionary<String, Cache`1<GenericCascadingExpression>> get_SourceVariables() { }

	public string get_SubstitutedExpression() { }

	public Optional<Object> GetObject() { }

	public Dictionary<String, Cache`1<GenericCascadingExpression>> GetSourceVariables() { }

	public Optional<String> GetString() { }

	public void RemoveOnChange(Action callback) { }

	public void RemoveVariable(string name) { }

	public void RenameVariable(string old, string nu) { }

	public void set_Expression(string value) { }

}

