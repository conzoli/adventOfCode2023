public static class Helper {

    public static void PrintWordArray(string[] input){
        
        foreach(var line in input){

            string[] words = line.Split(",");

            Console.WriteLine(string.Join(",", words));
        }
    }

}