namespace NCalc.Domain;

public class Identifier : LogicalExpression
{
	[CompilerGenerated]
	private string <Name>k__BackingField; //Field offset: 0x10

	public string Name
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public Identifier(string name) { }

	public virtual void Accept(LogicalExpressionVisitor visitor) { }

	[CompilerGenerated]
	public string get_Name() { }

	[CompilerGenerated]
	public void set_Name(string value) { }

}

