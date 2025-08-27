namespace Antlr.Runtime;

public abstract class BaseRecognizer
{
	public static readonly string NEXT_TOKEN_RULE_NAME; //Field offset: 0x0
	protected private RecognizerSharedState state; //Field offset: 0x10

	public override String[] TokenNames
	{
		 get { } //Length: 3
	}

	private static BaseRecognizer() { }

	public BaseRecognizer(RecognizerSharedState state) { }

	public override void BeginResync() { }

	protected private override BitSet CombineFollows(bool exact) { }

	protected private override BitSet ComputeContextSensitiveRuleFOLLOW() { }

	protected private override BitSet ComputeErrorRecoverySet() { }

	public override void ConsumeUntil(IIntStream input, BitSet set) { }

	public override void DisplayRecognitionError(String[] tokenNames, RecognitionException e) { }

	public override void EmitErrorMessage(string msg) { }

	public override void EndResync() { }

	public override String[] get_TokenNames() { }

	protected override object GetCurrentInputSymbol(IIntStream input) { }

	public override string GetErrorHeader(RecognitionException e) { }

	public override string GetErrorMessage(RecognitionException e, String[] tokenNames) { }

	protected override object GetMissingSymbol(IIntStream input, RecognitionException e, int expectedTokenType, BitSet follow) { }

	public override string GetTokenErrorDisplay(IToken t) { }

	public override object Match(IIntStream input, int ttype, BitSet follow) { }

	public bool MismatchIsMissingToken(IIntStream input, BitSet follow) { }

	public bool MismatchIsUnwantedToken(IIntStream input, int ttype) { }

	protected void PushFollow(BitSet fset) { }

	public override void Recover(IIntStream input, RecognitionException re) { }

	protected private override object RecoverFromMismatchedToken(IIntStream input, int ttype, BitSet follow) { }

	public override void ReportError(RecognitionException e) { }

	public override void Reset() { }

}

