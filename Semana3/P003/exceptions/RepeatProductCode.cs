namespace P003.Exceptions;

public class RepeatProductCode : Exception {
    public RepeatProductCode(string message) : base(message){}
}