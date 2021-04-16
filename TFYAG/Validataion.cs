using System;
using System.Collections.Generic;
using System.Text;

namespace TFYAG
{
    static class Validataion
    {
        private static readonly Func<string, bool> conditionDefault = (x) => (int.Parse(x) < 32767); 
        private enum State
        {
            Start,
            Error,
            Final,
            A0,
            A1,
            A2,
            A3,
            A4,
            A5,
            A6,
            A,
            C0,
            C,
            O0,
            O1,
            O2,
            O,
            G,
            L0,
            L,
            J1,
            J2,
            Q,
            B0,
            B,
            J0,
            J3,
            Q1,
            M,
            J4,

        }
        private static string Str { get; set; }
        private static string ResultStr { get; set; }
        private static Errors Err { get; set; }
        private static int ErrPos { get; set; }
        private static bool Function()
        {
            Func<int, string> operations1T = null;
            Func<int, int, string> operations2T = null;
            string memory = "";
            string memory1 = "";
            Func<string, bool> condition = null;
            int pos = 0;
            State state = State.Start;
            while(state != State.Error && state != State.Final)
            {

                if (pos >= Str.Length)
                {
                    SetError(Errors.ExpectedConitnued, -1, out state);
                }
                else
                {
                    switch (state)
                    {
                        case State.A:
                            switch (Str[pos])
                            {
                                case ' ':
                                    break;
                                case 'A':
                                    state = State.C0;
                                    condition = (x) => (int.Parse(x) <= 50);
                                    operations1T = ResultBack.A;
                                    operations2T = null;
                                    break;
                                case 'X':
                                    state = State.C0;
                                    condition = conditionDefault;
                                    operations1T = ResultBack.X;
                                    operations2T = null;
                                    break;
                                case 'S':
                                    condition = (x) => (int.Parse(x) <= 3);
                                    state = State.O0;
                                    operations1T = ResultBack.Skip;
                                    operations2T = null;
                                    break;
                                case 'E':
                                    condition = (x) => (int.Parse(x) <= 33);
                                    state = State.L0;
                                    operations2T = ResultBack.E;
                                    operations1T = null;
                                    break;
                                case 'F':
                                    condition = (x) => (int.Parse(x) <= 33);
                                    state = State.B0;
                                    operations2T = ResultBack.F;
                                    operations1T = ResultBack.F;
                                    break;
                                default:
                                    SetError(Errors.KeyWord, pos, out state);
                                    break;
                            }
                            break;
                        case State.Start:
                            switch (Str[pos])
                            {
                                case ' ':
                                    break;
                                case 'F':
                                    state = State.A0;
                                    break;
                                default:
                                    SetError(Errors.FExpected, pos, out state);
                                    break;
                            }
                            break;
                        case State.Error:
                            break;
                        case State.Final:
                            break;
                        case State.A0:
                            switch (Str[pos])
                            {
                                case 'O':
                                    state = State.A1;
                                    break;
                                default:
                                    SetError(Errors.OExpected, pos, out state);
                                    break;
                            }
                            break;
                        case State.A1:
                            switch (Str[pos])
                            {
                                case 'R':
                                    state = State.A2;
                                    break;
                                default:
                                    SetError(Errors.RExpected, pos, out state);
                                    break;
                            }
                            break;
                        case State.A2:
                            switch (Str[pos])
                            {
                                case 'M':
                                    state = State.A3;
                                    break;
                                default:
                                    SetError(Errors.MExpected, pos, out state);
                                    break;
                            }
                            break;
                        case State.A3:
                            switch (Str[pos])
                            {
                                case 'A':
                                    state = State.A4;
                                    break;
                                default:
                                    SetError(Errors.AExpected, pos, out state);
                                    break;
                            }
                            break;
                        case State.A4:
                            switch (Str[pos])
                            {
                                case 'T':
                                    state = State.A5;
                                    break;
                                default:
                                    SetError(Errors.TExpected, pos, out state);
                                    break;
                            }
                            break;
                        case State.A5:
                            switch (Str[pos])
                            {
                                case ' ':
                                    state = State.A6;
                                    break;
                                default:
                                    SetError(Errors.SpaceExpected, pos, out state);
                                    break;
                            }
                            break;
                        case State.A6:
                            switch (Str[pos])
                            {
                                case ' ':

                                    break;
                                case '(':
                                    state = State.A;
                                    break;
                                default:
                                    SetError(Errors.OpenBracketExpected, pos, out state);
                                    break;
                            }
                            break;
                        case State.C0:
                            switch (Str[pos])
                            {
                                case ' ':
                                    break;
                                case '(':
                                    state = State.C;
                                    break;
                                default:
                                    SetError(Errors.OpenBracketExpected, pos, out state);
                                    break;
                            }
                            break;
                        case State.C:
                            switch (Str[pos])
                            {
                                case ' ':
                                    break;
                                default:
                                    if (char.IsNumber(Str[pos]) && !Str[pos].Equals('0'))
                                    {
                                        memory += Str[pos];
                                        state = State.Q;
                                    }
                                    else
                                    {
                                        SetError(Errors.NumberExpected, pos, out state);
                                    }
                                    break;
                            }
                            break;
                        case State.O0:
                            switch (Str[pos])
                            {
                                case 'K':
                                    state = State.O1;
                                    break;
                                default:
                                    SetError(Errors.KExpected, pos, out state);
                                    break;
                            }
                            break;
                        case State.O1:
                            switch (Str[pos])
                            {
                                case 'I':
                                    state = State.O2;
                                    break;
                                default:
                                    SetError(Errors.IExpected, pos, out state);
                                    break;
                            }
                            break;
                        case State.O2:
                            switch (Str[pos])
                            {
                                case 'P':
                                    state = State.O;
                                    break;
                                default:
                                    SetError(Errors.PExpected, pos, out state);
                                    break;
                            }
                            break;
                        case State.O:
                            switch (Str[pos])
                            {
                                case ' ':
                                    break;
                                case ')':
                                    state = State.Final;
                                    ResultStr += operations1T(int.Parse("1"));
                                    break;
                                case '(':
                                    state = State.G;
                                    break;
                                case ',':
                                    ResultStr += operations1T(int.Parse("1"));
                                    state = State.A;
                                    break;
                                default:
                                    SetError(Errors.EXpectedOpenBracketOrClosedBracketOrComma, pos, out state);
                                    break;
                            }
                            break;
                        case State.G:
                            switch (Str[pos])
                            {
                                case ' ':
                                    break;
                                default:
                                    if (char.IsNumber(Str[pos]) && !Str[pos].Equals('0'))
                                    {
                                        memory += Str[pos];
                                        if (!condition(memory))
                                        {
                                            SetError(Errors.OutOfBoundsParameter, pos, out state);
                                        }
                                        else
                                        {
                                            state = State.Q;
                                        }
                                        
                                    }
                                    else
                                    {
                                        SetError(Errors.NumberExpected, pos, out state);
                                    }
                                    break;
                            }
                            break;
                        case State.L0:
                            switch (Str[pos])
                            {
                                case ' ':
                                    break;
                                case '(':
                                    state = State.L;
                                    break;
                                default:
                                    SetError(Errors.OpenBracketExpected, pos, out state);
                                    break;
                            }
                            break;
                        case State.L:
                            switch (Str[pos])
                            {
                                case ' ':
                                    break;
                                default:
                                    if (char.IsNumber(Str[pos]) && !Str[pos].Equals('0'))
                                    {
                                        memory += Str[pos];
                                        state = State.J1;
                                    }
                                    else
                                    {
                                        SetError(Errors.NumberExpected, pos, out state);
                                    }
                                    break;
                            }
                            break;
                        case State.J1:
                            switch (Str[pos])
                            {
                                case ' ':
                                    state = State.J4;
                                    break;
                                case ',':
                                    state = State.J2;
                                    condition = (x) => (int.Parse(x) <= 3);
                                    break;
                                default:
                                    if (char.IsNumber(Str[pos]))
                                    {
                                        memory += Str[pos];
                                        
                                        if (!condition(memory))
                                        {
                                            SetError(Errors.OutOfBoundsParameter, pos, out state);
                                        }
                                        else
                                        {
                                            state = State.J1;
                                        }
                                    }
                                    else
                                    {
                                        SetError(Errors.NumberExpected, pos, out state);
                                    }
                                    break;
                            }
                            break;
                        case State.J2:
                            switch (Str[pos])
                            {
                                case ' ':
                                    break;
                                default:
                                    if (char.IsNumber(Str[pos]) && !Str[pos].Equals('0'))
                                    {
                                        memory1 += Str[pos];
                                        if (!condition(memory1))
                                        {
                                            SetError(Errors.OutOfBoundsParameter, pos, out state);
                                        }
                                        else
                                        {
                                            state = State.Q;
                                        }
                                        
                                    }
                                    else
                                    {
                                        SetError(Errors.NumberExpected, pos, out state);
                                    }
                                    break;
                            }
                            break;
                        case State.Q:
                            switch (Str[pos])
                            {
                                case ' ':
                                    state = State.Q1;
                                    break;
                                case ')':
                                    state = State.M;
                                    ResultStr += operations1T?.Invoke(int.Parse(memory));
                                    ResultStr += operations2T?.Invoke(int.Parse(memory), int.Parse(memory1));
                                    memory = "";
                                    memory1 = "";
                                    break;
                                default:
                                    if (char.IsNumber(Str[pos]))
                                    {
                                        if (operations1T != null)
                                        {
                                            memory += Str[pos];
                                            if (!condition(memory))
                                            {
                                                SetError(Errors.OutOfBoundsParameter, pos, out state);
                                            }
                                        }
                                        else if (operations2T != null)
                                        {
                                            memory1 += Str[pos];
                                            if (!condition(memory1))
                                            {
                                                SetError(Errors.OutOfBoundsParameter, pos, out state);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        SetError(Errors.CloseBracketExpected, pos, out state);
                                    }
                                    break;
                            }
                            break;
                        case State.B0:
                            switch (Str[pos])
                            {
                                case ' ':
                                    break;
                                case '(':
                                    state = State.B;
                                    break;
                                default:
                                    SetError(Errors.OpenBracketExpected, pos, out state);
                                    break;
                            }
                            break;
                        case State.B:
                            switch (Str[pos])
                            {
                                case ' ':
                                    break;
                                default:
                                    if (char.IsNumber(Str[pos]) && !Str[pos].Equals('0'))
                                    {
                                        memory += Str[pos];
                                        if (!condition(memory))
                                        {
                                            SetError(Errors.OutOfBoundsParameter, pos, out state);
                                        }
                                        else
                                        {
                                            state = State.J0;
                                        }
                                    }
                                    else
                                    {
                                        SetError(Errors.NumberExpected, pos, out state);
                                    }
                                    break;
                            }
                            break;
                        case State.J0:
                            switch (Str[pos])
                            {
                                case ' ':
                                    state = State.J3;
                                    break;
                                case ')':
                                    state = State.M;
                                    operations2T = null;
                                    ResultStr += ResultBack.F(int.Parse(memory));
                                    memory = "";
                                    break;
                                case ',':
                                    state = State.J2;
                                    condition = (x) => (int.Parse(x) < 32);
                                    operations1T = null;
                                    break;
                                default:
                                    if (char.IsNumber(Str[pos]))
                                    {

                                        memory += Str[pos];
                                        if (!condition(memory))
                                        {
                                            SetError(Errors.OutOfBoundsParameter, pos, out state);
                                        }
                                    }
                                    else
                                    {
                                        SetError(Errors.OpenBracketOrCommaExpected, pos, out state);
                                    }
                                    break;
                            }
                            break;
                        case State.J3:
                            switch (Str[pos])
                            {
                                case ' ':
                                    break;
                                case ',':
                                    state = State.J2;
                                    condition = (x) => (int.Parse(x) < 32);
                                    operations1T = null;
                                    break;
                                case ')':
                                    state = State.M;
                                    operations2T = null;
                                    break;
                                default:
                                    SetError(Errors.CloseBracketOrCommaExpected, pos, out state);
                                    break;
                            }
                            break;
                        case State.Q1:
                            switch (Str[pos])
                            {
                                case ' ':
                                    break;
                                case ')':
                                    state = State.M;
                                    break;
                                default:
                                    SetError(Errors.CloseBracketExpected, pos, out state);
                                    break;
                            }
                            break;
                        case State.M:
                            switch (Str[pos])
                            {
                                case ' ':
                                    break;
                                case ')':
                                    state = State.Final;
                                    break;
                                case ',':
                                    state = State.A;
                                    break;
                                default:
                                    SetError(Errors.CloseBracketOrCommaExpected ,pos, out state);
                                    break;
                            }
                            break;
                        case State.J4:
                            switch (Str[pos])
                            {
                                case ' ':
                                    break;
                                case ',':
                                    state = State.J2;
                                    condition = (x) => (int.Parse(x) <= 3);
                                    memory = "";
                                    break;
                                default:
                                    SetError(Errors.CommaExpected, pos, out state);
                                    break;
                            }
                            break;
                        default:
                            return false;
                    }
                    pos++;
                }
            }
            return state == State.Final;
        }
        private static void SetError(Errors errors,int errorPos,out State state)
        {
            Err = errors;
            ErrPos = errorPos;
            state = State.Error;
        }

        public static Result Check(string InputString)
        {
            ResultStr = "";
            Str = InputString;
            Err = Errors.NoError;
            ErrPos = -1;
            Function();
            if (Err == Errors.NoError)
            {
                return new Result(ErrPos, Err,ResultStr);
            }
            else
            {
                return new Result(ErrPos, Err,"");
            }
        }

    }

    public enum Errors
    {
        /// <summary>
        /// нет ошибок
        /// </summary>
        NoError,
        /// <summary>
        /// выход за границы анализируемой строки
        /// </summary>
        OutOfRange,
        /// <summary>
        /// ожидается буква
        /// </summary>
        LetterExpected,
        /// <summary>
        /// ожидается буква или цифра
        /// </summary>
        LetterDigitExpected,
        /// <summary>
        /// неизвестная ошибка
        /// </summary>
        UnrecognizedError,
        FExpected,
        OExpected,
        RExpected,
        MExpected,
        AExpected,
        TExpected,
        OpenBracketExpected,
        CloseBracketExpected,
        XExpected,
        EExcpected,
        NumberExpected,
        SExpected,
        KExpected,
        PExpected,
        IExpected,
        KeyWord,
        OutOfBoundsParameter,
        CommaExpected,
        SpaceExpected,
        SpaceOrCommaExpected,
        SymbolOrCommaExpected,
        NumberOrCommeExected,
        OpenBracketOrCommaExpected,
        CloseBracketOrCommaExpected,
        NumberOrOpenBracketExpected,
        SymbolOrOpenBracketExpected,
        KeyCharOrCommaExpected,
        ExpectedConitnued,
        EXpectedOpenBracketOrClosedBracketOrComma

    }
}
