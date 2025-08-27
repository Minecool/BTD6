namespace NCalc.Domain;

public class TernaryExpression : LogicalExpression
{
	[CompilerGenerated]
	private LogicalExpression <LeftExpression>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private LogicalExpression <MiddleExpression>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private LogicalExpression <RightExpression>k__BackingField; //Field offset: 0x20

	public LogicalExpression LeftExpression
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public LogicalExpression MiddleExpression
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public LogicalExpression RightExpression
	{
		[CompilerGenerated]
		 get { } //Length: 159
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public TernaryExpression(LogicalExpression leftExpression, LogicalExpression middleExpression, LogicalExpression rightExpression) { }

	public virtual void Accept(LogicalExpressionVisitor visitor) { }

	[CompilerGenerated]
	public LogicalExpression get_LeftExpression() { }

	[CompilerGenerated]
	public LogicalExpression get_MiddleExpression() { }

	[CompilerGenerated]
	public LogicalExpression get_RightExpression() { }

	[CompilerGenerated]
	public void set_LeftExpression(LogicalExpression value) { }

	[CompilerGenerated]
	public void set_MiddleExpression(LogicalExpression value) { }

	[CompilerGenerated]
	public void set_RightExpression(LogicalExpression value) { }

}

