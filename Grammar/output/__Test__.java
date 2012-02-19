import java.io.*;
import org.antlr.runtime.*;
import org.antlr.runtime.debug.DebugEventSocketProxy;


public class __Test__ {

    public static void main(String args[]) throws Exception {
        TigerLexer lex = new TigerLexer(new ANTLRFileStream("C:\\HERE\\School\\!4to\\Complementos de Compilacion\\Compilador\\Grammar\\output\\__Test___input.txt", "UTF8"));
        CommonTokenStream tokens = new CommonTokenStream(lex);

        TigerParser g = new TigerParser(tokens, 49100, null);
        try {
            g.INT_CONST();
        } catch (RecognitionException e) {
            e.printStackTrace();
        }
    }
}