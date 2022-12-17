public interface IResponse<T>
{
    bool Success { get; set; }
    string Error { get; set; }
    T Data { get; set; }
}