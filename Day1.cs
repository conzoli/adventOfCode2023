public class Day1 {

    string[] StringLetters = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

    public void SolvePartOne(string[] input) {

        int TotalSum = 0;

        foreach(var line in input){

             int digitOne = 0;
             int digitTwo = 0;

            foreach(var Char in line){

                if( IsDigit(Char.ToString()) ) {

                    if(digitOne == 0){
                        digitOne = int.Parse(Char.ToString());
                    } else {
                        digitTwo = int.Parse(Char.ToString() );
                    }

                }
               
            }

            if(digitTwo == 0) {
                digitTwo = digitOne;
            }

            var CombinedValueString = digitOne.ToString() + digitTwo.ToString();

            TotalSum += int.Parse(CombinedValueString);

        }

        Console.WriteLine(TotalSum);

    }


    public void SolevePartTwo(string[] input){

        int TotalSum = 0;

        foreach(var line in input){

            int digitOne = 0;
            int digitTwo = 0;

            string wordChunk = "";

            foreach(var Char in line){

                wordChunk = wordChunk + Char;

                if( IsDigit(Char.ToString()) ) {

                    if(digitOne == 0){
                        digitOne = int.Parse(Char.ToString());
                    } else {
                        digitTwo = int.Parse(Char.ToString() );
                    }

                } else {

                    int CheckResult = CheckWordChunkIfContainsNumber(wordChunk);

                    if( CheckResult > 0 ) {

                        if(digitOne == 0) {
                            digitOne = CheckResult;
                        } else {
                            digitTwo = CheckResult;
                        }

                        wordChunk = "" + Char;
                    }
                }
               
            }

            if(digitTwo == 0) {
                digitTwo = digitOne;
            }

            var CombinedValueString = digitOne.ToString() + digitTwo.ToString();

            // Console.WriteLine(CombinedValueString);

            TotalSum += int.Parse(CombinedValueString);

        }

        Console.WriteLine(TotalSum);

    }


    private bool IsDigit(string digit){

        var isNumeric = false;

        int n;
        isNumeric = int.TryParse(digit, out n);

        return isNumeric;

    }

    private int CheckWordChunkIfContainsNumber(string chunk){

        var retVal = -1;

        string value = "";

        if(chunk.Length < 3) {
            return retVal;
        }

        for(int i = 0; i < StringLetters.Length; i++){
            if(chunk.Contains(StringLetters[i])){
                value += (i+1).ToString();
            }
        }

        if(value != ""){
            retVal = int.Parse(value);
        }

        return retVal;

    }

}