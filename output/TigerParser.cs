// $ANTLR 3.3 Nov 30, 2010 12:45:30 C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g 2012-02-09 04:41:56

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 219
// Unreachable code detected.
#pragma warning disable 162


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
				false, false, false, false, false, false, false, false, false, true, 
				false, true, false, false, false, false, false, false, false, false, 
				false, false, false, false, false, false, false, false, false, false
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
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:85:8: public prog : expr_or EOF ;
	[GrammarRule("prog")]
	public void prog()
	{
		Enter_prog();
		EnterRule("prog", 1);
		TraceIn("prog", 1);
		try { DebugEnterRule(GrammarFileName, "prog");
		DebugLocation(85, 25);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:85:12: ( expr_or EOF )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:85:15: expr_or EOF
			{
			DebugLocation(85, 15);
			PushFollow(Follow._expr_or_in_prog551);
			expr_or();
			PopFollow();
			if (state.failed) return;
			DebugLocation(85, 23);
			Match(input,EOF,Follow._EOF_in_prog553); if (state.failed) return;

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
		DebugLocation(85, 25);
		} finally { DebugExitRule(GrammarFileName, "prog"); }
		return;

	}
	// $ANTLR end "prog"


	partial void Enter_expr_or();
	partial void Leave_expr_or();

	// $ANTLR start "expr_or"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:86:1: expr_or : expr_and ( Or expr_and )* ;
	[GrammarRule("expr_or")]
	private void expr_or()
	{
		Enter_expr_or();
		EnterRule("expr_or", 2);
		TraceIn("expr_or", 2);
		try { DebugEnterRule(GrammarFileName, "expr_or");
		DebugLocation(86, 33);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:86:9: ( expr_and ( Or expr_and )* )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:86:11: expr_and ( Or expr_and )*
			{
			DebugLocation(86, 11);
			PushFollow(Follow._expr_and_in_expr_or560);
			expr_and();
			PopFollow();
			if (state.failed) return;
			DebugLocation(86, 20);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:86:20: ( Or expr_and )*
			try { DebugEnterSubRule(1);
			while (true)
			{
				int alt1=2;
				try { DebugEnterDecision(1, decisionCanBacktrack[1]);
				int LA1_0 = input.LA(1);

				if ((LA1_0==Or))
				{
					alt1=1;
				}


				} finally { DebugExitDecision(1); }
				switch ( alt1 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:86:21: Or expr_and
					{
					DebugLocation(86, 21);
					Match(input,Or,Follow._Or_in_expr_or563); if (state.failed) return;
					DebugLocation(86, 24);
					PushFollow(Follow._expr_and_in_expr_or565);
					expr_and();
					PopFollow();
					if (state.failed) return;

					}
					break;

				default:
					goto loop1;
				}
			}

			loop1:
				;

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
		DebugLocation(86, 33);
		} finally { DebugExitRule(GrammarFileName, "expr_or"); }
		return;

	}
	// $ANTLR end "expr_or"


	partial void Enter_expr_and();
	partial void Leave_expr_and();

	// $ANTLR start "expr_and"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:87:1: expr_and : expr_logical ( And expr_logical )* ;
	[GrammarRule("expr_and")]
	private void expr_and()
	{
		Enter_expr_and();
		EnterRule("expr_and", 3);
		TraceIn("expr_and", 3);
		try { DebugEnterRule(GrammarFileName, "expr_and");
		DebugLocation(87, 42);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:87:9: ( expr_logical ( And expr_logical )* )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:87:11: expr_logical ( And expr_logical )*
			{
			DebugLocation(87, 11);
			PushFollow(Follow._expr_logical_in_expr_and573);
			expr_logical();
			PopFollow();
			if (state.failed) return;
			DebugLocation(87, 24);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:87:24: ( And expr_logical )*
			try { DebugEnterSubRule(2);
			while (true)
			{
				int alt2=2;
				try { DebugEnterDecision(2, decisionCanBacktrack[2]);
				int LA2_0 = input.LA(1);

				if ((LA2_0==And))
				{
					alt2=1;
				}


				} finally { DebugExitDecision(2); }
				switch ( alt2 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:87:25: And expr_logical
					{
					DebugLocation(87, 25);
					Match(input,And,Follow._And_in_expr_and576); if (state.failed) return;
					DebugLocation(87, 29);
					PushFollow(Follow._expr_logical_in_expr_and578);
					expr_logical();
					PopFollow();
					if (state.failed) return;

					}
					break;

				default:
					goto loop2;
				}
			}

			loop2:
				;

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
		DebugLocation(87, 42);
		} finally { DebugExitRule(GrammarFileName, "expr_and"); }
		return;

	}
	// $ANTLR end "expr_and"


	partial void Enter_expr_logical();
	partial void Leave_expr_logical();

	// $ANTLR start "expr_logical"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:88:1: expr_logical : expr_arithm ( ( ( ( Equals ) | NotEquals | GThan | LThan | GEThan | LEThan ) ) expr_arithm )* ;
	[GrammarRule("expr_logical")]
	private void expr_logical()
	{
		Enter_expr_logical();
		EnterRule("expr_logical", 4);
		TraceIn("expr_logical", 4);
		try { DebugEnterRule(GrammarFileName, "expr_logical");
		DebugLocation(88, 4);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:89:2: ( expr_arithm ( ( ( ( Equals ) | NotEquals | GThan | LThan | GEThan | LEThan ) ) expr_arithm )* )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:89:4: expr_arithm ( ( ( ( Equals ) | NotEquals | GThan | LThan | GEThan | LEThan ) ) expr_arithm )*
			{
			DebugLocation(89, 4);
			PushFollow(Follow._expr_arithm_in_expr_logical588);
			expr_arithm();
			PopFollow();
			if (state.failed) return;
			DebugLocation(89, 16);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:89:16: ( ( ( ( Equals ) | NotEquals | GThan | LThan | GEThan | LEThan ) ) expr_arithm )*
			try { DebugEnterSubRule(4);
			while (true)
			{
				int alt4=2;
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
				switch ( alt4 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:90:4: ( ( ( Equals ) | NotEquals | GThan | LThan | GEThan | LEThan ) ) expr_arithm
					{
					DebugLocation(90, 4);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:90:4: ( ( ( Equals ) | NotEquals | GThan | LThan | GEThan | LEThan ) )
					DebugEnterAlt(1);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:90:5: ( ( Equals ) | NotEquals | GThan | LThan | GEThan | LEThan )
					{
					DebugLocation(90, 5);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:90:5: ( ( Equals ) | NotEquals | GThan | LThan | GEThan | LEThan )
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
							if (state.backtracking>0) {state.failed=true; return;}
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
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:90:6: ( Equals )
						{
						DebugLocation(90, 6);
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:90:6: ( Equals )
						DebugEnterAlt(1);
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:90:7: Equals
						{
						DebugLocation(90, 7);
						Match(input,Equals,Follow._Equals_in_expr_logical598); if (state.failed) return;

						}


						}
						break;
					case 2:
						DebugEnterAlt(2);
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:90:17: NotEquals
						{
						DebugLocation(90, 17);
						Match(input,NotEquals,Follow._NotEquals_in_expr_logical603); if (state.failed) return;

						}
						break;
					case 3:
						DebugEnterAlt(3);
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:90:29: GThan
						{
						DebugLocation(90, 29);
						Match(input,GThan,Follow._GThan_in_expr_logical607); if (state.failed) return;

						}
						break;
					case 4:
						DebugEnterAlt(4);
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:90:37: LThan
						{
						DebugLocation(90, 37);
						Match(input,LThan,Follow._LThan_in_expr_logical611); if (state.failed) return;

						}
						break;
					case 5:
						DebugEnterAlt(5);
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:90:45: GEThan
						{
						DebugLocation(90, 45);
						Match(input,GEThan,Follow._GEThan_in_expr_logical615); if (state.failed) return;

						}
						break;
					case 6:
						DebugEnterAlt(6);
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:90:54: LEThan
						{
						DebugLocation(90, 54);
						Match(input,LEThan,Follow._LEThan_in_expr_logical619); if (state.failed) return;

						}
						break;

					}
					} finally { DebugExitSubRule(3); }


					}

					DebugLocation(90, 63);
					PushFollow(Follow._expr_arithm_in_expr_logical623);
					expr_arithm();
					PopFollow();
					if (state.failed) return;

					}
					break;

				default:
					goto loop4;
				}
			}

			loop4:
				;

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
		DebugLocation(91, 4);
		} finally { DebugExitRule(GrammarFileName, "expr_logical"); }
		return;

	}
	// $ANTLR end "expr_logical"


	partial void Enter_expr_arithm();
	partial void Leave_expr_arithm();

	// $ANTLR start "expr_arithm"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:92:1: expr_arithm : expr_factor ( ( ( Plus ) | Minus ) expr_factor )* ;
	[GrammarRule("expr_arithm")]
	private void expr_arithm()
	{
		Enter_expr_arithm();
		EnterRule("expr_arithm", 5);
		TraceIn("expr_arithm", 5);
		try { DebugEnterRule(GrammarFileName, "expr_arithm");
		DebugLocation(92, 46);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:93:2: ( expr_factor ( ( ( Plus ) | Minus ) expr_factor )* )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:93:4: expr_factor ( ( ( Plus ) | Minus ) expr_factor )*
			{
			DebugLocation(93, 4);
			PushFollow(Follow._expr_factor_in_expr_arithm636);
			expr_factor();
			PopFollow();
			if (state.failed) return;
			DebugLocation(93, 16);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:93:16: ( ( ( Plus ) | Minus ) expr_factor )*
			try { DebugEnterSubRule(6);
			while (true)
			{
				int alt6=2;
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
				switch ( alt6 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:93:17: ( ( Plus ) | Minus ) expr_factor
					{
					DebugLocation(93, 17);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:93:17: ( ( Plus ) | Minus )
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
						if (state.backtracking>0) {state.failed=true; return;}
						NoViableAltException nvae = new NoViableAltException("", 5, 0, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
					} finally { DebugExitDecision(5); }
					switch (alt5)
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:93:18: ( Plus )
						{
						DebugLocation(93, 18);
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:93:18: ( Plus )
						DebugEnterAlt(1);
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:93:19: Plus
						{
						DebugLocation(93, 19);
						Match(input,Plus,Follow._Plus_in_expr_arithm641); if (state.failed) return;

						}


						}
						break;
					case 2:
						DebugEnterAlt(2);
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:93:27: Minus
						{
						DebugLocation(93, 27);
						Match(input,Minus,Follow._Minus_in_expr_arithm646); if (state.failed) return;

						}
						break;

					}
					} finally { DebugExitSubRule(5); }

					DebugLocation(93, 34);
					PushFollow(Follow._expr_factor_in_expr_arithm649);
					expr_factor();
					PopFollow();
					if (state.failed) return;

					}
					break;

				default:
					goto loop6;
				}
			}

			loop6:
				;

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
		DebugLocation(93, 46);
		} finally { DebugExitRule(GrammarFileName, "expr_arithm"); }
		return;

	}
	// $ANTLR end "expr_arithm"


	partial void Enter_expr_factor();
	partial void Leave_expr_factor();

	// $ANTLR start "expr_factor"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:94:1: expr_factor : expr ( ( ( Mult ) | Div ) expr )* ;
	[GrammarRule("expr_factor")]
	private void expr_factor()
	{
		Enter_expr_factor();
		EnterRule("expr_factor", 6);
		TraceIn("expr_factor", 6);
		try { DebugEnterRule(GrammarFileName, "expr_factor");
		DebugLocation(94, 30);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:95:2: ( expr ( ( ( Mult ) | Div ) expr )* )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:95:4: expr ( ( ( Mult ) | Div ) expr )*
			{
			DebugLocation(95, 4);
			PushFollow(Follow._expr_in_expr_factor659);
			expr();
			PopFollow();
			if (state.failed) return;
			DebugLocation(95, 9);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:95:9: ( ( ( Mult ) | Div ) expr )*
			try { DebugEnterSubRule(8);
			while (true)
			{
				int alt8=2;
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
				switch ( alt8 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:95:10: ( ( Mult ) | Div ) expr
					{
					DebugLocation(95, 10);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:95:10: ( ( Mult ) | Div )
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
						if (state.backtracking>0) {state.failed=true; return;}
						NoViableAltException nvae = new NoViableAltException("", 7, 0, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
					} finally { DebugExitDecision(7); }
					switch (alt7)
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:95:11: ( Mult )
						{
						DebugLocation(95, 11);
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:95:11: ( Mult )
						DebugEnterAlt(1);
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:95:12: Mult
						{
						DebugLocation(95, 12);
						Match(input,Mult,Follow._Mult_in_expr_factor664); if (state.failed) return;

						}


						}
						break;
					case 2:
						DebugEnterAlt(2);
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:95:20: Div
						{
						DebugLocation(95, 20);
						Match(input,Div,Follow._Div_in_expr_factor669); if (state.failed) return;

						}
						break;

					}
					} finally { DebugExitSubRule(7); }

					DebugLocation(95, 25);
					PushFollow(Follow._expr_in_expr_factor672);
					expr();
					PopFollow();
					if (state.failed) return;

					}
					break;

				default:
					goto loop8;
				}
			}

			loop8:
				;

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
		DebugLocation(95, 30);
		} finally { DebugExitRule(GrammarFileName, "expr_factor"); }
		return;

	}
	// $ANTLR end "expr_factor"


	partial void Enter_expr();
	partial void Leave_expr();

	// $ANTLR start "expr"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:96:1: expr : ( STRING_CONST | INT_CONST | NIL | Minus expr_or | ID ( LParent ( exprList )? RParent | ( ( LKey RKey )=> LKey RKey | LKey fieldList RKey ) | ( ( LCorch expr_or RCorch Of )=> ( LCorch expr_or RCorch Of expr_or ) | lvalue ( Assign expr_or )? ) ) | LParent ( exprSeq )? RParent | If expr_or Then expr_or ( Else expr_or )? | While expr_or Do expr_or | For ID Assign expr_or To expr_or Do expr_or | Break | Let declarationList In ( exprSeq )? End );
	[GrammarRule("expr")]
	private void expr()
	{
		Enter_expr();
		EnterRule("expr", 7);
		TraceIn("expr", 7);
		try { DebugEnterRule(GrammarFileName, "expr");
		DebugLocation(96, 39);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:96:6: ( STRING_CONST | INT_CONST | NIL | Minus expr_or | ID ( LParent ( exprList )? RParent | ( ( LKey RKey )=> LKey RKey | LKey fieldList RKey ) | ( ( LCorch expr_or RCorch Of )=> ( LCorch expr_or RCorch Of expr_or ) | lvalue ( Assign expr_or )? ) ) | LParent ( exprSeq )? RParent | If expr_or Then expr_or ( Else expr_or )? | While expr_or Do expr_or | For ID Assign expr_or To expr_or Do expr_or | Break | Let declarationList In ( exprSeq )? End )
			int alt17=11;
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
					if (state.backtracking>0) {state.failed=true; return;}
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
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:96:8: STRING_CONST
				{
				DebugLocation(96, 8);
				Match(input,STRING_CONST,Follow._STRING_CONST_in_expr681); if (state.failed) return;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:97:3: INT_CONST
				{
				DebugLocation(97, 3);
				Match(input,INT_CONST,Follow._INT_CONST_in_expr689); if (state.failed) return;

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:98:3: NIL
				{
				DebugLocation(98, 3);
				Match(input,NIL,Follow._NIL_in_expr697); if (state.failed) return;

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:99:3: Minus expr_or
				{
				DebugLocation(99, 3);
				Match(input,Minus,Follow._Minus_in_expr705); if (state.failed) return;
				DebugLocation(99, 9);
				PushFollow(Follow._expr_or_in_expr707);
				expr_or();
				PopFollow();
				if (state.failed) return;

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:103:3: ID ( LParent ( exprList )? RParent | ( ( LKey RKey )=> LKey RKey | LKey fieldList RKey ) | ( ( LCorch expr_or RCorch Of )=> ( LCorch expr_or RCorch Of expr_or ) | lvalue ( Assign expr_or )? ) )
				{
				DebugLocation(103, 3);
				Match(input,ID,Follow._ID_in_expr731); if (state.failed) return;
				DebugLocation(104, 3);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:104:3: ( LParent ( exprList )? RParent | ( ( LKey RKey )=> LKey RKey | LKey fieldList RKey ) | ( ( LCorch expr_or RCorch Of )=> ( LCorch expr_or RCorch Of expr_or ) | lvalue ( Assign expr_or )? ) )
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
						if (state.backtracking>0) {state.failed=true; return;}
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
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:105:4: LParent ( exprList )? RParent
					{
					DebugLocation(105, 4);
					Match(input,LParent,Follow._LParent_in_expr741); if (state.failed) return;
					DebugLocation(105, 12);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:105:12: ( exprList )?
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
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:105:13: exprList
						{
						DebugLocation(105, 13);
						PushFollow(Follow._exprList_in_expr744);
						exprList();
						PopFollow();
						if (state.failed) return;

						}
						break;

					}
					} finally { DebugExitSubRule(9); }

					DebugLocation(105, 24);
					Match(input,RParent,Follow._RParent_in_expr748); if (state.failed) return;

					}
					break;
				case 2:
					DebugEnterAlt(2);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:106:4: ( ( LKey RKey )=> LKey RKey | LKey fieldList RKey )
					{
					DebugLocation(106, 4);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:106:4: ( ( LKey RKey )=> LKey RKey | LKey fieldList RKey )
					int alt10=2;
					try { DebugEnterSubRule(10);
					try { DebugEnterDecision(10, decisionCanBacktrack[10]);
					int LA10_0 = input.LA(1);

					if ((LA10_0==LKey))
					{
						int LA10_1 = input.LA(2);

						if ((LA10_1==RKey))
						{
							int LA10_2 = input.LA(3);

							if ((EvaluatePredicate(synpred1_Tiger_fragment)))
							{
								alt10=1;
							}
							else if ((true))
							{
								alt10=2;
							}
							else
							{
								if (state.backtracking>0) {state.failed=true; return;}
								NoViableAltException nvae = new NoViableAltException("", 10, 2, input);

								DebugRecognitionException(nvae);
								throw nvae;
							}
						}
						else if ((LA10_1==Comma||LA10_1==ID))
						{
							alt10=2;
						}
						else
						{
							if (state.backtracking>0) {state.failed=true; return;}
							NoViableAltException nvae = new NoViableAltException("", 10, 1, input);

							DebugRecognitionException(nvae);
							throw nvae;
						}
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return;}
						NoViableAltException nvae = new NoViableAltException("", 10, 0, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
					} finally { DebugExitDecision(10); }
					switch (alt10)
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:106:5: ( LKey RKey )=> LKey RKey
						{
						DebugLocation(106, 20);
						Match(input,LKey,Follow._LKey_in_expr765); if (state.failed) return;
						DebugLocation(106, 25);
						Match(input,RKey,Follow._RKey_in_expr767); if (state.failed) return;

						}
						break;
					case 2:
						DebugEnterAlt(2);
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:106:32: LKey fieldList RKey
						{
						DebugLocation(106, 32);
						Match(input,LKey,Follow._LKey_in_expr771); if (state.failed) return;
						DebugLocation(106, 37);
						PushFollow(Follow._fieldList_in_expr773);
						fieldList();
						PopFollow();
						if (state.failed) return;
						DebugLocation(106, 47);
						Match(input,RKey,Follow._RKey_in_expr775); if (state.failed) return;

						}
						break;

					}
					} finally { DebugExitSubRule(10); }


					}
					break;
				case 3:
					DebugEnterAlt(3);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:107:4: ( ( LCorch expr_or RCorch Of )=> ( LCorch expr_or RCorch Of expr_or ) | lvalue ( Assign expr_or )? )
					{
					DebugLocation(107, 4);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:107:4: ( ( LCorch expr_or RCorch Of )=> ( LCorch expr_or RCorch Of expr_or ) | lvalue ( Assign expr_or )? )
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
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:107:5: ( LCorch expr_or RCorch Of )=> ( LCorch expr_or RCorch Of expr_or )
						{
						DebugLocation(107, 35);
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:107:35: ( LCorch expr_or RCorch Of expr_or )
						DebugEnterAlt(1);
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:107:36: LCorch expr_or RCorch Of expr_or
						{
						DebugLocation(107, 36);
						Match(input,LCorch,Follow._LCorch_in_expr798); if (state.failed) return;
						DebugLocation(107, 43);
						PushFollow(Follow._expr_or_in_expr800);
						expr_or();
						PopFollow();
						if (state.failed) return;
						DebugLocation(107, 51);
						Match(input,RCorch,Follow._RCorch_in_expr802); if (state.failed) return;
						DebugLocation(107, 58);
						Match(input,Of,Follow._Of_in_expr804); if (state.failed) return;
						DebugLocation(107, 61);
						PushFollow(Follow._expr_or_in_expr806);
						expr_or();
						PopFollow();
						if (state.failed) return;

						}


						}
						break;
					case 2:
						DebugEnterAlt(2);
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:107:72: lvalue ( Assign expr_or )?
						{
						DebugLocation(107, 72);
						PushFollow(Follow._lvalue_in_expr811);
						lvalue();
						PopFollow();
						if (state.failed) return;
						DebugLocation(107, 79);
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:107:79: ( Assign expr_or )?
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
							// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:107:80: Assign expr_or
							{
							DebugLocation(107, 80);
							Match(input,Assign,Follow._Assign_in_expr814); if (state.failed) return;
							DebugLocation(107, 87);
							PushFollow(Follow._expr_or_in_expr816);
							expr_or();
							PopFollow();
							if (state.failed) return;

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
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:109:3: LParent ( exprSeq )? RParent
				{
				DebugLocation(109, 3);
				Match(input,LParent,Follow._LParent_in_expr829); if (state.failed) return;
				DebugLocation(109, 11);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:109:11: ( exprSeq )?
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
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:109:12: exprSeq
					{
					DebugLocation(109, 12);
					PushFollow(Follow._exprSeq_in_expr832);
					exprSeq();
					PopFollow();
					if (state.failed) return;

					}
					break;

				}
				} finally { DebugExitSubRule(14); }

				DebugLocation(109, 22);
				Match(input,RParent,Follow._RParent_in_expr836); if (state.failed) return;

				}
				break;
			case 7:
				DebugEnterAlt(7);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:110:3: If expr_or Then expr_or ( Else expr_or )?
				{
				DebugLocation(110, 3);
				Match(input,If,Follow._If_in_expr845); if (state.failed) return;
				DebugLocation(110, 6);
				PushFollow(Follow._expr_or_in_expr847);
				expr_or();
				PopFollow();
				if (state.failed) return;
				DebugLocation(110, 14);
				Match(input,Then,Follow._Then_in_expr849); if (state.failed) return;
				DebugLocation(110, 19);
				PushFollow(Follow._expr_or_in_expr851);
				expr_or();
				PopFollow();
				if (state.failed) return;
				DebugLocation(110, 27);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:110:27: ( Else expr_or )?
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
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:110:28: Else expr_or
					{
					DebugLocation(110, 28);
					Match(input,Else,Follow._Else_in_expr854); if (state.failed) return;
					DebugLocation(110, 33);
					PushFollow(Follow._expr_or_in_expr856);
					expr_or();
					PopFollow();
					if (state.failed) return;

					}
					break;

				}
				} finally { DebugExitSubRule(15); }


				}
				break;
			case 8:
				DebugEnterAlt(8);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:111:3: While expr_or Do expr_or
				{
				DebugLocation(111, 3);
				Match(input,While,Follow._While_in_expr868); if (state.failed) return;
				DebugLocation(111, 9);
				PushFollow(Follow._expr_or_in_expr870);
				expr_or();
				PopFollow();
				if (state.failed) return;
				DebugLocation(111, 17);
				Match(input,Do,Follow._Do_in_expr872); if (state.failed) return;
				DebugLocation(111, 20);
				PushFollow(Follow._expr_or_in_expr874);
				expr_or();
				PopFollow();
				if (state.failed) return;

				}
				break;
			case 9:
				DebugEnterAlt(9);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:112:3: For ID Assign expr_or To expr_or Do expr_or
				{
				DebugLocation(112, 3);
				Match(input,For,Follow._For_in_expr882); if (state.failed) return;
				DebugLocation(112, 7);
				Match(input,ID,Follow._ID_in_expr884); if (state.failed) return;
				DebugLocation(112, 10);
				Match(input,Assign,Follow._Assign_in_expr886); if (state.failed) return;
				DebugLocation(112, 17);
				PushFollow(Follow._expr_or_in_expr888);
				expr_or();
				PopFollow();
				if (state.failed) return;
				DebugLocation(112, 25);
				Match(input,To,Follow._To_in_expr890); if (state.failed) return;
				DebugLocation(112, 28);
				PushFollow(Follow._expr_or_in_expr892);
				expr_or();
				PopFollow();
				if (state.failed) return;
				DebugLocation(112, 36);
				Match(input,Do,Follow._Do_in_expr894); if (state.failed) return;
				DebugLocation(112, 39);
				PushFollow(Follow._expr_or_in_expr896);
				expr_or();
				PopFollow();
				if (state.failed) return;

				}
				break;
			case 10:
				DebugEnterAlt(10);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:113:3: Break
				{
				DebugLocation(113, 3);
				Match(input,Break,Follow._Break_in_expr904); if (state.failed) return;

				}
				break;
			case 11:
				DebugEnterAlt(11);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:114:3: Let declarationList In ( exprSeq )? End
				{
				DebugLocation(114, 3);
				Match(input,Let,Follow._Let_in_expr913); if (state.failed) return;
				DebugLocation(114, 7);
				PushFollow(Follow._declarationList_in_expr915);
				declarationList();
				PopFollow();
				if (state.failed) return;
				DebugLocation(114, 23);
				Match(input,In,Follow._In_in_expr917); if (state.failed) return;
				DebugLocation(114, 26);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:114:26: ( exprSeq )?
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
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:114:27: exprSeq
					{
					DebugLocation(114, 27);
					PushFollow(Follow._exprSeq_in_expr920);
					exprSeq();
					PopFollow();
					if (state.failed) return;

					}
					break;

				}
				} finally { DebugExitSubRule(16); }

				DebugLocation(114, 37);
				Match(input,End,Follow._End_in_expr924); if (state.failed) return;

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
			TraceOut("expr", 7);
			LeaveRule("expr", 7);
			Leave_expr();
		}
		DebugLocation(114, 39);
		} finally { DebugExitRule(GrammarFileName, "expr"); }
		return;

	}
	// $ANTLR end "expr"


	partial void Enter_exprSeq();
	partial void Leave_exprSeq();

	// $ANTLR start "exprSeq"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:115:1: exprSeq : expr_or ( DotComma expr_or )* ;
	[GrammarRule("exprSeq")]
	private void exprSeq()
	{
		Enter_exprSeq();
		EnterRule("exprSeq", 8);
		TraceIn("exprSeq", 8);
		try { DebugEnterRule(GrammarFileName, "exprSeq");
		DebugLocation(115, 37);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:115:9: ( expr_or ( DotComma expr_or )* )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:115:11: expr_or ( DotComma expr_or )*
			{
			DebugLocation(115, 11);
			PushFollow(Follow._expr_or_in_exprSeq933);
			expr_or();
			PopFollow();
			if (state.failed) return;
			DebugLocation(115, 19);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:115:19: ( DotComma expr_or )*
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
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:115:20: DotComma expr_or
					{
					DebugLocation(115, 20);
					Match(input,DotComma,Follow._DotComma_in_exprSeq936); if (state.failed) return;
					DebugLocation(115, 29);
					PushFollow(Follow._expr_or_in_exprSeq938);
					expr_or();
					PopFollow();
					if (state.failed) return;

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
		DebugLocation(115, 37);
		} finally { DebugExitRule(GrammarFileName, "exprSeq"); }
		return;

	}
	// $ANTLR end "exprSeq"


	partial void Enter_exprList();
	partial void Leave_exprList();

	// $ANTLR start "exprList"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:116:1: exprList : expr_or ( Comma expr_or )* ;
	[GrammarRule("exprList")]
	private void exprList()
	{
		Enter_exprList();
		EnterRule("exprList", 9);
		TraceIn("exprList", 9);
		try { DebugEnterRule(GrammarFileName, "exprList");
		DebugLocation(116, 34);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:116:9: ( expr_or ( Comma expr_or )* )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:116:11: expr_or ( Comma expr_or )*
			{
			DebugLocation(116, 11);
			PushFollow(Follow._expr_or_in_exprList948);
			expr_or();
			PopFollow();
			if (state.failed) return;
			DebugLocation(116, 19);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:116:19: ( Comma expr_or )*
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
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:116:20: Comma expr_or
					{
					DebugLocation(116, 20);
					Match(input,Comma,Follow._Comma_in_exprList951); if (state.failed) return;
					DebugLocation(116, 26);
					PushFollow(Follow._expr_or_in_exprList953);
					expr_or();
					PopFollow();
					if (state.failed) return;

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
		DebugLocation(116, 34);
		} finally { DebugExitRule(GrammarFileName, "exprList"); }
		return;

	}
	// $ANTLR end "exprList"


	partial void Enter_fieldList();
	partial void Leave_fieldList();

	// $ANTLR start "fieldList"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:117:1: fieldList : idAssign ( Comma idAssign )* ;
	[GrammarRule("fieldList")]
	private void fieldList()
	{
		Enter_fieldList();
		EnterRule("fieldList", 10);
		TraceIn("fieldList", 10);
		try { DebugEnterRule(GrammarFileName, "fieldList");
		DebugLocation(117, 38);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:117:11: ( idAssign ( Comma idAssign )* )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:117:13: idAssign ( Comma idAssign )*
			{
			DebugLocation(117, 13);
			PushFollow(Follow._idAssign_in_fieldList964);
			idAssign();
			PopFollow();
			if (state.failed) return;
			DebugLocation(117, 22);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:117:22: ( Comma idAssign )*
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
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:117:23: Comma idAssign
					{
					DebugLocation(117, 23);
					Match(input,Comma,Follow._Comma_in_fieldList967); if (state.failed) return;
					DebugLocation(117, 29);
					PushFollow(Follow._idAssign_in_fieldList969);
					idAssign();
					PopFollow();
					if (state.failed) return;

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
		DebugLocation(117, 38);
		} finally { DebugExitRule(GrammarFileName, "fieldList"); }
		return;

	}
	// $ANTLR end "fieldList"


	partial void Enter_idAssign();
	partial void Leave_idAssign();

	// $ANTLR start "idAssign"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:119:1: idAssign : ( ID Equals expr_or | );
	[GrammarRule("idAssign")]
	private void idAssign()
	{
		Enter_idAssign();
		EnterRule("idAssign", 11);
		TraceIn("idAssign", 11);
		try { DebugEnterRule(GrammarFileName, "idAssign");
		DebugLocation(119, 29);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:119:9: ( ID Equals expr_or | )
			int alt21=2;
			try { DebugEnterDecision(21, decisionCanBacktrack[21]);
			int LA21_0 = input.LA(1);

			if ((LA21_0==ID))
			{
				alt21=1;
			}
			else if ((LA21_0==RKey||LA21_0==Comma))
			{
				alt21=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return;}
				NoViableAltException nvae = new NoViableAltException("", 21, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(21); }
			switch (alt21)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:119:11: ID Equals expr_or
				{
				DebugLocation(119, 11);
				Match(input,ID,Follow._ID_in_idAssign980); if (state.failed) return;
				DebugLocation(119, 14);
				Match(input,Equals,Follow._Equals_in_idAssign982); if (state.failed) return;
				DebugLocation(119, 21);
				PushFollow(Follow._expr_or_in_idAssign984);
				expr_or();
				PopFollow();
				if (state.failed) return;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:119:30: 
				{
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
			TraceOut("idAssign", 11);
			LeaveRule("idAssign", 11);
			Leave_idAssign();
		}
		DebugLocation(119, 29);
		} finally { DebugExitRule(GrammarFileName, "idAssign"); }
		return;

	}
	// $ANTLR end "idAssign"


	partial void Enter_lvalue();
	partial void Leave_lvalue();

	// $ANTLR start "lvalue"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:120:1: lvalue : ( Dot ID | LCorch expr_or RCorch )* ;
	[GrammarRule("lvalue")]
	private void lvalue()
	{
		Enter_lvalue();
		EnterRule("lvalue", 12);
		TraceIn("lvalue", 12);
		try { DebugEnterRule(GrammarFileName, "lvalue");
		DebugLocation(120, 43);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:120:8: ( ( Dot ID | LCorch expr_or RCorch )* )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:120:10: ( Dot ID | LCorch expr_or RCorch )*
			{
			DebugLocation(120, 10);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:120:10: ( Dot ID | LCorch expr_or RCorch )*
			try { DebugEnterSubRule(22);
			while (true)
			{
				int alt22=3;
				try { DebugEnterDecision(22, decisionCanBacktrack[22]);
				int LA22_0 = input.LA(1);

				if ((LA22_0==Dot))
				{
					alt22=1;
				}
				else if ((LA22_0==LCorch))
				{
					alt22=2;
				}


				} finally { DebugExitDecision(22); }
				switch ( alt22 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:120:11: Dot ID
					{
					DebugLocation(120, 11);
					Match(input,Dot,Follow._Dot_in_lvalue996); if (state.failed) return;
					DebugLocation(120, 15);
					Match(input,ID,Follow._ID_in_lvalue998); if (state.failed) return;

					}
					break;
				case 2:
					DebugEnterAlt(2);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:120:20: LCorch expr_or RCorch
					{
					DebugLocation(120, 20);
					Match(input,LCorch,Follow._LCorch_in_lvalue1002); if (state.failed) return;
					DebugLocation(120, 27);
					PushFollow(Follow._expr_or_in_lvalue1004);
					expr_or();
					PopFollow();
					if (state.failed) return;
					DebugLocation(120, 35);
					Match(input,RCorch,Follow._RCorch_in_lvalue1006); if (state.failed) return;

					}
					break;

				default:
					goto loop22;
				}
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
			TraceOut("lvalue", 12);
			LeaveRule("lvalue", 12);
			Leave_lvalue();
		}
		DebugLocation(120, 43);
		} finally { DebugExitRule(GrammarFileName, "lvalue"); }
		return;

	}
	// $ANTLR end "lvalue"


	partial void Enter_declarationList();
	partial void Leave_declarationList();

	// $ANTLR start "declarationList"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:121:1: declarationList : ( declaration )+ ;
	[GrammarRule("declarationList")]
	private void declarationList()
	{
		Enter_declarationList();
		EnterRule("declarationList", 13);
		TraceIn("declarationList", 13);
		try { DebugEnterRule(GrammarFileName, "declarationList");
		DebugLocation(121, 30);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:121:17: ( ( declaration )+ )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:121:19: ( declaration )+
			{
			DebugLocation(121, 19);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:121:19: ( declaration )+
			int cnt23=0;
			try { DebugEnterSubRule(23);
			while (true)
			{
				int alt23=2;
				try { DebugEnterDecision(23, decisionCanBacktrack[23]);
				int LA23_0 = input.LA(1);

				if ((LA23_0==Type||(LA23_0>=Var && LA23_0<=Function)))
				{
					alt23=1;
				}


				} finally { DebugExitDecision(23); }
				switch (alt23)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:121:19: declaration
					{
					DebugLocation(121, 19);
					PushFollow(Follow._declaration_in_declarationList1022);
					declaration();
					PopFollow();
					if (state.failed) return;

					}
					break;

				default:
					if (cnt23 >= 1)
						goto loop23;

					if (state.backtracking>0) {state.failed=true; return;}
					EarlyExitException eee23 = new EarlyExitException( 23, input );
					DebugRecognitionException(eee23);
					throw eee23;
				}
				cnt23++;
			}
			loop23:
				;

			} finally { DebugExitSubRule(23); }


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
		DebugLocation(121, 30);
		} finally { DebugExitRule(GrammarFileName, "declarationList"); }
		return;

	}
	// $ANTLR end "declarationList"


	partial void Enter_declaration();
	partial void Leave_declaration();

	// $ANTLR start "declaration"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:122:1: declaration : ( typeDeclaration | variableDeclaration | functionDeclaration );
	[GrammarRule("declaration")]
	private void declaration()
	{
		Enter_declaration();
		EnterRule("declaration", 14);
		TraceIn("declaration", 14);
		try { DebugEnterRule(GrammarFileName, "declaration");
		DebugLocation(122, 22);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:122:13: ( typeDeclaration | variableDeclaration | functionDeclaration )
			int alt24=3;
			try { DebugEnterDecision(24, decisionCanBacktrack[24]);
			switch (input.LA(1))
			{
			case Type:
				{
				alt24=1;
				}
				break;
			case Var:
				{
				alt24=2;
				}
				break;
			case Function:
				{
				alt24=3;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return;}
					NoViableAltException nvae = new NoViableAltException("", 24, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(24); }
			switch (alt24)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:122:15: typeDeclaration
				{
				DebugLocation(122, 15);
				PushFollow(Follow._typeDeclaration_in_declaration1032);
				typeDeclaration();
				PopFollow();
				if (state.failed) return;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:123:4: variableDeclaration
				{
				DebugLocation(123, 4);
				PushFollow(Follow._variableDeclaration_in_declaration1041);
				variableDeclaration();
				PopFollow();
				if (state.failed) return;

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:124:4: functionDeclaration
				{
				DebugLocation(124, 4);
				PushFollow(Follow._functionDeclaration_in_declaration1049);
				functionDeclaration();
				PopFollow();
				if (state.failed) return;

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
		DebugLocation(124, 22);
		} finally { DebugExitRule(GrammarFileName, "declaration"); }
		return;

	}
	// $ANTLR end "declaration"


	partial void Enter_typeDeclaration();
	partial void Leave_typeDeclaration();

	// $ANTLR start "typeDeclaration"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:125:1: typeDeclaration : Type ID Equals type ;
	[GrammarRule("typeDeclaration")]
	private void typeDeclaration()
	{
		Enter_typeDeclaration();
		EnterRule("typeDeclaration", 15);
		TraceIn("typeDeclaration", 15);
		try { DebugEnterRule(GrammarFileName, "typeDeclaration");
		DebugLocation(125, 37);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:125:17: ( Type ID Equals type )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:125:19: Type ID Equals type
			{
			DebugLocation(125, 19);
			Match(input,Type,Follow._Type_in_typeDeclaration1056); if (state.failed) return;
			DebugLocation(125, 24);
			Match(input,ID,Follow._ID_in_typeDeclaration1058); if (state.failed) return;
			DebugLocation(125, 27);
			Match(input,Equals,Follow._Equals_in_typeDeclaration1060); if (state.failed) return;
			DebugLocation(125, 34);
			PushFollow(Follow._type_in_typeDeclaration1062);
			type();
			PopFollow();
			if (state.failed) return;

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
		DebugLocation(125, 37);
		} finally { DebugExitRule(GrammarFileName, "typeDeclaration"); }
		return;

	}
	// $ANTLR end "typeDeclaration"


	partial void Enter_type();
	partial void Leave_type();

	// $ANTLR start "type"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:126:1: type : ( ID | LKey ( typeFields )? RKey | ArrayOf ID );
	[GrammarRule("type")]
	private void type()
	{
		Enter_type();
		EnterRule("type", 16);
		TraceIn("type", 16);
		try { DebugEnterRule(GrammarFileName, "type");
		DebugLocation(126, 12);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:126:6: ( ID | LKey ( typeFields )? RKey | ArrayOf ID )
			int alt26=3;
			try { DebugEnterDecision(26, decisionCanBacktrack[26]);
			switch (input.LA(1))
			{
			case ID:
				{
				alt26=1;
				}
				break;
			case LKey:
				{
				alt26=2;
				}
				break;
			case ArrayOf:
				{
				alt26=3;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return;}
					NoViableAltException nvae = new NoViableAltException("", 26, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(26); }
			switch (alt26)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:126:8: ID
				{
				DebugLocation(126, 8);
				Match(input,ID,Follow._ID_in_type1071); if (state.failed) return;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:127:3: LKey ( typeFields )? RKey
				{
				DebugLocation(127, 3);
				Match(input,LKey,Follow._LKey_in_type1079); if (state.failed) return;
				DebugLocation(127, 8);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:127:8: ( typeFields )?
				int alt25=2;
				try { DebugEnterSubRule(25);
				try { DebugEnterDecision(25, decisionCanBacktrack[25]);
				int LA25_0 = input.LA(1);

				if ((LA25_0==ID))
				{
					alt25=1;
				}
				} finally { DebugExitDecision(25); }
				switch (alt25)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:127:9: typeFields
					{
					DebugLocation(127, 9);
					PushFollow(Follow._typeFields_in_type1082);
					typeFields();
					PopFollow();
					if (state.failed) return;

					}
					break;

				}
				} finally { DebugExitSubRule(25); }

				DebugLocation(127, 22);
				Match(input,RKey,Follow._RKey_in_type1086); if (state.failed) return;

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:128:3: ArrayOf ID
				{
				DebugLocation(128, 3);
				Match(input,ArrayOf,Follow._ArrayOf_in_type1094); if (state.failed) return;
				DebugLocation(128, 11);
				Match(input,ID,Follow._ID_in_type1096); if (state.failed) return;

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
		DebugLocation(128, 12);
		} finally { DebugExitRule(GrammarFileName, "type"); }
		return;

	}
	// $ANTLR end "type"


	partial void Enter_typeFields();
	partial void Leave_typeFields();

	// $ANTLR start "typeFields"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:129:1: typeFields : typeField ( Comma typeField )* ;
	[GrammarRule("typeFields")]
	private void typeFields()
	{
		Enter_typeFields();
		EnterRule("typeFields", 17);
		TraceIn("typeFields", 17);
		try { DebugEnterRule(GrammarFileName, "typeFields");
		DebugLocation(129, 42);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:129:12: ( typeField ( Comma typeField )* )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:129:15: typeField ( Comma typeField )*
			{
			DebugLocation(129, 15);
			PushFollow(Follow._typeField_in_typeFields1106);
			typeField();
			PopFollow();
			if (state.failed) return;
			DebugLocation(129, 25);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:129:25: ( Comma typeField )*
			try { DebugEnterSubRule(27);
			while (true)
			{
				int alt27=2;
				try { DebugEnterDecision(27, decisionCanBacktrack[27]);
				int LA27_0 = input.LA(1);

				if ((LA27_0==Comma))
				{
					alt27=1;
				}


				} finally { DebugExitDecision(27); }
				switch ( alt27 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:129:26: Comma typeField
					{
					DebugLocation(129, 26);
					Match(input,Comma,Follow._Comma_in_typeFields1109); if (state.failed) return;
					DebugLocation(129, 32);
					PushFollow(Follow._typeField_in_typeFields1111);
					typeField();
					PopFollow();
					if (state.failed) return;

					}
					break;

				default:
					goto loop27;
				}
			}

			loop27:
				;

			} finally { DebugExitSubRule(27); }


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
		DebugLocation(129, 42);
		} finally { DebugExitRule(GrammarFileName, "typeFields"); }
		return;

	}
	// $ANTLR end "typeFields"


	partial void Enter_typeField();
	partial void Leave_typeField();

	// $ANTLR start "typeField"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:130:1: typeField : ID ':' ID ;
	[GrammarRule("typeField")]
	private void typeField()
	{
		Enter_typeField();
		EnterRule("typeField", 18);
		TraceIn("typeField", 18);
		try { DebugEnterRule(GrammarFileName, "typeField");
		DebugLocation(130, 21);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:130:11: ( ID ':' ID )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:130:13: ID ':' ID
			{
			DebugLocation(130, 13);
			Match(input,ID,Follow._ID_in_typeField1122); if (state.failed) return;
			DebugLocation(130, 16);
			Match(input,54,Follow._54_in_typeField1124); if (state.failed) return;
			DebugLocation(130, 20);
			Match(input,ID,Follow._ID_in_typeField1126); if (state.failed) return;

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
		DebugLocation(130, 21);
		} finally { DebugExitRule(GrammarFileName, "typeField"); }
		return;

	}
	// $ANTLR end "typeField"


	partial void Enter_variableDeclaration();
	partial void Leave_variableDeclaration();

	// $ANTLR start "variableDeclaration"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:132:1: variableDeclaration : Var ID ( ':' ID )? Assign expr_or ;
	[GrammarRule("variableDeclaration")]
	private void variableDeclaration()
	{
		Enter_variableDeclaration();
		EnterRule("variableDeclaration", 19);
		TraceIn("variableDeclaration", 19);
		try { DebugEnterRule(GrammarFileName, "variableDeclaration");
		DebugLocation(132, 53);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:132:21: ( Var ID ( ':' ID )? Assign expr_or )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:132:23: Var ID ( ':' ID )? Assign expr_or
			{
			DebugLocation(132, 23);
			Match(input,Var,Follow._Var_in_variableDeclaration1136); if (state.failed) return;
			DebugLocation(132, 27);
			Match(input,ID,Follow._ID_in_variableDeclaration1138); if (state.failed) return;
			DebugLocation(132, 30);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:132:30: ( ':' ID )?
			int alt28=2;
			try { DebugEnterSubRule(28);
			try { DebugEnterDecision(28, decisionCanBacktrack[28]);
			int LA28_0 = input.LA(1);

			if ((LA28_0==54))
			{
				alt28=1;
			}
			} finally { DebugExitDecision(28); }
			switch (alt28)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:132:31: ':' ID
				{
				DebugLocation(132, 31);
				Match(input,54,Follow._54_in_variableDeclaration1141); if (state.failed) return;
				DebugLocation(132, 35);
				Match(input,ID,Follow._ID_in_variableDeclaration1143); if (state.failed) return;

				}
				break;

			}
			} finally { DebugExitSubRule(28); }

			DebugLocation(132, 40);
			Match(input,Assign,Follow._Assign_in_variableDeclaration1147); if (state.failed) return;
			DebugLocation(132, 47);
			PushFollow(Follow._expr_or_in_variableDeclaration1149);
			expr_or();
			PopFollow();
			if (state.failed) return;

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
		DebugLocation(132, 53);
		} finally { DebugExitRule(GrammarFileName, "variableDeclaration"); }
		return;

	}
	// $ANTLR end "variableDeclaration"


	partial void Enter_functionDeclaration();
	partial void Leave_functionDeclaration();

	// $ANTLR start "functionDeclaration"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:136:1: functionDeclaration : Function ID LParent ( typeFields )? RParent ( ':' ID )? Equals expr_or ;
	[GrammarRule("functionDeclaration")]
	private void functionDeclaration()
	{
		Enter_functionDeclaration();
		EnterRule("functionDeclaration", 20);
		TraceIn("functionDeclaration", 20);
		try { DebugEnterRule(GrammarFileName, "functionDeclaration");
		DebugLocation(136, 88);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:136:21: ( Function ID LParent ( typeFields )? RParent ( ':' ID )? Equals expr_or )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:136:23: Function ID LParent ( typeFields )? RParent ( ':' ID )? Equals expr_or
			{
			DebugLocation(136, 23);
			Match(input,Function,Follow._Function_in_functionDeclaration1173); if (state.failed) return;
			DebugLocation(136, 32);
			Match(input,ID,Follow._ID_in_functionDeclaration1175); if (state.failed) return;
			DebugLocation(136, 35);
			Match(input,LParent,Follow._LParent_in_functionDeclaration1177); if (state.failed) return;
			DebugLocation(136, 43);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:136:43: ( typeFields )?
			int alt29=2;
			try { DebugEnterSubRule(29);
			try { DebugEnterDecision(29, decisionCanBacktrack[29]);
			int LA29_0 = input.LA(1);

			if ((LA29_0==ID))
			{
				alt29=1;
			}
			} finally { DebugExitDecision(29); }
			switch (alt29)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:136:44: typeFields
				{
				DebugLocation(136, 44);
				PushFollow(Follow._typeFields_in_functionDeclaration1180);
				typeFields();
				PopFollow();
				if (state.failed) return;

				}
				break;

			}
			} finally { DebugExitSubRule(29); }

			DebugLocation(136, 57);
			Match(input,RParent,Follow._RParent_in_functionDeclaration1184); if (state.failed) return;
			DebugLocation(136, 65);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:136:65: ( ':' ID )?
			int alt30=2;
			try { DebugEnterSubRule(30);
			try { DebugEnterDecision(30, decisionCanBacktrack[30]);
			int LA30_0 = input.LA(1);

			if ((LA30_0==54))
			{
				alt30=1;
			}
			} finally { DebugExitDecision(30); }
			switch (alt30)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:136:66: ':' ID
				{
				DebugLocation(136, 66);
				Match(input,54,Follow._54_in_functionDeclaration1187); if (state.failed) return;
				DebugLocation(136, 70);
				Match(input,ID,Follow._ID_in_functionDeclaration1189); if (state.failed) return;

				}
				break;

			}
			} finally { DebugExitSubRule(30); }

			DebugLocation(136, 75);
			Match(input,Equals,Follow._Equals_in_functionDeclaration1193); if (state.failed) return;
			DebugLocation(136, 82);
			PushFollow(Follow._expr_or_in_functionDeclaration1195);
			expr_or();
			PopFollow();
			if (state.failed) return;

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
		DebugLocation(136, 88);
		} finally { DebugExitRule(GrammarFileName, "functionDeclaration"); }
		return;

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
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:106:5: ( LKey RKey )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:106:6: LKey RKey
			{
			DebugLocation(106, 6);
			Match(input,LKey,Follow._LKey_in_synpred1_Tiger758); if (state.failed) return;
			DebugLocation(106, 11);
			Match(input,RKey,Follow._RKey_in_synpred1_Tiger760); if (state.failed) return;

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
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:107:5: ( LCorch expr_or RCorch Of )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:107:6: LCorch expr_or RCorch Of
			{
			DebugLocation(107, 6);
			Match(input,LCorch,Follow._LCorch_in_synpred2_Tiger786); if (state.failed) return;
			DebugLocation(107, 13);
			PushFollow(Follow._expr_or_in_synpred2_Tiger788);
			expr_or();
			PopFollow();
			if (state.failed) return;
			DebugLocation(107, 21);
			Match(input,RCorch,Follow._RCorch_in_synpred2_Tiger790); if (state.failed) return;
			DebugLocation(107, 28);
			Match(input,Of,Follow._Of_in_synpred2_Tiger792); if (state.failed) return;

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

		public override string Description { get { return "107:4: ( ( LCorch expr_or RCorch Of )=> ( LCorch expr_or RCorch Of expr_or ) | lvalue ( Assign expr_or )? )"; } }

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
		public static readonly BitSet _expr_or_in_prog551 = new BitSet(new ulong[]{0x0UL});
		public static readonly BitSet _EOF_in_prog553 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expr_and_in_expr_or560 = new BitSet(new ulong[]{0x2000000002UL});
		public static readonly BitSet _Or_in_expr_or563 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_and_in_expr_or565 = new BitSet(new ulong[]{0x2000000002UL});
		public static readonly BitSet _expr_logical_in_expr_and573 = new BitSet(new ulong[]{0x1000000002UL});
		public static readonly BitSet _And_in_expr_and576 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_logical_in_expr_and578 = new BitSet(new ulong[]{0x1000000002UL});
		public static readonly BitSet _expr_arithm_in_expr_logical588 = new BitSet(new ulong[]{0xFC0000002UL});
		public static readonly BitSet _Equals_in_expr_logical598 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _NotEquals_in_expr_logical603 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _GThan_in_expr_logical607 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _LThan_in_expr_logical611 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _GEThan_in_expr_logical615 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _LEThan_in_expr_logical619 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_arithm_in_expr_logical623 = new BitSet(new ulong[]{0xFC0000002UL});
		public static readonly BitSet _expr_factor_in_expr_arithm636 = new BitSet(new ulong[]{0x8000022UL});
		public static readonly BitSet _Plus_in_expr_arithm641 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _Minus_in_expr_arithm646 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_factor_in_expr_arithm649 = new BitSet(new ulong[]{0x8000022UL});
		public static readonly BitSet _expr_in_expr_factor659 = new BitSet(new ulong[]{0x30000002UL});
		public static readonly BitSet _Mult_in_expr_factor664 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _Div_in_expr_factor669 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_in_expr_factor672 = new BitSet(new ulong[]{0x30000002UL});
		public static readonly BitSet _STRING_CONST_in_expr681 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _INT_CONST_in_expr689 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _NIL_in_expr697 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _Minus_in_expr705 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_or_in_expr707 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_expr731 = new BitSet(new ulong[]{0x4000AC0UL});
		public static readonly BitSet _LParent_in_expr741 = new BitSet(new ulong[]{0x144000008B21B0UL});
		public static readonly BitSet _exprList_in_expr744 = new BitSet(new ulong[]{0x100UL});
		public static readonly BitSet _RParent_in_expr748 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LKey_in_expr765 = new BitSet(new ulong[]{0x1000UL});
		public static readonly BitSet _RKey_in_expr767 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LKey_in_expr771 = new BitSet(new ulong[]{0x10000001000000UL});
		public static readonly BitSet _fieldList_in_expr773 = new BitSet(new ulong[]{0x1000UL});
		public static readonly BitSet _RKey_in_expr775 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LCorch_in_expr798 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_or_in_expr800 = new BitSet(new ulong[]{0x400UL});
		public static readonly BitSet _RCorch_in_expr802 = new BitSet(new ulong[]{0x100000000000UL});
		public static readonly BitSet _Of_in_expr804 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_or_in_expr806 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _lvalue_in_expr811 = new BitSet(new ulong[]{0x42UL});
		public static readonly BitSet _Assign_in_expr814 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_or_in_expr816 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LParent_in_expr829 = new BitSet(new ulong[]{0x144000008B21B0UL});
		public static readonly BitSet _exprSeq_in_expr832 = new BitSet(new ulong[]{0x100UL});
		public static readonly BitSet _RParent_in_expr836 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _If_in_expr845 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_or_in_expr847 = new BitSet(new ulong[]{0x4000UL});
		public static readonly BitSet _Then_in_expr849 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_or_in_expr851 = new BitSet(new ulong[]{0x8002UL});
		public static readonly BitSet _Else_in_expr854 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_or_in_expr856 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _While_in_expr868 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_or_in_expr870 = new BitSet(new ulong[]{0x40000UL});
		public static readonly BitSet _Do_in_expr872 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_or_in_expr874 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _For_in_expr882 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _ID_in_expr884 = new BitSet(new ulong[]{0x40UL});
		public static readonly BitSet _Assign_in_expr886 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_or_in_expr888 = new BitSet(new ulong[]{0x100000UL});
		public static readonly BitSet _To_in_expr890 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_or_in_expr892 = new BitSet(new ulong[]{0x40000UL});
		public static readonly BitSet _Do_in_expr894 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_or_in_expr896 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _Break_in_expr904 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _Let_in_expr913 = new BitSet(new ulong[]{0x34000000000UL});
		public static readonly BitSet _declarationList_in_expr915 = new BitSet(new ulong[]{0x200000UL});
		public static readonly BitSet _In_in_expr917 = new BitSet(new ulong[]{0x14400000CB20B0UL});
		public static readonly BitSet _exprSeq_in_expr920 = new BitSet(new ulong[]{0x400000UL});
		public static readonly BitSet _End_in_expr924 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expr_or_in_exprSeq933 = new BitSet(new ulong[]{0x2000002UL});
		public static readonly BitSet _DotComma_in_exprSeq936 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_or_in_exprSeq938 = new BitSet(new ulong[]{0x2000002UL});
		public static readonly BitSet _expr_or_in_exprList948 = new BitSet(new ulong[]{0x1000002UL});
		public static readonly BitSet _Comma_in_exprList951 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_or_in_exprList953 = new BitSet(new ulong[]{0x1000002UL});
		public static readonly BitSet _idAssign_in_fieldList964 = new BitSet(new ulong[]{0x1000002UL});
		public static readonly BitSet _Comma_in_fieldList967 = new BitSet(new ulong[]{0x10000001000000UL});
		public static readonly BitSet _idAssign_in_fieldList969 = new BitSet(new ulong[]{0x1000002UL});
		public static readonly BitSet _ID_in_idAssign980 = new BitSet(new ulong[]{0x40000000UL});
		public static readonly BitSet _Equals_in_idAssign982 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_or_in_idAssign984 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _Dot_in_lvalue996 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _ID_in_lvalue998 = new BitSet(new ulong[]{0x4000202UL});
		public static readonly BitSet _LCorch_in_lvalue1002 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_or_in_lvalue1004 = new BitSet(new ulong[]{0x400UL});
		public static readonly BitSet _RCorch_in_lvalue1006 = new BitSet(new ulong[]{0x4000202UL});
		public static readonly BitSet _declaration_in_declarationList1022 = new BitSet(new ulong[]{0x34000000002UL});
		public static readonly BitSet _typeDeclaration_in_declaration1032 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _variableDeclaration_in_declaration1041 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _functionDeclaration_in_declaration1049 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _Type_in_typeDeclaration1056 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _ID_in_typeDeclaration1058 = new BitSet(new ulong[]{0x40000000UL});
		public static readonly BitSet _Equals_in_typeDeclaration1060 = new BitSet(new ulong[]{0x10008000000800UL});
		public static readonly BitSet _type_in_typeDeclaration1062 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_type1071 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LKey_in_type1079 = new BitSet(new ulong[]{0x10000000001000UL});
		public static readonly BitSet _typeFields_in_type1082 = new BitSet(new ulong[]{0x1000UL});
		public static readonly BitSet _RKey_in_type1086 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ArrayOf_in_type1094 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _ID_in_type1096 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _typeField_in_typeFields1106 = new BitSet(new ulong[]{0x1000002UL});
		public static readonly BitSet _Comma_in_typeFields1109 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _typeField_in_typeFields1111 = new BitSet(new ulong[]{0x1000002UL});
		public static readonly BitSet _ID_in_typeField1122 = new BitSet(new ulong[]{0x40000000000000UL});
		public static readonly BitSet _54_in_typeField1124 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _ID_in_typeField1126 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _Var_in_variableDeclaration1136 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _ID_in_variableDeclaration1138 = new BitSet(new ulong[]{0x40000000000040UL});
		public static readonly BitSet _54_in_variableDeclaration1141 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _ID_in_variableDeclaration1143 = new BitSet(new ulong[]{0x40UL});
		public static readonly BitSet _Assign_in_variableDeclaration1147 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_or_in_variableDeclaration1149 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _Function_in_functionDeclaration1173 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _ID_in_functionDeclaration1175 = new BitSet(new ulong[]{0x80UL});
		public static readonly BitSet _LParent_in_functionDeclaration1177 = new BitSet(new ulong[]{0x10000000000100UL});
		public static readonly BitSet _typeFields_in_functionDeclaration1180 = new BitSet(new ulong[]{0x100UL});
		public static readonly BitSet _RParent_in_functionDeclaration1184 = new BitSet(new ulong[]{0x40000040000000UL});
		public static readonly BitSet _54_in_functionDeclaration1187 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _ID_in_functionDeclaration1189 = new BitSet(new ulong[]{0x40000000UL});
		public static readonly BitSet _Equals_in_functionDeclaration1193 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_or_in_functionDeclaration1195 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LKey_in_synpred1_Tiger758 = new BitSet(new ulong[]{0x1000UL});
		public static readonly BitSet _RKey_in_synpred1_Tiger760 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LCorch_in_synpred2_Tiger786 = new BitSet(new ulong[]{0x144000008B20B0UL});
		public static readonly BitSet _expr_or_in_synpred2_Tiger788 = new BitSet(new ulong[]{0x400UL});
		public static readonly BitSet _RCorch_in_synpred2_Tiger790 = new BitSet(new ulong[]{0x100000000000UL});
		public static readonly BitSet _Of_in_synpred2_Tiger792 = new BitSet(new ulong[]{0x2UL});

	}
	#endregion Follow sets
}
