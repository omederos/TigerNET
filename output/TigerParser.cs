// $ANTLR 3.3 Nov 30, 2010 12:45:30 C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g 2012-02-07 02:34:54

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
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "NIL", "Minus", "Assign", "LParent", "RParent", "LCorch", "RCorch", "LKey", "RKey", "If", "Then", "Else", "Break", "While", "Do", "For", "To", "In", "End", "Let", "Comma", "DotComma", "Dot", "Plus", "Mult", "Div", "Equals", "NotEquals", "GThan", "LThan", "GEThan", "LEThan", "And", "Or", "Type", "ArrayOf", "TwoDots", "Var", "Function", "Quotes", "Underscore", "Of", "DIGIT", "INT_CONST", "SPACE", "ESC", "LETTER", "CHAR", "STRING_CONST", "ID", "COMMENTS"
	};
	public const int EOF=-1;
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
	public const int TwoDots=40;
	public const int Var=41;
	public const int Function=42;
	public const int Quotes=43;
	public const int Underscore=44;
	public const int Of=45;
	public const int DIGIT=46;
	public const int INT_CONST=47;
	public const int SPACE=48;
	public const int ESC=49;
	public const int LETTER=50;
	public const int CHAR=51;
	public const int STRING_CONST=52;
	public const int ID=53;
	public const int COMMENTS=54;

	// delegates
	// delegators

	#if ANTLR_DEBUG
		private static readonly bool[] decisionCanBacktrack =
			new bool[]
			{
				false, // invalid decision
				false, false, false, false, false, false, false, false, false, false, 
				true, false, false, false, false, false, false, false, false, false, 
				false, false, false, false, false
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


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	#region Rules

	partial void Enter_program();
	partial void Leave_program();

	// $ANTLR start "program"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:77:8: public program : expr_or EOF ;
	[GrammarRule("program")]
	public void program()
	{
		Enter_program();
		EnterRule("program", 1);
		TraceIn("program", 1);
		try { DebugEnterRule(GrammarFileName, "program");
		DebugLocation(77, 28);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:77:15: ( expr_or EOF )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:77:18: expr_or EOF
			{
			DebugLocation(77, 18);
			PushFollow(Follow._expr_or_in_program544);
			expr_or();
			PopFollow();
			if (state.failed) return;
			DebugLocation(77, 26);
			Match(input,EOF,Follow._EOF_in_program546); if (state.failed) return;

			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("program", 1);
			LeaveRule("program", 1);
			Leave_program();
		}
		DebugLocation(77, 28);
		} finally { DebugExitRule(GrammarFileName, "program"); }
		return;

	}
	// $ANTLR end "program"


	partial void Enter_expr_or();
	partial void Leave_expr_or();

	// $ANTLR start "expr_or"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:78:1: expr_or : expr_and ( Or expr_and )* ;
	[GrammarRule("expr_or")]
	private void expr_or()
	{
		Enter_expr_or();
		EnterRule("expr_or", 2);
		TraceIn("expr_or", 2);
		try { DebugEnterRule(GrammarFileName, "expr_or");
		DebugLocation(78, 33);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:78:9: ( expr_and ( Or expr_and )* )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:78:11: expr_and ( Or expr_and )*
			{
			DebugLocation(78, 11);
			PushFollow(Follow._expr_and_in_expr_or553);
			expr_and();
			PopFollow();
			if (state.failed) return;
			DebugLocation(78, 20);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:78:20: ( Or expr_and )*
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
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:78:21: Or expr_and
					{
					DebugLocation(78, 21);
					Match(input,Or,Follow._Or_in_expr_or556); if (state.failed) return;
					DebugLocation(78, 24);
					PushFollow(Follow._expr_and_in_expr_or558);
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
		DebugLocation(78, 33);
		} finally { DebugExitRule(GrammarFileName, "expr_or"); }
		return;

	}
	// $ANTLR end "expr_or"


	partial void Enter_expr_and();
	partial void Leave_expr_and();

	// $ANTLR start "expr_and"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:79:1: expr_and : expr_logical ( And expr_logical )* ;
	[GrammarRule("expr_and")]
	private void expr_and()
	{
		Enter_expr_and();
		EnterRule("expr_and", 3);
		TraceIn("expr_and", 3);
		try { DebugEnterRule(GrammarFileName, "expr_and");
		DebugLocation(79, 42);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:79:9: ( expr_logical ( And expr_logical )* )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:79:11: expr_logical ( And expr_logical )*
			{
			DebugLocation(79, 11);
			PushFollow(Follow._expr_logical_in_expr_and566);
			expr_logical();
			PopFollow();
			if (state.failed) return;
			DebugLocation(79, 24);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:79:24: ( And expr_logical )*
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
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:79:25: And expr_logical
					{
					DebugLocation(79, 25);
					Match(input,And,Follow._And_in_expr_and569); if (state.failed) return;
					DebugLocation(79, 29);
					PushFollow(Follow._expr_logical_in_expr_and571);
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
		DebugLocation(79, 42);
		} finally { DebugExitRule(GrammarFileName, "expr_and"); }
		return;

	}
	// $ANTLR end "expr_and"


	partial void Enter_expr_logical();
	partial void Leave_expr_logical();

	// $ANTLR start "expr_logical"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:80:1: expr_logical : expr_arithm ( ( ( ( Equals ) | NotEquals | GThan | LThan | GEThan | LEThan ) ) expr_arithm )* ;
	[GrammarRule("expr_logical")]
	private void expr_logical()
	{
		Enter_expr_logical();
		EnterRule("expr_logical", 4);
		TraceIn("expr_logical", 4);
		try { DebugEnterRule(GrammarFileName, "expr_logical");
		DebugLocation(80, 4);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:81:2: ( expr_arithm ( ( ( ( Equals ) | NotEquals | GThan | LThan | GEThan | LEThan ) ) expr_arithm )* )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:81:4: expr_arithm ( ( ( ( Equals ) | NotEquals | GThan | LThan | GEThan | LEThan ) ) expr_arithm )*
			{
			DebugLocation(81, 4);
			PushFollow(Follow._expr_arithm_in_expr_logical581);
			expr_arithm();
			PopFollow();
			if (state.failed) return;
			DebugLocation(81, 16);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:81:16: ( ( ( ( Equals ) | NotEquals | GThan | LThan | GEThan | LEThan ) ) expr_arithm )*
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
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:82:4: ( ( ( Equals ) | NotEquals | GThan | LThan | GEThan | LEThan ) ) expr_arithm
					{
					DebugLocation(82, 4);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:82:4: ( ( ( Equals ) | NotEquals | GThan | LThan | GEThan | LEThan ) )
					DebugEnterAlt(1);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:82:5: ( ( Equals ) | NotEquals | GThan | LThan | GEThan | LEThan )
					{
					DebugLocation(82, 5);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:82:5: ( ( Equals ) | NotEquals | GThan | LThan | GEThan | LEThan )
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
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:82:6: ( Equals )
						{
						DebugLocation(82, 6);
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:82:6: ( Equals )
						DebugEnterAlt(1);
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:82:7: Equals
						{
						DebugLocation(82, 7);
						Match(input,Equals,Follow._Equals_in_expr_logical591); if (state.failed) return;

						}


						}
						break;
					case 2:
						DebugEnterAlt(2);
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:82:17: NotEquals
						{
						DebugLocation(82, 17);
						Match(input,NotEquals,Follow._NotEquals_in_expr_logical596); if (state.failed) return;

						}
						break;
					case 3:
						DebugEnterAlt(3);
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:82:29: GThan
						{
						DebugLocation(82, 29);
						Match(input,GThan,Follow._GThan_in_expr_logical600); if (state.failed) return;

						}
						break;
					case 4:
						DebugEnterAlt(4);
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:82:37: LThan
						{
						DebugLocation(82, 37);
						Match(input,LThan,Follow._LThan_in_expr_logical604); if (state.failed) return;

						}
						break;
					case 5:
						DebugEnterAlt(5);
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:82:45: GEThan
						{
						DebugLocation(82, 45);
						Match(input,GEThan,Follow._GEThan_in_expr_logical608); if (state.failed) return;

						}
						break;
					case 6:
						DebugEnterAlt(6);
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:82:54: LEThan
						{
						DebugLocation(82, 54);
						Match(input,LEThan,Follow._LEThan_in_expr_logical612); if (state.failed) return;

						}
						break;

					}
					} finally { DebugExitSubRule(3); }


					}

					DebugLocation(82, 63);
					PushFollow(Follow._expr_arithm_in_expr_logical616);
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
		DebugLocation(83, 4);
		} finally { DebugExitRule(GrammarFileName, "expr_logical"); }
		return;

	}
	// $ANTLR end "expr_logical"


	partial void Enter_expr_arithm();
	partial void Leave_expr_arithm();

	// $ANTLR start "expr_arithm"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:84:1: expr_arithm : expr_factor ( ( ( Plus ) | Minus ) expr_factor )* ;
	[GrammarRule("expr_arithm")]
	private void expr_arithm()
	{
		Enter_expr_arithm();
		EnterRule("expr_arithm", 5);
		TraceIn("expr_arithm", 5);
		try { DebugEnterRule(GrammarFileName, "expr_arithm");
		DebugLocation(84, 46);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:85:2: ( expr_factor ( ( ( Plus ) | Minus ) expr_factor )* )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:85:4: expr_factor ( ( ( Plus ) | Minus ) expr_factor )*
			{
			DebugLocation(85, 4);
			PushFollow(Follow._expr_factor_in_expr_arithm629);
			expr_factor();
			PopFollow();
			if (state.failed) return;
			DebugLocation(85, 16);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:85:16: ( ( ( Plus ) | Minus ) expr_factor )*
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
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:85:17: ( ( Plus ) | Minus ) expr_factor
					{
					DebugLocation(85, 17);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:85:17: ( ( Plus ) | Minus )
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
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:85:18: ( Plus )
						{
						DebugLocation(85, 18);
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:85:18: ( Plus )
						DebugEnterAlt(1);
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:85:19: Plus
						{
						DebugLocation(85, 19);
						Match(input,Plus,Follow._Plus_in_expr_arithm634); if (state.failed) return;

						}


						}
						break;
					case 2:
						DebugEnterAlt(2);
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:85:27: Minus
						{
						DebugLocation(85, 27);
						Match(input,Minus,Follow._Minus_in_expr_arithm639); if (state.failed) return;

						}
						break;

					}
					} finally { DebugExitSubRule(5); }

					DebugLocation(85, 34);
					PushFollow(Follow._expr_factor_in_expr_arithm642);
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
		DebugLocation(85, 46);
		} finally { DebugExitRule(GrammarFileName, "expr_arithm"); }
		return;

	}
	// $ANTLR end "expr_arithm"


	partial void Enter_expr_factor();
	partial void Leave_expr_factor();

	// $ANTLR start "expr_factor"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:86:1: expr_factor : expr ( ( ( Mult ) | Div ) expr )* ;
	[GrammarRule("expr_factor")]
	private void expr_factor()
	{
		Enter_expr_factor();
		EnterRule("expr_factor", 6);
		TraceIn("expr_factor", 6);
		try { DebugEnterRule(GrammarFileName, "expr_factor");
		DebugLocation(86, 30);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:87:2: ( expr ( ( ( Mult ) | Div ) expr )* )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:87:4: expr ( ( ( Mult ) | Div ) expr )*
			{
			DebugLocation(87, 4);
			PushFollow(Follow._expr_in_expr_factor652);
			expr();
			PopFollow();
			if (state.failed) return;
			DebugLocation(87, 9);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:87:9: ( ( ( Mult ) | Div ) expr )*
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
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:87:10: ( ( Mult ) | Div ) expr
					{
					DebugLocation(87, 10);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:87:10: ( ( Mult ) | Div )
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
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:87:11: ( Mult )
						{
						DebugLocation(87, 11);
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:87:11: ( Mult )
						DebugEnterAlt(1);
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:87:12: Mult
						{
						DebugLocation(87, 12);
						Match(input,Mult,Follow._Mult_in_expr_factor657); if (state.failed) return;

						}


						}
						break;
					case 2:
						DebugEnterAlt(2);
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:87:20: Div
						{
						DebugLocation(87, 20);
						Match(input,Div,Follow._Div_in_expr_factor662); if (state.failed) return;

						}
						break;

					}
					} finally { DebugExitSubRule(7); }

					DebugLocation(87, 25);
					PushFollow(Follow._expr_in_expr_factor665);
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
		DebugLocation(87, 30);
		} finally { DebugExitRule(GrammarFileName, "expr_factor"); }
		return;

	}
	// $ANTLR end "expr_factor"


	partial void Enter_expr();
	partial void Leave_expr();

	// $ANTLR start "expr"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:88:1: expr : ( STRING_CONST | INT_CONST | NIL | Minus expr_or | ID ( ( LParent exprList RParent | LKey fieldList RKey )? | ( LCorch expr_or RCorch Of )=> ( LCorch expr_or RCorch Of expr_or ) | ( lvalue ( Assign expr_or )? ) ) | LParent exprSeq RParent | If expr_or Then expr_or ( Else expr_or )? | While expr_or Do expr_or | For ID Assign expr_or To expr_or Do expr_or | Break | Let declarationList In ( exprSeq )? End );
	[GrammarRule("expr")]
	private void expr()
	{
		Enter_expr();
		EnterRule("expr", 7);
		TraceIn("expr", 7);
		try { DebugEnterRule(GrammarFileName, "expr");
		DebugLocation(88, 39);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:88:6: ( STRING_CONST | INT_CONST | NIL | Minus expr_or | ID ( ( LParent exprList RParent | LKey fieldList RKey )? | ( LCorch expr_or RCorch Of )=> ( LCorch expr_or RCorch Of expr_or ) | ( lvalue ( Assign expr_or )? ) ) | LParent exprSeq RParent | If expr_or Then expr_or ( Else expr_or )? | While expr_or Do expr_or | For ID Assign expr_or To expr_or Do expr_or | Break | Let declarationList In ( exprSeq )? End )
			int alt14=11;
			try { DebugEnterDecision(14, decisionCanBacktrack[14]);
			switch (input.LA(1))
			{
			case STRING_CONST:
				{
				alt14=1;
				}
				break;
			case INT_CONST:
				{
				alt14=2;
				}
				break;
			case NIL:
				{
				alt14=3;
				}
				break;
			case Minus:
				{
				alt14=4;
				}
				break;
			case ID:
				{
				alt14=5;
				}
				break;
			case LParent:
				{
				alt14=6;
				}
				break;
			case If:
				{
				alt14=7;
				}
				break;
			case While:
				{
				alt14=8;
				}
				break;
			case For:
				{
				alt14=9;
				}
				break;
			case Break:
				{
				alt14=10;
				}
				break;
			case Let:
				{
				alt14=11;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return;}
					NoViableAltException nvae = new NoViableAltException("", 14, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(14); }
			switch (alt14)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:88:8: STRING_CONST
				{
				DebugLocation(88, 8);
				Match(input,STRING_CONST,Follow._STRING_CONST_in_expr674); if (state.failed) return;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:89:3: INT_CONST
				{
				DebugLocation(89, 3);
				Match(input,INT_CONST,Follow._INT_CONST_in_expr682); if (state.failed) return;

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:90:3: NIL
				{
				DebugLocation(90, 3);
				Match(input,NIL,Follow._NIL_in_expr690); if (state.failed) return;

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:91:3: Minus expr_or
				{
				DebugLocation(91, 3);
				Match(input,Minus,Follow._Minus_in_expr698); if (state.failed) return;
				DebugLocation(91, 9);
				PushFollow(Follow._expr_or_in_expr700);
				expr_or();
				PopFollow();
				if (state.failed) return;

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:95:3: ID ( ( LParent exprList RParent | LKey fieldList RKey )? | ( LCorch expr_or RCorch Of )=> ( LCorch expr_or RCorch Of expr_or ) | ( lvalue ( Assign expr_or )? ) )
				{
				DebugLocation(95, 3);
				Match(input,ID,Follow._ID_in_expr724); if (state.failed) return;
				DebugLocation(95, 6);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:95:6: ( ( LParent exprList RParent | LKey fieldList RKey )? | ( LCorch expr_or RCorch Of )=> ( LCorch expr_or RCorch Of expr_or ) | ( lvalue ( Assign expr_or )? ) )
				int alt11=3;
				try { DebugEnterSubRule(11);
				try { DebugEnterDecision(11, decisionCanBacktrack[11]);
				try
				{
					alt11 = dfa11.Predict(input);
				}
				catch (NoViableAltException nvae)
				{
					DebugRecognitionException(nvae);
					throw;
				}
				} finally { DebugExitDecision(11); }
				switch (alt11)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:95:7: ( LParent exprList RParent | LKey fieldList RKey )?
					{
					DebugLocation(95, 7);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:95:7: ( LParent exprList RParent | LKey fieldList RKey )?
					int alt9=3;
					try { DebugEnterSubRule(9);
					try { DebugEnterDecision(9, decisionCanBacktrack[9]);
					int LA9_0 = input.LA(1);

					if ((LA9_0==LParent))
					{
						alt9=1;
					}
					else if ((LA9_0==LKey))
					{
						alt9=2;
					}
					} finally { DebugExitDecision(9); }
					switch (alt9)
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:95:8: LParent exprList RParent
						{
						DebugLocation(95, 8);
						Match(input,LParent,Follow._LParent_in_expr728); if (state.failed) return;
						DebugLocation(95, 16);
						PushFollow(Follow._exprList_in_expr730);
						exprList();
						PopFollow();
						if (state.failed) return;
						DebugLocation(95, 25);
						Match(input,RParent,Follow._RParent_in_expr732); if (state.failed) return;

						}
						break;
					case 2:
						DebugEnterAlt(2);
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:95:35: LKey fieldList RKey
						{
						DebugLocation(95, 35);
						Match(input,LKey,Follow._LKey_in_expr736); if (state.failed) return;
						DebugLocation(95, 40);
						PushFollow(Follow._fieldList_in_expr738);
						fieldList();
						PopFollow();
						if (state.failed) return;
						DebugLocation(95, 50);
						Match(input,RKey,Follow._RKey_in_expr740); if (state.failed) return;

						}
						break;

					}
					} finally { DebugExitSubRule(9); }


					}
					break;
				case 2:
					DebugEnterAlt(2);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:95:59: ( LCorch expr_or RCorch Of )=> ( LCorch expr_or RCorch Of expr_or )
					{
					DebugLocation(95, 89);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:95:89: ( LCorch expr_or RCorch Of expr_or )
					DebugEnterAlt(1);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:95:90: LCorch expr_or RCorch Of expr_or
					{
					DebugLocation(95, 90);
					Match(input,LCorch,Follow._LCorch_in_expr759); if (state.failed) return;
					DebugLocation(95, 97);
					PushFollow(Follow._expr_or_in_expr761);
					expr_or();
					PopFollow();
					if (state.failed) return;
					DebugLocation(95, 105);
					Match(input,RCorch,Follow._RCorch_in_expr763); if (state.failed) return;
					DebugLocation(95, 112);
					Match(input,Of,Follow._Of_in_expr765); if (state.failed) return;
					DebugLocation(95, 115);
					PushFollow(Follow._expr_or_in_expr767);
					expr_or();
					PopFollow();
					if (state.failed) return;

					}


					}
					break;
				case 3:
					DebugEnterAlt(3);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:95:126: ( lvalue ( Assign expr_or )? )
					{
					DebugLocation(95, 126);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:95:126: ( lvalue ( Assign expr_or )? )
					DebugEnterAlt(1);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:95:127: lvalue ( Assign expr_or )?
					{
					DebugLocation(95, 127);
					PushFollow(Follow._lvalue_in_expr773);
					lvalue();
					PopFollow();
					if (state.failed) return;
					DebugLocation(95, 134);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:95:134: ( Assign expr_or )?
					int alt10=2;
					try { DebugEnterSubRule(10);
					try { DebugEnterDecision(10, decisionCanBacktrack[10]);
					int LA10_0 = input.LA(1);

					if ((LA10_0==Assign))
					{
						alt10=1;
					}
					} finally { DebugExitDecision(10); }
					switch (alt10)
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:95:135: Assign expr_or
						{
						DebugLocation(95, 135);
						Match(input,Assign,Follow._Assign_in_expr776); if (state.failed) return;
						DebugLocation(95, 142);
						PushFollow(Follow._expr_or_in_expr778);
						expr_or();
						PopFollow();
						if (state.failed) return;

						}
						break;

					}
					} finally { DebugExitSubRule(10); }


					}


					}
					break;

				}
				} finally { DebugExitSubRule(11); }


				}
				break;
			case 6:
				DebugEnterAlt(6);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:96:3: LParent exprSeq RParent
				{
				DebugLocation(96, 3);
				Match(input,LParent,Follow._LParent_in_expr789); if (state.failed) return;
				DebugLocation(96, 11);
				PushFollow(Follow._exprSeq_in_expr791);
				exprSeq();
				PopFollow();
				if (state.failed) return;
				DebugLocation(96, 19);
				Match(input,RParent,Follow._RParent_in_expr793); if (state.failed) return;

				}
				break;
			case 7:
				DebugEnterAlt(7);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:97:3: If expr_or Then expr_or ( Else expr_or )?
				{
				DebugLocation(97, 3);
				Match(input,If,Follow._If_in_expr802); if (state.failed) return;
				DebugLocation(97, 6);
				PushFollow(Follow._expr_or_in_expr804);
				expr_or();
				PopFollow();
				if (state.failed) return;
				DebugLocation(97, 14);
				Match(input,Then,Follow._Then_in_expr806); if (state.failed) return;
				DebugLocation(97, 19);
				PushFollow(Follow._expr_or_in_expr808);
				expr_or();
				PopFollow();
				if (state.failed) return;
				DebugLocation(97, 27);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:97:27: ( Else expr_or )?
				int alt12=2;
				try { DebugEnterSubRule(12);
				try { DebugEnterDecision(12, decisionCanBacktrack[12]);
				int LA12_0 = input.LA(1);

				if ((LA12_0==Else))
				{
					alt12=1;
				}
				} finally { DebugExitDecision(12); }
				switch (alt12)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:97:28: Else expr_or
					{
					DebugLocation(97, 28);
					Match(input,Else,Follow._Else_in_expr811); if (state.failed) return;
					DebugLocation(97, 33);
					PushFollow(Follow._expr_or_in_expr813);
					expr_or();
					PopFollow();
					if (state.failed) return;

					}
					break;

				}
				} finally { DebugExitSubRule(12); }


				}
				break;
			case 8:
				DebugEnterAlt(8);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:98:3: While expr_or Do expr_or
				{
				DebugLocation(98, 3);
				Match(input,While,Follow._While_in_expr825); if (state.failed) return;
				DebugLocation(98, 9);
				PushFollow(Follow._expr_or_in_expr827);
				expr_or();
				PopFollow();
				if (state.failed) return;
				DebugLocation(98, 17);
				Match(input,Do,Follow._Do_in_expr829); if (state.failed) return;
				DebugLocation(98, 20);
				PushFollow(Follow._expr_or_in_expr831);
				expr_or();
				PopFollow();
				if (state.failed) return;

				}
				break;
			case 9:
				DebugEnterAlt(9);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:99:3: For ID Assign expr_or To expr_or Do expr_or
				{
				DebugLocation(99, 3);
				Match(input,For,Follow._For_in_expr839); if (state.failed) return;
				DebugLocation(99, 7);
				Match(input,ID,Follow._ID_in_expr841); if (state.failed) return;
				DebugLocation(99, 10);
				Match(input,Assign,Follow._Assign_in_expr843); if (state.failed) return;
				DebugLocation(99, 17);
				PushFollow(Follow._expr_or_in_expr845);
				expr_or();
				PopFollow();
				if (state.failed) return;
				DebugLocation(99, 25);
				Match(input,To,Follow._To_in_expr847); if (state.failed) return;
				DebugLocation(99, 28);
				PushFollow(Follow._expr_or_in_expr849);
				expr_or();
				PopFollow();
				if (state.failed) return;
				DebugLocation(99, 36);
				Match(input,Do,Follow._Do_in_expr851); if (state.failed) return;
				DebugLocation(99, 39);
				PushFollow(Follow._expr_or_in_expr853);
				expr_or();
				PopFollow();
				if (state.failed) return;

				}
				break;
			case 10:
				DebugEnterAlt(10);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:100:3: Break
				{
				DebugLocation(100, 3);
				Match(input,Break,Follow._Break_in_expr861); if (state.failed) return;

				}
				break;
			case 11:
				DebugEnterAlt(11);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:101:3: Let declarationList In ( exprSeq )? End
				{
				DebugLocation(101, 3);
				Match(input,Let,Follow._Let_in_expr870); if (state.failed) return;
				DebugLocation(101, 7);
				PushFollow(Follow._declarationList_in_expr872);
				declarationList();
				PopFollow();
				if (state.failed) return;
				DebugLocation(101, 23);
				Match(input,In,Follow._In_in_expr874); if (state.failed) return;
				DebugLocation(101, 26);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:101:26: ( exprSeq )?
				int alt13=2;
				try { DebugEnterSubRule(13);
				try { DebugEnterDecision(13, decisionCanBacktrack[13]);
				int LA13_0 = input.LA(1);

				if (((LA13_0>=NIL && LA13_0<=Minus)||LA13_0==LParent||LA13_0==If||(LA13_0>=Break && LA13_0<=While)||LA13_0==For||LA13_0==Let||LA13_0==INT_CONST||(LA13_0>=STRING_CONST && LA13_0<=ID)))
				{
					alt13=1;
				}
				} finally { DebugExitDecision(13); }
				switch (alt13)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:101:27: exprSeq
					{
					DebugLocation(101, 27);
					PushFollow(Follow._exprSeq_in_expr877);
					exprSeq();
					PopFollow();
					if (state.failed) return;

					}
					break;

				}
				} finally { DebugExitSubRule(13); }

				DebugLocation(101, 37);
				Match(input,End,Follow._End_in_expr881); if (state.failed) return;

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
		DebugLocation(101, 39);
		} finally { DebugExitRule(GrammarFileName, "expr"); }
		return;

	}
	// $ANTLR end "expr"


	partial void Enter_exprSeq();
	partial void Leave_exprSeq();

	// $ANTLR start "exprSeq"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:102:1: exprSeq : expr_or ( DotComma expr_or )* ;
	[GrammarRule("exprSeq")]
	private void exprSeq()
	{
		Enter_exprSeq();
		EnterRule("exprSeq", 8);
		TraceIn("exprSeq", 8);
		try { DebugEnterRule(GrammarFileName, "exprSeq");
		DebugLocation(102, 37);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:102:9: ( expr_or ( DotComma expr_or )* )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:102:11: expr_or ( DotComma expr_or )*
			{
			DebugLocation(102, 11);
			PushFollow(Follow._expr_or_in_exprSeq890);
			expr_or();
			PopFollow();
			if (state.failed) return;
			DebugLocation(102, 19);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:102:19: ( DotComma expr_or )*
			try { DebugEnterSubRule(15);
			while (true)
			{
				int alt15=2;
				try { DebugEnterDecision(15, decisionCanBacktrack[15]);
				int LA15_0 = input.LA(1);

				if ((LA15_0==DotComma))
				{
					alt15=1;
				}


				} finally { DebugExitDecision(15); }
				switch ( alt15 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:102:20: DotComma expr_or
					{
					DebugLocation(102, 20);
					Match(input,DotComma,Follow._DotComma_in_exprSeq893); if (state.failed) return;
					DebugLocation(102, 29);
					PushFollow(Follow._expr_or_in_exprSeq895);
					expr_or();
					PopFollow();
					if (state.failed) return;

					}
					break;

				default:
					goto loop15;
				}
			}

			loop15:
				;

			} finally { DebugExitSubRule(15); }


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
		DebugLocation(102, 37);
		} finally { DebugExitRule(GrammarFileName, "exprSeq"); }
		return;

	}
	// $ANTLR end "exprSeq"


	partial void Enter_exprList();
	partial void Leave_exprList();

	// $ANTLR start "exprList"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:103:1: exprList : expr_or ( Comma expr_or )* ;
	[GrammarRule("exprList")]
	private void exprList()
	{
		Enter_exprList();
		EnterRule("exprList", 9);
		TraceIn("exprList", 9);
		try { DebugEnterRule(GrammarFileName, "exprList");
		DebugLocation(103, 34);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:103:9: ( expr_or ( Comma expr_or )* )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:103:11: expr_or ( Comma expr_or )*
			{
			DebugLocation(103, 11);
			PushFollow(Follow._expr_or_in_exprList905);
			expr_or();
			PopFollow();
			if (state.failed) return;
			DebugLocation(103, 19);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:103:19: ( Comma expr_or )*
			try { DebugEnterSubRule(16);
			while (true)
			{
				int alt16=2;
				try { DebugEnterDecision(16, decisionCanBacktrack[16]);
				int LA16_0 = input.LA(1);

				if ((LA16_0==Comma))
				{
					alt16=1;
				}


				} finally { DebugExitDecision(16); }
				switch ( alt16 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:103:20: Comma expr_or
					{
					DebugLocation(103, 20);
					Match(input,Comma,Follow._Comma_in_exprList908); if (state.failed) return;
					DebugLocation(103, 26);
					PushFollow(Follow._expr_or_in_exprList910);
					expr_or();
					PopFollow();
					if (state.failed) return;

					}
					break;

				default:
					goto loop16;
				}
			}

			loop16:
				;

			} finally { DebugExitSubRule(16); }


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
		DebugLocation(103, 34);
		} finally { DebugExitRule(GrammarFileName, "exprList"); }
		return;

	}
	// $ANTLR end "exprList"


	partial void Enter_fieldList();
	partial void Leave_fieldList();

	// $ANTLR start "fieldList"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:104:1: fieldList : idAssign ( Comma idAssign )* ;
	[GrammarRule("fieldList")]
	private void fieldList()
	{
		Enter_fieldList();
		EnterRule("fieldList", 10);
		TraceIn("fieldList", 10);
		try { DebugEnterRule(GrammarFileName, "fieldList");
		DebugLocation(104, 38);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:104:11: ( idAssign ( Comma idAssign )* )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:104:13: idAssign ( Comma idAssign )*
			{
			DebugLocation(104, 13);
			PushFollow(Follow._idAssign_in_fieldList921);
			idAssign();
			PopFollow();
			if (state.failed) return;
			DebugLocation(104, 22);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:104:22: ( Comma idAssign )*
			try { DebugEnterSubRule(17);
			while (true)
			{
				int alt17=2;
				try { DebugEnterDecision(17, decisionCanBacktrack[17]);
				int LA17_0 = input.LA(1);

				if ((LA17_0==Comma))
				{
					alt17=1;
				}


				} finally { DebugExitDecision(17); }
				switch ( alt17 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:104:23: Comma idAssign
					{
					DebugLocation(104, 23);
					Match(input,Comma,Follow._Comma_in_fieldList924); if (state.failed) return;
					DebugLocation(104, 29);
					PushFollow(Follow._idAssign_in_fieldList926);
					idAssign();
					PopFollow();
					if (state.failed) return;

					}
					break;

				default:
					goto loop17;
				}
			}

			loop17:
				;

			} finally { DebugExitSubRule(17); }


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
		DebugLocation(104, 38);
		} finally { DebugExitRule(GrammarFileName, "fieldList"); }
		return;

	}
	// $ANTLR end "fieldList"


	partial void Enter_idAssign();
	partial void Leave_idAssign();

	// $ANTLR start "idAssign"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:106:1: idAssign : ( ID Equals expr_or | );
	[GrammarRule("idAssign")]
	private void idAssign()
	{
		Enter_idAssign();
		EnterRule("idAssign", 11);
		TraceIn("idAssign", 11);
		try { DebugEnterRule(GrammarFileName, "idAssign");
		DebugLocation(106, 29);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:106:9: ( ID Equals expr_or | )
			int alt18=2;
			try { DebugEnterDecision(18, decisionCanBacktrack[18]);
			int LA18_0 = input.LA(1);

			if ((LA18_0==ID))
			{
				alt18=1;
			}
			else if ((LA18_0==RKey||LA18_0==Comma))
			{
				alt18=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return;}
				NoViableAltException nvae = new NoViableAltException("", 18, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(18); }
			switch (alt18)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:106:11: ID Equals expr_or
				{
				DebugLocation(106, 11);
				Match(input,ID,Follow._ID_in_idAssign937); if (state.failed) return;
				DebugLocation(106, 14);
				Match(input,Equals,Follow._Equals_in_idAssign939); if (state.failed) return;
				DebugLocation(106, 21);
				PushFollow(Follow._expr_or_in_idAssign941);
				expr_or();
				PopFollow();
				if (state.failed) return;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:106:30: 
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
		DebugLocation(106, 29);
		} finally { DebugExitRule(GrammarFileName, "idAssign"); }
		return;

	}
	// $ANTLR end "idAssign"


	partial void Enter_lvalue();
	partial void Leave_lvalue();

	// $ANTLR start "lvalue"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:107:1: lvalue : ( Dot ID | LCorch expr_or RCorch )* ;
	[GrammarRule("lvalue")]
	private void lvalue()
	{
		Enter_lvalue();
		EnterRule("lvalue", 12);
		TraceIn("lvalue", 12);
		try { DebugEnterRule(GrammarFileName, "lvalue");
		DebugLocation(107, 43);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:107:8: ( ( Dot ID | LCorch expr_or RCorch )* )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:107:10: ( Dot ID | LCorch expr_or RCorch )*
			{
			DebugLocation(107, 10);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:107:10: ( Dot ID | LCorch expr_or RCorch )*
			try { DebugEnterSubRule(19);
			while (true)
			{
				int alt19=3;
				try { DebugEnterDecision(19, decisionCanBacktrack[19]);
				int LA19_0 = input.LA(1);

				if ((LA19_0==Dot))
				{
					alt19=1;
				}
				else if ((LA19_0==LCorch))
				{
					alt19=2;
				}


				} finally { DebugExitDecision(19); }
				switch ( alt19 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:107:11: Dot ID
					{
					DebugLocation(107, 11);
					Match(input,Dot,Follow._Dot_in_lvalue953); if (state.failed) return;
					DebugLocation(107, 15);
					Match(input,ID,Follow._ID_in_lvalue955); if (state.failed) return;

					}
					break;
				case 2:
					DebugEnterAlt(2);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:107:20: LCorch expr_or RCorch
					{
					DebugLocation(107, 20);
					Match(input,LCorch,Follow._LCorch_in_lvalue959); if (state.failed) return;
					DebugLocation(107, 27);
					PushFollow(Follow._expr_or_in_lvalue961);
					expr_or();
					PopFollow();
					if (state.failed) return;
					DebugLocation(107, 35);
					Match(input,RCorch,Follow._RCorch_in_lvalue963); if (state.failed) return;

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
			TraceOut("lvalue", 12);
			LeaveRule("lvalue", 12);
			Leave_lvalue();
		}
		DebugLocation(107, 43);
		} finally { DebugExitRule(GrammarFileName, "lvalue"); }
		return;

	}
	// $ANTLR end "lvalue"


	partial void Enter_declarationList();
	partial void Leave_declarationList();

	// $ANTLR start "declarationList"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:108:1: declarationList : ( declaration )+ ;
	[GrammarRule("declarationList")]
	private void declarationList()
	{
		Enter_declarationList();
		EnterRule("declarationList", 13);
		TraceIn("declarationList", 13);
		try { DebugEnterRule(GrammarFileName, "declarationList");
		DebugLocation(108, 30);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:108:17: ( ( declaration )+ )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:108:19: ( declaration )+
			{
			DebugLocation(108, 19);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:108:19: ( declaration )+
			int cnt20=0;
			try { DebugEnterSubRule(20);
			while (true)
			{
				int alt20=2;
				try { DebugEnterDecision(20, decisionCanBacktrack[20]);
				int LA20_0 = input.LA(1);

				if ((LA20_0==Type||(LA20_0>=Var && LA20_0<=Function)))
				{
					alt20=1;
				}


				} finally { DebugExitDecision(20); }
				switch (alt20)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:108:19: declaration
					{
					DebugLocation(108, 19);
					PushFollow(Follow._declaration_in_declarationList979);
					declaration();
					PopFollow();
					if (state.failed) return;

					}
					break;

				default:
					if (cnt20 >= 1)
						goto loop20;

					if (state.backtracking>0) {state.failed=true; return;}
					EarlyExitException eee20 = new EarlyExitException( 20, input );
					DebugRecognitionException(eee20);
					throw eee20;
				}
				cnt20++;
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
			TraceOut("declarationList", 13);
			LeaveRule("declarationList", 13);
			Leave_declarationList();
		}
		DebugLocation(108, 30);
		} finally { DebugExitRule(GrammarFileName, "declarationList"); }
		return;

	}
	// $ANTLR end "declarationList"


	partial void Enter_declaration();
	partial void Leave_declaration();

	// $ANTLR start "declaration"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:109:1: declaration : ( typeDeclaration | variableDeclaration | functionDeclaration );
	[GrammarRule("declaration")]
	private void declaration()
	{
		Enter_declaration();
		EnterRule("declaration", 14);
		TraceIn("declaration", 14);
		try { DebugEnterRule(GrammarFileName, "declaration");
		DebugLocation(109, 22);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:109:13: ( typeDeclaration | variableDeclaration | functionDeclaration )
			int alt21=3;
			try { DebugEnterDecision(21, decisionCanBacktrack[21]);
			switch (input.LA(1))
			{
			case Type:
				{
				alt21=1;
				}
				break;
			case Var:
				{
				alt21=2;
				}
				break;
			case Function:
				{
				alt21=3;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return;}
					NoViableAltException nvae = new NoViableAltException("", 21, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(21); }
			switch (alt21)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:109:15: typeDeclaration
				{
				DebugLocation(109, 15);
				PushFollow(Follow._typeDeclaration_in_declaration989);
				typeDeclaration();
				PopFollow();
				if (state.failed) return;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:110:4: variableDeclaration
				{
				DebugLocation(110, 4);
				PushFollow(Follow._variableDeclaration_in_declaration998);
				variableDeclaration();
				PopFollow();
				if (state.failed) return;

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:111:4: functionDeclaration
				{
				DebugLocation(111, 4);
				PushFollow(Follow._functionDeclaration_in_declaration1006);
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
		DebugLocation(111, 22);
		} finally { DebugExitRule(GrammarFileName, "declaration"); }
		return;

	}
	// $ANTLR end "declaration"


	partial void Enter_typeDeclaration();
	partial void Leave_typeDeclaration();

	// $ANTLR start "typeDeclaration"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:112:1: typeDeclaration : Type ID Equals type ;
	[GrammarRule("typeDeclaration")]
	private void typeDeclaration()
	{
		Enter_typeDeclaration();
		EnterRule("typeDeclaration", 15);
		TraceIn("typeDeclaration", 15);
		try { DebugEnterRule(GrammarFileName, "typeDeclaration");
		DebugLocation(112, 37);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:112:17: ( Type ID Equals type )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:112:19: Type ID Equals type
			{
			DebugLocation(112, 19);
			Match(input,Type,Follow._Type_in_typeDeclaration1013); if (state.failed) return;
			DebugLocation(112, 24);
			Match(input,ID,Follow._ID_in_typeDeclaration1015); if (state.failed) return;
			DebugLocation(112, 27);
			Match(input,Equals,Follow._Equals_in_typeDeclaration1017); if (state.failed) return;
			DebugLocation(112, 34);
			PushFollow(Follow._type_in_typeDeclaration1019);
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
		DebugLocation(112, 37);
		} finally { DebugExitRule(GrammarFileName, "typeDeclaration"); }
		return;

	}
	// $ANTLR end "typeDeclaration"


	partial void Enter_type();
	partial void Leave_type();

	// $ANTLR start "type"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:113:1: type : ( ID | LKey typeFields RKey | ArrayOf ID );
	[GrammarRule("type")]
	private void type()
	{
		Enter_type();
		EnterRule("type", 16);
		TraceIn("type", 16);
		try { DebugEnterRule(GrammarFileName, "type");
		DebugLocation(113, 12);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:113:6: ( ID | LKey typeFields RKey | ArrayOf ID )
			int alt22=3;
			try { DebugEnterDecision(22, decisionCanBacktrack[22]);
			switch (input.LA(1))
			{
			case ID:
				{
				alt22=1;
				}
				break;
			case LKey:
				{
				alt22=2;
				}
				break;
			case ArrayOf:
				{
				alt22=3;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return;}
					NoViableAltException nvae = new NoViableAltException("", 22, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(22); }
			switch (alt22)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:113:8: ID
				{
				DebugLocation(113, 8);
				Match(input,ID,Follow._ID_in_type1028); if (state.failed) return;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:114:3: LKey typeFields RKey
				{
				DebugLocation(114, 3);
				Match(input,LKey,Follow._LKey_in_type1036); if (state.failed) return;
				DebugLocation(114, 8);
				PushFollow(Follow._typeFields_in_type1038);
				typeFields();
				PopFollow();
				if (state.failed) return;
				DebugLocation(114, 19);
				Match(input,RKey,Follow._RKey_in_type1040); if (state.failed) return;

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:115:3: ArrayOf ID
				{
				DebugLocation(115, 3);
				Match(input,ArrayOf,Follow._ArrayOf_in_type1048); if (state.failed) return;
				DebugLocation(115, 11);
				Match(input,ID,Follow._ID_in_type1050); if (state.failed) return;

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
		DebugLocation(115, 12);
		} finally { DebugExitRule(GrammarFileName, "type"); }
		return;

	}
	// $ANTLR end "type"


	partial void Enter_typeFields();
	partial void Leave_typeFields();

	// $ANTLR start "typeFields"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:116:1: typeFields : typeField ( Comma typeField )* ;
	[GrammarRule("typeFields")]
	private void typeFields()
	{
		Enter_typeFields();
		EnterRule("typeFields", 17);
		TraceIn("typeFields", 17);
		try { DebugEnterRule(GrammarFileName, "typeFields");
		DebugLocation(116, 42);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:116:12: ( typeField ( Comma typeField )* )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:116:15: typeField ( Comma typeField )*
			{
			DebugLocation(116, 15);
			PushFollow(Follow._typeField_in_typeFields1060);
			typeField();
			PopFollow();
			if (state.failed) return;
			DebugLocation(116, 25);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:116:25: ( Comma typeField )*
			try { DebugEnterSubRule(23);
			while (true)
			{
				int alt23=2;
				try { DebugEnterDecision(23, decisionCanBacktrack[23]);
				int LA23_0 = input.LA(1);

				if ((LA23_0==Comma))
				{
					alt23=1;
				}


				} finally { DebugExitDecision(23); }
				switch ( alt23 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:116:26: Comma typeField
					{
					DebugLocation(116, 26);
					Match(input,Comma,Follow._Comma_in_typeFields1063); if (state.failed) return;
					DebugLocation(116, 32);
					PushFollow(Follow._typeField_in_typeFields1065);
					typeField();
					PopFollow();
					if (state.failed) return;

					}
					break;

				default:
					goto loop23;
				}
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
			TraceOut("typeFields", 17);
			LeaveRule("typeFields", 17);
			Leave_typeFields();
		}
		DebugLocation(116, 42);
		} finally { DebugExitRule(GrammarFileName, "typeFields"); }
		return;

	}
	// $ANTLR end "typeFields"


	partial void Enter_typeField();
	partial void Leave_typeField();

	// $ANTLR start "typeField"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:117:1: typeField : ID TwoDots ID ;
	[GrammarRule("typeField")]
	private void typeField()
	{
		Enter_typeField();
		EnterRule("typeField", 18);
		TraceIn("typeField", 18);
		try { DebugEnterRule(GrammarFileName, "typeField");
		DebugLocation(117, 25);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:117:11: ( ID TwoDots ID )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:117:13: ID TwoDots ID
			{
			DebugLocation(117, 13);
			Match(input,ID,Follow._ID_in_typeField1076); if (state.failed) return;
			DebugLocation(117, 16);
			Match(input,TwoDots,Follow._TwoDots_in_typeField1078); if (state.failed) return;
			DebugLocation(117, 24);
			Match(input,ID,Follow._ID_in_typeField1080); if (state.failed) return;

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
		DebugLocation(117, 25);
		} finally { DebugExitRule(GrammarFileName, "typeField"); }
		return;

	}
	// $ANTLR end "typeField"


	partial void Enter_variableDeclaration();
	partial void Leave_variableDeclaration();

	// $ANTLR start "variableDeclaration"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:119:1: variableDeclaration : ( Var ID Assign expr_or | Var ID TwoDots ID Assign expr_or );
	[GrammarRule("variableDeclaration")]
	private void variableDeclaration()
	{
		Enter_variableDeclaration();
		EnterRule("variableDeclaration", 19);
		TraceIn("variableDeclaration", 19);
		try { DebugEnterRule(GrammarFileName, "variableDeclaration");
		DebugLocation(119, 36);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:119:21: ( Var ID Assign expr_or | Var ID TwoDots ID Assign expr_or )
			int alt24=2;
			try { DebugEnterDecision(24, decisionCanBacktrack[24]);
			int LA24_0 = input.LA(1);

			if ((LA24_0==Var))
			{
				int LA24_1 = input.LA(2);

				if ((LA24_1==ID))
				{
					int LA24_2 = input.LA(3);

					if ((LA24_2==Assign))
					{
						alt24=1;
					}
					else if ((LA24_2==TwoDots))
					{
						alt24=2;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return;}
						NoViableAltException nvae = new NoViableAltException("", 24, 2, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return;}
					NoViableAltException nvae = new NoViableAltException("", 24, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return;}
				NoViableAltException nvae = new NoViableAltException("", 24, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(24); }
			switch (alt24)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:119:23: Var ID Assign expr_or
				{
				DebugLocation(119, 23);
				Match(input,Var,Follow._Var_in_variableDeclaration1090); if (state.failed) return;
				DebugLocation(119, 27);
				Match(input,ID,Follow._ID_in_variableDeclaration1092); if (state.failed) return;
				DebugLocation(119, 30);
				Match(input,Assign,Follow._Assign_in_variableDeclaration1094); if (state.failed) return;
				DebugLocation(119, 37);
				PushFollow(Follow._expr_or_in_variableDeclaration1096);
				expr_or();
				PopFollow();
				if (state.failed) return;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:120:5: Var ID TwoDots ID Assign expr_or
				{
				DebugLocation(120, 5);
				Match(input,Var,Follow._Var_in_variableDeclaration1106); if (state.failed) return;
				DebugLocation(120, 9);
				Match(input,ID,Follow._ID_in_variableDeclaration1108); if (state.failed) return;
				DebugLocation(120, 12);
				Match(input,TwoDots,Follow._TwoDots_in_variableDeclaration1110); if (state.failed) return;
				DebugLocation(120, 20);
				Match(input,ID,Follow._ID_in_variableDeclaration1112); if (state.failed) return;
				DebugLocation(120, 23);
				Match(input,Assign,Follow._Assign_in_variableDeclaration1114); if (state.failed) return;
				DebugLocation(120, 30);
				PushFollow(Follow._expr_or_in_variableDeclaration1116);
				expr_or();
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
			TraceOut("variableDeclaration", 19);
			LeaveRule("variableDeclaration", 19);
			Leave_variableDeclaration();
		}
		DebugLocation(120, 36);
		} finally { DebugExitRule(GrammarFileName, "variableDeclaration"); }
		return;

	}
	// $ANTLR end "variableDeclaration"


	partial void Enter_functionDeclaration();
	partial void Leave_functionDeclaration();

	// $ANTLR start "functionDeclaration"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:124:1: functionDeclaration : Function ID LParent typeFields RParent ( TwoDots ID )? Equals expr ;
	[GrammarRule("functionDeclaration")]
	private void functionDeclaration()
	{
		Enter_functionDeclaration();
		EnterRule("functionDeclaration", 20);
		TraceIn("functionDeclaration", 20);
		try { DebugEnterRule(GrammarFileName, "functionDeclaration");
		DebugLocation(124, 86);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:124:21: ( Function ID LParent typeFields RParent ( TwoDots ID )? Equals expr )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:124:23: Function ID LParent typeFields RParent ( TwoDots ID )? Equals expr
			{
			DebugLocation(124, 23);
			Match(input,Function,Follow._Function_in_functionDeclaration1138); if (state.failed) return;
			DebugLocation(124, 32);
			Match(input,ID,Follow._ID_in_functionDeclaration1140); if (state.failed) return;
			DebugLocation(124, 35);
			Match(input,LParent,Follow._LParent_in_functionDeclaration1142); if (state.failed) return;
			DebugLocation(124, 43);
			PushFollow(Follow._typeFields_in_functionDeclaration1144);
			typeFields();
			PopFollow();
			if (state.failed) return;
			DebugLocation(124, 54);
			Match(input,RParent,Follow._RParent_in_functionDeclaration1146); if (state.failed) return;
			DebugLocation(124, 62);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:124:62: ( TwoDots ID )?
			int alt25=2;
			try { DebugEnterSubRule(25);
			try { DebugEnterDecision(25, decisionCanBacktrack[25]);
			int LA25_0 = input.LA(1);

			if ((LA25_0==TwoDots))
			{
				alt25=1;
			}
			} finally { DebugExitDecision(25); }
			switch (alt25)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:124:63: TwoDots ID
				{
				DebugLocation(124, 63);
				Match(input,TwoDots,Follow._TwoDots_in_functionDeclaration1149); if (state.failed) return;
				DebugLocation(124, 71);
				Match(input,ID,Follow._ID_in_functionDeclaration1151); if (state.failed) return;

				}
				break;

			}
			} finally { DebugExitSubRule(25); }

			DebugLocation(124, 76);
			Match(input,Equals,Follow._Equals_in_functionDeclaration1155); if (state.failed) return;
			DebugLocation(124, 83);
			PushFollow(Follow._expr_in_functionDeclaration1157);
			expr();
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
		DebugLocation(124, 86);
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
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:95:59: ( LCorch expr_or RCorch Of )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:95:60: LCorch expr_or RCorch Of
			{
			DebugLocation(95, 60);
			Match(input,LCorch,Follow._LCorch_in_synpred1_Tiger747); if (state.failed) return;
			DebugLocation(95, 67);
			PushFollow(Follow._expr_or_in_synpred1_Tiger749);
			expr_or();
			PopFollow();
			if (state.failed) return;
			DebugLocation(95, 75);
			Match(input,RCorch,Follow._RCorch_in_synpred1_Tiger751); if (state.failed) return;
			DebugLocation(95, 82);
			Match(input,Of,Follow._Of_in_synpred1_Tiger753); if (state.failed) return;

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
	DFA11 dfa11;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa11 = new DFA11( this, SpecialStateTransition11 );
	}

	private class DFA11 : DFA
	{
		private const string DFA11_eotS =
			"\x22\xFFFF";
		private const string DFA11_eofS =
			"\x1\xF\x21\xFFFF";
		private const string DFA11_minS =
			"\x1\x5\x1D\xFFFF\x1\x0\x3\xFFFF";
		private const string DFA11_maxS =
			"\x1\x2A\x1D\xFFFF\x1\x0\x3\xFFFF";
		private const string DFA11_acceptS =
			"\x1\xFFFF\x1\x1\x1\xFFFF\x1B\x1\x1\xFFFF\x1\x3\x1\xFFFF\x1\x2";
		private const string DFA11_specialS =
			"\x1E\xFFFF\x1\x0\x3\xFFFF}>";
		private static readonly string[] DFA11_transitionS =
			{
				"\x1\x6\x1\x1F\x1\x1\x1\x16\x1\x1E\x1\x10\x1\x1\x1\x19\x1\xFFFF\x1\x11"+
				"\x1\x12\x2\xFFFF\x1\x13\x1\xFFFF\x1\x14\x1\x1A\x1\x17\x1\xFFFF\x1\x18"+
				"\x1\x15\x1\x1F\x1\x5\x1\x3\x1\x4\x1\x7\x1\x8\x1\x9\x1\xA\x1\xB\x1\xC"+
				"\x1\xD\x1\xE\x1\x1B\x2\xFFFF\x1\x1C\x1\x1D",
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
				"\x1\xFFFF",
				"",
				"",
				""
			};

		private static readonly short[] DFA11_eot = DFA.UnpackEncodedString(DFA11_eotS);
		private static readonly short[] DFA11_eof = DFA.UnpackEncodedString(DFA11_eofS);
		private static readonly char[] DFA11_min = DFA.UnpackEncodedStringToUnsignedChars(DFA11_minS);
		private static readonly char[] DFA11_max = DFA.UnpackEncodedStringToUnsignedChars(DFA11_maxS);
		private static readonly short[] DFA11_accept = DFA.UnpackEncodedString(DFA11_acceptS);
		private static readonly short[] DFA11_special = DFA.UnpackEncodedString(DFA11_specialS);
		private static readonly short[][] DFA11_transition;

		static DFA11()
		{
			int numStates = DFA11_transitionS.Length;
			DFA11_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA11_transition[i] = DFA.UnpackEncodedString(DFA11_transitionS[i]);
			}
		}

		public DFA11( BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition )
			: base(specialStateTransition)
		{
			this.recognizer = recognizer;
			this.decisionNumber = 11;
			this.eot = DFA11_eot;
			this.eof = DFA11_eof;
			this.min = DFA11_min;
			this.max = DFA11_max;
			this.accept = DFA11_accept;
			this.special = DFA11_special;
			this.transition = DFA11_transition;
		}

		public override string Description { get { return "95:6: ( ( LParent exprList RParent | LKey fieldList RKey )? | ( LCorch expr_or RCorch Of )=> ( LCorch expr_or RCorch Of expr_or ) | ( lvalue ( Assign expr_or )? ) )"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private int SpecialStateTransition11(DFA dfa, int s, IIntStream _input)
	{
		ITokenStream input = (ITokenStream)_input;
		int _s = s;
		switch (s)
		{
			case 0:
				int LA11_30 = input.LA(1);


				int index11_30 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred1_Tiger_fragment)) ) {s = 33;}

				else if ( (true) ) {s = 31;}


				input.Seek(index11_30);
				if ( s>=0 ) return s;
				break;
		}
		if (state.backtracking > 0) {state.failed=true; return -1;}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 11, _s, input);
		dfa.Error(nvae);
		throw nvae;
	}

	#endregion DFA

	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _expr_or_in_program544 = new BitSet(new ulong[]{0x0UL});
		public static readonly BitSet _EOF_in_program546 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expr_and_in_expr_or553 = new BitSet(new ulong[]{0x2000000002UL});
		public static readonly BitSet _Or_in_expr_or556 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _expr_and_in_expr_or558 = new BitSet(new ulong[]{0x2000000002UL});
		public static readonly BitSet _expr_logical_in_expr_and566 = new BitSet(new ulong[]{0x1000000002UL});
		public static readonly BitSet _And_in_expr_and569 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _expr_logical_in_expr_and571 = new BitSet(new ulong[]{0x1000000002UL});
		public static readonly BitSet _expr_arithm_in_expr_logical581 = new BitSet(new ulong[]{0xFC0000002UL});
		public static readonly BitSet _Equals_in_expr_logical591 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _NotEquals_in_expr_logical596 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _GThan_in_expr_logical600 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _LThan_in_expr_logical604 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _GEThan_in_expr_logical608 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _LEThan_in_expr_logical612 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _expr_arithm_in_expr_logical616 = new BitSet(new ulong[]{0xFC0000002UL});
		public static readonly BitSet _expr_factor_in_expr_arithm629 = new BitSet(new ulong[]{0x8000022UL});
		public static readonly BitSet _Plus_in_expr_arithm634 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _Minus_in_expr_arithm639 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _expr_factor_in_expr_arithm642 = new BitSet(new ulong[]{0x8000022UL});
		public static readonly BitSet _expr_in_expr_factor652 = new BitSet(new ulong[]{0x30000002UL});
		public static readonly BitSet _Mult_in_expr_factor657 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _Div_in_expr_factor662 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _expr_in_expr_factor665 = new BitSet(new ulong[]{0x30000002UL});
		public static readonly BitSet _STRING_CONST_in_expr674 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _INT_CONST_in_expr682 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _NIL_in_expr690 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _Minus_in_expr698 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _expr_or_in_expr700 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_expr724 = new BitSet(new ulong[]{0x4000AC2UL});
		public static readonly BitSet _LParent_in_expr728 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _exprList_in_expr730 = new BitSet(new ulong[]{0x100UL});
		public static readonly BitSet _RParent_in_expr732 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LKey_in_expr736 = new BitSet(new ulong[]{0x20000001000000UL});
		public static readonly BitSet _fieldList_in_expr738 = new BitSet(new ulong[]{0x1000UL});
		public static readonly BitSet _RKey_in_expr740 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LCorch_in_expr759 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _expr_or_in_expr761 = new BitSet(new ulong[]{0x400UL});
		public static readonly BitSet _RCorch_in_expr763 = new BitSet(new ulong[]{0x200000000000UL});
		public static readonly BitSet _Of_in_expr765 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _expr_or_in_expr767 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _lvalue_in_expr773 = new BitSet(new ulong[]{0x42UL});
		public static readonly BitSet _Assign_in_expr776 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _expr_or_in_expr778 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LParent_in_expr789 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _exprSeq_in_expr791 = new BitSet(new ulong[]{0x100UL});
		public static readonly BitSet _RParent_in_expr793 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _If_in_expr802 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _expr_or_in_expr804 = new BitSet(new ulong[]{0x4000UL});
		public static readonly BitSet _Then_in_expr806 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _expr_or_in_expr808 = new BitSet(new ulong[]{0x8002UL});
		public static readonly BitSet _Else_in_expr811 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _expr_or_in_expr813 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _While_in_expr825 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _expr_or_in_expr827 = new BitSet(new ulong[]{0x40000UL});
		public static readonly BitSet _Do_in_expr829 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _expr_or_in_expr831 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _For_in_expr839 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _ID_in_expr841 = new BitSet(new ulong[]{0x40UL});
		public static readonly BitSet _Assign_in_expr843 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _expr_or_in_expr845 = new BitSet(new ulong[]{0x100000UL});
		public static readonly BitSet _To_in_expr847 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _expr_or_in_expr849 = new BitSet(new ulong[]{0x40000UL});
		public static readonly BitSet _Do_in_expr851 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _expr_or_in_expr853 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _Break_in_expr861 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _Let_in_expr870 = new BitSet(new ulong[]{0x64000000000UL});
		public static readonly BitSet _declarationList_in_expr872 = new BitSet(new ulong[]{0x200000UL});
		public static readonly BitSet _In_in_expr874 = new BitSet(new ulong[]{0x30800000CB20B0UL});
		public static readonly BitSet _exprSeq_in_expr877 = new BitSet(new ulong[]{0x400000UL});
		public static readonly BitSet _End_in_expr881 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expr_or_in_exprSeq890 = new BitSet(new ulong[]{0x2000002UL});
		public static readonly BitSet _DotComma_in_exprSeq893 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _expr_or_in_exprSeq895 = new BitSet(new ulong[]{0x2000002UL});
		public static readonly BitSet _expr_or_in_exprList905 = new BitSet(new ulong[]{0x1000002UL});
		public static readonly BitSet _Comma_in_exprList908 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _expr_or_in_exprList910 = new BitSet(new ulong[]{0x1000002UL});
		public static readonly BitSet _idAssign_in_fieldList921 = new BitSet(new ulong[]{0x1000002UL});
		public static readonly BitSet _Comma_in_fieldList924 = new BitSet(new ulong[]{0x20000001000000UL});
		public static readonly BitSet _idAssign_in_fieldList926 = new BitSet(new ulong[]{0x1000002UL});
		public static readonly BitSet _ID_in_idAssign937 = new BitSet(new ulong[]{0x40000000UL});
		public static readonly BitSet _Equals_in_idAssign939 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _expr_or_in_idAssign941 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _Dot_in_lvalue953 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _ID_in_lvalue955 = new BitSet(new ulong[]{0x4000202UL});
		public static readonly BitSet _LCorch_in_lvalue959 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _expr_or_in_lvalue961 = new BitSet(new ulong[]{0x400UL});
		public static readonly BitSet _RCorch_in_lvalue963 = new BitSet(new ulong[]{0x4000202UL});
		public static readonly BitSet _declaration_in_declarationList979 = new BitSet(new ulong[]{0x64000000002UL});
		public static readonly BitSet _typeDeclaration_in_declaration989 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _variableDeclaration_in_declaration998 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _functionDeclaration_in_declaration1006 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _Type_in_typeDeclaration1013 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _ID_in_typeDeclaration1015 = new BitSet(new ulong[]{0x40000000UL});
		public static readonly BitSet _Equals_in_typeDeclaration1017 = new BitSet(new ulong[]{0x20008000000800UL});
		public static readonly BitSet _type_in_typeDeclaration1019 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_type1028 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LKey_in_type1036 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _typeFields_in_type1038 = new BitSet(new ulong[]{0x1000UL});
		public static readonly BitSet _RKey_in_type1040 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ArrayOf_in_type1048 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _ID_in_type1050 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _typeField_in_typeFields1060 = new BitSet(new ulong[]{0x1000002UL});
		public static readonly BitSet _Comma_in_typeFields1063 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _typeField_in_typeFields1065 = new BitSet(new ulong[]{0x1000002UL});
		public static readonly BitSet _ID_in_typeField1076 = new BitSet(new ulong[]{0x10000000000UL});
		public static readonly BitSet _TwoDots_in_typeField1078 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _ID_in_typeField1080 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _Var_in_variableDeclaration1090 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _ID_in_variableDeclaration1092 = new BitSet(new ulong[]{0x40UL});
		public static readonly BitSet _Assign_in_variableDeclaration1094 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _expr_or_in_variableDeclaration1096 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _Var_in_variableDeclaration1106 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _ID_in_variableDeclaration1108 = new BitSet(new ulong[]{0x10000000000UL});
		public static readonly BitSet _TwoDots_in_variableDeclaration1110 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _ID_in_variableDeclaration1112 = new BitSet(new ulong[]{0x40UL});
		public static readonly BitSet _Assign_in_variableDeclaration1114 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _expr_or_in_variableDeclaration1116 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _Function_in_functionDeclaration1138 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _ID_in_functionDeclaration1140 = new BitSet(new ulong[]{0x80UL});
		public static readonly BitSet _LParent_in_functionDeclaration1142 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _typeFields_in_functionDeclaration1144 = new BitSet(new ulong[]{0x100UL});
		public static readonly BitSet _RParent_in_functionDeclaration1146 = new BitSet(new ulong[]{0x10040000000UL});
		public static readonly BitSet _TwoDots_in_functionDeclaration1149 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _ID_in_functionDeclaration1151 = new BitSet(new ulong[]{0x40000000UL});
		public static readonly BitSet _Equals_in_functionDeclaration1155 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _expr_in_functionDeclaration1157 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LCorch_in_synpred1_Tiger747 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _expr_or_in_synpred1_Tiger749 = new BitSet(new ulong[]{0x400UL});
		public static readonly BitSet _RCorch_in_synpred1_Tiger751 = new BitSet(new ulong[]{0x200000000000UL});
		public static readonly BitSet _Of_in_synpred1_Tiger753 = new BitSet(new ulong[]{0x2UL});

	}
	#endregion Follow sets
}
