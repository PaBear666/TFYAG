using System;
using System.Collections.Generic;
using System.Text;

namespace TFYAG
{
    class Result
    {
        public int ErrPosition { get; private set; }
        private Errors Err { get; set; }
        public string ResultString { get; private set; }

        public Result(int errPosition,Errors err)
        {
            ErrPosition = errPosition;
            Err = err;
        }

        public Result(int errPosition,Errors err,string resultString) : this(errPosition, err)
        {
            ResultString = resultString;
        }
        public string ErrMessage()
        {
            switch (Err)
            {
                case Errors.NoError:
                    return "Нет Ошибок";

                case Errors.OutOfRange:
                    return "Выход за границы";

                case Errors.LetterExpected:
                    return "Ожидается буква";

                case Errors.LetterDigitExpected:
                    return "Ожидается буква или цифра";

                case Errors.FExpected:
                    return "Ожидается символ F";

                case Errors.OExpected:
                    return "Ожидается символ O";

                case Errors.RExpected:
                    return "Ожидается символ R";

                case Errors.MExpected:
                    return "Ожидается символ M";

                case Errors.AExpected:
                    return "Ожидается символ A";

                case Errors.TExpected:
                    return "Ожидается символ T";

                case Errors.OpenBracketExpected:
                    return "Ожидается символ (";

                case Errors.CloseBracketExpected:
                    return "Ожидается символ )";

                case Errors.XExpected:
                    return "Ожидается символ X";

                case Errors.EExcpected:
                    return "Ожидается символ E";

                case Errors.NumberExpected:
                    return "Ожидается цифра";

                case Errors.SExpected:
                    return "Ожидается символ S";

                case Errors.KExpected:
                    return "Ожидается символ K";

                case Errors.PExpected:
                    return "Ожидается символ P";

                case Errors.IExpected:
                    return "Ожидается символ I";

                case Errors.KeyWord:
                    return "Ожидается начало ключевого слова";

                case Errors.UnrecognizedError:
                    return "Неизвествная ошибка ";

                case Errors.OutOfBoundsParameter:
                    return "Превышение значения параметра";

                case Errors.CommaExpected:
                    return "Ожидается ,";
                case Errors.SpaceExpected:
                    return "Ожидается пробел";

                case Errors.SpaceOrCommaExpected:
                    return "Ожидается пробел или ,";
                case Errors.SymbolOrCommaExpected:
                    return "Ожидается символ или ,";
                case Errors.NumberOrCommeExected:
                    return "Ожидается цифра или ,";
                case Errors.OpenBracketOrCommaExpected:
                    return "Ожидается ( или ,";
                case Errors.CloseBracketOrCommaExpected:
                    return "Ожидается ) или запятая";
                case Errors.NumberOrOpenBracketExpected:
                    return "Ожидается ( или цифра";
                case Errors.SymbolOrOpenBracketExpected:
                    return "Ожидается ( или символ";
                case Errors.KeyCharOrCommaExpected:
                    return "Ожидается Ключевое слвоо или ,";
                case Errors.ExpectedConitnued:
                    return "Ожидается продолжение ввода";

                case Errors.EXpectedOpenBracketOrClosedBracketOrComma:
                    return "Ожидается ) или ( или ,";
                default:
                    return "Неизвестная ошибка";
            }
        }
    }
}
