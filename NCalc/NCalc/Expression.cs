namespace NCalc;

public class Expression
{
	private static bool _cacheEnabled; //Field offset: 0x0
	private static Dictionary<String, WeakReference> _compiledExpressions; //Field offset: 0x8
	private static readonly ReaderWriterLock Rwl; //Field offset: 0x10
	protected string OriginalExpression; //Field offset: 0x10
	protected Dictionary<String, IEnumerator> ParameterEnumerators; //Field offset: 0x18
	protected Dictionary<String, Object> ParametersBackup; //Field offset: 0x20
	private EvaluateFunctionHandler EvaluateFunction; //Field offset: 0x28
	private EvaluateParameterHandler EvaluateParameter; //Field offset: 0x30
	private Dictionary<String, Object> _parameters; //Field offset: 0x38
	[CompilerGenerated]
	private EvaluateOptions <Options>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private string <Error>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private LogicalExpression <ParsedExpression>k__BackingField; //Field offset: 0x50

	public event EvaluateFunctionHandler EvaluateFunction
	{
		 add { } //Length: 148
		 remove { } //Length: 148
	}

	public event EvaluateParameterHandler EvaluateParameter
	{
		 add { } //Length: 148
		 remove { } //Length: 148
	}

	public private string Error
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public EvaluateOptions Options
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public Dictionary<String, Object> Parameters
	{
		 get { } //Length: 111
		 set { } //Length: 5
	}

	public private LogicalExpression ParsedExpression
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 5
	}

	private static Expression() { }

	public Expression(string expression) { }

	public Expression(string expression, EvaluateOptions options) { }

	public Expression(LogicalExpression expression, EvaluateOptions options) { }

	public void add_EvaluateFunction(EvaluateFunctionHandler value) { }

	public void add_EvaluateParameter(EvaluateParameterHandler value) { }

	private static void CleanCache() { }

	public static LogicalExpression Compile(string expression, bool nocache) { }

	public object Evaluate() { }

	[CompilerGenerated]
	public string get_Error() { }

	[CompilerGenerated]
	public EvaluateOptions get_Options() { }

	public Dictionary<String, Object> get_Parameters() { }

	[CompilerGenerated]
	public LogicalExpression get_ParsedExpression() { }

	public bool HasErrors() { }

	public void remove_EvaluateFunction(EvaluateFunctionHandler value) { }

	public void remove_EvaluateParameter(EvaluateParameterHandler value) { }

	[CompilerGenerated]
	private void set_Error(string value) { }

	[CompilerGenerated]
	public void set_Options(EvaluateOptions value) { }

	public void set_Parameters(Dictionary<String, Object> value) { }

	[CompilerGenerated]
	private void set_ParsedExpression(LogicalExpression value) { }

}

