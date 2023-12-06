public class FileReader
{
    public FileReader()
    {
    }

    public async Task<string[]> ReadFileAsync (string fileName)
    {

        var result = new List<string>();

        try
        {

            StreamReader sr = new(fileName);

            string? line;

            if (sr is not null)
            {
                line = await sr.ReadLineAsync();

                while (line != null)
                {

                    result.Add(line);

                    //Read the next line
                    line = await sr.ReadLineAsync();
                }

                //close the file
                sr.Close();

            }

        }
        catch (Exception) { }

        return result.ToArray();

    }

}