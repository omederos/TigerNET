// $ANTLR 3.3 Nov 30, 2010 12:45:30 C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g 2012-02-13 02:07:55

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 219
// Unreachable code detected.
#pragma warning disable 162


using TigerNET.AST;


using System.Collections.Generic;
using Antlr.Runtime;
using Stack = System.Collections.Generic.Stack<object>;
using List = System.Collections.IList;
using ArrayList = System.Collections.Generic.List<object>;
using Map = System.Collections.IDictionary;
using HashMap = System.Collections.Generic.Dictionary<object, object>;
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.3 Nov 30, 2010 12:45:30")]
[System.CLSCompliant(false)]
public partial class TigerParser : Antlr.Runtime.Parser
{
	internal static readonly string[] tokenNames = new string[] {
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "NIL", "Minus", "Assign", "LParent", "RParent", "LCorch", "RCorch", "LKey", "RKey", "If", "Then", "Else", "Break", "While", "Do", "For", "To", "In", "End", "Let", "Comma", "DotComma", "Dot", "Plus", "Mult", "Div", "Equals", "NotEquals", "GThan", "LThan", "GEThan", "LEThan", "And", "Or", "Type", "ArrayOf", "Var", "Function", "Quotes", "Underscore", "Of", "DIGIT", "INT_CONST", "CHAR", "SPACE", "ESC", "STRING_CONST", "LETTER", "ID", "COMMENTS", "':'"
	};
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

	// delegates
	// delegators

	#if ANTLR_DEBUG
		private static readonly bool[] decisionCanBacktrack =
			new bool[]
			{
				false, // invalid decision
				false, false, false, false, false, false, false, false, false, false, 
				false, true, false, false, false, false, false, false, false, false, 
				false, false, false, false, false, false, false, false, false
			};
	#else
		private static readonly bool[] decisionCanBacktrack = new bool[0];
	#endif
	public TigerParser( ITokenStream input )
		: this( input, new RecognizerSharedState() )
	{
	}
	public TigerParser(ITokenStream input, RecognizerSharedState state)
		: base(input, state)
	{

		OnCreated();
	}
		

	public override string[] TokenNames { get { return TigerParser.tokenNames; } }
	public override string GrammarFileName { get { return "C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g"; } }


	private IList<string> _errors = new List<string>();
	public IList<string> Errors { get { return _errors; }}

	public override void ReportError(RecognitionException e) {
		Errors.Add(e.ToString());
	}	


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	#region Rules

	partial void Enter_prog();
	partial void Leave_prog();

	// $ANTLR start "prog"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:89:8: public prog returns [ExpressionNode node] : e= expr_or EOF ;
	[GrammarRule("prog")]
	public ExpressionNode prog()
	{
		Enter_prog();
		EnterRule("prog", 1);
		TraceIn("prog", 1);
		ExpressionNode node = default(ExpressionNode);

		ExpressionNode e = default(ExpressionNode);

		try { DebugEnterRule(GrammarFileName, "prog");
		DebugLocation(89, 86);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:89:43: (e= expr_or EOF )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:89:45: e= expr_or EOF
			{
			DebugLocation(89, 47);
			PushFollow(Follow._expr_or_in_prog565);
			e=expr_or();
			PopFollow();
			if (state.failed) return node;
			DebugLocation(89, 57);
			Match(input,EOF,Follow._EOF_in_prog567); if (state.failed) return node;
			DebugLocation(89, 61);
			if ( state.backtracking == 0 )
			{
				 node = e; 
			}

			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("prog", 1);
			LeaveRule("prog", 1);
			Leave_prog();
		}
		DebugLocation(89, 86);
		} finally { DebugExitRule(GrammarFileName, "prog"); }
		return node;

	}
	// $ANTLR end "prog"


	partial void Enter_expr_or();
	partial void Leave_expr_or();

	// $ANTLR start "expr_or"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:90:1: expr_or returns [ExpressionNode node] : left= expr_and ( Or right= expr_or )? ;
	[GrammarRule("expr_or")]
	private ExpressionNode expr_or()
	{
		Enter_expr_or();
		EnterRule("expr_or", 2);
		TraceIn("expr_or", 2);
		ExpressionNode node = default(ExpressionNode);

		ExpressionNode left = default(ExpressionNode);
		ExpressionNode right = default(ExpressionNode);

		try { DebugEnterRule(GrammarFileName, "expr_or");
		DebugLocation(90, 3);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:90:39: (left= expr_and ( Or right= expr_or )? )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:90:41: left= expr_and ( Or right= expr_or )?
			{
			DebugLocation(90, 46);
			PushFollow(Follow._expr_and_in_expr_or584);
			left=expr_and();
			PopFollow();
			if (state.failed) return node;
			DebugLocation(91, 1);
			if ( state.backtracking == 0 )
			{

				/* Left */
				node = left; 

			}
			DebugLocation(95, 1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:95:1: ( Or right= expr_or )?
			int alt1=2;
			try { DebugEnterSubRule(1);
			try { DebugEnterDecision(1, decisionCanBacktrack[1]);
			int LA1_0 = input.LA(1);

			if ((LA1_0==Or))
			{
				alt1=1;
			}
			} finally { DebugExitDecision(1); }
			switch (alt1)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:95:2: Or right= expr_or
				{
				DebugLocation(95, 2);
				Match(input,Or,Follow._Or_in_expr_or590); if (state.failed) return node;
				DebugLocation(95, 11);
				PushFollow(Follow._expr_or_in_expr_or596);
				right=expr_or();
				PopFollow();
				if (state.failed) return node;
				DebugLocation(96, 1);
				if ( state.backtracking == 0 )
				{

					var orOperatorNode = new OrOperatorNode(node, right);
					node = orOperatorNode;

				}

				}
				break;

			}
			} finally { DebugExitSubRule(1); }


			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("expr_or", 2);
			LeaveRule("expr_or", 2);
			Leave_expr_or();
		}
		DebugLocation(99, 3);
		} finally { DebugExitRule(GrammarFileName, "expr_or"); }
		return node;

	}
	// $ANTLR end "expr_or"


	partial void Enter_expr_and();
	partial void Leave_expr_and();

	// $ANTLR start "expr_and"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:100:1: expr_and returns [ExpressionNode node] : left= expr_logical ( And right= expr_and )? ;
	[GrammarRule("expr_and")]
	private ExpressionNode expr_and()
	{
		Enter_expr_and();
		EnterRule("expr_and", 3);
		TraceIn("expr_and", 3);
		ExpressionNode node = default(ExpressionNode);

		ExpressionNode left = default(ExpressionNode);
		ExpressionNode right = default(ExpressionNode);

		try { DebugEnterRule(GrammarFileName, "expr_and");
		DebugLocation(100, 2);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:100:39: (left= expr_logical ( And right= expr_and )? )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:100:41: left= expr_logical ( And right= expr_and )?
			{
			DebugLocation(100, 46);
			PushFollow(Follow._expr_logical_in_expr_and615);
			left=expr_logical();
			PopFollow();
			if (state.failed) return node;
			DebugLocation(101, 1);
			if ( state.backtracking == 0 )
			{

				node = left;

			}
			DebugLocation(104, 1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:104:1: ( And right= expr_and )?
			int alt2=2;
			try { DebugEnterSubRule(2);
			try { DebugEnterDecision(2, decisionCanBacktrack[2]);
			int LA2_0 = input.LA(1);

			if ((LA2_0==And))
			{
				alt2=1;
			}
			} finally { DebugExitDecision(2); }
			switch (alt2)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:104:2: And right= expr_and
				{
				DebugLocation(104, 2);
				Match(input,And,Follow._And_in_expr_and622); if (state.failed) return node;
				DebugLocation(104, 12);
				PushFollow(Follow._expr_and_in_expr_and628);
				right=expr_and();
				PopFollow();
				if (state.failed) return node;
				DebugLocation(105, 1);
				if ( state.backtracking == 0 )
				{

					var andOperatorNode = new AndOperatorNode(node, right);
					node = andOperatorNode;

				}

				}
				break;

			}
			} finally { DebugExitSubRule(2); }


			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("expr_and", 3);
			LeaveRule("expr_and", 3);
			Leave_expr_and();
		}
		DebugLocation(109, 2);
		} finally { DebugExitRule(GrammarFileName, "expr_and"); }
		return node;

	}
	// $ANTLR end "expr_and"


	partial void Enter_expr_logical();
	partial void Leave_expr_logical();

	// $ANTLR start "expr_logical"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:110:1: expr_logical returns [ExpressionNode node] : left= expr_arithm ( ( ( Equals ) | NotEquals | GThan | LThan | GEThan | LEThan ) right= expr_logical )? ;
	[GrammarRule("expr_logical")]
	private ExpressionNode expr_logical()
	{
		Enter_expr_logical();
		EnterRule("expr_logical", 4);
		TraceIn("expr_logical", 4);
		ExpressionNode node = default(ExpressionNode);

		ExpressionNode left = default(ExpressionNode);
		ExpressionNode right = default(ExpressionNode);

		RelationalBinaryOperatorNode n = null;
		try { DebugEnterRule(GrammarFileName, "expr_logical");
		DebugLocation(110, 3);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:112:2: (left= expr_arithm ( ( ( Equals ) | NotEquals | GThan | LThan | GEThan | LEThan ) right= expr_logical )? )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:112:4: left= expr_arithm ( ( ( Equals ) | NotEquals | GThan | LThan | GEThan | LEThan ) right= expr_logical )?
			{
			DebugLocation(112, 9);
			PushFollow(Follow._expr_arithm_in_expr_logical656);
			left=expr_arithm();
			PopFollow();
			if (state.failed) return node;
			DebugLocation(113, 1);
			if ( state.backtracking == 0 )
			{

				node = left; 

			}
			DebugLocation(116, 2);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:116:2: ( ( ( Equals ) | NotEquals | GThan | LThan | GEThan | LEThan ) right= expr_logical )?
			int alt4=2;
			try { DebugEnterSubRule(4);
			try { DebugEnterDecision(4, decisionCanBacktrack[4]);
			switch (input.LA(1))
			{
			case Equals:
				{
				alt4=1;
				}
				break;
			case NotEquals:
				{
				alt4=1;
				}
				break;
			case GThan:
				{
				alt4=1;
				}
				break;
			case LThan:
				{
				alt4=1;
				}
				break;
			case GEThan:
				{
				alt4=1;
				}
				break;
			case LEThan:
				{
				alt4=1;
				}
				break;
			}

			} finally { DebugExitDecision(4); }
			switch (alt4)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:118:2: ( ( Equals ) | NotEquals | GThan | LThan | GEThan | LEThan ) right= expr_logical
				{
				DebugLocation(118, 2);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:118:2: ( ( Equals ) | NotEquals | GThan | LThan | GEThan | LEThan )
				int alt3=6;
				try { DebugEnterSubRule(3);
				try { DebugEnterDecision(3, decisionCanBacktrack[3]);
				switch (input.LA(1))
				{
				case Equals:
					{
					alt3=1;
					}
					break;
				case NotEquals:
					{
					alt3=2;
					}
					break;
				case GThan:
					{
					alt3=3;
					}
					break;
				case LThan:
					{
					alt3=4;
					}
					break;
				case GEThan:
					{
					alt3=5;
					}
					break;
				case LEThan:
					{
					alt3=6;
					}
					break;
				default:
					{
						if (state.backtracking>0) {state.failed=true; return node;}
						NoViableAltException nvae = new NoViableAltException("", 3, 0, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
				}

				} finally { DebugExitDecision(3); }
				switch (alt3)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:118:3: ( Equals )
					{
					DebugLocation(118, 3);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:118:3: ( Equals )
					DebugEnterAlt(1);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:118:4: Equals
					{
					DebugLocation(118, 4);
					Match(input,Equals,Follow._Equals_in_expr_logical669); if (state.failed) return node;
					DebugLocation(119, 2);
					if ( state.backtracking == 0 )
					{

							n = new EqualOperatorNode() { Left = node };
							
					}

					}


					}
					break;
				case 2:
					DebugEnterAlt(2);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:122:2: NotEquals
					{
					DebugLocation(122, 2);
					Match(input,NotEquals,Follow._NotEquals_in_expr_logical680); if (state.failed) return node;
					DebugLocation(123, 2);
					if ( state.backtracking == 0 )
					{

							n = new NotEqualOperatorNode() { Left = node };
							
					}

					}
					break;
				case 3:
					DebugEnterAlt(3);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:126:2: GThan
					{
					DebugLocation(126, 2);
					Match(input,GThan,Follow._GThan_in_expr_logical689); if (state.failed) return node;
					DebugLocation(126, 8);
					if ( state.backtracking == 0 )
					{

							n = new GreatherOperatorNode() { Left = node };
							
					}

					}
					break;
				case 4:
					DebugEnterAlt(4);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:129:2: LThan
					{
					DebugLocation(129, 2);
					Match(input,LThan,Follow._LThan_in_expr_logical696); if (state.failed) return node;
					DebugLocation(130, 2);
					if ( state.backtracking == 0 )
					{

							n = new LowerOperatorNode() { Left = node };
							
					}

					}
					break;
				case 5:
					DebugEnterAlt(5);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:133:2: GEThan
					{
					DebugLocation(133, 2);
					Match(input,GEThan,Follow._GEThan_in_expr_logical705); if (state.failed) return node;
					DebugLocation(134, 2);
					if ( state.backtracking == 0 )
					{

							n = new GreatherEqualOperatorNode() { Left = node };
							
					}

					}
					break;
				case 6:
					DebugEnterAlt(6);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:137:2: LEThan
					{
					DebugLocation(137, 2);
					Match(input,LEThan,Follow._LEThan_in_expr_logical714); if (state.failed) return node;
					DebugLocation(138, 2);
					if ( state.backtracking == 0 )
					{

							n = new LowerEqualOperatorNode() { Left = node };	
							
					}

					}
					break;

				}
				} finally { DebugExitSubRule(3); }

				DebugLocation(141, 10);
				PushFollow(Follow._expr_logical_in_expr_logical727);
				right=expr_logical();
				PopFollow();
				if (state.failed) return node;
				DebugLocation(142, 2);
				if ( state.backtracking == 0 )
				{

						n.Right = right;
						
				}

				}
				break;

			}
			} finally { DebugExitSubRule(4); }


			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("expr_logical", 4);
			LeaveRule("expr_logical", 4);
			Leave_expr_logical();
		}
		DebugLocation(146, 3);
		} finally { DebugExitRule(GrammarFileName, "expr_logical"); }
		return node;

	}
	// $ANTLR end "expr_logical"


	partial void Enter_expr_arithm();
	partial void Leave_expr_arithm();

	// $ANTLR start "expr_arithm"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:147:1: expr_arithm returns [ExpressionNode node] : left= expr_factor ( ( ( Plus ) | Minus ) right= expr_arithm )? ;
	[GrammarRule("expr_arithm")]
	private ExpressionNode expr_arithm()
	{
		Enter_expr_arithm();
		EnterRule("expr_arithm", 5);
		TraceIn("expr_arithm", 5);
		ExpressionNode node = default(ExpressionNode);

		ExpressionNode left = default(ExpressionNode);
		ExpressionNode right = default(ExpressionNode);

		ArithmeticalBinaryOperatorNode n = null;
		try { DebugEnterRule(GrammarFileName, "expr_arithm");
		DebugLocation(147, 3);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:149:2: (left= expr_factor ( ( ( Plus ) | Minus ) right= expr_arithm )? )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:149:4: left= expr_factor ( ( ( Plus ) | Minus ) right= expr_arithm )?
			{
			DebugLocation(149, 9);
			PushFollow(Follow._expr_factor_in_expr_arithm758);
			left=expr_factor();
			PopFollow();
			if (state.failed) return node;
			DebugLocation(149, 23);
			if ( state.backtracking == 0 )
			{
				node = left;
			}
			DebugLocation(150, 2);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:150:2: ( ( ( Plus ) | Minus ) right= expr_arithm )?
			int alt6=2;
			try { DebugEnterSubRule(6);
			try { DebugEnterDecision(6, decisionCanBacktrack[6]);
			int LA6_0 = input.LA(1);

			if ((LA6_0==Plus))
			{
				alt6=1;
			}
			else if ((LA6_0==Minus))
			{
				alt6=1;
			}
			} finally { DebugExitDecision(6); }
			switch (alt6)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:151:2: ( ( Plus ) | Minus ) right= expr_arithm
				{
				DebugLocation(151, 2);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:151:2: ( ( Plus ) | Minus )
				int alt5=2;
				try { DebugEnterSubRule(5);
				try { DebugEnterDecision(5, decisionCanBacktrack[5]);
				int LA5_0 = input.LA(1);

				if ((LA5_0==Plus))
				{
					alt5=1;
				}
				else if ((LA5_0==Minus))
				{
					alt5=2;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return node;}
					NoViableAltException nvae = new NoViableAltException("", 5, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
				} finally { DebugExitDecision(5); }
				switch (alt5)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:152:2: ( Plus )
					{
					DebugLocation(152, 2);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:152:2: ( Plus )
					DebugEnterAlt(1);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:152:3: Plus
					{
					DebugLocation(152, 3);
					Match(input,Plus,Follow._Plus_in_expr_arithm771); if (state.failed) return node;

					}

					DebugLocation(153, 2);
					if ( state.backtracking == 0 )
					{

							n = new PlusOperatorNode() { Left = node };
							
					}

					}
					break;
				case 2:
					DebugEnterAlt(2);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:156:2: Minus
					{
					DebugLocation(156, 2);
					Match(input,Minus,Follow._Minus_in_expr_arithm782); if (state.failed) return node;
					DebugLocation(157, 2);
					if ( state.backtracking == 0 )
					{

							n = new MinusOperatorNode() { Left = node };
							
					}

					}
					break;

				}
				} finally { DebugExitSubRule(5); }

				DebugLocation(160, 10);
				PushFollow(Follow._expr_arithm_in_expr_arithm794);
				right=expr_arithm();
				PopFollow();
				if (state.failed) return node;
				DebugLocation(160, 24);
				if ( state.backtracking == 0 )
				{
					n.Right = right;
				}

				}
				break;

			}
			} finally { DebugExitSubRule(6); }


			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("expr_arithm", 5);
			LeaveRule("expr_arithm", 5);
			Leave_expr_arithm();
		}
		DebugLocation(161, 3);
		} finally { DebugExitRule(GrammarFileName, "expr_arithm"); }
		return node;

	}
	// $ANTLR end "expr_arithm"


	partial void Enter_expr_factor();
	partial void Leave_expr_factor();

	// $ANTLR start "expr_factor"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:162:1: expr_factor returns [ExpressionNode node] : left= expr ( ( ( Mult ) | Div ) right= expr_factor )? ;
	[GrammarRule("expr_factor")]
	private ExpressionNode expr_factor()
	{
		Enter_expr_factor();
		EnterRule("expr_factor", 6);
		TraceIn("expr_factor", 6);
		ExpressionNode node = default(ExpressionNode);

		ExpressionNode left = default(ExpressionNode);
		ExpressionNode right = default(ExpressionNode);

		ArithmeticalBinaryOperatorNode n = null;
		try { DebugEnterRule(GrammarFileName, "expr_factor");
		DebugLocation(162, 3);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:164:2: (left= expr ( ( ( Mult ) | Div ) right= expr_factor )? )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:164:4: left= expr ( ( ( Mult ) | Div ) right= expr_factor )?
			{
			DebugLocation(164, 9);
			PushFollow(Follow._expr_in_expr_factor821);
			left=expr();
			PopFollow();
			if (state.failed) return node;
			DebugLocation(164, 16);
			if ( state.backtracking == 0 )
			{
				node = left; 
			}
			DebugLocation(165, 2);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:165:2: ( ( ( Mult ) | Div ) right= expr_factor )?
			int alt8=2;
			try { DebugEnterSubRule(8);
			try { DebugEnterDecision(8, decisionCanBacktrack[8]);
			int LA8_0 = input.LA(1);

			if ((LA8_0==Mult))
			{
				alt8=1;
			}
			else if ((LA8_0==Div))
			{
				alt8=1;
			}
			} finally { DebugExitDecision(8); }
			switch (alt8)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:166:2: ( ( Mult ) | Div ) right= expr_factor
				{
				DebugLocation(166, 2);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:166:2: ( ( Mult ) | Div )
				int alt7=2;
				try { DebugEnterSubRule(7);
				try { DebugEnterDecision(7, decisionCanBacktrack[7]);
				int LA7_0 = input.LA(1);

				if ((LA7_0==Mult))
				{
					alt7=1;
				}
				else if ((LA7_0==Div))
				{
					alt7=2;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return node;}
					NoViableAltException nvae = new NoViableAltException("", 7, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
				} finally { DebugExitDecision(7); }
				switch (alt7)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:167:2: ( Mult )
					{
					DebugLocation(167, 2);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:167:2: ( Mult )
					DebugEnterAlt(1);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:167:3: Mult
					{
					DebugLocation(167, 3);
					Match(input,Mult,Follow._Mult_in_expr_factor833); if (state.failed) return node;

					}

					DebugLocation(168, 2);
					if ( state.backtracking == 0 )
					{

							n = new ProdOperatorNode() { Left = node };
							
					}

					}
					break;
				case 2:
					DebugEnterAlt(2);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:171:2: Div
					{
					DebugLocation(171, 2);
					Match(input,Div,Follow._Div_in_expr_factor843); if (state.failed) return node;
					DebugLocation(172, 2);
					if ( state.backtracking == 0 )
					{

							n = new DivOperatorNode() { Left = node };
							
					}

					}
					break;

				}
				} finally { DebugExitSubRule(7); }

				DebugLocation(175, 10);
				PushFollow(Follow._expr_factor_in_expr_factor856);
				right=expr_factor();
				PopFollow();
				if (state.failed) return node;
				DebugLocation(175, 24);
				if ( state.backtracking == 0 )
				{
					n.Right = right;
				}

				}
				break;

			}
			} finally { DebugExitSubRule(8); }


			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("expr_factor", 6);
			LeaveRule("expr_factor", 6);
			Leave_expr_factor();
		}
		DebugLocation(176, 3);
		} finally { DebugExitRule(GrammarFileName, "expr_factor"); }
		return node;

	}
	// $ANTLR end "expr_factor"


	partial void Enter_expr();
	partial void Leave_expr();

	// $ANTLR start "expr"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:177:1: expr returns [ExpressionNode node] : ( STRING_CONST | INT_CONST | NIL | Minus e= expr_or | id= ID ( LParent (list= exprList )? RParent | ( ( LKey RKey )=> LKey RKey | LKey fields= fieldList RKey ) | ( ( LCorch expr_or RCorch Of )=> ( LCorch length= expr_or RCorch Of initialValue= expr_or ) | lv= lvalue[$node] ( Assign body= expr_or )? ) ) | LParent ( exprSeq )? RParent | If cond= expr_or Then then= expr_or ( Else els= expr_or )? | While cond= expr_or Do body= expr_or | For ID Assign start= expr_or To end= expr_or Do bodyFor= expr_or | Break | Let declarations= declarationList In (items= exprSeq )? End ) lvalue[$node] ;
	[GrammarRule("expr")]
	private ExpressionNode expr()
	{
		Enter_expr();
		EnterRule("expr", 7);
		TraceIn("expr", 7);
		ExpressionNode node = default(ExpressionNode);

		IToken id=null;
		IToken STRING_CONST1=null;
		IToken INT_CONST2=null;
		ExpressionNode e = default(ExpressionNode);
		IList<ExpressionNode> list = default(IList<ExpressionNode>);
		IList<FieldAssignmentNode> fields = default(IList<FieldAssignmentNode>);
		ExpressionNode length = default(ExpressionNode);
		ExpressionNode initialValue = default(ExpressionNode);
		ExpressionNode lv = default(ExpressionNode);
		ExpressionNode body = default(ExpressionNode);
		ExpressionNode cond = default(ExpressionNode);
		ExpressionNode then = default(ExpressionNode);
		ExpressionNode els = default(ExpressionNode);
		ExpressionNode start = default(ExpressionNode);
		ExpressionNode end = default(ExpressionNode);
		ExpressionNode bodyFor = default(ExpressionNode);
		IList<DeclarationNode> declarations = default(IList<DeclarationNode>);
		IList<ExpressionNode> items = default(IList<ExpressionNode>);

		try { DebugEnterRule(GrammarFileName, "expr");
		DebugLocation(177, 15);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:177:35: ( ( STRING_CONST | INT_CONST | NIL | Minus e= expr_or | id= ID ( LParent (list= exprList )? RParent | ( ( LKey RKey )=> LKey RKey | LKey fields= fieldList RKey ) | ( ( LCorch expr_or RCorch Of )=> ( LCorch length= expr_or RCorch Of initialValue= expr_or ) | lv= lvalue[$node] ( Assign body= expr_or )? ) ) | LParent ( exprSeq )? RParent | If cond= expr_or Then then= expr_or ( Else els= expr_or )? | While cond= expr_or Do body= expr_or | For ID Assign start= expr_or To end= expr_or Do bodyFor= expr_or | Break | Let declarations= declarationList In (items= exprSeq )? End ) lvalue[$node] )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:178:2: ( STRING_CONST | INT_CONST | NIL | Minus e= expr_or | id= ID ( LParent (list= exprList )? RParent | ( ( LKey RKey )=> LKey RKey | LKey fields= fieldList RKey ) | ( ( LCorch expr_or RCorch Of )=> ( LCorch length= expr_or RCorch Of initialValue= expr_or ) | lv= lvalue[$node] ( Assign body= expr_or )? ) ) | LParent ( exprSeq )? RParent | If cond= expr_or Then then= expr_or ( Else els= expr_or )? | While cond= expr_or Do body= expr_or | For ID Assign start= expr_or To end= expr_or Do bodyFor= expr_or | Break | Let declarations= declarationList In (items= exprSeq )? End ) lvalue[$node]
			{
			DebugLocation(178, 2);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:178:2: ( STRING_CONST | INT_CONST | NIL | Minus e= expr_or | id= ID ( LParent (list= exprList )? RParent | ( ( LKey RKey )=> LKey RKey | LKey fields= fieldList RKey ) | ( ( LCorch expr_or RCorch Of )=> ( LCorch length= expr_or RCorch Of initialValue= expr_or ) | lv= lvalue[$node] ( Assign body= expr_or )? ) ) | LParent ( exprSeq )? RParent | If cond= expr_or Then then= expr_or ( Else els= expr_or )? | While cond= expr_or Do body= expr_or | For ID Assign start= expr_or To end= expr_or Do bodyFor= expr_or | Break | Let declarations= declarationList In (items= exprSeq )? End )
			int alt17=11;
			try { DebugEnterSubRule(17);
			try { DebugEnterDecision(17, decisionCanBacktrack[17]);
			switch (input.LA(1))
			{
			case STRING_CONST:
				{
				alt17=1;
				}
				break;
			case INT_CONST:
				{
				alt17=2;
				}
				break;
			case NIL:
				{
				alt17=3;
				}
				break;
			case Minus:
				{
				alt17=4;
				}
				break;
			case ID:
				{
				alt17=5;
				}
				break;
			case LParent:
				{
				alt17=6;
				}
				break;
			case If:
				{
				alt17=7;
				}
				break;
			case While:
				{
				alt17=8;
				}
				break;
			case For:
				{
				alt17=9;
				}
				break;
			case Break:
				{
				alt17=10;
				}
				break;
			case Let:
				{
				alt17=11;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return node;}
					NoViableAltException nvae = new NoViableAltException("", 17, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(17); }
			switch (alt17)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:178:3: STRING_CONST
				{
				DebugLocation(178, 3);
				STRING_CONST1=(IToken)Match(input,STRING_CONST,Follow._STRING_CONST_in_expr875); if (state.failed) return node;
				DebugLocation(178, 16);
				if ( state.backtracking == 0 )
				{
					node = new StringLiteralNode(STRING_CONST1.Text); 
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:179:2: INT_CONST
				{
				DebugLocation(179, 2);
				INT_CONST2=(IToken)Match(input,INT_CONST,Follow._INT_CONST_in_expr883); if (state.failed) return node;
				DebugLocation(179, 12);
				if ( state.backtracking == 0 )
				{
					node = new IntegerLiteralNode(int.Parse(INT_CONST2.Text)); 
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:180:2: NIL
				{
				DebugLocation(180, 2);
				Match(input,NIL,Follow._NIL_in_expr891); if (state.failed) return node;
				DebugLocation(180, 6);
				if ( state.backtracking == 0 )
				{
					node = new NilLiteralNode(); 
				}

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:181:2: Minus e= expr_or
				{
				DebugLocation(181, 2);
				Match(input,Minus,Follow._Minus_in_expr899); if (state.failed) return node;
				DebugLocation(181, 10);
				PushFollow(Follow._expr_or_in_expr905);
				e=expr_or();
				PopFollow();
				if (state.failed) return node;
				DebugLocation(181, 20);
				if ( state.backtracking == 0 )
				{
					node = new MinusUnaryOperatorNode(e); 
				}

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:185:2: id= ID ( LParent (list= exprList )? RParent | ( ( LKey RKey )=> LKey RKey | LKey fields= fieldList RKey ) | ( ( LCorch expr_or RCorch Of )=> ( LCorch length= expr_or RCorch Of initialValue= expr_or ) | lv= lvalue[$node] ( Assign body= expr_or )? ) )
				{
				DebugLocation(185, 5);
				id=(IToken)Match(input,ID,Follow._ID_in_expr930); if (state.failed) return node;
				DebugLocation(185, 10);
				if ( state.backtracking == 0 )
				{
					node = new VariableAccessNode(id.Text); 
				}
				DebugLocation(186, 2);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:186:2: ( LParent (list= exprList )? RParent | ( ( LKey RKey )=> LKey RKey | LKey fields= fieldList RKey ) | ( ( LCorch expr_or RCorch Of )=> ( LCorch length= expr_or RCorch Of initialValue= expr_or ) | lv= lvalue[$node] ( Assign body= expr_or )? ) )
				int alt13=3;
				try { DebugEnterSubRule(13);
				try { DebugEnterDecision(13, decisionCanBacktrack[13]);
				switch (input.LA(1))
				{
				case LParent:
					{
					alt13=1;
					}
					break;
				case LKey:
					{
					alt13=2;
					}
					break;
				case EOF:
				case Minus:
				case Assign:
				case RParent:
				case LCorch:
				case RCorch:
				case RKey:
				case Then:
				case Else:
				case Do:
				case To:
				case In:
				case End:
				case Comma:
				case DotComma:
				case Dot:
				case Plus:
				case Mult:
				case Div:
				case Equals:
				case NotEquals:
				case GThan:
				case LThan:
				case GEThan:
				case LEThan:
				case And:
				case Or:
				case Type:
				case Var:
				case Function:
					{
					alt13=3;
					}
					break;
				default:
					{
						if (state.backtracking>0) {state.failed=true; return node;}
						NoViableAltException nvae = new NoViableAltException("", 13, 0, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
				}

				} finally { DebugExitDecision(13); }
				switch (alt13)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:187:3: LParent (list= exprList )? RParent
					{
					DebugLocation(187, 3);
					Match(input,LParent,Follow._LParent_in_expr939); if (state.failed) return node;
					DebugLocation(187, 11);
					if ( state.backtracking == 0 )
					{
						node = new CallableNode(id.Text, new List<ExpressionNode>()); 
					}
					DebugLocation(187, 77);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:187:77: (list= exprList )?
					int alt9=2;
					try { DebugEnterSubRule(9);
					try { DebugEnterDecision(9, decisionCanBacktrack[9]);
					int LA9_0 = input.LA(1);

					if (((LA9_0>=NIL && LA9_0<=Minus)||LA9_0==LParent||LA9_0==If||(LA9_0>=Break && LA9_0<=While)||LA9_0==For||LA9_0==Let||LA9_0==INT_CONST||LA9_0==STRING_CONST||LA9_0==ID))
					{
						alt9=1;
					}
					} finally { DebugExitDecision(9); }
					switch (alt9)
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:187:78: list= exprList
						{
						DebugLocation(187, 83);
						PushFollow(Follow._exprList_in_expr947);
						list=exprList();
						PopFollow();
						if (state.failed) return node;
						DebugLocation(187, 94);
						if ( state.backtracking == 0 )
						{
							 node = new CallableNode(id.Text, list); 
						}

						}
						break;

					}
					} finally { DebugExitSubRule(9); }

					DebugLocation(187, 150);
					Match(input,RParent,Follow._RParent_in_expr954); if (state.failed) return node;
					DebugLocation(188, 3);
					if ( state.backtracking == 0 )
					{

								
					}

					}
					break;
				case 2:
					DebugEnterAlt(2);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:190:3: ( ( LKey RKey )=> LKey RKey | LKey fields= fieldList RKey )
					{
					DebugLocation(190, 3);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:190:3: ( ( LKey RKey )=> LKey RKey | LKey fields= fieldList RKey )
					int alt10=2;
					try { DebugEnterSubRule(10);
					try { DebugEnterDecision(10, decisionCanBacktrack[10]);
					int LA10_0 = input.LA(1);

					if ((LA10_0==LKey))
					{
						int LA10_1 = input.LA(2);

						if ((LA10_1==RKey) && (EvaluatePredicate(synpred1_Tiger_fragment)))
						{
							alt10=1;
						}
						else if ((LA10_1==ID))
						{
							alt10=2;
						}
						else
						{
							if (state.backtracking>0) {state.failed=true; return node;}
							NoViableAltException nvae = new NoViableAltException("", 10, 1, input);

							DebugRecognitionException(nvae);
							throw nvae;
						}
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return node;}
						NoViableAltException nvae = new NoViableAltException("", 10, 0, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
					} finally { DebugExitDecision(10); }
					switch (alt10)
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:191:4: ( LKey RKey )=> LKey RKey
						{
						DebugLocation(192, 6);
						Match(input,LKey,Follow._LKey_in_expr984); if (state.failed) return node;
						DebugLocation(192, 11);
						Match(input,RKey,Follow._RKey_in_expr986); if (state.failed) return node;
						DebugLocation(192, 16);
						if ( state.backtracking == 0 )
						{
							node = new RecordLiteralNode(id.Text, new List<FieldAssignmentNode>()); 
						}

						}
						break;
					case 2:
						DebugEnterAlt(2);
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:193:6: LKey fields= fieldList RKey
						{
						DebugLocation(193, 6);
						Match(input,LKey,Follow._LKey_in_expr996); if (state.failed) return node;
						DebugLocation(193, 18);
						PushFollow(Follow._fieldList_in_expr1002);
						fields=fieldList();
						PopFollow();
						if (state.failed) return node;
						DebugLocation(194, 6);
						if ( state.backtracking == 0 )
						{

											 node = new RecordLiteralNode(id.Text, fields);
											 
						}
						DebugLocation(197, 6);
						Match(input,RKey,Follow._RKey_in_expr1018); if (state.failed) return node;

						}
						break;

					}
					} finally { DebugExitSubRule(10); }


					}
					break;
				case 3:
					DebugEnterAlt(3);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:199:3: ( ( LCorch expr_or RCorch Of )=> ( LCorch length= expr_or RCorch Of initialValue= expr_or ) | lv= lvalue[$node] ( Assign body= expr_or )? )
					{
					DebugLocation(199, 3);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:199:3: ( ( LCorch expr_or RCorch Of )=> ( LCorch length= expr_or RCorch Of initialValue= expr_or ) | lv= lvalue[$node] ( Assign body= expr_or )? )
					int alt12=2;
					try { DebugEnterSubRule(12);
					try { DebugEnterDecision(12, decisionCanBacktrack[12]);
					try
					{
						alt12 = dfa12.Predict(input);
					}
					catch (NoViableAltException nvae)
					{
						DebugRecognitionException(nvae);
						throw;
					}
					} finally { DebugExitDecision(12); }
					switch (alt12)
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:199:4: ( LCorch expr_or RCorch Of )=> ( LCorch length= expr_or RCorch Of initialValue= expr_or )
						{
						DebugLocation(200, 3);
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:200:3: ( LCorch length= expr_or RCorch Of initialValue= expr_or )
						DebugEnterAlt(1);
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:201:3: LCorch length= expr_or RCorch Of initialValue= expr_or
						{
						DebugLocation(201, 3);
						Match(input,LCorch,Follow._LCorch_in_expr1047); if (state.failed) return node;
						DebugLocation(201, 17);
						PushFollow(Follow._expr_or_in_expr1053);
						length=expr_or();
						PopFollow();
						if (state.failed) return node;
						DebugLocation(201, 27);
						Match(input,RCorch,Follow._RCorch_in_expr1055); if (state.failed) return node;
						DebugLocation(201, 34);
						Match(input,Of,Follow._Of_in_expr1057); if (state.failed) return node;
						DebugLocation(201, 50);
						PushFollow(Follow._expr_or_in_expr1063);
						initialValue=expr_or();
						PopFollow();
						if (state.failed) return node;
						DebugLocation(202, 3);
						if ( state.backtracking == 0 )
						{

									node = new ArrayLiteralNode(id.Text, length, initialValue); 
									
						}

						}


						}
						break;
					case 2:
						DebugEnterAlt(2);
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:206:3: lv= lvalue[$node] ( Assign body= expr_or )?
						{
						DebugLocation(206, 6);
						PushFollow(Follow._lvalue_in_expr1083);
						lv=lvalue(node);
						PopFollow();
						if (state.failed) return node;
						DebugLocation(206, 22);
						if ( state.backtracking == 0 )
						{
							node = lv; 
						}
						DebugLocation(206, 42);
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:206:42: ( Assign body= expr_or )?
						int alt11=2;
						try { DebugEnterSubRule(11);
						try { DebugEnterDecision(11, decisionCanBacktrack[11]);
						int LA11_0 = input.LA(1);

						if ((LA11_0==Assign))
						{
							alt11=1;
						}
						} finally { DebugExitDecision(11); }
						switch (alt11)
						{
						case 1:
							DebugEnterAlt(1);
							// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:206:43: Assign body= expr_or
							{
							DebugLocation(206, 43);
							Match(input,Assign,Follow._Assign_in_expr1088); if (state.failed) return node;
							DebugLocation(206, 55);
							PushFollow(Follow._expr_or_in_expr1094);
							body=expr_or();
							PopFollow();
							if (state.failed) return node;
							DebugLocation(206, 65);
							if ( state.backtracking == 0 )
							{
								node = new AssignmentNode((AccessNode)node, body);
							}

							}
							break;

						}
						} finally { DebugExitSubRule(11); }


						}
						break;

					}
					} finally { DebugExitSubRule(12); }


					}
					break;

				}
				} finally { DebugExitSubRule(13); }


				}
				break;
			case 6:
				DebugEnterAlt(6);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:209:2: LParent ( exprSeq )? RParent
				{
				DebugLocation(209, 2);
				Match(input,LParent,Follow._LParent_in_expr1110); if (state.failed) return node;
				DebugLocation(209, 10);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:209:10: ( exprSeq )?
				int alt14=2;
				try { DebugEnterSubRule(14);
				try { DebugEnterDecision(14, decisionCanBacktrack[14]);
				int LA14_0 = input.LA(1);

				if (((LA14_0>=NIL && LA14_0<=Minus)||LA14_0==LParent||LA14_0==If||(LA14_0>=Break && LA14_0<=While)||LA14_0==For||LA14_0==Let||LA14_0==INT_CONST||LA14_0==STRING_CONST||LA14_0==ID))
				{
					alt14=1;
				}
				} finally { DebugExitDecision(14); }
				switch (alt14)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:209:11: exprSeq
					{
					DebugLocation(209, 11);
					PushFollow(Follow._exprSeq_in_expr1113);
					exprSeq();
					PopFollow();
					if (state.failed) return node;

					}
					break;

				}
				} finally { DebugExitSubRule(14); }

				DebugLocation(209, 21);
				Match(input,RParent,Follow._RParent_in_expr1117); if (state.failed) return node;

				}
				break;
			case 7:
				DebugEnterAlt(7);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:210:2: If cond= expr_or Then then= expr_or ( Else els= expr_or )?
				{
				DebugLocation(210, 2);
				Match(input,If,Follow._If_in_expr1125); if (state.failed) return node;
				DebugLocation(210, 10);
				PushFollow(Follow._expr_or_in_expr1131);
				cond=expr_or();
				PopFollow();
				if (state.failed) return node;
				DebugLocation(210, 20);
				Match(input,Then,Follow._Then_in_expr1133); if (state.failed) return node;
				DebugLocation(210, 30);
				PushFollow(Follow._expr_or_in_expr1139);
				then=expr_or();
				PopFollow();
				if (state.failed) return node;
				DebugLocation(210, 40);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:210:40: ( Else els= expr_or )?
				int alt15=2;
				try { DebugEnterSubRule(15);
				try { DebugEnterDecision(15, decisionCanBacktrack[15]);
				int LA15_0 = input.LA(1);

				if ((LA15_0==Else))
				{
					alt15=1;
				}
				} finally { DebugExitDecision(15); }
				switch (alt15)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:210:41: Else els= expr_or
					{
					DebugLocation(210, 41);
					Match(input,Else,Follow._Else_in_expr1142); if (state.failed) return node;
					DebugLocation(210, 50);
					PushFollow(Follow._expr_or_in_expr1148);
					els=expr_or();
					PopFollow();
					if (state.failed) return node;

					}
					break;

				}
				} finally { DebugExitSubRule(15); }

				DebugLocation(211, 2);
				if ( state.backtracking == 0 )
				{

						node = new IfThenElseNode(cond, then, els);
						
				}

				}
				break;
			case 8:
				DebugEnterAlt(8);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:214:2: While cond= expr_or Do body= expr_or
				{
				DebugLocation(214, 2);
				Match(input,While,Follow._While_in_expr1163); if (state.failed) return node;
				DebugLocation(214, 13);
				PushFollow(Follow._expr_or_in_expr1169);
				cond=expr_or();
				PopFollow();
				if (state.failed) return node;
				DebugLocation(214, 23);
				Match(input,Do,Follow._Do_in_expr1171); if (state.failed) return node;
				DebugLocation(214, 31);
				PushFollow(Follow._expr_or_in_expr1177);
				body=expr_or();
				PopFollow();
				if (state.failed) return node;
				DebugLocation(215, 2);
				if ( state.backtracking == 0 )
				{

						node = new WhileNode(cond, body);
						
				}

				}
				break;
			case 9:
				DebugEnterAlt(9);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:218:2: For ID Assign start= expr_or To end= expr_or Do bodyFor= expr_or
				{
				DebugLocation(218, 2);
				Match(input,For,Follow._For_in_expr1187); if (state.failed) return node;
				DebugLocation(218, 6);
				Match(input,ID,Follow._ID_in_expr1189); if (state.failed) return node;
				DebugLocation(218, 9);
				Match(input,Assign,Follow._Assign_in_expr1191); if (state.failed) return node;
				DebugLocation(218, 22);
				PushFollow(Follow._expr_or_in_expr1197);
				start=expr_or();
				PopFollow();
				if (state.failed) return node;
				DebugLocation(218, 32);
				Match(input,To,Follow._To_in_expr1199); if (state.failed) return node;
				DebugLocation(218, 39);
				PushFollow(Follow._expr_or_in_expr1205);
				end=expr_or();
				PopFollow();
				if (state.failed) return node;
				DebugLocation(218, 49);
				Match(input,Do,Follow._Do_in_expr1207); if (state.failed) return node;
				DebugLocation(218, 60);
				PushFollow(Follow._expr_or_in_expr1213);
				bodyFor=expr_or();
				PopFollow();
				if (state.failed) return node;
				DebugLocation(219, 2);
				if ( state.backtracking == 0 )
				{

						node = new ForToDoNode(start, end, bodyFor);
						
				}

				}
				break;
			case 10:
				DebugEnterAlt(10);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:222:2: Break
				{
				DebugLocation(222, 2);
				Match(input,Break,Follow._Break_in_expr1223); if (state.failed) return node;
				DebugLocation(222, 8);
				if ( state.backtracking == 0 )
				{
					 node = new BreakNode(); 
				}

				}
				break;
			case 11:
				DebugEnterAlt(11);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:223:2: Let declarations= declarationList In (items= exprSeq )? End
				{
				DebugLocation(223, 2);
				Match(input,Let,Follow._Let_in_expr1232); if (state.failed) return node;
				DebugLocation(223, 19);
				PushFollow(Follow._declarationList_in_expr1238);
				declarations=declarationList();
				PopFollow();
				if (state.failed) return node;
				DebugLocation(223, 37);
				if ( state.backtracking == 0 )
				{
					node = new LetInEndNode(declarations); 
				}
				DebugLocation(223, 87);
				Match(input,In,Follow._In_in_expr1242); if (state.failed) return node;
				DebugLocation(223, 90);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:223:90: (items= exprSeq )?
				int alt16=2;
				try { DebugEnterSubRule(16);
				try { DebugEnterDecision(16, decisionCanBacktrack[16]);
				int LA16_0 = input.LA(1);

				if (((LA16_0>=NIL && LA16_0<=Minus)||LA16_0==LParent||LA16_0==If||(LA16_0>=Break && LA16_0<=While)||LA16_0==For||LA16_0==Let||LA16_0==INT_CONST||LA16_0==STRING_CONST||LA16_0==ID))
				{
					alt16=1;
				}
				} finally { DebugExitDecision(16); }
				switch (alt16)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:223:91: items= exprSeq
					{
					DebugLocation(223, 97);
					PushFollow(Follow._exprSeq_in_expr1249);
					items=exprSeq();
					PopFollow();
					if (state.failed) return node;
					DebugLocation(223, 107);
					if ( state.backtracking == 0 )
					{
						((LetInEndNode)node).Expressions = items; 
					}

					}
					break;

				}
				} finally { DebugExitSubRule(16); }

				DebugLocation(223, 162);
				Match(input,End,Follow._End_in_expr1255); if (state.failed) return node;

				}
				break;

			}
			} finally { DebugExitSubRule(17); }

			DebugLocation(225, 2);
			PushFollow(Follow._lvalue_in_expr1264);
			lvalue(node);
			PopFollow();
			if (state.failed) return node;

			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("expr", 7);
			LeaveRule("expr", 7);
			Leave_expr();
		}
		DebugLocation(225, 15);
		} finally { DebugExitRule(GrammarFileName, "expr"); }
		return node;

	}
	// $ANTLR end "expr"


	partial void Enter_exprSeq();
	partial void Leave_exprSeq();

	// $ANTLR start "exprSeq"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:226:1: exprSeq returns [IList<ExpressionNode> items] : e1= expr_or ( DotComma e2= expr_or )* ;
	[GrammarRule("exprSeq")]
	private IList<ExpressionNode> exprSeq()
	{
		Enter_exprSeq();
		EnterRule("exprSeq", 8);
		TraceIn("exprSeq", 8);
		IList<ExpressionNode> items = default(IList<ExpressionNode>);

		ExpressionNode e1 = default(ExpressionNode);
		ExpressionNode e2 = default(ExpressionNode);

		items = new List<ExpressionNode>();
		try { DebugEnterRule(GrammarFileName, "exprSeq");
		DebugLocation(226, 88);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:228:1: (e1= expr_or ( DotComma e2= expr_or )* )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:228:3: e1= expr_or ( DotComma e2= expr_or )*
			{
			DebugLocation(228, 6);
			PushFollow(Follow._expr_or_in_exprSeq1288);
			e1=expr_or();
			PopFollow();
			if (state.failed) return items;
			DebugLocation(228, 16);
			if ( state.backtracking == 0 )
			{
				items.Add(e1); 
			}
			DebugLocation(228, 40);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:228:40: ( DotComma e2= expr_or )*
			try { DebugEnterSubRule(18);
			while (true)
			{
				int alt18=2;
				try { DebugEnterDecision(18, decisionCanBacktrack[18]);
				int LA18_0 = input.LA(1);

				if ((LA18_0==DotComma))
				{
					alt18=1;
				}


				} finally { DebugExitDecision(18); }
				switch ( alt18 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:228:41: DotComma e2= expr_or
					{
					DebugLocation(228, 41);
					Match(input,DotComma,Follow._DotComma_in_exprSeq1292); if (state.failed) return items;
					DebugLocation(228, 53);
					PushFollow(Follow._expr_or_in_exprSeq1298);
					e2=expr_or();
					PopFollow();
					if (state.failed) return items;
					DebugLocation(228, 63);
					if ( state.backtracking == 0 )
					{
						items.Add(e2); 
					}

					}
					break;

				default:
					goto loop18;
				}
			}

			loop18:
				;

			} finally { DebugExitSubRule(18); }


			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("exprSeq", 8);
			LeaveRule("exprSeq", 8);
			Leave_exprSeq();
		}
		DebugLocation(228, 88);
		} finally { DebugExitRule(GrammarFileName, "exprSeq"); }
		return items;

	}
	// $ANTLR end "exprSeq"


	partial void Enter_exprList();
	partial void Leave_exprList();

	// $ANTLR start "exprList"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:230:1: exprList returns [IList<ExpressionNode> items] : e1= expr_or ( Comma e2= expr_or )* ;
	[GrammarRule("exprList")]
	private IList<ExpressionNode> exprList()
	{
		Enter_exprList();
		EnterRule("exprList", 9);
		TraceIn("exprList", 9);
		IList<ExpressionNode> items = default(IList<ExpressionNode>);

		ExpressionNode e1 = default(ExpressionNode);
		ExpressionNode e2 = default(ExpressionNode);

		items = new List<ExpressionNode>();
		try { DebugEnterRule(GrammarFileName, "exprList");
		DebugLocation(230, 82);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:232:1: (e1= expr_or ( Comma e2= expr_or )* )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:232:3: e1= expr_or ( Comma e2= expr_or )*
			{
			DebugLocation(232, 6);
			PushFollow(Follow._expr_or_in_exprList1326);
			e1=expr_or();
			PopFollow();
			if (state.failed) return items;
			DebugLocation(232, 16);
			if ( state.backtracking == 0 )
			{
				items.Add(e1);
			}
			DebugLocation(232, 39);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:232:39: ( Comma e2= expr_or )*
			try { DebugEnterSubRule(19);
			while (true)
			{
				int alt19=2;
				try { DebugEnterDecision(19, decisionCanBacktrack[19]);
				int LA19_0 = input.LA(1);

				if ((LA19_0==Comma))
				{
					alt19=1;
				}


				} finally { DebugExitDecision(19); }
				switch ( alt19 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:232:40: Comma e2= expr_or
					{
					DebugLocation(232, 40);
					Match(input,Comma,Follow._Comma_in_exprList1331); if (state.failed) return items;
					DebugLocation(232, 49);
					PushFollow(Follow._expr_or_in_exprList1337);
					e2=expr_or();
					PopFollow();
					if (state.failed) return items;
					DebugLocation(232, 59);
					if ( state.backtracking == 0 )
					{
						items.Add(e2);
					}

					}
					break;

				default:
					goto loop19;
				}
			}

			loop19:
				;

			} finally { DebugExitSubRule(19); }


			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("exprList", 9);
			LeaveRule("exprList", 9);
			Leave_exprList();
		}
		DebugLocation(232, 82);
		} finally { DebugExitRule(GrammarFileName, "exprList"); }
		return items;

	}
	// $ANTLR end "exprList"


	partial void Enter_fieldList();
	partial void Leave_fieldList();

	// $ANTLR start "fieldList"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:234:1: fieldList returns [IList<FieldAssignmentNode> items] : id= idAssign ( Comma id= idAssign )* ;
	[GrammarRule("fieldList")]
	private IList<FieldAssignmentNode> fieldList()
	{
		Enter_fieldList();
		EnterRule("fieldList", 10);
		TraceIn("fieldList", 10);
		IList<FieldAssignmentNode> items = default(IList<FieldAssignmentNode>);

		FieldAssignmentNode id = default(FieldAssignmentNode);

		items = new List<FieldAssignmentNode>(); 
		try { DebugEnterRule(GrammarFileName, "fieldList");
		DebugLocation(234, 85);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:235:51: (id= idAssign ( Comma id= idAssign )* )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:236:2: id= idAssign ( Comma id= idAssign )*
			{
			DebugLocation(236, 5);
			PushFollow(Follow._idAssign_in_fieldList1364);
			id=idAssign();
			PopFollow();
			if (state.failed) return items;
			DebugLocation(236, 16);
			if ( state.backtracking == 0 )
			{
				items.Add(id);
			}
			DebugLocation(236, 40);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:236:40: ( Comma id= idAssign )*
			try { DebugEnterSubRule(20);
			while (true)
			{
				int alt20=2;
				try { DebugEnterDecision(20, decisionCanBacktrack[20]);
				int LA20_0 = input.LA(1);

				if ((LA20_0==Comma))
				{
					alt20=1;
				}


				} finally { DebugExitDecision(20); }
				switch ( alt20 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:236:41: Comma id= idAssign
					{
					DebugLocation(236, 41);
					Match(input,Comma,Follow._Comma_in_fieldList1369); if (state.failed) return items;
					DebugLocation(236, 50);
					PushFollow(Follow._idAssign_in_fieldList1375);
					id=idAssign();
					PopFollow();
					if (state.failed) return items;
					DebugLocation(236, 61);
					if ( state.backtracking == 0 )
					{
						items.Add(id);
					}

					}
					break;

				default:
					goto loop20;
				}
			}

			loop20:
				;

			} finally { DebugExitSubRule(20); }


			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("fieldList", 10);
			LeaveRule("fieldList", 10);
			Leave_fieldList();
		}
		DebugLocation(236, 85);
		} finally { DebugExitRule(GrammarFileName, "fieldList"); }
		return items;

	}
	// $ANTLR end "fieldList"


	partial void Enter_idAssign();
	partial void Leave_idAssign();

	// $ANTLR start "idAssign"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:238:1: idAssign returns [FieldAssignmentNode node] : fieldName= ID Equals body= expr_or ;
	[GrammarRule("idAssign")]
	private FieldAssignmentNode idAssign()
	{
		Enter_idAssign();
		EnterRule("idAssign", 11);
		TraceIn("idAssign", 11);
		FieldAssignmentNode node = default(FieldAssignmentNode);

		IToken fieldName=null;
		ExpressionNode body = default(ExpressionNode);

		try { DebugEnterRule(GrammarFileName, "idAssign");
		DebugLocation(238, 100);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:238:44: (fieldName= ID Equals body= expr_or )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:239:1: fieldName= ID Equals body= expr_or
			{
			DebugLocation(239, 11);
			fieldName=(IToken)Match(input,ID,Follow._ID_in_idAssign1397); if (state.failed) return node;
			DebugLocation(239, 16);
			Match(input,Equals,Follow._Equals_in_idAssign1399); if (state.failed) return node;
			DebugLocation(239, 28);
			PushFollow(Follow._expr_or_in_idAssign1405);
			body=expr_or();
			PopFollow();
			if (state.failed) return node;
			DebugLocation(239, 38);
			if ( state.backtracking == 0 )
			{
				node = new FieldAssignmentNode(fieldName.Text, body);
			}

			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("idAssign", 11);
			LeaveRule("idAssign", 11);
			Leave_idAssign();
		}
		DebugLocation(239, 100);
		} finally { DebugExitRule(GrammarFileName, "idAssign"); }
		return node;

	}
	// $ANTLR end "idAssign"


	partial void Enter_lvalue();
	partial void Leave_lvalue();

	// $ANTLR start "lvalue"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:241:1: lvalue[ExpressionNode accessNode] returns [ExpressionNode node] : ( Dot fieldName= ID | LCorch index= expr_or RCorch )* ;
	[GrammarRule("lvalue")]
	private ExpressionNode lvalue(ExpressionNode accessNode)
	{
		Enter_lvalue();
		EnterRule("lvalue", 12);
		TraceIn("lvalue", 12);
		ExpressionNode node = default(ExpressionNode);

		IToken fieldName=null;
		ExpressionNode index = default(ExpressionNode);

		try { DebugEnterRule(GrammarFileName, "lvalue");
		DebugLocation(241, 2);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:241:65: ( ( Dot fieldName= ID | LCorch index= expr_or RCorch )* )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:242:1: ( Dot fieldName= ID | LCorch index= expr_or RCorch )*
			{
			DebugLocation(242, 1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:242:1: ( Dot fieldName= ID | LCorch index= expr_or RCorch )*
			try { DebugEnterSubRule(21);
			while (true)
			{
				int alt21=3;
				try { DebugEnterDecision(21, decisionCanBacktrack[21]);
				int LA21_0 = input.LA(1);

				if ((LA21_0==Dot))
				{
					alt21=1;
				}
				else if ((LA21_0==LCorch))
				{
					alt21=2;
				}


				} finally { DebugExitDecision(21); }
				switch ( alt21 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:243:1: Dot fieldName= ID
					{
					DebugLocation(243, 1);
					Match(input,Dot,Follow._Dot_in_lvalue1425); if (state.failed) return node;
					DebugLocation(243, 15);
					fieldName=(IToken)Match(input,ID,Follow._ID_in_lvalue1431); if (state.failed) return node;
					DebugLocation(243, 20);
					if ( state.backtracking == 0 )
					{
						node = new RecordAccessNode(accessNode, fieldName.Text);
					}

					}
					break;
				case 2:
					DebugEnterAlt(2);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:244:1: LCorch index= expr_or RCorch
					{
					DebugLocation(244, 1);
					Match(input,LCorch,Follow._LCorch_in_lvalue1437); if (state.failed) return node;
					DebugLocation(244, 14);
					PushFollow(Follow._expr_or_in_lvalue1443);
					index=expr_or();
					PopFollow();
					if (state.failed) return node;
					DebugLocation(244, 24);
					Match(input,RCorch,Follow._RCorch_in_lvalue1445); if (state.failed) return node;
					DebugLocation(244, 31);
					if ( state.backtracking == 0 )
					{
						node = new ArrayAccessNode(accessNode, index); 
					}

					}
					break;

				default:
					goto loop21;
				}
			}

			loop21:
				;

			} finally { DebugExitSubRule(21); }


			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("lvalue", 12);
			LeaveRule("lvalue", 12);
			Leave_lvalue();
		}
		DebugLocation(245, 2);
		} finally { DebugExitRule(GrammarFileName, "lvalue"); }
		return node;

	}
	// $ANTLR end "lvalue"


	partial void Enter_declarationList();
	partial void Leave_declarationList();

	// $ANTLR start "declarationList"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:247:1: declarationList returns [IList<DeclarationNode> items] : (dec= declaration )+ ;
	[GrammarRule("declarationList")]
	private IList<DeclarationNode> declarationList()
	{
		Enter_declarationList();
		EnterRule("declarationList", 13);
		TraceIn("declarationList", 13);
		IList<DeclarationNode> items = default(IList<DeclarationNode>);

		DeclarationNode dec = default(DeclarationNode);

		items = new List<DeclarationNode>();
		try { DebugEnterRule(GrammarFileName, "declarationList");
		DebugLocation(247, 48);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:248:45: ( (dec= declaration )+ )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:249:2: (dec= declaration )+
			{
			DebugLocation(249, 2);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:249:2: (dec= declaration )+
			int cnt22=0;
			try { DebugEnterSubRule(22);
			while (true)
			{
				int alt22=2;
				try { DebugEnterDecision(22, decisionCanBacktrack[22]);
				int LA22_0 = input.LA(1);

				if ((LA22_0==Type||(LA22_0>=Var && LA22_0<=Function)))
				{
					alt22=1;
				}


				} finally { DebugExitDecision(22); }
				switch (alt22)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:249:3: dec= declaration
					{
					DebugLocation(249, 7);
					PushFollow(Follow._declaration_in_declarationList1477);
					dec=declaration();
					PopFollow();
					if (state.failed) return items;
					DebugLocation(249, 21);
					if ( state.backtracking == 0 )
					{
						items.Add(dec);
					}

					}
					break;

				default:
					if (cnt22 >= 1)
						goto loop22;

					if (state.backtracking>0) {state.failed=true; return items;}
					EarlyExitException eee22 = new EarlyExitException( 22, input );
					DebugRecognitionException(eee22);
					throw eee22;
				}
				cnt22++;
			}
			loop22:
				;

			} finally { DebugExitSubRule(22); }


			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("declarationList", 13);
			LeaveRule("declarationList", 13);
			Leave_declarationList();
		}
		DebugLocation(249, 48);
		} finally { DebugExitRule(GrammarFileName, "declarationList"); }
		return items;

	}
	// $ANTLR end "declarationList"


	partial void Enter_declaration();
	partial void Leave_declaration();

	// $ANTLR start "declaration"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:250:1: declaration returns [DeclarationNode node] : (t= typeDeclaration | v= variableDeclaration | f= functionDeclaration );
	[GrammarRule("declaration")]
	private DeclarationNode declaration()
	{
		Enter_declaration();
		EnterRule("declaration", 14);
		TraceIn("declaration", 14);
		DeclarationNode node = default(DeclarationNode);

		TypeDeclarationNode t = default(TypeDeclarationNode);
		VariableDeclarationNode v = default(VariableDeclarationNode);
		CallableDeclarationNode f = default(CallableDeclarationNode);

		try { DebugEnterRule(GrammarFileName, "declaration");
		DebugLocation(250, 43);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:250:44: (t= typeDeclaration | v= variableDeclaration | f= functionDeclaration )
			int alt23=3;
			try { DebugEnterDecision(23, decisionCanBacktrack[23]);
			switch (input.LA(1))
			{
			case Type:
				{
				alt23=1;
				}
				break;
			case Var:
				{
				alt23=2;
				}
				break;
			case Function:
				{
				alt23=3;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return node;}
					NoViableAltException nvae = new NoViableAltException("", 23, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(23); }
			switch (alt23)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:252:1: t= typeDeclaration
				{
				DebugLocation(252, 3);
				PushFollow(Follow._typeDeclaration_in_declaration1503);
				t=typeDeclaration();
				PopFollow();
				if (state.failed) return node;
				DebugLocation(252, 21);
				if ( state.backtracking == 0 )
				{
					 node = t; 
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:253:1: v= variableDeclaration
				{
				DebugLocation(253, 3);
				PushFollow(Follow._variableDeclaration_in_declaration1513);
				v=variableDeclaration();
				PopFollow();
				if (state.failed) return node;
				DebugLocation(253, 25);
				if ( state.backtracking == 0 )
				{
					 node = v; 
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:254:1: f= functionDeclaration
				{
				DebugLocation(254, 3);
				PushFollow(Follow._functionDeclaration_in_declaration1523);
				f=functionDeclaration();
				PopFollow();
				if (state.failed) return node;
				DebugLocation(254, 25);
				if ( state.backtracking == 0 )
				{
					node = f; 
				}

				}
				break;

			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("declaration", 14);
			LeaveRule("declaration", 14);
			Leave_declaration();
		}
		DebugLocation(254, 43);
		} finally { DebugExitRule(GrammarFileName, "declaration"); }
		return node;

	}
	// $ANTLR end "declaration"


	partial void Enter_typeDeclaration();
	partial void Leave_typeDeclaration();

	// $ANTLR start "typeDeclaration"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:256:1: typeDeclaration returns [TypeDeclarationNode node] : Type name= ID Equals type[$name.Text] ;
	[GrammarRule("typeDeclaration")]
	private TypeDeclarationNode typeDeclaration()
	{
		Enter_typeDeclaration();
		EnterRule("typeDeclaration", 15);
		TraceIn("typeDeclaration", 15);
		TypeDeclarationNode node = default(TypeDeclarationNode);

		IToken name=null;

		try { DebugEnterRule(GrammarFileName, "typeDeclaration");
		DebugLocation(256, 38);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:256:52: ( Type name= ID Equals type[$name.Text] )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:257:1: Type name= ID Equals type[$name.Text]
			{
			DebugLocation(257, 1);
			Match(input,Type,Follow._Type_in_typeDeclaration1538); if (state.failed) return node;
			DebugLocation(257, 11);
			name=(IToken)Match(input,ID,Follow._ID_in_typeDeclaration1544); if (state.failed) return node;
			DebugLocation(257, 16);
			Match(input,Equals,Follow._Equals_in_typeDeclaration1546); if (state.failed) return node;
			DebugLocation(257, 23);
			PushFollow(Follow._type_in_typeDeclaration1548);
			type(name.Text);
			PopFollow();
			if (state.failed) return node;

			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("typeDeclaration", 15);
			LeaveRule("typeDeclaration", 15);
			Leave_typeDeclaration();
		}
		DebugLocation(257, 38);
		} finally { DebugExitRule(GrammarFileName, "typeDeclaration"); }
		return node;

	}
	// $ANTLR end "typeDeclaration"


	partial void Enter_type();
	partial void Leave_type();

	// $ANTLR start "type"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:259:1: type[string name] returns [TypeDeclarationNode node] : (id= ID | LKey (fields= typeFields )? RKey | ArrayOf typeName= ID );
	[GrammarRule("type")]
	private TypeDeclarationNode type(string name)
	{
		Enter_type();
		EnterRule("type", 16);
		TraceIn("type", 16);
		TypeDeclarationNode node = default(TypeDeclarationNode);

		IToken id=null;
		IToken typeName=null;
		IList<TypeField> fields = default(IList<TypeField>);

		try { DebugEnterRule(GrammarFileName, "type");
		DebugLocation(259, 80);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:259:54: (id= ID | LKey (fields= typeFields )? RKey | ArrayOf typeName= ID )
			int alt25=3;
			try { DebugEnterDecision(25, decisionCanBacktrack[25]);
			switch (input.LA(1))
			{
			case ID:
				{
				alt25=1;
				}
				break;
			case LKey:
				{
				alt25=2;
				}
				break;
			case ArrayOf:
				{
				alt25=3;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return node;}
					NoViableAltException nvae = new NoViableAltException("", 25, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(25); }
			switch (alt25)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:260:2: id= ID
				{
				DebugLocation(260, 5);
				id=(IToken)Match(input,ID,Follow._ID_in_type1570); if (state.failed) return node;
				DebugLocation(260, 10);
				if ( state.backtracking == 0 )
				{
					node = new AliasDeclarationNode(name, id.Text); 
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:261:2: LKey (fields= typeFields )? RKey
				{
				DebugLocation(261, 2);
				Match(input,LKey,Follow._LKey_in_type1578); if (state.failed) return node;
				DebugLocation(261, 7);
				if ( state.backtracking == 0 )
				{
					node = new RecordDeclarationNode(name); 
				}
				DebugLocation(261, 50);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:261:50: (fields= typeFields )?
				int alt24=2;
				try { DebugEnterSubRule(24);
				try { DebugEnterDecision(24, decisionCanBacktrack[24]);
				int LA24_0 = input.LA(1);

				if ((LA24_0==ID))
				{
					alt24=1;
				}
				} finally { DebugExitDecision(24); }
				switch (alt24)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:261:51: fields= typeFields
					{
					DebugLocation(261, 58);
					PushFollow(Follow._typeFields_in_type1586);
					fields=typeFields();
					PopFollow();
					if (state.failed) return node;
					DebugLocation(261, 71);
					if ( state.backtracking == 0 )
					{
						((RecordDeclarationNode)node).Fields = fields;
					}

					}
					break;

				}
				} finally { DebugExitSubRule(24); }

				DebugLocation(261, 130);
				Match(input,RKey,Follow._RKey_in_type1592); if (state.failed) return node;

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:262:2: ArrayOf typeName= ID
				{
				DebugLocation(262, 2);
				Match(input,ArrayOf,Follow._ArrayOf_in_type1599); if (state.failed) return node;
				DebugLocation(262, 19);
				typeName=(IToken)Match(input,ID,Follow._ID_in_type1605); if (state.failed) return node;
				DebugLocation(262, 24);
				if ( state.backtracking == 0 )
				{
					node = new ArrayDeclarationNode(name, typeName.Text);
				}

				}
				break;

			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("type", 16);
			LeaveRule("type", 16);
			Leave_type();
		}
		DebugLocation(262, 80);
		} finally { DebugExitRule(GrammarFileName, "type"); }
		return node;

	}
	// $ANTLR end "type"


	partial void Enter_typeFields();
	partial void Leave_typeFields();

	// $ANTLR start "typeFields"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:264:1: typeFields returns [IList<TypeField> items] : t= typeField ( Comma t= typeField )* ;
	[GrammarRule("typeFields")]
	private IList<TypeField> typeFields()
	{
		Enter_typeFields();
		EnterRule("typeFields", 17);
		TraceIn("typeFields", 17);
		IList<TypeField> items = default(IList<TypeField>);

		TypeField t = default(TypeField);

		items = new List<TypeField>();
		try { DebugEnterRule(GrammarFileName, "typeFields");
		DebugLocation(264, 85);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:265:40: (t= typeField ( Comma t= typeField )* )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:266:1: t= typeField ( Comma t= typeField )*
			{
			DebugLocation(266, 3);
			PushFollow(Follow._typeField_in_typeFields1631);
			t=typeField();
			PopFollow();
			if (state.failed) return items;
			DebugLocation(266, 15);
			if ( state.backtracking == 0 )
			{
				items.Add(t); 
			}
			DebugLocation(266, 40);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:266:40: ( Comma t= typeField )*
			try { DebugEnterSubRule(26);
			while (true)
			{
				int alt26=2;
				try { DebugEnterDecision(26, decisionCanBacktrack[26]);
				int LA26_0 = input.LA(1);

				if ((LA26_0==Comma))
				{
					alt26=1;
				}


				} finally { DebugExitDecision(26); }
				switch ( alt26 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:266:41: Comma t= typeField
					{
					DebugLocation(266, 41);
					Match(input,Comma,Follow._Comma_in_typeFields1636); if (state.failed) return items;
					DebugLocation(266, 49);
					PushFollow(Follow._typeField_in_typeFields1642);
					t=typeField();
					PopFollow();
					if (state.failed) return items;
					DebugLocation(266, 61);
					if ( state.backtracking == 0 )
					{
						items.Add(t);
					}

					}
					break;

				default:
					goto loop26;
				}
			}

			loop26:
				;

			} finally { DebugExitSubRule(26); }


			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("typeFields", 17);
			LeaveRule("typeFields", 17);
			Leave_typeFields();
		}
		DebugLocation(266, 85);
		} finally { DebugExitRule(GrammarFileName, "typeFields"); }
		return items;

	}
	// $ANTLR end "typeFields"


	partial void Enter_typeField();
	partial void Leave_typeField();

	// $ANTLR start "typeField"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:268:1: typeField returns [TypeField value] : id= ID ':' typeId= ID ;
	[GrammarRule("typeField")]
	private TypeField typeField()
	{
		Enter_typeField();
		EnterRule("typeField", 18);
		TraceIn("typeField", 18);
		TypeField value = default(TypeField);

		IToken id=null;
		IToken typeId=null;

		try { DebugEnterRule(GrammarFileName, "typeField");
		DebugLocation(268, 111);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:268:37: (id= ID ':' typeId= ID )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:268:39: id= ID ':' typeId= ID
			{
			DebugLocation(268, 42);
			id=(IToken)Match(input,ID,Follow._ID_in_typeField1664); if (state.failed) return value;
			DebugLocation(268, 47);
			Match(input,54,Follow._54_in_typeField1666); if (state.failed) return value;
			DebugLocation(268, 58);
			typeId=(IToken)Match(input,ID,Follow._ID_in_typeField1672); if (state.failed) return value;
			DebugLocation(268, 63);
			if ( state.backtracking == 0 )
			{
				value = new TypeField(id.Text, typeId.Text);
			}

			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("typeField", 18);
			LeaveRule("typeField", 18);
			Leave_typeField();
		}
		DebugLocation(268, 111);
		} finally { DebugExitRule(GrammarFileName, "typeField"); }
		return value;

	}
	// $ANTLR end "typeField"


	partial void Enter_variableDeclaration();
	partial void Leave_variableDeclaration();

	// $ANTLR start "variableDeclaration"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:270:1: variableDeclaration returns [VariableDeclarationNode node] : Var name= ID ( ':' tName= ID )? Assign body= expr_or ;
	[GrammarRule("variableDeclaration")]
	private VariableDeclarationNode variableDeclaration()
	{
		Enter_variableDeclaration();
		EnterRule("variableDeclaration", 19);
		TraceIn("variableDeclaration", 19);
		VariableDeclarationNode node = default(VariableDeclarationNode);

		IToken name=null;
		IToken tName=null;
		ExpressionNode body = default(ExpressionNode);

		string typeName = null;
		try { DebugEnterRule(GrammarFileName, "variableDeclaration");
		DebugLocation(270, 72);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:271:32: ( Var name= ID ( ':' tName= ID )? Assign body= expr_or )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:272:1: Var name= ID ( ':' tName= ID )? Assign body= expr_or
			{
			DebugLocation(272, 1);
			Match(input,Var,Follow._Var_in_variableDeclaration1691); if (state.failed) return node;
			DebugLocation(272, 10);
			name=(IToken)Match(input,ID,Follow._ID_in_variableDeclaration1697); if (state.failed) return node;
			DebugLocation(272, 15);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:272:15: ( ':' tName= ID )?
			int alt27=2;
			try { DebugEnterSubRule(27);
			try { DebugEnterDecision(27, decisionCanBacktrack[27]);
			int LA27_0 = input.LA(1);

			if ((LA27_0==54))
			{
				alt27=1;
			}
			} finally { DebugExitDecision(27); }
			switch (alt27)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:272:16: ':' tName= ID
				{
				DebugLocation(272, 16);
				Match(input,54,Follow._54_in_variableDeclaration1700); if (state.failed) return node;
				DebugLocation(272, 26);
				tName=(IToken)Match(input,ID,Follow._ID_in_variableDeclaration1706); if (state.failed) return node;
				DebugLocation(272, 31);
				if ( state.backtracking == 0 )
				{
					typeName = tName.Text;
				}

				}
				break;

			}
			} finally { DebugExitSubRule(27); }

			DebugLocation(272, 59);
			Match(input,Assign,Follow._Assign_in_variableDeclaration1712); if (state.failed) return node;
			DebugLocation(272, 71);
			PushFollow(Follow._expr_or_in_variableDeclaration1718);
			body=expr_or();
			PopFollow();
			if (state.failed) return node;
			DebugLocation(273, 1);
			if ( state.backtracking == 0 )
			{
				node = new VariableDeclarationNode(name.Text, body, typeName);
			}

			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("variableDeclaration", 19);
			LeaveRule("variableDeclaration", 19);
			Leave_variableDeclaration();
		}
		DebugLocation(273, 72);
		} finally { DebugExitRule(GrammarFileName, "variableDeclaration"); }
		return node;

	}
	// $ANTLR end "variableDeclaration"


	partial void Enter_functionDeclaration();
	partial void Leave_functionDeclaration();

	// $ANTLR start "functionDeclaration"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:277:1: functionDeclaration returns [CallableDeclarationNode node] : Function name= ID LParent (f= typeFields )? RParent ( ':' tName= ID )? Equals body= expr_or ;
	[GrammarRule("functionDeclaration")]
	private CallableDeclarationNode functionDeclaration()
	{
		Enter_functionDeclaration();
		EnterRule("functionDeclaration", 20);
		TraceIn("functionDeclaration", 20);
		CallableDeclarationNode node = default(CallableDeclarationNode);

		IToken name=null;
		IToken tName=null;
		IList<TypeField> f = default(IList<TypeField>);
		ExpressionNode body = default(ExpressionNode);


		IList<TypeField> fields = new List<TypeField>();
		string typeName = null;

		try { DebugEnterRule(GrammarFileName, "functionDeclaration");
		DebugLocation(277, 0);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:282:1: ( Function name= ID LParent (f= typeFields )? RParent ( ':' tName= ID )? Equals body= expr_or )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:283:1: Function name= ID LParent (f= typeFields )? RParent ( ':' tName= ID )? Equals body= expr_or
			{
			DebugLocation(283, 1);
			Match(input,Function,Follow._Function_in_functionDeclaration1756); if (state.failed) return node;
			DebugLocation(283, 15);
			name=(IToken)Match(input,ID,Follow._ID_in_functionDeclaration1762); if (state.failed) return node;
			DebugLocation(283, 20);
			Match(input,LParent,Follow._LParent_in_functionDeclaration1764); if (state.failed) return node;
			DebugLocation(283, 28);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:283:28: (f= typeFields )?
			int alt28=2;
			try { DebugEnterSubRule(28);
			try { DebugEnterDecision(28, decisionCanBacktrack[28]);
			int LA28_0 = input.LA(1);

			if ((LA28_0==ID))
			{
				alt28=1;
			}
			} finally { DebugExitDecision(28); }
			switch (alt28)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:283:29: f= typeFields
				{
				DebugLocation(283, 31);
				PushFollow(Follow._typeFields_in_functionDeclaration1771);
				f=typeFields();
				PopFollow();
				if (state.failed) return node;
				DebugLocation(283, 44);
				if ( state.backtracking == 0 )
				{
					fields = f;
				}

				}
				break;

			}
			} finally { DebugExitSubRule(28); }

			DebugLocation(283, 67);
			Match(input,RParent,Follow._RParent_in_functionDeclaration1777); if (state.failed) return node;
			DebugLocation(283, 75);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:283:75: ( ':' tName= ID )?
			int alt29=2;
			try { DebugEnterSubRule(29);
			try { DebugEnterDecision(29, decisionCanBacktrack[29]);
			int LA29_0 = input.LA(1);

			if ((LA29_0==54))
			{
				alt29=1;
			}
			} finally { DebugExitDecision(29); }
			switch (alt29)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:283:76: ':' tName= ID
				{
				DebugLocation(283, 76);
				Match(input,54,Follow._54_in_functionDeclaration1780); if (state.failed) return node;
				DebugLocation(283, 86);
				tName=(IToken)Match(input,ID,Follow._ID_in_functionDeclaration1786); if (state.failed) return node;
				DebugLocation(283, 91);
				if ( state.backtracking == 0 )
				{
					typeName = tName.Text;
				}

				}
				break;

			}
			} finally { DebugExitSubRule(29); }

			DebugLocation(283, 119);
			Match(input,Equals,Follow._Equals_in_functionDeclaration1792); if (state.failed) return node;
			DebugLocation(283, 131);
			PushFollow(Follow._expr_or_in_functionDeclaration1798);
			body=expr_or();
			PopFollow();
			if (state.failed) return node;
			DebugLocation(284, 1);
			if ( state.backtracking == 0 )
			{
				return new CallableDeclarationNode(name.Text, fields, body, typeName);
			}

			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("functionDeclaration", 20);
			LeaveRule("functionDeclaration", 20);
			Leave_functionDeclaration();
		}
		DebugLocation(285, 0);
		} finally { DebugExitRule(GrammarFileName, "functionDeclaration"); }
		return node;

	}
	// $ANTLR end "functionDeclaration"

	partial void Enter_synpred1_Tiger_fragment();
	partial void Leave_synpred1_Tiger_fragment();

	// $ANTLR start synpred1_Tiger
	public void synpred1_Tiger_fragment()
	{
		Enter_synpred1_Tiger_fragment();
		EnterRule("synpred1_Tiger_fragment", 21);
		TraceIn("synpred1_Tiger_fragment", 21);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:191:4: ( LKey RKey )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:191:5: LKey RKey
			{
			DebugLocation(191, 5);
			Match(input,LKey,Follow._LKey_in_synpred1_Tiger971); if (state.failed) return;
			DebugLocation(191, 10);
			Match(input,RKey,Follow._RKey_in_synpred1_Tiger973); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred1_Tiger_fragment", 21);
			LeaveRule("synpred1_Tiger_fragment", 21);
			Leave_synpred1_Tiger_fragment();
		}
	}
	// $ANTLR end synpred1_Tiger

	partial void Enter_synpred2_Tiger_fragment();
	partial void Leave_synpred2_Tiger_fragment();

	// $ANTLR start synpred2_Tiger
	public void synpred2_Tiger_fragment()
	{
		Enter_synpred2_Tiger_fragment();
		EnterRule("synpred2_Tiger_fragment", 22);
		TraceIn("synpred2_Tiger_fragment", 22);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:199:4: ( LCorch expr_or RCorch Of )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:199:5: LCorch expr_or RCorch Of
			{
			DebugLocation(199, 5);
			Match(input,LCorch,Follow._LCorch_in_synpred2_Tiger1029); if (state.failed) return;
			DebugLocation(199, 12);
			PushFollow(Follow._expr_or_in_synpred2_Tiger1031);
			expr_or();
			PopFollow();
			if (state.failed) return;
			DebugLocation(199, 20);
			Match(input,RCorch,Follow._RCorch_in_synpred2_Tiger1033); if (state.failed) return;
			DebugLocation(199, 27);
			Match(input,Of,Follow._Of_in_synpred2_Tiger1035); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred2_Tiger_fragment", 22);
			LeaveRule("synpred2_Tiger_fragment", 22);
			Leave_synpred2_Tiger_fragment();
		}
	}
	// $ANTLR end synpred2_Tiger
	#endregion Rules

	#region Synpreds
	private bool EvaluatePredicate(System.Action fragment)
	{
		bool success = false;
		state.backtracking++;
		try { DebugBeginBacktrack(state.backtracking);
		int start = input.Mark();
		try
		{
			fragment();
		}
		catch ( RecognitionException re )
		{
			System.Console.Error.WriteLine("impossible: "+re);
		}
		success = !state.failed;
		input.Rewind(start);
		} finally { DebugEndBacktrack(state.backtracking, success); }
		state.backtracking--;
		state.failed=false;
		return success;
	}
	#endregion Synpreds


	#region DFA
	DFA12 dfa12;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa12 = new DFA12( this, SpecialStateTransition12 );
	}

	private class DFA12 : DFA
	{
		private const string DFA12_eotS =
			"\x20\xFFFF";
		private const string DFA12_eofS =
			"\x1\x2\x1F\xFFFF";
		private const string DFA12_minS =
			"\x1\x5\x1\x0\x1E\xFFFF";
		private const string DFA12_maxS =
			"\x1\x29\x1\x0\x1E\xFFFF";
		private const string DFA12_acceptS =
			"\x2\xFFFF\x1\x2\x1C\xFFFF\x1\x1";
		private const string DFA12_specialS =
			"\x1\xFFFF\x1\x0\x1E\xFFFF}>";
		private static readonly string[] DFA12_transitionS =
			{
				"\x2\x2\x1\xFFFF\x1\x2\x1\x1\x1\x2\x1\xFFFF\x1\x2\x1\xFFFF\x2\x2\x2"+
				"\xFFFF\x1\x2\x1\xFFFF\x3\x2\x1\xFFFF\xF\x2\x1\xFFFF\x2\x2",
				"\x1\xFFFF",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				""
			};

		private static readonly short[] DFA12_eot = DFA.UnpackEncodedString(DFA12_eotS);
		private static readonly short[] DFA12_eof = DFA.UnpackEncodedString(DFA12_eofS);
		private static readonly char[] DFA12_min = DFA.UnpackEncodedStringToUnsignedChars(DFA12_minS);
		private static readonly char[] DFA12_max = DFA.UnpackEncodedStringToUnsignedChars(DFA12_maxS);
		private static readonly short[] DFA12_accept = DFA.UnpackEncodedString(DFA12_acceptS);
		private static readonly short[] DFA12_special = DFA.UnpackEncodedString(DFA12_specialS);
		private static readonly short[][] DFA12_transition;

		static DFA12()
		{
			int numStates = DFA12_transitionS.Length;
			DFA12_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA12_transition[i] = DFA.UnpackEncodedString(DFA12_transitionS[i]);
			}
		}

		public DFA12( BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition )
			: base(specialStateTransition)
		{
			this.recognizer = recognizer;
			this.decisionNumber = 12;
			this.eot = DFA12_eot;
			this.eof = DFA12_eof;
			this.min = DFA12_min;
			this.max = DFA12_max;
			this.accept = DFA12_accept;
			this.special = DFA12_special;
			this.transition = DFA12_transition;
		}

		public override string Description { get { return "199:3: ( ( LCorch expr_or RCorch Of )=> ( LCorch length= expr_or RCorch Of initialValue= expr_or ) | lv= lvalue[$node] ( Assign body= expr_or )? )"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private int SpecialStateTransition12(DFA dfa, int s, IIntStream _input)
	{
		ITokenStream input = (ITokenStream)_input;
		int _s = s;
		switch (s)
		{
			case 0:
				int LA12_1 = input.LA(1);


				int index12_1 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred2_Tiger_fragment)) ) {s = 31;}

				else if ( (true) ) {s = 2;}


				input.Seek(index12_1);
				if ( s>=0 ) return s;
				break;
		}
		if (state.backtracking > 0) {state.failed=true; return -1;}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 12, _s, input);
		dfa.Error(nvae);
		throw nvae;
	}

	#endregion DFA

	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _expr_or_in_prog565 = new BitSet(new ulong[]{0x0UL});
		public static readonly BitSet _EOF_in_prog567 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expr_and_in_expr_or584 = new BitSet(new ulong[]{0x2000000002UL});
		public static readonly BitSet _Or_in_expr_or590 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_or_in_expr_or596 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expr_logical_in_expr_and615 = new BitSet(new ulong[]{0x1000000002UL});
		public static readonly BitSet _And_in_expr_and622 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_and_in_expr_and628 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expr_arithm_in_expr_logical656 = new BitSet(new ulong[]{0xFC0000002UL});
		public static readonly BitSet _Equals_in_expr_logical669 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _NotEquals_in_expr_logical680 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _GThan_in_expr_logical689 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _LThan_in_expr_logical696 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _GEThan_in_expr_logical705 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _LEThan_in_expr_logical714 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_logical_in_expr_logical727 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expr_factor_in_expr_arithm758 = new BitSet(new ulong[]{0x8000022UL});
		public static readonly BitSet _Plus_in_expr_arithm771 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _Minus_in_expr_arithm782 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_arithm_in_expr_arithm794 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expr_in_expr_factor821 = new BitSet(new ulong[]{0x30000002UL});
		public static readonly BitSet _Mult_in_expr_factor833 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _Div_in_expr_factor843 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_factor_in_expr_factor856 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _STRING_CONST_in_expr875 = new BitSet(new ulong[]{0x4000200UL});
		public static readonly BitSet _INT_CONST_in_expr883 = new BitSet(new ulong[]{0x4000200UL});
		public static readonly BitSet _NIL_in_expr891 = new BitSet(new ulong[]{0x4000200UL});
		public static readonly BitSet _Minus_in_expr899 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_or_in_expr905 = new BitSet(new ulong[]{0x4000200UL});
		public static readonly BitSet _ID_in_expr930 = new BitSet(new ulong[]{0x4000AC0UL});
		public static readonly BitSet _LParent_in_expr939 = new BitSet(new ulong[]{0x144000008B21B0UL});
		public static readonly BitSet _exprList_in_expr947 = new BitSet(new ulong[]{0x100UL});
		public static readonly BitSet _RParent_in_expr954 = new BitSet(new ulong[]{0x4000200UL});
		public static readonly BitSet _LKey_in_expr984 = new BitSet(new ulong[]{0x1000UL});
		public static readonly BitSet _RKey_in_expr986 = new BitSet(new ulong[]{0x4000200UL});
		public static readonly BitSet _LKey_in_expr996 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _fieldList_in_expr1002 = new BitSet(new ulong[]{0x1000UL});
		public static readonly BitSet _RKey_in_expr1018 = new BitSet(new ulong[]{0x4000200UL});
		public static readonly BitSet _LCorch_in_expr1047 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_or_in_expr1053 = new BitSet(new ulong[]{0x400UL});
		public static readonly BitSet _RCorch_in_expr1055 = new BitSet(new ulong[]{0x100000000000UL});
		public static readonly BitSet _Of_in_expr1057 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_or_in_expr1063 = new BitSet(new ulong[]{0x4000200UL});
		public static readonly BitSet _lvalue_in_expr1083 = new BitSet(new ulong[]{0x4000240UL});
		public static readonly BitSet _Assign_in_expr1088 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_or_in_expr1094 = new BitSet(new ulong[]{0x4000200UL});
		public static readonly BitSet _LParent_in_expr1110 = new BitSet(new ulong[]{0x144000008B21B0UL});
		public static readonly BitSet _exprSeq_in_expr1113 = new BitSet(new ulong[]{0x100UL});
		public static readonly BitSet _RParent_in_expr1117 = new BitSet(new ulong[]{0x4000200UL});
		public static readonly BitSet _If_in_expr1125 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_or_in_expr1131 = new BitSet(new ulong[]{0x4000UL});
		public static readonly BitSet _Then_in_expr1133 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_or_in_expr1139 = new BitSet(new ulong[]{0x4008200UL});
		public static readonly BitSet _Else_in_expr1142 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_or_in_expr1148 = new BitSet(new ulong[]{0x4000200UL});
		public static readonly BitSet _While_in_expr1163 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_or_in_expr1169 = new BitSet(new ulong[]{0x40000UL});
		public static readonly BitSet _Do_in_expr1171 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_or_in_expr1177 = new BitSet(new ulong[]{0x4000200UL});
		public static readonly BitSet _For_in_expr1187 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _ID_in_expr1189 = new BitSet(new ulong[]{0x40UL});
		public static readonly BitSet _Assign_in_expr1191 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_or_in_expr1197 = new BitSet(new ulong[]{0x100000UL});
		public static readonly BitSet _To_in_expr1199 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_or_in_expr1205 = new BitSet(new ulong[]{0x40000UL});
		public static readonly BitSet _Do_in_expr1207 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_or_in_expr1213 = new BitSet(new ulong[]{0x4000200UL});
		public static readonly BitSet _Break_in_expr1223 = new BitSet(new ulong[]{0x4000200UL});
		public static readonly BitSet _Let_in_expr1232 = new BitSet(new ulong[]{0x34000000000UL});
		public static readonly BitSet _declarationList_in_expr1238 = new BitSet(new ulong[]{0x200000UL});
		public static readonly BitSet _In_in_expr1242 = new BitSet(new ulong[]{0x14400000CB20B0UL});
		public static readonly BitSet _exprSeq_in_expr1249 = new BitSet(new ulong[]{0x400000UL});
		public static readonly BitSet _End_in_expr1255 = new BitSet(new ulong[]{0x4000200UL});
		public static readonly BitSet _lvalue_in_expr1264 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expr_or_in_exprSeq1288 = new BitSet(new ulong[]{0x2000002UL});
		public static readonly BitSet _DotComma_in_exprSeq1292 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_or_in_exprSeq1298 = new BitSet(new ulong[]{0x2000002UL});
		public static readonly BitSet _expr_or_in_exprList1326 = new BitSet(new ulong[]{0x1000002UL});
		public static readonly BitSet _Comma_in_exprList1331 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_or_in_exprList1337 = new BitSet(new ulong[]{0x1000002UL});
		public static readonly BitSet _idAssign_in_fieldList1364 = new BitSet(new ulong[]{0x1000002UL});
		public static readonly BitSet _Comma_in_fieldList1369 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _idAssign_in_fieldList1375 = new BitSet(new ulong[]{0x1000002UL});
		public static readonly BitSet _ID_in_idAssign1397 = new BitSet(new ulong[]{0x40000000UL});
		public static readonly BitSet _Equals_in_idAssign1399 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_or_in_idAssign1405 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _Dot_in_lvalue1425 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _ID_in_lvalue1431 = new BitSet(new ulong[]{0x4000202UL});
		public static readonly BitSet _LCorch_in_lvalue1437 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_or_in_lvalue1443 = new BitSet(new ulong[]{0x400UL});
		public static readonly BitSet _RCorch_in_lvalue1445 = new BitSet(new ulong[]{0x4000202UL});
		public static readonly BitSet _declaration_in_declarationList1477 = new BitSet(new ulong[]{0x34000000002UL});
		public static readonly BitSet _typeDeclaration_in_declaration1503 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _variableDeclaration_in_declaration1513 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _functionDeclaration_in_declaration1523 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _Type_in_typeDeclaration1538 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _ID_in_typeDeclaration1544 = new BitSet(new ulong[]{0x40000000UL});
		public static readonly BitSet _Equals_in_typeDeclaration1546 = new BitSet(new ulong[]{0x10008000000800UL});
		public static readonly BitSet _type_in_typeDeclaration1548 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_type1570 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LKey_in_type1578 = new BitSet(new ulong[]{0x10000000001000UL});
		public static readonly BitSet _typeFields_in_type1586 = new BitSet(new ulong[]{0x1000UL});
		public static readonly BitSet _RKey_in_type1592 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ArrayOf_in_type1599 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _ID_in_type1605 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _typeField_in_typeFields1631 = new BitSet(new ulong[]{0x1000002UL});
		public static readonly BitSet _Comma_in_typeFields1636 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _typeField_in_typeFields1642 = new BitSet(new ulong[]{0x1000002UL});
		public static readonly BitSet _ID_in_typeField1664 = new BitSet(new ulong[]{0x40000000000000UL});
		public static readonly BitSet _54_in_typeField1666 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _ID_in_typeField1672 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _Var_in_variableDeclaration1691 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _ID_in_variableDeclaration1697 = new BitSet(new ulong[]{0x40000000000040UL});
		public static readonly BitSet _54_in_variableDeclaration1700 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _ID_in_variableDeclaration1706 = new BitSet(new ulong[]{0x40UL});
		public static readonly BitSet _Assign_in_variableDeclaration1712 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_or_in_variableDeclaration1718 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _Function_in_functionDeclaration1756 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _ID_in_functionDeclaration1762 = new BitSet(new ulong[]{0x80UL});
		public static readonly BitSet _LParent_in_functionDeclaration1764 = new BitSet(new ulong[]{0x10000000000100UL});
		public static readonly BitSet _typeFields_in_functionDeclaration1771 = new BitSet(new ulong[]{0x100UL});
		public static readonly BitSet _RParent_in_functionDeclaration1777 = new BitSet(new ulong[]{0x40000040000000UL});
		public static readonly BitSet _54_in_functionDeclaration1780 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _ID_in_functionDeclaration1786 = new BitSet(new ulong[]{0x40000000UL});
		public static readonly BitSet _Equals_in_functionDeclaration1792 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_or_in_functionDeclaration1798 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LKey_in_synpred1_Tiger971 = new BitSet(new ulong[]{0x1000UL});
		public static readonly BitSet _RKey_in_synpred1_Tiger973 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LCorch_in_synpred2_Tiger1029 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_or_in_synpred2_Tiger1031 = new BitSet(new ulong[]{0x400UL});
		public static readonly BitSet _RCorch_in_synpred2_Tiger1033 = new BitSet(new ulong[]{0x100000000000UL});
		public static readonly BitSet _Of_in_synpred2_Tiger1035 = new BitSet(new ulong[]{0x2UL});

	}
	#endregion Follow sets
}
