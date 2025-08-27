namespace Assets.Scripts.Unity.Cascade;

public abstract class CascadingExpression : GenericCascadingExpression
{
	public string expression; //Field offset: 0x0
	protected Dictionary<String, Cache`1<GenericCascadingExpression>> sourceVariables; //Field offset: 0x0
	protected Dictionary<String, Cache`1<GenericCascadingExpression>> expansions; //Field offset: 0x0
	private bool isValid; //Field offset: 0x0
	private Optional<T> val; //Field offset: 0x0
	protected string substitutedExpression; //Field offset: 0x0
	[CompilerGenerated]
	private Action onChanged; //Field offset: 0x0

	public event Action onChanged
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public override string Expression
	{
		 get { } //Length: 5
		 set { } //Length: 96
	}

	public override Dictionary<String, Cache`1<GenericCascadingExpression>> SourceVariables
	{
		 get { } //Length: 5
	}

	public override string SubstitutedExpression
	{
		 get { } //Length: 39
	}

	protected CascadingExpression`1() { }

	protected CascadingExpression`1(string expression) { }

	[CompilerGenerated]
	private void <AddExpansion>b__28_0(GenericCascadingExpression x) { }

	[CompilerGenerated]
	private void <AddExpansion>b__28_1(GenericCascadingExpression x) { }

	[CompilerGenerated]
	private void <AddExpansion>b__28_2() { }

	[CompilerGenerated]
	private void <AddSourceVariable>b__27_0(GenericCascadingExpression x) { }

	[CompilerGenerated]
	private void <AddSourceVariable>b__27_1(GenericCascadingExpression x) { }

	[CompilerGenerated]
	private void <AddSourceVariable>b__27_2() { }

	[CompilerGenerated]
	public void add_onChanged(Action value) { }

	public override void AddExpansion(string name, Cache<GenericCascadingExpression> source) { }

	public override void AddOnChange(Action callback) { }

	public override void AddSourceVariable(string name, Cache<GenericCascadingExpression> source) { }

	protected abstract T Calculate() { }

	protected string CalculateString() { }

	protected override string Clean(string dirty) { }

	public override void ClearVariables() { }

	public override void ForceUpdate() { }

	public Optional<T> Get() { }

	public override string get_Expression() { }

	public override Dictionary<String, Cache`1<GenericCascadingExpression>> get_SourceVariables() { }

	public override string get_SubstitutedExpression() { }

	public override Optional<Object> GetObject() { }

	public override Dictionary<String, Cache`1<GenericCascadingExpression>> GetSourceVariables() { }

	public override Optional<String> GetString() { }

	public void OnDependantChanged() { }

	public static T op_Implicit(CascadingExpression<T> cache) { }

	[CompilerGenerated]
	public void remove_onChanged(Action value) { }

	public override void RemoveOnChange(Action callback) { }

	public override void RemoveVariable(string name) { }

	public override void RenameVariable(string old, string nu) { }

	public override void set_Expression(string value) { }

}

