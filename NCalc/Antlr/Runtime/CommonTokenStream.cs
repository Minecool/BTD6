namespace Antlr.Runtime;

public class CommonTokenStream : ITokenStream, IIntStream
{
	protected ITokenSource tokenSource; //Field offset: 0x10
	protected IList tokens; //Field offset: 0x18
	protected IDictionary channelOverrideMap; //Field offset: 0x20
	protected HashList discardSet; //Field offset: 0x28
	protected int channel; //Field offset: 0x30
	protected bool discardOffChannelTokens; //Field offset: 0x34
	protected int lastMarker; //Field offset: 0x38
	protected int p; //Field offset: 0x3C

	public override int Count
	{
		 get { } //Length: 73
	}

	public CommonTokenStream() { }

	public CommonTokenStream(ITokenSource tokenSource) { }

	public override void Consume() { }

	protected override void FillBuffer() { }

	public override int get_Count() { }

	public override int Index() { }

	public override int LA(int i) { }

	protected override IToken LB(int k) { }

	public override IToken LT(int k) { }

	public override int Mark() { }

	public override void Rewind(int marker) { }

	public override void Seek(int index) { }

	protected override int SkipOffTokenChannels(int i) { }

	protected override int SkipOffTokenChannelsReverse(int i) { }

	public override string ToString(int start, int stop) { }

	public virtual string ToString() { }

}

