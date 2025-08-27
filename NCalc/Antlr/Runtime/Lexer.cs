namespace Antlr.Runtime;

public abstract class Lexer : BaseRecognizer, ITokenSource
{
	protected private ICharStream input; //Field offset: 0x18

	public override int CharIndex
	{
		 get { } //Length: 73
	}

	public Lexer(ICharStream input, RecognizerSharedState state) { }

	public override void Emit(IToken token) { }

	public override IToken Emit() { }

	public override int get_CharIndex() { }

	public string GetCharErrorDisplay(int c) { }

	public virtual string GetErrorMessage(RecognitionException e, String[] tokenNames) { }

	public override void Match(string s) { }

	public override void Match(int c) { }

	public override void MatchRange(int a, int b) { }

	public abstract void mTokens() { }

	public override IToken NextToken() { }

	public override void Recover(RecognitionException re) { }

	public virtual void ReportError(RecognitionException e) { }

	public virtual void Reset() { }

}

