namespace UnityEngine.UIElements;

public struct UQueryBuilder : IEquatable<UQueryBuilder`1<T>>
{
	private List<StyleSelector> m_StyleSelectors; //Field offset: 0x0
	private List<StyleSelectorPart> m_Parts; //Field offset: 0x0
	private VisualElement m_Element; //Field offset: 0x0
	private List<RuleMatcher> m_Matchers; //Field offset: 0x0
	private StyleSelectorRelationship m_Relationship; //Field offset: 0x0
	private int pseudoStatesMask; //Field offset: 0x0
	private int negatedPseudoStatesMask; //Field offset: 0x0

	private List<StyleSelectorPart> parts
	{
		private get { } //Length: 111
	}

	private List<StyleSelector> styleSelectors
	{
		private get { } //Length: 109
	}

	public UQueryBuilder`1(VisualElement visualElement) { }

	private void AddClass(string c) { }

	private void AddClasses(String[] classes) { }

	private void AddName(string id) { }

	private void AddPseudoStatesRuleIfNecessasy() { }

	private UQueryBuilder<T2> AddRelationship(StyleSelectorRelationship relationship) { }

	private void AddType() { }

	public UQueryState<T> Build() { }

	public UQueryBuilder<T> Class(string classname) { }

	private bool CurrentSelectorEmpty() { }

	public override bool Equals(UQueryBuilder<T> other) { }

	public virtual bool Equals(object obj) { }

	private void FinishCurrentSelector() { }

	private void FinishSelector() { }

	public void ForEach(Action<T> funcCall) { }

	private List<StyleSelectorPart> get_parts() { }

	private List<StyleSelector> get_styleSelectors() { }

	public virtual int GetHashCode() { }

	public UQueryBuilder<T> Name(string id) { }

	public UQueryBuilder<T2> OfType(string name = null, string className = null) { }

	public UQueryBuilder<T2> OfType(string name = null, String[] classes) { }

	internal UQueryBuilder<T> SingleBaseType() { }

	public List<T> ToList() { }

}

