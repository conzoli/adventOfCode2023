
FileReader fr = new FileReader();


//var fileLines = await fr.ReadFileAsync("Input/test.txt");

//Helper.PrintWordArray(fileLines);


// var SampleInputDay1 = await fr.ReadFileAsync("Input/SampleInputDay1.txt");
// var InputDay1 = await fr.ReadFileAsync("Input/InputDay1.txt");

// var SampleInputDay1Part2 = await fr.ReadFileAsync("Input/SampleInputDay1Part2.txt");
// var InputDay1Part2 = await fr.ReadFileAsync("Input/InputDay1Part2.txt");


// Helper.PrintWordArray(SampleInputDay1Part2);


// var day1 = new Day1();

// day1.SolvePartOne(InputDay1);

// day1.SolevePartTwo(InputDay1Part2);



var SampleInputDay2 = await fr.ReadFileAsync("Input/SampleInputDay2Part1.txt");

var InputDay2 = await fr.ReadFileAsync("Input/InputDay2Part1.txt");

var day2 = new Day2();

// day2.SolvePartOne(InputDay2);

day2.SolvePartTwo(InputDay2);

