using System;
using Microsoft.Identity.Client;

namespace API.Requesthelpers;

public class ApiErrorResponse(int statusCode, string message, string? details)
{
    public int StatusCode { get; set; } = statusCode;
    public string Message { get; set; } = message;
    public string? Details { get; set; } = details;// Optional, for more detailed error messages

}
