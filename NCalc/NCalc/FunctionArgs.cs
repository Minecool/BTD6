namespace NCalc;

public class FunctionArgs : EventArgs
{
	private object _result; //Field offset: 0x10
	private Expression[] _parameters; //Field offset: 0x18
	[CompilerGenerated]
	private bool <HasResult>k__BackingField; //Field offset: 0x20

	public bool HasResult
	{
		[CompilerGenerated]
		 get { } //Length: 7
	}

	public Expression[] Parameters
	{
		 get { } //Length: 7
		 set { } //Length: 5
	}

	public object Result
	{
		 get { } //Length: 7
	}

	public FunctionArgs() { }

	[CompilerGenerated]
	public bool get_HasResult() { }

	public Expression[] get_Parameters() { }

	public object get_Result() { }

	public void set_Parameters(Expression[] value) { }

}

