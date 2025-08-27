namespace NCalc.Domain;

public class UnaryExpression : LogicalExpression
{
	[CompilerGenerated]
	private LogicalExpression <Expression>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private UnaryExpressionType <Type>k__BackingField; //Field offset: 0x18

	public LogicalExpression Expression
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public UnaryExpressionType Type
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public UnaryExpression(UnaryExpressionType type, LogicalExpression expression) { }

	public virtual void Accept(LogicalExpressionVisitor visitor) { }

	[CompilerGenerated]
	public LogicalExpression get_Expression() { }

	[CompilerGenerated]
	public UnaryExpressionType get_Type() { }

	[CompilerGenerated]
	public void set_Expression(LogicalExpression value) { }

	[CompilerGenerated]
	public void set_Type(UnaryExpressionType value) { }

}

