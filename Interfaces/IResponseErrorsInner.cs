namespace APICalculo.Interfaces
{
    public interface IResponseErrorsInner
    {
        string? CodeError { get; set; }
        string? Message { get; set; }
        string? PxObjClass { get; set; }
        int StatusCode { get; set; }
    }
}