public class Day2 {


    const int maxRed = 12;
    const int maxGreen = 13;
    const int maxBlue = 14;

    public void SolvePartOne(string[] input){

        // Helper.PrintWordArray(input);

        var TotalSum = 0;


        foreach(var line in input){

            var FirstSplit = line.Split(":");

            var GamePart = FirstSplit[0];

            var GameAndIdSektion = GamePart.Split(" ");

            var GameId = GameAndIdSektion[1];

            // Console.WriteLine(GameId);

            var Draws = FirstSplit[1];

            var DrawArray = Draws.Split(";");

            var DrawResultList = new List<DrawResult>();

            foreach(var draw in DrawArray){

                var Draw = GetResultFromDraw(draw.Trim());

                DrawResultList.Add(Draw);

                // Console.WriteLine("Red: " + Draw.Red + " Green: " + Draw.Green + " Blue: " +Draw.Blue);

            }

            var GameValid = true;

            foreach(var drawResult in DrawResultList){
                if(CheckIfDrawIsFalid(drawResult) == false){
                    GameValid = false;
                    break;
                }
            }

            if(GameValid == true){
                TotalSum += int.Parse(GameId);
            }

        }
        
        Console.WriteLine(TotalSum);

    }


    public void SolvePartTwo(string[] input){

        var TotalSum = 0;


        foreach(var line in input){

            var FirstSplit = line.Split(":");

            var GamePart = FirstSplit[0];

            var GameAndIdSektion = GamePart.Split(" ");

            var GameId = GameAndIdSektion[1];

            // Console.WriteLine(GameId);

            var Draws = FirstSplit[1];

            var DrawArray = Draws.Split(";");

            var DrawResultList = new List<DrawResult>();

            var maxRed = 0;
            var maxGreen = 0;
            var maxBlue = 0;

            foreach(var draw in DrawArray){

                var Draw = GetResultFromDraw(draw.Trim());

                DrawResultList.Add(Draw);

                // Console.WriteLine("Red: " + Draw.Red + " Green: " + Draw.Green + " Blue: " +Draw.Blue);

            }

            foreach(var drawResult in DrawResultList){

                if(drawResult.Red > maxRed)
                    maxRed = drawResult.Red;

                if(drawResult.Green > maxGreen)
                    maxGreen = drawResult.Green;

                if(drawResult.Blue > maxBlue)
                    maxBlue = drawResult.Blue;
               
            }

           
            var multipliedMaxValues = maxRed * maxGreen * maxBlue;

            Console.WriteLine(multipliedMaxValues);

            TotalSum += multipliedMaxValues;

        }
        
        Console.WriteLine("------");

        Console.WriteLine(TotalSum);

    }

    private DrawResult GetResultFromDraw(string drawAsString){
        
        var RetVal = new DrawResult();

        var Sektions = drawAsString.Split(",");

        foreach(var sektion in Sektions){

            var TrimedSektion = sektion.Trim();

            var Parts = TrimedSektion.Split(" ");

            var numberCubes = Parts[0];

            var ColorString = Parts[1];

            if(ColorString.Equals("red")){
                RetVal.Red = int.Parse(numberCubes);
            }
            if(ColorString.Equals("green")){
                RetVal.Green = int.Parse(numberCubes);
            }
            if(ColorString.Equals("blue")){
                RetVal.Blue = int.Parse(numberCubes);
            }

        }

        return RetVal;

    }

    private bool CheckIfDrawIsFalid(DrawResult Draw){

        var retVal = true;

        if(Draw.Red > maxRed)
            retVal = false;

        if(Draw.Green > maxGreen)
            retVal = false;

        if(Draw.Blue > maxBlue)
            retVal = false;

        return retVal;


    }

}


public class DrawResult{

    public int Red {get; set;} = 0;
    public int Green {get;set;}= 0;

    public int Blue {get;set;}= 0;

    public DrawResult(){}

}