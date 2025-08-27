namespace NCalc.Domain;

public abstract class LogicalExpression
{

	protected LogicalExpression() { }

	public override void Accept(LogicalExpressionVisitor visitor) { }

	public virtual string ToString() { }

}

