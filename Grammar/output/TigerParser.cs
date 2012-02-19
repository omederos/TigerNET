// $ANTLR 3.3 Nov 30, 2010 12:45:30 C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g 2012-02-19 15:04:01

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
				false, false, false, false, false, true, false, false, false, false, 
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
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:94:8: public prog returns [ExpressionNode node] : e= expr_or EOF ;
	[GrammarRule("prog")]
	public ExpressionNode prog()
	{
		Enter_prog();
		EnterRule("prog", 1);
		TraceIn("prog", 1);
		ExpressionNode node = default(ExpressionNode);

		ExpressionNode e = default(ExpressionNode);

		try { DebugEnterRule(GrammarFileName, "prog");
		DebugLocation(94, 86);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:94:43: (e= expr_or EOF )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:94:45: e= expr_or EOF
			{
			DebugLocation(94, 47);
			PushFollow(Follow._expr_or_in_prog577);
			e=expr_or();
			PopFollow();
			if (state.failed) return node;
			DebugLocation(94, 57);
			Match(input,EOF,Follow._EOF_in_prog579); if (state.failed) return node;
			DebugLocation(94, 61);
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
		DebugLocation(94, 86);
		} finally { DebugExitRule(GrammarFileName, "prog"); }
		return node;

	}
	// $ANTLR end "prog"


	partial void Enter_expr_or();
	partial void Leave_expr_or();

	// $ANTLR start "expr_or"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:95:1: expr_or returns [ExpressionNode node] : left= expr_and ( Or right= expr_or )? ;
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
		DebugLocation(95, 3);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:95:39: (left= expr_and ( Or right= expr_or )? )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:95:41: left= expr_and ( Or right= expr_or )?
			{
			DebugLocation(95, 46);
			PushFollow(Follow._expr_and_in_expr_or596);
			left=expr_and();
			PopFollow();
			if (state.failed) return node;
			DebugLocation(96, 1);
			if ( state.backtracking == 0 )
			{

				/* Left */
				node = left; 

			}
			DebugLocation(100, 1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:100:1: ( Or right= expr_or )?
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
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:100:2: Or right= expr_or
				{
				DebugLocation(100, 2);
				Match(input,Or,Follow._Or_in_expr_or602); if (state.failed) return node;
				DebugLocation(100, 11);
				PushFollow(Follow._expr_or_in_expr_or608);
				right=expr_or();
				PopFollow();
				if (state.failed) return node;
				DebugLocation(101, 1);
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
		DebugLocation(104, 3);
		} finally { DebugExitRule(GrammarFileName, "expr_or"); }
		return node;

	}
	// $ANTLR end "expr_or"


	partial void Enter_expr_and();
	partial void Leave_expr_and();

	// $ANTLR start "expr_and"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:105:1: expr_and returns [ExpressionNode node] : left= expr_logical ( And right= expr_and )? ;
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
		DebugLocation(105, 2);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:105:39: (left= expr_logical ( And right= expr_and )? )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:105:41: left= expr_logical ( And right= expr_and )?
			{
			DebugLocation(105, 46);
			PushFollow(Follow._expr_logical_in_expr_and627);
			left=expr_logical();
			PopFollow();
			if (state.failed) return node;
			DebugLocation(106, 1);
			if ( state.backtracking == 0 )
			{

				node = left;

			}
			DebugLocation(109, 1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:109:1: ( And right= expr_and )?
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
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:109:2: And right= expr_and
				{
				DebugLocation(109, 2);
				Match(input,And,Follow._And_in_expr_and634); if (state.failed) return node;
				DebugLocation(109, 12);
				PushFollow(Follow._expr_and_in_expr_and640);
				right=expr_and();
				PopFollow();
				if (state.failed) return node;
				DebugLocation(110, 1);
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
		DebugLocation(114, 2);
		} finally { DebugExitRule(GrammarFileName, "expr_and"); }
		return node;

	}
	// $ANTLR end "expr_and"


	partial void Enter_expr_logical();
	partial void Leave_expr_logical();

	// $ANTLR start "expr_logical"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:115:1: expr_logical returns [ExpressionNode node] : left= expr_arithm ( ( ( Equals ) | NotEquals | GThan | LThan | GEThan | LEThan ) right= expr_logical )? ;
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
		DebugLocation(115, 3);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:117:2: (left= expr_arithm ( ( ( Equals ) | NotEquals | GThan | LThan | GEThan | LEThan ) right= expr_logical )? )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:117:4: left= expr_arithm ( ( ( Equals ) | NotEquals | GThan | LThan | GEThan | LEThan ) right= expr_logical )?
			{
			DebugLocation(117, 9);
			PushFollow(Follow._expr_arithm_in_expr_logical668);
			left=expr_arithm();
			PopFollow();
			if (state.failed) return node;
			DebugLocation(118, 1);
			if ( state.backtracking == 0 )
			{

				node = left; 

			}
			DebugLocation(121, 2);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:121:2: ( ( ( Equals ) | NotEquals | GThan | LThan | GEThan | LEThan ) right= expr_logical )?
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
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:123:2: ( ( Equals ) | NotEquals | GThan | LThan | GEThan | LEThan ) right= expr_logical
				{
				DebugLocation(123, 2);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:123:2: ( ( Equals ) | NotEquals | GThan | LThan | GEThan | LEThan )
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
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:123:3: ( Equals )
					{
					DebugLocation(123, 3);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:123:3: ( Equals )
					DebugEnterAlt(1);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:123:4: Equals
					{
					DebugLocation(123, 4);
					Match(input,Equals,Follow._Equals_in_expr_logical681); if (state.failed) return node;
					DebugLocation(124, 2);
					if ( state.backtracking == 0 )
					{

							n = new EqualOperatorNode() { Left = node };
							
					}

					}


					}
					break;
				case 2:
					DebugEnterAlt(2);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:127:2: NotEquals
					{
					DebugLocation(127, 2);
					Match(input,NotEquals,Follow._NotEquals_in_expr_logical692); if (state.failed) return node;
					DebugLocation(128, 2);
					if ( state.backtracking == 0 )
					{

							n = new NotEqualOperatorNode() { Left = node };
							
					}

					}
					break;
				case 3:
					DebugEnterAlt(3);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:131:2: GThan
					{
					DebugLocation(131, 2);
					Match(input,GThan,Follow._GThan_in_expr_logical701); if (state.failed) return node;
					DebugLocation(131, 8);
					if ( state.backtracking == 0 )
					{

							n = new GreatherOperatorNode() { Left = node };
							
					}

					}
					break;
				case 4:
					DebugEnterAlt(4);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:134:2: LThan
					{
					DebugLocation(134, 2);
					Match(input,LThan,Follow._LThan_in_expr_logical708); if (state.failed) return node;
					DebugLocation(135, 2);
					if ( state.backtracking == 0 )
					{

							n = new LowerOperatorNode() { Left = node };
							
					}

					}
					break;
				case 5:
					DebugEnterAlt(5);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:138:2: GEThan
					{
					DebugLocation(138, 2);
					Match(input,GEThan,Follow._GEThan_in_expr_logical717); if (state.failed) return node;
					DebugLocation(139, 2);
					if ( state.backtracking == 0 )
					{

							n = new GreatherEqualOperatorNode() { Left = node };
							
					}

					}
					break;
				case 6:
					DebugEnterAlt(6);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:142:2: LEThan
					{
					DebugLocation(142, 2);
					Match(input,LEThan,Follow._LEThan_in_expr_logical726); if (state.failed) return node;
					DebugLocation(143, 2);
					if ( state.backtracking == 0 )
					{

							n = new LowerEqualOperatorNode() { Left = node };	
							
					}

					}
					break;

				}
				} finally { DebugExitSubRule(3); }

				DebugLocation(146, 10);
				PushFollow(Follow._expr_logical_in_expr_logical739);
				right=expr_logical();
				PopFollow();
				if (state.failed) return node;
				DebugLocation(147, 2);
				if ( state.backtracking == 0 )
				{

						n.Right = right;
						node = n;
						
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
		DebugLocation(152, 3);
		} finally { DebugExitRule(GrammarFileName, "expr_logical"); }
		return node;

	}
	// $ANTLR end "expr_logical"


	partial void Enter_expr_arithm();
	partial void Leave_expr_arithm();

	// $ANTLR start "expr_arithm"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:153:1: expr_arithm returns [ExpressionNode node] : left= expr_factor ( ( ( Plus ) | Minus ) right= expr_arithm )? ;
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
		DebugLocation(153, 3);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:155:2: (left= expr_factor ( ( ( Plus ) | Minus ) right= expr_arithm )? )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:155:4: left= expr_factor ( ( ( Plus ) | Minus ) right= expr_arithm )?
			{
			DebugLocation(155, 9);
			PushFollow(Follow._expr_factor_in_expr_arithm770);
			left=expr_factor();
			PopFollow();
			if (state.failed) return node;
			DebugLocation(155, 23);
			if ( state.backtracking == 0 )
			{
				node = left;
			}
			DebugLocation(156, 2);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:156:2: ( ( ( Plus ) | Minus ) right= expr_arithm )?
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
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:157:2: ( ( Plus ) | Minus ) right= expr_arithm
				{
				DebugLocation(157, 2);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:157:2: ( ( Plus ) | Minus )
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
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:158:2: ( Plus )
					{
					DebugLocation(158, 2);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:158:2: ( Plus )
					DebugEnterAlt(1);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:158:3: Plus
					{
					DebugLocation(158, 3);
					Match(input,Plus,Follow._Plus_in_expr_arithm783); if (state.failed) return node;

					}

					DebugLocation(159, 2);
					if ( state.backtracking == 0 )
					{

							n = new PlusOperatorNode() { Left = node };
							
					}

					}
					break;
				case 2:
					DebugEnterAlt(2);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:162:2: Minus
					{
					DebugLocation(162, 2);
					Match(input,Minus,Follow._Minus_in_expr_arithm794); if (state.failed) return node;
					DebugLocation(163, 2);
					if ( state.backtracking == 0 )
					{

							n = new MinusOperatorNode() { Left = node };
							
					}

					}
					break;

				}
				} finally { DebugExitSubRule(5); }

				DebugLocation(166, 10);
				PushFollow(Follow._expr_arithm_in_expr_arithm806);
				right=expr_arithm();
				PopFollow();
				if (state.failed) return node;
				DebugLocation(166, 24);
				if ( state.backtracking == 0 )
				{
					n.Right = right; node = n;
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
		DebugLocation(167, 3);
		} finally { DebugExitRule(GrammarFileName, "expr_arithm"); }
		return node;

	}
	// $ANTLR end "expr_arithm"


	partial void Enter_expr_factor();
	partial void Leave_expr_factor();

	// $ANTLR start "expr_factor"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:168:1: expr_factor returns [ExpressionNode node] : left= expr ( ( ( Mult ) | Div ) right= expr_factor )? ;
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
		DebugLocation(168, 3);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:170:2: (left= expr ( ( ( Mult ) | Div ) right= expr_factor )? )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:170:4: left= expr ( ( ( Mult ) | Div ) right= expr_factor )?
			{
			DebugLocation(170, 9);
			PushFollow(Follow._expr_in_expr_factor833);
			left=expr();
			PopFollow();
			if (state.failed) return node;
			DebugLocation(170, 16);
			if ( state.backtracking == 0 )
			{
				node = left; 
			}
			DebugLocation(171, 2);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:171:2: ( ( ( Mult ) | Div ) right= expr_factor )?
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
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:172:2: ( ( Mult ) | Div ) right= expr_factor
				{
				DebugLocation(172, 2);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:172:2: ( ( Mult ) | Div )
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
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:173:2: ( Mult )
					{
					DebugLocation(173, 2);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:173:2: ( Mult )
					DebugEnterAlt(1);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:173:3: Mult
					{
					DebugLocation(173, 3);
					Match(input,Mult,Follow._Mult_in_expr_factor845); if (state.failed) return node;

					}

					DebugLocation(174, 2);
					if ( state.backtracking == 0 )
					{

							n = new ProdOperatorNode() { Left = node };
							
					}

					}
					break;
				case 2:
					DebugEnterAlt(2);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:177:2: Div
					{
					DebugLocation(177, 2);
					Match(input,Div,Follow._Div_in_expr_factor855); if (state.failed) return node;
					DebugLocation(178, 2);
					if ( state.backtracking == 0 )
					{

							n = new DivOperatorNode() { Left = node };
							
					}

					}
					break;

				}
				} finally { DebugExitSubRule(7); }

				DebugLocation(181, 10);
				PushFollow(Follow._expr_factor_in_expr_factor868);
				right=expr_factor();
				PopFollow();
				if (state.failed) return node;
				DebugLocation(181, 24);
				if ( state.backtracking == 0 )
				{
					n.Right = right; node = n;
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
		DebugLocation(182, 3);
		} finally { DebugExitRule(GrammarFileName, "expr_factor"); }
		return node;

	}
	// $ANTLR end "expr_factor"


	partial void Enter_expr();
	partial void Leave_expr();

	// $ANTLR start "expr"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:183:1: expr returns [ExpressionNode node] : ( STRING_CONST | INT_CONST | NIL | Minus e= expr_or | id= ID aux= idAux[$id.Text] | LParent (seq= exprSeq )? RParent | If cond= expr_or Then then= expr_or ( Else els= expr_or )? | While cond= expr_or Do body= expr_or | For varName= ID Assign start= expr_or To end= expr_or Do bodyFor= expr_or | Break | Let declarations= declarationList In (seq= exprSeq )? End ) lv= lvalue[$node] ;
	[GrammarRule("expr")]
	private ExpressionNode expr()
	{
		Enter_expr();
		EnterRule("expr", 7);
		TraceIn("expr", 7);
		ExpressionNode node = default(ExpressionNode);

		IToken id=null;
		IToken varName=null;
		IToken STRING_CONST1=null;
		IToken INT_CONST2=null;
		ExpressionNode e = default(ExpressionNode);
		ExpressionNode aux = default(ExpressionNode);
		ExpressionSequenceNode seq = default(ExpressionSequenceNode);
		ExpressionNode cond = default(ExpressionNode);
		ExpressionNode then = default(ExpressionNode);
		ExpressionNode els = default(ExpressionNode);
		ExpressionNode body = default(ExpressionNode);
		ExpressionNode start = default(ExpressionNode);
		ExpressionNode end = default(ExpressionNode);
		ExpressionNode bodyFor = default(ExpressionNode);
		IList<DeclarationNode> declarations = default(IList<DeclarationNode>);
		ExpressionNode lv = default(ExpressionNode);

		try { DebugEnterRule(GrammarFileName, "expr");
		DebugLocation(183, 42);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:183:35: ( ( STRING_CONST | INT_CONST | NIL | Minus e= expr_or | id= ID aux= idAux[$id.Text] | LParent (seq= exprSeq )? RParent | If cond= expr_or Then then= expr_or ( Else els= expr_or )? | While cond= expr_or Do body= expr_or | For varName= ID Assign start= expr_or To end= expr_or Do bodyFor= expr_or | Break | Let declarations= declarationList In (seq= exprSeq )? End ) lv= lvalue[$node] )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:184:2: ( STRING_CONST | INT_CONST | NIL | Minus e= expr_or | id= ID aux= idAux[$id.Text] | LParent (seq= exprSeq )? RParent | If cond= expr_or Then then= expr_or ( Else els= expr_or )? | While cond= expr_or Do body= expr_or | For varName= ID Assign start= expr_or To end= expr_or Do bodyFor= expr_or | Break | Let declarations= declarationList In (seq= exprSeq )? End ) lv= lvalue[$node]
			{
			DebugLocation(184, 2);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:184:2: ( STRING_CONST | INT_CONST | NIL | Minus e= expr_or | id= ID aux= idAux[$id.Text] | LParent (seq= exprSeq )? RParent | If cond= expr_or Then then= expr_or ( Else els= expr_or )? | While cond= expr_or Do body= expr_or | For varName= ID Assign start= expr_or To end= expr_or Do bodyFor= expr_or | Break | Let declarations= declarationList In (seq= exprSeq )? End )
			int alt12=11;
			try { DebugEnterSubRule(12);
			try { DebugEnterDecision(12, decisionCanBacktrack[12]);
			switch (input.LA(1))
			{
			case STRING_CONST:
				{
				alt12=1;
				}
				break;
			case INT_CONST:
				{
				alt12=2;
				}
				break;
			case NIL:
				{
				alt12=3;
				}
				break;
			case Minus:
				{
				alt12=4;
				}
				break;
			case ID:
				{
				alt12=5;
				}
				break;
			case LParent:
				{
				alt12=6;
				}
				break;
			case If:
				{
				alt12=7;
				}
				break;
			case While:
				{
				alt12=8;
				}
				break;
			case For:
				{
				alt12=9;
				}
				break;
			case Break:
				{
				alt12=10;
				}
				break;
			case Let:
				{
				alt12=11;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return node;}
					NoViableAltException nvae = new NoViableAltException("", 12, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(12); }
			switch (alt12)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:185:2: STRING_CONST
				{
				DebugLocation(185, 2);
				STRING_CONST1=(IToken)Match(input,STRING_CONST,Follow._STRING_CONST_in_expr889); if (state.failed) return node;
				DebugLocation(185, 15);
				if ( state.backtracking == 0 )
				{
					node = new StringLiteralNode(STRING_CONST1.Text); 
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:186:2: INT_CONST
				{
				DebugLocation(186, 2);
				INT_CONST2=(IToken)Match(input,INT_CONST,Follow._INT_CONST_in_expr897); if (state.failed) return node;
				DebugLocation(186, 12);
				if ( state.backtracking == 0 )
				{
					node = new IntegerLiteralNode(int.Parse(INT_CONST2.Text)); 
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:187:2: NIL
				{
				DebugLocation(187, 2);
				Match(input,NIL,Follow._NIL_in_expr905); if (state.failed) return node;
				DebugLocation(187, 6);
				if ( state.backtracking == 0 )
				{
					node = new NilLiteralNode(); 
				}

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:188:2: Minus e= expr_or
				{
				DebugLocation(188, 2);
				Match(input,Minus,Follow._Minus_in_expr913); if (state.failed) return node;
				DebugLocation(188, 10);
				PushFollow(Follow._expr_or_in_expr919);
				e=expr_or();
				PopFollow();
				if (state.failed) return node;
				DebugLocation(188, 20);
				if ( state.backtracking == 0 )
				{
					node = new MinusUnaryOperatorNode(e); 
				}

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:192:2: id= ID aux= idAux[$id.Text]
				{
				DebugLocation(192, 5);
				id=(IToken)Match(input,ID,Follow._ID_in_expr944); if (state.failed) return node;
				DebugLocation(192, 14);
				PushFollow(Follow._idAux_in_expr950);
				aux=idAux(id.Text);
				PopFollow();
				if (state.failed) return node;
				DebugLocation(192, 32);
				if ( state.backtracking == 0 )
				{
					node = aux;
				}

				}
				break;
			case 6:
				DebugEnterAlt(6);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:193:2: LParent (seq= exprSeq )? RParent
				{
				DebugLocation(193, 2);
				Match(input,LParent,Follow._LParent_in_expr959); if (state.failed) return node;
				DebugLocation(193, 10);
				if ( state.backtracking == 0 )
				{
					node = new ExpressionSequenceNode();
				}
				DebugLocation(193, 50);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:193:50: (seq= exprSeq )?
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
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:193:51: seq= exprSeq
					{
					DebugLocation(193, 55);
					PushFollow(Follow._exprSeq_in_expr968);
					seq=exprSeq();
					PopFollow();
					if (state.failed) return node;
					DebugLocation(193, 65);
					if ( state.backtracking == 0 )
					{
						node = seq;
					}

					}
					break;

				}
				} finally { DebugExitSubRule(9); }

				DebugLocation(193, 88);
				Match(input,RParent,Follow._RParent_in_expr974); if (state.failed) return node;

				}
				break;
			case 7:
				DebugEnterAlt(7);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:194:2: If cond= expr_or Then then= expr_or ( Else els= expr_or )?
				{
				DebugLocation(194, 2);
				Match(input,If,Follow._If_in_expr982); if (state.failed) return node;
				DebugLocation(194, 10);
				PushFollow(Follow._expr_or_in_expr988);
				cond=expr_or();
				PopFollow();
				if (state.failed) return node;
				DebugLocation(194, 20);
				Match(input,Then,Follow._Then_in_expr990); if (state.failed) return node;
				DebugLocation(194, 30);
				PushFollow(Follow._expr_or_in_expr996);
				then=expr_or();
				PopFollow();
				if (state.failed) return node;
				DebugLocation(194, 40);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:194:40: ( Else els= expr_or )?
				int alt10=2;
				try { DebugEnterSubRule(10);
				try { DebugEnterDecision(10, decisionCanBacktrack[10]);
				int LA10_0 = input.LA(1);

				if ((LA10_0==Else))
				{
					alt10=1;
				}
				} finally { DebugExitDecision(10); }
				switch (alt10)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:194:41: Else els= expr_or
					{
					DebugLocation(194, 41);
					Match(input,Else,Follow._Else_in_expr999); if (state.failed) return node;
					DebugLocation(194, 50);
					PushFollow(Follow._expr_or_in_expr1005);
					els=expr_or();
					PopFollow();
					if (state.failed) return node;

					}
					break;

				}
				} finally { DebugExitSubRule(10); }

				DebugLocation(195, 2);
				if ( state.backtracking == 0 )
				{

						node = new IfThenElseNode(cond, then, els);
						
				}

				}
				break;
			case 8:
				DebugEnterAlt(8);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:198:2: While cond= expr_or Do body= expr_or
				{
				DebugLocation(198, 2);
				Match(input,While,Follow._While_in_expr1020); if (state.failed) return node;
				DebugLocation(198, 13);
				PushFollow(Follow._expr_or_in_expr1026);
				cond=expr_or();
				PopFollow();
				if (state.failed) return node;
				DebugLocation(198, 23);
				Match(input,Do,Follow._Do_in_expr1028); if (state.failed) return node;
				DebugLocation(198, 31);
				PushFollow(Follow._expr_or_in_expr1034);
				body=expr_or();
				PopFollow();
				if (state.failed) return node;
				DebugLocation(199, 2);
				if ( state.backtracking == 0 )
				{

						node = new WhileNode(cond, body);
						
				}

				}
				break;
			case 9:
				DebugEnterAlt(9);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:202:2: For varName= ID Assign start= expr_or To end= expr_or Do bodyFor= expr_or
				{
				DebugLocation(202, 2);
				Match(input,For,Follow._For_in_expr1044); if (state.failed) return node;
				DebugLocation(202, 14);
				varName=(IToken)Match(input,ID,Follow._ID_in_expr1050); if (state.failed) return node;
				DebugLocation(202, 19);
				Match(input,Assign,Follow._Assign_in_expr1052); if (state.failed) return node;
				DebugLocation(202, 32);
				PushFollow(Follow._expr_or_in_expr1058);
				start=expr_or();
				PopFollow();
				if (state.failed) return node;
				DebugLocation(202, 42);
				Match(input,To,Follow._To_in_expr1060); if (state.failed) return node;
				DebugLocation(202, 49);
				PushFollow(Follow._expr_or_in_expr1066);
				end=expr_or();
				PopFollow();
				if (state.failed) return node;
				DebugLocation(202, 59);
				Match(input,Do,Follow._Do_in_expr1068); if (state.failed) return node;
				DebugLocation(202, 70);
				PushFollow(Follow._expr_or_in_expr1074);
				bodyFor=expr_or();
				PopFollow();
				if (state.failed) return node;
				DebugLocation(203, 2);
				if ( state.backtracking == 0 )
				{

						node = new ForToDoNode(varName.Text, start, end, bodyFor);
						
				}

				}
				break;
			case 10:
				DebugEnterAlt(10);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:206:2: Break
				{
				DebugLocation(206, 2);
				Match(input,Break,Follow._Break_in_expr1084); if (state.failed) return node;
				DebugLocation(206, 8);
				if ( state.backtracking == 0 )
				{
					 node = new BreakNode(); 
				}

				}
				break;
			case 11:
				DebugEnterAlt(11);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:207:2: Let declarations= declarationList In (seq= exprSeq )? End
				{
				DebugLocation(207, 2);
				Match(input,Let,Follow._Let_in_expr1093); if (state.failed) return node;
				DebugLocation(207, 19);
				PushFollow(Follow._declarationList_in_expr1099);
				declarations=declarationList();
				PopFollow();
				if (state.failed) return node;
				DebugLocation(207, 37);
				if ( state.backtracking == 0 )
				{
					node = new LetInEndNode(declarations); 
				}
				DebugLocation(207, 87);
				Match(input,In,Follow._In_in_expr1103); if (state.failed) return node;
				DebugLocation(207, 90);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:207:90: (seq= exprSeq )?
				int alt11=2;
				try { DebugEnterSubRule(11);
				try { DebugEnterDecision(11, decisionCanBacktrack[11]);
				int LA11_0 = input.LA(1);

				if (((LA11_0>=NIL && LA11_0<=Minus)||LA11_0==LParent||LA11_0==If||(LA11_0>=Break && LA11_0<=While)||LA11_0==For||LA11_0==Let||LA11_0==INT_CONST||LA11_0==STRING_CONST||LA11_0==ID))
				{
					alt11=1;
				}
				} finally { DebugExitDecision(11); }
				switch (alt11)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:207:91: seq= exprSeq
					{
					DebugLocation(207, 95);
					PushFollow(Follow._exprSeq_in_expr1110);
					seq=exprSeq();
					PopFollow();
					if (state.failed) return node;
					DebugLocation(207, 105);
					if ( state.backtracking == 0 )
					{
						((LetInEndNode)node).Expressions = seq; 
					}

					}
					break;

				}
				} finally { DebugExitSubRule(11); }

				DebugLocation(207, 157);
				Match(input,End,Follow._End_in_expr1116); if (state.failed) return node;

				}
				break;

			}
			} finally { DebugExitSubRule(12); }

			DebugLocation(208, 7);
			PushFollow(Follow._lvalue_in_expr1127);
			lv=lvalue(node);
			PopFollow();
			if (state.failed) return node;
			DebugLocation(208, 23);
			if ( state.backtracking == 0 )
			{
				node = lv; 
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
			TraceOut("expr", 7);
			LeaveRule("expr", 7);
			Leave_expr();
		}
		DebugLocation(208, 42);
		} finally { DebugExitRule(GrammarFileName, "expr"); }
		return node;

	}
	// $ANTLR end "expr"


	partial void Enter_idAux();
	partial void Leave_idAux();

	// $ANTLR start "idAux"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:210:1: idAux[string id] returns [ExpressionNode node] : ( LParent (list= exprList )? RParent | ( ( LKey RKey )=> LKey RKey | LKey fields= fieldList RKey ) | ( ( LCorch expr_or RCorch Of )=> ( LCorch length= expr_or RCorch Of initialValue= expr_or ) | lv= lvalue[$node] ( Assign body= expr_or )? ) );
	[GrammarRule("idAux")]
	private ExpressionNode idAux(string id)
	{
		Enter_idAux();
		EnterRule("idAux", 8);
		TraceIn("idAux", 8);
		ExpressionNode node = default(ExpressionNode);

		IList<ExpressionNode> list = default(IList<ExpressionNode>);
		IList<FieldAssignmentNode> fields = default(IList<FieldAssignmentNode>);
		ExpressionNode length = default(ExpressionNode);
		ExpressionNode initialValue = default(ExpressionNode);
		ExpressionNode lv = default(ExpressionNode);
		ExpressionNode body = default(ExpressionNode);

		node = new VariableAccessNode(id); 
		try { DebugEnterRule(GrammarFileName, "idAux");
		DebugLocation(210, 2);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:212:1: ( LParent (list= exprList )? RParent | ( ( LKey RKey )=> LKey RKey | LKey fields= fieldList RKey ) | ( ( LCorch expr_or RCorch Of )=> ( LCorch length= expr_or RCorch Of initialValue= expr_or ) | lv= lvalue[$node] ( Assign body= expr_or )? ) )
			int alt17=3;
			try { DebugEnterDecision(17, decisionCanBacktrack[17]);
			switch (input.LA(1))
			{
			case LParent:
				{
				alt17=1;
				}
				break;
			case LKey:
				{
				alt17=2;
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
				alt17=3;
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
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:213:2: LParent (list= exprList )? RParent
				{
				DebugLocation(213, 2);
				Match(input,LParent,Follow._LParent_in_idAux1151); if (state.failed) return node;
				DebugLocation(213, 10);
				if ( state.backtracking == 0 )
				{
					node = new CallableNode(id, new List<ExpressionNode>()); 
				}
				DebugLocation(213, 70);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:213:70: (list= exprList )?
				int alt13=2;
				try { DebugEnterSubRule(13);
				try { DebugEnterDecision(13, decisionCanBacktrack[13]);
				int LA13_0 = input.LA(1);

				if (((LA13_0>=NIL && LA13_0<=Minus)||LA13_0==LParent||LA13_0==If||(LA13_0>=Break && LA13_0<=While)||LA13_0==For||LA13_0==Let||LA13_0==INT_CONST||LA13_0==STRING_CONST||LA13_0==ID))
				{
					alt13=1;
				}
				} finally { DebugExitDecision(13); }
				switch (alt13)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:213:71: list= exprList
					{
					DebugLocation(213, 76);
					PushFollow(Follow._exprList_in_idAux1159);
					list=exprList();
					PopFollow();
					if (state.failed) return node;
					DebugLocation(213, 87);
					if ( state.backtracking == 0 )
					{
						 node = new CallableNode(id, list); 
					}

					}
					break;

				}
				} finally { DebugExitSubRule(13); }

				DebugLocation(213, 137);
				Match(input,RParent,Follow._RParent_in_idAux1166); if (state.failed) return node;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:214:2: ( ( LKey RKey )=> LKey RKey | LKey fields= fieldList RKey )
				{
				DebugLocation(214, 2);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:214:2: ( ( LKey RKey )=> LKey RKey | LKey fields= fieldList RKey )
				int alt14=2;
				try { DebugEnterSubRule(14);
				try { DebugEnterDecision(14, decisionCanBacktrack[14]);
				int LA14_0 = input.LA(1);

				if ((LA14_0==LKey))
				{
					int LA14_1 = input.LA(2);

					if ((LA14_1==RKey) && (EvaluatePredicate(synpred1_Tiger_fragment)))
					{
						alt14=1;
					}
					else if ((LA14_1==ID))
					{
						alt14=2;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return node;}
						NoViableAltException nvae = new NoViableAltException("", 14, 1, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return node;}
					NoViableAltException nvae = new NoViableAltException("", 14, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
				} finally { DebugExitDecision(14); }
				switch (alt14)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:215:3: ( LKey RKey )=> LKey RKey
					{
					DebugLocation(216, 5);
					Match(input,LKey,Follow._LKey_in_idAux1188); if (state.failed) return node;
					DebugLocation(216, 10);
					Match(input,RKey,Follow._RKey_in_idAux1190); if (state.failed) return node;
					DebugLocation(216, 15);
					if ( state.backtracking == 0 )
					{
						node = new RecordLiteralNode(id, new List<FieldAssignmentNode>()); 
					}

					}
					break;
				case 2:
					DebugEnterAlt(2);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:217:5: LKey fields= fieldList RKey
					{
					DebugLocation(217, 5);
					Match(input,LKey,Follow._LKey_in_idAux1199); if (state.failed) return node;
					DebugLocation(217, 17);
					PushFollow(Follow._fieldList_in_idAux1205);
					fields=fieldList();
					PopFollow();
					if (state.failed) return node;
					DebugLocation(218, 5);
					if ( state.backtracking == 0 )
					{

									 node = new RecordLiteralNode(id, fields);
									 
					}
					DebugLocation(221, 5);
					Match(input,RKey,Follow._RKey_in_idAux1219); if (state.failed) return node;

					}
					break;

				}
				} finally { DebugExitSubRule(14); }


				}
				break;
			case 3:
				DebugEnterAlt(3);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:223:2: ( ( LCorch expr_or RCorch Of )=> ( LCorch length= expr_or RCorch Of initialValue= expr_or ) | lv= lvalue[$node] ( Assign body= expr_or )? )
				{
				DebugLocation(223, 2);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:223:2: ( ( LCorch expr_or RCorch Of )=> ( LCorch length= expr_or RCorch Of initialValue= expr_or ) | lv= lvalue[$node] ( Assign body= expr_or )? )
				int alt16=2;
				try { DebugEnterSubRule(16);
				try { DebugEnterDecision(16, decisionCanBacktrack[16]);
				try
				{
					alt16 = dfa16.Predict(input);
				}
				catch (NoViableAltException nvae)
				{
					DebugRecognitionException(nvae);
					throw;
				}
				} finally { DebugExitDecision(16); }
				switch (alt16)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:223:3: ( LCorch expr_or RCorch Of )=> ( LCorch length= expr_or RCorch Of initialValue= expr_or )
					{
					DebugLocation(224, 2);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:224:2: ( LCorch length= expr_or RCorch Of initialValue= expr_or )
					DebugEnterAlt(1);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:225:2: LCorch length= expr_or RCorch Of initialValue= expr_or
					{
					DebugLocation(225, 2);
					Match(input,LCorch,Follow._LCorch_in_idAux1244); if (state.failed) return node;
					DebugLocation(225, 16);
					PushFollow(Follow._expr_or_in_idAux1250);
					length=expr_or();
					PopFollow();
					if (state.failed) return node;
					DebugLocation(225, 26);
					Match(input,RCorch,Follow._RCorch_in_idAux1252); if (state.failed) return node;
					DebugLocation(225, 33);
					Match(input,Of,Follow._Of_in_idAux1254); if (state.failed) return node;
					DebugLocation(225, 49);
					PushFollow(Follow._expr_or_in_idAux1260);
					initialValue=expr_or();
					PopFollow();
					if (state.failed) return node;
					DebugLocation(226, 2);
					if ( state.backtracking == 0 )
					{

							node = new ArrayLiteralNode(id, length, initialValue); 
							
					}

					}


					}
					break;
				case 2:
					DebugEnterAlt(2);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:230:2: lv= lvalue[$node] ( Assign body= expr_or )?
					{
					DebugLocation(230, 5);
					PushFollow(Follow._lvalue_in_idAux1277);
					lv=lvalue(node);
					PopFollow();
					if (state.failed) return node;
					DebugLocation(230, 21);
					if ( state.backtracking == 0 )
					{
						node = lv; 
					}
					DebugLocation(230, 41);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:230:41: ( Assign body= expr_or )?
					int alt15=2;
					try { DebugEnterSubRule(15);
					try { DebugEnterDecision(15, decisionCanBacktrack[15]);
					int LA15_0 = input.LA(1);

					if ((LA15_0==Assign))
					{
						alt15=1;
					}
					} finally { DebugExitDecision(15); }
					switch (alt15)
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:230:42: Assign body= expr_or
						{
						DebugLocation(230, 42);
						Match(input,Assign,Follow._Assign_in_idAux1282); if (state.failed) return node;
						DebugLocation(230, 54);
						PushFollow(Follow._expr_or_in_idAux1288);
						body=expr_or();
						PopFollow();
						if (state.failed) return node;
						DebugLocation(230, 64);
						if ( state.backtracking == 0 )
						{
							node = new AssignmentNode((AccessNode)node, body);
						}

						}
						break;

					}
					} finally { DebugExitSubRule(15); }


					}
					break;

				}
				} finally { DebugExitSubRule(16); }


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
			TraceOut("idAux", 8);
			LeaveRule("idAux", 8);
			Leave_idAux();
		}
		DebugLocation(231, 2);
		} finally { DebugExitRule(GrammarFileName, "idAux"); }
		return node;

	}
	// $ANTLR end "idAux"


	partial void Enter_exprSeq();
	partial void Leave_exprSeq();

	// $ANTLR start "exprSeq"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:232:1: exprSeq returns [ExpressionSequenceNode node] : e1= expr_or ( DotComma e2= expr_or )* ;
	[GrammarRule("exprSeq")]
	private ExpressionSequenceNode exprSeq()
	{
		Enter_exprSeq();
		EnterRule("exprSeq", 9);
		TraceIn("exprSeq", 9);
		ExpressionSequenceNode node = default(ExpressionSequenceNode);

		ExpressionNode e1 = default(ExpressionNode);
		ExpressionNode e2 = default(ExpressionNode);

		node = new ExpressionSequenceNode();
		try { DebugEnterRule(GrammarFileName, "exprSeq");
		DebugLocation(232, 156);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:234:1: (e1= expr_or ( DotComma e2= expr_or )* )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:234:3: e1= expr_or ( DotComma e2= expr_or )*
			{
			DebugLocation(234, 6);
			PushFollow(Follow._expr_or_in_exprSeq1316);
			e1=expr_or();
			PopFollow();
			if (state.failed) return node;
			DebugLocation(234, 16);
			if ( state.backtracking == 0 )
			{
				((ExpressionSequenceNode)node).Sequence.Add(e1); 
			}
			DebugLocation(234, 74);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:234:74: ( DotComma e2= expr_or )*
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
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:234:75: DotComma e2= expr_or
					{
					DebugLocation(234, 75);
					Match(input,DotComma,Follow._DotComma_in_exprSeq1320); if (state.failed) return node;
					DebugLocation(234, 87);
					PushFollow(Follow._expr_or_in_exprSeq1326);
					e2=expr_or();
					PopFollow();
					if (state.failed) return node;
					DebugLocation(234, 97);
					if ( state.backtracking == 0 )
					{
						((ExpressionSequenceNode)node).Sequence.Add(e2); 
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
			TraceOut("exprSeq", 9);
			LeaveRule("exprSeq", 9);
			Leave_exprSeq();
		}
		DebugLocation(234, 156);
		} finally { DebugExitRule(GrammarFileName, "exprSeq"); }
		return node;

	}
	// $ANTLR end "exprSeq"


	partial void Enter_exprList();
	partial void Leave_exprList();

	// $ANTLR start "exprList"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:236:1: exprList returns [IList<ExpressionNode> items] : e1= expr_or ( Comma e2= expr_or )* ;
	[GrammarRule("exprList")]
	private IList<ExpressionNode> exprList()
	{
		Enter_exprList();
		EnterRule("exprList", 10);
		TraceIn("exprList", 10);
		IList<ExpressionNode> items = default(IList<ExpressionNode>);

		ExpressionNode e1 = default(ExpressionNode);
		ExpressionNode e2 = default(ExpressionNode);

		items = new List<ExpressionNode>();
		try { DebugEnterRule(GrammarFileName, "exprList");
		DebugLocation(236, 82);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:238:1: (e1= expr_or ( Comma e2= expr_or )* )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:238:3: e1= expr_or ( Comma e2= expr_or )*
			{
			DebugLocation(238, 6);
			PushFollow(Follow._expr_or_in_exprList1354);
			e1=expr_or();
			PopFollow();
			if (state.failed) return items;
			DebugLocation(238, 16);
			if ( state.backtracking == 0 )
			{
				items.Add(e1);
			}
			DebugLocation(238, 39);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:238:39: ( Comma e2= expr_or )*
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
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:238:40: Comma e2= expr_or
					{
					DebugLocation(238, 40);
					Match(input,Comma,Follow._Comma_in_exprList1359); if (state.failed) return items;
					DebugLocation(238, 49);
					PushFollow(Follow._expr_or_in_exprList1365);
					e2=expr_or();
					PopFollow();
					if (state.failed) return items;
					DebugLocation(238, 59);
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
			TraceOut("exprList", 10);
			LeaveRule("exprList", 10);
			Leave_exprList();
		}
		DebugLocation(238, 82);
		} finally { DebugExitRule(GrammarFileName, "exprList"); }
		return items;

	}
	// $ANTLR end "exprList"


	partial void Enter_fieldList();
	partial void Leave_fieldList();

	// $ANTLR start "fieldList"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:240:1: fieldList returns [IList<FieldAssignmentNode> items] : id= idAssign ( Comma id= idAssign )* ;
	[GrammarRule("fieldList")]
	private IList<FieldAssignmentNode> fieldList()
	{
		Enter_fieldList();
		EnterRule("fieldList", 11);
		TraceIn("fieldList", 11);
		IList<FieldAssignmentNode> items = default(IList<FieldAssignmentNode>);

		FieldAssignmentNode id = default(FieldAssignmentNode);

		items = new List<FieldAssignmentNode>(); 
		try { DebugEnterRule(GrammarFileName, "fieldList");
		DebugLocation(240, 85);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:241:51: (id= idAssign ( Comma id= idAssign )* )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:242:2: id= idAssign ( Comma id= idAssign )*
			{
			DebugLocation(242, 5);
			PushFollow(Follow._idAssign_in_fieldList1392);
			id=idAssign();
			PopFollow();
			if (state.failed) return items;
			DebugLocation(242, 16);
			if ( state.backtracking == 0 )
			{
				items.Add(id);
			}
			DebugLocation(242, 40);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:242:40: ( Comma id= idAssign )*
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
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:242:41: Comma id= idAssign
					{
					DebugLocation(242, 41);
					Match(input,Comma,Follow._Comma_in_fieldList1397); if (state.failed) return items;
					DebugLocation(242, 50);
					PushFollow(Follow._idAssign_in_fieldList1403);
					id=idAssign();
					PopFollow();
					if (state.failed) return items;
					DebugLocation(242, 61);
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
			TraceOut("fieldList", 11);
			LeaveRule("fieldList", 11);
			Leave_fieldList();
		}
		DebugLocation(242, 85);
		} finally { DebugExitRule(GrammarFileName, "fieldList"); }
		return items;

	}
	// $ANTLR end "fieldList"


	partial void Enter_idAssign();
	partial void Leave_idAssign();

	// $ANTLR start "idAssign"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:244:1: idAssign returns [FieldAssignmentNode node] : fieldName= ID Equals body= expr_or ;
	[GrammarRule("idAssign")]
	private FieldAssignmentNode idAssign()
	{
		Enter_idAssign();
		EnterRule("idAssign", 12);
		TraceIn("idAssign", 12);
		FieldAssignmentNode node = default(FieldAssignmentNode);

		IToken fieldName=null;
		ExpressionNode body = default(ExpressionNode);

		try { DebugEnterRule(GrammarFileName, "idAssign");
		DebugLocation(244, 100);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:244:44: (fieldName= ID Equals body= expr_or )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:245:1: fieldName= ID Equals body= expr_or
			{
			DebugLocation(245, 11);
			fieldName=(IToken)Match(input,ID,Follow._ID_in_idAssign1425); if (state.failed) return node;
			DebugLocation(245, 16);
			Match(input,Equals,Follow._Equals_in_idAssign1427); if (state.failed) return node;
			DebugLocation(245, 28);
			PushFollow(Follow._expr_or_in_idAssign1433);
			body=expr_or();
			PopFollow();
			if (state.failed) return node;
			DebugLocation(245, 38);
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
			TraceOut("idAssign", 12);
			LeaveRule("idAssign", 12);
			Leave_idAssign();
		}
		DebugLocation(245, 100);
		} finally { DebugExitRule(GrammarFileName, "idAssign"); }
		return node;

	}
	// $ANTLR end "idAssign"


	partial void Enter_lvalue();
	partial void Leave_lvalue();

	// $ANTLR start "lvalue"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:247:1: lvalue[ExpressionNode accessNode] returns [ExpressionNode node] : ( Dot fieldName= ID | LCorch index= expr_or RCorch )* ;
	[GrammarRule("lvalue")]
	private ExpressionNode lvalue(ExpressionNode accessNode)
	{
		Enter_lvalue();
		EnterRule("lvalue", 13);
		TraceIn("lvalue", 13);
		ExpressionNode node = default(ExpressionNode);

		IToken fieldName=null;
		ExpressionNode index = default(ExpressionNode);

		try { DebugEnterRule(GrammarFileName, "lvalue");
		DebugLocation(247, 2);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:247:65: ( ( Dot fieldName= ID | LCorch index= expr_or RCorch )* )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:248:1: ( Dot fieldName= ID | LCorch index= expr_or RCorch )*
			{
			DebugLocation(248, 1);
			if ( state.backtracking == 0 )
			{
				node = accessNode;
			}
			DebugLocation(249, 1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:249:1: ( Dot fieldName= ID | LCorch index= expr_or RCorch )*
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
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:250:1: Dot fieldName= ID
					{
					DebugLocation(250, 1);
					Match(input,Dot,Follow._Dot_in_lvalue1455); if (state.failed) return node;
					DebugLocation(250, 15);
					fieldName=(IToken)Match(input,ID,Follow._ID_in_lvalue1461); if (state.failed) return node;
					DebugLocation(250, 20);
					if ( state.backtracking == 0 )
					{
						node = new RecordAccessNode(node, fieldName.Text);
					}

					}
					break;
				case 2:
					DebugEnterAlt(2);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:251:1: LCorch index= expr_or RCorch
					{
					DebugLocation(251, 1);
					Match(input,LCorch,Follow._LCorch_in_lvalue1467); if (state.failed) return node;
					DebugLocation(251, 14);
					PushFollow(Follow._expr_or_in_lvalue1473);
					index=expr_or();
					PopFollow();
					if (state.failed) return node;
					DebugLocation(251, 24);
					Match(input,RCorch,Follow._RCorch_in_lvalue1475); if (state.failed) return node;
					DebugLocation(251, 31);
					if ( state.backtracking == 0 )
					{
						node = new ArrayAccessNode(node, index); 
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
			TraceOut("lvalue", 13);
			LeaveRule("lvalue", 13);
			Leave_lvalue();
		}
		DebugLocation(252, 2);
		} finally { DebugExitRule(GrammarFileName, "lvalue"); }
		return node;

	}
	// $ANTLR end "lvalue"


	partial void Enter_declarationList();
	partial void Leave_declarationList();

	// $ANTLR start "declarationList"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:254:1: declarationList returns [IList<DeclarationNode> items] : (dec= declaration )+ ;
	[GrammarRule("declarationList")]
	private IList<DeclarationNode> declarationList()
	{
		Enter_declarationList();
		EnterRule("declarationList", 14);
		TraceIn("declarationList", 14);
		IList<DeclarationNode> items = default(IList<DeclarationNode>);

		DeclarationNode dec = default(DeclarationNode);

		items = new List<DeclarationNode>();
		try { DebugEnterRule(GrammarFileName, "declarationList");
		DebugLocation(254, 48);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:255:45: ( (dec= declaration )+ )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:256:2: (dec= declaration )+
			{
			DebugLocation(256, 2);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:256:2: (dec= declaration )+
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
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:256:3: dec= declaration
					{
					DebugLocation(256, 7);
					PushFollow(Follow._declaration_in_declarationList1507);
					dec=declaration();
					PopFollow();
					if (state.failed) return items;
					DebugLocation(256, 21);
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
			TraceOut("declarationList", 14);
			LeaveRule("declarationList", 14);
			Leave_declarationList();
		}
		DebugLocation(256, 48);
		} finally { DebugExitRule(GrammarFileName, "declarationList"); }
		return items;

	}
	// $ANTLR end "declarationList"


	partial void Enter_declaration();
	partial void Leave_declaration();

	// $ANTLR start "declaration"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:257:1: declaration returns [DeclarationNode node] : (t= typeDeclaration | v= variableDeclaration | f= functionDeclaration );
	[GrammarRule("declaration")]
	private DeclarationNode declaration()
	{
		Enter_declaration();
		EnterRule("declaration", 15);
		TraceIn("declaration", 15);
		DeclarationNode node = default(DeclarationNode);

		TypeDeclarationNode t = default(TypeDeclarationNode);
		VariableDeclarationNode v = default(VariableDeclarationNode);
		CallableDeclarationNode f = default(CallableDeclarationNode);

		try { DebugEnterRule(GrammarFileName, "declaration");
		DebugLocation(257, 43);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:257:44: (t= typeDeclaration | v= variableDeclaration | f= functionDeclaration )
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
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:259:1: t= typeDeclaration
				{
				DebugLocation(259, 3);
				PushFollow(Follow._typeDeclaration_in_declaration1533);
				t=typeDeclaration();
				PopFollow();
				if (state.failed) return node;
				DebugLocation(259, 21);
				if ( state.backtracking == 0 )
				{
					 node = t; 
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:260:1: v= variableDeclaration
				{
				DebugLocation(260, 3);
				PushFollow(Follow._variableDeclaration_in_declaration1543);
				v=variableDeclaration();
				PopFollow();
				if (state.failed) return node;
				DebugLocation(260, 25);
				if ( state.backtracking == 0 )
				{
					 node = v; 
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:261:1: f= functionDeclaration
				{
				DebugLocation(261, 3);
				PushFollow(Follow._functionDeclaration_in_declaration1553);
				f=functionDeclaration();
				PopFollow();
				if (state.failed) return node;
				DebugLocation(261, 25);
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
			TraceOut("declaration", 15);
			LeaveRule("declaration", 15);
			Leave_declaration();
		}
		DebugLocation(261, 43);
		} finally { DebugExitRule(GrammarFileName, "declaration"); }
		return node;

	}
	// $ANTLR end "declaration"


	partial void Enter_typeDeclaration();
	partial void Leave_typeDeclaration();

	// $ANTLR start "typeDeclaration"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:263:1: typeDeclaration returns [TypeDeclarationNode node] : Type name= ID Equals t= type[$name.Text] ;
	[GrammarRule("typeDeclaration")]
	private TypeDeclarationNode typeDeclaration()
	{
		Enter_typeDeclaration();
		EnterRule("typeDeclaration", 16);
		TraceIn("typeDeclaration", 16);
		TypeDeclarationNode node = default(TypeDeclarationNode);

		IToken name=null;
		TypeDeclarationNode t = default(TypeDeclarationNode);

		try { DebugEnterRule(GrammarFileName, "typeDeclaration");
		DebugLocation(263, 62);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:263:52: ( Type name= ID Equals t= type[$name.Text] )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:264:1: Type name= ID Equals t= type[$name.Text]
			{
			DebugLocation(264, 1);
			Match(input,Type,Follow._Type_in_typeDeclaration1568); if (state.failed) return node;
			DebugLocation(264, 11);
			name=(IToken)Match(input,ID,Follow._ID_in_typeDeclaration1574); if (state.failed) return node;
			DebugLocation(264, 16);
			Match(input,Equals,Follow._Equals_in_typeDeclaration1576); if (state.failed) return node;
			DebugLocation(264, 25);
			PushFollow(Follow._type_in_typeDeclaration1582);
			t=type(name.Text);
			PopFollow();
			if (state.failed) return node;
			DebugLocation(264, 44);
			if ( state.backtracking == 0 )
			{
				node = t;
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
			TraceOut("typeDeclaration", 16);
			LeaveRule("typeDeclaration", 16);
			Leave_typeDeclaration();
		}
		DebugLocation(264, 62);
		} finally { DebugExitRule(GrammarFileName, "typeDeclaration"); }
		return node;

	}
	// $ANTLR end "typeDeclaration"


	partial void Enter_type();
	partial void Leave_type();

	// $ANTLR start "type"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:266:1: type[string name] returns [TypeDeclarationNode node] : (id= ID | LKey (fields= typeFields )? RKey | ArrayOf typeName= ID );
	[GrammarRule("type")]
	private TypeDeclarationNode type(string name)
	{
		Enter_type();
		EnterRule("type", 17);
		TraceIn("type", 17);
		TypeDeclarationNode node = default(TypeDeclarationNode);

		IToken id=null;
		IToken typeName=null;
		IList<TypeField> fields = default(IList<TypeField>);

		try { DebugEnterRule(GrammarFileName, "type");
		DebugLocation(266, 80);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:266:54: (id= ID | LKey (fields= typeFields )? RKey | ArrayOf typeName= ID )
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
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:267:2: id= ID
				{
				DebugLocation(267, 5);
				id=(IToken)Match(input,ID,Follow._ID_in_type1607); if (state.failed) return node;
				DebugLocation(267, 10);
				if ( state.backtracking == 0 )
				{
					node = new AliasDeclarationNode(name, id.Text); 
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:268:2: LKey (fields= typeFields )? RKey
				{
				DebugLocation(268, 2);
				Match(input,LKey,Follow._LKey_in_type1615); if (state.failed) return node;
				DebugLocation(268, 7);
				if ( state.backtracking == 0 )
				{
					node = new RecordDeclarationNode(name); 
				}
				DebugLocation(268, 50);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:268:50: (fields= typeFields )?
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
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:268:51: fields= typeFields
					{
					DebugLocation(268, 58);
					PushFollow(Follow._typeFields_in_type1623);
					fields=typeFields();
					PopFollow();
					if (state.failed) return node;
					DebugLocation(268, 71);
					if ( state.backtracking == 0 )
					{
						((RecordDeclarationNode)node).Fields = fields;
					}

					}
					break;

				}
				} finally { DebugExitSubRule(24); }

				DebugLocation(268, 130);
				Match(input,RKey,Follow._RKey_in_type1629); if (state.failed) return node;

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:269:2: ArrayOf typeName= ID
				{
				DebugLocation(269, 2);
				Match(input,ArrayOf,Follow._ArrayOf_in_type1636); if (state.failed) return node;
				DebugLocation(269, 19);
				typeName=(IToken)Match(input,ID,Follow._ID_in_type1642); if (state.failed) return node;
				DebugLocation(269, 24);
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
			TraceOut("type", 17);
			LeaveRule("type", 17);
			Leave_type();
		}
		DebugLocation(269, 80);
		} finally { DebugExitRule(GrammarFileName, "type"); }
		return node;

	}
	// $ANTLR end "type"


	partial void Enter_typeFields();
	partial void Leave_typeFields();

	// $ANTLR start "typeFields"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:271:1: typeFields returns [IList<TypeField> items] : t= typeField ( Comma t= typeField )* ;
	[GrammarRule("typeFields")]
	private IList<TypeField> typeFields()
	{
		Enter_typeFields();
		EnterRule("typeFields", 18);
		TraceIn("typeFields", 18);
		IList<TypeField> items = default(IList<TypeField>);

		TypeField t = default(TypeField);

		items = new List<TypeField>();
		try { DebugEnterRule(GrammarFileName, "typeFields");
		DebugLocation(271, 85);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:272:40: (t= typeField ( Comma t= typeField )* )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:273:1: t= typeField ( Comma t= typeField )*
			{
			DebugLocation(273, 3);
			PushFollow(Follow._typeField_in_typeFields1668);
			t=typeField();
			PopFollow();
			if (state.failed) return items;
			DebugLocation(273, 15);
			if ( state.backtracking == 0 )
			{
				items.Add(t); 
			}
			DebugLocation(273, 40);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:273:40: ( Comma t= typeField )*
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
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:273:41: Comma t= typeField
					{
					DebugLocation(273, 41);
					Match(input,Comma,Follow._Comma_in_typeFields1673); if (state.failed) return items;
					DebugLocation(273, 49);
					PushFollow(Follow._typeField_in_typeFields1679);
					t=typeField();
					PopFollow();
					if (state.failed) return items;
					DebugLocation(273, 61);
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
			TraceOut("typeFields", 18);
			LeaveRule("typeFields", 18);
			Leave_typeFields();
		}
		DebugLocation(273, 85);
		} finally { DebugExitRule(GrammarFileName, "typeFields"); }
		return items;

	}
	// $ANTLR end "typeFields"


	partial void Enter_typeField();
	partial void Leave_typeField();

	// $ANTLR start "typeField"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:275:1: typeField returns [TypeField value] : id= ID ':' typeId= ID ;
	[GrammarRule("typeField")]
	private TypeField typeField()
	{
		Enter_typeField();
		EnterRule("typeField", 19);
		TraceIn("typeField", 19);
		TypeField value = default(TypeField);

		IToken id=null;
		IToken typeId=null;

		try { DebugEnterRule(GrammarFileName, "typeField");
		DebugLocation(275, 111);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:275:37: (id= ID ':' typeId= ID )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:275:39: id= ID ':' typeId= ID
			{
			DebugLocation(275, 42);
			id=(IToken)Match(input,ID,Follow._ID_in_typeField1701); if (state.failed) return value;
			DebugLocation(275, 47);
			Match(input,54,Follow._54_in_typeField1703); if (state.failed) return value;
			DebugLocation(275, 58);
			typeId=(IToken)Match(input,ID,Follow._ID_in_typeField1709); if (state.failed) return value;
			DebugLocation(275, 63);
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
			TraceOut("typeField", 19);
			LeaveRule("typeField", 19);
			Leave_typeField();
		}
		DebugLocation(275, 111);
		} finally { DebugExitRule(GrammarFileName, "typeField"); }
		return value;

	}
	// $ANTLR end "typeField"


	partial void Enter_variableDeclaration();
	partial void Leave_variableDeclaration();

	// $ANTLR start "variableDeclaration"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:277:1: variableDeclaration returns [VariableDeclarationNode node] : Var name= ID ( ':' tName= ID )? Assign body= expr_or ;
	[GrammarRule("variableDeclaration")]
	private VariableDeclarationNode variableDeclaration()
	{
		Enter_variableDeclaration();
		EnterRule("variableDeclaration", 20);
		TraceIn("variableDeclaration", 20);
		VariableDeclarationNode node = default(VariableDeclarationNode);

		IToken name=null;
		IToken tName=null;
		ExpressionNode body = default(ExpressionNode);

		string typeName = null;
		try { DebugEnterRule(GrammarFileName, "variableDeclaration");
		DebugLocation(277, 72);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:278:32: ( Var name= ID ( ':' tName= ID )? Assign body= expr_or )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:279:1: Var name= ID ( ':' tName= ID )? Assign body= expr_or
			{
			DebugLocation(279, 1);
			Match(input,Var,Follow._Var_in_variableDeclaration1728); if (state.failed) return node;
			DebugLocation(279, 10);
			name=(IToken)Match(input,ID,Follow._ID_in_variableDeclaration1734); if (state.failed) return node;
			DebugLocation(279, 15);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:279:15: ( ':' tName= ID )?
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
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:279:16: ':' tName= ID
				{
				DebugLocation(279, 16);
				Match(input,54,Follow._54_in_variableDeclaration1737); if (state.failed) return node;
				DebugLocation(279, 26);
				tName=(IToken)Match(input,ID,Follow._ID_in_variableDeclaration1743); if (state.failed) return node;
				DebugLocation(279, 31);
				if ( state.backtracking == 0 )
				{
					typeName = tName.Text;
				}

				}
				break;

			}
			} finally { DebugExitSubRule(27); }

			DebugLocation(279, 59);
			Match(input,Assign,Follow._Assign_in_variableDeclaration1749); if (state.failed) return node;
			DebugLocation(279, 71);
			PushFollow(Follow._expr_or_in_variableDeclaration1755);
			body=expr_or();
			PopFollow();
			if (state.failed) return node;
			DebugLocation(280, 1);
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
			TraceOut("variableDeclaration", 20);
			LeaveRule("variableDeclaration", 20);
			Leave_variableDeclaration();
		}
		DebugLocation(280, 72);
		} finally { DebugExitRule(GrammarFileName, "variableDeclaration"); }
		return node;

	}
	// $ANTLR end "variableDeclaration"


	partial void Enter_functionDeclaration();
	partial void Leave_functionDeclaration();

	// $ANTLR start "functionDeclaration"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:284:1: functionDeclaration returns [CallableDeclarationNode node] : Function name= ID LParent (f= typeFields )? RParent ( ':' tName= ID )? Equals body= expr_or ;
	[GrammarRule("functionDeclaration")]
	private CallableDeclarationNode functionDeclaration()
	{
		Enter_functionDeclaration();
		EnterRule("functionDeclaration", 21);
		TraceIn("functionDeclaration", 21);
		CallableDeclarationNode node = default(CallableDeclarationNode);

		IToken name=null;
		IToken tName=null;
		IList<TypeField> f = default(IList<TypeField>);
		ExpressionNode body = default(ExpressionNode);


		IList<TypeField> fields = new List<TypeField>();
		string typeName = null;

		try { DebugEnterRule(GrammarFileName, "functionDeclaration");
		DebugLocation(284, 0);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:289:1: ( Function name= ID LParent (f= typeFields )? RParent ( ':' tName= ID )? Equals body= expr_or )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:290:1: Function name= ID LParent (f= typeFields )? RParent ( ':' tName= ID )? Equals body= expr_or
			{
			DebugLocation(290, 1);
			Match(input,Function,Follow._Function_in_functionDeclaration1793); if (state.failed) return node;
			DebugLocation(290, 15);
			name=(IToken)Match(input,ID,Follow._ID_in_functionDeclaration1799); if (state.failed) return node;
			DebugLocation(290, 20);
			Match(input,LParent,Follow._LParent_in_functionDeclaration1801); if (state.failed) return node;
			DebugLocation(290, 28);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:290:28: (f= typeFields )?
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
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:290:29: f= typeFields
				{
				DebugLocation(290, 31);
				PushFollow(Follow._typeFields_in_functionDeclaration1808);
				f=typeFields();
				PopFollow();
				if (state.failed) return node;
				DebugLocation(290, 44);
				if ( state.backtracking == 0 )
				{
					fields = f;
				}

				}
				break;

			}
			} finally { DebugExitSubRule(28); }

			DebugLocation(290, 67);
			Match(input,RParent,Follow._RParent_in_functionDeclaration1814); if (state.failed) return node;
			DebugLocation(290, 75);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:290:75: ( ':' tName= ID )?
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
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:290:76: ':' tName= ID
				{
				DebugLocation(290, 76);
				Match(input,54,Follow._54_in_functionDeclaration1817); if (state.failed) return node;
				DebugLocation(290, 86);
				tName=(IToken)Match(input,ID,Follow._ID_in_functionDeclaration1823); if (state.failed) return node;
				DebugLocation(290, 91);
				if ( state.backtracking == 0 )
				{
					typeName = tName.Text;
				}

				}
				break;

			}
			} finally { DebugExitSubRule(29); }

			DebugLocation(290, 119);
			Match(input,Equals,Follow._Equals_in_functionDeclaration1829); if (state.failed) return node;
			DebugLocation(290, 131);
			PushFollow(Follow._expr_or_in_functionDeclaration1835);
			body=expr_or();
			PopFollow();
			if (state.failed) return node;
			DebugLocation(291, 1);
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
			TraceOut("functionDeclaration", 21);
			LeaveRule("functionDeclaration", 21);
			Leave_functionDeclaration();
		}
		DebugLocation(292, 0);
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
		EnterRule("synpred1_Tiger_fragment", 22);
		TraceIn("synpred1_Tiger_fragment", 22);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:215:3: ( LKey RKey )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:215:4: LKey RKey
			{
			DebugLocation(215, 4);
			Match(input,LKey,Follow._LKey_in_synpred1_Tiger1176); if (state.failed) return;
			DebugLocation(215, 9);
			Match(input,RKey,Follow._RKey_in_synpred1_Tiger1178); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred1_Tiger_fragment", 22);
			LeaveRule("synpred1_Tiger_fragment", 22);
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
		EnterRule("synpred2_Tiger_fragment", 23);
		TraceIn("synpred2_Tiger_fragment", 23);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:223:3: ( LCorch expr_or RCorch Of )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:223:4: LCorch expr_or RCorch Of
			{
			DebugLocation(223, 4);
			Match(input,LCorch,Follow._LCorch_in_synpred2_Tiger1228); if (state.failed) return;
			DebugLocation(223, 11);
			PushFollow(Follow._expr_or_in_synpred2_Tiger1230);
			expr_or();
			PopFollow();
			if (state.failed) return;
			DebugLocation(223, 19);
			Match(input,RCorch,Follow._RCorch_in_synpred2_Tiger1232); if (state.failed) return;
			DebugLocation(223, 26);
			Match(input,Of,Follow._Of_in_synpred2_Tiger1234); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred2_Tiger_fragment", 23);
			LeaveRule("synpred2_Tiger_fragment", 23);
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
	DFA16 dfa16;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa16 = new DFA16( this, SpecialStateTransition16 );
	}

	private class DFA16 : DFA
	{
		private const string DFA16_eotS =
			"\x20\xFFFF";
		private const string DFA16_eofS =
			"\x1\x2\x1F\xFFFF";
		private const string DFA16_minS =
			"\x1\x5\x1\x0\x1E\xFFFF";
		private const string DFA16_maxS =
			"\x1\x29\x1\x0\x1E\xFFFF";
		private const string DFA16_acceptS =
			"\x2\xFFFF\x1\x2\x1C\xFFFF\x1\x1";
		private const string DFA16_specialS =
			"\x1\xFFFF\x1\x0\x1E\xFFFF}>";
		private static readonly string[] DFA16_transitionS =
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

		private static readonly short[] DFA16_eot = DFA.UnpackEncodedString(DFA16_eotS);
		private static readonly short[] DFA16_eof = DFA.UnpackEncodedString(DFA16_eofS);
		private static readonly char[] DFA16_min = DFA.UnpackEncodedStringToUnsignedChars(DFA16_minS);
		private static readonly char[] DFA16_max = DFA.UnpackEncodedStringToUnsignedChars(DFA16_maxS);
		private static readonly short[] DFA16_accept = DFA.UnpackEncodedString(DFA16_acceptS);
		private static readonly short[] DFA16_special = DFA.UnpackEncodedString(DFA16_specialS);
		private static readonly short[][] DFA16_transition;

		static DFA16()
		{
			int numStates = DFA16_transitionS.Length;
			DFA16_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA16_transition[i] = DFA.UnpackEncodedString(DFA16_transitionS[i]);
			}
		}

		public DFA16( BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition )
			: base(specialStateTransition)
		{
			this.recognizer = recognizer;
			this.decisionNumber = 16;
			this.eot = DFA16_eot;
			this.eof = DFA16_eof;
			this.min = DFA16_min;
			this.max = DFA16_max;
			this.accept = DFA16_accept;
			this.special = DFA16_special;
			this.transition = DFA16_transition;
		}

		public override string Description { get { return "223:2: ( ( LCorch expr_or RCorch Of )=> ( LCorch length= expr_or RCorch Of initialValue= expr_or ) | lv= lvalue[$node] ( Assign body= expr_or )? )"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private int SpecialStateTransition16(DFA dfa, int s, IIntStream _input)
	{
		ITokenStream input = (ITokenStream)_input;
		int _s = s;
		switch (s)
		{
			case 0:
				int LA16_1 = input.LA(1);


				int index16_1 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred2_Tiger_fragment)) ) {s = 31;}

				else if ( (true) ) {s = 2;}


				input.Seek(index16_1);
				if ( s>=0 ) return s;
				break;
		}
		if (state.backtracking > 0) {state.failed=true; return -1;}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 16, _s, input);
		dfa.Error(nvae);
		throw nvae;
	}

	#endregion DFA

	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _expr_or_in_prog577 = new BitSet(new ulong[]{0x0UL});
		public static readonly BitSet _EOF_in_prog579 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expr_and_in_expr_or596 = new BitSet(new ulong[]{0x2000000002UL});
		public static readonly BitSet _Or_in_expr_or602 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_or_in_expr_or608 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expr_logical_in_expr_and627 = new BitSet(new ulong[]{0x1000000002UL});
		public static readonly BitSet _And_in_expr_and634 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_and_in_expr_and640 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expr_arithm_in_expr_logical668 = new BitSet(new ulong[]{0xFC0000002UL});
		public static readonly BitSet _Equals_in_expr_logical681 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _NotEquals_in_expr_logical692 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _GThan_in_expr_logical701 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _LThan_in_expr_logical708 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _GEThan_in_expr_logical717 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _LEThan_in_expr_logical726 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_logical_in_expr_logical739 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expr_factor_in_expr_arithm770 = new BitSet(new ulong[]{0x8000022UL});
		public static readonly BitSet _Plus_in_expr_arithm783 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _Minus_in_expr_arithm794 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_arithm_in_expr_arithm806 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expr_in_expr_factor833 = new BitSet(new ulong[]{0x30000002UL});
		public static readonly BitSet _Mult_in_expr_factor845 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _Div_in_expr_factor855 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_factor_in_expr_factor868 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _STRING_CONST_in_expr889 = new BitSet(new ulong[]{0x4000200UL});
		public static readonly BitSet _INT_CONST_in_expr897 = new BitSet(new ulong[]{0x4000200UL});
		public static readonly BitSet _NIL_in_expr905 = new BitSet(new ulong[]{0x4000200UL});
		public static readonly BitSet _Minus_in_expr913 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_or_in_expr919 = new BitSet(new ulong[]{0x4000200UL});
		public static readonly BitSet _ID_in_expr944 = new BitSet(new ulong[]{0x4000AC0UL});
		public static readonly BitSet _idAux_in_expr950 = new BitSet(new ulong[]{0x4000200UL});
		public static readonly BitSet _LParent_in_expr959 = new BitSet(new ulong[]{0x144000008B21B0UL});
		public static readonly BitSet _exprSeq_in_expr968 = new BitSet(new ulong[]{0x100UL});
		public static readonly BitSet _RParent_in_expr974 = new BitSet(new ulong[]{0x4000200UL});
		public static readonly BitSet _If_in_expr982 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_or_in_expr988 = new BitSet(new ulong[]{0x4000UL});
		public static readonly BitSet _Then_in_expr990 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_or_in_expr996 = new BitSet(new ulong[]{0x4008200UL});
		public static readonly BitSet _Else_in_expr999 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_or_in_expr1005 = new BitSet(new ulong[]{0x4000200UL});
		public static readonly BitSet _While_in_expr1020 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_or_in_expr1026 = new BitSet(new ulong[]{0x40000UL});
		public static readonly BitSet _Do_in_expr1028 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_or_in_expr1034 = new BitSet(new ulong[]{0x4000200UL});
		public static readonly BitSet _For_in_expr1044 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _ID_in_expr1050 = new BitSet(new ulong[]{0x40UL});
		public static readonly BitSet _Assign_in_expr1052 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_or_in_expr1058 = new BitSet(new ulong[]{0x100000UL});
		public static readonly BitSet _To_in_expr1060 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_or_in_expr1066 = new BitSet(new ulong[]{0x40000UL});
		public static readonly BitSet _Do_in_expr1068 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_or_in_expr1074 = new BitSet(new ulong[]{0x4000200UL});
		public static readonly BitSet _Break_in_expr1084 = new BitSet(new ulong[]{0x4000200UL});
		public static readonly BitSet _Let_in_expr1093 = new BitSet(new ulong[]{0x34000000000UL});
		public static readonly BitSet _declarationList_in_expr1099 = new BitSet(new ulong[]{0x200000UL});
		public static readonly BitSet _In_in_expr1103 = new BitSet(new ulong[]{0x14400000CB20B0UL});
		public static readonly BitSet _exprSeq_in_expr1110 = new BitSet(new ulong[]{0x400000UL});
		public static readonly BitSet _End_in_expr1116 = new BitSet(new ulong[]{0x4000200UL});
		public static readonly BitSet _lvalue_in_expr1127 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LParent_in_idAux1151 = new BitSet(new ulong[]{0x144000008B21B0UL});
		public static readonly BitSet _exprList_in_idAux1159 = new BitSet(new ulong[]{0x100UL});
		public static readonly BitSet _RParent_in_idAux1166 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LKey_in_idAux1188 = new BitSet(new ulong[]{0x1000UL});
		public static readonly BitSet _RKey_in_idAux1190 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LKey_in_idAux1199 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _fieldList_in_idAux1205 = new BitSet(new ulong[]{0x1000UL});
		public static readonly BitSet _RKey_in_idAux1219 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LCorch_in_idAux1244 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_or_in_idAux1250 = new BitSet(new ulong[]{0x400UL});
		public static readonly BitSet _RCorch_in_idAux1252 = new BitSet(new ulong[]{0x100000000000UL});
		public static readonly BitSet _Of_in_idAux1254 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_or_in_idAux1260 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _lvalue_in_idAux1277 = new BitSet(new ulong[]{0x42UL});
		public static readonly BitSet _Assign_in_idAux1282 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_or_in_idAux1288 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expr_or_in_exprSeq1316 = new BitSet(new ulong[]{0x2000002UL});
		public static readonly BitSet _DotComma_in_exprSeq1320 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_or_in_exprSeq1326 = new BitSet(new ulong[]{0x2000002UL});
		public static readonly BitSet _expr_or_in_exprList1354 = new BitSet(new ulong[]{0x1000002UL});
		public static readonly BitSet _Comma_in_exprList1359 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_or_in_exprList1365 = new BitSet(new ulong[]{0x1000002UL});
		public static readonly BitSet _idAssign_in_fieldList1392 = new BitSet(new ulong[]{0x1000002UL});
		public static readonly BitSet _Comma_in_fieldList1397 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _idAssign_in_fieldList1403 = new BitSet(new ulong[]{0x1000002UL});
		public static readonly BitSet _ID_in_idAssign1425 = new BitSet(new ulong[]{0x40000000UL});
		public static readonly BitSet _Equals_in_idAssign1427 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_or_in_idAssign1433 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _Dot_in_lvalue1455 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _ID_in_lvalue1461 = new BitSet(new ulong[]{0x4000202UL});
		public static readonly BitSet _LCorch_in_lvalue1467 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_or_in_lvalue1473 = new BitSet(new ulong[]{0x400UL});
		public static readonly BitSet _RCorch_in_lvalue1475 = new BitSet(new ulong[]{0x4000202UL});
		public static readonly BitSet _declaration_in_declarationList1507 = new BitSet(new ulong[]{0x34000000002UL});
		public static readonly BitSet _typeDeclaration_in_declaration1533 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _variableDeclaration_in_declaration1543 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _functionDeclaration_in_declaration1553 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _Type_in_typeDeclaration1568 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _ID_in_typeDeclaration1574 = new BitSet(new ulong[]{0x40000000UL});
		public static readonly BitSet _Equals_in_typeDeclaration1576 = new BitSet(new ulong[]{0x10008000000800UL});
		public static readonly BitSet _type_in_typeDeclaration1582 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_type1607 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LKey_in_type1615 = new BitSet(new ulong[]{0x10000000001000UL});
		public static readonly BitSet _typeFields_in_type1623 = new BitSet(new ulong[]{0x1000UL});
		public static readonly BitSet _RKey_in_type1629 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ArrayOf_in_type1636 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _ID_in_type1642 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _typeField_in_typeFields1668 = new BitSet(new ulong[]{0x1000002UL});
		public static readonly BitSet _Comma_in_typeFields1673 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _typeField_in_typeFields1679 = new BitSet(new ulong[]{0x1000002UL});
		public static readonly BitSet _ID_in_typeField1701 = new BitSet(new ulong[]{0x40000000000000UL});
		public static readonly BitSet _54_in_typeField1703 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _ID_in_typeField1709 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _Var_in_variableDeclaration1728 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _ID_in_variableDeclaration1734 = new BitSet(new ulong[]{0x40000000000040UL});
		public static readonly BitSet _54_in_variableDeclaration1737 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _ID_in_variableDeclaration1743 = new BitSet(new ulong[]{0x40UL});
		public static readonly BitSet _Assign_in_variableDeclaration1749 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_or_in_variableDeclaration1755 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _Function_in_functionDeclaration1793 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _ID_in_functionDeclaration1799 = new BitSet(new ulong[]{0x80UL});
		public static readonly BitSet _LParent_in_functionDeclaration1801 = new BitSet(new ulong[]{0x10000000000100UL});
		public static readonly BitSet _typeFields_in_functionDeclaration1808 = new BitSet(new ulong[]{0x100UL});
		public static readonly BitSet _RParent_in_functionDeclaration1814 = new BitSet(new ulong[]{0x40000040000000UL});
		public static readonly BitSet _54_in_functionDeclaration1817 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _ID_in_functionDeclaration1823 = new BitSet(new ulong[]{0x40000000UL});
		public static readonly BitSet _Equals_in_functionDeclaration1829 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_or_in_functionDeclaration1835 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LKey_in_synpred1_Tiger1176 = new BitSet(new ulong[]{0x1000UL});
		public static readonly BitSet _RKey_in_synpred1_Tiger1178 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LCorch_in_synpred2_Tiger1228 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_or_in_synpred2_Tiger1230 = new BitSet(new ulong[]{0x400UL});
		public static readonly BitSet _RCorch_in_synpred2_Tiger1232 = new BitSet(new ulong[]{0x100000000000UL});
		public static readonly BitSet _Of_in_synpred2_Tiger1234 = new BitSet(new ulong[]{0x2UL});

	}
	#endregion Follow sets
}
