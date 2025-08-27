//Type is in global namespace

public class NCalcLexer : Lexer
{
	internal class DFA14 : DFA
	{

		public virtual string Description
		{
			 get { } //Length: 44
		}

		public DFA14(BaseRecognizer recognizer) { }

		public virtual string get_Description() { }

	}

	internal class DFA7 : DFA
	{

		public virtual string Description
		{
			 get { } //Length: 44
		}

		public DFA7(BaseRecognizer recognizer) { }

		public virtual string get_Description() { }

	}

	private static readonly String[] DFA7_transitionS; //Field offset: 0x0
	private static readonly Int16[] DFA7_eot; //Field offset: 0x8
	private static readonly Int16[] DFA7_eof; //Field offset: 0x10
	private static readonly Char[] DFA7_min; //Field offset: 0x18
	private static readonly Char[] DFA7_max; //Field offset: 0x20
	private static readonly Int16[] DFA7_accept; //Field offset: 0x28
	private static readonly Int16[] DFA7_special; //Field offset: 0x30
	private static readonly Int16[][] DFA7_transition; //Field offset: 0x38
	private static readonly String[] DFA14_transitionS; //Field offset: 0x40
	private static readonly Int16[] DFA14_eot; //Field offset: 0x48
	private static readonly Int16[] DFA14_eof; //Field offset: 0x50
	private static readonly Char[] DFA14_min; //Field offset: 0x58
	private static readonly Char[] DFA14_max; //Field offset: 0x60
	private static readonly Int16[] DFA14_accept; //Field offset: 0x68
	private static readonly Int16[] DFA14_special; //Field offset: 0x70
	private static readonly Int16[][] DFA14_transition; //Field offset: 0x78
	protected DFA7 dfa7; //Field offset: 0x20
	protected DFA14 dfa14; //Field offset: 0x28

	private static NCalcLexer() { }

	public NCalcLexer(ICharStream input) { }

	public NCalcLexer(ICharStream input, RecognizerSharedState state) { }

	private void InitializeCyclicDFAs() { }

	public void mDATETIME() { }

	public void mDIGIT() { }

	public void mE() { }

	public void mEscapeSequence() { }

	public void mFALSE() { }

	public void mFLOAT() { }

	public void mHexDigit() { }

	public void mID() { }

	public void mINTEGER() { }

	public void mLETTER() { }

	public void mNAME() { }

	public void mSTRING() { }

	public void mT__19() { }

	public void mT__20() { }

	public void mT__21() { }

	public void mT__22() { }

	public void mT__23() { }

	public void mT__24() { }

	public void mT__25() { }

	public void mT__26() { }

	public void mT__27() { }

	public void mT__28() { }

	public void mT__29() { }

	public void mT__30() { }

	public void mT__31() { }

	public void mT__32() { }

	public void mT__33() { }

	public void mT__34() { }

	public void mT__35() { }

	public void mT__36() { }

	public void mT__37() { }

	public void mT__38() { }

	public void mT__39() { }

	public void mT__40() { }

	public void mT__41() { }

	public void mT__42() { }

	public void mT__43() { }

	public void mT__44() { }

	public void mT__45() { }

	public void mT__46() { }

	public void mT__47() { }

	public void mT__48() { }

	public virtual void mTokens() { }

	public void mTRUE() { }

	public void mUnicodeEscape() { }

	public void mWS() { }

}

