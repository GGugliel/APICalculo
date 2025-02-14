using APICalculo.Model;

namespace APICalculo.Interfaces
{
    public interface IResponseErrors : IResponseErrorsInner
    {
        IResponseErrorsInner? ErrorsInner { get; set; }
    }
}