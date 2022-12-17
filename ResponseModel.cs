public record ResponseModel<T> : IResponse<T>
{
    public ResponseModel(bool success, T data)
    {
        Success = success;
        Data = data;
    }
    
    public ResponseModel(bool success, string error)
    {
        Success = success;
        Error = error;
    }

    public ResponseModel(bool success, T data, string error)
    {
        Success = success;
        Data = data;
        Error = error;
    }

    public bool Success { get; init; }
    public string Error { get; init; }
    public T Data { get; init; }
}