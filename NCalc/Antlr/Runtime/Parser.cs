namespace Antlr.Runtime;

public class Parser : BaseRecognizer
{
	protected private ITokenStream input; //Field offset: 0x18

	public override ITokenStream TokenStream
	{
		 set { } //Length: 55
	}

	public Parser(ITokenStream input, RecognizerSharedState state) { }

	protected virtual object GetCurrentInputSymbol(IIntStream input) { }

	protected virtual object GetMissingSymbol(IIntStream input, RecognitionException e, int expectedTokenType, BitSet follow) { }

	public virtual void Reset() { }

	public override void set_TokenStream(ITokenStream value) { }

}

