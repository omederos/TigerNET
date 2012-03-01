// $ANTLR 3.3 Nov 30, 2010 12:45:30 C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g 2012-03-01 05:14:32

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 219
// Unreachable code detected.
#pragma warning disable 162


using System.Collections.Generic;
using Antlr.Runtime;
using Stack = System.Collections.Generic.Stack<object>;
using List = System.Collections.IList;
using ArrayList = System.Collections.Generic.List<object>;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.3 Nov 30, 2010 12:45:30")]
[System.CLSCompliant(false)]
public partial class TigerLexer : Antlr.Runtime.Lexer
{
	public const int EOF=-1;
	public const int T__54=54;
	public const int NIL=4;
	public const int Minus=5;
	public const int Assign=6;
	public const int LParent=7;
	public const int RParent=8;
	public const int LCorch=9;
	public const int RCorch=10;
	public const int LKey=11;
	public const int RKey=12;
	public const int If=13;
	public const int Then=14;
	public const int Else=15;
	public const int Break=16;
	public const int While=17;
	public const int Do=18;
	public const int For=19;
	public const int To=20;
	public const int In=21;
	public const int End=22;
	public const int Let=23;
	public const int Comma=24;
	public const int DotComma=25;
	public const int Dot=26;
	public const int Plus=27;
	public const int Mult=28;
	public const int Div=29;
	public const int Equals=30;
	public const int NotEquals=31;
	public const int GThan=32;
	public const int LThan=33;
	public const int GEThan=34;
	public const int LEThan=35;
	public const int And=36;
	public const int Or=37;
	public const int Type=38;
	public const int ArrayOf=39;
	public const int Var=40;
	public const int Function=41;
	public const int Quotes=42;
	public const int Underscore=43;
	public const int Of=44;
	public const int DIGIT=45;
	public const int INT_CONST=46;
	public const int CHAR=47;
	public const int SPACE=48;
	public const int ESC=49;
	public const int STRING_CONST=50;
	public const int LETTER=51;
	public const int ID=52;
	public const int COMMENTS=53;

	private IList<string> _errors = new List<string>();
	public IList<string> Errors { get { return _errors; }}

	public override void ReportError(RecognitionException e) {
		Errors.Add(e.ToString());
	}	


    // delegates
    // delegators

	public TigerLexer()
	{
		OnCreated();
	}

	public TigerLexer(ICharStream input )
		: this(input, new RecognizerSharedState())
	{
	}

	public TigerLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state)
	{


		OnCreated();
	}
	public override string GrammarFileName { get { return "C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g"; } }

	private static readonly bool[] decisionCanBacktrack = new bool[0];


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	partial void Enter_NIL();
	partial void Leave_NIL();

	// $ANTLR start "NIL"
	[GrammarRule("NIL")]
	private void mNIL()
	{
		Enter_NIL();
		EnterRule("NIL", 1);
		TraceIn("NIL", 1);
		try
		{
			int _type = NIL;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:16:5: ( 'nil' )
			DebugEnterAlt(1);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:16:7: 'nil'
			{
			DebugLocation(16, 7);
			Match("nil"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NIL", 1);
			LeaveRule("NIL", 1);
			Leave_NIL();
		}
	}
	// $ANTLR end "NIL"

	partial void Enter_Minus();
	partial void Leave_Minus();

	// $ANTLR start "Minus"
	[GrammarRule("Minus")]
	private void mMinus()
	{
		Enter_Minus();
		EnterRule("Minus", 2);
		TraceIn("Minus", 2);
		try
		{
			int _type = Minus;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:17:7: ( '-' )
			DebugEnterAlt(1);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:17:9: '-'
			{
			DebugLocation(17, 9);
			Match('-'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("Minus", 2);
			LeaveRule("Minus", 2);
			Leave_Minus();
		}
	}
	// $ANTLR end "Minus"

	partial void Enter_Assign();
	partial void Leave_Assign();

	// $ANTLR start "Assign"
	[GrammarRule("Assign")]
	private void mAssign()
	{
		Enter_Assign();
		EnterRule("Assign", 3);
		TraceIn("Assign", 3);
		try
		{
			int _type = Assign;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:18:8: ( ':=' )
			DebugEnterAlt(1);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:18:10: ':='
			{
			DebugLocation(18, 10);
			Match(":="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("Assign", 3);
			LeaveRule("Assign", 3);
			Leave_Assign();
		}
	}
	// $ANTLR end "Assign"

	partial void Enter_LParent();
	partial void Leave_LParent();

	// $ANTLR start "LParent"
	[GrammarRule("LParent")]
	private void mLParent()
	{
		Enter_LParent();
		EnterRule("LParent", 4);
		TraceIn("LParent", 4);
		try
		{
			int _type = LParent;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:19:9: ( '(' )
			DebugEnterAlt(1);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:19:11: '('
			{
			DebugLocation(19, 11);
			Match('('); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LParent", 4);
			LeaveRule("LParent", 4);
			Leave_LParent();
		}
	}
	// $ANTLR end "LParent"

	partial void Enter_RParent();
	partial void Leave_RParent();

	// $ANTLR start "RParent"
	[GrammarRule("RParent")]
	private void mRParent()
	{
		Enter_RParent();
		EnterRule("RParent", 5);
		TraceIn("RParent", 5);
		try
		{
			int _type = RParent;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:20:9: ( ')' )
			DebugEnterAlt(1);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:20:11: ')'
			{
			DebugLocation(20, 11);
			Match(')'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("RParent", 5);
			LeaveRule("RParent", 5);
			Leave_RParent();
		}
	}
	// $ANTLR end "RParent"

	partial void Enter_LCorch();
	partial void Leave_LCorch();

	// $ANTLR start "LCorch"
	[GrammarRule("LCorch")]
	private void mLCorch()
	{
		Enter_LCorch();
		EnterRule("LCorch", 6);
		TraceIn("LCorch", 6);
		try
		{
			int _type = LCorch;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:21:8: ( '[' )
			DebugEnterAlt(1);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:21:10: '['
			{
			DebugLocation(21, 10);
			Match('['); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LCorch", 6);
			LeaveRule("LCorch", 6);
			Leave_LCorch();
		}
	}
	// $ANTLR end "LCorch"

	partial void Enter_RCorch();
	partial void Leave_RCorch();

	// $ANTLR start "RCorch"
	[GrammarRule("RCorch")]
	private void mRCorch()
	{
		Enter_RCorch();
		EnterRule("RCorch", 7);
		TraceIn("RCorch", 7);
		try
		{
			int _type = RCorch;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:22:8: ( ']' )
			DebugEnterAlt(1);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:22:10: ']'
			{
			DebugLocation(22, 10);
			Match(']'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("RCorch", 7);
			LeaveRule("RCorch", 7);
			Leave_RCorch();
		}
	}
	// $ANTLR end "RCorch"

	partial void Enter_LKey();
	partial void Leave_LKey();

	// $ANTLR start "LKey"
	[GrammarRule("LKey")]
	private void mLKey()
	{
		Enter_LKey();
		EnterRule("LKey", 8);
		TraceIn("LKey", 8);
		try
		{
			int _type = LKey;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:23:6: ( '{' )
			DebugEnterAlt(1);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:23:8: '{'
			{
			DebugLocation(23, 8);
			Match('{'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LKey", 8);
			LeaveRule("LKey", 8);
			Leave_LKey();
		}
	}
	// $ANTLR end "LKey"

	partial void Enter_RKey();
	partial void Leave_RKey();

	// $ANTLR start "RKey"
	[GrammarRule("RKey")]
	private void mRKey()
	{
		Enter_RKey();
		EnterRule("RKey", 9);
		TraceIn("RKey", 9);
		try
		{
			int _type = RKey;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:24:6: ( '}' )
			DebugEnterAlt(1);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:24:8: '}'
			{
			DebugLocation(24, 8);
			Match('}'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("RKey", 9);
			LeaveRule("RKey", 9);
			Leave_RKey();
		}
	}
	// $ANTLR end "RKey"

	partial void Enter_If();
	partial void Leave_If();

	// $ANTLR start "If"
	[GrammarRule("If")]
	private void mIf()
	{
		Enter_If();
		EnterRule("If", 10);
		TraceIn("If", 10);
		try
		{
			int _type = If;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:25:4: ( 'if' )
			DebugEnterAlt(1);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:25:6: 'if'
			{
			DebugLocation(25, 6);
			Match("if"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("If", 10);
			LeaveRule("If", 10);
			Leave_If();
		}
	}
	// $ANTLR end "If"

	partial void Enter_Then();
	partial void Leave_Then();

	// $ANTLR start "Then"
	[GrammarRule("Then")]
	private void mThen()
	{
		Enter_Then();
		EnterRule("Then", 11);
		TraceIn("Then", 11);
		try
		{
			int _type = Then;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:26:6: ( 'then' )
			DebugEnterAlt(1);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:26:8: 'then'
			{
			DebugLocation(26, 8);
			Match("then"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("Then", 11);
			LeaveRule("Then", 11);
			Leave_Then();
		}
	}
	// $ANTLR end "Then"

	partial void Enter_Else();
	partial void Leave_Else();

	// $ANTLR start "Else"
	[GrammarRule("Else")]
	private void mElse()
	{
		Enter_Else();
		EnterRule("Else", 12);
		TraceIn("Else", 12);
		try
		{
			int _type = Else;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:27:6: ( 'else' )
			DebugEnterAlt(1);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:27:8: 'else'
			{
			DebugLocation(27, 8);
			Match("else"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("Else", 12);
			LeaveRule("Else", 12);
			Leave_Else();
		}
	}
	// $ANTLR end "Else"

	partial void Enter_Break();
	partial void Leave_Break();

	// $ANTLR start "Break"
	[GrammarRule("Break")]
	private void mBreak()
	{
		Enter_Break();
		EnterRule("Break", 13);
		TraceIn("Break", 13);
		try
		{
			int _type = Break;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:28:7: ( 'break' )
			DebugEnterAlt(1);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:28:9: 'break'
			{
			DebugLocation(28, 9);
			Match("break"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("Break", 13);
			LeaveRule("Break", 13);
			Leave_Break();
		}
	}
	// $ANTLR end "Break"

	partial void Enter_While();
	partial void Leave_While();

	// $ANTLR start "While"
	[GrammarRule("While")]
	private void mWhile()
	{
		Enter_While();
		EnterRule("While", 14);
		TraceIn("While", 14);
		try
		{
			int _type = While;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:29:7: ( 'while' )
			DebugEnterAlt(1);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:29:9: 'while'
			{
			DebugLocation(29, 9);
			Match("while"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("While", 14);
			LeaveRule("While", 14);
			Leave_While();
		}
	}
	// $ANTLR end "While"

	partial void Enter_Do();
	partial void Leave_Do();

	// $ANTLR start "Do"
	[GrammarRule("Do")]
	private void mDo()
	{
		Enter_Do();
		EnterRule("Do", 15);
		TraceIn("Do", 15);
		try
		{
			int _type = Do;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:30:4: ( 'do' )
			DebugEnterAlt(1);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:30:6: 'do'
			{
			DebugLocation(30, 6);
			Match("do"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("Do", 15);
			LeaveRule("Do", 15);
			Leave_Do();
		}
	}
	// $ANTLR end "Do"

	partial void Enter_For();
	partial void Leave_For();

	// $ANTLR start "For"
	[GrammarRule("For")]
	private void mFor()
	{
		Enter_For();
		EnterRule("For", 16);
		TraceIn("For", 16);
		try
		{
			int _type = For;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:31:5: ( 'for' )
			DebugEnterAlt(1);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:31:7: 'for'
			{
			DebugLocation(31, 7);
			Match("for"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("For", 16);
			LeaveRule("For", 16);
			Leave_For();
		}
	}
	// $ANTLR end "For"

	partial void Enter_To();
	partial void Leave_To();

	// $ANTLR start "To"
	[GrammarRule("To")]
	private void mTo()
	{
		Enter_To();
		EnterRule("To", 17);
		TraceIn("To", 17);
		try
		{
			int _type = To;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:32:4: ( 'to' )
			DebugEnterAlt(1);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:32:6: 'to'
			{
			DebugLocation(32, 6);
			Match("to"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("To", 17);
			LeaveRule("To", 17);
			Leave_To();
		}
	}
	// $ANTLR end "To"

	partial void Enter_In();
	partial void Leave_In();

	// $ANTLR start "In"
	[GrammarRule("In")]
	private void mIn()
	{
		Enter_In();
		EnterRule("In", 18);
		TraceIn("In", 18);
		try
		{
			int _type = In;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:33:4: ( 'in' )
			DebugEnterAlt(1);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:33:6: 'in'
			{
			DebugLocation(33, 6);
			Match("in"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("In", 18);
			LeaveRule("In", 18);
			Leave_In();
		}
	}
	// $ANTLR end "In"

	partial void Enter_End();
	partial void Leave_End();

	// $ANTLR start "End"
	[GrammarRule("End")]
	private void mEnd()
	{
		Enter_End();
		EnterRule("End", 19);
		TraceIn("End", 19);
		try
		{
			int _type = End;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:34:5: ( 'end' )
			DebugEnterAlt(1);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:34:7: 'end'
			{
			DebugLocation(34, 7);
			Match("end"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("End", 19);
			LeaveRule("End", 19);
			Leave_End();
		}
	}
	// $ANTLR end "End"

	partial void Enter_Let();
	partial void Leave_Let();

	// $ANTLR start "Let"
	[GrammarRule("Let")]
	private void mLet()
	{
		Enter_Let();
		EnterRule("Let", 20);
		TraceIn("Let", 20);
		try
		{
			int _type = Let;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:35:5: ( 'let' )
			DebugEnterAlt(1);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:35:7: 'let'
			{
			DebugLocation(35, 7);
			Match("let"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("Let", 20);
			LeaveRule("Let", 20);
			Leave_Let();
		}
	}
	// $ANTLR end "Let"

	partial void Enter_Comma();
	partial void Leave_Comma();

	// $ANTLR start "Comma"
	[GrammarRule("Comma")]
	private void mComma()
	{
		Enter_Comma();
		EnterRule("Comma", 21);
		TraceIn("Comma", 21);
		try
		{
			int _type = Comma;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:36:7: ( ',' )
			DebugEnterAlt(1);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:36:9: ','
			{
			DebugLocation(36, 9);
			Match(','); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("Comma", 21);
			LeaveRule("Comma", 21);
			Leave_Comma();
		}
	}
	// $ANTLR end "Comma"

	partial void Enter_DotComma();
	partial void Leave_DotComma();

	// $ANTLR start "DotComma"
	[GrammarRule("DotComma")]
	private void mDotComma()
	{
		Enter_DotComma();
		EnterRule("DotComma", 22);
		TraceIn("DotComma", 22);
		try
		{
			int _type = DotComma;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:37:10: ( ';' )
			DebugEnterAlt(1);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:37:12: ';'
			{
			DebugLocation(37, 12);
			Match(';'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DotComma", 22);
			LeaveRule("DotComma", 22);
			Leave_DotComma();
		}
	}
	// $ANTLR end "DotComma"

	partial void Enter_Dot();
	partial void Leave_Dot();

	// $ANTLR start "Dot"
	[GrammarRule("Dot")]
	private void mDot()
	{
		Enter_Dot();
		EnterRule("Dot", 23);
		TraceIn("Dot", 23);
		try
		{
			int _type = Dot;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:38:5: ( '.' )
			DebugEnterAlt(1);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:38:7: '.'
			{
			DebugLocation(38, 7);
			Match('.'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("Dot", 23);
			LeaveRule("Dot", 23);
			Leave_Dot();
		}
	}
	// $ANTLR end "Dot"

	partial void Enter_Plus();
	partial void Leave_Plus();

	// $ANTLR start "Plus"
	[GrammarRule("Plus")]
	private void mPlus()
	{
		Enter_Plus();
		EnterRule("Plus", 24);
		TraceIn("Plus", 24);
		try
		{
			int _type = Plus;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:39:6: ( '+' )
			DebugEnterAlt(1);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:39:8: '+'
			{
			DebugLocation(39, 8);
			Match('+'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("Plus", 24);
			LeaveRule("Plus", 24);
			Leave_Plus();
		}
	}
	// $ANTLR end "Plus"

	partial void Enter_Mult();
	partial void Leave_Mult();

	// $ANTLR start "Mult"
	[GrammarRule("Mult")]
	private void mMult()
	{
		Enter_Mult();
		EnterRule("Mult", 25);
		TraceIn("Mult", 25);
		try
		{
			int _type = Mult;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:40:6: ( '*' )
			DebugEnterAlt(1);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:40:8: '*'
			{
			DebugLocation(40, 8);
			Match('*'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("Mult", 25);
			LeaveRule("Mult", 25);
			Leave_Mult();
		}
	}
	// $ANTLR end "Mult"

	partial void Enter_Div();
	partial void Leave_Div();

	// $ANTLR start "Div"
	[GrammarRule("Div")]
	private void mDiv()
	{
		Enter_Div();
		EnterRule("Div", 26);
		TraceIn("Div", 26);
		try
		{
			int _type = Div;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:41:5: ( '/' )
			DebugEnterAlt(1);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:41:7: '/'
			{
			DebugLocation(41, 7);
			Match('/'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("Div", 26);
			LeaveRule("Div", 26);
			Leave_Div();
		}
	}
	// $ANTLR end "Div"

	partial void Enter_Equals();
	partial void Leave_Equals();

	// $ANTLR start "Equals"
	[GrammarRule("Equals")]
	private void mEquals()
	{
		Enter_Equals();
		EnterRule("Equals", 27);
		TraceIn("Equals", 27);
		try
		{
			int _type = Equals;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:42:8: ( '=' )
			DebugEnterAlt(1);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:42:10: '='
			{
			DebugLocation(42, 10);
			Match('='); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("Equals", 27);
			LeaveRule("Equals", 27);
			Leave_Equals();
		}
	}
	// $ANTLR end "Equals"

	partial void Enter_NotEquals();
	partial void Leave_NotEquals();

	// $ANTLR start "NotEquals"
	[GrammarRule("NotEquals")]
	private void mNotEquals()
	{
		Enter_NotEquals();
		EnterRule("NotEquals", 28);
		TraceIn("NotEquals", 28);
		try
		{
			int _type = NotEquals;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:43:11: ( '<>' )
			DebugEnterAlt(1);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:43:13: '<>'
			{
			DebugLocation(43, 13);
			Match("<>"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NotEquals", 28);
			LeaveRule("NotEquals", 28);
			Leave_NotEquals();
		}
	}
	// $ANTLR end "NotEquals"

	partial void Enter_GThan();
	partial void Leave_GThan();

	// $ANTLR start "GThan"
	[GrammarRule("GThan")]
	private void mGThan()
	{
		Enter_GThan();
		EnterRule("GThan", 29);
		TraceIn("GThan", 29);
		try
		{
			int _type = GThan;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:44:7: ( '>' )
			DebugEnterAlt(1);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:44:9: '>'
			{
			DebugLocation(44, 9);
			Match('>'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("GThan", 29);
			LeaveRule("GThan", 29);
			Leave_GThan();
		}
	}
	// $ANTLR end "GThan"

	partial void Enter_LThan();
	partial void Leave_LThan();

	// $ANTLR start "LThan"
	[GrammarRule("LThan")]
	private void mLThan()
	{
		Enter_LThan();
		EnterRule("LThan", 30);
		TraceIn("LThan", 30);
		try
		{
			int _type = LThan;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:45:7: ( '<' )
			DebugEnterAlt(1);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:45:9: '<'
			{
			DebugLocation(45, 9);
			Match('<'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LThan", 30);
			LeaveRule("LThan", 30);
			Leave_LThan();
		}
	}
	// $ANTLR end "LThan"

	partial void Enter_GEThan();
	partial void Leave_GEThan();

	// $ANTLR start "GEThan"
	[GrammarRule("GEThan")]
	private void mGEThan()
	{
		Enter_GEThan();
		EnterRule("GEThan", 31);
		TraceIn("GEThan", 31);
		try
		{
			int _type = GEThan;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:46:8: ( '>=' )
			DebugEnterAlt(1);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:46:10: '>='
			{
			DebugLocation(46, 10);
			Match(">="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("GEThan", 31);
			LeaveRule("GEThan", 31);
			Leave_GEThan();
		}
	}
	// $ANTLR end "GEThan"

	partial void Enter_LEThan();
	partial void Leave_LEThan();

	// $ANTLR start "LEThan"
	[GrammarRule("LEThan")]
	private void mLEThan()
	{
		Enter_LEThan();
		EnterRule("LEThan", 32);
		TraceIn("LEThan", 32);
		try
		{
			int _type = LEThan;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:47:8: ( '<=' )
			DebugEnterAlt(1);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:47:10: '<='
			{
			DebugLocation(47, 10);
			Match("<="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LEThan", 32);
			LeaveRule("LEThan", 32);
			Leave_LEThan();
		}
	}
	// $ANTLR end "LEThan"

	partial void Enter_And();
	partial void Leave_And();

	// $ANTLR start "And"
	[GrammarRule("And")]
	private void mAnd()
	{
		Enter_And();
		EnterRule("And", 33);
		TraceIn("And", 33);
		try
		{
			int _type = And;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:48:5: ( '&' )
			DebugEnterAlt(1);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:48:7: '&'
			{
			DebugLocation(48, 7);
			Match('&'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("And", 33);
			LeaveRule("And", 33);
			Leave_And();
		}
	}
	// $ANTLR end "And"

	partial void Enter_Or();
	partial void Leave_Or();

	// $ANTLR start "Or"
	[GrammarRule("Or")]
	private void mOr()
	{
		Enter_Or();
		EnterRule("Or", 34);
		TraceIn("Or", 34);
		try
		{
			int _type = Or;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:49:4: ( '|' )
			DebugEnterAlt(1);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:49:6: '|'
			{
			DebugLocation(49, 6);
			Match('|'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("Or", 34);
			LeaveRule("Or", 34);
			Leave_Or();
		}
	}
	// $ANTLR end "Or"

	partial void Enter_Type();
	partial void Leave_Type();

	// $ANTLR start "Type"
	[GrammarRule("Type")]
	private void mType()
	{
		Enter_Type();
		EnterRule("Type", 35);
		TraceIn("Type", 35);
		try
		{
			int _type = Type;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:50:6: ( 'type' )
			DebugEnterAlt(1);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:50:8: 'type'
			{
			DebugLocation(50, 8);
			Match("type"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("Type", 35);
			LeaveRule("Type", 35);
			Leave_Type();
		}
	}
	// $ANTLR end "Type"

	partial void Enter_ArrayOf();
	partial void Leave_ArrayOf();

	// $ANTLR start "ArrayOf"
	[GrammarRule("ArrayOf")]
	private void mArrayOf()
	{
		Enter_ArrayOf();
		EnterRule("ArrayOf", 36);
		TraceIn("ArrayOf", 36);
		try
		{
			int _type = ArrayOf;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:51:9: ( 'array of' )
			DebugEnterAlt(1);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:51:11: 'array of'
			{
			DebugLocation(51, 11);
			Match("array of"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ArrayOf", 36);
			LeaveRule("ArrayOf", 36);
			Leave_ArrayOf();
		}
	}
	// $ANTLR end "ArrayOf"

	partial void Enter_Var();
	partial void Leave_Var();

	// $ANTLR start "Var"
	[GrammarRule("Var")]
	private void mVar()
	{
		Enter_Var();
		EnterRule("Var", 37);
		TraceIn("Var", 37);
		try
		{
			int _type = Var;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:52:5: ( 'var' )
			DebugEnterAlt(1);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:52:7: 'var'
			{
			DebugLocation(52, 7);
			Match("var"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("Var", 37);
			LeaveRule("Var", 37);
			Leave_Var();
		}
	}
	// $ANTLR end "Var"

	partial void Enter_Function();
	partial void Leave_Function();

	// $ANTLR start "Function"
	[GrammarRule("Function")]
	private void mFunction()
	{
		Enter_Function();
		EnterRule("Function", 38);
		TraceIn("Function", 38);
		try
		{
			int _type = Function;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:53:10: ( 'function' )
			DebugEnterAlt(1);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:53:12: 'function'
			{
			DebugLocation(53, 12);
			Match("function"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("Function", 38);
			LeaveRule("Function", 38);
			Leave_Function();
		}
	}
	// $ANTLR end "Function"

	partial void Enter_Quotes();
	partial void Leave_Quotes();

	// $ANTLR start "Quotes"
	[GrammarRule("Quotes")]
	private void mQuotes()
	{
		Enter_Quotes();
		EnterRule("Quotes", 39);
		TraceIn("Quotes", 39);
		try
		{
			int _type = Quotes;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:54:8: ( '\"' )
			DebugEnterAlt(1);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:54:10: '\"'
			{
			DebugLocation(54, 10);
			Match('\"'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("Quotes", 39);
			LeaveRule("Quotes", 39);
			Leave_Quotes();
		}
	}
	// $ANTLR end "Quotes"

	partial void Enter_Underscore();
	partial void Leave_Underscore();

	// $ANTLR start "Underscore"
	[GrammarRule("Underscore")]
	private void mUnderscore()
	{
		Enter_Underscore();
		EnterRule("Underscore", 40);
		TraceIn("Underscore", 40);
		try
		{
			int _type = Underscore;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:55:12: ( '_' )
			DebugEnterAlt(1);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:55:14: '_'
			{
			DebugLocation(55, 14);
			Match('_'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("Underscore", 40);
			LeaveRule("Underscore", 40);
			Leave_Underscore();
		}
	}
	// $ANTLR end "Underscore"

	partial void Enter_Of();
	partial void Leave_Of();

	// $ANTLR start "Of"
	[GrammarRule("Of")]
	private void mOf()
	{
		Enter_Of();
		EnterRule("Of", 41);
		TraceIn("Of", 41);
		try
		{
			int _type = Of;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:56:4: ( 'of' )
			DebugEnterAlt(1);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:56:6: 'of'
			{
			DebugLocation(56, 6);
			Match("of"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("Of", 41);
			LeaveRule("Of", 41);
			Leave_Of();
		}
	}
	// $ANTLR end "Of"

	partial void Enter_T__54();
	partial void Leave_T__54();

	// $ANTLR start "T__54"
	[GrammarRule("T__54")]
	private void mT__54()
	{
		Enter_T__54();
		EnterRule("T__54", 42);
		TraceIn("T__54", 42);
		try
		{
			int _type = T__54;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:57:7: ( ':' )
			DebugEnterAlt(1);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:57:9: ':'
			{
			DebugLocation(57, 9);
			Match(':'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__54", 42);
			LeaveRule("T__54", 42);
			Leave_T__54();
		}
	}
	// $ANTLR end "T__54"

	partial void Enter_INT_CONST();
	partial void Leave_INT_CONST();

	// $ANTLR start "INT_CONST"
	[GrammarRule("INT_CONST")]
	private void mINT_CONST()
	{
		Enter_INT_CONST();
		EnterRule("INT_CONST", 43);
		TraceIn("INT_CONST", 43);
		try
		{
			int _type = INT_CONST;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:77:12: ( ( DIGIT )+ )
			DebugEnterAlt(1);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:77:14: ( DIGIT )+
			{
			DebugLocation(77, 14);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:77:14: ( DIGIT )+
			int cnt1=0;
			try { DebugEnterSubRule(1);
			while (true)
			{
				int alt1=2;
				try { DebugEnterDecision(1, decisionCanBacktrack[1]);
				int LA1_0 = input.LA(1);

				if (((LA1_0>='0' && LA1_0<='9')))
				{
					alt1=1;
				}


				} finally { DebugExitDecision(1); }
				switch (alt1)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:77:15: DIGIT
					{
					DebugLocation(77, 15);
					mDIGIT(); 

					}
					break;

				default:
					if (cnt1 >= 1)
						goto loop1;

					EarlyExitException eee1 = new EarlyExitException( 1, input );
					DebugRecognitionException(eee1);
					throw eee1;
				}
				cnt1++;
			}
			loop1:
				;

			} finally { DebugExitSubRule(1); }


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("INT_CONST", 43);
			LeaveRule("INT_CONST", 43);
			Leave_INT_CONST();
		}
	}
	// $ANTLR end "INT_CONST"

	partial void Enter_STRING_CONST();
	partial void Leave_STRING_CONST();

	// $ANTLR start "STRING_CONST"
	[GrammarRule("STRING_CONST")]
	private void mSTRING_CONST()
	{
		Enter_STRING_CONST();
		EnterRule("STRING_CONST", 44);
		TraceIn("STRING_CONST", 44);
		try
		{
			int _type = STRING_CONST;
			int _channel = DefaultTokenChannel;
			CommonToken CHAR1=null;
			CommonToken SPACE2=null;
			CommonToken ESC3=null;

			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:78:14: ( Quotes ( CHAR | SPACE | ESC )* Quotes )
			DebugEnterAlt(1);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:78:16: Quotes ( CHAR | SPACE | ESC )* Quotes
			{
			DebugLocation(78, 16);
			mQuotes(); 
			DebugLocation(78, 23);
			Text = "";
			DebugLocation(79, 1);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:79:1: ( CHAR | SPACE | ESC )*
			try { DebugEnterSubRule(2);
			while (true)
			{
				int alt2=4;
				try { DebugEnterDecision(2, decisionCanBacktrack[2]);
				int LA2_0 = input.LA(1);

				if (((LA2_0>='\u0000' && LA2_0<='\b')||(LA2_0>='\u000B' && LA2_0<='\u001F')||LA2_0=='!'||(LA2_0>='#' && LA2_0<='[')||(LA2_0>=']' && LA2_0<='\uFFFF')))
				{
					alt2=1;
				}
				else if (((LA2_0>='\t' && LA2_0<='\n')||LA2_0==' '))
				{
					alt2=2;
				}
				else if ((LA2_0=='\\'))
				{
					alt2=3;
				}


				} finally { DebugExitDecision(2); }
				switch ( alt2 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:80:1: CHAR
					{
					DebugLocation(80, 1);
					int CHAR1Start386 = CharIndex;
					int CHAR1StartLine386 = Line;
					int CHAR1StartCharPos386 = CharPositionInLine;
					mCHAR(); 
					CHAR1 = new CommonToken(input, TokenTypes.Invalid, TokenChannels.Default, CHAR1Start386, CharIndex-1);
					CHAR1.Line = CHAR1StartLine386;
					CHAR1.CharPositionInLine = CHAR1StartCharPos386;
					DebugLocation(80, 6);
					Text += CHAR1.Text; 

					}
					break;
				case 2:
					DebugEnterAlt(2);
					// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:81:1: SPACE
					{
					DebugLocation(81, 1);
					int SPACE2Start391 = CharIndex;
					int SPACE2StartLine391 = Line;
					int SPACE2StartCharPos391 = CharPositionInLine;
					mSPACE(); 
					SPACE2 = new CommonToken(input, TokenTypes.Invalid, TokenChannels.Default, SPACE2Start391, CharIndex-1);
					SPACE2.Line = SPACE2StartLine391;
					SPACE2.CharPositionInLine = SPACE2StartCharPos391;
					DebugLocation(81, 7);
					Text += SPACE2.Text; 

					}
					break;
				case 3:
					DebugEnterAlt(3);
					// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:82:1: ESC
					{
					DebugLocation(82, 1);
					int ESC3Start396 = CharIndex;
					int ESC3StartLine396 = Line;
					int ESC3StartCharPos396 = CharPositionInLine;
					mESC(); 
					ESC3 = new CommonToken(input, TokenTypes.Invalid, TokenChannels.Default, ESC3Start396, CharIndex-1);
					ESC3.Line = ESC3StartLine396;
					ESC3.CharPositionInLine = ESC3StartCharPos396;
					DebugLocation(82, 5);
					Text += ESC3.Text; 

					}
					break;

				default:
					goto loop2;
				}
			}

			loop2:
				;

			} finally { DebugExitSubRule(2); }

			DebugLocation(83, 4);
			mQuotes(); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("STRING_CONST", 44);
			LeaveRule("STRING_CONST", 44);
			Leave_STRING_CONST();
		}
	}
	// $ANTLR end "STRING_CONST"

	partial void Enter_DIGIT();
	partial void Leave_DIGIT();

	// $ANTLR start "DIGIT"
	[GrammarRule("DIGIT")]
	private void mDIGIT()
	{
		Enter_DIGIT();
		EnterRule("DIGIT", 45);
		TraceIn("DIGIT", 45);
		try
		{
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:84:16: ( '0' .. '9' )
			DebugEnterAlt(1);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:84:18: '0' .. '9'
			{
			DebugLocation(84, 18);
			MatchRange('0','9'); 

			}

		}
		finally
		{
			TraceOut("DIGIT", 45);
			LeaveRule("DIGIT", 45);
			Leave_DIGIT();
		}
	}
	// $ANTLR end "DIGIT"

	partial void Enter_SPACE();
	partial void Leave_SPACE();

	// $ANTLR start "SPACE"
	[GrammarRule("SPACE")]
	private void mSPACE()
	{
		Enter_SPACE();
		EnterRule("SPACE", 46);
		TraceIn("SPACE", 46);
		try
		{
			int _type = SPACE;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:85:7: ( ( '\\n' | '\\t' | ' ' | '\\r' ) )
			DebugEnterAlt(1);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:85:9: ( '\\n' | '\\t' | ' ' | '\\r' )
			{
			DebugLocation(85, 9);
			if ((input.LA(1)>='\t' && input.LA(1)<='\n')||input.LA(1)=='\r'||input.LA(1)==' ')
			{
				input.Consume();

			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;}

			DebugLocation(85, 30);
			_channel = Hidden;

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("SPACE", 46);
			LeaveRule("SPACE", 46);
			Leave_SPACE();
		}
	}
	// $ANTLR end "SPACE"

	partial void Enter_ESC();
	partial void Leave_ESC();

	// $ANTLR start "ESC"
	[GrammarRule("ESC")]
	private void mESC()
	{
		Enter_ESC();
		EnterRule("ESC", 47);
		TraceIn("ESC", 47);
		try
		{
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:86:14: ( '\\\\' ( 'n' | 't' | '\\\\' | '\"' ) )
			DebugEnterAlt(1);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:86:16: '\\\\' ( 'n' | 't' | '\\\\' | '\"' )
			{
			DebugLocation(86, 16);
			Match('\\'); 
			DebugLocation(86, 20);
			if (input.LA(1)=='\"'||input.LA(1)=='\\'||input.LA(1)=='n'||input.LA(1)=='t')
			{
				input.Consume();

			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;}


			}

		}
		finally
		{
			TraceOut("ESC", 47);
			LeaveRule("ESC", 47);
			Leave_ESC();
		}
	}
	// $ANTLR end "ESC"

	partial void Enter_LETTER();
	partial void Leave_LETTER();

	// $ANTLR start "LETTER"
	[GrammarRule("LETTER")]
	private void mLETTER()
	{
		Enter_LETTER();
		EnterRule("LETTER", 48);
		TraceIn("LETTER", 48);
		try
		{
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:87:17: ( 'a' .. 'z' | 'A' .. 'Z' )
			DebugEnterAlt(1);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:
			{
			DebugLocation(87, 17);
			if ((input.LA(1)>='A' && input.LA(1)<='Z')||(input.LA(1)>='a' && input.LA(1)<='z'))
			{
				input.Consume();

			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;}


			}

		}
		finally
		{
			TraceOut("LETTER", 48);
			LeaveRule("LETTER", 48);
			Leave_LETTER();
		}
	}
	// $ANTLR end "LETTER"

	partial void Enter_CHAR();
	partial void Leave_CHAR();

	// $ANTLR start "CHAR"
	[GrammarRule("CHAR")]
	private void mCHAR()
	{
		Enter_CHAR();
		EnterRule("CHAR", 49);
		TraceIn("CHAR", 49);
		try
		{
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:88:15: (~ ( '\\n' | '\\t' | '\\\\' | '\"' | ' ' ) )
			DebugEnterAlt(1);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:88:17: ~ ( '\\n' | '\\t' | '\\\\' | '\"' | ' ' )
			{
			DebugLocation(88, 17);
			if ((input.LA(1)>='\u0000' && input.LA(1)<='\b')||(input.LA(1)>='\u000B' && input.LA(1)<='\u001F')||input.LA(1)=='!'||(input.LA(1)>='#' && input.LA(1)<='[')||(input.LA(1)>=']' && input.LA(1)<='\uFFFF'))
			{
				input.Consume();

			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;}


			}

		}
		finally
		{
			TraceOut("CHAR", 49);
			LeaveRule("CHAR", 49);
			Leave_CHAR();
		}
	}
	// $ANTLR end "CHAR"

	partial void Enter_ID();
	partial void Leave_ID();

	// $ANTLR start "ID"
	[GrammarRule("ID")]
	private void mID()
	{
		Enter_ID();
		EnterRule("ID", 50);
		TraceIn("ID", 50);
		try
		{
			int _type = ID;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:89:4: ( LETTER ( LETTER | DIGIT | Underscore )* )
			DebugEnterAlt(1);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:89:6: LETTER ( LETTER | DIGIT | Underscore )*
			{
			DebugLocation(89, 6);
			mLETTER(); 
			DebugLocation(89, 12);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:89:12: ( LETTER | DIGIT | Underscore )*
			try { DebugEnterSubRule(3);
			while (true)
			{
				int alt3=2;
				try { DebugEnterDecision(3, decisionCanBacktrack[3]);
				int LA3_0 = input.LA(1);

				if (((LA3_0>='0' && LA3_0<='9')||(LA3_0>='A' && LA3_0<='Z')||LA3_0=='_'||(LA3_0>='a' && LA3_0<='z')))
				{
					alt3=1;
				}


				} finally { DebugExitDecision(3); }
				switch ( alt3 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:
					{
					DebugLocation(89, 12);
					if ((input.LA(1)>='0' && input.LA(1)<='9')||(input.LA(1)>='A' && input.LA(1)<='Z')||input.LA(1)=='_'||(input.LA(1)>='a' && input.LA(1)<='z'))
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						Recover(mse);
						throw mse;}


					}
					break;

				default:
					goto loop3;
				}
			}

			loop3:
				;

			} finally { DebugExitSubRule(3); }


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ID", 50);
			LeaveRule("ID", 50);
			Leave_ID();
		}
	}
	// $ANTLR end "ID"

	partial void Enter_COMMENTS();
	partial void Leave_COMMENTS();

	// $ANTLR start "COMMENTS"
	[GrammarRule("COMMENTS")]
	private void mCOMMENTS()
	{
		Enter_COMMENTS();
		EnterRule("COMMENTS", 51);
		TraceIn("COMMENTS", 51);
		try
		{
			int _type = COMMENTS;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:91:2: ( '/*' ( options {greedy=false; } : COMMENTS | . )* '*/' )
			DebugEnterAlt(1);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:91:4: '/*' ( options {greedy=false; } : COMMENTS | . )* '*/'
			{
			DebugLocation(91, 4);
			Match("/*"); 

			DebugLocation(91, 9);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:91:9: ( options {greedy=false; } : COMMENTS | . )*
			try { DebugEnterSubRule(4);
			while (true)
			{
				int alt4=3;
				try { DebugEnterDecision(4, decisionCanBacktrack[4]);
				int LA4_0 = input.LA(1);

				if ((LA4_0=='*'))
				{
					int LA4_1 = input.LA(2);

					if ((LA4_1=='/'))
					{
						alt4=3;
					}
					else if (((LA4_1>='\u0000' && LA4_1<='.')||(LA4_1>='0' && LA4_1<='\uFFFF')))
					{
						alt4=2;
					}


				}
				else if ((LA4_0=='/'))
				{
					int LA4_2 = input.LA(2);

					if ((LA4_2=='*'))
					{
						alt4=1;
					}
					else if (((LA4_2>='\u0000' && LA4_2<=')')||(LA4_2>='+' && LA4_2<='\uFFFF')))
					{
						alt4=2;
					}


				}
				else if (((LA4_0>='\u0000' && LA4_0<=')')||(LA4_0>='+' && LA4_0<='.')||(LA4_0>='0' && LA4_0<='\uFFFF')))
				{
					alt4=2;
				}


				} finally { DebugExitDecision(4); }
				switch ( alt4 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:91:37: COMMENTS
					{
					DebugLocation(91, 37);
					mCOMMENTS(); 

					}
					break;
				case 2:
					DebugEnterAlt(2);
					// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:91:48: .
					{
					DebugLocation(91, 48);
					MatchAny(); 

					}
					break;

				default:
					goto loop4;
				}
			}

			loop4:
				;

			} finally { DebugExitSubRule(4); }

			DebugLocation(91, 53);
			Match("*/"); 

			DebugLocation(92, 3);
			_channel = Hidden;

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("COMMENTS", 51);
			LeaveRule("COMMENTS", 51);
			Leave_COMMENTS();
		}
	}
	// $ANTLR end "COMMENTS"

	public override void mTokens()
	{
		// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:1:8: ( NIL | Minus | Assign | LParent | RParent | LCorch | RCorch | LKey | RKey | If | Then | Else | Break | While | Do | For | To | In | End | Let | Comma | DotComma | Dot | Plus | Mult | Div | Equals | NotEquals | GThan | LThan | GEThan | LEThan | And | Or | Type | ArrayOf | Var | Function | Quotes | Underscore | Of | T__54 | INT_CONST | STRING_CONST | SPACE | ID | COMMENTS )
		int alt5=47;
		try { DebugEnterDecision(5, decisionCanBacktrack[5]);
		try
		{
			alt5 = dfa5.Predict(input);
		}
		catch (NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
			throw;
		}
		} finally { DebugExitDecision(5); }
		switch (alt5)
		{
		case 1:
			DebugEnterAlt(1);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:1:10: NIL
			{
			DebugLocation(1, 10);
			mNIL(); 

			}
			break;
		case 2:
			DebugEnterAlt(2);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:1:14: Minus
			{
			DebugLocation(1, 14);
			mMinus(); 

			}
			break;
		case 3:
			DebugEnterAlt(3);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:1:20: Assign
			{
			DebugLocation(1, 20);
			mAssign(); 

			}
			break;
		case 4:
			DebugEnterAlt(4);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:1:27: LParent
			{
			DebugLocation(1, 27);
			mLParent(); 

			}
			break;
		case 5:
			DebugEnterAlt(5);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:1:35: RParent
			{
			DebugLocation(1, 35);
			mRParent(); 

			}
			break;
		case 6:
			DebugEnterAlt(6);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:1:43: LCorch
			{
			DebugLocation(1, 43);
			mLCorch(); 

			}
			break;
		case 7:
			DebugEnterAlt(7);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:1:50: RCorch
			{
			DebugLocation(1, 50);
			mRCorch(); 

			}
			break;
		case 8:
			DebugEnterAlt(8);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:1:57: LKey
			{
			DebugLocation(1, 57);
			mLKey(); 

			}
			break;
		case 9:
			DebugEnterAlt(9);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:1:62: RKey
			{
			DebugLocation(1, 62);
			mRKey(); 

			}
			break;
		case 10:
			DebugEnterAlt(10);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:1:67: If
			{
			DebugLocation(1, 67);
			mIf(); 

			}
			break;
		case 11:
			DebugEnterAlt(11);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:1:70: Then
			{
			DebugLocation(1, 70);
			mThen(); 

			}
			break;
		case 12:
			DebugEnterAlt(12);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:1:75: Else
			{
			DebugLocation(1, 75);
			mElse(); 

			}
			break;
		case 13:
			DebugEnterAlt(13);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:1:80: Break
			{
			DebugLocation(1, 80);
			mBreak(); 

			}
			break;
		case 14:
			DebugEnterAlt(14);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:1:86: While
			{
			DebugLocation(1, 86);
			mWhile(); 

			}
			break;
		case 15:
			DebugEnterAlt(15);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:1:92: Do
			{
			DebugLocation(1, 92);
			mDo(); 

			}
			break;
		case 16:
			DebugEnterAlt(16);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:1:95: For
			{
			DebugLocation(1, 95);
			mFor(); 

			}
			break;
		case 17:
			DebugEnterAlt(17);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:1:99: To
			{
			DebugLocation(1, 99);
			mTo(); 

			}
			break;
		case 18:
			DebugEnterAlt(18);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:1:102: In
			{
			DebugLocation(1, 102);
			mIn(); 

			}
			break;
		case 19:
			DebugEnterAlt(19);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:1:105: End
			{
			DebugLocation(1, 105);
			mEnd(); 

			}
			break;
		case 20:
			DebugEnterAlt(20);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:1:109: Let
			{
			DebugLocation(1, 109);
			mLet(); 

			}
			break;
		case 21:
			DebugEnterAlt(21);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:1:113: Comma
			{
			DebugLocation(1, 113);
			mComma(); 

			}
			break;
		case 22:
			DebugEnterAlt(22);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:1:119: DotComma
			{
			DebugLocation(1, 119);
			mDotComma(); 

			}
			break;
		case 23:
			DebugEnterAlt(23);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:1:128: Dot
			{
			DebugLocation(1, 128);
			mDot(); 

			}
			break;
		case 24:
			DebugEnterAlt(24);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:1:132: Plus
			{
			DebugLocation(1, 132);
			mPlus(); 

			}
			break;
		case 25:
			DebugEnterAlt(25);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:1:137: Mult
			{
			DebugLocation(1, 137);
			mMult(); 

			}
			break;
		case 26:
			DebugEnterAlt(26);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:1:142: Div
			{
			DebugLocation(1, 142);
			mDiv(); 

			}
			break;
		case 27:
			DebugEnterAlt(27);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:1:146: Equals
			{
			DebugLocation(1, 146);
			mEquals(); 

			}
			break;
		case 28:
			DebugEnterAlt(28);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:1:153: NotEquals
			{
			DebugLocation(1, 153);
			mNotEquals(); 

			}
			break;
		case 29:
			DebugEnterAlt(29);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:1:163: GThan
			{
			DebugLocation(1, 163);
			mGThan(); 

			}
			break;
		case 30:
			DebugEnterAlt(30);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:1:169: LThan
			{
			DebugLocation(1, 169);
			mLThan(); 

			}
			break;
		case 31:
			DebugEnterAlt(31);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:1:175: GEThan
			{
			DebugLocation(1, 175);
			mGEThan(); 

			}
			break;
		case 32:
			DebugEnterAlt(32);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:1:182: LEThan
			{
			DebugLocation(1, 182);
			mLEThan(); 

			}
			break;
		case 33:
			DebugEnterAlt(33);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:1:189: And
			{
			DebugLocation(1, 189);
			mAnd(); 

			}
			break;
		case 34:
			DebugEnterAlt(34);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:1:193: Or
			{
			DebugLocation(1, 193);
			mOr(); 

			}
			break;
		case 35:
			DebugEnterAlt(35);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:1:196: Type
			{
			DebugLocation(1, 196);
			mType(); 

			}
			break;
		case 36:
			DebugEnterAlt(36);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:1:201: ArrayOf
			{
			DebugLocation(1, 201);
			mArrayOf(); 

			}
			break;
		case 37:
			DebugEnterAlt(37);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:1:209: Var
			{
			DebugLocation(1, 209);
			mVar(); 

			}
			break;
		case 38:
			DebugEnterAlt(38);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:1:213: Function
			{
			DebugLocation(1, 213);
			mFunction(); 

			}
			break;
		case 39:
			DebugEnterAlt(39);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:1:222: Quotes
			{
			DebugLocation(1, 222);
			mQuotes(); 

			}
			break;
		case 40:
			DebugEnterAlt(40);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:1:229: Underscore
			{
			DebugLocation(1, 229);
			mUnderscore(); 

			}
			break;
		case 41:
			DebugEnterAlt(41);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:1:240: Of
			{
			DebugLocation(1, 240);
			mOf(); 

			}
			break;
		case 42:
			DebugEnterAlt(42);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:1:243: T__54
			{
			DebugLocation(1, 243);
			mT__54(); 

			}
			break;
		case 43:
			DebugEnterAlt(43);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:1:249: INT_CONST
			{
			DebugLocation(1, 249);
			mINT_CONST(); 

			}
			break;
		case 44:
			DebugEnterAlt(44);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:1:259: STRING_CONST
			{
			DebugLocation(1, 259);
			mSTRING_CONST(); 

			}
			break;
		case 45:
			DebugEnterAlt(45);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:1:272: SPACE
			{
			DebugLocation(1, 272);
			mSPACE(); 

			}
			break;
		case 46:
			DebugEnterAlt(46);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:1:278: ID
			{
			DebugLocation(1, 278);
			mID(); 

			}
			break;
		case 47:
			DebugEnterAlt(47);
			// C:\\Users\\Oscar\\Documents\\Visual Studio 2010\\Projects\\TigerNET\\Grammar\\Tiger.g:1:281: COMMENTS
			{
			DebugLocation(1, 281);
			mCOMMENTS(); 

			}
			break;

		}

	}


	#region DFA
	DFA5 dfa5;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa5 = new DFA5(this, SpecialStateTransition5);
	}

	private class DFA5 : DFA
	{
		private const string DFA5_eotS =
			"\x1\xFFFF\x1\x24\x1\xFFFF\x1\x27\x6\xFFFF\x8\x24\x5\xFFFF\x1\x36\x1"+
			"\xFFFF\x1\x39\x1\x3B\x2\xFFFF\x2\x24\x1\x3E\x1\xFFFF\x1\x24\x3\xFFFF"+
			"\x1\x24\x2\xFFFF\x1\x42\x1\x43\x1\x24\x1\x45\x5\x24\x1\x4B\x3\x24\x7"+
			"\xFFFF\x2\x24\x2\xFFFF\x1\x51\x1\x52\x2\xFFFF\x1\x24\x1\xFFFF\x2\x24"+
			"\x1\x56\x2\x24\x1\xFFFF\x1\x59\x1\x24\x1\x5B\x1\x24\x1\x5D\x2\xFFFF\x1"+
			"\x5E\x1\x5F\x1\x60\x1\xFFFF\x2\x24\x1\xFFFF\x1\x24\x1\xFFFF\x1\x24\x4"+
			"\xFFFF\x1\x65\x1\x66\x2\x24\x2\xFFFF\x1\x24\x1\xFFFF\x1\x24\x1\x6B\x1"+
			"\xFFFF";
		private const string DFA5_eofS =
			"\x6C\xFFFF";
		private const string DFA5_minS =
			"\x1\x9\x1\x69\x1\xFFFF\x1\x3D\x6\xFFFF\x1\x66\x1\x68\x1\x6C\x1\x72\x1"+
			"\x68\x2\x6F\x1\x65\x5\xFFFF\x1\x2A\x1\xFFFF\x2\x3D\x2\xFFFF\x1\x72\x1"+
			"\x61\x1\x0\x1\xFFFF\x1\x66\x3\xFFFF\x1\x6C\x2\xFFFF\x2\x30\x1\x65\x1"+
			"\x30\x1\x70\x1\x73\x1\x64\x1\x65\x1\x69\x1\x30\x1\x72\x1\x6E\x1\x74\x7"+
			"\xFFFF\x2\x72\x2\xFFFF\x2\x30\x2\xFFFF\x1\x6E\x1\xFFFF\x2\x65\x1\x30"+
			"\x1\x61\x1\x6C\x1\xFFFF\x1\x30\x1\x63\x1\x30\x1\x61\x1\x30\x2\xFFFF\x3"+
			"\x30\x1\xFFFF\x1\x6B\x1\x65\x1\xFFFF\x1\x74\x1\xFFFF\x1\x79\x4\xFFFF"+
			"\x2\x30\x1\x69\x1\x20\x2\xFFFF\x1\x6F\x1\xFFFF\x1\x6E\x1\x30\x1\xFFFF";
		private const string DFA5_maxS =
			"\x1\x7D\x1\x69\x1\xFFFF\x1\x3D\x6\xFFFF\x1\x6E\x1\x79\x1\x6E\x1\x72"+
			"\x1\x68\x1\x6F\x1\x75\x1\x65\x5\xFFFF\x1\x2A\x1\xFFFF\x1\x3E\x1\x3D\x2"+
			"\xFFFF\x1\x72\x1\x61\x1\xFFFF\x1\xFFFF\x1\x66\x3\xFFFF\x1\x6C\x2\xFFFF"+
			"\x2\x7A\x1\x65\x1\x7A\x1\x70\x1\x73\x1\x64\x1\x65\x1\x69\x1\x7A\x1\x72"+
			"\x1\x6E\x1\x74\x7\xFFFF\x2\x72\x2\xFFFF\x2\x7A\x2\xFFFF\x1\x6E\x1\xFFFF"+
			"\x2\x65\x1\x7A\x1\x61\x1\x6C\x1\xFFFF\x1\x7A\x1\x63\x1\x7A\x1\x61\x1"+
			"\x7A\x2\xFFFF\x3\x7A\x1\xFFFF\x1\x6B\x1\x65\x1\xFFFF\x1\x74\x1\xFFFF"+
			"\x1\x79\x4\xFFFF\x2\x7A\x1\x69\x1\x20\x2\xFFFF\x1\x6F\x1\xFFFF\x1\x6E"+
			"\x1\x7A\x1\xFFFF";
		private const string DFA5_acceptS =
			"\x2\xFFFF\x1\x2\x1\xFFFF\x1\x4\x1\x5\x1\x6\x1\x7\x1\x8\x1\x9\x8\xFFFF"+
			"\x1\x15\x1\x16\x1\x17\x1\x18\x1\x19\x1\xFFFF\x1\x1B\x2\xFFFF\x1\x21\x1"+
			"\x22\x3\xFFFF\x1\x28\x1\xFFFF\x1\x2B\x1\x2D\x1\x2E\x1\xFFFF\x1\x3\x1"+
			"\x2A\xD\xFFFF\x1\x2F\x1\x1A\x1\x1C\x1\x20\x1\x1E\x1\x1F\x1\x1D\x2\xFFFF"+
			"\x1\x27\x1\x2C\x2\xFFFF\x1\xA\x1\x12\x1\xFFFF\x1\x11\x5\xFFFF\x1\xF\x5"+
			"\xFFFF\x1\x29\x1\x1\x3\xFFFF\x1\x13\x2\xFFFF\x1\x10\x1\xFFFF\x1\x14\x1"+
			"\xFFFF\x1\x25\x1\xB\x1\x23\x1\xC\x4\xFFFF\x1\xD\x1\xE\x1\xFFFF\x1\x24"+
			"\x2\xFFFF\x1\x26";
		private const string DFA5_specialS =
			"\x1F\xFFFF\x1\x0\x4C\xFFFF}>";
		private static readonly string[] DFA5_transitionS =
			{
				"\x2\x23\x2\xFFFF\x1\x23\x12\xFFFF\x1\x23\x1\xFFFF\x1\x1F\x3\xFFFF\x1"+
				"\x1B\x1\xFFFF\x1\x4\x1\x5\x1\x16\x1\x15\x1\x12\x1\x2\x1\x14\x1\x17\xA"+
				"\x22\x1\x3\x1\x13\x1\x19\x1\x18\x1\x1A\x2\xFFFF\x1A\x24\x1\x6\x1\xFFFF"+
				"\x1\x7\x1\xFFFF\x1\x20\x1\xFFFF\x1\x1D\x1\xD\x1\x24\x1\xF\x1\xC\x1\x10"+
				"\x2\x24\x1\xA\x2\x24\x1\x11\x1\x24\x1\x1\x1\x21\x4\x24\x1\xB\x1\x24"+
				"\x1\x1E\x1\xE\x3\x24\x1\x8\x1\x1C\x1\x9",
				"\x1\x25",
				"",
				"\x1\x26",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\x28\x7\xFFFF\x1\x29",
				"\x1\x2A\x6\xFFFF\x1\x2B\x9\xFFFF\x1\x2C",
				"\x1\x2D\x1\xFFFF\x1\x2E",
				"\x1\x2F",
				"\x1\x30",
				"\x1\x31",
				"\x1\x32\x5\xFFFF\x1\x33",
				"\x1\x34",
				"",
				"",
				"",
				"",
				"",
				"\x1\x35",
				"",
				"\x1\x38\x1\x37",
				"\x1\x3A",
				"",
				"",
				"\x1\x3C",
				"\x1\x3D",
				"\x0\x3F",
				"",
				"\x1\x40",
				"",
				"",
				"",
				"\x1\x41",
				"",
				"",
				"\xA\x24\x7\xFFFF\x1A\x24\x4\xFFFF\x1\x24\x1\xFFFF\x1A\x24",
				"\xA\x24\x7\xFFFF\x1A\x24\x4\xFFFF\x1\x24\x1\xFFFF\x1A\x24",
				"\x1\x44",
				"\xA\x24\x7\xFFFF\x1A\x24\x4\xFFFF\x1\x24\x1\xFFFF\x1A\x24",
				"\x1\x46",
				"\x1\x47",
				"\x1\x48",
				"\x1\x49",
				"\x1\x4A",
				"\xA\x24\x7\xFFFF\x1A\x24\x4\xFFFF\x1\x24\x1\xFFFF\x1A\x24",
				"\x1\x4C",
				"\x1\x4D",
				"\x1\x4E",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\x4F",
				"\x1\x50",
				"",
				"",
				"\xA\x24\x7\xFFFF\x1A\x24\x4\xFFFF\x1\x24\x1\xFFFF\x1A\x24",
				"\xA\x24\x7\xFFFF\x1A\x24\x4\xFFFF\x1\x24\x1\xFFFF\x1A\x24",
				"",
				"",
				"\x1\x53",
				"",
				"\x1\x54",
				"\x1\x55",
				"\xA\x24\x7\xFFFF\x1A\x24\x4\xFFFF\x1\x24\x1\xFFFF\x1A\x24",
				"\x1\x57",
				"\x1\x58",
				"",
				"\xA\x24\x7\xFFFF\x1A\x24\x4\xFFFF\x1\x24\x1\xFFFF\x1A\x24",
				"\x1\x5A",
				"\xA\x24\x7\xFFFF\x1A\x24\x4\xFFFF\x1\x24\x1\xFFFF\x1A\x24",
				"\x1\x5C",
				"\xA\x24\x7\xFFFF\x1A\x24\x4\xFFFF\x1\x24\x1\xFFFF\x1A\x24",
				"",
				"",
				"\xA\x24\x7\xFFFF\x1A\x24\x4\xFFFF\x1\x24\x1\xFFFF\x1A\x24",
				"\xA\x24\x7\xFFFF\x1A\x24\x4\xFFFF\x1\x24\x1\xFFFF\x1A\x24",
				"\xA\x24\x7\xFFFF\x1A\x24\x4\xFFFF\x1\x24\x1\xFFFF\x1A\x24",
				"",
				"\x1\x61",
				"\x1\x62",
				"",
				"\x1\x63",
				"",
				"\x1\x64",
				"",
				"",
				"",
				"",
				"\xA\x24\x7\xFFFF\x1A\x24\x4\xFFFF\x1\x24\x1\xFFFF\x1A\x24",
				"\xA\x24\x7\xFFFF\x1A\x24\x4\xFFFF\x1\x24\x1\xFFFF\x1A\x24",
				"\x1\x67",
				"\x1\x68",
				"",
				"",
				"\x1\x69",
				"",
				"\x1\x6A",
				"\xA\x24\x7\xFFFF\x1A\x24\x4\xFFFF\x1\x24\x1\xFFFF\x1A\x24",
				""
			};

		private static readonly short[] DFA5_eot = DFA.UnpackEncodedString(DFA5_eotS);
		private static readonly short[] DFA5_eof = DFA.UnpackEncodedString(DFA5_eofS);
		private static readonly char[] DFA5_min = DFA.UnpackEncodedStringToUnsignedChars(DFA5_minS);
		private static readonly char[] DFA5_max = DFA.UnpackEncodedStringToUnsignedChars(DFA5_maxS);
		private static readonly short[] DFA5_accept = DFA.UnpackEncodedString(DFA5_acceptS);
		private static readonly short[] DFA5_special = DFA.UnpackEncodedString(DFA5_specialS);
		private static readonly short[][] DFA5_transition;

		static DFA5()
		{
			int numStates = DFA5_transitionS.Length;
			DFA5_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA5_transition[i] = DFA.UnpackEncodedString(DFA5_transitionS[i]);
			}
		}

		public DFA5( BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition )
			: base(specialStateTransition)
		{
			this.recognizer = recognizer;
			this.decisionNumber = 5;
			this.eot = DFA5_eot;
			this.eof = DFA5_eof;
			this.min = DFA5_min;
			this.max = DFA5_max;
			this.accept = DFA5_accept;
			this.special = DFA5_special;
			this.transition = DFA5_transition;
		}

		public override string Description { get { return "1:1: Tokens : ( NIL | Minus | Assign | LParent | RParent | LCorch | RCorch | LKey | RKey | If | Then | Else | Break | While | Do | For | To | In | End | Let | Comma | DotComma | Dot | Plus | Mult | Div | Equals | NotEquals | GThan | LThan | GEThan | LEThan | And | Or | Type | ArrayOf | Var | Function | Quotes | Underscore | Of | T__54 | INT_CONST | STRING_CONST | SPACE | ID | COMMENTS );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private int SpecialStateTransition5(DFA dfa, int s, IIntStream _input)
	{
		IIntStream input = _input;
		int _s = s;
		switch (s)
		{
			case 0:
				int LA5_31 = input.LA(1);

				s = -1;
				if ( ((LA5_31>='\u0000' && LA5_31<='\uFFFF')) ) {s = 63;}

				else s = 62;

				if ( s>=0 ) return s;
				break;
		}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 5, _s, input);
		dfa.Error(nvae);
		throw nvae;
	}
 
	#endregion

}
