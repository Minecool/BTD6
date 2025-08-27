namespace NCalc;

public class ParameterArgs : EventArgs
{
	private object _result; //Field offset: 0x10
	[CompilerGenerated]
	private bool <HasResult>k__BackingField; //Field offset: 0x18

	public bool HasResult
	{
		[CompilerGenerated]
		 get { } //Length: 7
	}

	public object Result
	{
		 get { } //Length: 7
	}

	public ParameterArgs() { }

	[CompilerGenerated]
	public bool get_HasResult() { }

	public object get_Result() { }

}

