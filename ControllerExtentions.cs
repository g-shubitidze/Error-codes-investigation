public static class ControllerExtentions
{
    public static async Task<IActionResult> HandleResponse<T, R>(this Controller controller, Func<T, Task<R>> action)
    {
        try
        {
            var result = await action();
            return Ok(new ResponseModel<GENERIC_TYPE>(true, result));
        }
        catch (ValidationException ex)
        {
            return Ok(new ResponseModel<GENERIC_TYPE>(false, "validation message"));
        }
        catch (Exception ex)
        {
            return new StatusCodeResult(StatusCodes.Status500InternalServerError);
        }
    }
}