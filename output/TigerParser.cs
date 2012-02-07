// $ANTLR 3.3 Nov 30, 2010 12:45:30 C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g 2012-02-07 02:02:08

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
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:67:8: public program : expr_or EOF ;
	[GrammarRule("program")]
	public void program()
	{
		Enter_program();
		EnterRule("program", 1);
		TraceIn("program", 1);
		try { DebugEnterRule(GrammarFileName, "program");
		DebugLocation(67, 28);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:67:15: ( expr_or EOF )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:67:18: expr_or EOF
			{
			DebugLocation(67, 18);
			PushFollow(Follow._expr_or_in_program534);
			expr_or();
			PopFollow();
			if (state.failed) return;
			DebugLocation(67, 26);
			Match(input,EOF,Follow._EOF_in_program536); if (state.failed) return;

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
		DebugLocation(67, 28);
		} finally { DebugExitRule(GrammarFileName, "program"); }
		return;

	}
	// $ANTLR end "program"


	partial void Enter_expr_or();
	partial void Leave_expr_or();

	// $ANTLR start "expr_or"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:68:1: expr_or : expr_and ( Or expr_and )* ;
	[GrammarRule("expr_or")]
	private void expr_or()
	{
		Enter_expr_or();
		EnterRule("expr_or", 2);
		TraceIn("expr_or", 2);
		try { DebugEnterRule(GrammarFileName, "expr_or");
		DebugLocation(68, 33);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:68:9: ( expr_and ( Or expr_and )* )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:68:11: expr_and ( Or expr_and )*
			{
			DebugLocation(68, 11);
			PushFollow(Follow._expr_and_in_expr_or543);
			expr_and();
			PopFollow();
			if (state.failed) return;
			DebugLocation(68, 20);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:68:20: ( Or expr_and )*
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
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:68:21: Or expr_and
					{
					DebugLocation(68, 21);
					Match(input,Or,Follow._Or_in_expr_or546); if (state.failed) return;
					DebugLocation(68, 24);
					PushFollow(Follow._expr_and_in_expr_or548);
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
		DebugLocation(68, 33);
		} finally { DebugExitRule(GrammarFileName, "expr_or"); }
		return;

	}
	// $ANTLR end "expr_or"


	partial void Enter_expr_and();
	partial void Leave_expr_and();

	// $ANTLR start "expr_and"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:69:1: expr_and : expr_logical ( And expr_logical )* ;
	[GrammarRule("expr_and")]
	private void expr_and()
	{
		Enter_expr_and();
		EnterRule("expr_and", 3);
		TraceIn("expr_and", 3);
		try { DebugEnterRule(GrammarFileName, "expr_and");
		DebugLocation(69, 42);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:69:9: ( expr_logical ( And expr_logical )* )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:69:11: expr_logical ( And expr_logical )*
			{
			DebugLocation(69, 11);
			PushFollow(Follow._expr_logical_in_expr_and556);
			expr_logical();
			PopFollow();
			if (state.failed) return;
			DebugLocation(69, 24);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:69:24: ( And expr_logical )*
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
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:69:25: And expr_logical
					{
					DebugLocation(69, 25);
					Match(input,And,Follow._And_in_expr_and559); if (state.failed) return;
					DebugLocation(69, 29);
					PushFollow(Follow._expr_logical_in_expr_and561);
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
		DebugLocation(69, 42);
		} finally { DebugExitRule(GrammarFileName, "expr_and"); }
		return;

	}
	// $ANTLR end "expr_and"


	partial void Enter_expr_logical();
	partial void Leave_expr_logical();

	// $ANTLR start "expr_logical"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:70:1: expr_logical : expr_arithm ( ( ( ( Equals ) | NotEquals | GThan | LThan | GEThan | LEThan ) ) expr_arithm )* ;
	[GrammarRule("expr_logical")]
	private void expr_logical()
	{
		Enter_expr_logical();
		EnterRule("expr_logical", 4);
		TraceIn("expr_logical", 4);
		try { DebugEnterRule(GrammarFileName, "expr_logical");
		DebugLocation(70, 4);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:71:2: ( expr_arithm ( ( ( ( Equals ) | NotEquals | GThan | LThan | GEThan | LEThan ) ) expr_arithm )* )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:71:4: expr_arithm ( ( ( ( Equals ) | NotEquals | GThan | LThan | GEThan | LEThan ) ) expr_arithm )*
			{
			DebugLocation(71, 4);
			PushFollow(Follow._expr_arithm_in_expr_logical571);
			expr_arithm();
			PopFollow();
			if (state.failed) return;
			DebugLocation(71, 16);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:71:16: ( ( ( ( Equals ) | NotEquals | GThan | LThan | GEThan | LEThan ) ) expr_arithm )*
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
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:72:4: ( ( ( Equals ) | NotEquals | GThan | LThan | GEThan | LEThan ) ) expr_arithm
					{
					DebugLocation(72, 4);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:72:4: ( ( ( Equals ) | NotEquals | GThan | LThan | GEThan | LEThan ) )
					DebugEnterAlt(1);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:72:5: ( ( Equals ) | NotEquals | GThan | LThan | GEThan | LEThan )
					{
					DebugLocation(72, 5);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:72:5: ( ( Equals ) | NotEquals | GThan | LThan | GEThan | LEThan )
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
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:72:6: ( Equals )
						{
						DebugLocation(72, 6);
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:72:6: ( Equals )
						DebugEnterAlt(1);
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:72:7: Equals
						{
						DebugLocation(72, 7);
						Match(input,Equals,Follow._Equals_in_expr_logical581); if (state.failed) return;

						}


						}
						break;
					case 2:
						DebugEnterAlt(2);
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:72:17: NotEquals
						{
						DebugLocation(72, 17);
						Match(input,NotEquals,Follow._NotEquals_in_expr_logical586); if (state.failed) return;

						}
						break;
					case 3:
						DebugEnterAlt(3);
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:72:29: GThan
						{
						DebugLocation(72, 29);
						Match(input,GThan,Follow._GThan_in_expr_logical590); if (state.failed) return;

						}
						break;
					case 4:
						DebugEnterAlt(4);
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:72:37: LThan
						{
						DebugLocation(72, 37);
						Match(input,LThan,Follow._LThan_in_expr_logical594); if (state.failed) return;

						}
						break;
					case 5:
						DebugEnterAlt(5);
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:72:45: GEThan
						{
						DebugLocation(72, 45);
						Match(input,GEThan,Follow._GEThan_in_expr_logical598); if (state.failed) return;

						}
						break;
					case 6:
						DebugEnterAlt(6);
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:72:54: LEThan
						{
						DebugLocation(72, 54);
						Match(input,LEThan,Follow._LEThan_in_expr_logical602); if (state.failed) return;

						}
						break;

					}
					} finally { DebugExitSubRule(3); }


					}

					DebugLocation(72, 63);
					PushFollow(Follow._expr_arithm_in_expr_logical606);
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
		DebugLocation(73, 4);
		} finally { DebugExitRule(GrammarFileName, "expr_logical"); }
		return;

	}
	// $ANTLR end "expr_logical"


	partial void Enter_expr_arithm();
	partial void Leave_expr_arithm();

	// $ANTLR start "expr_arithm"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:74:1: expr_arithm : expr_factor ( ( ( Plus ) | Minus ) expr_factor )* ;
	[GrammarRule("expr_arithm")]
	private void expr_arithm()
	{
		Enter_expr_arithm();
		EnterRule("expr_arithm", 5);
		TraceIn("expr_arithm", 5);
		try { DebugEnterRule(GrammarFileName, "expr_arithm");
		DebugLocation(74, 46);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:75:2: ( expr_factor ( ( ( Plus ) | Minus ) expr_factor )* )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:75:4: expr_factor ( ( ( Plus ) | Minus ) expr_factor )*
			{
			DebugLocation(75, 4);
			PushFollow(Follow._expr_factor_in_expr_arithm619);
			expr_factor();
			PopFollow();
			if (state.failed) return;
			DebugLocation(75, 16);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:75:16: ( ( ( Plus ) | Minus ) expr_factor )*
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
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:75:17: ( ( Plus ) | Minus ) expr_factor
					{
					DebugLocation(75, 17);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:75:17: ( ( Plus ) | Minus )
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
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:75:18: ( Plus )
						{
						DebugLocation(75, 18);
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:75:18: ( Plus )
						DebugEnterAlt(1);
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:75:19: Plus
						{
						DebugLocation(75, 19);
						Match(input,Plus,Follow._Plus_in_expr_arithm624); if (state.failed) return;

						}


						}
						break;
					case 2:
						DebugEnterAlt(2);
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:75:27: Minus
						{
						DebugLocation(75, 27);
						Match(input,Minus,Follow._Minus_in_expr_arithm629); if (state.failed) return;

						}
						break;

					}
					} finally { DebugExitSubRule(5); }

					DebugLocation(75, 34);
					PushFollow(Follow._expr_factor_in_expr_arithm632);
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
		DebugLocation(75, 46);
		} finally { DebugExitRule(GrammarFileName, "expr_arithm"); }
		return;

	}
	// $ANTLR end "expr_arithm"


	partial void Enter_expr_factor();
	partial void Leave_expr_factor();

	// $ANTLR start "expr_factor"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:76:1: expr_factor : expr ( ( ( Mult ) | Div ) expr )* ;
	[GrammarRule("expr_factor")]
	private void expr_factor()
	{
		Enter_expr_factor();
		EnterRule("expr_factor", 6);
		TraceIn("expr_factor", 6);
		try { DebugEnterRule(GrammarFileName, "expr_factor");
		DebugLocation(76, 30);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:77:2: ( expr ( ( ( Mult ) | Div ) expr )* )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:77:4: expr ( ( ( Mult ) | Div ) expr )*
			{
			DebugLocation(77, 4);
			PushFollow(Follow._expr_in_expr_factor642);
			expr();
			PopFollow();
			if (state.failed) return;
			DebugLocation(77, 9);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:77:9: ( ( ( Mult ) | Div ) expr )*
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
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:77:10: ( ( Mult ) | Div ) expr
					{
					DebugLocation(77, 10);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:77:10: ( ( Mult ) | Div )
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
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:77:11: ( Mult )
						{
						DebugLocation(77, 11);
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:77:11: ( Mult )
						DebugEnterAlt(1);
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:77:12: Mult
						{
						DebugLocation(77, 12);
						Match(input,Mult,Follow._Mult_in_expr_factor647); if (state.failed) return;

						}


						}
						break;
					case 2:
						DebugEnterAlt(2);
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:77:20: Div
						{
						DebugLocation(77, 20);
						Match(input,Div,Follow._Div_in_expr_factor652); if (state.failed) return;

						}
						break;

					}
					} finally { DebugExitSubRule(7); }

					DebugLocation(77, 25);
					PushFollow(Follow._expr_in_expr_factor655);
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
		DebugLocation(77, 30);
		} finally { DebugExitRule(GrammarFileName, "expr_factor"); }
		return;

	}
	// $ANTLR end "expr_factor"


	partial void Enter_expr();
	partial void Leave_expr();

	// $ANTLR start "expr"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:78:1: expr : ( STRING_CONST | INT_CONST | NIL | Minus expr | ID ( ( LParent exprList RParent | LKey fieldList RKey )? | ( LCorch expr_or RCorch Of )=> ( LCorch expr_or RCorch Of expr_or ) | ( lvalue ( Assign expr_or )? ) ) | LParent exprSeq RParent | If expr_or Then expr_or ( Else expr_or )? | While expr_or Do expr_or | For ID Assign expr_or To expr_or Do expr_or | Break | Let declarationList In ( exprSeq )? End );
	[GrammarRule("expr")]
	private void expr()
	{
		Enter_expr();
		EnterRule("expr", 7);
		TraceIn("expr", 7);
		try { DebugEnterRule(GrammarFileName, "expr");
		DebugLocation(78, 39);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:78:6: ( STRING_CONST | INT_CONST | NIL | Minus expr | ID ( ( LParent exprList RParent | LKey fieldList RKey )? | ( LCorch expr_or RCorch Of )=> ( LCorch expr_or RCorch Of expr_or ) | ( lvalue ( Assign expr_or )? ) ) | LParent exprSeq RParent | If expr_or Then expr_or ( Else expr_or )? | While expr_or Do expr_or | For ID Assign expr_or To expr_or Do expr_or | Break | Let declarationList In ( exprSeq )? End )
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
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:78:8: STRING_CONST
				{
				DebugLocation(78, 8);
				Match(input,STRING_CONST,Follow._STRING_CONST_in_expr664); if (state.failed) return;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:79:3: INT_CONST
				{
				DebugLocation(79, 3);
				Match(input,INT_CONST,Follow._INT_CONST_in_expr670); if (state.failed) return;

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:80:3: NIL
				{
				DebugLocation(80, 3);
				Match(input,NIL,Follow._NIL_in_expr676); if (state.failed) return;

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:81:3: Minus expr
				{
				DebugLocation(81, 3);
				Match(input,Minus,Follow._Minus_in_expr682); if (state.failed) return;
				DebugLocation(81, 9);
				PushFollow(Follow._expr_in_expr684);
				expr();
				PopFollow();
				if (state.failed) return;

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:85:3: ID ( ( LParent exprList RParent | LKey fieldList RKey )? | ( LCorch expr_or RCorch Of )=> ( LCorch expr_or RCorch Of expr_or ) | ( lvalue ( Assign expr_or )? ) )
				{
				DebugLocation(85, 3);
				Match(input,ID,Follow._ID_in_expr706); if (state.failed) return;
				DebugLocation(85, 6);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:85:6: ( ( LParent exprList RParent | LKey fieldList RKey )? | ( LCorch expr_or RCorch Of )=> ( LCorch expr_or RCorch Of expr_or ) | ( lvalue ( Assign expr_or )? ) )
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
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:85:7: ( LParent exprList RParent | LKey fieldList RKey )?
					{
					DebugLocation(85, 7);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:85:7: ( LParent exprList RParent | LKey fieldList RKey )?
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
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:85:8: LParent exprList RParent
						{
						DebugLocation(85, 8);
						Match(input,LParent,Follow._LParent_in_expr710); if (state.failed) return;
						DebugLocation(85, 16);
						PushFollow(Follow._exprList_in_expr712);
						exprList();
						PopFollow();
						if (state.failed) return;
						DebugLocation(85, 25);
						Match(input,RParent,Follow._RParent_in_expr714); if (state.failed) return;

						}
						break;
					case 2:
						DebugEnterAlt(2);
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:85:35: LKey fieldList RKey
						{
						DebugLocation(85, 35);
						Match(input,LKey,Follow._LKey_in_expr718); if (state.failed) return;
						DebugLocation(85, 40);
						PushFollow(Follow._fieldList_in_expr720);
						fieldList();
						PopFollow();
						if (state.failed) return;
						DebugLocation(85, 50);
						Match(input,RKey,Follow._RKey_in_expr722); if (state.failed) return;

						}
						break;

					}
					} finally { DebugExitSubRule(9); }


					}
					break;
				case 2:
					DebugEnterAlt(2);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:85:59: ( LCorch expr_or RCorch Of )=> ( LCorch expr_or RCorch Of expr_or )
					{
					DebugLocation(85, 89);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:85:89: ( LCorch expr_or RCorch Of expr_or )
					DebugEnterAlt(1);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:85:90: LCorch expr_or RCorch Of expr_or
					{
					DebugLocation(85, 90);
					Match(input,LCorch,Follow._LCorch_in_expr741); if (state.failed) return;
					DebugLocation(85, 97);
					PushFollow(Follow._expr_or_in_expr743);
					expr_or();
					PopFollow();
					if (state.failed) return;
					DebugLocation(85, 105);
					Match(input,RCorch,Follow._RCorch_in_expr745); if (state.failed) return;
					DebugLocation(85, 112);
					Match(input,Of,Follow._Of_in_expr747); if (state.failed) return;
					DebugLocation(85, 115);
					PushFollow(Follow._expr_or_in_expr749);
					expr_or();
					PopFollow();
					if (state.failed) return;

					}


					}
					break;
				case 3:
					DebugEnterAlt(3);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:85:126: ( lvalue ( Assign expr_or )? )
					{
					DebugLocation(85, 126);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:85:126: ( lvalue ( Assign expr_or )? )
					DebugEnterAlt(1);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:85:127: lvalue ( Assign expr_or )?
					{
					DebugLocation(85, 127);
					PushFollow(Follow._lvalue_in_expr755);
					lvalue();
					PopFollow();
					if (state.failed) return;
					DebugLocation(85, 134);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:85:134: ( Assign expr_or )?
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
						// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:85:135: Assign expr_or
						{
						DebugLocation(85, 135);
						Match(input,Assign,Follow._Assign_in_expr758); if (state.failed) return;
						DebugLocation(85, 142);
						PushFollow(Follow._expr_or_in_expr760);
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
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:86:3: LParent exprSeq RParent
				{
				DebugLocation(86, 3);
				Match(input,LParent,Follow._LParent_in_expr771); if (state.failed) return;
				DebugLocation(86, 11);
				PushFollow(Follow._exprSeq_in_expr773);
				exprSeq();
				PopFollow();
				if (state.failed) return;
				DebugLocation(86, 19);
				Match(input,RParent,Follow._RParent_in_expr775); if (state.failed) return;

				}
				break;
			case 7:
				DebugEnterAlt(7);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:87:3: If expr_or Then expr_or ( Else expr_or )?
				{
				DebugLocation(87, 3);
				Match(input,If,Follow._If_in_expr784); if (state.failed) return;
				DebugLocation(87, 6);
				PushFollow(Follow._expr_or_in_expr786);
				expr_or();
				PopFollow();
				if (state.failed) return;
				DebugLocation(87, 14);
				Match(input,Then,Follow._Then_in_expr788); if (state.failed) return;
				DebugLocation(87, 19);
				PushFollow(Follow._expr_or_in_expr790);
				expr_or();
				PopFollow();
				if (state.failed) return;
				DebugLocation(87, 27);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:87:27: ( Else expr_or )?
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
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:87:28: Else expr_or
					{
					DebugLocation(87, 28);
					Match(input,Else,Follow._Else_in_expr793); if (state.failed) return;
					DebugLocation(87, 33);
					PushFollow(Follow._expr_or_in_expr795);
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
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:88:3: While expr_or Do expr_or
				{
				DebugLocation(88, 3);
				Match(input,While,Follow._While_in_expr807); if (state.failed) return;
				DebugLocation(88, 9);
				PushFollow(Follow._expr_or_in_expr809);
				expr_or();
				PopFollow();
				if (state.failed) return;
				DebugLocation(88, 17);
				Match(input,Do,Follow._Do_in_expr811); if (state.failed) return;
				DebugLocation(88, 20);
				PushFollow(Follow._expr_or_in_expr813);
				expr_or();
				PopFollow();
				if (state.failed) return;

				}
				break;
			case 9:
				DebugEnterAlt(9);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:89:3: For ID Assign expr_or To expr_or Do expr_or
				{
				DebugLocation(89, 3);
				Match(input,For,Follow._For_in_expr821); if (state.failed) return;
				DebugLocation(89, 7);
				Match(input,ID,Follow._ID_in_expr823); if (state.failed) return;
				DebugLocation(89, 10);
				Match(input,Assign,Follow._Assign_in_expr825); if (state.failed) return;
				DebugLocation(89, 17);
				PushFollow(Follow._expr_or_in_expr827);
				expr_or();
				PopFollow();
				if (state.failed) return;
				DebugLocation(89, 25);
				Match(input,To,Follow._To_in_expr829); if (state.failed) return;
				DebugLocation(89, 28);
				PushFollow(Follow._expr_or_in_expr831);
				expr_or();
				PopFollow();
				if (state.failed) return;
				DebugLocation(89, 36);
				Match(input,Do,Follow._Do_in_expr833); if (state.failed) return;
				DebugLocation(89, 39);
				PushFollow(Follow._expr_or_in_expr835);
				expr_or();
				PopFollow();
				if (state.failed) return;

				}
				break;
			case 10:
				DebugEnterAlt(10);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:90:3: Break
				{
				DebugLocation(90, 3);
				Match(input,Break,Follow._Break_in_expr843); if (state.failed) return;

				}
				break;
			case 11:
				DebugEnterAlt(11);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:91:3: Let declarationList In ( exprSeq )? End
				{
				DebugLocation(91, 3);
				Match(input,Let,Follow._Let_in_expr852); if (state.failed) return;
				DebugLocation(91, 7);
				PushFollow(Follow._declarationList_in_expr854);
				declarationList();
				PopFollow();
				if (state.failed) return;
				DebugLocation(91, 23);
				Match(input,In,Follow._In_in_expr856); if (state.failed) return;
				DebugLocation(91, 26);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:91:26: ( exprSeq )?
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
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:91:27: exprSeq
					{
					DebugLocation(91, 27);
					PushFollow(Follow._exprSeq_in_expr859);
					exprSeq();
					PopFollow();
					if (state.failed) return;

					}
					break;

				}
				} finally { DebugExitSubRule(13); }

				DebugLocation(91, 37);
				Match(input,End,Follow._End_in_expr863); if (state.failed) return;

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
		DebugLocation(91, 39);
		} finally { DebugExitRule(GrammarFileName, "expr"); }
		return;

	}
	// $ANTLR end "expr"


	partial void Enter_exprSeq();
	partial void Leave_exprSeq();

	// $ANTLR start "exprSeq"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:92:1: exprSeq : expr_or ( DotComma expr_or )* ;
	[GrammarRule("exprSeq")]
	private void exprSeq()
	{
		Enter_exprSeq();
		EnterRule("exprSeq", 8);
		TraceIn("exprSeq", 8);
		try { DebugEnterRule(GrammarFileName, "exprSeq");
		DebugLocation(92, 37);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:92:9: ( expr_or ( DotComma expr_or )* )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:92:11: expr_or ( DotComma expr_or )*
			{
			DebugLocation(92, 11);
			PushFollow(Follow._expr_or_in_exprSeq872);
			expr_or();
			PopFollow();
			if (state.failed) return;
			DebugLocation(92, 19);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:92:19: ( DotComma expr_or )*
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
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:92:20: DotComma expr_or
					{
					DebugLocation(92, 20);
					Match(input,DotComma,Follow._DotComma_in_exprSeq875); if (state.failed) return;
					DebugLocation(92, 29);
					PushFollow(Follow._expr_or_in_exprSeq877);
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
		DebugLocation(92, 37);
		} finally { DebugExitRule(GrammarFileName, "exprSeq"); }
		return;

	}
	// $ANTLR end "exprSeq"


	partial void Enter_exprList();
	partial void Leave_exprList();

	// $ANTLR start "exprList"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:93:1: exprList : expr_or ( Comma expr_or )* ;
	[GrammarRule("exprList")]
	private void exprList()
	{
		Enter_exprList();
		EnterRule("exprList", 9);
		TraceIn("exprList", 9);
		try { DebugEnterRule(GrammarFileName, "exprList");
		DebugLocation(93, 34);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:93:9: ( expr_or ( Comma expr_or )* )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:93:11: expr_or ( Comma expr_or )*
			{
			DebugLocation(93, 11);
			PushFollow(Follow._expr_or_in_exprList885);
			expr_or();
			PopFollow();
			if (state.failed) return;
			DebugLocation(93, 19);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:93:19: ( Comma expr_or )*
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
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:93:20: Comma expr_or
					{
					DebugLocation(93, 20);
					Match(input,Comma,Follow._Comma_in_exprList888); if (state.failed) return;
					DebugLocation(93, 26);
					PushFollow(Follow._expr_or_in_exprList890);
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
		DebugLocation(93, 34);
		} finally { DebugExitRule(GrammarFileName, "exprList"); }
		return;

	}
	// $ANTLR end "exprList"


	partial void Enter_fieldList();
	partial void Leave_fieldList();

	// $ANTLR start "fieldList"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:94:1: fieldList : idAssign ( Comma idAssign )* ;
	[GrammarRule("fieldList")]
	private void fieldList()
	{
		Enter_fieldList();
		EnterRule("fieldList", 10);
		TraceIn("fieldList", 10);
		try { DebugEnterRule(GrammarFileName, "fieldList");
		DebugLocation(94, 38);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:94:11: ( idAssign ( Comma idAssign )* )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:94:13: idAssign ( Comma idAssign )*
			{
			DebugLocation(94, 13);
			PushFollow(Follow._idAssign_in_fieldList899);
			idAssign();
			PopFollow();
			if (state.failed) return;
			DebugLocation(94, 22);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:94:22: ( Comma idAssign )*
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
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:94:23: Comma idAssign
					{
					DebugLocation(94, 23);
					Match(input,Comma,Follow._Comma_in_fieldList902); if (state.failed) return;
					DebugLocation(94, 29);
					PushFollow(Follow._idAssign_in_fieldList904);
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
		DebugLocation(94, 38);
		} finally { DebugExitRule(GrammarFileName, "fieldList"); }
		return;

	}
	// $ANTLR end "fieldList"


	partial void Enter_idAssign();
	partial void Leave_idAssign();

	// $ANTLR start "idAssign"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:96:1: idAssign : ( ID Equals expr_or | );
	[GrammarRule("idAssign")]
	private void idAssign()
	{
		Enter_idAssign();
		EnterRule("idAssign", 11);
		TraceIn("idAssign", 11);
		try { DebugEnterRule(GrammarFileName, "idAssign");
		DebugLocation(96, 29);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:96:9: ( ID Equals expr_or | )
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
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:96:11: ID Equals expr_or
				{
				DebugLocation(96, 11);
				Match(input,ID,Follow._ID_in_idAssign913); if (state.failed) return;
				DebugLocation(96, 14);
				Match(input,Equals,Follow._Equals_in_idAssign915); if (state.failed) return;
				DebugLocation(96, 21);
				PushFollow(Follow._expr_or_in_idAssign917);
				expr_or();
				PopFollow();
				if (state.failed) return;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:96:30: 
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
		DebugLocation(96, 29);
		} finally { DebugExitRule(GrammarFileName, "idAssign"); }
		return;

	}
	// $ANTLR end "idAssign"


	partial void Enter_lvalue();
	partial void Leave_lvalue();

	// $ANTLR start "lvalue"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:97:1: lvalue : ( Dot ID | LCorch expr_or RCorch )* ;
	[GrammarRule("lvalue")]
	private void lvalue()
	{
		Enter_lvalue();
		EnterRule("lvalue", 12);
		TraceIn("lvalue", 12);
		try { DebugEnterRule(GrammarFileName, "lvalue");
		DebugLocation(97, 43);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:97:8: ( ( Dot ID | LCorch expr_or RCorch )* )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:97:10: ( Dot ID | LCorch expr_or RCorch )*
			{
			DebugLocation(97, 10);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:97:10: ( Dot ID | LCorch expr_or RCorch )*
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
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:97:11: Dot ID
					{
					DebugLocation(97, 11);
					Match(input,Dot,Follow._Dot_in_lvalue927); if (state.failed) return;
					DebugLocation(97, 15);
					Match(input,ID,Follow._ID_in_lvalue929); if (state.failed) return;

					}
					break;
				case 2:
					DebugEnterAlt(2);
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:97:20: LCorch expr_or RCorch
					{
					DebugLocation(97, 20);
					Match(input,LCorch,Follow._LCorch_in_lvalue933); if (state.failed) return;
					DebugLocation(97, 27);
					PushFollow(Follow._expr_or_in_lvalue935);
					expr_or();
					PopFollow();
					if (state.failed) return;
					DebugLocation(97, 35);
					Match(input,RCorch,Follow._RCorch_in_lvalue937); if (state.failed) return;

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
		DebugLocation(97, 43);
		} finally { DebugExitRule(GrammarFileName, "lvalue"); }
		return;

	}
	// $ANTLR end "lvalue"


	partial void Enter_declarationList();
	partial void Leave_declarationList();

	// $ANTLR start "declarationList"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:98:1: declarationList : ( declaration )+ ;
	[GrammarRule("declarationList")]
	private void declarationList()
	{
		Enter_declarationList();
		EnterRule("declarationList", 13);
		TraceIn("declarationList", 13);
		try { DebugEnterRule(GrammarFileName, "declarationList");
		DebugLocation(98, 30);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:98:17: ( ( declaration )+ )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:98:19: ( declaration )+
			{
			DebugLocation(98, 19);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:98:19: ( declaration )+
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
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:98:19: declaration
					{
					DebugLocation(98, 19);
					PushFollow(Follow._declaration_in_declarationList947);
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
		DebugLocation(98, 30);
		} finally { DebugExitRule(GrammarFileName, "declarationList"); }
		return;

	}
	// $ANTLR end "declarationList"


	partial void Enter_declaration();
	partial void Leave_declaration();

	// $ANTLR start "declaration"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:99:1: declaration : ( typeDeclaration | variableDeclaration | functionDeclaration );
	[GrammarRule("declaration")]
	private void declaration()
	{
		Enter_declaration();
		EnterRule("declaration", 14);
		TraceIn("declaration", 14);
		try { DebugEnterRule(GrammarFileName, "declaration");
		DebugLocation(99, 22);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:99:13: ( typeDeclaration | variableDeclaration | functionDeclaration )
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
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:99:15: typeDeclaration
				{
				DebugLocation(99, 15);
				PushFollow(Follow._typeDeclaration_in_declaration955);
				typeDeclaration();
				PopFollow();
				if (state.failed) return;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:100:4: variableDeclaration
				{
				DebugLocation(100, 4);
				PushFollow(Follow._variableDeclaration_in_declaration963);
				variableDeclaration();
				PopFollow();
				if (state.failed) return;

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:101:4: functionDeclaration
				{
				DebugLocation(101, 4);
				PushFollow(Follow._functionDeclaration_in_declaration971);
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
		DebugLocation(101, 22);
		} finally { DebugExitRule(GrammarFileName, "declaration"); }
		return;

	}
	// $ANTLR end "declaration"


	partial void Enter_typeDeclaration();
	partial void Leave_typeDeclaration();

	// $ANTLR start "typeDeclaration"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:102:1: typeDeclaration : Type ID Equals type ;
	[GrammarRule("typeDeclaration")]
	private void typeDeclaration()
	{
		Enter_typeDeclaration();
		EnterRule("typeDeclaration", 15);
		TraceIn("typeDeclaration", 15);
		try { DebugEnterRule(GrammarFileName, "typeDeclaration");
		DebugLocation(102, 37);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:102:17: ( Type ID Equals type )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:102:19: Type ID Equals type
			{
			DebugLocation(102, 19);
			Match(input,Type,Follow._Type_in_typeDeclaration978); if (state.failed) return;
			DebugLocation(102, 24);
			Match(input,ID,Follow._ID_in_typeDeclaration980); if (state.failed) return;
			DebugLocation(102, 27);
			Match(input,Equals,Follow._Equals_in_typeDeclaration982); if (state.failed) return;
			DebugLocation(102, 34);
			PushFollow(Follow._type_in_typeDeclaration984);
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
		DebugLocation(102, 37);
		} finally { DebugExitRule(GrammarFileName, "typeDeclaration"); }
		return;

	}
	// $ANTLR end "typeDeclaration"


	partial void Enter_type();
	partial void Leave_type();

	// $ANTLR start "type"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:103:1: type : ( ID | LKey typeFields RKey | ArrayOf ID );
	[GrammarRule("type")]
	private void type()
	{
		Enter_type();
		EnterRule("type", 16);
		TraceIn("type", 16);
		try { DebugEnterRule(GrammarFileName, "type");
		DebugLocation(103, 12);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:103:6: ( ID | LKey typeFields RKey | ArrayOf ID )
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
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:103:8: ID
				{
				DebugLocation(103, 8);
				Match(input,ID,Follow._ID_in_type991); if (state.failed) return;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:104:3: LKey typeFields RKey
				{
				DebugLocation(104, 3);
				Match(input,LKey,Follow._LKey_in_type998); if (state.failed) return;
				DebugLocation(104, 8);
				PushFollow(Follow._typeFields_in_type1000);
				typeFields();
				PopFollow();
				if (state.failed) return;
				DebugLocation(104, 19);
				Match(input,RKey,Follow._RKey_in_type1002); if (state.failed) return;

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:105:3: ArrayOf ID
				{
				DebugLocation(105, 3);
				Match(input,ArrayOf,Follow._ArrayOf_in_type1009); if (state.failed) return;
				DebugLocation(105, 11);
				Match(input,ID,Follow._ID_in_type1011); if (state.failed) return;

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
		DebugLocation(105, 12);
		} finally { DebugExitRule(GrammarFileName, "type"); }
		return;

	}
	// $ANTLR end "type"


	partial void Enter_typeFields();
	partial void Leave_typeFields();

	// $ANTLR start "typeFields"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:106:1: typeFields : typeField ( Comma typeField )* ;
	[GrammarRule("typeFields")]
	private void typeFields()
	{
		Enter_typeFields();
		EnterRule("typeFields", 17);
		TraceIn("typeFields", 17);
		try { DebugEnterRule(GrammarFileName, "typeFields");
		DebugLocation(106, 42);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:106:12: ( typeField ( Comma typeField )* )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:106:15: typeField ( Comma typeField )*
			{
			DebugLocation(106, 15);
			PushFollow(Follow._typeField_in_typeFields1019);
			typeField();
			PopFollow();
			if (state.failed) return;
			DebugLocation(106, 25);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:106:25: ( Comma typeField )*
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
					// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:106:26: Comma typeField
					{
					DebugLocation(106, 26);
					Match(input,Comma,Follow._Comma_in_typeFields1022); if (state.failed) return;
					DebugLocation(106, 32);
					PushFollow(Follow._typeField_in_typeFields1024);
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
		DebugLocation(106, 42);
		} finally { DebugExitRule(GrammarFileName, "typeFields"); }
		return;

	}
	// $ANTLR end "typeFields"


	partial void Enter_typeField();
	partial void Leave_typeField();

	// $ANTLR start "typeField"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:107:1: typeField : ID TwoDots ID ;
	[GrammarRule("typeField")]
	private void typeField()
	{
		Enter_typeField();
		EnterRule("typeField", 18);
		TraceIn("typeField", 18);
		try { DebugEnterRule(GrammarFileName, "typeField");
		DebugLocation(107, 25);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:107:11: ( ID TwoDots ID )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:107:13: ID TwoDots ID
			{
			DebugLocation(107, 13);
			Match(input,ID,Follow._ID_in_typeField1033); if (state.failed) return;
			DebugLocation(107, 16);
			Match(input,TwoDots,Follow._TwoDots_in_typeField1035); if (state.failed) return;
			DebugLocation(107, 24);
			Match(input,ID,Follow._ID_in_typeField1037); if (state.failed) return;

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
		DebugLocation(107, 25);
		} finally { DebugExitRule(GrammarFileName, "typeField"); }
		return;

	}
	// $ANTLR end "typeField"


	partial void Enter_variableDeclaration();
	partial void Leave_variableDeclaration();

	// $ANTLR start "variableDeclaration"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:109:1: variableDeclaration : ( Var ID Assign expr_or | Var ID TwoDots ID Assign expr_or );
	[GrammarRule("variableDeclaration")]
	private void variableDeclaration()
	{
		Enter_variableDeclaration();
		EnterRule("variableDeclaration", 19);
		TraceIn("variableDeclaration", 19);
		try { DebugEnterRule(GrammarFileName, "variableDeclaration");
		DebugLocation(109, 36);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:109:21: ( Var ID Assign expr_or | Var ID TwoDots ID Assign expr_or )
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
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:109:23: Var ID Assign expr_or
				{
				DebugLocation(109, 23);
				Match(input,Var,Follow._Var_in_variableDeclaration1045); if (state.failed) return;
				DebugLocation(109, 27);
				Match(input,ID,Follow._ID_in_variableDeclaration1047); if (state.failed) return;
				DebugLocation(109, 30);
				Match(input,Assign,Follow._Assign_in_variableDeclaration1049); if (state.failed) return;
				DebugLocation(109, 37);
				PushFollow(Follow._expr_or_in_variableDeclaration1051);
				expr_or();
				PopFollow();
				if (state.failed) return;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:110:5: Var ID TwoDots ID Assign expr_or
				{
				DebugLocation(110, 5);
				Match(input,Var,Follow._Var_in_variableDeclaration1059); if (state.failed) return;
				DebugLocation(110, 9);
				Match(input,ID,Follow._ID_in_variableDeclaration1061); if (state.failed) return;
				DebugLocation(110, 12);
				Match(input,TwoDots,Follow._TwoDots_in_variableDeclaration1063); if (state.failed) return;
				DebugLocation(110, 20);
				Match(input,ID,Follow._ID_in_variableDeclaration1065); if (state.failed) return;
				DebugLocation(110, 23);
				Match(input,Assign,Follow._Assign_in_variableDeclaration1067); if (state.failed) return;
				DebugLocation(110, 30);
				PushFollow(Follow._expr_or_in_variableDeclaration1069);
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
		DebugLocation(110, 36);
		} finally { DebugExitRule(GrammarFileName, "variableDeclaration"); }
		return;

	}
	// $ANTLR end "variableDeclaration"


	partial void Enter_functionDeclaration();
	partial void Leave_functionDeclaration();

	// $ANTLR start "functionDeclaration"
	// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:111:1: functionDeclaration : Function ID LParent typeFields RParent ( TwoDots ID )? Equals expr ;
	[GrammarRule("functionDeclaration")]
	private void functionDeclaration()
	{
		Enter_functionDeclaration();
		EnterRule("functionDeclaration", 20);
		TraceIn("functionDeclaration", 20);
		try { DebugEnterRule(GrammarFileName, "functionDeclaration");
		DebugLocation(111, 86);
		try
		{
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:111:21: ( Function ID LParent typeFields RParent ( TwoDots ID )? Equals expr )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:111:23: Function ID LParent typeFields RParent ( TwoDots ID )? Equals expr
			{
			DebugLocation(111, 23);
			Match(input,Function,Follow._Function_in_functionDeclaration1076); if (state.failed) return;
			DebugLocation(111, 32);
			Match(input,ID,Follow._ID_in_functionDeclaration1078); if (state.failed) return;
			DebugLocation(111, 35);
			Match(input,LParent,Follow._LParent_in_functionDeclaration1080); if (state.failed) return;
			DebugLocation(111, 43);
			PushFollow(Follow._typeFields_in_functionDeclaration1082);
			typeFields();
			PopFollow();
			if (state.failed) return;
			DebugLocation(111, 54);
			Match(input,RParent,Follow._RParent_in_functionDeclaration1084); if (state.failed) return;
			DebugLocation(111, 62);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:111:62: ( TwoDots ID )?
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
				// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:111:63: TwoDots ID
				{
				DebugLocation(111, 63);
				Match(input,TwoDots,Follow._TwoDots_in_functionDeclaration1087); if (state.failed) return;
				DebugLocation(111, 71);
				Match(input,ID,Follow._ID_in_functionDeclaration1089); if (state.failed) return;

				}
				break;

			}
			} finally { DebugExitSubRule(25); }

			DebugLocation(111, 76);
			Match(input,Equals,Follow._Equals_in_functionDeclaration1093); if (state.failed) return;
			DebugLocation(111, 83);
			PushFollow(Follow._expr_in_functionDeclaration1095);
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
		DebugLocation(111, 86);
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
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:85:59: ( LCorch expr_or RCorch Of )
			DebugEnterAlt(1);
			// C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\Tiger.g:85:60: LCorch expr_or RCorch Of
			{
			DebugLocation(85, 60);
			Match(input,LCorch,Follow._LCorch_in_synpred1_Tiger729); if (state.failed) return;
			DebugLocation(85, 67);
			PushFollow(Follow._expr_or_in_synpred1_Tiger731);
			expr_or();
			PopFollow();
			if (state.failed) return;
			DebugLocation(85, 75);
			Match(input,RCorch,Follow._RCorch_in_synpred1_Tiger733); if (state.failed) return;
			DebugLocation(85, 82);
			Match(input,Of,Follow._Of_in_synpred1_Tiger735); if (state.failed) return;

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

		public override string Description { get { return "85:6: ( ( LParent exprList RParent | LKey fieldList RKey )? | ( LCorch expr_or RCorch Of )=> ( LCorch expr_or RCorch Of expr_or ) | ( lvalue ( Assign expr_or )? ) )"; } }

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
		public static readonly BitSet _expr_or_in_program534 = new BitSet(new ulong[]{0x0UL});
		public static readonly BitSet _EOF_in_program536 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expr_and_in_expr_or543 = new BitSet(new ulong[]{0x2000000002UL});
		public static readonly BitSet _Or_in_expr_or546 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _expr_and_in_expr_or548 = new BitSet(new ulong[]{0x2000000002UL});
		public static readonly BitSet _expr_logical_in_expr_and556 = new BitSet(new ulong[]{0x1000000002UL});
		public static readonly BitSet _And_in_expr_and559 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _expr_logical_in_expr_and561 = new BitSet(new ulong[]{0x1000000002UL});
		public static readonly BitSet _expr_arithm_in_expr_logical571 = new BitSet(new ulong[]{0xFC0000002UL});
		public static readonly BitSet _Equals_in_expr_logical581 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _NotEquals_in_expr_logical586 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _GThan_in_expr_logical590 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _LThan_in_expr_logical594 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _GEThan_in_expr_logical598 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _LEThan_in_expr_logical602 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _expr_arithm_in_expr_logical606 = new BitSet(new ulong[]{0xFC0000002UL});
		public static readonly BitSet _expr_factor_in_expr_arithm619 = new BitSet(new ulong[]{0x8000022UL});
		public static readonly BitSet _Plus_in_expr_arithm624 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _Minus_in_expr_arithm629 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _expr_factor_in_expr_arithm632 = new BitSet(new ulong[]{0x8000022UL});
		public static readonly BitSet _expr_in_expr_factor642 = new BitSet(new ulong[]{0x30000002UL});
		public static readonly BitSet _Mult_in_expr_factor647 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _Div_in_expr_factor652 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _expr_in_expr_factor655 = new BitSet(new ulong[]{0x30000002UL});
		public static readonly BitSet _STRING_CONST_in_expr664 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _INT_CONST_in_expr670 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _NIL_in_expr676 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _Minus_in_expr682 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _expr_in_expr684 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_expr706 = new BitSet(new ulong[]{0x4000AC2UL});
		public static readonly BitSet _LParent_in_expr710 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _exprList_in_expr712 = new BitSet(new ulong[]{0x100UL});
		public static readonly BitSet _RParent_in_expr714 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LKey_in_expr718 = new BitSet(new ulong[]{0x20000001000000UL});
		public static readonly BitSet _fieldList_in_expr720 = new BitSet(new ulong[]{0x1000UL});
		public static readonly BitSet _RKey_in_expr722 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LCorch_in_expr741 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _expr_or_in_expr743 = new BitSet(new ulong[]{0x400UL});
		public static readonly BitSet _RCorch_in_expr745 = new BitSet(new ulong[]{0x200000000000UL});
		public static readonly BitSet _Of_in_expr747 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _expr_or_in_expr749 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _lvalue_in_expr755 = new BitSet(new ulong[]{0x42UL});
		public static readonly BitSet _Assign_in_expr758 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _expr_or_in_expr760 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LParent_in_expr771 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _exprSeq_in_expr773 = new BitSet(new ulong[]{0x100UL});
		public static readonly BitSet _RParent_in_expr775 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _If_in_expr784 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _expr_or_in_expr786 = new BitSet(new ulong[]{0x4000UL});
		public static readonly BitSet _Then_in_expr788 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _expr_or_in_expr790 = new BitSet(new ulong[]{0x8002UL});
		public static readonly BitSet _Else_in_expr793 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _expr_or_in_expr795 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _While_in_expr807 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _expr_or_in_expr809 = new BitSet(new ulong[]{0x40000UL});
		public static readonly BitSet _Do_in_expr811 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _expr_or_in_expr813 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _For_in_expr821 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _ID_in_expr823 = new BitSet(new ulong[]{0x40UL});
		public static readonly BitSet _Assign_in_expr825 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _expr_or_in_expr827 = new BitSet(new ulong[]{0x100000UL});
		public static readonly BitSet _To_in_expr829 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _expr_or_in_expr831 = new BitSet(new ulong[]{0x40000UL});
		public static readonly BitSet _Do_in_expr833 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _expr_or_in_expr835 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _Break_in_expr843 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _Let_in_expr852 = new BitSet(new ulong[]{0x64000000000UL});
		public static readonly BitSet _declarationList_in_expr854 = new BitSet(new ulong[]{0x200000UL});
		public static readonly BitSet _In_in_expr856 = new BitSet(new ulong[]{0x30800000CB20B0UL});
		public static readonly BitSet _exprSeq_in_expr859 = new BitSet(new ulong[]{0x400000UL});
		public static readonly BitSet _End_in_expr863 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expr_or_in_exprSeq872 = new BitSet(new ulong[]{0x2000002UL});
		public static readonly BitSet _DotComma_in_exprSeq875 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _expr_or_in_exprSeq877 = new BitSet(new ulong[]{0x2000002UL});
		public static readonly BitSet _expr_or_in_exprList885 = new BitSet(new ulong[]{0x1000002UL});
		public static readonly BitSet _Comma_in_exprList888 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _expr_or_in_exprList890 = new BitSet(new ulong[]{0x1000002UL});
		public static readonly BitSet _idAssign_in_fieldList899 = new BitSet(new ulong[]{0x1000002UL});
		public static readonly BitSet _Comma_in_fieldList902 = new BitSet(new ulong[]{0x20000001000000UL});
		public static readonly BitSet _idAssign_in_fieldList904 = new BitSet(new ulong[]{0x1000002UL});
		public static readonly BitSet _ID_in_idAssign913 = new BitSet(new ulong[]{0x40000000UL});
		public static readonly BitSet _Equals_in_idAssign915 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _expr_or_in_idAssign917 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _Dot_in_lvalue927 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _ID_in_lvalue929 = new BitSet(new ulong[]{0x4000202UL});
		public static readonly BitSet _LCorch_in_lvalue933 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _expr_or_in_lvalue935 = new BitSet(new ulong[]{0x400UL});
		public static readonly BitSet _RCorch_in_lvalue937 = new BitSet(new ulong[]{0x4000202UL});
		public static readonly BitSet _declaration_in_declarationList947 = new BitSet(new ulong[]{0x64000000002UL});
		public static readonly BitSet _typeDeclaration_in_declaration955 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _variableDeclaration_in_declaration963 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _functionDeclaration_in_declaration971 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _Type_in_typeDeclaration978 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _ID_in_typeDeclaration980 = new BitSet(new ulong[]{0x40000000UL});
		public static readonly BitSet _Equals_in_typeDeclaration982 = new BitSet(new ulong[]{0x20008000000800UL});
		public static readonly BitSet _type_in_typeDeclaration984 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_type991 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LKey_in_type998 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _typeFields_in_type1000 = new BitSet(new ulong[]{0x1000UL});
		public static readonly BitSet _RKey_in_type1002 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ArrayOf_in_type1009 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _ID_in_type1011 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _typeField_in_typeFields1019 = new BitSet(new ulong[]{0x1000002UL});
		public static readonly BitSet _Comma_in_typeFields1022 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _typeField_in_typeFields1024 = new BitSet(new ulong[]{0x1000002UL});
		public static readonly BitSet _ID_in_typeField1033 = new BitSet(new ulong[]{0x10000000000UL});
		public static readonly BitSet _TwoDots_in_typeField1035 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _ID_in_typeField1037 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _Var_in_variableDeclaration1045 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _ID_in_variableDeclaration1047 = new BitSet(new ulong[]{0x40UL});
		public static readonly BitSet _Assign_in_variableDeclaration1049 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _expr_or_in_variableDeclaration1051 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _Var_in_variableDeclaration1059 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _ID_in_variableDeclaration1061 = new BitSet(new ulong[]{0x10000000000UL});
		public static readonly BitSet _TwoDots_in_variableDeclaration1063 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _ID_in_variableDeclaration1065 = new BitSet(new ulong[]{0x40UL});
		public static readonly BitSet _Assign_in_variableDeclaration1067 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _expr_or_in_variableDeclaration1069 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _Function_in_functionDeclaration1076 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _ID_in_functionDeclaration1078 = new BitSet(new ulong[]{0x80UL});
		public static readonly BitSet _LParent_in_functionDeclaration1080 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _typeFields_in_functionDeclaration1082 = new BitSet(new ulong[]{0x100UL});
		public static readonly BitSet _RParent_in_functionDeclaration1084 = new BitSet(new ulong[]{0x10040000000UL});
		public static readonly BitSet _TwoDots_in_functionDeclaration1087 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _ID_in_functionDeclaration1089 = new BitSet(new ulong[]{0x40000000UL});
		public static readonly BitSet _Equals_in_functionDeclaration1093 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _expr_in_functionDeclaration1095 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _LCorch_in_synpred1_Tiger729 = new BitSet(new ulong[]{0x308000008B20B0UL});
		public static readonly BitSet _expr_or_in_synpred1_Tiger731 = new BitSet(new ulong[]{0x400UL});
		public static readonly BitSet _RCorch_in_synpred1_Tiger733 = new BitSet(new ulong[]{0x200000000000UL});
		public static readonly BitSet _Of_in_synpred1_Tiger735 = new BitSet(new ulong[]{0x2UL});

	}
	#endregion Follow sets
}
