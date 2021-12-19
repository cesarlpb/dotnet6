public class Program {
public static int exitCode = 0;
public static void Main()
{
    int coverage = CalcCoverage("cobertura.xml");
    if (coverage > 90){
    exitCode = Convert.ToInt32(ExitCode.Success);
    }
    else{
    exitCode = Convert.ToInt32(ExitCode.Failed);
    }
    Environment.ExitCode = exitCode;
}
public static int CalcCoverage(string cobertura){
    // Parse cobertura xml para retornar el valor 
    // Round to int
    return 99;
}
public enum ExitCode : int {
  Success = 0,  // coverage = 100%
  Failed = 1    // coverage below certain %
}
}
